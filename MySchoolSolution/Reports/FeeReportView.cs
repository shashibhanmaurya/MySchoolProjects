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
        public DataSet dataSet { get; set; }
        public string purpose { get; set; }
        public FeeReportView()
        {
            InitializeComponent();
        }

        private void FeeReportView_Load(object sender, EventArgs e)
        {
            if (purpose.Contains("Fee Collection for date"))
            {
                Reports.DailyFeeReport mr = new Reports.DailyFeeReport();
                CrystalDecisions.CrystalReports.Engine.TextObject Purpose = mr.ReportDefinition.ReportObjects["Purpose"] as CrystalDecisions.CrystalReports.Engine.TextObject;
                Purpose.Text = purpose;
                mr.SetDataSource(dataSet.Tables[0]);
                mr.SetDatabaseLogon("sa", "abc123");
                crystalReportViewer1.ReportSource = mr;
            }
            else
            {
                Reports.FeeReport mr = new Reports.FeeReport();
                CrystalDecisions.CrystalReports.Engine.TextObject Purpose = mr.ReportDefinition.ReportObjects["Purpose"] as CrystalDecisions.CrystalReports.Engine.TextObject;
                Purpose.Text = purpose;
                mr.SetDataSource(dataSet.Tables[0]);
                mr.SetDatabaseLogon("sa", "abc123");
                crystalReportViewer1.ReportSource = mr;
            }                 

           
        }
    }
}
