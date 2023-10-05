namespace QLCuaHangMauVang
{
    partial class fmNSX
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
            txtTenNSX = new TextBox();
            label3 = new Label();
            txtMaNSX = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvNSX = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNSX).BeginInit();
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
            panel1.Location = new Point(0, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 103);
            panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            btnDong.Image = Properties.Resources.icons8_close_window_24;
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.Location = new Point(688, 26);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(100, 43);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            btnBoqua.Image = Properties.Resources.icons8_skip_24;
            btnBoqua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoqua.Location = new Point(561, 26);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(100, 43);
            btnBoqua.TabIndex = 4;
            btnBoqua.Text = "Bỏ Qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.icons8_save_24;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(423, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 43);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_open_end_wrench_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(300, 26);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 43);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_24;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(168, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 43);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add2;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(45, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 43);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTenNSX);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtMaNSX);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 132);
            panel2.TabIndex = 0;
            // 
            // txtTenNSX
            // 
            txtTenNSX.Location = new Point(168, 75);
            txtTenNSX.Name = "txtTenNSX";
            txtTenNSX.Size = new Size(313, 23);
            txtTenNSX.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 78);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên Nhà Sản Xuất";
            // 
            // txtMaNSX
            // 
            txtMaNSX.Location = new Point(168, 49);
            txtMaNSX.Name = "txtMaNSX";
            txtMaNSX.Size = new Size(313, 23);
            txtMaNSX.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 49);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Nhà Sản Xuất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh Mục Nhà Sản Xuất";
            // 
            // dgvNSX
            // 
            dgvNSX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNSX.Dock = DockStyle.Fill;
            dgvNSX.Location = new Point(0, 132);
            dgvNSX.Name = "dgvNSX";
            dgvNSX.RowTemplate.Height = 25;
            dgvNSX.Size = new Size(860, 291);
            dgvNSX.TabIndex = 2;
            dgvNSX.CellContentClick += dataGridView1_CellContentClick;
            // 
            // fmNSX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 526);
            Controls.Add(dgvNSX);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fmNSX";
            Text = "fmNSX";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNSX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDong;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Panel panel2;
        private DataGridView dgvNSX;
        private TextBox txtTenNSX;
        private Label label3;
        private TextBox txtMaNSX;
        private Label label2;
        private Label label1;
        private Button btnThem;
    }
}