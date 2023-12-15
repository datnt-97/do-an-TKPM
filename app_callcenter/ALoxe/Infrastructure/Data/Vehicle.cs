using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Data
{
    public class Vehicle
    {
        public int id { get; set; }
        public int driverId { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string licensePlate { get; set; }
        public string image { get; set; }
        public string thoi_gian_tao { get; set; }
        public string thoi_gian_cap_nhat { get; set; }
        public int ma_tai_xe { get; set; }

        public enum VehicleType
        {
            VIP, FOUR_SEAT, FIVE_SEAT, SEVEN_SEAT
        }

    }
}
