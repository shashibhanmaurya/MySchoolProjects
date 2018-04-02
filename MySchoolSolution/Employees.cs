using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            BindGridEmployee();
            lblSession.Text = CommonFunctions.GetCurrentSession;
        }
        private void BindGridEmployee()
        {
            SqlParameter[] m = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "EmployeeInfo_SelectAll", m);
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvEmployees.DataSource = ds.Tables[0];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select Name,FatherName,MotherName,DOB,Age,MaritalStatus,Gender,Email,PhoneNumber,Address1,City,JobTitle,Qualification,ExperienceInYear, Salary, HireDate, Nationality, AadharCardNo from tbl_EmployeeInfo  WHERE Name LIKE '%' + @Name + '%'");
            cmd.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvEmployees.DataSource = dt;
            gvEmployees.ReadOnly = true;
        }

        private void gvEmployees_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Empid = Convert.ToInt32(gvEmployees.Rows[e.RowIndex].Cells["EmpId"].Value);
                EmployeeEntry st = new EmployeeEntry();
                st.EmployeeId = Empid;
                st.Operation = "Update";
                st.Show();
                this.Close();
            }
        }
    }
}
