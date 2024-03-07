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
    public partial class frmMonHoc : Form
    {
        int vitri;
        public frmMonHoc()
        {
            InitializeComponent();
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dsTN.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
            this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BANGDIEMTableAdapter.Fill(this.dsTN.BANGDIEM);
            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.dsTN.BODE);
            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
            cbbCoSo.DataSource = Program.bds_dspm;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup.Equals("TRUONG"))
            {
                cbbCoSo.Enabled = true;
                btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = false;

            }
            else
            {
                cbbCoSo.Enabled = false;
                btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = true;
            }
            pnTuongTac.Enabled = false;
        }
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMONHOC.Position;
            pnTuongTac.Enabled = true;
            bdsMONHOC.AddNew();
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled =  btnHoanTac.Enabled = true;
            gcMonHoc.Enabled = false;
        }

        private void btnCapNhat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMONHOC.Position;
            pnTuongTac.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHoanTac.Enabled = true;
            gcMonHoc.Enabled = false;
        }

        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mamh = "";
            if (bdsGiAOVIEN_DANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có giảng viên đăng ký thi", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsBANGDIEM.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có trong bảng điểm", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (bdsBODE.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có trong bộ đề", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa môn học này ?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mamh = ((DataRowView)bdsMONHOC[bdsMONHOC.Position])["MAMH"].ToString();
                    bdsMONHOC.RemoveCurrent();
                    MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    MONHOCTableAdapter.Update(this.dsTN.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa môn học thất bại vì đã xảy ra lỗi" + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
                    this.bdsMONHOC.Position = this.bdsMONHOC.Find("MAMH", mamh);
                    return;
                }
            }

            if (bdsMONHOC.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsMONHOC.Count == 0)
            {
                MessageBox.Show("Không có môn học nào để ghi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaMonHoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã môn học không được để trống !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaMonHoc.Focus();
                return;
            }
            if(txtTenMonHoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên môn học không được để trống !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenMonHoc.Focus();
                return;
            }
            try
            {
                SqlDataReader reader;
                reader = Program.ExecSqlDataReader("EXEC SP_KiemTraMaMonHoc '" + ((DataRowView)bdsMONHOC[bdsMONHOC.Position])["MAMH"].ToString().Trim() + "'");
                if (reader == null)
                {
                    return;
                }
                reader.Read();
                if(reader.GetString(0).Equals("Y"))
                {
                    MessageBox.Show("Mã môn học bị trùng !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                reader.Close();
            }
            catch
            {

            }
            try
            {         
                bdsMONHOC.EndEdit();
                bdsMONHOC.ResetCurrentItem();
                MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                MONHOCTableAdapter.Update(this.dsTN.MONHOC);
                MessageBox.Show("Ghi môn học thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ghi môn học thất bại vì đã xảy ra lỗi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gcMonHoc.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
            pnTuongTac.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMONHOC.CancelEdit();
            if(btnThem.Enabled == false)
            {
                bdsMONHOC.Position = vitri; 
            }
            gcMonHoc.Enabled = true;
            pnTuongTac.Enabled = false;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
        }

        private void btnLamMoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Làm mới dữ liệu đã gặp lỗi !", "Lỗi làm mới dữ liệu", MessageBoxButtons.OK);
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
            if(cbbCoSo.SelectedIndex != Program.mCoso)
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
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
                this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.BANGDIEMTableAdapter.Fill(this.dsTN.BANGDIEM);
                this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.BODETableAdapter.Fill(this.dsTN.BODE);
                this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
            }
        }

        private void gcMonHoc_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = true;
        }
    }
}
