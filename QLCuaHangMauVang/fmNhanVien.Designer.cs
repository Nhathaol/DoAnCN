namespace QLCuaHangMauVang
{
    partial class fmNhanVien
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
            panel1 = new Panel();
            panel2 = new Panel();
            mskNgaySinh = new DateTimePicker();
            mtbDienThoai = new MaskedTextBox();
            chkGioiTinh = new CheckBox();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtDiaChi = new TextBox();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvNhanVien = new DataGridView();
            btnDong = new Button();
            btnBoqua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnBoqua);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 515);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 100);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(mskNgaySinh);
            panel2.Controls.Add(mtbDienThoai);
            panel2.Controls.Add(chkGioiTinh);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtTenNhanVien);
            panel2.Controls.Add(txtMaNhanVien);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 192);
            panel2.TabIndex = 0;
            // 
            // mskNgaySinh
            // 
            mskNgaySinh.Format = DateTimePickerFormat.Short;
            mskNgaySinh.Location = new Point(592, 134);
            mskNgaySinh.Name = "mskNgaySinh";
            mskNgaySinh.Size = new Size(264, 23);
            mskNgaySinh.TabIndex = 5;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(594, 89);
            mtbDienThoai.Mask = "(999) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(262, 23);
            mtbDienThoai.TabIndex = 4;
            // 
            // chkGioiTinh
            // 
            chkGioiTinh.AutoSize = true;
            chkGioiTinh.Location = new Point(159, 134);
            chkGioiTinh.Name = "chkGioiTinh";
            chkGioiTinh.Size = new Size(52, 19);
            chkGioiTinh.TabIndex = 2;
            chkGioiTinh.Text = "Nam";
            chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 134);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 1;
            label8.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 94);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 138);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 1;
            label4.Text = "Ngày Sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 97);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 1;
            label6.Text = "Điện Thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(585, 52);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(271, 23);
            txtDiaChi.TabIndex = 3;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(142, 91);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(271, 23);
            txtTenNhanVien.TabIndex = 1;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(142, 49);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(271, 23);
            txtMaNhanVien.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(504, 57);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 1;
            label9.Text = "Địa Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 52);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(353, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh Mục Nhân Viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 192);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowTemplate.Height = 25;
            dgvNhanVien.Size = new Size(928, 323);
            dgvNhanVien.TabIndex = 2;
            // 
            // btnDong
            // 
            btnDong.Image = Properties.Resources.icons8_close_window_24;
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.Location = new Point(736, 29);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(100, 43);
            btnDong.TabIndex = 11;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            btnBoqua.Image = Properties.Resources.icons8_skip_24;
            btnBoqua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoqua.Location = new Point(609, 29);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(100, 43);
            btnBoqua.TabIndex = 10;
            btnBoqua.Text = "Bỏ Qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.icons8_save_24;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(471, 29);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 43);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_open_end_wrench_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(348, 29);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 43);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_24;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(216, 29);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 43);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add2;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(93, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 43);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // fmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 615);
            Controls.Add(dgvNhanVien);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fmNhanVien";
            Text = "fmNhanVien";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvNhanVien;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox txtMaNhanVien;
        private Label label2;
        private Label label8;
        private Label label4;
        private CheckBox chkGioiTinh;
        private DateTimePicker mskNgaySinh;
        private MaskedTextBox mtbDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenNhanVien;
        private Label label9;
        private Button btnDong;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}