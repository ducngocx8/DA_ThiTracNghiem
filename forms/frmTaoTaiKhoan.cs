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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DSGVChuaCoTaiKhoan");
            this.cbbGVSV.DataSource = dt;
            this.cbbGVSV.DisplayMember = "HOTEN";
            this.cbbGVSV.ValueMember = "MAGV";
            if (this.cbbGVSV.Items.Count == 0)
            {
                return;
            }
            this.cbbGVSV.SelectedIndex = 0;
            if(Program.mGroup.Equals("TRUONG"))
            {
                this.lbNhom.Visible = this.rdbtCoSo.Visible = this.rdbtGiangVien.Visible = false;
            }
            else if (Program.mGroup.Equals("COSO"))
            {
                this.rdbtCoSo.Visible = this.rdbtGiangVien.Visible = true;
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (this.cbbGVSV.Items.Count == 0)
            {
                MessageBox.Show("Không có giảng viên để tạo tài khoản !", "Lỗi ghi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenTaiKhoan.Focus();
                return;
            }
            if(txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMatKhau.Focus();
                return;
            }
            if(this.rdbtCoSo.Checked != true && this.rdbtGiangVien.Checked != true && Program.mGroup.Equals("COSO"))
            {
                MessageBox.Show("Nhóm không được để trống!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMatKhau.Focus();
                return;
            }
            string strLenh = "";
            if (Program.mGroup.Equals("TRUONG"))
            {
                strLenh = "SP_TAOTAIKHOAN '" + txtTenTaiKhoan.Text.ToUpper() + "', '" + txtMatKhau.Text + "', '" + cbbGVSV.SelectedValue.ToString() + "' , 'TRUONG'";
            }
            else if (Program.mGroup.Equals("COSO"))
            {
                if (this.rdbtCoSo.Checked == true)
                {
                    strLenh = "SP_TAOTAIKHOAN '" + txtTenTaiKhoan.Text.ToUpper().Trim() + "', '" + txtMatKhau.Text.Trim() + "', '" + cbbGVSV.SelectedValue.ToString().Trim() + "' , 'COSO'";
                }
                else if (this.rdbtGiangVien.Checked == true)
                {
                    strLenh = "SP_TAOTAIKHOAN '" + txtTenTaiKhoan.Text.ToUpper().Trim() + "', '" + txtMatKhau.Text.Trim() + "', '" + cbbGVSV.SelectedValue.ToString().Trim() + "' , 'GIANGVIEN'";
                }
            }
            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null)
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = new DataTable();
                    dt = Program.ExecSqlDataTable("SELECT * FROM V_DSGVChuaCoTaiKhoan");
                    this.cbbGVSV.DataSource = dt;
                    this.cbbGVSV.DisplayMember = "HOTEN";
                    this.cbbGVSV.ValueMember = "MAGV";
                    if (this.cbbGVSV.Items.Count == 0)
                    {
                        return;
                    }
                    this.cbbGVSV.SelectedIndex = 0;
                    if (Program.mGroup.Equals("TRUONG"))
                    {
                        this.lbNhom.Visible = this.rdbtCoSo.Visible = this.rdbtGiangVien.Visible = false;
                    }
                    else if (Program.mGroup.Equals("COSO"))
                    {
                        this.rdbtCoSo.Visible = this.rdbtGiangVien.Visible = true;
                    }
                    this.txtTenTaiKhoan.Text = "";
                    this.txtMatKhau.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm tài khoản thất bại" + ex.Message, "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
