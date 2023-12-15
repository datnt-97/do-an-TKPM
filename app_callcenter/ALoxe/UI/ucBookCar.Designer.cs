namespace ALoxe.UI
{
    partial class ucBookCar
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
            clCode = new DataGridViewTextBoxColumn();
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
            rjButton1 = new Components.RJButton();
            btnReload = new Components.RJButton();
            splitContainer1 = new SplitContainer();
            pnToobar = new Panel();
            label1 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnToobar.SuspendLayout();
            SuspendLayout();
            // 
            // dgBooking
            // 
            dgBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBooking.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBooking.Columns.AddRange(new DataGridViewColumn[] { clCode, clKhachHang, clSDT, clDiemDI, clDiemDen, clTaiXe, clBienSoXe, clLoaiXe, clNhanVien, clBatDau, clKetThuc, clTrangThai, clOption });
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
            dgBooking.Size = new Size(1334, 397);
            dgBooking.TabIndex = 0;
            dgBooking.CellContentClick += dgBooking_CellContentClick;
            // 
            // clCode
            // 
            clCode.HeaderText = "Code";
            clCode.MinimumWidth = 6;
            clCode.Name = "clCode";
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
            clOption.Text = "Detail";
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Left;
            rjButton1.BackColor = Color.FromArgb(0, 192, 0);
            rjButton1.BackgroundColor = Color.FromArgb(0, 192, 0);
            rjButton1.BorderColor = SystemColors.Control;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 5;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(544, -2);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(164, 44);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Tiếp nhận";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Left;
            btnReload.BackColor = SystemColors.Highlight;
            btnReload.BackgroundColor = SystemColors.Highlight;
            btnReload.BorderColor = SystemColors.Control;
            btnReload.BorderRadius = 0;
            btnReload.BorderSize = 5;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(412, 0);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(106, 44);
            btnReload.TabIndex = 1;
            btnReload.Text = "Tải lại";
            btnReload.TextColor = Color.White;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnToobar);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgBooking);
            splitContainer1.Size = new Size(1334, 468);
            splitContainer1.SplitterDistance = 67;
            splitContainer1.TabIndex = 4;
            // 
            // pnToobar
            // 
            pnToobar.Controls.Add(label1);
            pnToobar.Controls.Add(txtSearch);
            pnToobar.Controls.Add(btnReload);
            pnToobar.Controls.Add(rjButton1);
            pnToobar.Dock = DockStyle.Bottom;
            pnToobar.Location = new Point(0, 23);
            pnToobar.Name = "pnToobar";
            pnToobar.Size = new Size(1334, 44);
            pnToobar.TabIndex = 0;
            pnToobar.Paint += pnToobar_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left;
            txtSearch.Location = new Point(88, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(302, 27);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // ucBookCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ucBookCar";
            Size = new Size(1334, 468);
            ((System.ComponentModel.ISupportInitialize)dgBooking).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnToobar.ResumeLayout(false);
            pnToobar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgBooking;
        private Components.RJButton rjButton1;
        private Components.RJButton btnReload;
        private SplitContainer splitContainer1;
        private Panel pnToobar;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripTextBox toolStripTextBox1;
        private DataGridViewTextBoxColumn clCode;
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
        private TextBox txtSearch;
        private Label label1;
    }
}
