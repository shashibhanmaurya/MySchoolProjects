using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution
{
    public partial class FeeSearch : Form
    {
        public FeeSearch()
        {
            InitializeComponent();
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectSession");
            comboSession.DataSource = ds.Tables[0];
            comboSession1.DataSource = ds.Tables[0];
            comboSession.DisplayMember = "Session_Year";
            comboSession.ValueMember = "Session_Year";
            comboSession1.DisplayMember = "Session_Year";
            comboSession1.ValueMember = "Session_Year";
            comboClass.DataSource = CommonFunctions.GetClasses;
            comboClassForStatement.DataSource = CommonFunctions.GetClasses;
            lblSession.Text = CommonFunctions.GetCurrentSession;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@DateFrom", Convert.ToDateTime(dtFrom.Text));
            m[1] = new SqlParameter("@DateTo", Convert.ToDateTime(dtTo.Text));

            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeBetweenTwoDates", m);
            gvSearchResult.DataSource = ds.Tables[0];
        }

        private void FeeSearch_Load(object sender, EventArgs e)
        {

            if (groupSelectAll.Visible == true)
            {
                DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectAllMonthlyFee");
                gvSearchResult.DataSource = ds.Tables[0];
            }
        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@Session", comboSession.Text);
            m[1] = new SqlParameter("@Class", comboClass.Text);

            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeByClassAndSession", m);
            gvSearchResult.DataSource = ds.Tables[0];
        }

        private void comboSession1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", comboSession1.Text);


            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeBySession", m);
            gvSearchResult.DataSource = ds.Tables[0];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.FeeStatement fs = new Reports.FeeStatement();
            fs.Class = comboClassForStatement.Text;

            fs.Session = lblSession.Text;
            fs.Show();
        }

        private void comboClassForStatement_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@Session", lblSession.Text);
            m[1] = new SqlParameter("@Class", comboClassForStatement.Text);


            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "Student_FeeStatementBySessionAndClass", m);
            gvSearchResult.DataSource = ds.Tables[0];
        }

        private void btnDailyCollectionPrint_Click(object sender, EventArgs e)
        {
            Reports.FeeReportView fv = new Reports.FeeReportView();
            fv.Show();
        }
    }
}
