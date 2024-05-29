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
               
            }

        }
    }
}
