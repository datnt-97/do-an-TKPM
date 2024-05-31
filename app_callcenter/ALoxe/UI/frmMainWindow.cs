using ALoxe.Components;
using ALoxe.Infrastructure.DB;
using ALoxe.Infrastructure.Model;
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
    public partial class frmMainWindow : Form
    {
        int _index = 0;
        Color _colorDefault = Color.FromArgb(100, 64, 224, 208);
        //set color for active button is warning color
        Color _colorBackgrondActive = Color.FromArgb(255, 204, 0);
        Button[] _buttons;
        private void GetVersionAndBuild()
        {
            //get version and build
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            var build = version.Build;
            var major = version.Major;
            var minor = version.Minor;
            var revision = version.Revision;
            var versionString = string.Format("Ver : {0}.{1}.{2}.{3}", major, minor, build, revision);
            //set version to label
            //lbVersion.Text = versionString;

        }
        AppDBContext db = new AppDBContext();
        UserModel user;
        public frmMainWindow()
        {
            InitializeComponent();
            _buttons = new Button[] {
            btnOverview, btnHistory,btnCustomer,
            };
            GetVersionAndBuild();
            user = db.Users.ToList().FirstOrDefault();


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            var login = new frmLogin(db);
            var u = db.Users.ToList().FirstOrDefault();

            if (u == null)
            {
                login.Closed += (s, e) => this.Close();
                login.Show();
                this.Hide();
            }

            foreach (var item in _buttons)
            {
                item.BackColor = _colorDefault;
                item.Click += Item_Click;
            }
            Active();
            lbUserName.Text = "Xin chào " + user.FullName;
        }
        private void Item_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            _index = Array.IndexOf(_buttons, button);
            Active();
        }
        public void Active()
        {
            foreach (var item in _buttons)
            {
                item.BackColor = _colorDefault;
            }
            _buttons[_index].BackColor = _colorBackgrondActive;

            pnMain.Controls.Clear();

            switch (_index)
            {
                case 0:
                    var frmOverview = new ucOverview();
                    pnMain.Controls.Add(frmOverview);
                    frmOverview.Dock = DockStyle.Fill;
                    break;
                case 1:
                    //add control to panel
                    var frmReceive = new ucBookCar(this, user);
                    pnMain.Controls.Add(frmReceive);
                    frmReceive.Dock = DockStyle.Fill;
                    break;
                case 2:
                    var frmReceive2 = new ucBookCar(this, user, false);
                    pnMain.Controls.Add(frmReceive2);
                    frmReceive2.Dock = DockStyle.Fill;
                    break;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            db.Users.RemoveRange(db.Users);
            db.SaveChanges();
            //reload this form
            Application.Restart();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
