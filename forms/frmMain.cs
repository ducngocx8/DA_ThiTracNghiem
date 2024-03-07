using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace CSDLPT_TN.forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmDangNhap f;
        public frmMain()
        {
            InitializeComponent();
            btnDangXuat.Enabled = false;
            btnTaoTaiKhoan.Enabled = false;
            btnMonHoc.Enabled = false;
            btnKhoa.Enabled = false;
            btnSinhVien.Enabled = false;
            btnGiangVien.Enabled = false;
            btnKetQua.Enabled = false;
            btnDe.Enabled = false;
            btnDangKyThi.Enabled = false;
            btnThi.Enabled = false;
            btnInBangDiem.Enabled = false;
            btnInDanhSach.Enabled = false;
        }

        private Form checkExists(Type ftype)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void btnDangNhap_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            {
                Form frm = this.checkExists(typeof(frmDangNhap));
                if (frm != null)
                {
                    frm.Activate();
                }
                else
                {
                    f = new frmDangNhap();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnKetQua_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmXemKetQua));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmXemKetQua f = new frmXemKetQua();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInBangDiem_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmInBangDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmInBangDiem f = new frmInBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInDanhSach_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmInDanhSach));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmInDanhSach f = new frmInDanhSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmThi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThi f = new frmThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
            btnTaoTaiKhoan.Enabled = false;
            btnMonHoc.Enabled = false;
            btnKhoa.Enabled = false;
            btnSinhVien.Enabled = false;
            btnGiangVien.Enabled = false;
            btnKetQua.Enabled = false;
            btnDe.Enabled = false;
            btnDangKyThi.Enabled = false;
            btnThi.Enabled = false;
            btnInBangDiem.Enabled = false;
            btnInDanhSach.Enabled = false;
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmMonHoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmKhoaLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhoaLop f = new frmKhoaLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmLopSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLopSinhVien f = new frmLopSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGiangVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmGiangVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmGiangVien f = new frmGiangVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangKyThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmDangKyThi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangKyThi f = new frmDangKyThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmBoDe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBoDe f = new frmBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmTaoTaiKhoan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}