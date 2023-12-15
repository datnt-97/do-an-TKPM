using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ALoxe.Components.ucStep;

namespace ALoxe.Components
{
    public partial class ucStepH : UserControl
    {
        public Step step;

        public ucStepH(Step step)
        {
            InitializeComponent();
            this.step = step;
            //tạo 3 row cho pnTest (panel)
            //row 2 là row label name step size (100,20) ở giữa 
            //row 3 là row label description step size (100,20) ở giữa
            button = new CircleImageButton();
            pnTest.Dock = DockStyle.Fill;
            //row 1 là row Circlebutton size 40,40 ở giữa. 1 panel nhỏ bên trái size (50,4) ,location nằm bên trái của circlebutton. 1 panel nhỏ bên phải size (50,4) ,location nằm bên phải của circlebutton
            button.Size = new Size(40, 40);
            button.Text = step.Number.ToString();
            button.Font=new Font(button.Font.FontFamily, 10, FontStyle.Bold);
            //bacground color là màu trắng 
            button.BackColor = Color.White;
            //set button nằm giữa panel
            button.Location = new Point((pnTest.Width - button.Width) / 2, (pnTest.Height - button.Height) / 2);
            pnTest.Controls.Add(button);

            //panel nhỏ bên trái
            panelLeft = new Panel();
            panelLeft.Size = new Size(50, 4);
            panelLeft.Location = new Point(button.Location.X - panelLeft.Width, (pnTest.Height - panelLeft.Height) / 2);
            panelLeft.BackColor = Color.Gray;
            //viền đen
            pnTest.Controls.Add(panelLeft);
            //panel nhỏ bên phải
            panelRight = new Panel();
            panelRight.Size = new Size(50, 4);
            panelRight.Location = new Point(button.Location.X + button.Width, (pnTest.Height - panelRight.Height) / 2);
            panelRight.BackColor = Color.Gray;
            //viền đen

            pnTest.Controls.Add(panelRight);

            //row 2 là row label name step nằm dưới button
            lbTitle = new Label();

            lbTitle.Text = step.Name;
            lbTitle.Size = new Size(130, 50);
            lbTitle.Location = new Point((pnTest.Width - lbTitle.Width) / 2, button.Location.Y + button.Height + 3);
            //set bold
            //font size 12
            lbTitle.Font = new Font(lbTitle.Font.FontFamily, 8, FontStyle.Bold);
            lbTitle.MaximumSize = new Size(130, 50);


            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            pnTest.Controls.Add(lbTitle);

            //row 3 là row label description step nằm dưới label name step

            var lbDescription = new Label();
            lbDescription.Text = step.Description;
            lbDescription.Size = new Size(130, 20);
            lbDescription.MaximumSize = new Size(130, 20);
            lbDescription.Location = new Point((pnTest.Width - lbDescription.Width) / 2, lbTitle.Location.Y + lbTitle.Height + 2);
            //font size 10
            lbDescription.Font = new Font(lbDescription.Font.FontFamily, 8);

            lbDescription.TextAlign = ContentAlignment.MiddleCenter;

            if (step.isFirst)
            {
                panelLeft.Visible = false;
            }
            if (step.isLast)
            {
                panelRight.Visible = false;
            }
        }
        CircleImageButton button;
        Label lbTitle;
        Label lbDescription;
        Panel panelLeft;
        Panel panelRight;

        private void ucStepH_Load(object sender, EventArgs e)
        {

           
        }

        public void Active()
        {
            button.Image = Properties.Resources.Check;
            ActiveLeft();
            ActiveRight();

        }
        public void InActive()
        {
            button.Image = null;
            InActiveLeft();
            InActiveRight();
        }
        public void ActiveLeft()
        {
            panelLeft.BackColor = Color.FromArgb(0, 192, 0);
        }
        public void InActiveLeft()
        {
            panelLeft.BackColor = Color.Gray;
        }
        public void InActiveRight()
        {
            panelRight.BackColor = Color.Gray;
        }
        public void ActiveRight()
        {
            panelRight.BackColor = Color.FromArgb(0, 192, 0);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void lbDes_Click(object sender, EventArgs e)
        {

        }
    }
}
