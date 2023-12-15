using ALoxe.Components;
using ALoxe.Infrastructure.DB;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ALoxe.UI
{
    public partial class frmMain : Form
    {
        int _index = 0;
        Color _colorDefault = Color.FromArgb(100, 64, 224, 208);
        //set color for active button is warning color
        Color _colorBackgrondActive = Color.FromArgb(255, 204, 0);
        RJButton[] _buttons;

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
            lbVersion.Text = versionString;

        }
        AppDBContext db = new AppDBContext();
        public frmMain()
        {
            InitializeComponent();

            _buttons = new RJButton[] {
            btnReceive,btnDriver,btn
            };
            GetVersionAndBuild();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            foreach (var item in _buttons)
            {
                item.BackColor = _colorDefault;
                item.Click += Item_Click;
            }
            Active();

        }

        private void Item_Click(object sender, EventArgs e)
        {
            var button = sender as RJButton;
            _index = Array.IndexOf(_buttons, button);
            Active();
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {

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
                    var frmReceive = new ucBookCar(this);
                    //add control to panel

                    pnMain.Controls.Add(frmReceive);
                    frmReceive.Dock = DockStyle.Fill;
                    break;
                default:
                    break;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
