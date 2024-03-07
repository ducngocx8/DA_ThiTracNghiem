using CSDLPT_TN.report;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmXemKetQua : Form
    {
        private int dem = 0;
        public frmXemKetQua()
        {
            InitializeComponent();
        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            string masv = txtMaSinhVien.Text.Trim();
            string mamh = cbbMonHoc.SelectedValue.ToString().Trim();
            string date = dtNgayThi.DateTime.ToString("ddMMyyyy");
            string lanthi = cbbLanThi.Items[cbbLanThi.SelectedIndex].ToString().Trim();

            string baithi = mamh + masv + lanthi + date;
            rptKetQuaThi rpt = new rptKetQuaThi(baithi);
            rpt.lbHoTen.Text = txtTenSinhVien.Text;
            rpt.lbLanThi.Text = lanthi;
            rpt.lbMonThi.Text = txtTenMonHoc.Text;
            rpt.lbTenLop.Text = txtTenLop.Text;
            date = dtNgayThi.DateTime.ToString("dd/MM/yyyy");
            rpt.lbNgayThi.Text = date;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void frmXemKetQua_Load(object sender, EventArgs e)
        {
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
            cbbMonHoc.DataSource = bdsMonHoc;
            cbbMonHoc.DisplayMember = "TENMH";
            cbbMonHoc.ValueMember = "MAMH";
            if (cbbMonHoc.Items.Count <= 0)
            {
                return;
            }
            else
            {
                cbbMonHoc.SelectedIndex = 0;
            }
            cbbLanThi.Items.Add(1);
            cbbLanThi.Items.Add(2);
            if (cbbLanThi.Items.Count <= 0)
            {
                return;
            }
            else
            {
                cbbLanThi.SelectedIndex = -1;
            }
            dem++;

        }

        public void layThongTinBangDiem()
        {
            string masv = txtMaSinhVien.Text.Trim();
            string mamh = cbbMonHoc.SelectedValue.ToString().Trim();
            int lanthi = int.Parse(cbbLanThi.Items[cbbLanThi.SelectedIndex].ToString().Trim());
            string sql = "EXEC SP_ThongTinDiemSinhVienCau9 '" + masv + "', '" + mamh + "', " + lanthi;

            try
            {
                Program.myReader = Program.ExecSqlDataReader(sql);
                if (Program.myReader == null)
                {
                    return;
                }
                if (Program.myReader.Read())
                {
                    txtTenSinhVien.Text = Program.myReader.GetString(0);
                    txtTenMonHoc.Text = Program.myReader.GetString(1);
                    txtTenLop.Text = Program.myReader.GetString(2);
                    int lanThi = Program.myReader.GetInt16(3);
                    txtLanThi.Text = lanThi.ToString();
                    dtNgayThi.DateTime = Program.myReader.GetDateTime(4);
                    float diem = (float)Program.myReader.GetDouble(5);
                    txtDiem.Text = diem.ToString();
                    pnBtn.Visible = true;
                }
                else
                {
                    txtTenSinhVien.Text = "...";
                    txtTenMonHoc.Text = "...";
                    txtTenLop.Text = "...";
                    txtLanThi.Text = "...";
                    txtDiem.Text = "...";
                    pnBtn.Visible = false;
                }
                Program.myReader.Close();
                Program.conn.Close();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi xảy ra trong quá trình lấy thông tin! " + e, "ERROR",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dem > 0 && txtMaSinhVien.ToString().Trim().Length > 0 && cbbLanThi.SelectedIndex != -1)
                {
                    layThongTinBangDiem();
                }
            }
            catch (Exception) { }
        }

        private void cbbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dem > 0 && txtMaSinhVien.ToString().Trim().Length > 0)
                {
                    layThongTinBangDiem();
                }
            }
            catch (Exception) { }

        }

        private void txtMaSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
