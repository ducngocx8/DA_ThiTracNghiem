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
    public partial class frmLopSinhVien : Form
    {
        int vitri;
        int vitribatdau;
        public frmLopSinhVien()
        {
            InitializeComponent();
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
            if(Program.KetNoi() == 0)
            {

            }
            else
            {
                dsTN.EnforceConstraints = false;
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dsTN.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.dsTN.SINHVIEN);
                this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.BANGDIEMTableAdapter.Fill(this.dsTN.BANGDIEM);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSINHVIEN.AddNew();
            ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MALOP"] = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
            btnXoa.Enabled = true;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string masinhvien = "";
            if (bdsBANGDIEM.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên viên này vì đã có điểm ", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa sinh viên này ?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masinhvien = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MASV"].ToString();
                    bdsSINHVIEN.RemoveCurrent();
                    SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    SINHVIENTableAdapter.Update(this.dsTN.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa sinh viên thất bại vì đã xảy ra lỗi", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SINHVIENTableAdapter.Fill(this.dsTN.SINHVIEN);
                    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MASV", masinhvien);
                    return;
                }
            }

            if (bdsSINHVIEN.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsSINHVIEN.Count == 0)
            {
                MessageBox.Show("Không có sinh viên nào để ghi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    for (int i = bdsSINHVIEN.Count - 1; i < this.bdsSINHVIEN.Count; i++)
                    {
                        if(((DataRowView)bdsSINHVIEN[i])["MASV"].ToString().Equals(""))
                        {
                            MessageBox.Show("Mã sinh viên không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(((DataRowView)bdsSINHVIEN[i])["HO"].ToString().Equals(""))
                        {
                            MessageBox.Show("Họ không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(((DataRowView)bdsSINHVIEN[i])["TEN"].ToString().Equals(""))
                        {
                            MessageBox.Show("Tên không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (((DataRowView)bdsSINHVIEN[i])["NGAYSINH"].ToString().Equals(""))
                        {
                            MessageBox.Show("Ngày sinh không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(((DataRowView)bdsSINHVIEN[i])["DIACHI"].ToString().Equals(""))
                        {
                            MessageBox.Show("Địa chỉ không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(((DataRowView)bdsSINHVIEN[i])["PASSWORD"].ToString().Equals(""))
                        {
                            MessageBox.Show("Mật khẩu không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (!((DateTime)((DataRowView)bdsSINHVIEN[i])["NGAYSINH"] <= DateTime.Now))
                        {
                            MessageBox.Show("Ngày sinh không thể lớn hơn hiện tại !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        SqlDataReader reader;
                        reader = Program.ExecSqlDataReader("EXEC SP_KiemTraMaSinhVien '" + ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MASV"].ToString().Trim() + "'");
                        if (reader == null)
                        {
                            return;
                        }
                        reader.Read();
                        if (reader.GetString(0).Equals("Y"))
                        {
                            MessageBox.Show("Mã sinh viên: " + ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MASV"].ToString().Trim() + " bị trùng !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                bdsSINHVIEN.EndEdit();
                bdsSINHVIEN.ResetCurrentItem();
                SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                SINHVIENTableAdapter.Update(this.dsTN.SINHVIEN);
                MessageBox.Show("Ghi sinh viên thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi sinh viên thất bại vì đã xảy ra lỗi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["PASSWORD"].ToString(), "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                return;
            }
            gcSinhVien.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnHoanTac.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSINHVIEN.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsSINHVIEN.Position = vitri;
            }
            gcSinhVien.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnHoanTac.Enabled = false;
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SINHVIENTableAdapter.Fill(this.dsTN.SINHVIEN);
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
        private void frmLopSinhVien_Load(object sender, EventArgs e)
        {
            dsTN.EnforceConstraints = false;
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dsTN.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.dsTN.SINHVIEN);
            this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BANGDIEMTableAdapter.Fill(this.dsTN.BANGDIEM);
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

        private void gcLop_Click(object sender, EventArgs e)
        {
            this.vitribatdau = bdsSINHVIEN.Count;
        }

        private void gcSinhVien_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = true;
        }
    }
}
