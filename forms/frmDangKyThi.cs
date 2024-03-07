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
    public partial class frmDangKyThi : Form
    {
        int vitri;
        int vitribatdau;
        public frmDangKyThi()
        {
            InitializeComponent();
        }

        private void frmDangKyThi_Load(object sender, EventArgs e)
        {
            Int16[] lan = new Int16[2];
            Int16[] socauthi = new Int16[91];
            Int16[] thoigianthi = new Int16[46];
            dsTN.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dsTN.LOP);
            this.GIANGVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIANGVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
            cbbCoSo.DataSource = Program.bds_dspm;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoso;
            this.repositoryItemLookUpEdit1.DataSource = this.dsTN.MONHOC;
            this.repositoryItemLookUpEdit1.DisplayMember = "MAMH";
            this.repositoryItemLookUpEdit1.ValueMember = "MAMH";
            this.repositoryItemLookUpEdit2.DataSource = new String[]{"A", "B", "C"};
            for(int i=0; i<=1; i++)
            {
                lan[i] = Int16.Parse((i+1).ToString());
            }
            this.repositoryItemLookUpEdit3.DataSource = lan;
            for (int i = 10; i <= 100; i++)
            {
                socauthi[i-10] = Int16.Parse((i.ToString()));
            }
            this.repositoryItemLookUpEdit4.DataSource = socauthi;
            for (int i = 15; i <= 60; i++)
            {
               thoigianthi[i-15] = Int16.Parse((i.ToString()));
            }
            this.repositoryItemLookUpEdit5.DataSource = thoigianthi;
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
            bdsGIANGVIEN_DANGKY.AddNew();
            ((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["MAGV"] = Program.username;
            btnXoa.Enabled = true;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String magv;
            if (!((DateTime)((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["NGAYTHI"] >= DateTime.Now))
            {
                MessageBox.Show("Đã qua ngày thi nên không thể xóa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(MessageBox.Show("Có chắc chắn hủy đăng ký ?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    magv = ((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["MAGV"].ToString();
                    bdsGIANGVIEN_DANGKY.RemoveCurrent();
                    GIANGVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    GIANGVIEN_DANGKYTableAdapter.Update(this.dsTN.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hủy đăng ký thất bại vì đã xảy ra lỗi", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GIANGVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
                    return;
                }
            }
            if (bdsGIANGVIEN_DANGKY.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsGIANGVIEN_DANGKY.Count == 0)
            {
                MessageBox.Show("Không có đăng ký thi nào để ghi !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    for (int i = bdsGIANGVIEN_DANGKY.Count - 1; i < this.bdsGIANGVIEN_DANGKY.Count; i++)
                    {
                        if(((DataRowView)bdsGIANGVIEN_DANGKY[i])["MAMH"].ToString().Equals(""))
                        {
                            MessageBox.Show("Mã môn học không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(((DataRowView)bdsGIANGVIEN_DANGKY[i])["TRINHDO"].ToString().Equals(""))
                        {
                            MessageBox.Show("Trình độ không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(((DataRowView)bdsGIANGVIEN_DANGKY[i])["NGAYTHI"].ToString().Equals(""))
                        {
                            MessageBox.Show("Ngày thi không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(((DataRowView)bdsGIANGVIEN_DANGKY[i])["LAN"].ToString().Equals(""))
                        {
                            MessageBox.Show("Lần thi không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(((DataRowView)bdsGIANGVIEN_DANGKY[i])["SOCAUTHI"].ToString().Equals(""))
                        {
                            MessageBox.Show("Số câu thi không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(((DataRowView)bdsGIANGVIEN_DANGKY[i])["THOIGIAN"].ToString().Equals(""))
                        {
                            MessageBox.Show("Thời gian thi không thể trống !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        SqlDataReader reader1;
                        reader1 = Program.ExecSqlDataReader("EXEC SP_KiemTraGiangVienDangKy '" + ((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["MALOP"].ToString().Trim() + "', '" + ((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["MAMH"].ToString().Trim() + "', '" + ((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["LAN"].ToString().Trim() + "'");
                        if (reader1 == null)
                        {
                            return;
                        }
                        reader1.Read();
                        if (reader1.GetString(0).Equals("Y"))
                        {
                            MessageBox.Show("Thông tin đăng ký:\nMã lớp: " + ((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["MALOP"].ToString().Trim() + "\nMã môn học: " + ((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["MAMH"].ToString().Trim() + "\nLần: " + ((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["LAN"].ToString().Trim() + "\nbị trùng !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reader1.Close();
                            return;
                        }
                        reader1.Close();
                        if (!((DateTime)((DataRowView)bdsGIANGVIEN_DANGKY[i])["NGAYTHI"] >= DateTime.Now.Date))
                        {
                            MessageBox.Show("Ngày thi không thể nhỏ hơn hiện tại !", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        SqlDataReader reader2;
                        reader2 = Program.ExecSqlDataReader("EXEC SP_SOCAUHOI '" + ((DataRowView)bdsGIANGVIEN_DANGKY[i])["MAMH"].ToString().Trim() + "', '" + ((DataRowView)bdsGIANGVIEN_DANGKY[i])["TRINHDO"].ToString().Trim() + "', '" + ((DataRowView)bdsGIANGVIEN_DANGKY[i])["SOCAUTHI"].ToString().Trim() + "'");
                        if (reader2 == null)
                        {
                            return;
                        }
                        reader2.Read();
                        if (reader2.GetString(0).Equals("N"))
                        {
                            
                              int socauthieu = reader2.GetInt32(1);
                              MessageBox.Show("Trong bộ đề không đủ sô câu thi của mã môn: " + ((DataRowView)bdsGIANGVIEN_DANGKY[i])["MAMH"].ToString() + " !\n Số câu còn thiếu: " + socauthieu.ToString(), "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              reader2.Close();
                              return;
                        }
                        reader2.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Kiểm tra lại thông tin đã nhập !" + ex.Message, "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                bdsGIANGVIEN_DANGKY.EndEdit();
                bdsGIANGVIEN_DANGKY.ResetCurrentItem();
                GIANGVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                GIANGVIEN_DANGKYTableAdapter.Update(this.dsTN.GIAOVIEN_DANGKY);
                MessageBox.Show("Ghi đăng ký thi thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHoanTac.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi đăng ký thất bại vì đã xảy ra lỗi !" + ex.Message, "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gcGiaoVienDangKy.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnHoanTac.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGIANGVIEN_DANGKY.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsGIANGVIEN_DANGKY.Position = vitri;
            }
            gcGiaoVienDangKy.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnHoanTac.Enabled = false;
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                GIANGVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
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
                dsTN.EnforceConstraints = false;
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dsTN.LOP);
                this.GIANGVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIANGVIEN_DANGKYTableAdapter.Fill(this.dsTN.GIAOVIEN_DANGKY);
            }
        }

        private void gcGiaoVienDangKy_Click(object sender, EventArgs e)
        {
            int vt = bdsGIANGVIEN_DANGKY.Position;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = true;
            if(!((DataRowView)bdsGIANGVIEN_DANGKY[bdsGIANGVIEN_DANGKY.Position])["MAGV"].ToString().ToUpper().Trim().Equals(Program.username.ToString().ToUpper().Trim()))
            {
                MessageBox.Show("Giảng viên không được phép cập nhật đăng ký của giảng viên khác", "Lỗi cập nhật dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bdsGIANGVIEN_DANGKY.Position = vt;
                return;
            }
        }

        private void gcLop_Click(object sender, EventArgs e)
        {
            this.vitribatdau = bdsGIANGVIEN_DANGKY.Count;
        }
    }
}
