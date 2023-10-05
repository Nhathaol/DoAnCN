namespace QLCuaHangMauVang
{
    partial class fmDMHang
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
            label1 = new Label();
            panel1 = new Panel();
            btnDong = new Button();
            btnBoqua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            button1 = new Button();
            btnTimKiem = new Button();
            btnHienThi = new Button();
            panel2 = new Panel();
            label2 = new Label();
            txtMaHang = new TextBox();
            label3 = new Label();
            txtTenHang = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtSoLuong = new TextBox();
            label6 = new Label();
            txtDonGiaNhap = new TextBox();
            label7 = new Label();
            txtDonGiaBan = new TextBox();
            cboMaChatLieu = new ComboBox();
            label8 = new Label();
            txtAnh = new TextBox();
            label9 = new Label();
            txtGhiChu = new TextBox();
            btnOpen = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh Mục Hàng Hóa";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHienThi);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnBoqua);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 558);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 83);
            panel1.TabIndex = 1;
            // 
            // btnDong
            // 
            btnDong.Image = Properties.Resources.icons8_close_window_24;
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.Location = new Point(776, 27);
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
            btnBoqua.Location = new Point(432, 31);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(103, 43);
            btnBoqua.TabIndex = 10;
            btnBoqua.Text = "Bỏ Qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.icons8_save_24;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(329, 31);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(81, 43);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_open_end_wrench_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(216, 31);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(88, 43);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_24;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(122, 31);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 43);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add2;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(22, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(83, 43);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(556, 29);
            button1.Name = "button1";
            button1.Size = new Size(87, 45);
            button1.TabIndex = 12;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(556, 29);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(87, 45);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += button3_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(663, 27);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(96, 45);
            btnHienThi.TabIndex = 12;
            btnHienThi.Text = "Hiển Thị DS";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnOpen);
            panel2.Controls.Add(cboMaChatLieu);
            panel2.Controls.Add(txtDonGiaBan);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDonGiaNhap);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSoLuong);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTenHang);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtGhiChu);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtAnh);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtMaHang);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 307);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 63);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Hàng";
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(121, 61);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(163, 23);
            txtMaHang.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 104);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên Hàng";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(121, 102);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(163, 23);
            txtTenHang.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 146);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 1;
            label4.Text = "Mã Chất Liệu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 185);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 1;
            label5.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(121, 183);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(163, 23);
            txtSoLuong.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 227);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 1;
            label6.Text = "Đơn Giá  Nhập";
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(141, 224);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(143, 23);
            txtDonGiaNhap.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 266);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 1;
            label7.Text = "Đơn Giá Bán";
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(141, 266);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new Size(143, 23);
            txtDonGiaBan.TabIndex = 2;
            // 
            // cboMaChatLieu
            // 
            cboMaChatLieu.FormattingEnabled = true;
            cboMaChatLieu.Location = new Point(140, 146);
            cboMaChatLieu.Name = "cboMaChatLieu";
            cboMaChatLieu.Size = new Size(136, 23);
            cboMaChatLieu.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(360, 64);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 1;
            label8.Text = "Ảnh";
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(416, 63);
            txtAnh.Multiline = true;
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(163, 56);
            txtAnh.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(360, 141);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 1;
            label9.Text = "Ghi Chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(416, 141);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(199, 93);
            txtGhiChu.TabIndex = 2;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(590, 61);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(53, 31);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Mở";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(649, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 191);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(888, 251);
            dataGridView1.TabIndex = 3;
            // 
            // fmDMHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 641);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fmDMHang";
            Text = "fmDMHang";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnTimKiem;
        private Button button1;
        private Button btnDong;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnHienThi;
        private Panel panel2;
        private ComboBox cboMaChatLieu;
        private TextBox txtDonGiaBan;
        private Label label7;
        private TextBox txtDonGiaNhap;
        private Label label6;
        private TextBox txtSoLuong;
        private Label label5;
        private Label label4;
        private TextBox txtTenHang;
        private Label label3;
        private TextBox txtMaHang;
        private Label label2;
        private TextBox txtGhiChu;
        private Label label9;
        private TextBox txtAnh;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btnOpen;
        private DataGridView dataGridView1;
    }
}