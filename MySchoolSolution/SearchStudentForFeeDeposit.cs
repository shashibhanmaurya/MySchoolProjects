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
    public partial class SearchStudentForFeeDeposit : Form
    {
        public SearchStudentForFeeDeposit()
        {
            InitializeComponent();
        }

        private void SearchStudentForFeeDeposit_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
            comboClass.DataSource = CommonFunctions.GetClasses;

        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlParameter[] m = new SqlParameter[3];
            m[0] = new SqlParameter("@SearchPhrase", txtStudentName.Text);
            m[1] = new SqlParameter("@Class", comboClass.Text);
            m[2] = new SqlParameter("@Session", lblSession.Text);

            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SearchForFeeDeposit", m);
            gvStudents.DataSource = ds.Tables[0];

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

            SqlParameter[] m = new SqlParameter[3];
            m[0] = new SqlParameter("@SearchPhrase", txtStudentName.Text);
            m[1] = new SqlParameter("@Class", comboClass.Text);
            m[2] = new SqlParameter("@Session", lblSession.Text);



            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SearchForFeeDeposit", m);
            gvStudents.DataSource = ds.Tables[0];


        }

        private void gvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int admissionNo = Convert.ToInt32(gvStudents.Rows[e.RowIndex].Cells["Addmission_Number"].Value);
                FeeDeposit fd = new FeeDeposit();
                fd.AdmissionNo = admissionNo;
                fd.Show();
                this.Close();
            }
        }
    }
}
