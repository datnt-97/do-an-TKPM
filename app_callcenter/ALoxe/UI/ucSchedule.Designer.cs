namespace ALoxe.UI
{
    partial class ucSchedule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgBooking = new DataGridView();
            clKhachHang = new DataGridViewTextBoxColumn();
            clSDT = new DataGridViewTextBoxColumn();
            clDiemDI = new DataGridViewTextBoxColumn();
            clDiemDen = new DataGridViewTextBoxColumn();
            clTaiXe = new DataGridViewTextBoxColumn();
            clBienSoXe = new DataGridViewTextBoxColumn();
            clLoaiXe = new DataGridViewTextBoxColumn();
            clNhanVien = new DataGridViewTextBoxColumn();
            clBatDau = new DataGridViewTextBoxColumn();
            clKetThuc = new DataGridViewTextBoxColumn();
            clTrangThai = new DataGridViewTextBoxColumn();
            clOption = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgBooking).BeginInit();
            SuspendLayout();
            // 
            // dgBooking
            // 
            dgBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBooking.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBooking.Columns.AddRange(new DataGridViewColumn[] { clKhachHang, clSDT, clDiemDI, clDiemDen, clTaiXe, clBienSoXe, clLoaiXe, clNhanVien, clBatDau, clKetThuc, clTrangThai, clOption });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgBooking.DefaultCellStyle = dataGridViewCellStyle1;
            dgBooking.Dock = DockStyle.Fill;
            dgBooking.GridColor = SystemColors.InactiveBorder;
            dgBooking.Location = new Point(0, 0);
            dgBooking.Name = "dgBooking";
            dgBooking.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgBooking.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgBooking.Size = new Size(881, 454);
            dgBooking.TabIndex = 1;
            // 
            // clKhachHang
            // 
            clKhachHang.HeaderText = "Người đặt";
            clKhachHang.MinimumWidth = 6;
            clKhachHang.Name = "clKhachHang";
            // 
            // clSDT
            // 
            clSDT.HeaderText = "SDT";
            clSDT.MinimumWidth = 6;
            clSDT.Name = "clSDT";
            // 
            // clDiemDI
            // 
            clDiemDI.HeaderText = "Điểm đi";
            clDiemDI.MinimumWidth = 6;
            clDiemDI.Name = "clDiemDI";
            // 
            // clDiemDen
            // 
            clDiemDen.HeaderText = "Điểm đến";
            clDiemDen.MinimumWidth = 6;
            clDiemDen.Name = "clDiemDen";
            // 
            // clTaiXe
            // 
            clTaiXe.HeaderText = "Tài xế";
            clTaiXe.MinimumWidth = 6;
            clTaiXe.Name = "clTaiXe";
            // 
            // clBienSoXe
            // 
            clBienSoXe.HeaderText = "Biển số xe";
            clBienSoXe.MinimumWidth = 6;
            clBienSoXe.Name = "clBienSoXe";
            // 
            // clLoaiXe
            // 
            clLoaiXe.HeaderText = "Loại xe";
            clLoaiXe.MinimumWidth = 6;
            clLoaiXe.Name = "clLoaiXe";
            // 
            // clNhanVien
            // 
            clNhanVien.HeaderText = "Nhân viên";
            clNhanVien.MinimumWidth = 6;
            clNhanVien.Name = "clNhanVien";
            // 
            // clBatDau
            // 
            clBatDau.HeaderText = "Bắt đầu";
            clBatDau.MinimumWidth = 6;
            clBatDau.Name = "clBatDau";
            // 
            // clKetThuc
            // 
            clKetThuc.HeaderText = "Kết thúc";
            clKetThuc.MinimumWidth = 6;
            clKetThuc.Name = "clKetThuc";
            // 
            // clTrangThai
            // 
            clTrangThai.HeaderText = "Trạng thái";
            clTrangThai.MinimumWidth = 6;
            clTrangThai.Name = "clTrangThai";
            // 
            // clOption
            // 
            clOption.HeaderText = "Option";
            clOption.MinimumWidth = 6;
            clOption.Name = "clOption";
            // 
            // ucSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgBooking);
            Name = "ucSchedule";
            Size = new Size(881, 454);
            ((System.ComponentModel.ISupportInitialize)dgBooking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgBooking;
        private DataGridViewTextBoxColumn clKhachHang;
        private DataGridViewTextBoxColumn clSDT;
        private DataGridViewTextBoxColumn clDiemDI;
        private DataGridViewTextBoxColumn clDiemDen;
        private DataGridViewTextBoxColumn clTaiXe;
        private DataGridViewTextBoxColumn clBienSoXe;
        private DataGridViewTextBoxColumn clLoaiXe;
        private DataGridViewTextBoxColumn clNhanVien;
        private DataGridViewTextBoxColumn clBatDau;
        private DataGridViewTextBoxColumn clKetThuc;
        private DataGridViewTextBoxColumn clTrangThai;
        private DataGridViewButtonColumn clOption;
    }
}
