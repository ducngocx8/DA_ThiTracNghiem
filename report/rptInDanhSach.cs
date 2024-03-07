using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT_TN.report
{
    public partial class rptInDanhSach : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInDanhSach()
        {
            InitializeComponent();
        }
        public rptInDanhSach(String tungay, String denngay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tungay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denngay;
            this.sqlDataSource1.Fill();
        }
    }
}
