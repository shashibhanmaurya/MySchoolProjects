using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MySchoolSolution
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
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
        //private void bindgrid()
        //{

        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "StudentInfo_SelectAll";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    gvStudents.AutoGenerateColumns = false;
        //    gvStudents.ColumnCount = 16;
        //    gvStudents.Columns[0].Name = "RollNumber";
        //    gvStudents.Columns[0].HeaderText = "RollNumber";
        //    gvStudents.Columns[0].DataPropertyName = "RollNumber";
        //    gvStudents.Columns[1].Name = "Name";
        //    gvStudents.Columns[1].HeaderText = "Name";
        //    gvStudents.Columns[1].DataPropertyName = "Name";
        //    gvStudents.Columns[2].Name = "FatherName";
        //    gvStudents.Columns[2].HeaderText = "FatherName";
        //    gvStudents.Columns[2].DataPropertyName = "FatherName";
        //    gvStudents.Columns[3].Name = "Class";
        //    gvStudents.Columns[3].HeaderText = "Class";
        //    gvStudents.Columns[3].DataPropertyName = "Class";
        //    gvStudents.Columns[4].Name = "DOB";
        //    gvStudents.Columns[4].HeaderText = "DOB";
        //    gvStudents.Columns[4].DataPropertyName = "DOB";
        //    gvStudents.Columns[5].Name = "Gender";
        //    gvStudents.Columns[5].HeaderText = "Gender";
        //    gvStudents.Columns[5].DataPropertyName = "Gender";
        //    gvStudents.Columns[6].Name = "Category";
        //    gvStudents.Columns[6].HeaderText = "Category";
        //    gvStudents.Columns[6].DataPropertyName = "Category";
        //    gvStudents.Columns[7].Name = "Admission_Date";
        //    gvStudents.Columns[7].HeaderText = "Admission_Date";
        //    gvStudents.Columns[7].DataPropertyName = "Admission_Date";
        //    gvStudents.Columns[8].Name = "Address1";
        //    gvStudents.Columns[8].HeaderText = "Address1";
        //    gvStudents.Columns[8].DataPropertyName = "Address1";
        //    gvStudents.Columns[9].Name = "Address2";
        //    gvStudents.Columns[9].HeaderText = "Address2";
        //    gvStudents.Columns[9].DataPropertyName = "Address2";
        //    gvStudents.Columns[10].Name = "PhoneRes";
        //    gvStudents.Columns[10].HeaderText = "PhoneRes";
        //    gvStudents.Columns[10].DataPropertyName = "PhoneRes";
        //    gvStudents.Columns[11].Name = "Route_No";
        //    gvStudents.Columns[11].HeaderText = "Bus Route_No";
        //    gvStudents.Columns[11].DataPropertyName = "Route_No";
        //    gvStudents.Columns[12].Name = "Stopage";
        //    gvStudents.Columns[12].HeaderText = "Stopage";
        //    gvStudents.Columns[12].DataPropertyName = "Stopage";
        //    gvStudents.Columns[13].Name = "AadharCardNo";
        //    gvStudents.Columns[13].HeaderText = "AadharCardNo";
        //    gvStudents.Columns[13].DataPropertyName = "AadharCardNo";
        //    gvStudents.Columns[14].Name = "Addmission_Number";
        //    gvStudents.Columns[14].HeaderText = "Addmission_Number";
        //    gvStudents.Columns[14].DataPropertyName = "Addmission_Number";
        //    gvStudents.Columns[15].Name = "Section";
        //    gvStudents.Columns[15].HeaderText = "Section";
        //    gvStudents.Columns[15].DataPropertyName = "Section";
        //    gvStudents.DataSource = dt;
        //    gvStudents.ReadOnly = true;
        //    this.gvStudents.DefaultCellStyle.BackColor = Color.Green;
        //    this.gvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
        //    this.gvStudents.RowHeadersDefaultCellStyle.BackColor = Color.Green;
        //    this.gvStudents.DefaultCellStyle.Font = new Font("Times New Roman", 12);

        //}

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select Addmission_Number,RollNumber, Name,FatherName,Stud_In_Class,DOB,Gender,Category,Admission_Date,Address1,Address2,PhoneRes, Route_No,Stopage,AadharCardNo from tbl_StudentInfo  WHERE Name LIKE '%' + @Name + '%'");
            cmd.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudent.DataSource = dt;
            gvStudent.ReadOnly = true;


        }
        private void Students_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
            BindGridStudent();
        }

        private void gvStudent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int admissionNo = Convert.ToInt32(gvStudent.Rows[e.RowIndex].Cells["Addmission_Number"].Value);
                NewStudentEntry st = new NewStudentEntry();
                st.AdmissionNo = admissionNo;
                st.Operation = "Update";
                st.Show();
                this.Close();
            }
        }
    }
}
