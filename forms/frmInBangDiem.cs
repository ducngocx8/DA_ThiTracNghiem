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
    public partial class frmInBangDiem : Form
    {
        public frmInBangDiem()
        {
            InitializeComponent();
        }

        private void frmInBangDiem_Load(object sender, EventArgs e)
        {
            dsTN.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dsTN.LOP);
            this.cbbLop.DataSource = this.dsTN.LOP;
            this.cbbLop.DisplayMember = "TENLOP";
            this.cbbLop.ValueMember = "MALOP";
            this.cbbMonHoc.DataSource = this.dsTN.MONHOC;
            this.cbbMonHoc.DisplayMember = "TENMH";
            this.cbbMonHoc.ValueMember = "MAMH";
            cbbCoSo.DataSource = Program.bds_dspm;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoso;
            if(Program.mGroup.Equals("TRUONG"))
            {
                cbbCoSo.Enabled = true;
            }
            else
            {
                cbbCoSo.Enabled = false;
            }
            this.cbbLanThi.SelectedIndex = 0;
        }
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            rptBangDiem rp = new rptBangDiem(this.cbbLop.SelectedValue.ToString(), this.cbbMonHoc.SelectedValue.ToString(), int.Parse(this.cbbLanThi.Text.ToString()));
            rp.lbTieuDe.Text = "BẢNG ĐIỂM THI LẦN " + this.cbbLanThi.Text.ToUpper() + " CỦA MÔN " + cbbMonHoc.Text.ToUpper() + " THUỘC LỚP " + cbbLop.Text.ToUpper();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
        private void cbbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
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
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Fill(this.dsTN.MONHOC);
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dsTN.LOP);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
