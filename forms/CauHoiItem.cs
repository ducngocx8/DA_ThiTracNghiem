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
    public partial class CauHoiItem : UserControl
    {
        private int idBaiThi;
        private int idde;
        private int cauSo;
        private string ndCauHoi;
        private string cauA;
        private string cauB;
        private string cauC;
        private string cauD;
        private string daChon = "";
        private string dapAn = "";
        private int maBD;

        public CauHoiItem()
        {
            InitializeComponent();
        }

        public int MaBangDiem
        {
            get { return maBD; }
            set { maBD = value; }
        }

        public int IDBaiThi
        {
            get { return idBaiThi; }
            set { idBaiThi = value; }
        }

        public int IDDe
        {
            get { return idde; }
            set { idde = value; }
        }

        public int CauSo
        {
            get { return cauSo; }
            set
            {
                cauSo = value;
                lbCauSo.Text = "Câu " + cauSo + ": ";
            }
        }
        //câu hỏi
        public string NDCauHoi
        {
            get { return ndCauHoi; }
            set
            {
                ndCauHoi = value;
                lbNoiDungCH.Text = ndCauHoi;
            }
        }

        //câu A
        public string CauA
        {
            get { return cauA; }
            set
            {
                cauA = value;
                rbA.Text = cauA;
            }
        }
        //câu B
        public string CauB
        {
            get { return cauB; }
            set
            {
                cauB = value;
                rbB.Text = cauB;
            }
        }
        //câu C
        public string CauC
        {
            get { return cauC; }
            set
            {
                cauC = value;
                rbC.Text = cauC;
            }
        }
        //câu D
        public string CauD
        {
            get { return cauD; }
            set
            {
                cauD = value;
                rbD.Text = cauD;
            }
        }

        //câu đã chọn
        public string CauDaChon
        {
            get { return daChon; }
            set { daChon = value; }
        }

        //câu đáp án
        public string CauDapAn
        {
            get { return dapAn; }
            set { dapAn = value; }
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "A";
            var principalForm = Application.OpenForms.OfType<frmThi>().Single();
            principalForm.capNhatDapAnDaChon(cauSo, "A");
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "B";
            var principalForm = Application.OpenForms.OfType<frmThi>().Single();
            principalForm.capNhatDapAnDaChon(cauSo, "B");
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "C";
            var principalForm = Application.OpenForms.OfType<frmThi>().Single();
            principalForm.capNhatDapAnDaChon(cauSo, "C");
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "D";
            var principalForm = Application.OpenForms.OfType<frmThi>().Single();
            principalForm.capNhatDapAnDaChon(cauSo, "D");
        }
    }
}
