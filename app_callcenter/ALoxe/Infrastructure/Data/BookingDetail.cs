using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [JsonProperty("pickupLocation")]
        public string CustomerAddress { get; set; }

        [JsonProperty("returnLocation")]
        public string CustomerAddressTo { get; set; }

        [JsonProperty("startTime")]
        public DateTime? Date { get; set; }
        [JsonProperty("vehicleType")]
        public int VehicleType { get; set; }

        [JsonProperty("pickupLongitude")]
        public double? PickUpLongitude { get; set; }
        [JsonProperty("pickupLatitude")]
        public double? PickUpLatitude { get; set; }
        [JsonProperty("returnLongitude")]
        public double? DropOffLongitude { get; set; }
        [JsonProperty("returnLatitude")]
        public double? DropOffLatitude { get; set; }

        public string VehicleTypeObj
        {
            get
            {
                var type = (Vehicle.VehicleType)VehicleType;
                //get attribute display name of enum
                var memInfo = typeof(Vehicle.VehicleType).GetMember(type.ToString());
                var attr = memInfo[0].GetCustomAttributes(typeof(DisplayAttribute), false);
                return ((DisplayAttribute)attr[0]).Name;
            }
        }
    }
}
