using ALoxe.Infrastructure.DB;
using ALoxe.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALoxe.Migrations.DataSeeder
{
    public static class DataSeeder
    {
        public static void SeedData()
        {
            using (var context = new AppDBContext())
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
}
