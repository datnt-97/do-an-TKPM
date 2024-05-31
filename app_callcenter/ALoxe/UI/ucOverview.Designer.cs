namespace ALoxe.UI
{
    partial class ucOverview
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            containerMain = new SplitContainer();
            containerLeft = new SplitContainer();
            label2 = new Label();
            lbTongChuyen = new Label();
            label1 = new Label();
            lbTongChuyenDi = new Label();
            lbDoanhThu = new Label();
            containerSub = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)containerMain).BeginInit();
            containerMain.Panel1.SuspendLayout();
            containerMain.Panel2.SuspendLayout();
            containerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)containerLeft).BeginInit();
            containerLeft.Panel1.SuspendLayout();
            containerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)containerSub).BeginInit();
            containerSub.SuspendLayout();
            SuspendLayout();
            // 
            // containerMain
            // 
            containerMain.Dock = DockStyle.Fill;
            containerMain.Location = new Point(0, 0);
            containerMain.Name = "containerMain";
            // 
            // containerMain.Panel1
            // 
            containerMain.Panel1.Controls.Add(containerLeft);
            containerMain.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // containerMain.Panel2
            // 
            containerMain.Panel2.Controls.Add(containerSub);
            containerMain.Size = new Size(1077, 528);
            containerMain.SplitterDistance = 641;
            containerMain.TabIndex = 0;
            // 
            // containerLeft
            // 
            containerLeft.Dock = DockStyle.Fill;
            containerLeft.Location = new Point(0, 0);
            containerLeft.Name = "containerLeft";
            containerLeft.Orientation = Orientation.Horizontal;
            // 
            // containerLeft.Panel1
            // 
            containerLeft.Panel1.Controls.Add(label2);
            containerLeft.Panel1.Controls.Add(lbTongChuyen);
            containerLeft.Panel1.Controls.Add(label1);
            containerLeft.Panel1.Controls.Add(lbTongChuyenDi);
            containerLeft.Panel1.Controls.Add(lbDoanhThu);
            containerLeft.Panel1.Paint += containerLeft_Panel1_Paint;
            containerLeft.Size = new Size(641, 528);
            containerLeft.SplitterDistance = 189;
            containerLeft.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(380, 18);
            label2.Name = "label2";
            label2.Size = new Size(186, 35);
            label2.TabIndex = 3;
            label2.Text = "Tổng chuyến đi";
            // 
            // lbTongChuyen
            // 
            lbTongChuyen.AutoSize = true;
            lbTongChuyen.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbTongChuyen.Location = new Point(380, 53);
            lbTongChuyen.Name = "lbTongChuyen";
            lbTongChuyen.Size = new Size(198, 54);
            lbTongChuyen.TabIndex = 4;
            lbTongChuyen.Text = "0 Chuyến";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(193, 35);
            label1.TabIndex = 0;
            label1.Text = "Tổng doanh thu";
            // 
            // lbTongChuyenDi
            // 
            lbTongChuyenDi.AutoSize = true;
            lbTongChuyenDi.Font = new Font("Segoe UI", 11F);
            lbTongChuyenDi.ForeColor = SystemColors.ControlDarkDark;
            lbTongChuyenDi.Location = new Point(26, 107);
            lbTongChuyenDi.Name = "lbTongChuyenDi";
            lbTongChuyenDi.Size = new Size(112, 25);
            lbTongChuyenDi.TabIndex = 2;
            lbTongChuyenDi.Text = "0 Chuyến đi";
            // 
            // lbDoanhThu
            // 
            lbDoanhThu.AutoSize = true;
            lbDoanhThu.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbDoanhThu.Location = new Point(16, 53);
            lbDoanhThu.Name = "lbDoanhThu";
            lbDoanhThu.Size = new Size(146, 54);
            lbDoanhThu.TabIndex = 1;
            lbDoanhThu.Text = "0 VND";
            // 
            // containerSub
            // 
            containerSub.Dock = DockStyle.Fill;
            containerSub.IsSplitterFixed = true;
            containerSub.Location = new Point(0, 0);
            containerSub.Name = "containerSub";
            containerSub.Orientation = Orientation.Horizontal;
            // 
            // containerSub.Panel2
            // 
            containerSub.Panel2.Padding = new Padding(5);
            containerSub.Size = new Size(432, 528);
            containerSub.SplitterDistance = 411;
            containerSub.TabIndex = 0;
            // 
            // ucOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(containerMain);
            Name = "ucOverview";
            Size = new Size(1077, 528);
            Load += ucOverview_Load;
            containerMain.Panel1.ResumeLayout(false);
            containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)containerMain).EndInit();
            containerMain.ResumeLayout(false);
            containerLeft.Panel1.ResumeLayout(false);
            containerLeft.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)containerLeft).EndInit();
            containerLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)containerSub).EndInit();
            containerSub.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer containerMain;
        private SplitContainer containerSub;
        private Label lbTongChuyenDi;
        private Label lbDoanhThu;
        private Label label1;
        private SplitContainer containerLeft;
        private Label label2;
        private Label lbTongChuyen;
    }
}
