namespace Bai_01
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
            lblMaTL = new Label();
            txtMaTL = new TextBox();
            lblTenTheLoai = new Label();
            txtTenTheLoai = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvTheLoai = new DataGridView();
            lblNgayTao = new Label();
            lblNgayTaoValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            SuspendLayout();
            // 
            // lblMaTL
            // 
            lblMaTL.AutoSize = true;
            lblMaTL.Location = new Point(15, 16);
            lblMaTL.Margin = new Padding(2, 0, 2, 0);
            lblMaTL.Name = "lblMaTL";
            lblMaTL.Size = new Size(66, 15);
            lblMaTL.TabIndex = 0;
            lblMaTL.Text = "Mã thể loại";
            // 
            // txtMaTL
            // 
            txtMaTL.BackColor = SystemColors.Window;
            txtMaTL.Location = new Point(92, 14);
            txtMaTL.Margin = new Padding(2, 2, 2, 2);
            txtMaTL.Name = "txtMaTL";
            txtMaTL.PlaceholderText = "ReadOnly";
            txtMaTL.ReadOnly = true;
            txtMaTL.Size = new Size(211, 23);
            txtMaTL.TabIndex = 1;
            txtMaTL.TabStop = false;
            // 
            // lblTenTheLoai
            // 
            lblTenTheLoai.AutoSize = true;
            lblTenTheLoai.Location = new Point(15, 43);
            lblTenTheLoai.Margin = new Padding(2, 0, 2, 0);
            lblTenTheLoai.Name = "lblTenTheLoai";
            lblTenTheLoai.Size = new Size(68, 15);
            lblTenTheLoai.TabIndex = 2;
            lblTenTheLoai.Text = "Tên thể loại";
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.Location = new Point(92, 41);
            txtTenTheLoai.Margin = new Padding(2, 2, 2, 2);
            txtTenTheLoai.MaxLength = 100;
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.Size = new Size(211, 23);
            txtTenTheLoai.TabIndex = 3;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(15, 70);
            lblMoTa.Margin = new Padding(2, 0, 2, 0);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(38, 15);
            lblMoTa.TabIndex = 4;
            lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(92, 68);
            txtMoTa.Margin = new Padding(2, 2, 2, 2);
            txtMoTa.MaxLength = 255;
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(211, 59);
            txtMoTa.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(705, 11);
            btnThem.Margin = new Padding(2, 2, 2, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(77, 23);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.Location = new Point(789, 11);
            btnSua.Margin = new Padding(2, 2, 2, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 23);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(873, 11);
            btnXoa.Margin = new Padding(2, 2, 2, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 23);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(957, 11);
            btnLamMoi.Margin = new Padding(2, 2, 2, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(77, 23);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += button4_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(15, 139);
            txtTimKiem.Margin = new Padding(2, 2, 2, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(285, 23);
            txtTimKiem.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(309, 137);
            btnTimKiem.Margin = new Padding(2, 2, 2, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(83, 23);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Location = new Point(15, 169);
            dgvTheLoai.Margin = new Padding(2, 2, 2, 2);
            dgvTheLoai.MultiSelect = false;
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.ReadOnly = true;
            dgvTheLoai.RowHeadersWidth = 40;
            dgvTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoai.Size = new Size(1021, 174);
            dgvTheLoai.TabIndex = 14;
            dgvTheLoai.SelectionChanged += dgvTheLoai_SelectionChanged;
            // 
            // lblNgayTao
            // 
            lblNgayTao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(705, 43);
            lblNgayTao.Margin = new Padding(2, 0, 2, 0);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(58, 15);
            lblNgayTao.TabIndex = 10;
            lblNgayTao.Text = "Ngày tạo:";
            // 
            // lblNgayTaoValue
            // 
            lblNgayTaoValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNgayTaoValue.AutoSize = true;
            lblNgayTaoValue.Location = new Point(772, 43);
            lblNgayTaoValue.Margin = new Padding(2, 0, 2, 0);
            lblNgayTaoValue.Name = "lblNgayTaoValue";
            lblNgayTaoValue.Size = new Size(0, 15);
            lblNgayTaoValue.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 352);
            Controls.Add(dgvTheLoai);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblNgayTaoValue);
            Controls.Add(lblNgayTao);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtMoTa);
            Controls.Add(lblMoTa);
            Controls.Add(txtTenTheLoai);
            Controls.Add(lblTenTheLoai);
            Controls.Add(txtMaTL);
            Controls.Add(lblMaTL);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(796, 376);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thể Loại Sách - Tri Thức Books";
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaTL;
        private TextBox txtMaTL;
        private Label lblTenTheLoai;
        private TextBox txtTenTheLoai;
        private Label lblMoTa;
        private TextBox txtMoTa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvTheLoai;
        private Label lblNgayTao;
        private Label lblNgayTaoValue;
    }
}
