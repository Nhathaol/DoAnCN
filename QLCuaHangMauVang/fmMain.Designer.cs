namespace QLCuaHangMauVang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuNSX = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuHangHoa = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuHoaDonBan = new ToolStripMenuItem();
            mnuTimKiem = new ToolStripMenuItem();
            mnuFindHoaDon = new ToolStripMenuItem();
            mnuFindHang = new ToolStripMenuItem();
            mnuFindKhachHang = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuBCHangTon = new ToolStripMenuItem();
            mnuBCDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHienTroGiup = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuDanhMuc, mnuHoaDon, mnuTimKiem, mnuBaoCao, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1011, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
            mnuFile.Image = (Image)resources.GetObject("mnuFile.Image");
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(73, 20);
            mnuFile.Text = "Tệp Tin";
            // 
            // mnuThoat
            // 
            mnuThoat.Image = (Image)resources.GetObject("mnuThoat.Image");
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(180, 22);
            mnuThoat.Text = "Thoát";
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuNSX, mnuNhanVien, mnuKhachHang, mnuHangHoa });
            mnuDanhMuc.Image = (Image)resources.GetObject("mnuDanhMuc.Image");
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(90, 20);
            mnuDanhMuc.Text = "Danh Mục";
            // 
            // mnuNSX
            // 
            mnuNSX.Image = (Image)resources.GetObject("mnuNSX.Image");
            mnuNSX.Name = "mnuNSX";
            mnuNSX.Size = new Size(180, 22);
            mnuNSX.Text = "Nhà Sản Xuất";
            mnuNSX.Click += mnuChatLieu_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Image = (Image)resources.GetObject("mnuNhanVien.Image");
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(180, 22);
            mnuNhanVien.Text = "Nhân Viên ";
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Image = (Image)resources.GetObject("mnuKhachHang.Image");
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(180, 22);
            mnuKhachHang.Text = "Khách Hàng";
            // 
            // mnuHangHoa
            // 
            mnuHangHoa.Image = (Image)resources.GetObject("mnuHangHoa.Image");
            mnuHangHoa.Name = "mnuHangHoa";
            mnuHangHoa.Size = new Size(180, 22);
            mnuHangHoa.Text = "Hàng Hóa";
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.DropDownItems.AddRange(new ToolStripItem[] { mnuHoaDonBan });
            mnuHoaDon.Image = (Image)resources.GetObject("mnuHoaDon.Image");
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(85, 20);
            mnuHoaDon.Text = "Hóa  Đơn";
            // 
            // mnuHoaDonBan
            // 
            mnuHoaDonBan.Image = (Image)resources.GetObject("mnuHoaDonBan.Image");
            mnuHoaDonBan.Name = "mnuHoaDonBan";
            mnuHoaDonBan.Size = new Size(180, 22);
            mnuHoaDonBan.Text = "Hóa Đơn Bán";
            // 
            // mnuTimKiem
            // 
            mnuTimKiem.DropDownItems.AddRange(new ToolStripItem[] { mnuFindHoaDon, mnuFindHang, mnuFindKhachHang });
            mnuTimKiem.Image = (Image)resources.GetObject("mnuTimKiem.Image");
            mnuTimKiem.Name = "mnuTimKiem";
            mnuTimKiem.Size = new Size(85, 20);
            mnuTimKiem.Text = "Tìm Kiếm";
            // 
            // mnuFindHoaDon
            // 
            mnuFindHoaDon.Image = (Image)resources.GetObject("mnuFindHoaDon.Image");
            mnuFindHoaDon.Name = "mnuFindHoaDon";
            mnuFindHoaDon.Size = new Size(180, 22);
            mnuFindHoaDon.Text = "Hóa Đơn ";
            // 
            // mnuFindHang
            // 
            mnuFindHang.Image = (Image)resources.GetObject("mnuFindHang.Image");
            mnuFindHang.Name = "mnuFindHang";
            mnuFindHang.Size = new Size(180, 22);
            mnuFindHang.Text = "Hàng";
            // 
            // mnuFindKhachHang
            // 
            mnuFindKhachHang.Image = (Image)resources.GetObject("mnuFindKhachHang.Image");
            mnuFindKhachHang.Name = "mnuFindKhachHang";
            mnuFindKhachHang.Size = new Size(180, 22);
            mnuFindKhachHang.Text = " KHách Hàng";
            mnuFindKhachHang.Click += kháchToolStripMenuItem_Click;
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuBCHangTon, mnuBCDoanhThu });
            mnuBaoCao.Image = (Image)resources.GetObject("mnuBaoCao.Image");
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(79, 20);
            mnuBaoCao.Text = "Báo Cáo";
            // 
            // mnuBCHangTon
            // 
            mnuBCHangTon.Image = (Image)resources.GetObject("mnuBCHangTon.Image");
            mnuBCHangTon.Name = "mnuBCHangTon";
            mnuBCHangTon.Size = new Size(180, 22);
            mnuBCHangTon.Text = "Hàng Tồn";
            // 
            // mnuBCDoanhThu
            // 
            mnuBCDoanhThu.Image = (Image)resources.GetObject("mnuBCDoanhThu.Image");
            mnuBCDoanhThu.Name = "mnuBCDoanhThu";
            mnuBCDoanhThu.Size = new Size(180, 22);
            mnuBCDoanhThu.Text = "Danh Thu";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHienTroGiup });
            mnuTroGiup.Image = (Image)resources.GetObject("mnuTroGiup.Image");
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(79, 20);
            mnuTroGiup.Text = "Trợ Giúp";
            // 
            // mnuHienTroGiup
            // 
            mnuHienTroGiup.Image = (Image)resources.GetObject("mnuHienTroGiup.Image");
            mnuHienTroGiup.Name = "mnuHienTroGiup";
            mnuHienTroGiup.Size = new Size(180, 22);
            mnuHienTroGiup.Text = "Trợ Giúp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 635);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản Lý Cửa Hàng Màu Vàng";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuNSX;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuHangHoa;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuHoaDonBan;
        private ToolStripMenuItem mnuTimKiem;
        private ToolStripMenuItem mnuFindHoaDon;
        private ToolStripMenuItem mnuFindHang;
        private ToolStripMenuItem mnuFindKhachHang;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuBCHangTon;
        private ToolStripMenuItem mnuBCDoanhThu;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuHienTroGiup;
    }
}