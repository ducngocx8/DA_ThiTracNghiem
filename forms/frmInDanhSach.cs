using CSDLPT_TN.report;
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
    public partial class frmInDanhSach : Form
    {
        String tungay;
        String denngay;
        bool kiemtratungay = false;
        bool kiemtrdenngay = false;
        public frmInDanhSach()
        {
            InitializeComponent();
        }

        private void frmInDanhSach_Load(object sender, EventArgs e)
        {
        }
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            if(!kiemtratungay)
            {
                MessageBox.Show("Chưa chọn ngày bắt đầu !", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(!kiemtrdenngay)
            {
                MessageBox.Show("Chưa chọn ngày kết thúc !", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            rptInDanhSach rp = new rptInDanhSach(this.tungay, this.denngay);
            rp.lbTieuDe.Text = "DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM THUỘC 2 CƠ SỞ TỪ NGÀY " + this.dtpkTuNgay.Value.ToString("dd/MM/yyyy").ToUpper() + " ĐẾN NGÀY " + this.dtpkDenNgay.Value.ToString("dd/MM/yyyy");
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void dtpkTuNgay_ValueChanged(object sender, EventArgs e)
        {
            this.kiemtratungay = true;
            this.tungay = this.dtpkTuNgay.Value.ToString("yyyy-MM-dd").Trim();
        }
        private void dtpkDenNgay_ValueChanged(object sender, EventArgs e)
        {
            this.kiemtrdenngay = true;
            this.denngay = this.dtpkDenNgay.Value.ToString("yyyy-MM-dd").Trim();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
