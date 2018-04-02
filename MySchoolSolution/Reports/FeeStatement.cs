using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            CrystalDecisions.CrystalReports.Engine.TextObject txtSession = mr.ReportDefinition.ReportObjects["txtSession"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            txtSession.Text = Session;

            CrystalDecisions.CrystalReports.Engine.TextObject txtClass = mr.ReportDefinition.ReportObjects["txtClass"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            txtClass.Text = Class;
            SqlParameter[] m = new SqlParameter[2];

            m[0] = new SqlParameter("@Session", Session);
            m[1] = new SqlParameter("@Class", Class);

            DataSet ds1 = SqlHelper.ExecuteDataset(Connection.Connection_string, "Student_FeeStatementBySessionAndClass", m);
            //mr.SetParameterValue("@Session", Session);
            //mr.SetParameterValue("@Class", Class);
            //// mr.PrintToPrinter();
            //// mr.SetDataSource(ds1);
            //SqlConnection con = Connection.Connection_string;
            mr.SetDataSource(ds1.Tables[0]);
            mr.SetDatabaseLogon("sa", "abc123");
            rvFeeStatement.ReportSource = mr;
        }
    }
}
