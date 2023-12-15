namespace ALoxe.UI
{
    partial class frmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            cbPhuong = new ComboBox();
            cbTP = new ComboBox();
            cbQuan = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTenKH = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            groupBox1 = new GroupBox();
            lbVip = new Label();
            dtpVIP = new DateTimePicker();
            rdVIP = new RadioButton();
            rd7 = new RadioButton();
            rd5 = new RadioButton();
            rd4 = new RadioButton();
            rjButton1 = new Components.RJButton();
            rjButton2 = new Components.RJButton();
            lbMessage = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            cbTPDen = new ComboBox();
            cbPhuongDen = new ComboBox();
            cbQuanDen = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtDiaChiDen = new TextBox();
            label11 = new Label();
            pnMap = new Panel();
            btnBook = new Components.RJButton();
            elhMap = new Components.ElementHostCustom();
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            label12 = new Label();
            lbLocationFrom = new Label();
            lbLocationTo = new Label();
            btnXoaLocation = new Components.RJButton();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbPhuong
            // 
            cbPhuong.FormattingEnabled = true;
            cbPhuong.Location = new Point(112, 107);
            cbPhuong.Name = "cbPhuong";
            cbPhuong.Size = new Size(353, 28);
            cbPhuong.TabIndex = 0;
            // 
            // cbTP
            // 
            cbTP.FormattingEnabled = true;
            cbTP.Location = new Point(112, 26);
            cbTP.Name = "cbTP";
            cbTP.Size = new Size(353, 28);
            cbTP.TabIndex = 1;
            cbTP.SelectedIndexChanged += cbTP_SelectedIndexChanged;
            // 
            // cbQuan
            // 
            cbQuan.FormattingEnabled = true;
            cbQuan.Location = new Point(112, 65);
            cbQuan.Name = "cbQuan";
            cbQuan.Size = new Size(353, 28);
            cbQuan.TabIndex = 2;
            cbQuan.SelectedIndexChanged += cbQuan_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 110);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 3;
            label1.Text = "Xã/ Phường";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 4;
            label2.Text = "Quận/ Huyện";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Tỉnh/TP";
            // 
            // txtDiaChi
            // 
            txtDiaChi.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(112, 144);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(353, 27);
            txtDiaChi.TabIndex = 6;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 151);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 54);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 9;
            label5.Text = "Tên KH";
            // 
            // txtTenKH
            // 
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Location = new Point(138, 47);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(210, 27);
            txtTenKH.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 99);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 11;
            label6.Text = "Số ĐT";
            // 
            // txtSDT
            // 
            txtSDT.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(138, 92);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(210, 27);
            txtSDT.TabIndex = 10;
            txtSDT.TextChanged += txtSDT_TextChanged;
            txtSDT.KeyDown += txtSDT_KeyDown;
            txtSDT.MouseEnter += txtSDT_MouseEnter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 32);
            panel1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(12, 0);
            label7.Name = "label7";
            label7.Size = new Size(202, 32);
            label7.TabIndex = 0;
            label7.Text = "Thông tin đặt xe";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbVip);
            groupBox1.Controls.Add(dtpVIP);
            groupBox1.Controls.Add(rdVIP);
            groupBox1.Controls.Add(rd7);
            groupBox1.Controls.Add(rd5);
            groupBox1.Controls.Add(rd4);
            groupBox1.Location = new Point(741, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 96);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại xe";
            // 
            // lbVip
            // 
            lbVip.AutoSize = true;
            lbVip.Location = new Point(164, 65);
            lbVip.Name = "lbVip";
            lbVip.Size = new Size(95, 20);
            lbVip.TabIndex = 19;
            lbVip.Text = "Đặt lịch (VIP)";
            lbVip.Visible = false;
            lbVip.Click += lbVip_Click;
            // 
            // dtpVIP
            // 
            dtpVIP.Format = DateTimePickerFormat.Custom;
            dtpVIP.Location = new Point(272, 62);
            dtpVIP.Name = "dtpVIP";
            dtpVIP.Size = new Size(202, 27);
            dtpVIP.TabIndex = 4;
            dtpVIP.Visible = false;
            // 
            // rdVIP
            // 
            rdVIP.AutoSize = true;
            rdVIP.Location = new Point(396, 26);
            rdVIP.Name = "rdVIP";
            rdVIP.Size = new Size(72, 24);
            rdVIP.TabIndex = 3;
            rdVIP.Text = "Xe VIP";
            rdVIP.UseVisualStyleBackColor = true;
            rdVIP.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rd7
            // 
            rd7.AutoSize = true;
            rd7.Location = new Point(262, 26);
            rd7.Name = "rd7";
            rd7.Size = new Size(87, 24);
            rd7.TabIndex = 2;
            rd7.Text = "Xe 7 chỗ";
            rd7.UseVisualStyleBackColor = true;
            rd7.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rd5
            // 
            rd5.AutoSize = true;
            rd5.Location = new Point(129, 26);
            rd5.Name = "rd5";
            rd5.Size = new Size(87, 24);
            rd5.TabIndex = 1;
            rd5.Text = "Xe 5 chỗ";
            rd5.UseVisualStyleBackColor = true;
            rd5.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rd4
            // 
            rd4.AutoSize = true;
            rd4.Checked = true;
            rd4.Location = new Point(9, 26);
            rd4.Name = "rd4";
            rd4.Size = new Size(87, 24);
            rd4.TabIndex = 0;
            rd4.TabStop = true;
            rd4.Text = "Xe 4 chỗ";
            rd4.UseVisualStyleBackColor = true;
            rd4.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumTurquoise;
            rjButton1.BackgroundColor = Color.MediumTurquoise;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(210, 633);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(177, 41);
            rjButton1.TabIndex = 16;
            rjButton1.Text = "Định vị";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.LightSlateGray;
            rjButton2.BackgroundColor = Color.LightSlateGray;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(402, 633);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(146, 41);
            rjButton2.TabIndex = 17;
            rjButton2.Text = "Hủy";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(32, 570);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(50, 20);
            lbMessage.TabIndex = 18;
            lbMessage.Text = "label9";
            lbMessage.Visible = false;
            lbMessage.Click += lbMessage_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(cbTP);
            groupBox2.Controls.Add(cbPhuong);
            groupBox2.Controls.Add(cbQuan);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(481, 189);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Địa điểm đón khách";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientInactiveCaption;
            groupBox3.Controls.Add(cbTPDen);
            groupBox3.Controls.Add(cbPhuongDen);
            groupBox3.Controls.Add(cbQuanDen);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtDiaChiDen);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 376);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(481, 190);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Địa điểm đến";
            // 
            // cbTPDen
            // 
            cbTPDen.FormattingEnabled = true;
            cbTPDen.Location = new Point(112, 26);
            cbTPDen.Name = "cbTPDen";
            cbTPDen.Size = new Size(353, 28);
            cbTPDen.TabIndex = 1;
            cbTPDen.SelectedIndexChanged += cbTPDen_SelectedIndexChanged;
            // 
            // cbPhuongDen
            // 
            cbPhuongDen.FormattingEnabled = true;
            cbPhuongDen.Location = new Point(112, 108);
            cbPhuongDen.Name = "cbPhuongDen";
            cbPhuongDen.Size = new Size(353, 28);
            cbPhuongDen.TabIndex = 0;
            // 
            // cbQuanDen
            // 
            cbQuanDen.FormattingEnabled = true;
            cbQuanDen.Location = new Point(112, 66);
            cbQuanDen.Name = "cbQuanDen";
            cbQuanDen.Size = new Size(353, 28);
            cbQuanDen.TabIndex = 2;
            cbQuanDen.SelectedIndexChanged += cbQuanDen_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 108);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 3;
            label8.Text = "Xã/ Phường";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 69);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 4;
            label9.Text = "Quận/ Huyện";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 29);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 5;
            label10.Text = "Tỉnh/TP";
            // 
            // txtDiaChiDen
            // 
            txtDiaChiDen.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChiDen.Location = new Point(112, 145);
            txtDiaChiDen.Name = "txtDiaChiDen";
            txtDiaChiDen.Size = new Size(353, 27);
            txtDiaChiDen.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 152);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 7;
            label11.Text = "Địa chỉ";
            // 
            // pnMap
            // 
            pnMap.Location = new Point(527, 137);
            pnMap.Name = "pnMap";
            pnMap.Size = new Size(695, 429);
            pnMap.TabIndex = 21;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.ControlLight;
            btnBook.BackgroundColor = SystemColors.ControlLight;
            btnBook.BorderColor = Color.PaleVioletRed;
            btnBook.BorderRadius = 15;
            btnBook.BorderSize = 0;
            btnBook.Enabled = false;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(15, 633);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(177, 41);
            btnBook.TabIndex = 22;
            btnBook.Text = "Đặt xe";
            btnBook.TextColor = Color.White;
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += rjButton3_Click;
            // 
            // elhMap
            // 
            elhMap.Location = new Point(0, 0);
            elhMap.Name = "elhMap";
            elhMap.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(481, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 27);
            txtEmail.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(402, 47);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 27;
            label12.Text = "Email";
            // 
            // lbLocationFrom
            // 
            lbLocationFrom.AutoSize = true;
            lbLocationFrom.Location = new Point(527, 584);
            lbLocationFrom.Name = "lbLocationFrom";
            lbLocationFrom.Size = new Size(50, 20);
            lbLocationFrom.TabIndex = 28;
            lbLocationFrom.Text = "label9";
            lbLocationFrom.Visible = false;
            // 
            // lbLocationTo
            // 
            lbLocationTo.AutoSize = true;
            lbLocationTo.Location = new Point(750, 584);
            lbLocationTo.Name = "lbLocationTo";
            lbLocationTo.Size = new Size(50, 20);
            lbLocationTo.TabIndex = 29;
            lbLocationTo.Text = "label9";
            lbLocationTo.Visible = false;
            // 
            // btnXoaLocation
            // 
            btnXoaLocation.BackColor = SystemColors.AppWorkspace;
            btnXoaLocation.BackgroundColor = SystemColors.AppWorkspace;
            btnXoaLocation.BorderColor = Color.PaleVioletRed;
            btnXoaLocation.BorderRadius = 15;
            btnXoaLocation.BorderSize = 0;
            btnXoaLocation.Enabled = false;
            btnXoaLocation.FlatAppearance.BorderSize = 0;
            btnXoaLocation.FlatStyle = FlatStyle.Flat;
            btnXoaLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaLocation.ForeColor = Color.White;
            btnXoaLocation.Location = new Point(1101, 574);
            btnXoaLocation.Name = "btnXoaLocation";
            btnXoaLocation.Size = new Size(114, 38);
            btnXoaLocation.TabIndex = 30;
            btnXoaLocation.Text = "Xóa tọa độ";
            btnXoaLocation.TextColor = Color.White;
            btnXoaLocation.UseVisualStyleBackColor = false;
            btnXoaLocation.Visible = false;
            btnXoaLocation.Click += btnXoaLocation_Click;
            // 
            // frmBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1253, 920);
            Controls.Add(btnXoaLocation);
            Controls.Add(lbLocationTo);
            Controls.Add(lbLocationFrom);
            Controls.Add(label12);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Controls.Add(btnBook);
            Controls.Add(pnMap);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(lbMessage);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(txtSDT);
            Controls.Add(label5);
            Controls.Add(txtTenKH);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1090, 585);
            Name = "frmBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking";
            Load += BookingCRUD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPhuong;
        private ComboBox cbTP;
        private ComboBox cbQuan;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label4;
        private Label label5;
        private TextBox txtTenKH;
        private Label label6;
        private TextBox txtSDT;
        private Panel panel1;
        private Label label7;
        private GroupBox groupBox1;
        private RadioButton rdVIP;
        private RadioButton rd7;
        private RadioButton rd5;
        private RadioButton rd4;
        private Components.RJButton rjButton1;
        private Components.RJButton rjButton2;
        private Label lbMessage;
        private Label lbVip;
        private DateTimePicker dtpVIP;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cbTPDen;
        private ComboBox cbPhuongDen;
        private ComboBox cbQuanDen;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDiaChiDen;
        private Label label11;
        private Panel pnMap;
        private Components.RJButton btnBook;
        private Components.ElementHostCustom elhMap;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label label12;
        private Label lbLocationFrom;
        private Label lbLocationTo;
        private Components.RJButton btnXoaLocation;
    }
}