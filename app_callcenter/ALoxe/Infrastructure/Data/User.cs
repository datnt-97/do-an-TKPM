using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Data
{
    public class User
    {

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("fullName")]
        public string? FullName { get; set; }
        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }
        [JsonProperty("email")]
        public string? Email { get; set; }
        [JsonProperty("address")]
        public string? Address { get; set; }
        [JsonProperty("role")]
        public string? Role { get; set; }
        [JsonProperty("thoi_gian_tao")]
        public string? Thoi_gian_tao { get; set; }
        [JsonProperty("thoi_gian_cap_nhat")]
        public string? Thoi_gian_cap_nhat { get; set; }

        [JsonProperty("avatar")]
        public string? Avatar { get; set; } = "https://i.pravatar.cc/300";


    }
}
