using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoxe.Infrastructure.Data
{
    public class Booking
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("startTime")]
        public string? Date { get; set; }
        [JsonProperty("endTime")]
        public string? DateEnd { get; set; }
        [JsonProperty("staffId")]
        public int? StaffId { get; set; }
        [JsonProperty("status")]
        public string? Status { get; set; }
        [JsonProperty("orderDetail")]
        public BookingDetail? BookingDetailObj { get; set; }

        [JsonProperty("customer")]
        public Customer? CustomerObj { get; set; }

        [JsonProperty("driver")]
        public Driver? DriverObj { get; set; }

        [JsonProperty("staff")]
        public Staff? StaffObj { get; set; }
        //amount
        [JsonProperty("totalPrice")]
        public int? Amount { get; set; }
        public DateTime StartTime
        {
            get
            {
                //2024-05-30T03:56:59.295Z
                //yyyy-MM-ddTHH:mm:ss.fffZ
                var k = DateTime.ParseExact(Date.Split("T")[0] + Date.Split("T")[1].Split('.')[0].Replace("Z", ""), "yyyy-MM-ddHH:mm:ss", null);
                //utc to local
                return k.ToLocalTime();
            }
        }

        public DateTime EndTime
        {
            get
            {
                //2024-05-30T03:56:59.295Z
                //yyyy-MM-ddTHH:mm:ss.fffZ
                var k = DateTime.ParseExact(DateEnd.Split("T")[0] + DateEnd.Split("T")[1].Split('.')[0].Replace("Z", ""), "yyyy-MM-ddHH:mm:ss", null);
                //utc to local
                return k.ToLocalTime();

            }
        }

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
    [AttributeUsage(AttributeTargets.Field)]
    public class NameValue : Attribute
    {
        public string Name { get; set; }
        public NameValue(string name)
        {
            Name = name;
        }
    }

    public enum BookingStatus
    {
        [Display(Name = "#68dcfc")]
        [NameValue("Đã đặt")]
        BOOKED,
        [Display(Name = "#ffdc04")]
        [NameValue("Đang chờ tài xế")]
        WAITING_FOR_DRIVER,

        [Display(Name = "#00ff00")] // Màu xanh lá cây để biểu thị tình trạng tốt
        [NameValue("Đã tìm thấy tài xế")]
        DRIVER_FOUND,

        [Display(Name = "#007bff")] // Màu xanh dương để biểu thị tình trạng xác nhận
        [NameValue("Tài xế đã xác nhận")]
        DRIVER_CONFIRMED,

        [Display(Name = "#00c853")] // Màu xanh lá cây sáng để biểu thị tài xế đã đến
        [NameValue("Tài xế đã đến")]
        DRIVER_COME,

        [Display(Name = "#ff9800")] // Màu cam để biểu thị tình trạng đang lên xe
        [NameValue("Đang lên xe")]
        ONBOARDING,

        [Display(Name = "#4caf50")] // Màu xanh lá cây đậm để biểu thị đã đến nơi
        [NameValue("Đã đến nơi")]
        ARRIVED,

        [Display(Name = "#8bc34a")] // Màu xanh lá cây nhạt để biểu thị đã thanh toán
        [NameValue("Đã thanh toán")]
        PAID,

        [Display(Name = "#f44336")] // Màu đỏ để biểu thị không tìm thấy tài xế
        [NameValue("Không tìm thấy tài xế")]
        DRIVER_NOT_FOUND,

        [Display(Name = "#9e9e9e")] // Màu xám để biểu thị tình trạng hủy
        [NameValue("Đã hủy")]
        CANCELLED
    }

}
