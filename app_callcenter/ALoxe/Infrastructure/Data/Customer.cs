using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Data
{
    public class Customer
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("level")]
        public string Level { get; set; }
        [JsonProperty("dob")]
        public string Dob { get; set; }
        [JsonProperty("thoi_gian_tao")]
        public string Thoi_gian_tao { get; set; }
        [JsonProperty("thoi_gian_cap_nhat")]
        public string Thoi_gian_cap_nhat { get; set; }
        [JsonProperty("ma_nguoi_dung")]
        public int Ma_nguoi_dung { get; set; }

        [JsonProperty("user")]
        public User UserObj { get; set; }

    }
}
