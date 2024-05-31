using ALoxe.Common;
using ALoxe.Infrastructure.Data;
using Newtonsoft.Json.Linq;
using ScottPlot;
using ScottPlot.Colormaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALoxe.UI
{
    public partial class ucOverview : UserControl
    {
        public class PieChartOrderItem
        {
            public string ValueName;
            public double Value;
            public string Name;
            public string Color = "#FF0000";

        }
        public class PieChartOrder
        {
            public List<PieChartOrderItem> data;
            public string label;
        }
        PieChartOrder _chartOrder;
        private List<Booking> _list = new List<Booking>();
        public ucOverview()
        {
            InitializeComponent();
            loadData();
            BookingStatus[] allow = { BookingStatus.BOOKED, BookingStatus.PAID, BookingStatus.CANCELLED, BookingStatus.DRIVER_FOUND };
            var g = _list.Where(n => allow.Contains(n.bookingStatus)).GroupBy(n => n.bookingStatus.ToString());
            var total = _list.Count;
            var totalAmount = _list.Where(b => b.bookingStatus == BookingStatus.PAID).Sum(x => x.Amount);
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            lbDoanhThu.Text = String.Format(info, "{0:c}", (totalAmount ?? 0));
            lbTongChuyen.Text = _list.Count + " chuyến đi";
            lbTongChuyenDi.Text = _list.Where(b => b.bookingStatus == BookingStatus.PAID).Count().ToString() + " chuyến đi hoàn thành";
            var data = Enum.GetValues(typeof(BookingStatus)).Cast<BookingStatus>().ToList().Where(b => allow.Contains(b)).Select(c =>
             {
                 //get attribute display name of enum
                 var memInfo = typeof(BookingStatus).GetMember(c.ToString());
                 var attr = memInfo[0].GetCustomAttributes(typeof(DisplayAttribute), false);
                 var nameAttr = memInfo[0].GetCustomAttributes(typeof(NameValue), false);
                 var color = ((DisplayAttribute)attr[0]).Name;
                 var name = ((NameValue)nameAttr[0]).Name;
                 var s = g.FirstOrDefault(x => x.Key == c.ToString());
                 return new PieChartOrderItem
                 {
                     Name = name,
                     ValueName = (s?.Count() ?? 0) + " (" + Math.Round(((s?.Count() ?? 0) * 1.0 / total * 100), 2) + "%)",
                     Value = Math.Round(((s?.Count() ?? 0) * 1.0 / total * 100), 2),
                     Color = color
                 };
             }).ToList();

            _chartOrder = new PieChartOrder
            {
                data = data,
                label = "Tình trạng đơn hàng"
            };
        }

        void loadData()
        {

            var loading = new frmLoading(async (l) =>
            {
                _list = await Util.GetBookingsAsync();
                l.PerformSafely(() =>
                {
                    l.Close();
                });
            });
            loading.ShowDialog();
        }
        private void ucOverview_Load(object sender, EventArgs e)
        {
            var fp = new ScottPlot.WinForms.FormsPlot() { Dock = DockStyle.Fill };
            fp.Plot.Title("Biểu đồ tình trạng đơn hàng");

            var pies = new List<PieSlice>();
            _chartOrder.data.ForEach(x =>
            {
                pies.Add(new PieSlice(x.Value, ScottPlot.Color.FromHex(x.Color)));
            });
            fp.Plot.Add.Pie(pies);
            var p = fp.Plot.GetPlottables().First();
            containerSub.Panel1.Controls.Add(fp);

            var location = new Point(0, 0);
            foreach (var item in _chartOrder.data)
            {
                //add button to panel 
                var btn = new Button();
                btn.Text = item.Name + " : " + item.ValueName;
                btn.Dock = DockStyle.None;
                var color = ScottPlot.Color.FromHex(item.Color);
                btn.BackColor = System.Drawing.Color.FromArgb(color.R, color.G, color.B);
                //set location for button
                btn.Location = location;
                //set width auto size
                btn.AutoSize = true;
                containerSub.Panel2.Controls.Add(btn);
                var width = location.X + btn.Width;
                if (width > containerSub.Panel2.Width)
                {
                    location.X = 0;
                    location.Y += btn.Height + 5;
                }
                else
                {
                    location.X += btn.Width + 5;
                }

            }

            var fp2 = new ScottPlot.WinForms.FormsPlot() { Dock = DockStyle.Fill };
            //biểu đồ line chart theo tháng dữ liệu danh sách booking
            var g = _list.GroupBy(n =>
            {
                var dateForHour = n.StartTime.ToString("yyyy-MM-dd HH");
                var d = DateTime.ParseExact(dateForHour, "yyyy-MM-dd HH", null);
                return d.ToOADate();
            });
            var plt = fp2.Plot;
            plt.Title("Biểu đồ số lượng chuyến đi theo ngày");
            plt.YLabel("Số lượng chuyến đi");
            plt.XLabel("Ngày");
            int[] dateData = g.Select(x => new { c = x.Count(), x.Key }).OrderBy(b => b.Key).Select(b => b.c).Take(30).ToArray();

            double[] dates = g.Select(x => x.Key).OrderBy(n => n).Take(30).ToArray();
            var sca = fp2.Plot.Add.Scatter(dates, dateData);
            plt.Axes.DateTimeTicksBottom();
            // Store the primary Y axis so we can refer to it later
            //var YAxis1 = plt.Axes.Left;

            //var sig1 = fp2.Plot.Add.Signal(dateData);

            //sig1.MarkerSize = 5;
            //fp2.Plot.Axes.AutoScale();
            //fp2.Plot.Axes.Zoom(.8, .7);
            containerLeft.Panel2.Controls.Add(fp2);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void containerLeft_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
