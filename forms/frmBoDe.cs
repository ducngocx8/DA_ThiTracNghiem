using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_TN.forms
{
    public partial class frmBoDe : Form
    {
        int vitri;
        public frmBoDe()
        {
            InitializeComponent();
        }
        private void frmBoDe_Load(object sender, EventArgs e)
        {
            dsTN.EnforceConstraints = false;
            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.dsTN.BODE);
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {       
            vitri = bdsBODE.Position;
            bdsBODE.AddNew();
            this.cbbTrinhDo.Enabled = true;
            this.cbbTenMonHoc.Enabled = true;
            this.txtNoiDung.Enabled = true;
            this.txtA.Enabled = true;
            this.txtB.Enabled = true;
            this.txtC.Enabled = true;
            this.txtD.Enabled = true;
            this.cbbDapAn.Enabled = true;
            this.cbbTrinhDo.SelectedIndex = -1;
            this.cbbDapAn.SelectedIndex = -1;
            txtCauHoi.Text = (int.Parse(((DataRowView)bdsBODE[bdsBODE.Position - 1])["CAUHOI"].ToString()) + 1).ToString();
            ((DataRowView)bdsBODE[bdsBODE.Position])["CAUHOI"] = int.Parse(((DataRowView)bdsBODE[bdsBODE.Position - 1])["CAUHOI"].ToString()) + 1;
            ((DataRowView)bdsBODE[bdsBODE.Position])["MAGV"] = Program.username.ToString().ToUpper();
            try
            {
                ((DataRowView)bdsBODE[bdsBODE.Position])["TRINHDO"] = this.cbbTrinhDo.Text;
                ((DataRowView)bdsBODE[bdsBODE.Position])["DAP_AN"] = this.cbbDapAn.Text;
            }
            catch
            {

            }
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHoanTac.Enabled = true;
            this.cbbTenMonHoc.Enabled = true;
            gcBoDe.Enabled = false;
            pnTuongTac.Enabled = true;
        }
        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsBODE.Position;
            this.cbbTenMonHoc.Enabled = true;
            this.cbbTenMonHoc.SelectedIndex = 0;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHoanTac.Enabled = true;
            gcBoDe.Enabled = false;
            pnTuongTac.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!((String)((DataRowView)bdsBODE[bdsBODE.Position])["MAGV"]).ToString().Trim().ToUpper().Contains(Program.mlogin.ToString().Trim().ToUpper()))
            {
                MessageBox.Show("Giảng viên không được xóa câu hỏi của giảng viên khác !", "Lỗi cập nhật dữ liệu", MessageBoxButtons.OK);
                return;
            }
            Int32 ch = 0;
            if(MessageBox.Show("Có chắc chắn xóa câu hỏi này ?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    ch = int.Parse(((DataRowView)bdsBODE[bdsBODE.Position])["CAUHOI"].ToString());
                    bdsBODE.RemoveCurrent();
                    BODETableAdapter.Connection.ConnectionString = Program.connstr;
                    BODETableAdapter.Update(this.dsTN.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa câu hỏi thất bại vì đã xảy ra lỗi", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
                    bdsBODE.Position = bdsBODE.Find("CAUHOI", ch);
                    return;
                }
            }
            if (bdsBODE.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsBODE.Count == 0)
            {
                MessageBox.Show("Không có câu hỏi nào để ghi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbTenMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn môn học cho câu hỏi này !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if(cbbTrinhDo.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn trình độ cho câu hỏi này !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if(txtNoiDung.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập nội dung cho câu hỏi này !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                txtNoiDung.Focus();
                return;
            }
            if (txtA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập đáp án A !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                txtA.Focus();
                return;
            }
            if (txtB.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập đáp án B !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                txtB.Focus();
                return;
            }
            if (txtC.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập đáp án C !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                txtC.Focus();
                return;
            }
            if (txtD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập đáp án D !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                txtD.Focus();
                return;
            }
            if (cbbDapAn.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn đáp án cho câu hỏi này !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                return;
            }
            ((DataRowView)bdsBODE[bdsBODE.Position])["TRINHDO"] = this.cbbTrinhDo.Text;
            try
            {
                bdsBODE.EndEdit();
                bdsBODE.ResetCurrentItem();
                BODETableAdapter.Connection.ConnectionString = Program.connstr;
                BODETableAdapter.Update(this.dsTN.BODE);
                MessageBox.Show("Ghi câu hỏi thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi câu hỏi thất bại vì đã xảy ra lỗi !" + ex.Message, "Lỗi ghi dữ liệu", MessageBoxButtons.OK);
                return;
            }
            gcBoDe.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
            pnTuongTac.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBODE.CancelEdit();
            BODETableAdapter.Fill(this.dsTN.BODE);
            if (btnThem.Enabled == false)
            {
                bdsBODE.Position = vitri;
            }
            gcBoDe.Enabled = true;
            pnTuongTac.Enabled = false;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                BODETableAdapter.Fill(this.dsTN.BODE);
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
                this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.BODETableAdapter.Fill(this.dsTN.BODE);
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
            }
        }
        private void gcBoDe_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtCauHoi.Text = ((DataRowView)bdsBODE[bdsBODE.Position])["CAUHOI"].ToString();
                this.txtMaMonHoc.Text = ((DataRowView)bdsBODE[bdsBODE.Position])["MAMH"].ToString();
            }
            catch
            {

            }
            if (((String)((DataRowView)bdsBODE[bdsBODE.Position])["MAGV"]).ToString().Trim().ToUpper().Contains(Program.mlogin.ToString().Trim().ToUpper()))
            {
                this.cbbTrinhDo.Enabled = true;
                this.cbbTenMonHoc.Enabled = true;
                this.txtNoiDung.Enabled = true;
                this.txtA.Enabled = true;
                this.txtB.Enabled = true;
                this.txtC.Enabled = true;
                this.txtD.Enabled = true;
                this.cbbDapAn.Enabled = true;
                return;
            }
            this.cbbTrinhDo.Enabled = false;
            this.cbbTenMonHoc.Enabled = false;
            this.txtNoiDung.Enabled = false;
            this.txtA.Enabled = false;
            this.txtB.Enabled = false;
            this.txtC.Enabled = false;
            this.txtD.Enabled = false;
            this.cbbDapAn.Enabled = false;
        }

        private void cbbTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataRowView)bdsBODE[bdsBODE.Position])["TRINHDO"] = this.cbbTrinhDo.Text;
            }
            catch (Exception ex)
            {

            }
        }

        private void cbbDapAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataRowView)bdsBODE[bdsBODE.Position])["DAP_AN"] = this.cbbDapAn.Text;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
