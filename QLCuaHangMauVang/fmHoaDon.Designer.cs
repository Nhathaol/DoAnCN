namespace QLCuaHangMauVang
{
    partial class fmHoaDon
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
            btnTimKiem = new Button();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            btnNgay = new Button();
            cboMaKhach = new ComboBox();
            mtbDienThoai = new MaskedTextBox();
            txtDiaChi = new TextBox();
            txtTenKhach = new TextBox();
            cboMaNhanVien = new ComboBox();
            txtNgayBan = new DateTimePicker();
            txtTenNhanVien = new TextBox();
            txtMaHDBan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvHDBanHang = new DataGridView();
            panel4 = new Panel();
            txtTongTien = new TextBox();
            lblBangChu = new Label();
            label18 = new Label();
            label17 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            btnDong = new Button();
            btnInHoaDon = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            txtSoLuong = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            txtTenHang = new TextBox();
            txtGiamGia = new TextBox();
            txtDonGiaBan = new TextBox();
            txtThanhTien = new TextBox();
            cboMaHang = new ComboBox();
            cboMaHDBan = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cboMaHDBan);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 599);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 45);
            panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(347, 6);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(99, 27);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Hóa Đơn";
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
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(907, 599);
            splitContainer1.SplitterDistance = 199;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNgay);
            groupBox1.Controls.Add(cboMaKhach);
            groupBox1.Controls.Add(mtbDienThoai);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTenKhach);
            groupBox1.Controls.Add(cboMaNhanVien);
            groupBox1.Controls.Add(txtNgayBan);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(txtMaHDBan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(23, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(872, 168);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Chung";
            // 
            // btnNgay
            // 
            btnNgay.Location = new Point(303, 69);
            btnNgay.Name = "btnNgay";
            btnNgay.Size = new Size(49, 23);
            btnNgay.TabIndex = 9;
            btnNgay.Text = "...";
            btnNgay.UseVisualStyleBackColor = true;
            // 
            // cboMaKhach
            // 
            cboMaKhach.FormattingEnabled = true;
            cboMaKhach.Location = new Point(594, 31);
            cboMaKhach.Name = "cboMaKhach";
            cboMaKhach.Size = new Size(159, 23);
            cboMaKhach.TabIndex = 8;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(592, 139);
            mtbDienThoai.Mask = "(999) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(163, 23);
            mtbDienThoai.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(594, 100);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(161, 23);
            txtDiaChi.TabIndex = 6;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(594, 67);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(161, 23);
            txtTenKhach.TabIndex = 5;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(145, 103);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(151, 23);
            cboMaNhanVien.TabIndex = 3;
            // 
            // txtNgayBan
            // 
            txtNgayBan.Format = DateTimePickerFormat.Short;
            txtNgayBan.Location = new Point(145, 67);
            txtNgayBan.Name = "txtNgayBan";
            txtNgayBan.Size = new Size(151, 23);
            txtNgayBan.TabIndex = 2;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(145, 136);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(151, 23);
            txtTenNhanVien.TabIndex = 1;
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(145, 26);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.Size = new Size(151, 23);
            txtMaHDBan.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 139);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 0;
            label6.Text = "Tên Nhân Viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 103);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 0;
            label5.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 67);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Ngày Bán";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(471, 139);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 0;
            label10.Text = "Điện Thoại ";
            label10.Click += label3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(471, 103);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 0;
            label9.Text = "Địa Chỉ";
            label9.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(471, 67);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 0;
            label8.Text = "Tên Khách Hàng";
            label8.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 34);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 0;
            label7.Text = "Mã Khách Hàng";
            label7.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 34);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã Hóa Đơn";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(347, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 0;
            label2.Text = "Hóa Đơn Bán Hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHDBanHang);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(907, 396);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Các Mặt Hàng";
            // 
            // dgvHDBanHang
            // 
            dgvHDBanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDBanHang.Dock = DockStyle.Fill;
            dgvHDBanHang.Location = new Point(3, 119);
            dgvHDBanHang.Name = "dgvHDBanHang";
            dgvHDBanHang.RowTemplate.Height = 25;
            dgvHDBanHang.Size = new Size(901, 156);
            dgvHDBanHang.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtTongTien);
            panel4.Controls.Add(lblBangChu);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label17);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(901, 68);
            panel4.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(679, 8);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(139, 23);
            txtTongTien.TabIndex = 3;
            // 
            // lblBangChu
            // 
            lblBangChu.AutoSize = true;
            lblBangChu.Location = new Point(40, 37);
            lblBangChu.Name = "lblBangChu";
            lblBangChu.Size = new Size(59, 15);
            lblBangChu.TabIndex = 2;
            lblBangChu.Text = "Bằng Chữ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(614, 11);
            label18.Name = "label18";
            label18.Size = new Size(59, 15);
            label18.TabIndex = 1;
            label18.Text = "Tổng Tiền";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(38, 11);
            label17.Name = "label17";
            label17.Size = new Size(141, 15);
            label17.TabIndex = 0;
            label17.Text = "Nhấy Đúp 1 Dòng Để Xóa";
            // 
            // panel3
            // 
            panel3.Controls.Add(cboMaHang);
            panel3.Controls.Add(txtThanhTien);
            panel3.Controls.Add(txtDonGiaBan);
            panel3.Controls.Add(txtGiamGia);
            panel3.Controls.Add(txtTenHang);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(txtSoLuong);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(901, 100);
            panel3.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(55, 52);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 0;
            label12.Text = "Số Lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 15);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 0;
            label11.Text = "Mã Hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDong);
            panel2.Controls.Add(btnInHoaDon);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnThem);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 343);
            panel2.Name = "panel2";
            panel2.Size = new Size(901, 50);
            panel2.TabIndex = 0;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(743, 6);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(116, 26);
            btnDong.TabIndex = 0;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(590, 6);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(130, 26);
            btnInHoaDon.TabIndex = 0;
            btnInHoaDon.Text = "In Hóa Đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(427, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 26);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Hủy Hóa Đơn";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(225, 6);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(147, 26);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu Hóa Đơn";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(40, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(151, 26);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm Hóa Đơn";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(141, 49);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(146, 23);
            txtSoLuong.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(363, 16);
            label20.Name = "label20";
            label20.Size = new Size(57, 15);
            label20.TabIndex = 2;
            label20.Text = "Tên Hàng";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(363, 52);
            label21.Name = "label21";
            label21.Size = new Size(55, 15);
            label21.TabIndex = 2;
            label21.Text = "Giảm Giá";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(649, 16);
            label22.Name = "label22";
            label22.Size = new Size(49, 15);
            label22.TabIndex = 2;
            label22.Text = "Đơn Giá";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(649, 57);
            label23.Name = "label23";
            label23.Size = new Size(65, 15);
            label23.TabIndex = 2;
            label23.Text = "Thành Tiền";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(427, 15);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(157, 23);
            txtTenHang.TabIndex = 3;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(426, 52);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(157, 23);
            txtGiamGia.TabIndex = 3;
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(702, 13);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new Size(157, 23);
            txtDonGiaBan.TabIndex = 3;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(720, 52);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(157, 23);
            txtThanhTien.TabIndex = 3;
            // 
            // cboMaHang
            // 
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Location = new Point(145, 15);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(141, 23);
            cboMaHang.TabIndex = 4;
            // 
            // cboMaHDBan
            // 
            cboMaHDBan.FormattingEnabled = true;
            cboMaHDBan.Location = new Point(103, 9);
            cboMaHDBan.Name = "cboMaHDBan";
            cboMaHDBan.Size = new Size(141, 23);
            cboMaHDBan.TabIndex = 4;
            // 
            // fmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 644);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "fmHoaDon";
            Text = "fmHoaDon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTimKiem;
        private ComboBox comboBox1;
        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker txtNgayBan;
        private TextBox txtMaHDBan;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cboMaNhanVien;
        private TextBox txtTenNhanVien;
        private TextBox txtMaK;
        private TextBox txtTenKhach;
        private TextBox txtDiaChi;
        private MaskedTextBox mtbDienThoai;
        private GroupBox groupBox2;
        private Panel panel3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label13;
        private ComboBox comboBox3;
        private Label label12;
        private Label label11;
        private Panel panel2;
        private DataGridView dgvHDBanHang;
        private Panel panel4;
        private Label label17;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label16;
        private Label label15;
        private TextBox textBox7;
        private Label label14;
        private TextBox txtTongTien;
        private Label lblBangChu;
        private Label label18;
        private Button btnDong;
        private Button btnInHoaDon;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private ComboBox cboMaKhach;
        private Button btnNgay;
        private ComboBox cboMaHDBan;
        private ComboBox cboMaHang;
        private TextBox txtThanhTien;
        private TextBox txtDonGiaBan;
        private TextBox txtGiamGia;
        private TextBox txtTenHang;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private TextBox txtSoLuong;
    }
}