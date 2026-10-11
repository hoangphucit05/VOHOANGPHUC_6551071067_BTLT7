namespace Bai01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblHangThanhVien = new Label();
            cboHangThanhVien = new ComboBox();
            chkTrangThai = new CheckBox();
            grpGioiTinh = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtTimKiemTen = new TextBox();
            lblTimKiemHang = new Label();
            cboTimKiemHang = new ComboBox();
            btnTimKiem = new Button();
            dgvHoiVien = new DataGridView();
            grpGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoiVien).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(20, 28);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(43, 15);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(125, 25);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(180, 23);
            txtHoTen.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(20, 65);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(76, 15);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(125, 62);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(180, 23);
            txtSDT.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 102);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(20, 140);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(60, 15);
            lblNgaySinh.TabIndex = 6;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(125, 136);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(180, 23);
            dtpNgaySinh.TabIndex = 7;
            // 
            // lblHangThanhVien
            // 
            lblHangThanhVien.AutoSize = true;
            lblHangThanhVien.Location = new Point(20, 178);
            lblHangThanhVien.Name = "lblHangThanhVien";
            lblHangThanhVien.Size = new Size(95, 15);
            lblHangThanhVien.TabIndex = 8;
            lblHangThanhVien.Text = "Hạng thành viên";
            // 
            // cboHangThanhVien
            // 
            cboHangThanhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHangThanhVien.FormattingEnabled = true;
            cboHangThanhVien.Location = new Point(125, 174);
            cboHangThanhVien.Name = "cboHangThanhVien";
            cboHangThanhVien.Size = new Size(180, 23);
            cboHangThanhVien.TabIndex = 9;
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Checked = true;
            chkTrangThai.CheckState = CheckState.Checked;
            chkTrangThai.Location = new Point(23, 215);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(112, 19);
            chkTrangThai.TabIndex = 10;
            chkTrangThai.Text = "Đang hoạt động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(radNu);
            grpGioiTinh.Controls.Add(radNam);
            grpGioiTinh.Location = new Point(335, 25);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(190, 80);
            grpGioiTinh.TabIndex = 11;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Giới tính";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(110, 36);
            radNu.Name = "radNu";
            radNu.Size = new Size(41, 19);
            radNu.TabIndex = 1;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Checked = true;
            radNam.Location = new Point(25, 36);
            radNam.Name = "radNam";
            radNam.Size = new Size(51, 19);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(598, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 32);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.Location = new Point(598, 68);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 32);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(598, 112);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 32);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(598, 156);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 32);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtTimKiemTen
            // 
            txtTimKiemTen.Location = new Point(20, 260);
            txtTimKiemTen.Name = "txtTimKiemTen";
            txtTimKiemTen.Size = new Size(285, 23);
            txtTimKiemTen.TabIndex = 16;
            // 
            // lblTimKiemHang
            // 
            lblTimKiemHang.AutoSize = true;
            lblTimKiemHang.Location = new Point(320, 264);
            lblTimKiemHang.Name = "lblTimKiemHang";
            lblTimKiemHang.Size = new Size(95, 15);
            lblTimKiemHang.TabIndex = 17;
            lblTimKiemHang.Text = "Hạng thành viên";
            // 
            // cboTimKiemHang
            // 
            cboTimKiemHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTimKiemHang.FormattingEnabled = true;
            cboTimKiemHang.Location = new Point(420, 260);
            cboTimKiemHang.Name = "cboTimKiemHang";
            cboTimKiemHang.Size = new Size(130, 23);
            cboTimKiemHang.TabIndex = 18;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(598, 255);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 32);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvHoiVien
            // 
            dgvHoiVien.AllowUserToAddRows = false;
            dgvHoiVien.AllowUserToDeleteRows = false;
            dgvHoiVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoiVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoiVien.Location = new Point(12, 300);
            dgvHoiVien.MultiSelect = false;
            dgvHoiVien.Name = "dgvHoiVien";
            dgvHoiVien.ReadOnly = true;
            dgvHoiVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoiVien.Size = new Size(696, 118);
            dgvHoiVien.TabIndex = 20;
            dgvHoiVien.CellClick += dgvHoiVien_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 461);
            Controls.Add(dgvHoiVien);
            Controls.Add(btnTimKiem);
            Controls.Add(cboTimKiemHang);
            Controls.Add(lblTimKiemHang);
            Controls.Add(txtTimKiemTen);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpGioiTinh);
            Controls.Add(chkTrangThai);
            Controls.Add(cboHangThanhVien);
            Controls.Add(lblHangThanhVien);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            MinimumSize = new Size(736, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Hội Viên Phòng Gym FitZone";
            Load += Form1_Load;
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoiVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblHangThanhVien;
        private System.Windows.Forms.ComboBox cboHangThanhVien;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiemTen;
        private System.Windows.Forms.Label lblTimKiemHang;
        private System.Windows.Forms.ComboBox cboTimKiemHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHoiVien;
    }
}
