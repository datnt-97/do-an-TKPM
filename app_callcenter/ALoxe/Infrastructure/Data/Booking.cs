using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Data
{
    public class Booking
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("staffId")]
        public int? StaffId { get; set; }
        [JsonProperty("startTime")]
        public string? Date { get; set; }
        [JsonProperty("endTime")]
        public string? DateEnd { get; set; }
        [JsonProperty("status")]
        public string? Status { get; set; }
        [JsonProperty("bookingDetail")]
        public BookingDetail? BookingDetailObj { get; set; }

        [JsonProperty("customer")]
        public Customer? CustomerObj { get; set; }

        [JsonProperty("driver")]
        public Driver? DriverObj { get; set; }

        [JsonProperty("staff")]
        public Staff? StaffObj { get; set; }
        //amount
        [JsonProperty("amount")]
        public int? Amount { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        public BookingStatus bookingStatus
        {
            get
            {
                if (Status == null)
                {
                    return BookingStatus.BOOKED;
                }
                else
                {
                    return (BookingStatus)Enum.Parse(typeof(BookingStatus), Status);
                }
            }
        }
    }
    public enum BookingStatus
    {
        BOOKED, WAITING_FOR_DRIVER, DRIVER_FOUND, DRIVER_CONFIRMED, DRIVER_COME, ONBOARDING, ARRIVED, PAID, DRIVER_NOT_FOUND, CANCELLED
    }

}
