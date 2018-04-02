using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace MySchoolSolution
{
    public partial class StudentDelete : Form
    {
        public StudentDelete()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindGridStudent()
        {
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", lblSession.Text);
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SelectAllBySession", m);
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvStudent.DataSource = ds.Tables[0];
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataGridViewRow> selectedRows = (from row in gvStudent.Rows.Cast<DataGridViewRow>()
                                                      where Convert.ToBoolean(row.Cells["Select"].Value) == true
                                                      select row).ToList();
                if (MessageBox.Show(string.Format("Do you want to delete {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        SqlParameter[] m = new SqlParameter[2];
                        m[0] = new SqlParameter("@StdId", row.Cells["StdId"].Value);                     
                        m[1] = new SqlParameter("@Session", lblSession.Text);
                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "StudentInfo_Delete", m);                    
                    }

                    this.BindGridStudent();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentDelete_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
            BindGridStudent();
        }
    }
}
