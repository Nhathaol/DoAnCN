namespace QLCuaHangMauVang
{
    partial class fmKhachHang
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
            btnDong = new Button();
            btnBoqua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            mtbDienThoai = new MaskedTextBox();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            txtDiaChi = new TextBox();
            txtTenKhach = new TextBox();
            label4 = new Label();
            txtMaKhach = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dgvKhachHang = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
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
            panel1.Location = new Point(0, 397);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 103);
            panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            btnDong.Image = Properties.Resources.icons8_close_window_24;
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.Location = new Point(692, 31);
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
            btnBoqua.Location = new Point(565, 31);
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
            btnLuu.Location = new Point(427, 31);
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
            btnSua.Location = new Point(304, 31);
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
            btnXoa.Location = new Point(172, 31);
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
            btnThem.Location = new Point(49, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 43);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(mtbDienThoai);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtTenKhach);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtMaKhach);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 161);
            panel2.TabIndex = 1;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(528, 105);
            mtbDienThoai.Mask = "(999) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(163, 23);
            mtbDienThoai.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(462, 108);
            label10.Name = "label10";
            label10.Size = new Size(26, 15);
            label10.TabIndex = 1;
            label10.Text = "SDT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(462, 61);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 1;
            label8.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 103);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 1;
            label6.Text = "Tên Kách Hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(528, 53);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(161, 23);
            txtDiaChi.TabIndex = 2;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(163, 100);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(161, 23);
            txtTenKhach.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 53);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 1;
            label4.Text = "Mã Khách Hàng";
            label4.Click += label4_Click;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(163, 53);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(161, 23);
            txtMaKhach.TabIndex = 2;
            txtMaKhach.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(295, 9);
            label3.Name = "label3";
            label3.Size = new Size(215, 25);
            label3.TabIndex = 0;
            label3.Text = "Danh Mục Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh Mục Khách Hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 161);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowTemplate.Height = 25;
            dgvKhachHang.Size = new Size(831, 236);
            dgvKhachHang.TabIndex = 2;
            // 
            // fmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 500);
            Controls.Add(dgvKhachHang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fmKhachHang";
            Text = "fmKhachHang";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDong;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dgvKhachHang;
        private Label label1;
        private TextBox txtMaKhach;
        private Label label10;
        private Label label8;
        private Label label6;
        private TextBox txtDiaChi;
        private TextBox txtTenKhach;
        private Label label4;
        private Label label3;
        private MaskedTextBox mtbDienThoai;
    }
}