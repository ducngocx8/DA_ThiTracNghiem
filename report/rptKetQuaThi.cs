using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CSDLPT_TN.report
{
    public partial class rptKetQuaThi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKetQuaThi()
        {

        }
        public rptKetQuaThi(string baithi)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = baithi;
            this.sqlDataSource1.Fill();
        }

    }
}
