using ALoxe.Infrastructure.Model;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using SQLite.CodeFirst;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Reflection.Emit;
using System.Windows.Input;


namespace ALoxe.Infrastructure.DB
{
    [DbConfigurationType(typeof(MyConfiguration))]
    public class AppDBContext : DbContext, IDisposable
    {

        public AppDBContext()
            : base("Data Source=App-data/database/aloxe-app.db;PRAGMA journal_mode = WAL; Version = 3")
        {

            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ModelConfiguration.Configure(modelBuilder);
            var sqliteConnectionInitializer = new MyDbContextInitializer(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public DbSet<Model.Province> Provinces { get; set; }
        public DbSet<Model.District> Districts { get; set; }
        public DbSet<Model.Street> Streets { get; set; }
        public DbSet<Model.UserModel> Users { get; set; }
        public DbSet<Model.UserRemember> UserRemembers { get; set; }
    }
    public class ModelConfiguration
    {
        public static void Configure(DbModelBuilder modelBuilder)
        {
            ConfigureTeamEntity(modelBuilder);
        }

        private static void ConfigureTeamEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Province>().ToTable("Province");
            modelBuilder.Entity<Model.District>().ToTable("District");
            modelBuilder.Entity<Model.Street>().ToTable("Street");
            modelBuilder.Entity<Model.UserModel>().ToTable("User");

            //định nghĩa các quan hệ giữa các bảng
            modelBuilder.Entity<Province>().HasKey(p => p.Id);
            modelBuilder.Entity<District>().HasKey(p => p.Id);
            modelBuilder.Entity<Street>().HasKey(p => p.Id);
            modelBuilder.Entity<UserModel>().HasKey(p => p.Id);

            modelBuilder.Entity<District>()
                .HasRequired<Province>(s => s.Province)
                .WithMany(g => g.Districts)
                .HasForeignKey(s => s.ProvinceId);
            modelBuilder.Entity<Street>()
                .HasRequired<District>(s => s.District)
                .WithMany(g => g.Streets)
                .HasForeignKey(s => s.DistrictId);
        }


    }
    public class MyConfiguration : DbConfiguration, IDbConnectionFactory
    {
        public MyConfiguration()
        {
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);

            var providerServices = (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices));

            SetProviderServices("System.Data.SQLite", providerServices);
            SetProviderServices("System.Data.SQLite.EF6", providerServices);

            SetDefaultConnectionFactory(this);
        }

        public DbConnection CreateConnection(string connectionString)
            => new SQLiteConnection(connectionString);
    }
    public class MyDbContextInitializer : SqliteCreateDatabaseIfNotExists<AppDBContext>
    {
        public MyDbContextInitializer(DbModelBuilder modelBuilder)
        : base(modelBuilder)
        {
        }

        protected override void Seed(AppDBContext context)
        {
            if (!context.Provinces.Any())
            {

                var provinces = JObject.Parse(System.IO.File.ReadAllText("App-data/dist/tinh_tp.json")).ToObject<Dictionary<string, dynamic>>();
                var districts = JObject.Parse(System.IO.File.ReadAllText("App-data/dist/quan_huyen.json")).ToObject<Dictionary<string, dynamic>>();
                var streets = JObject.Parse(System.IO.File.ReadAllText("App-data/dist/xa_phuong.json")).ToObject<Dictionary<string, dynamic>>();
                var pros = provinces.Select(b => new Province()
                {
                    Code = b.Key,
                    Name = b.Value.name,
                    Description = b.Value.name_with_type,
                    Id = int.Parse(b.Key),

                }).ToList();
                var dis = districts.Select(d => new District()
                {
                    Code = d.Key,
                    Name = d.Value.name,
                    Description = d.Value.name_with_type,
                    Id = int.Parse(d.Key),
                    ProvinceId = int.Parse((string)d.Value.parent_code),
                    ProvinceCode = d.Value.parent_code,

                }).ToList();
                var str = streets.Select(s => new Street()
                {
                    Code = s.Key,
                    Name = s.Value.name,
                    Description = s.Value.name_with_type,
                    Id = int.Parse(s.Key),
                    DistrictId = int.Parse((string)s.Value.parent_code),
                    DistrictCode = s.Value.parent_code,
                }).ToList();

                context.Provinces.AddRange(pros);
                context.Districts.AddRange(dis);
                context.Streets.AddRange(str);
                context.SaveChanges();
            }
        }
    }

}
