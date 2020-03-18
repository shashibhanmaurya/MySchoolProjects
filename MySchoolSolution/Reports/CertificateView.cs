using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution.Reports
{
    public partial class CertificateView : Form
    {
        public CertificateView()
        {
            InitializeComponent();
        }
        public DataSet dataSet { get; set; }
        public string purpose { get; set; }
        private void Certificate_Load(object sender, EventArgs e)
        {
            if (purpose == "FeeCertificate")
            {
                StudentFeeCertificatePrint mr = new StudentFeeCertificatePrint();
               // CrystalDecisions.CrystalReports.Engine.TextObject Purpose = mr.ReportDefinition.ReportObjects["Purpose"] as CrystalDecisions.CrystalReports.Engine.TextObject;
               // Purpose.Text = purpose;
                mr.SetDataSource(dataSet.Tables[0]);
                mr.SetDatabaseLogon("sa", "abc123");
                CertificateViewer.ReportSource = mr;
            }
            //if (purpose == "BirthCertificate")
            //{
            //    Reports.FeeReport mr = new Reports.FeeReport();
            //    CrystalDecisions.CrystalReports.Engine.TextObject Purpose = mr.ReportDefinition.ReportObjects["Purpose"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            //    Purpose.Text = purpose;
            //    mr.SetDataSource(dataSet.Tables[0]);
            //    mr.SetDatabaseLogon("sa", "abc123");
            //    crystalReportViewer1.ReportSource = mr;
            //}
        }
    }
}
