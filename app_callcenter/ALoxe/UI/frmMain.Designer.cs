namespace ALoxe.UI
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            splitContainer1 = new SplitContainer();
            lbVersion = new Label();
            btn = new Components.RJButton();
            btnDriver = new Components.RJButton();
            btnReceive = new Components.RJButton();
            pnMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(64, 64, 64);
            splitContainer1.Panel1.Controls.Add(lbVersion);
            splitContainer1.Panel1.Controls.Add(btn);
            splitContainer1.Panel1.Controls.Add(btnDriver);
            splitContainer1.Panel1.Controls.Add(btnReceive);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Menu;
            splitContainer1.Panel2.Controls.Add(pnMain);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1244, 540);
            splitContainer1.SplitterDistance = 142;
            splitContainer1.TabIndex = 0;
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Dock = DockStyle.Bottom;
            lbVersion.ForeColor = SystemColors.ButtonHighlight;
            lbVersion.Location = new Point(0, 520);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(50, 20);
            lbVersion.TabIndex = 4;
            lbVersion.Text = "label1";
            lbVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn.BackColor = Color.MediumSlateBlue;
            btn.BackgroundColor = Color.MediumSlateBlue;
            btn.BorderColor = Color.PaleVioletRed;
            btn.BorderRadius = 0;
            btn.BorderSize = 0;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.Location = new Point(1, 135);
            btn.Name = "btn";
            btn.Size = new Size(140, 36);
            btn.TabIndex = 3;
            btn.Text = "Định vị";
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.TextColor = Color.White;
            btn.UseVisualStyleBackColor = false;
            // 
            // btnDriver
            // 
            btnDriver.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDriver.BackColor = Color.MediumSlateBlue;
            btnDriver.BackgroundColor = Color.MediumSlateBlue;
            btnDriver.BorderColor = Color.PaleVioletRed;
            btnDriver.BorderRadius = 0;
            btnDriver.BorderSize = 0;
            btnDriver.FlatAppearance.BorderSize = 0;
            btnDriver.FlatStyle = FlatStyle.Flat;
            btnDriver.ForeColor = Color.White;
            btnDriver.Location = new Point(1, 97);
            btnDriver.Name = "btnDriver";
            btnDriver.Size = new Size(140, 36);
            btnDriver.TabIndex = 2;
            btnDriver.Text = "Lịch sử chuyến đi";
            btnDriver.TextAlign = ContentAlignment.MiddleLeft;
            btnDriver.TextColor = Color.White;
            btnDriver.UseVisualStyleBackColor = false;
            // 
            // btnReceive
            // 
            btnReceive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReceive.BackColor = Color.MediumSlateBlue;
            btnReceive.BackgroundColor = Color.MediumSlateBlue;
            btnReceive.BorderColor = Color.PaleVioletRed;
            btnReceive.BorderRadius = 0;
            btnReceive.BorderSize = 0;
            btnReceive.FlatAppearance.BorderSize = 0;
            btnReceive.FlatStyle = FlatStyle.Flat;
            btnReceive.ForeColor = Color.White;
            btnReceive.Location = new Point(0, 59);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(140, 36);
            btnReceive.TabIndex = 1;
            btnReceive.Text = "Tiếp nhận";
            btnReceive.TextAlign = ContentAlignment.MiddleLeft;
            btnReceive.TextColor = Color.White;
            btnReceive.UseVisualStyleBackColor = false;
            // 
            // pnMain
            // 
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Padding = new Padding(5, 0, 5, 0);
            pnMain.Size = new Size(1098, 540);
            pnMain.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 540);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Màn hình chính";
            Load += frmMain_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Components.RJButton btnReceive;
        private Components.RJButton btn;
        private Components.RJButton btnDriver;
        private Label lbVersion;
        private Panel pnMain;
    }
}