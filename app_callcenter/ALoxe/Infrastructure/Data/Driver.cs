using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Data
{
    public class Driver : Staff
    {
        public string level { get; set; }
        public string licenseType { get; set; }
        public string licenseExpiry { get; set; }
        public string status { get; set; }
        public string vehicleType { get; set; }
        public string thoi_gian_tao { get; set; }
        public string thoi_gian_cap_nhat { get; set; }
        public int ma_nguoi_dung { get; set; }
        public Vehicle vehicle { get; set; }

    }
}
