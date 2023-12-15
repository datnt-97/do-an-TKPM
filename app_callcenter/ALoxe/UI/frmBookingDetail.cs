using ALoxe.Common;
using ALoxe.Components;
using ALoxe.Infrastructure.Data;
using ALoxe.Infrastructure.Socket;
using BingMapsRESTToolkit;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALoxe.UI
{
    public partial class frmBookingDetail : Form
    {
        Booking _booking;
        Microsoft.Maps.MapControl.WPF.Location locationFrom = null;
        Microsoft.Maps.MapControl.WPF.Location locationTo = null;
        Route route = null;
        public frmBookingDetail(Booking booking)
        {
            InitializeComponent();
            Text = "Chi tiết đặt xe " + booking.Code + "(" + booking.Id + ")";
            _booking = booking;
            if (Socket.client != null && !Socket.client.Connected)
            {
                Task.Run(async () =>
                {
                    await Socket.client.ConnectAsync();
                }).Wait();
            }
            Socket.client.OnAny((eventName, data) =>
            {
            });
            Socket.client.On(_booking.Id.ToString(), response =>
            {
                Task.Run(async () =>
                {
                    _booking = await Util.GetBookingAsync(_booking.Id.ToString());

                }).Wait();
                this.PerformSafely(() =>
                {
                    UpdateStatus();
                    DrawDriver();

                });
            });

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        void SetUCMap(ucMap ucMap)
        {
            elhMap.Child = ucMap;
        }
        ucMap mapALL = new ucMap();
        ElementHostCustom elhMap = new ElementHostCustom();

        private void frmBookingDetail_Load(object sender, EventArgs e)
        {
            loadDetail();

        }
        private void loadDetail()
        {

            elhMap.Dock = DockStyle.Fill;
            pnMap.Controls.Add(elhMap);
            //tọa độ mặt định ở HCM
            mapALL.myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(10.762622, 106.660172);
            //zoom level
            mapALL.myMap.ZoomLevel = 10;
            //add map to panel

            var loading = new frmLoading(async (l) =>
            {
                _booking = await Util.GetBookingAsync(_booking.Id.ToString());
                if (_booking.BookingDetailObj != null && _booking.BookingDetailObj.CustomerAddress != null)
                {
                    locationFrom = await Common.Util.GetLocationFromAddressAsync(_booking.BookingDetailObj.CustomerAddress);
                    locationTo = await Common.Util.GetLocationFromAddressAsync(_booking.BookingDetailObj.CustomerAddressTo);

                }
                //route = await Common.Util.GetRoute2PointAsync(locationFrom, locationTo);
                l.PerformSafely(() => l.Close());
            });
            loading.ShowDialog();

            if (_booking == null)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu");
                return;
            }
            //set avartar  url
            if (_booking?.CustomerObj?.UserObj?.Avatar != null)
            {
                pbKH.Image = null;
                pbKH.ImageLocation = _booking?.CustomerObj?.UserObj?.Avatar ?? "";

            }
         
            //set data for booking detail
            lbDi.Text = _booking.BookingDetailObj.CustomerAddress;
            lbDen.Text = _booking.BookingDetailObj.CustomerAddressTo;
            lbSDT_KH.Text = _booking?.CustomerObj?.UserObj?.PhoneNumber ?? "";
            lbTenKH.Text = _booking?.CustomerObj?.UserObj?.FullName ?? "";
            lbEmailKH.Text = _booking?.CustomerObj?.UserObj?.Email ?? "";

           

            //set data for detail
            lbNgayDat.Text = _booking.Date ?? "";
            if (locationFrom != null && locationTo != null)
            {
                lbKC.Text = (Util.Distance(locationFrom, locationTo) / 1000).ToString("0.0") + " km";
            }
            blGiaTien.Text = _booking.Amount?.ToString("0,0") ?? "";

            DrawDriver();
            Common.UICommon.ShowMapFrom2Point(ref mapALL, locationFrom, locationTo, route);
            SetUCMap(mapALL);
            DrawStep();
        }
        void UpdateStatus()
        {
            var i = 0;
            var steps = pnStepH.Controls.Cast<ucStepH>().ToList();
            foreach (ucStepH step in steps)
            {
                var currentStatus = ((int)(Enum.Parse(typeof(BookingStatus), step.step.data.ToString())));
                if (_booking.bookingStatus == BookingStatus.DRIVER_NOT_FOUND && currentStatus == (int)_booking.bookingStatus)
                {

                    step.Active();
                    step.InActiveLeft();
                    step.InActiveRight();


                }
                else if (_booking.bookingStatus == BookingStatus.CANCELLED && currentStatus == (int)_booking.bookingStatus)
                {
                    step.Active();
                    step.InActiveLeft();
                    step.InActiveRight();
                }
                else if (currentStatus <= (int)_booking.bookingStatus && (_booking.bookingStatus != BookingStatus.CANCELLED)
                     && (_booking.bookingStatus != BookingStatus.DRIVER_NOT_FOUND))
                {

                    step.Active();
                    if (currentStatus == (int)_booking.bookingStatus && _booking.bookingStatus == BookingStatus.PAID)
                    {
                        step.InActiveRight();
                    }
                    else
                    {
                        if (i + 1 < steps.Count && steps[i + 1] != null)
                        {
                            steps[i + 1].ActiveLeft();
                        }
                    }
                }

                i++;
            }
        }
        void DrawDriver()
        {
            if (_booking?.DriverObj?.user?.Avatar != null)
            {
                pbTaiXe.Image = null;
                pbTaiXe.ImageLocation = _booking?.DriverObj?.user?.Avatar ?? "";

            }

            //set data for driver
            lbTaiXe.Text = _booking?.DriverObj?.user?.FullName ?? "";
            lbSDTTX.Text = _booking?.DriverObj?.user?.PhoneNumber ?? "";

            lbBienSo.Text = _booking?.DriverObj?.vehicle?.licensePlate ?? "";
            lbLoaiXe.Text = _booking?.BookingDetailObj?.VehicleTypeObj ?? "";
            lbLoaiXeBooking.Text = _booking?.BookingDetailObj?.VehicleTypeObj ?? "";
            lbBangCap.Text = _booking?.DriverObj?.licenseType ?? "";

            //xóa pnWaitingDriver nếu có
            var pnWaitingDriver = pnTaiXe.Controls.Find("pnWaitingDriver", true).FirstOrDefault();
            if (pnWaitingDriver != null)
            {
                pnTaiXe.Controls.Remove(pnWaitingDriver);
            }

            if (_booking.bookingStatus == BookingStatus.BOOKED || _booking.bookingStatus == BookingStatus.WAITING_FOR_DRIVER)
            {
                //add thêm panel chờ tài xế , hiển thị chữ chờ tài xế ở giữa panel
                var pn = new Panel();
                pn.Name = "pnWaitingDriver";
                pn.Dock = DockStyle.Fill;
                pn.BackColor = Color.FromArgb(0, 0, 0, 0);
                //thêm usercontrol loading và label ở dưới loading vào panel
                var loadingUC = new Loading();
                //width = 50, height = 50
                loadingUC.Size = new Size(50, 50);
                //cho loading ở giữa panel
                loadingUC.Location = new System.Drawing.Point((pnTaiXe.Width - loadingUC.Width) / 2, (pnTaiXe.Height - loadingUC.Height) / 2);
                pn.Controls.Add(loadingUC);
                var lb = new Label();
                if (_booking.bookingStatus == BookingStatus.BOOKED)
                    lb.Text = "Chưa đến giờ hẹn";
                //lb.Dock = DockStyle.Bottom;
                lb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lb.ForeColor = Color.Black;

                //max size = size của panel
                lb.Size = new Size(pnTaiXe.Width, 50);
                lb.MaximumSize = new Size(pnTaiXe.Width, 50);
                lb.TextAlign = ContentAlignment.MiddleCenter;
                //location nằm dưới loading và ở giữa panel
                lb.Location = new System.Drawing.Point((pnTaiXe.Width - lb.Width) / 2, loadingUC.Location.Y + loadingUC.Height);

                //lb.BorderStyle= BorderStyle.FixedSingle;
                pn.Controls.Add(lb);
                pn.Dock = DockStyle.Fill;
                pnTaiXe.Controls.Add(pn);
                pn.BringToFront();
            }
        }
        private void DrawStep()
        {
            var steps = new List<ucStepH>();
            steps.Add(new ucStepH(new ucStep.Step()
            {
                Name = "Đã đặt xe",
                Description = "Đã đặt xe theo lịch hẹn",
                Number = 1,
                isLast = false,
                isFirst = true,
                data = BookingStatus.BOOKED
            }));
            steps.Add(new ucStepH(new ucStep.Step()
            {
                Name = "Đang tìm tài xế",
                Description = "Đang tìm tài xế",
                Number = 2,
                isLast = false,
                data = BookingStatus.WAITING_FOR_DRIVER
            }));
            steps.Add(new ucStepH(new ucStep.Step()
            {
                Name = "Đã tìm thấy tài xế",
                Description = "Đã tìm thấy tài xế",
                Number = 3,
                isLast = false,
                data = BookingStatus.DRIVER_FOUND
            }));
            steps.Add(new ucStepH(new ucStep.Step()
            {
                Name = "Tài xế đã nhận",
                Description = "Tài xế đã nhận",
                Number = 4,
                isLast = false,
                data = BookingStatus.DRIVER_CONFIRMED
            }));
            steps.Add(new ucStepH(new ucStep.Step()
            {
                Name = "Đón khách",
                Description = "Đang đón khách",
                Number = 5,
                isLast = false,
                data = BookingStatus.DRIVER_COME
            }));
            steps.Add(new ucStepH(new ucStep.Step()
            {
                Name = "Trên đường",
                Description = "Đang trên đường",
                Number = 6,
                isLast = false,
                data = BookingStatus.ONBOARDING
            }));
            steps.Add(new ucStepH(new ucStep.Step()
            {
                Name = "Đến nơi",
                Description = "Đã đến nơi",
                Number = 7,
                isLast = false,
                data = BookingStatus.ARRIVED
            }));
            steps.Add(new ucStepH(new ucStep.Step()
            {
                Name = "Đã thanh toán",
                Description = "Đã thanh toán",
                Number = 8,
                isLast = false,
                data = BookingStatus.PAID
            }));
            //not found driver
            steps.Add(new ucStepH(new ucStep.Step()
            {
                data = BookingStatus.DRIVER_NOT_FOUND,
                Name = "Không tìm thấy tài xế",
                Description = "Không tìm thấy tài xế",
                Number = 9,
                isLast = false

            }));
            steps.Add(new ucStepH(new ucStep.Step()
            {
                Name = "Đã hủy",
                Description = "Đã hủy",
                Number = 10,
                isLast = true,
                data = BookingStatus.CANCELLED
            }));
            pnStepH.Controls.Clear();

            var i = 0;
            foreach (var step in steps)
            {
                step.Dock = DockStyle.Right;
                pnStepH.Controls.Add(step);
                var currentStatus = ((int)(Enum.Parse(typeof(BookingStatus), step.step.data.ToString())));
                if (_booking.bookingStatus == BookingStatus.DRIVER_NOT_FOUND && currentStatus == (int)_booking.bookingStatus)
                {

                    step.Active();
                    step.InActiveLeft();
                    step.InActiveRight();


                }
                else if (_booking.bookingStatus == BookingStatus.CANCELLED && currentStatus == (int)_booking.bookingStatus)
                {
                    step.Active();
                    step.InActiveLeft();
                    step.InActiveRight();
                }
                else if (currentStatus <= (int)_booking.bookingStatus && (_booking.bookingStatus != BookingStatus.CANCELLED)
                     && (_booking.bookingStatus != BookingStatus.DRIVER_NOT_FOUND))
                {

                    step.Active();
                    if (currentStatus == (int)_booking.bookingStatus && _booking.bookingStatus == BookingStatus.PAID)
                    {
                        step.InActiveRight();
                    }
                    else
                    {
                        if (i + 1 < steps.Count && steps[i + 1] != null)
                        {
                            steps[i + 1].ActiveLeft();
                        }
                    }
                }

                i++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //reload form
            var bookingDetail = new frmBookingDetail(_booking);
            bookingDetail.Show();
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
