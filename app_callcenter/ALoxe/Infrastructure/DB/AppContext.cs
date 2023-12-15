using ALoxe.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.DB
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=App-data/database/app.db", (ac) =>
            {
            });
            optionsBuilder.ConfigureWarnings(x => x.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.AmbientTransactionWarning));
            //SQLitePCL.Batteries.Init();
        }

        public DbSet<Model.Province> Provinces { get; set; }
        public DbSet<Model.District> Districts { get; set; }
        public DbSet<Model.Street> Streets { get; set; }
        public DbSet<Model.UserModel> Users { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
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

            modelBuilder.Entity<Model.District>()
                .HasOne<Model.Province>(s => s.Province)
                .WithMany(g => g.Districts)
                .HasForeignKey(s => s.ProvinceId);
            modelBuilder.Entity<Model.Street>()
                .HasOne<Model.District>(s => s.District)
                .WithMany(g => g.Streets)
                .HasForeignKey(s => s.DistrictId);
          


        }
        //seed data cho bảng Provinc, District, Street
       
    }
}
