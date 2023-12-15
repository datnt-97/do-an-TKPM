namespace ALoxe.UI
{
    partial class frmMainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            pnMain = new Panel();
            MenuVertical = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnsalir = new PictureBox();
            panel4 = new Panel();
            panel3 = new Panel();
            btnCustomer = new Button();
            btnHistory = new Button();
            btninicio = new PictureBox();
            toolTip1 = new ToolTip(components);
            lbUserName = new Label();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btninicio).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = SystemColors.ButtonFace;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(293, 0);
            pnMain.Margin = new Padding(4, 5, 4, 5);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1279, 734);
            pnMain.TabIndex = 5;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnCustomer);
            MenuVertical.Controls.Add(btnHistory);
            MenuVertical.Controls.Add(btninicio);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 5, 4, 5);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(293, 734);
            MenuVertical.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbUserName);
            panel2.Controls.Add(btnsalir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 664);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 70);
            panel2.TabIndex = 0;
            // 
            // btnsalir
            // 
            btnsalir.Cursor = Cursors.Hand;
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(4, 10);
            btnsalir.Margin = new Padding(4, 5, 4, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(46, 55);
            btnsalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnsalir.TabIndex = 16;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 279);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(7, 62);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 208);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(7, 62);
            panel3.TabIndex = 6;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(26, 32, 40);
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(4, 279);
            btnCustomer.Margin = new Padding(4, 5, 4, 5);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(289, 62);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Lịch hẹn";
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(26, 32, 40);
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(4, 208);
            btnHistory.Margin = new Padding(4, 5, 4, 5);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(289, 62);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "Lịch sửa đặt xe";
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // btninicio
            // 
            btninicio.Cursor = Cursors.Hand;
            btninicio.Dock = DockStyle.Top;
            btninicio.Location = new Point(0, 0);
            btninicio.Margin = new Padding(4, 5, 4, 5);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(293, 179);
            btninicio.SizeMode = PictureBoxSizeMode.Zoom;
            btninicio.TabIndex = 0;
            btninicio.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.ForeColor = SystemColors.ButtonHighlight;
            lbUserName.Location = new Point(66, 24);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(50, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "label1";
            // 
            // frmMainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 734);
            Controls.Add(pnMain);
            Controls.Add(MenuVertical);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng đặt xe";
            Load += frmMainWindow_Load;
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btninicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Panel MenuVertical;
        private PictureBox btnsalir;
        private Panel panel4;
        private Panel panel3;
        private Button btnCustomer;
        private Button btnHistory;
        private PictureBox btninicio;
        private Panel panel2;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Label lbUserName;
    }
}