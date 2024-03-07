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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void rdbtnSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            this.lbTaiKhoan.Text = "MÃ SINH VIÊN:";
        }

        private void rdbtnGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            this.lbTaiKhoan.Text = "TÀI KHOẢN:";
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string chuoiKetNoi = "Data Source=LAPTOP-TC17PAIU\\MSSQLSERVER04;Initial Catalog=TN;User ID=sa;password=123";
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            Program.conn.ConnectionString = chuoiKetNoi;
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DSPM");
            Program.bds_dspm.DataSource = dt;
            cbbCoSo.DataSource = dt;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = 0;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtTaiKhoan.Text.Trim() == "" || this.txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Phải điền đầy đủ tài khoản và mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Program.servername = cbbCoSo.SelectedValue.ToString();
            if(this.rdbtnSinhVien.Checked == true)
            {
                Program.mlogin = "SV";
                Program.password = "123";
            }
            else
            {
                Program.mlogin = this.txtTaiKhoan.Text.Trim();
                Program.password = this.txtMatKhau.Text.Trim();
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác !", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.mCoso = this.cbbCoSo.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "";
            if (this.rdbtnGiangVien.Checked == true)
            {
                strLenh = "EXEC SP_DangNhapGiangVien '" + Program.mlogin + "'";
            }
            else if (this.rdbtnSinhVien.Checked == true)
            {
                
                try
                {
                    SqlDataReader reader;
                    reader = Program.ExecSqlDataReader("EXEC SP_KiemTraDangNhapSinhVien '" + this.txtTaiKhoan.Text.Trim() + "', '" + this.txtMatKhau.Text.Trim() + "'");
                    if (reader == null)
                    {
                        Program.myReader.Close();
                        return;
                    }
                    reader.Read();
                    if (reader.GetString(0).Equals("N"))
                    {
                        MessageBox.Show("Sinh viên đã đăng nhập sai tài khoản hoặc mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Program.username = reader.GetString(0);
                    strLenh = "EXEC SP_DangNhapSinhVien 'SV', '" + Program.username.Trim() + "'";
                    reader.Close();
                }
                catch(Exception ex)
                {

                }  
            }
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return;
            }
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0); 
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập dữ liệu\n Xem lại tài khoản và mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            String tam = "";
            if(Program.mGroup.Equals("TRUONG"))
            {
                tam = "Trường";
                Program.frmChinh.btnTaoTaiKhoan.Enabled = true;
                Program.frmChinh.btnDangXuat.Enabled = true;
                Program.frmChinh.btnMonHoc.Enabled = true;
                Program.frmChinh.btnKhoa.Enabled = true;
                Program.frmChinh.btnSinhVien.Enabled = true;
                Program.frmChinh.btnGiangVien.Enabled = true;
                Program.frmChinh.btnDe.Enabled = true;
                Program.frmChinh.btnDangKyThi.Enabled = true;
                Program.frmChinh.btnKetQua.Enabled = true;
                Program.frmChinh.btnInBangDiem.Enabled = true;
                Program.frmChinh.btnInDanhSach.Enabled = true;
            }
            else if (Program.mGroup.Equals("COSO"))
            {
                tam = "Cơ sở";
                Program.frmChinh.btnTaoTaiKhoan.Enabled = true;
                Program.frmChinh.btnDangXuat.Enabled = true;
                Program.frmChinh.btnMonHoc.Enabled = true;
                Program.frmChinh.btnKhoa.Enabled = true;
                Program.frmChinh.btnSinhVien.Enabled = true;
                Program.frmChinh.btnGiangVien.Enabled = true;
                Program.frmChinh.btnDe.Enabled = true;
                Program.frmChinh.btnDangKyThi.Enabled = true;
                Program.frmChinh.btnThi.Enabled = true;
                Program.frmChinh.btnKetQua.Enabled = true;
                Program.frmChinh.btnInBangDiem.Enabled = true;
                Program.frmChinh.btnInDanhSach.Enabled = true;
            }
            else if (Program.mGroup.Equals("GIANGVIEN"))
            {
                tam = "Giảng viên";
                Program.frmChinh.btnTaoTaiKhoan.Enabled = false;
                Program.frmChinh.btnDangXuat.Enabled = true;
                Program.frmChinh.btnMonHoc.Enabled = false;
                Program.frmChinh.btnKhoa.Enabled = false;
                Program.frmChinh.btnSinhVien.Enabled = false;
                Program.frmChinh.btnGiangVien.Enabled = false;
                Program.frmChinh.btnDe.Enabled = true;
                Program.frmChinh.btnDangKyThi.Enabled = true;
                Program.frmChinh.btnThi.Enabled = true;
                Program.frmChinh.btnKetQua.Enabled = true;
                Program.frmChinh.btnInBangDiem.Enabled = false;
                Program.frmChinh.btnInDanhSach.Enabled = false;
            }
            else
            {
                tam = "Sinh viên";
                Program.frmChinh.btnThi.Enabled = true;
            }
            if (Program.mGroup.Equals("SINHVIEN"))
            {
                MessageBox.Show("Đăng nhập thành công ! " + "\nHọ và tên sinh viên: " + Program.mHoten + "\nThuộc nhóm: " + tam, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Đăng nhập thành công ! " + "\nHọ và tên giảng viên: " + Program.mHoten + "\nThuộc nhóm: " + tam, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Program.frmChinh.btnDangNhap.Enabled = false;
            Program.frmChinh.btnDangXuat.Enabled = true;
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
        }
    }
}
