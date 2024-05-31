using ALoxe.Common;
using ALoxe.Infrastructure.Data;
using ALoxe.Infrastructure.DB;
using ALoxe.Infrastructure.Http;
using ALoxe.Infrastructure.Model;
using Microsoft.Maps.MapControl.WPF;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ALoxe.UI
{
    public partial class frmBooking : Form
    {
        AppDBContext db;
        Location locationFrom = null;
        Location locationTo = null;
        UserModel user = null;
        public frmBooking(string title)
        {
            InitializeComponent();
            this.Text = title;
            db = new AppDBContext();
            //db.Database.AutoSavepointsEnabled = false;
            dtpVIP.Format = DateTimePickerFormat.Custom;
            dtpVIP.CustomFormat = "dd/MM/yyyy hh:mm";
            dtpVIP.MinDate = DateTime.Now;
            user = db.Users.FirstOrDefault();

            lbKC.Visible = false;
            lbLocationFrom.Visible = false;
            lbLocationTo.Visible = false;
            lbTien.Visible = false;


        }
        void SetUCMap(ucMap ucMap)
        {
            elhMap.Child = ucMap;
        }
        ucMap mapALL = new ucMap();

        private void BookingCRUD_Load(object sender, EventArgs e)
        {
            elhMap.Dock = DockStyle.Fill;
            pnMap.Controls.Add(elhMap);
            //tọa độ mặt định ở HCM
            mapALL.myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(10.762622, 106.660172);
            //zoom level
            mapALL.myMap.ZoomLevel = 10;
            //add map to panel

            SetUCMap(mapALL);

            db.Provinces.OrderBy(b => b.Name).ToList().ForEach(p =>
            {
                cbTP.Items.Add(p);
                cbTPDen.Items.Add(p);
            });
            //select first item
            if (cbTP.Items.Count > 0)
            {
                cbTP.SelectedIndex = 0;
                cbTPDen.SelectedIndex = 0;
            }



        }

        private void cbTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var province = cbTP.SelectedItem as Province;
            if (province != null)
            {
                //select quận huyện 
                cbQuan.Items.Clear();
                db.Districts.OrderBy(b => b.Name).Where(d => d.ProvinceId == province.Id).OrderBy(b => b.Name).ToList().ForEach(p => cbQuan.Items.Add(p));
                cbQuan.SelectedIndex = 0;
            }
        }

        private void cbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select phường xã
            var district = cbQuan.SelectedItem as District;
            if (district != null)
            {
                cbPhuong.Items.Clear();
                db.Streets.OrderBy(b => b.Name).Where(d => d.DistrictId == district.Id).OrderBy(b => b.Name).ToList().ForEach(p => cbPhuong.Items.Add(p));
                cbPhuong.SelectedIndex = 0;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void validate()
        {
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                lbMessage.Text = "Số điện thoại không được để trống";
            }
            else if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                lbMessage.Text = "Tên khách hàng không được để trống";
            }
            else if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                lbMessage.Text = "Địa chỉ đón khách không được để trống";
            }
            else if (string.IsNullOrEmpty(txtDiaChiDen.Text))
            {
                lbMessage.Text = "Địa chỉ đến không được để trống";
            }
            else if (cbTP.SelectedItem == null)
            {
                lbMessage.Text = "Tỉnh/Thành phố không được để trống";
            }
            else if (cbQuan.SelectedItem == null)
            {
                lbMessage.Text = "Quận/Huyện không được để trống";
            }
            else if (cbPhuong.SelectedItem == null)
            {
                lbMessage.Text = "Phường/Xã không được để trống";
            }
            else if (cbTPDen.SelectedItem == null)
            {
                lbMessage.Text = "Tỉnh/Thành phố đến không được để trống";
            }
            else if (cbQuanDen.SelectedItem == null)
            {
                lbMessage.Text = "Quận/Huyện đến không được để trống";
            }
            else if (cbPhuongDen.SelectedItem == null)
            {
                lbMessage.Text = "Phường/Xã đến không được để trống";
            }
            else
            {
                lbMessage.Text = "";
            }

        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            mapALL.myMap.Children.Clear();
            this.locationFrom = null;
            this.locationTo = null;
            //loading 

            var addressFrom = txtDiaChi.Text + ", " + (cbPhuong.SelectedItem as Street).Name + ", " + (cbQuan.SelectedItem as District).Name + ", " + (cbTP.SelectedItem as Province).Name;
            var addressTo = txtDiaChiDen.Text + ", " + (cbPhuongDen.SelectedItem as Street).Name + ", " + (cbQuanDen.SelectedItem as District).Name + ", " + (cbTPDen.SelectedItem as Province).Name;
            var loading = new frmLoading(async (l) =>
            {
                this.locationFrom = await Common.Util.GetLocationFromAddressAsync(addressFrom);
                l.PerformSafely(() =>
                {
                    l.Close();
                });
            }, "Đang tìm điểm đón");
            loading.ShowDialog();
            var loading2 = new frmLoading(async (l) =>
            {
                this.locationTo = await Common.Util.GetLocationFromAddressAsync(addressTo);
                l.PerformSafely(() =>
                {
                    l.Close();
                });
            }, "Đang tìm điểm đến");
            loading2.ShowDialog();
            var route = Common.Util.GetRouteFromAddressAsync(addressFrom, addressTo);

            if (locationFrom != null)
            {
                //center map to location
                mapALL.myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(locationFrom.Latitude, locationFrom.Longitude);
                //zoom level
                //Pushpin điểm A
                var pushpin = new Microsoft.Maps.MapControl.WPF.Pushpin();
                //thêm màu cho pushpin
                pushpin.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
                //sự kiện click vào pushpin A sẽ hiển thị thông tin
                pushpin.MouseLeftButtonUp += (s, ev) =>
                {
                    var pin = s as Microsoft.Maps.MapControl.WPF.Pushpin;
                    if (pin != null)
                    {
                        var location = pin.Location;
                        var address = addressFrom;
                        if (address != null)
                        {
                            MessageBox.Show(addressFrom);
                        }
                    }
                };
                pushpin.Location = locationFrom;
                mapALL.myMap.Children.Add(pushpin);
            }
            if (locationTo != null)
            {
                var pushpin = new Microsoft.Maps.MapControl.WPF.Pushpin();
                //thêm màu cho pushpin
                pushpin.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Blue);
                //sự kiện click vào pushpin B sẽ hiển thị thông tin
                pushpin.MouseLeftButtonUp += (s, ev) =>
                {
                    var pin = s as Microsoft.Maps.MapControl.WPF.Pushpin;
                    if (pin != null)
                    {
                        var location = pin.Location;
                        var address = addressTo;
                        if (address != null)
                        {
                            MessageBox.Show(addressTo);
                        }
                    }
                };
                pushpin.Location = locationTo;
                mapALL.myMap.Children.Add(pushpin);

            }
            //zoom level with distance between 2 location 
            if (locationFrom != null && locationTo != null)
            {
                var distance = Common.Util.Distance(locationFrom, locationTo);
                if (distance < 100000)
                {
                    mapALL.myMap.ZoomLevel = 10;
                }
                else if (distance < 200000)
                {
                    mapALL.myMap.ZoomLevel = 9;
                }
                else if (distance < 300000)
                {
                    mapALL.myMap.ZoomLevel = 8;
                }
                else if (distance < 400000)
                {
                    mapALL.myMap.ZoomLevel = 7;
                }
                else if (distance < 500000)
                {
                    mapALL.myMap.ZoomLevel = 6;
                }
                else if (distance < 600000)
                {
                    mapALL.myMap.ZoomLevel = 5;
                }
                else if (distance < 700000)
                {
                    mapALL.myMap.ZoomLevel = 4;
                }
                else if (distance < 800000)
                {
                    mapALL.myMap.ZoomLevel = 3;
                }
                else if (distance < 900000)
                {
                    mapALL.myMap.ZoomLevel = 2;
                }
                else if (distance < 1000000)
                {
                    mapALL.myMap.ZoomLevel = 1;
                }
                else
                {
                    mapALL.myMap.ZoomLevel = 0;
                }

                //kc kilomet lấy sau 2 số thập phân
                var kc = Math.Round(distance / 1000, 2);
                lbKC.Text = kc.ToString() + " km";

                lbLocationFrom.Text = locationFrom.ToString();
                lbLocationTo.Text = locationTo.ToString();

                lbKC.Visible = true;
                lbLocationFrom.Visible = true;
                lbLocationTo.Visible = true;
                //tính tiền và format tiền
                var tien = Math.Round(kc * 10000, 0);
                //định dạng tiền tệ vnd
                lbTien.Text = "Dự kiến : " + tien.ToString("N0") + " VNĐ";
                lbTien.Visible = true;

                //lbTien.Text = "Dự kiến : " + Math.Round(kc * 10000, 0).ToString() + " VNĐ";
                //lbTien.Visible = true;
            }
            this.locationFrom = locationFrom;
            this.locationTo = locationTo;
            //route from addressFrom to addressTo
            if (route != null)
            {
                var routeLine = new Microsoft.Maps.MapControl.WPF.MapPolyline();
                routeLine.Locations = new Microsoft.Maps.MapControl.WPF.LocationCollection();
                foreach (var point in route.RoutePath.Line.Coordinates)
                {
                    routeLine.Locations.Add(new Microsoft.Maps.MapControl.WPF.Location(point[0], point[1]));
                    //tô màu đường đi
                    var color = System.Windows.Media.Colors.Red;
                    routeLine.Stroke = new System.Windows.Media.SolidColorBrush(color);
                    //độ dày đường đi
                    routeLine.StrokeThickness = 6;
                }
                mapALL.myMap.Children.Add(routeLine);
            }
            SetUCMap(mapALL);

            btnBook.Enabled = true;
            //color for button green 
            btnBook.BackColor = Color.FromArgb(255, 204, 0);
            btnXoaLocation.Visible = true;
            btnXoaLocation.Enabled = true;
            //color for button red 
            btnXoaLocation.BackColor = Color.Red;

            lbLocationFrom.Text = locationFrom.ToString();
            lbLocationTo.Text = locationTo.ToString();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lbVip.Visible = true;
            dtpVIP.Visible = true;
        }

        private void lbVip_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbVip.Visible = false;
            dtpVIP.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbVip.Visible = false;
            dtpVIP.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            lbVip.Visible = false;
            dtpVIP.Visible = false;
        }

        private void cbQuanDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var district = cbQuanDen.SelectedItem as District;
            if (district != null)
            {
                //select phường xã
                cbPhuongDen.Items.Clear();
                db.Streets.Where(d => d.DistrictId == district.Id).OrderBy(b => b.Name).ToList().ForEach(p => cbPhuongDen.Items.Add(p));
                cbPhuongDen.SelectedIndex = 0;
            }

        }

        private void cbTPDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var province = cbTPDen.SelectedItem as Province;
            if (province != null)
            {
                //select quận huyện 
                cbQuanDen.Items.Clear();
                db.Districts.Where(d => d.ProvinceId == province.Id).OrderBy(b => b.Name).ToList().ForEach(p => cbQuanDen.Items.Add(p));
                cbQuanDen.SelectedIndex = 0;
            }
        }

        private void lbMessage_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            //check location from and location to 
            if (locationFrom == null || locationTo == null)
            {
                lbMessage.Text = "Vui lòng chọn địa chỉ đón và địa chỉ đến";
                lbMessage.ForeColor = Color.Red;
                lbMessage.Visible = true;
                return;
            }
            if (locationFrom == locationTo)
            {
                lbMessage.Text = "Địa chỉ đón và địa chỉ đến không được trùng nhau";
                lbMessage.ForeColor = Color.Red;
                lbMessage.Visible = true;
                return;
            }

            //check input
            lbMessage.Text = "";
            validate();
            if (!string.IsNullOrEmpty(lbMessage.Text))
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Visible = true;
                return;
            }
            var vehicleType = 0;
            if (rd4.Checked)
            {
                vehicleType = 4;
            }
            else if (rd5.Checked)
            {
                vehicleType = 5;
            }
            else if (rd7.Checked)
            {
                vehicleType = 7;
            }
            var vehicleTypeEnum = Vehicle.VehicleType.VIP;
            switch (vehicleType)
            {
                case 4:
                    vehicleTypeEnum = Vehicle.VehicleType.FOUR_SEAT;
                    break;
                case 5:
                    vehicleTypeEnum = Vehicle.VehicleType.FIVE_SEAT;
                    break;
                case 7:
                    vehicleTypeEnum = Vehicle.VehicleType.SEVEN_SEAT;
                    break;
                default:
                    break;
                    //case 5:
                    //    vehicleTypeEnum = "FIVE_SEAT";
                    //    break;
                    //case 7:
                    //    vehicleTypeEnum = "SEVEN_SEAT";
                    //    break;
                    //default:
                    //    break;
            }
            //check email valid
            if (!Common.Util.IsValidEmail(txtEmail.Text))
            {
                lbMessage.Text = "Email không hợp lệ";
                lbMessage.ForeColor = Color.Red;
                lbMessage.Visible = true;
                return;
            }
            //check so dien thoai valid
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                lbMessage.Text = "Số điện thoại không hợp lệ";
                lbMessage.ForeColor = Color.Red;
                lbMessage.Visible = true;
                return;
            }
            //save to db
            var diaChi = txtDiaChi.Text + ", " + (cbPhuong.SelectedItem as Street).Name + ", " + (cbQuan.SelectedItem as District).Name + ", " + (cbTP.SelectedItem as Province).Name;
            var diaChiDen = txtDiaChiDen.Text + ", " + (cbPhuongDen.SelectedItem as Street).Name + ", " + (cbQuanDen.SelectedItem as District).Name + ", " + (cbTPDen.SelectedItem as Province).Name;

            var bookingDetail = new BookingDetail()
            {
                Customer = txtTenKH.Text,
                CustomerPhone = txtSDT.Text,
                CustomerAddress = diaChi,
                CustomerAddressTo = diaChiDen,
                Date = dtpVIP.Value,
                VehicleType = ((int)vehicleTypeEnum),
                CustomerEmail = txtEmail.Text,
                DropOffLatitude = locationTo.Latitude,
                DropOffLongitude = locationTo.Longitude,
                PickUpLatitude = locationFrom.Latitude,
                PickUpLongitude = locationFrom.Longitude
            };
            //check vip date 
            if (dtpVIP.Value < DateTime.Now && vehicleTypeEnum == Vehicle.VehicleType.VIP)
            {
                lbMessage.Text = "Thời gian đặt xe không hợp lệ";
                lbMessage.ForeColor = Color.Red;
                lbMessage.Visible = true;
                return;

            }
            var booking = new
            {
                startTime = dtpVIP.Value.ToUniversalTime(),
                staffId = user.Id,
                orderDetail = new
                {
                    vehicleType = vehicleTypeEnum.ToString(),
                    pickupLongitude = locationFrom.Longitude,
                    pickupLatitude = locationFrom.Latitude,
                    returnLongitude = locationTo.Longitude,
                    returnLatitude = locationTo.Latitude,
                    pickupLocation = diaChi,
                    returnLocation = diaChiDen,
                    startTime = dtpVIP.Value.ToUniversalTime(),
                },
                customer = new
                {
                    fullName = txtTenKH.Text,
                    phoneNumber = txtSDT.Text,
                    email = txtEmail.Text
                },
            };
            var json = JsonConvert.SerializeObject(booking, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            var post = JsonConvert.DeserializeObject(json);
            HttpRequest_v2 httpRequest = new HttpRequest_v2();
            bool isRebooking = false;
            HttpResponseMessage response = null;
            Result res = null;

            var loading = new frmLoading(async (l) =>
            {
                response = await httpRequest.SendAsync(Constant.APP_SERVER + Constant.URL_BOOKING, HttpMethod.Post, post);
                var result = await response.Content.ReadAsStringAsync();
                res = JsonConvert.DeserializeObject<Result>(result);
                l.PerformSafely(() => l.Close());

            }, "Đang đặt xe");
            loading.ShowDialog();
            if (response == null || res == null)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
                return;
            }
            if (response.IsSuccessStatusCode)
            {
                if (res.status == "SUCCESS")
                {
                    var bookingRes = JsonConvert.DeserializeObject<Booking>(JsonConvert.SerializeObject(res.data));
                    if (bookingRes.bookingStatus == BookingStatus.DRIVER_NOT_FOUND)
                    {
                        //thông báo popup tài xế không có, xác nhận  đặt xe lại hoặc hủy 
                        var dialogResult = MessageBox.Show("Không tìm thấy tài xế phù hợp, bạn có muốn đặt xe lại không?", "Thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            isRebooking = true;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                            //hủy đặt xe
                            this.Close();
                        }
                    }
                    else if (vehicleTypeEnum == Vehicle.VehicleType.VIP && DateTime.Now.ToString("yyyy-MM-dd HH:mm") != dtpVIP.Value.ToString("yyyy-MM-dd HH:mm"))
                    {
                        //thông báo đã đặt lịch hẹn thành công 
                        MessageBox.Show($"Đặt lịch hẹn thành công  ({bookingRes.Code})");

                    }
                    else
                    {
                        MessageBox.Show($"Đăt thành công ({bookingRes.Code})");

                    }
                }
            }
            else
            {
                if (res.status == "NotfoundError")
                {
                    var dialogResult = MessageBox.Show("Không tìm thấy tài xế phù hợp, bạn có muốn đặt xe lại không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.rjButton3_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
                }

                //thông báo đã có lỗi xảy ra
            }
        }

        private void btnXoaLocation_Click(object sender, EventArgs e)
        {
            locationFrom = null;
            locationTo = null;
            mapALL.myMap.Children.Clear();
            btnBook.Enabled = false;
            //btnBook ControlLight
            btnBook.BackColor = Color.FromArgb(224, 224, 224);
            btnXoaLocation.Visible = false;

            lbLocationFrom.Text = "";
            lbLocationTo.Text = "";

            lbKC.Visible = false;
            lbLocationFrom.Visible = false;
            lbLocationTo.Visible = false;
            lbTien.Visible = false;


        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            //var add = txtDiaChi.Text + ", " + (cbPhuong.SelectedItem as Street).Description + ", " + (cbQuan.SelectedItem as District).Description + ", " + (cbTP.SelectedItem as Province).Description;
            //Task.Run(() =>
            //{
            //    Util.SearchAddress(add);
            //}).Wait();

        }

        private void txtSDT_MouseEnter(object sender, EventArgs e)
        {


        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {

            //enter
            if (e.KeyCode == Keys.Enter)
            {
                HttpRequest_v2 httpRequest = new HttpRequest_v2();
                var text = txtSDT.Text;
                Task.Run(async () =>
                {
                    var response = await httpRequest.SendAsync(Constant.APP_SERVER + Constant.URL_SEARCH_CUSTOMER + $"?search={text}", HttpMethod.Get
                        , headers: new Dictionary<string, string>
                        {
                            { "x-access-token",user.Token}
                        });
                    var result = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var res = JsonConvert.DeserializeObject<Result>(result);
                        if (res.status == "SUCCESS")
                        {
                            var customer = JsonConvert.DeserializeObject<List<Customer>>(JsonConvert.SerializeObject(res.data));
                            this.PerformSafely(() =>
                            {
                                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                                customer.ForEach(b => collection.Add(b.UserObj.PhoneNumber));
                                txtSDT.AutoCompleteSource = AutoCompleteSource.CustomSource;
                                txtSDT.AutoCompleteCustomSource = collection;
                                txtSDT.AutoCompleteMode = AutoCompleteMode.Suggest;
                            });

                        }
                    }
                });
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            //    HttpRequest_v2 httpRequest = new HttpRequest_v2();
            //    var text = txtSDT.Text;
            //    Task.Run(async () =>
            //    {
            //        var response = await httpRequest.PostAsync(Constant.APP_SERVER + Constant.URL_SEARCH_CUSTOMER + $"?search={text}", HttpMethod.Get
            //            , headers: new Dictionary<string, string>
            //            {
            //                    { "x-access-token",user.Token}
            //            });
            //        var result = await response.Content.ReadAsStringAsync();
            //        if (response.IsSuccessStatusCode)
            //        {
            //            var res = JsonConvert.DeserializeObject<Result>(result);
            //            if (res.status == "SUCCESS")
            //            {
            //                var customer = JsonConvert.DeserializeObject<List<Customer>>(JsonConvert.SerializeObject(res.data));
            //                this.PerformSafely(() =>
            //                {
            //                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            //                    customer.ForEach(b => collection.Add(b.UserObj.PhoneNumber));
            //                    txtSDT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //                    txtSDT.AutoCompleteCustomSource = collection;
            //                    txtSDT.AutoCompleteMode = AutoCompleteMode.Append;
            //                });
            //            }
            //        }
            //    });
        }
    }
}
