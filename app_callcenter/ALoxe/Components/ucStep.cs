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
    public partial class ucStep : UserControl
    {
        public class Step
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public int Number { get; set; }
            public bool isLast;
            public bool isFirst;
            public object data;
        }
        public Step step;
        public ucStep(Step step)
        {
            InitializeComponent();
            this.step = step;
        }

        private void ucStep_Load(object sender, EventArgs e)
        {
            lbName.Text = step.Name;
            lbDes.Text = step.Description;
            btnStep.Text = step.Number.ToString();
            if (step.isLast)
            {
                pnProgress.Visible = false;
            }
        }

        public void Active()
        {
            btnStep.Image = Properties.Resources.Check;
            pnProgress.BackColor = Color.FromArgb(0, 192, 0);
        }
    }
}
