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
            comboSession.DataSource = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectSession");
            comboSession.DisplayMember = "Session_Year";
            comboSession.ValueMember = "Session_Year";
            comboClass.DataSource = CommonFunctions.GetClasses;
        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@Session", Convert.ToDateTime(comboSession.Text));
            m[1] = new SqlParameter("@Class", Convert.ToDateTime(comboClass.Text));

            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeByClassAndSession", m);
            gvSearchResult.DataSource = ds.Tables[0];
        }

        private void comboSession1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", Convert.ToDateTime(comboSession1.Text));
           

            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeBySession", m);
            gvSearchResult.DataSource = ds.Tables[0];
        }
    }
}
