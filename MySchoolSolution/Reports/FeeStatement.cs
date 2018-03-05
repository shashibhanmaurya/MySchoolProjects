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
    public partial class FeeStatement : Form
    {
        public string Session { get; set; }
        public string Class { get; set; }
        public FeeStatement()
        {
            InitializeComponent();
        }

        private void FeeStatement_Load(object sender, EventArgs e)
        {
            Reports.ReportSudentFeeStatementByClassAndSession mr = new Reports.ReportSudentFeeStatementByClassAndSession();
            mr.SetParameterValue("@Session",Session);
            mr.SetParameterValue("@Class", Class);
           // mr.PrintToPrinter();
            // mr.SetDataSource(ds1);
            mr.SetDatabaseLogon("sa", "abc123");
            rvFeeStatement.ReportSource = mr;
        }
    }
}
