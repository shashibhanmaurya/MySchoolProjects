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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvSearchResult.DataSource = null;
           SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@DateFrom",Convert.ToDateTime( dtFrom.Text));
            m[1] = new SqlParameter("@DateTo", Convert.ToDateTime(dtTo.Text));         

            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SearchBetweenTwoDates", m);
            gvSearchResult.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text!=string.Empty)
            {
                gvSearchResult.DataSource = null;
                SqlParameter[] m = new SqlParameter[1];
                m[0] = new SqlParameter("@Name", txtName.Text);
              
                DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SearchByName", m);
                gvSearchResult.DataSource = ds.Tables[0];
            }
        }

        private void tctFatherName_TextChanged(object sender, EventArgs e)
        {
            if (tctFatherName.Text != string.Empty)
            {
                gvSearchResult.DataSource = null;
                SqlParameter[] m = new SqlParameter[1];
                m[0] = new SqlParameter("@FatherName", tctFatherName.Text);

                DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SearchByFatherName", m);
                gvSearchResult.DataSource = ds.Tables[0];
            }
        }

        private void txtRollNo_TextChanged(object sender, EventArgs e)
        {
            if (txtRollNo.Text != string.Empty)
            {
                gvSearchResult.DataSource = null;
                SqlParameter[] m = new SqlParameter[1];
                m[0] = new SqlParameter("@RollNo", txtRollNo.Text);

                DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SearchByRollNo", m);
                gvSearchResult.DataSource = ds.Tables[0];
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void txtAdmissionNo_TextChanged(object sender, EventArgs e)
        {
            if (txtRollNo.Text != string.Empty)
            {
                gvSearchResult.DataSource = null;
                SqlParameter[] m = new SqlParameter[1];
                m[0] = new SqlParameter("@AdmissionNo", txtAdmissionNo.Text);

                DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SearchByAdmissionNo", m);
                gvSearchResult.DataSource = ds.Tables[0];
            }
        }
    }
}
