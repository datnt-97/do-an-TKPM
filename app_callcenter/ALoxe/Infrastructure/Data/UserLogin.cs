using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Data
{
    internal class UserLogin
    {
        public int userId { get; set; }
        public string accessToken { get; set; }
        public long accessTokenExpiryIn { get; set; }
        public string refreshToken { get; set; }
        public long refreshTokenExpiryIn { get; set; }
        public string role { get; set; }
        public int? customerId { get; set; }
        public int? driverId { get; set; }
        public int? staffId { get; set; }
        public string fullName { get; set; }

    }
}
