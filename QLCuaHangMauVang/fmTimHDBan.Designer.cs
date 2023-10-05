namespace QLCuaHangMauVang
{
    partial class fmTimHDBan
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
            btnTimLai = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvTKHoaDon = new DataGridView();
            btnTimKiem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaHDBan = new TextBox();
            txtThang = new TextBox();
            txtNam = new TextBox();
            txtMaNhanVien = new TextBox();
            txtMaKhach = new TextBox();
            txtTongTien = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTKHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnTimLai);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 397);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 89);
            panel1.TabIndex = 1;
            // 
            // btnDong
            // 
            btnDong.Image = Properties.Resources.icons8_close_window_24;
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.Location = new Point(534, 34);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(100, 43);
            btnDong.TabIndex = 11;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnTimLai
            // 
            btnTimLai.Image = Properties.Resources.icons8_skip_24;
            btnTimLai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimLai.Location = new Point(358, 34);
            btnTimLai.Name = "btnTimLai";
            btnTimLai.Size = new Size(100, 43);
            btnTimLai.TabIndex = 10;
            btnTimLai.Text = "Tìm Lại ";
            btnTimLai.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 362);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 35);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtNam);
            panel3.Controls.Add(txtThang);
            panel3.Controls.Add(txtTongTien);
            panel3.Controls.Add(txtMaKhach);
            panel3.Controls.Add(txtMaNhanVien);
            panel3.Controls.Add(txtMaHDBan);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 175);
            panel3.TabIndex = 3;
            // 
            // dgvTKHoaDon
            // 
            dgvTKHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTKHoaDon.Dock = DockStyle.Fill;
            dgvTKHoaDon.Location = new Point(0, 175);
            dgvTKHoaDon.Name = "dgvTKHoaDon";
            dgvTKHoaDon.RowTemplate.Height = 25;
            dgvTKHoaDon.Size = new Size(834, 187);
            dgvTKHoaDon.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(167, 34);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(104, 43);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhấy đúp vào hóa đơn để hiện thị Thông tin chi tiết";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 31);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 31);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 68);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "Tháng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 78);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 0;
            label5.Text = "Tổng Tiền :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 68);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 0;
            label6.Text = "Năm :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 113);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 0;
            label7.Text = "Mã Nhân Viên";
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(147, 28);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.Size = new Size(241, 23);
            txtMaHDBan.TabIndex = 1;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(112, 65);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(100, 23);
            txtThang.TabIndex = 1;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(288, 65);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(100, 23);
            txtNam.TabIndex = 1;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(148, 110);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(241, 23);
            txtMaNhanVien.TabIndex = 1;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(559, 31);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(241, 23);
            txtMaKhach.TabIndex = 1;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(559, 78);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(241, 23);
            txtTongTien.TabIndex = 1;
            // 
            // fmTimHDBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 486);
            Controls.Add(dgvTKHoaDon);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fmTimHDBan";
            Text = "fmTimHDBan";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTKHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTimKiem;
        private Button btnDong;
        private Button btnTimLai;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private DataGridView dgvTKHoaDon;
        private TextBox txtNam;
        private TextBox txtThang;
        private TextBox txtTongTien;
        private TextBox txtMaKhach;
        private TextBox txtMaNhanVien;
        private TextBox txtMaHDBan;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}