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
    public partial class FeeStatementWithAmountDue : Form
    {
        public string Session { get; set; }
        public string Class { get; set; }
        public string TillMonthValue { get; set; }
        public DataTable dsReport { get; set; }
        public FeeStatementWithAmountDue()
        {
            InitializeComponent();
        }

        private void FeeStatementWithAmountDue_Load(object sender, EventArgs e)
        {
            Reports.ReportSudentFeeStatementByClassAndSessionWithBalance mr = new Reports.ReportSudentFeeStatementByClassAndSessionWithBalance();
            CrystalDecisions.CrystalReports.Engine.TextObject txtSession = mr.ReportDefinition.ReportObjects["txtSession"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            txtSession.Text = Session;

            CrystalDecisions.CrystalReports.Engine.TextObject txtClass = mr.ReportDefinition.ReportObjects["txtClass"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            txtClass.Text = Class;
            CrystalDecisions.CrystalReports.Engine.TextObject TillMonth = mr.ReportDefinition.ReportObjects["TillMonth"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            TillMonth.Text = TillMonthValue;



            mr.SetDataSource(dsReport);
            mr.SetDatabaseLogon("sa", "abc123");
            rvFeeStatement.ReportSource = mr;
        }
    }
}
