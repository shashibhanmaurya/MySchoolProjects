using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution.Reports
{
    public partial class FeeReportView : Form
    {
        public FeeReportView()
        {
            InitializeComponent();
        }

        private void FeeReportView_Load(object sender, EventArgs e)
        {
            SqlParameter[] m = new SqlParameter[1];

            m[0] = new SqlParameter("@Date", Convert.ToDateTime(DateTime.Now).ToShortDateString());

            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "DailyFeeCollection", m);
            Reports.FeeReport mr = new Reports.FeeReport();

            mr.SetDataSource(ds.Tables[0]);
            mr.SetDatabaseLogon("sa", "abc123");
            crystalReportViewer1.ReportSource = mr;
        }
    }
}
