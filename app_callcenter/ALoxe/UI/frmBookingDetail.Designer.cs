namespace ALoxe.UI
{
    partial class frmBookingDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingDetail));
            pnTaiXe = new Panel();
            lbSDTTX = new LinkLabel();
            lbTaiXe = new Label();
            lbBangCap = new Label();
            lbLoaiXe = new Label();
            pbTaiXe = new PictureBox();
            lbBienSo = new Label();
            label6 = new Label();
            panel2 = new Panel();
            lbTenKH = new Label();
            lbSDT_KH = new LinkLabel();
            lbEmailKH = new LinkLabel();
            pbKH = new PictureBox();
            label7 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            lbLoaiXeBooking = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbNgayDat = new Label();
            blGiaTien = new Label();
            lbKC = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbDen = new Label();
            lbDi = new Label();
            pictureBox5 = new PictureBox();
            pnMap = new Panel();
            bookingBindingSource = new BindingSource(components);
            pnStepH = new Panel();
            pnTaiXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTaiXe).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbKH).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnTaiXe
            // 
            pnTaiXe.BorderStyle = BorderStyle.FixedSingle;
            pnTaiXe.Controls.Add(lbSDTTX);
            pnTaiXe.Controls.Add(lbTaiXe);
            pnTaiXe.Controls.Add(lbBangCap);
            pnTaiXe.Controls.Add(lbLoaiXe);
            pnTaiXe.Controls.Add(pbTaiXe);
            pnTaiXe.Controls.Add(lbBienSo);
            pnTaiXe.Location = new Point(20, 165);
            pnTaiXe.Name = "pnTaiXe";
            pnTaiXe.Size = new Size(369, 123);
            pnTaiXe.TabIndex = 0;
            // 
            // lbSDTTX
            // 
            lbSDTTX.AutoSize = true;
            lbSDTTX.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSDTTX.Location = new Point(109, 64);
            lbSDTTX.Name = "lbSDTTX";
            lbSDTTX.Size = new Size(36, 20);
            lbSDTTX.TabIndex = 30;
            lbSDTTX.TabStop = true;
            lbSDTTX.Text = "SDT";
            // 
            // lbTaiXe
            // 
            lbTaiXe.AutoSize = true;
            lbTaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTaiXe.Location = new Point(6, 98);
            lbTaiXe.Name = "lbTaiXe";
            lbTaiXe.Size = new Size(77, 20);
            lbTaiXe.TabIndex = 29;
            lbTaiXe.Text = "họ tên TX";
            // 
            // lbBangCap
            // 
            lbBangCap.AutoSize = true;
            lbBangCap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbBangCap.Location = new Point(107, 92);
            lbBangCap.Name = "lbBangCap";
            lbBangCap.Size = new Size(72, 20);
            lbBangCap.TabIndex = 28;
            lbBangCap.Text = "bằng cấp";
            // 
            // lbLoaiXe
            // 
            lbLoaiXe.AutoSize = true;
            lbLoaiXe.Font = new Font("Segoe UI", 8F);
            lbLoaiXe.Location = new Point(107, 43);
            lbLoaiXe.Name = "lbLoaiXe";
            lbLoaiXe.Size = new Size(47, 19);
            lbLoaiXe.TabIndex = 27;
            lbLoaiXe.Text = "loại xe";
            // 
            // pbTaiXe
            // 
            pbTaiXe.Image = (Image)resources.GetObject("pbTaiXe.Image");
            pbTaiXe.Location = new Point(3, 3);
            pbTaiXe.Name = "pbTaiXe";
            pbTaiXe.Size = new Size(97, 89);
            pbTaiXe.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTaiXe.TabIndex = 3;
            pbTaiXe.TabStop = false;
            // 
            // lbBienSo
            // 
            lbBienSo.AutoSize = true;
            lbBienSo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbBienSo.Location = new Point(106, 23);
            lbBienSo.Name = "lbBienSo";
            lbBienSo.Size = new Size(76, 25);
            lbBienSo.TabIndex = 26;
            lbBienSo.Text = "Biển số";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(21, 135);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 31;
            label6.Text = "Tài xế";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbTenKH);
            panel2.Controls.Add(lbSDT_KH);
            panel2.Controls.Add(lbEmailKH);
            panel2.Controls.Add(pbKH);
            panel2.Location = new Point(20, 540);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 133);
            panel2.TabIndex = 1;
            // 
            // lbTenKH
            // 
            lbTenKH.AutoSize = true;
            lbTenKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTenKH.Location = new Point(118, 10);
            lbTenKH.Name = "lbTenKH";
            lbTenKH.Size = new Size(39, 20);
            lbTenKH.TabIndex = 43;
            lbTenKH.Text = "ABC";
            // 
            // lbSDT_KH
            // 
            lbSDT_KH.AutoSize = true;
            lbSDT_KH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSDT_KH.Location = new Point(118, 32);
            lbSDT_KH.Name = "lbSDT_KH";
            lbSDT_KH.Size = new Size(36, 20);
            lbSDT_KH.TabIndex = 38;
            lbSDT_KH.TabStop = true;
            lbSDT_KH.Text = "SDT";
            // 
            // lbEmailKH
            // 
            lbEmailKH.AutoSize = true;
            lbEmailKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbEmailKH.Location = new Point(118, 58);
            lbEmailKH.Name = "lbEmailKH";
            lbEmailKH.Size = new Size(47, 20);
            lbEmailKH.TabIndex = 37;
            lbEmailKH.TabStop = true;
            lbEmailKH.Text = "Email";
            // 
            // pbKH
            // 
            pbKH.Image = (Image)resources.GetObject("pbKH.Image");
            pbKH.Location = new Point(6, 10);
            pbKH.Name = "pbKH";
            pbKH.Size = new Size(97, 89);
            pbKH.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKH.TabIndex = 30;
            pbKH.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(20, 512);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 39;
            label7.Text = "Khách hàng";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label5);
            panel7.Controls.Add(lbLoaiXeBooking);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(lbNgayDat);
            panel7.Controls.Add(blGiaTien);
            panel7.Controls.Add(lbKC);
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(pictureBox3);
            panel7.Controls.Add(lbDen);
            panel7.Controls.Add(lbDi);
            panel7.Controls.Add(pictureBox5);
            panel7.Location = new Point(20, 294);
            panel7.Name = "panel7";
            panel7.Size = new Size(369, 214);
            panel7.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 119);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 43;
            label5.Text = "Loại xe : ";
            // 
            // lbLoaiXeBooking
            // 
            lbLoaiXeBooking.AutoSize = true;
            lbLoaiXeBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbLoaiXeBooking.Location = new Point(126, 119);
            lbLoaiXeBooking.Name = "lbLoaiXeBooking";
            lbLoaiXeBooking.Size = new Size(39, 20);
            lbLoaiXeBooking.TabIndex = 42;
            lbLoaiXeBooking.Text = "ABC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(6, 179);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 41;
            label3.Text = "Ngày đặt : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(6, 159);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 40;
            label2.Text = "Giá tiền :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 139);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 39;
            label1.Text = "Khoảng cách : ";
            // 
            // lbNgayDat
            // 
            lbNgayDat.AutoSize = true;
            lbNgayDat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbNgayDat.Location = new Point(126, 179);
            lbNgayDat.Name = "lbNgayDat";
            lbNgayDat.Size = new Size(50, 20);
            lbNgayDat.TabIndex = 38;
            lbNgayDat.Text = "1/1/1";
            // 
            // blGiaTien
            // 
            blGiaTien.AutoSize = true;
            blGiaTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            blGiaTien.Location = new Point(126, 159);
            blGiaTien.Name = "blGiaTien";
            blGiaTien.Size = new Size(18, 20);
            blGiaTien.TabIndex = 37;
            blGiaTien.Text = "0";
            // 
            // lbKC
            // 
            lbKC.AutoSize = true;
            lbKC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbKC.Location = new Point(126, 139);
            lbKC.Name = "lbKC";
            lbKC.Size = new Size(18, 20);
            lbKC.TabIndex = 36;
            lbKC.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(5, 67);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // lbDen
            // 
            lbDen.AutoSize = true;
            lbDen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDen.Location = new Point(51, 67);
            lbDen.MaximumSize = new Size(250, 45);
            lbDen.Name = "lbDen";
            lbDen.Size = new Size(76, 20);
            lbDen.TabIndex = 31;
            lbDen.Text = "Điểm đến";
            // 
            // lbDi
            // 
            lbDi.AutoSize = true;
            lbDi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDi.Location = new Point(51, 3);
            lbDi.MaximumSize = new Size(250, 45);
            lbDi.Name = "lbDi";
            lbDi.Size = new Size(63, 20);
            lbDi.TabIndex = 30;
            lbDi.Text = "Điểm đi";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(10, 40);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // pnMap
            // 
            pnMap.Location = new Point(407, 149);
            pnMap.Name = "pnMap";
            pnMap.Size = new Size(1009, 524);
            pnMap.TabIndex = 27;
            // 
            // bookingBindingSource
            // 
            bookingBindingSource.DataSource = typeof(Infrastructure.Data.Booking);
            // 
            // pnStepH
            // 
            pnStepH.Location = new Point(20, 12);
            pnStepH.Name = "pnStepH";
            pnStepH.Size = new Size(1396, 120);
            pnStepH.TabIndex = 29;
            // 
            // frmBookingDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1445, 777);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pnStepH);
            Controls.Add(pnMap);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(pnTaiXe);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1463, 824);
            Name = "frmBookingDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookingDetail";
            Load += frmBookingDetail_Load;
            pnTaiXe.ResumeLayout(false);
            pnTaiXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTaiXe).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbKH).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnTaiXe;
        private Panel panel2;
        private Label lbTaiXe;
        private Label lbBangCap;
        private Label lbLoaiXe;
        private PictureBox pbTaiXe;
        private Label blBienSo;
        private Label textBox1;
        private PictureBox pbKH;
        private Label label19;
        private Label lbSDTKH;
        private Label label21;
        private Panel panel7;
        private PictureBox pictureBox3;
        private Label lbDen;
        private Label lbDi;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lbKC;
        private Label blGiaTien;
        private Panel pnMap;
        private Label lbNgayDat;
        private BindingSource bookingBindingSource;
        private LinkLabel lbSDTTX;
        private LinkLabel lbSDT_KH;
        private LinkLabel lbEmailKH;
        private Label lbBienSo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnStepH;
        private Label label5;
        private Label lbLoaiXeBooking;
        private Label label6;
        private Label label7;
        private Label lbTenKH;
    }
}