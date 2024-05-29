using ALoxe.Common;
using ALoxe.Components;
using ALoxe.Infrastructure.Data;
using ALoxe.Infrastructure.Http;
using ALoxe.Infrastructure.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace ALoxe.UI
{
    public partial class ucBookCar : UserControl
    {
        frmMainWindow mainFrm;
        bool isBooking = true;
        UserModel user;
        public ucBookCar(frmMainWindow frmMain, UserModel user, bool isBooking = true)
        {
            InitializeComponent();
            this.mainFrm = frmMain;
            this.user = user;
            this.isBooking = isBooking;
            if (!isBooking)
            {
                rjButton1.Visible = false;
            }
            loadData();


        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var form = new frmBooking("Đặt xe");
            //mainFrm.Hide();
            //form.Closed += (s, args) => mainFrm.Show();
            form.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {

            var list = new List<Booking>();
            var loading = new frmLoading(async (l) =>
            {
                list = await GetBookingsAsync();
                l.PerformSafely(() =>
                {
                    l.Close();
                });
            });
            loading.ShowDialog();
            LoadGrid(list);
        }
        void LoadGrid(List<Booking> l)
        {

            dgBooking.Rows.Clear();
            foreach (var item in l)
            {
                var row = new DataGridViewRow();
                row.Tag = item;
                var date = DateTime.Parse(item.Date);
                var local = date.ToLocalTime().ToString("dd-MM-yyyy HH:mm");
                var localEnd = "";
                if (!string.IsNullOrEmpty(item.DateEnd))
                {
                    var dateEnd = DateTime.Parse(item.DateEnd);
                    localEnd = dateEnd.ToLocalTime().ToString("dd-MM-yyyy HH:mm");
                }

                //get attribute display name of enum status
                var enumType = typeof(BookingStatus);
                var memInfo = enumType.GetMember(item.bookingStatus.ToString());
                var attr = memInfo[0].GetCustomAttributes(typeof(NameValue), false);
                var name = ((NameValue)attr[0]).Name;

                row.CreateCells(dgBooking,
                    item.Code ?? "",
                    item.CustomerObj?.UserObj.FullName ?? "",
                    item.CustomerObj?.UserObj.PhoneNumber ?? "",
                    item.BookingDetailObj?.CustomerAddress ?? "",
                    item.BookingDetailObj?.CustomerAddressTo ?? "",
                    item.DriverObj?.user?.FullName ?? "",
                    item.DriverObj?.vehicle?.licensePlate ?? "",
                    item.BookingDetailObj?.VehicleTypeObj ?? "",
                    item.StaffObj?.user.FullName ?? "",
                    local ?? "",
                    localEnd ?? "",
                    name ?? "",
                    "Chi tiết"
                    );
                row.Cells[12].Style.WrapMode = DataGridViewTriState.True;
                dgBooking.Rows.Add(row);

            }
        }
        async Task<List<Booking>> GetBookingsAsync()
        {
            HttpRequest_v2 httpRequest = new HttpRequest_v2();

            var response = await httpRequest.SendAsync(Constant.APP_SERVER + Constant.URL_BOOKING + $"?staffId={user.Id}&search={txtSearch.Text ?? ""}&{(!isBooking ? "status=" + BookingStatus.BOOKED.ToString() : "")}", HttpMethod.Get);
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Result>(res, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                });
                if (result.status == "SUCCESS")
                {
                    try
                    {
                        var list = JsonConvert.DeserializeObject<List<Booking>>(JsonConvert.SerializeObject(result.data
                            , new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                            }), new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                            });
                        //đưa dữ liệu vào datagridview
                        return list;
                    }
                    catch (Exception ex)
                    {

                    }
                    //.Select(b=>b.ToObject<Booking>()).ToList();// result.data as List<Booking>;
                }

            }
            return new List<Booking>();

        }


        private void dgBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = sender as DataGridView;
            if (dataGrid.RowCount > 1 && e.ColumnIndex == dataGrid.ColumnCount - 1)
            {
                var row = dataGrid.Rows[e.RowIndex];
                var booking = row.Tag as Booking;

                var form = new frmBookingDetail(booking);
                form.Show();
            }
        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnToobar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadData();
            }

        }
    }
}
