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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            lbTongChuyenDi = new Label();
            lbDoanhThu = new Label();
            label1 = new Label();
            containerSub = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)containerMain).BeginInit();
            containerMain.Panel1.SuspendLayout();
            containerMain.Panel2.SuspendLayout();
            containerMain.SuspendLayout();
            panel1.SuspendLayout();
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
            containerMain.Panel1.Controls.Add(panel1);
            containerMain.Panel1.Controls.Add(lbTongChuyenDi);
            containerMain.Panel1.Controls.Add(lbDoanhThu);
            containerMain.Panel1.Controls.Add(label1);
            containerMain.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // containerMain.Panel2
            // 
            containerMain.Panel2.Controls.Add(containerSub);
            containerMain.Size = new Size(1077, 493);
            containerMain.SplitterDistance = 641;
            containerMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 385);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 108);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label3.Location = new Point(353, 31);
            label3.Name = "label3";
            label3.Size = new Size(202, 40);
            label3.TabIndex = 4;
            label3.Text = "0 Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(121, 40);
            label2.TabIndex = 3;
            label2.Text = "0 Tài xế";
            // 
            // lbTongChuyenDi
            // 
            lbTongChuyenDi.AutoSize = true;
            lbTongChuyenDi.Font = new Font("Segoe UI", 11F);
            lbTongChuyenDi.ForeColor = SystemColors.ControlDarkDark;
            lbTongChuyenDi.Location = new Point(40, 129);
            lbTongChuyenDi.Name = "lbTongChuyenDi";
            lbTongChuyenDi.Size = new Size(112, 25);
            lbTongChuyenDi.TabIndex = 2;
            lbTongChuyenDi.Text = "0 Chuyến đi";
            // 
            // lbDoanhThu
            // 
            lbDoanhThu.AutoSize = true;
            lbDoanhThu.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbDoanhThu.Location = new Point(30, 75);
            lbDoanhThu.Name = "lbDoanhThu";
            lbDoanhThu.Size = new Size(146, 54);
            lbDoanhThu.TabIndex = 1;
            lbDoanhThu.Text = "0 VND";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(193, 35);
            label1.TabIndex = 0;
            label1.Text = "Tổng doanh thu";
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
            containerSub.Size = new Size(432, 493);
            containerSub.SplitterDistance = 385;
            containerSub.TabIndex = 0;
            // 
            // ucOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(containerMain);
            Name = "ucOverview";
            Size = new Size(1077, 493);
            Load += ucOverview_Load;
            containerMain.Panel1.ResumeLayout(false);
            containerMain.Panel1.PerformLayout();
            containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)containerMain).EndInit();
            containerMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label3;
        private Label label2;
        private Panel panel1;
    }
}
