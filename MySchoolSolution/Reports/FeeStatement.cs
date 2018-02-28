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
        public FeeStatement()
        {
            InitializeComponent();
        }

        private void FeeStatement_Load(object sender, EventArgs e)
        {
            Reports.ReportSudentFeeStatementByClassAndSession mr = new Reports.ReportSudentFeeStatementByClassAndSession();
            mr.SetParameterValue("@Session","2017-2018");
            mr.SetParameterValue("@Class", "Lkg");
           // mr.PrintToPrinter();
            // mr.SetDataSource(ds1);
            mr.SetDatabaseLogon("sa", "abc123");
            rvFeeStatement.ReportSource = mr;
        }
    }
}
