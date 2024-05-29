using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Data
{
    public class Staff
    {

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("staffCode")]
        public string StaffCode { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("thoi_gian_tao")]
        public string Thoi_gian_tao { get; set; }
        [JsonProperty("thoi_gian_cap_nhat")]
        public string Thoi_gian_cap_nhat { get; set; }
        [JsonProperty("ma_nguoi_dung")]
        public int Ma_nguoi_dung { get; set; }

        [JsonProperty("user")]
        public User user { get; set; }

    }
}
