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
    public partial class frmLoading : Form
    {
        Action<frmLoading> action;
        public frmLoading(Action<frmLoading> action, string title = "")
        {
            InitializeComponent();
            //set không cho resize form
            this.FormBorderStyle = FormBorderStyle.None;
            //set opacity for form 30%
            this.Opacity = .80D;
            this.action = action;
            lbTitle.Text = title;
            if (string.IsNullOrEmpty(title))
            {
                lbTitle.Visible = false;
            }
            else
            {
                lbTitle.Visible = true;
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            this.Shown += FrmLoading_Activated;
        }

        private async void FrmLoading_Activated(object? sender, EventArgs e)
        {
            await Task.Run(() =>
             {
                 action(this);
             });
        }
    }
}
