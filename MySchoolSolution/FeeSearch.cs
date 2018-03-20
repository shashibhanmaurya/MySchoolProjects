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
        public string SearchFor { get; set; }
        DataSet ds = new DataSet();
        public FeeSearch()
        {
            InitializeComponent();


            lblSession.Text = CommonFunctions.GetCurrentSession;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@DateFrom", Convert.ToDateTime(dtFrom.Text));
            m[1] = new SqlParameter("@DateTo", Convert.ToDateTime(dtTo.Text));

            ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeBetweenTwoDates", m);
            gvSearchResult.DataSource = ds.Tables[0];
        }

        private void FeeSearch_Load(object sender, EventArgs e)
        {
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectSession");
            if (groupSelectAll.Visible == true)
            {
                ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectAllMonthlyFee");
                gvSearchResult.DataSource = ds.Tables[0];
            }

            else if (SearchFor == "SessionAndClass")
            {
                comboSession.DataSource = ds.Tables[0];

                comboSession.DisplayMember = "Session_Year";
                comboSession.ValueMember = "Session_Year";
                comboClass.DataSource = CommonFunctions.GetClasses;
            }
            else if (SearchFor == "ForSession")
            {
                comboSession1.DisplayMember = "Session_Year";
                comboSession1.ValueMember = "Session_Year";
                comboSession1.DataSource = ds.Tables[0];
            }
            else if (SearchFor == "Statement")
            {
                comboClassForStatement.DataSource = CommonFunctions.GetClasses;
            }

            else if (SearchFor == "StudentWiseSearch")
            {
                GetStudentAutoComplete();
            }
        }
        private void GetStudentAutoComplete()
        {
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", lblSession.Text);
            SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "StudentInfoAutoComplete", m);
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                MyCollection.Add(dr.GetString(0));
            }
            txtStudent.AutoCompleteCustomSource = MyCollection;


        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@Session", comboSession.Text);
            m[1] = new SqlParameter("@Class", comboClass.Text);

            ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeByClassAndSession", m);
            gvSearchResult.DataSource = ds.Tables[0];
        }

        private void comboSession1_SelectedIndexChanged(object sender, EventArgs e)
        {

            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", comboSession1.Text);


            ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeBySession", m);

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
            SqlParameter[] m = new SqlParameter[1];

            m[0] = new SqlParameter("@Date", Convert.ToDateTime(DateTime.Now).ToShortDateString());

            ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "DailyFeeCollection", m);
            Reports.FeeReportView fv = new Reports.FeeReportView();
            fv.dataSet = ds;
            fv.purpose = "Fee Collection for " + Convert.ToDateTime(DateTime.Now).ToShortDateString() + "";
            fv.Show();
            this.Hide();
        }

        private void PrintOverAll_Click(object sender, EventArgs e)
        {
            Reports.FeeReportView fv = new Reports.FeeReportView();
            fv.dataSet = ds;
            fv.purpose = "Overall fee collection";
            fv.Show();
            this.Hide();
        }

        private void PrintbySession_Click(object sender, EventArgs e)
        {
            Reports.FeeReportView fv = new Reports.FeeReportView();
            fv.dataSet = ds;
            fv.purpose = "Fee Collection for Session: " + comboSession1.Text + "";
            fv.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports.FeeReportView fv = new Reports.FeeReportView();
            fv.dataSet = ds;
            fv.purpose = "Fee Collection for Class: " + comboClass.Text + " and session " + comboSession.Text + "";
            fv.Show();
            this.Hide();
        }

        private void comboSession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports.FeeReportView fv = new Reports.FeeReportView();
            fv.dataSet = ds;
            fv.purpose = "Fee Collection for between: " + dtFrom.Text + " and  " + dtTo.Text + "";
            fv.Show();
            this.Hide();
        }

        private void btnStudentwiseSearch_Click(object sender, EventArgs e)
        {
            int admissionNo = 0;

            string[] chk = txtStudent.Text.Split('_');
            if (chk.Count() > 0)
            {
                admissionNo = Convert.ToInt32(chk.ElementAt(1));
                gvSearchResult.DataSource = null;
                SqlParameter[] m = new SqlParameter[2];
                m[0] = new SqlParameter("@AdmissionNo", admissionNo);
                m[1] = new SqlParameter("@Session", lblSession.Text);

                ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeByAdmissionNoAndSession", m);
                gvSearchResult.DataSource = ds.Tables[0];

            }

        }

        private void StudentwiseFeePrint_Click(object sender, EventArgs e)
        {
             string Name = string.Empty;
            string cls = string.Empty;

            string[] chk = txtStudent.Text.Split('_');
            if (chk.Count() > 0)
            {
                Name = chk.ElementAt(0);
                cls = chk.ElementAt(3);
                Reports.FeeReportView fv = new Reports.FeeReportView();
                fv.dataSet = ds;
                fv.purpose = "Fee Collection for: " + Name + " of class  " + cls + "";
                fv.Show();
                this.Hide();
            }
        }
    }
}
