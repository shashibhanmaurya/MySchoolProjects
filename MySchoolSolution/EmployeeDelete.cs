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
    public partial class EmployeeDelete : Form
    {
        public EmployeeDelete()
        {
            InitializeComponent();
        }

        private void EmployeeDelete_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
            BindGridEmployee();
        }
        private void BindGridEmployee()
        {
            SqlParameter[] m = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "EmployeeInfo_SelectAll", m);
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvEmployee.DataSource = ds.Tables[0];
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataGridViewRow> selectedRows = (from row in gvEmployee.Rows.Cast<DataGridViewRow>()
                                                      where Convert.ToBoolean(row.Cells["Select"].Value) == true
                                                      select row).ToList();
                if (MessageBox.Show(string.Format("Do you want to delete {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        SqlParameter[] m = new SqlParameter[2];
                        m[0] = new SqlParameter("@EmpId", row.Cells["EmpId"].Value);
                        m[1] = new SqlParameter("@Session", lblSession.Text);
                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "EmployeeInfo_Delete", m);
                    }

                    this.BindGridEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
