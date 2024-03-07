namespace CSDLPT_TN.forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDe = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKyDe = new DevExpress.XtraBars.BarButtonItem();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnKetQua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKyThi = new DevExpress.XtraBars.BarButtonItem();
            this.pgHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pggTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgHocVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pggMonHoc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pggKhoaVaLop = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pggLopVaSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pggGiangVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgThi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pggDeThi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pggDangKy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pggThi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pggKetQuaThi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pggDiemThi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pggDangKyThi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnTaoTaiKhoan,
            this.btnDangXuat,
            this.btnMonHoc,
            this.barButtonItem5,
            this.btnInBangDiem,
            this.btnInDanhSach,
            this.btnKhoa,
            this.btnSinhVien,
            this.btnGiangVien,
            this.btnDe,
            this.btnDangKyDe,
            this.btnThi,
            this.btnKetQua,
            this.barButtonItem1,
            this.btnDangKyThi});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pgHeThong,
            this.pgHocVien,
            this.pgThi,
            this.pgBaoCao});
            this.ribbon.Size = new System.Drawing.Size(1491, 179);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Glyph")));
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.LargeGlyph")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick_1);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.Glyph")));
            this.btnTaoTaiKhoan.Id = 2;
            this.btnTaoTaiKhoan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.LargeGlyph")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.LargeGlyph")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.Glyph")));
            this.btnMonHoc.Id = 4;
            this.btnMonHoc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.LargeGlyph")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnInBangDiem
            // 
            this.btnInBangDiem.Caption = "In Bảng Điểm";
            this.btnInBangDiem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnInBangDiem.Glyph")));
            this.btnInBangDiem.Id = 6;
            this.btnInBangDiem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnInBangDiem.LargeGlyph")));
            this.btnInBangDiem.Name = "btnInBangDiem";
            this.btnInBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInBangDiem_ItemClick_1);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Caption = "In danh sách";
            this.btnInDanhSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnInDanhSach.Glyph")));
            this.btnInDanhSach.Id = 7;
            this.btnInDanhSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnInDanhSach.LargeGlyph")));
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDanhSach_ItemClick_1);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Caption = "Khoa";
            this.btnKhoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKhoa.Glyph")));
            this.btnKhoa.Id = 8;
            this.btnKhoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhoa.LargeGlyph")));
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoa_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh viên";
            this.btnSinhVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.Glyph")));
            this.btnSinhVien.Id = 9;
            this.btnSinhVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.LargeGlyph")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Caption = "Giảng viên";
            this.btnGiangVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGiangVien.Glyph")));
            this.btnGiangVien.Id = 10;
            this.btnGiangVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGiangVien.LargeGlyph")));
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiangVien_ItemClick);
            // 
            // btnDe
            // 
            this.btnDe.Caption = "Đề";
            this.btnDe.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDe.Glyph")));
            this.btnDe.Id = 11;
            this.btnDe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDe.LargeGlyph")));
            this.btnDe.Name = "btnDe";
            this.btnDe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDe_ItemClick);
            // 
            // btnDangKyDe
            // 
            this.btnDangKyDe.Caption = "Đăng ký đề";
            this.btnDangKyDe.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangKyDe.Glyph")));
            this.btnDangKyDe.Id = 12;
            this.btnDangKyDe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangKyDe.LargeGlyph")));
            this.btnDangKyDe.Name = "btnDangKyDe";
            // 
            // btnThi
            // 
            this.btnThi.Caption = "Thi";
            this.btnThi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThi.Glyph")));
            this.btnThi.Id = 13;
            this.btnThi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThi.LargeGlyph")));
            this.btnThi.Name = "btnThi";
            this.btnThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThi_ItemClick);
            // 
            // btnKetQua
            // 
            this.btnKetQua.Caption = "Kết quả";
            this.btnKetQua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKetQua.Glyph")));
            this.btnKetQua.Id = 14;
            this.btnKetQua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKetQua.LargeGlyph")));
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKetQua_ItemClick_1);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnDangKyThi
            // 
            this.btnDangKyThi.Caption = "Đăng ký thi";
            this.btnDangKyThi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangKyThi.Glyph")));
            this.btnDangKyThi.Id = 16;
            this.btnDangKyThi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangKyThi.LargeGlyph")));
            this.btnDangKyThi.Name = "btnDangKyThi";
            this.btnDangKyThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKyThi_ItemClick);
            // 
            // pgHeThong
            // 
            this.pgHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pggTaiKhoan});
            this.pgHeThong.Name = "pgHeThong";
            this.pgHeThong.Text = "Hệ thống";
            // 
            // pggTaiKhoan
            // 
            this.pggTaiKhoan.ItemLinks.Add(this.btnDangNhap);
            this.pggTaiKhoan.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.pggTaiKhoan.ItemLinks.Add(this.btnDangXuat);
            this.pggTaiKhoan.Name = "pggTaiKhoan";
            this.pggTaiKhoan.Text = "Tài khoản";
            // 
            // pgHocVien
            // 
            this.pgHocVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pggMonHoc,
            this.pggKhoaVaLop,
            this.pggLopVaSinhVien,
            this.pggGiangVien});
            this.pgHocVien.Name = "pgHocVien";
            this.pgHocVien.Text = "Học viện";
            // 
            // pggMonHoc
            // 
            this.pggMonHoc.AllowTextClipping = false;
            this.pggMonHoc.ItemLinks.Add(this.btnMonHoc);
            this.pggMonHoc.Name = "pggMonHoc";
            this.pggMonHoc.Text = "Môn học";
            // 
            // pggKhoaVaLop
            // 
            this.pggKhoaVaLop.AllowTextClipping = false;
            this.pggKhoaVaLop.ItemLinks.Add(this.btnKhoa);
            this.pggKhoaVaLop.Name = "pggKhoaVaLop";
            this.pggKhoaVaLop.Text = "Khoa và lớp";
            // 
            // pggLopVaSinhVien
            // 
            this.pggLopVaSinhVien.AllowTextClipping = false;
            this.pggLopVaSinhVien.ItemLinks.Add(this.btnSinhVien);
            this.pggLopVaSinhVien.Name = "pggLopVaSinhVien";
            this.pggLopVaSinhVien.Text = "Lớp và sinh viên";
            // 
            // pggGiangVien
            // 
            this.pggGiangVien.AllowTextClipping = false;
            this.pggGiangVien.ItemLinks.Add(this.btnGiangVien);
            this.pggGiangVien.Name = "pggGiangVien";
            this.pggGiangVien.Text = "Giảng viên";
            // 
            // pgThi
            // 
            this.pgThi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pggDeThi,
            this.pggDangKy,
            this.pggThi,
            this.pggKetQuaThi});
            this.pgThi.Name = "pgThi";
            this.pgThi.Text = "Thi";
            // 
            // pggDeThi
            // 
            this.pggDeThi.ItemLinks.Add(this.btnDe);
            this.pggDeThi.Name = "pggDeThi";
            this.pggDeThi.Text = "Đề thi";
            // 
            // pggDangKy
            // 
            this.pggDangKy.ItemLinks.Add(this.btnDangKyThi);
            this.pggDangKy.Name = "pggDangKy";
            this.pggDangKy.Text = "Đăng ký";
            // 
            // pggThi
            // 
            this.pggThi.ItemLinks.Add(this.btnThi);
            this.pggThi.Name = "pggThi";
            this.pggThi.Text = "Thi";
            // 
            // pggKetQuaThi
            // 
            this.pggKetQuaThi.AllowTextClipping = false;
            this.pggKetQuaThi.ItemLinks.Add(this.btnKetQua);
            this.pggKetQuaThi.Name = "pggKetQuaThi";
            this.pggKetQuaThi.Text = "Kết quả thi";
            // 
            // pgBaoCao
            // 
            this.pgBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pggDiemThi,
            this.pggDangKyThi});
            this.pgBaoCao.Name = "pgBaoCao";
            this.pgBaoCao.Text = "Báo cáo";
            // 
            // pggDiemThi
            // 
            this.pggDiemThi.AllowTextClipping = false;
            this.pggDiemThi.ItemLinks.Add(this.btnInBangDiem);
            this.pggDiemThi.Name = "pggDiemThi";
            this.pggDiemThi.Text = "Điểm thi";
            // 
            // pggDangKyThi
            // 
            this.pggDangKyThi.AllowTextClipping = false;
            this.pggDangKyThi.ItemLinks.Add(this.btnInDanhSach);
            this.pggDangKyThi.Name = "pggDangKyThi";
            this.pggDangKyThi.Text = "Đăng ký thi";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 493);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1491, 40);
            // 
            // frmMain
            // 
            this.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.Appearance.Image")));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseImage = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 533);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "THI TRẮC NGHIỆM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pgHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggKhoaVaLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggLopVaSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggGiangVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggDeThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggDiemThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggDangKyThi;
        private DevExpress.XtraBars.BarButtonItem btnDangKyDe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggKetQuaThi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pggDangKy;
        public DevExpress.XtraBars.BarButtonItem btnDangNhap;
        public DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        public DevExpress.XtraBars.BarButtonItem btnDangXuat;
        public DevExpress.XtraBars.Ribbon.RibbonPage pgHocVien;
        public DevExpress.XtraBars.Ribbon.RibbonPage pgThi;
        public DevExpress.XtraBars.Ribbon.RibbonPage pgBaoCao;
        public DevExpress.XtraBars.BarButtonItem btnMonHoc;
        public DevExpress.XtraBars.BarButtonItem btnInBangDiem;
        public DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        public DevExpress.XtraBars.BarButtonItem btnKhoa;
        public DevExpress.XtraBars.BarButtonItem btnSinhVien;
        public DevExpress.XtraBars.BarButtonItem btnGiangVien;
        public DevExpress.XtraBars.BarButtonItem btnDe;
        public DevExpress.XtraBars.BarButtonItem btnThi;
        public DevExpress.XtraBars.BarButtonItem btnKetQua;
        public DevExpress.XtraBars.BarButtonItem btnDangKyThi;
    }
}