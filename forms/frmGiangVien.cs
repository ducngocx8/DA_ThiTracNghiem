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
    public partial class frmGiangVien : Form
    {
        int vitri;
        int vitribatdau;
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            dsTN.EnforceConstraints = false;
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.dsTN.KHOA);
            this.GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIANGVIENTableAdapter.Fill(this.dsTN.GIAOVIEN);
            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.dsTN.BODE);
            this.GIANGVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIANGVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
            cbbCoSo.DataSource = Program.bds_dspm;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup.Equals("TRUONG"))
            {
                cbbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = false;

            }
            else
            {
                cbbCoSo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = true;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGIANGVIEN.AddNew();
            ((DataRowView)bdsGIANGVIEN[bdsGIANGVIEN.Position])["MAKH"] = ((DataRowView)bdsKHOA[bdsKHOA.Position])["MAKH"].ToString();
            btnXoa.Enabled = true;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string magiangvien = "";
            if (bdsBODE.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên này vì đã đăng ký trong bộ đề", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsGIANGVIEN_DANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên này vì đã đăng ký cho thi", "Lỗi xóa dữ liệu", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa giảng viên này ?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    magiangvien = ((DataRowView)bdsGIANGVIEN[bdsGIANGVIEN.Position])["MAGV"].ToString();
                    bdsGIANGVIEN.RemoveCurrent();
                    GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    GIANGVIENTableAdapter.Update(this.dsTN.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa giảng viên thất bại vì đã xảy ra lỗi", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GIANGVIENTableAdapter.Fill(this.dsTN.GIAOVIEN);
                    bdsGIANGVIEN.Position = bdsGIANGVIEN.Find("MAGV", magiangvien);
                    return;
                }
            }

            if (bdsGIANGVIEN.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }
        private void btnGhi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsGIANGVIEN.Count == 0)
            {
                MessageBox.Show("Không có giảng viên nào để ghi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    for (int i = bdsGIANGVIEN.Count - 2; i < this.bdsGIANGVIEN.Count; i++)
                    {
                        if (((DataRowView)bdsGIANGVIEN[i])["MAGV"].ToString().Equals(""))
                        {
                            MessageBox.Show("Mã giảng viên không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (((DataRowView)bdsGIANGVIEN[i])["HO"].ToString().Equals(""))
                        {
                            MessageBox.Show("Họ không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (((DataRowView)bdsGIANGVIEN[i])["TEN"].ToString().Equals(""))
                        {
                            MessageBox.Show("Tên không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        SqlDataReader reader;
                        reader = Program.ExecSqlDataReader("EXEC SP_KiemTraMaGiangVien '" + ((DataRowView)bdsKHOA[bdsKHOA.Position])["MAGV"].ToString().Trim() + "'");
                        if (reader == null)
                        {
                            return;
                        }
                        reader.Read();
                        if (reader.GetString(0).Equals("Y"))
                        {
                            MessageBox.Show("Mã giảng viên: " + ((DataRowView)bdsKHOA[bdsKHOA.Position])["MAGV"].ToString().Trim() + " bị trùng !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                bdsGIANGVIEN.EndEdit();
                bdsGIANGVIEN.ResetCurrentItem();
                GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                GIANGVIENTableAdapter.Update(this.dsTN.GIAOVIEN);
                MessageBox.Show("Ghi giảng viên thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi giảng viên thất bại vì đã xảy ra lỗi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                return;
            }
            gcGiangVien.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnHoanTac.Enabled = false;
        }

        private void btnHoanTac_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGIANGVIEN.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsGIANGVIEN.Position = vitri;
            }
            gcGiangVien.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnHoanTac.Enabled = false;
        }
        private void btnLamMoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                GIANGVIENTableAdapter.Fill(this.dsTN.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Làm mới dữ liệu đã gặp lỗi !", "Lỗi làm mới dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCoSo.SelectedValue.ToString().Equals("System.Data.DataRowView"))
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
                this.GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIANGVIENTableAdapter.Fill(this.dsTN.GIAOVIEN);
                this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.BODETableAdapter.Fill(this.dsTN.BODE);
                this.GIANGVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIANGVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
            }
        }
        private void gcKhoa_Click(object sender, EventArgs e)
        {
            this.vitribatdau = bdsGIANGVIEN.Count;
        }

        private void gcGiangVien_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = true;
        }
    }
}
