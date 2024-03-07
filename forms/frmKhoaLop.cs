using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_TN.forms
{
    public partial class frmKhoaLop : Form
    {
        int vitri;
        int vitribatdau;
        String macs;
        public frmKhoaLop()
        {
            InitializeComponent();
        }
        private void frmKhoaLop_Load(object sender, EventArgs e)
        {
            dsTN.EnforceConstraints = false;
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.dsTN.KHOA);
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dsTN.LOP);
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.dsTN.GIAOVIEN);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.dsTN.SINHVIEN);
            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
            macs = ((DataRowView)bdsKHOA[0])["MACS"].ToString();
            cbbCoSo.DataSource = Program.bds_dspm;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup.Equals("TRUONG"))
            {
                cbbCoSo.Enabled = true;
                btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnThemLop.Enabled = btnXoaLop.Enabled = btnGhiLop.Enabled = false;
            }
            else
            {
                cbbCoSo.Enabled = false;
                btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnThemLop.Enabled = btnXoaLop.Enabled = btnGhiLop.Enabled = true;
            }
            pnTuongTac.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKHOA.Position;
            pnTuongTac.Enabled = true;
            bdsKHOA.AddNew();
            txtMaCoSo.Text = macs;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = btnThemLop.Enabled = btnXoaLop.Enabled = btnGhiLop.Enabled = false;
            btnGhi.Enabled = btnHoanTac.Enabled = true;
            gcKHOA.Enabled = false;
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKHOA.Position;
            pnTuongTac.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = btnThemLop.Enabled = btnXoaLop.Enabled = btnGhiLop.Enabled = false;
            btnGhi.Enabled = btnHoanTac.Enabled = true;
            gcKHOA.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string makh = "";
            if (bdsGIAOVIEN.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã có giáo viên", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsLOP.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã có lớp", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa khoa này ?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    makh = ((DataRowView)bdsKHOA[bdsKHOA.Position])["MAKH"].ToString();
                    bdsKHOA.RemoveCurrent();
                    KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    KHOATableAdapter.Update(this.dsTN.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa khoa thất bại vì đã xảy ra lỗi", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    KHOATableAdapter.Fill(this.dsTN.KHOA);
                    bdsKHOA.Position = bdsKHOA.Find("MAKH", makh);
                    return;
                }
            }

            if (bdsKHOA.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsKHOA.Count == 0)
            {
                MessageBox.Show("Không có khoa nào để ghi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaKhoa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã khoa không được để trống !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên khoa không được để trống !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenKhoa.Focus();
                return;
            }
            try
            {
                SqlDataReader reader;
                reader = Program.ExecSqlDataReader("EXEC SP_KiemTraMaKhoa '" + ((DataRowView)bdsKHOA[bdsKHOA.Position])["MAKH"].ToString().Trim() + "'");
                if (reader == null)
                {
                    return;
                }
                reader.Read();
                if (reader.GetString(0).Equals("Y"))
                {
                    MessageBox.Show("Mã khoa: " + ((DataRowView)bdsKHOA[bdsKHOA.Position])["MAKH"].ToString().Trim() + " bị trùng !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                reader.Close();
            }
            catch
            {

            }
            try
            {
                bdsKHOA.EndEdit();
                bdsKHOA.ResetCurrentItem();
                KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                KHOATableAdapter.Update(this.dsTN.KHOA);
                LOPTableAdapter.Fill(this.dsTN.LOP);
                btnThemLop.Enabled = btnXoaLop.Enabled = btnGhiLop.Enabled = true;
                MessageBox.Show("Ghi khoa thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi khoa thất bại vì đã xảy ra lỗi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gcKHOA.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
            pnTuongTac.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKHOA.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsKHOA.Position = vitri;
            }
            gcKHOA.Enabled = true;
            pnTuongTac.Enabled = false;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = btnThemLop.Enabled = btnXoaLop.Enabled = btnGhiLop.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                KHOATableAdapter.Fill(this.dsTN.KHOA);
                LOPTableAdapter.Fill(this.dsTN.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Làm mới dữ liệu đã gặp lỗi !", "Lỗi làm mới dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbCoSo.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                return;
            }
            Program.servername = cbbCoSo.SelectedValue.ToString();
            if (cbbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {

            }
            else
            {
                dsTN.EnforceConstraints = false;
                this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOATableAdapter.Fill(this.dsTN.KHOA);
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dsTN.LOP);
                this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIENTableAdapter.Fill(this.dsTN.GIAOVIEN);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.dsTN.SINHVIEN);
                this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            bdsLOP.AddNew();
            ((DataRowView)bdsLOP[bdsLOP.Position])["MAKH"] = ((DataRowView)bdsKHOA[bdsKHOA.Position])["MAKH"].ToString();
            btnXoaLop.Enabled = true;
        }
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            string malop = "";
            if (bdsGIAOVIEN_DANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có giảng viên đăng ký", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsSINHVIEN.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa lớp này ?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
                    bdsLOP.RemoveCurrent();
                    LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    LOPTableAdapter.Update(this.dsTN.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lớp thất bại vì đã xảy ra lỗi", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LOPTableAdapter.Fill(this.dsTN.LOP);
                    bdsLOP.Position = bdsLOP.Find("MALOP", malop);
                    return;
                }
            }
            if (bdsLOP.Count == 0)
            {
                btnXoaLop.Enabled = false;
            }
        }
        private void btnGhiLop_Click(object sender, EventArgs e)
        {
            if (this.bdsLOP.Count == 0)
            {
                MessageBox.Show("Không có lớp nào để ghi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    for (int i = bdsLOP.Count-1; i < this.bdsLOP.Count; i++)
                    {
                        if (((DataRowView)bdsLOP[i])["MALOP"].ToString().Equals(""))
                        {
                            MessageBox.Show("Mã lớp không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (((DataRowView)bdsLOP[i])["TENLOP"].ToString().Equals(""))
                        {
                            MessageBox.Show("Tên lớp không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        SqlDataReader reader;
                        reader = Program.ExecSqlDataReader("EXEC SP_KiemTraMaLop '" + ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString().Trim() + "'");
                        if (reader == null)
                        {
                            MessageBox.Show("NULL");
                            return;
                        }
                        reader.Read();
                        if (reader.GetString(0).Equals("Y"))
                        {
                            MessageBox.Show("Mã lớp: " + ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString().Trim() + " bị trùng !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại thông tin đã nhập !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                bdsLOP.EndEdit();
                bdsLOP.ResetCurrentItem();
                LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                LOPTableAdapter.Update(this.dsTN.LOP);
                btnThemLop.Enabled = btnXoaLop.Enabled = btnGhiLop.Enabled = true;
                MessageBox.Show("Ghi lớp thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi lớp thất bại vì đã xảy ra lỗi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                return;
            }
        }
        private void gcKHOA_Click(object sender, EventArgs e)
        {
            this.vitribatdau = bdsLOP.Count;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = true;
            btnThemLop.Enabled = btnXoaLop.Enabled = btnGhiLop.Enabled = true;
        }
    }
}
