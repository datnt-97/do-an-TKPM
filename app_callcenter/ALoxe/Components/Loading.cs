using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALoxe.Components
{
    public partial class Loading : UserControl
    {
        public Loading()
        {
            //set background color to transparent for form
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            //set opacity for form
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
