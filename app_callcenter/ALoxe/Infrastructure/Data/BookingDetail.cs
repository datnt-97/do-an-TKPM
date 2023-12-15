using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Data
{
    public class BookingDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("ten")]
        public string Customer { get; set; }
        [JsonProperty("email")]
        public string CustomerEmail { get; set; }
        [JsonProperty("so_dien_thoai")]
        public string CustomerPhone { get; set; }
        [JsonProperty("pickUpPoint")]
        public string CustomerAddress { get; set; }

        [JsonProperty("dropOffPoint")]
        public string CustomerAddressTo { get; set; }

        [JsonProperty("startTime")]
        public DateTime? Date { get; set; }
        [JsonProperty("vehicleType")]
        public string VehicleType { get; set; }

        [JsonProperty("pickUplongitude")]
        public double? PickUpLongitude { get; set; }
        [JsonProperty("pickUplatitude")]
        public double? PickUpLatitude { get; set; }
        [JsonProperty("dropOfflongitude")]
        public double? DropOffLongitude { get; set; }
        [JsonProperty("dropOfflatitude")]
        public double? DropOffLatitude { get; set; }

        public string VehicleTypeObj
        {
            get
            {
                if (VehicleType == "VIP")
                {
                    return "Xe VIP";
                }
                else if (VehicleType == "FOUR_SEAT")
                {
                    return "Xe 4 chỗ";
                }
                else if (VehicleType == "FIVE_SEAT")
                {
                    return "Xe 5 chỗ";
                }
                else if (VehicleType == "SEVEN_SEAT")
                {
                    return "Xe 7 chỗ";
                }
                else
                {
                    return "Không xác định";
                }
               
            }
        }
    }
}
