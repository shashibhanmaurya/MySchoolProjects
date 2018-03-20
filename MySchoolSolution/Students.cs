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
        public int stdId;
        public Students()
        {
            InitializeComponent();

            bindgrid();
        }
        private void bindgrid()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "StudentInfo_SelectAll";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 15;
            dataGridView1.Columns[0].Name = "RollNumber";
            dataGridView1.Columns[0].HeaderText = "RollNumber";
            dataGridView1.Columns[0].DataPropertyName = "RollNumber";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[1].DataPropertyName = "Name";
            dataGridView1.Columns[2].Name = "FatherName";
            dataGridView1.Columns[2].HeaderText = "FatherName";
            dataGridView1.Columns[2].DataPropertyName = "FatherName";
            dataGridView1.Columns[3].Name = "Stud_In_Class";
            dataGridView1.Columns[3].HeaderText = "Stud_In_Class";
            dataGridView1.Columns[3].DataPropertyName = "Stud_In_Class";
            dataGridView1.Columns[4].Name = "DOB";
            dataGridView1.Columns[4].HeaderText = "DOB";
            dataGridView1.Columns[4].DataPropertyName = "DOB";
            dataGridView1.Columns[5].Name = "Gender";
            dataGridView1.Columns[5].HeaderText = "Gender";
            dataGridView1.Columns[5].DataPropertyName = "Gender";
            dataGridView1.Columns[6].Name = "Category";
            dataGridView1.Columns[6].HeaderText = "Category";
            dataGridView1.Columns[6].DataPropertyName = "Category";
            dataGridView1.Columns[7].Name = "Admission_Date";
            dataGridView1.Columns[7].HeaderText = "Admission_Date";
            dataGridView1.Columns[7].DataPropertyName = "Admission_Date";
            dataGridView1.Columns[8].Name = "Address1";
            dataGridView1.Columns[8].HeaderText = "Address1";
            dataGridView1.Columns[8].DataPropertyName = "Address1";
            dataGridView1.Columns[9].Name = "Address2";
            dataGridView1.Columns[9].HeaderText = "Address2";
            dataGridView1.Columns[9].DataPropertyName = "Address2";
            dataGridView1.Columns[10].Name = "PhoneRes";
            dataGridView1.Columns[10].HeaderText = "PhoneRes";
            dataGridView1.Columns[10].DataPropertyName = "PhoneRes";
            dataGridView1.Columns[11].Name = "Route_No";
            dataGridView1.Columns[11].HeaderText = "Bus Route_No";
            dataGridView1.Columns[11].DataPropertyName = "Route_No";
            dataGridView1.Columns[12].Name = "Stopage";
            dataGridView1.Columns[12].HeaderText = "Stopage";
            dataGridView1.Columns[12].DataPropertyName = "Stopage";
            dataGridView1.Columns[13].Name = "AadharCardNo";
            dataGridView1.Columns[13].HeaderText = "AadharCardNo";
            dataGridView1.Columns[13].DataPropertyName = "AadharCardNo";
            dataGridView1.Columns[14].Name = "Addmission_Number";
            dataGridView1.Columns[14].HeaderText = "Addmission_Number";
            dataGridView1.Columns[14].DataPropertyName = "Addmission_Number";
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Green;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
            this.dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Green;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select Addmission_Number,RollNumber, Name,FatherName,Stud_In_Class,DOB,Gender,Category,Admission_Date,Address1,Address2,PhoneRes, Route_No,Stopage,AadharCardNo from tbl_StudentInfo  WHERE Name LIKE '%' + @Name + '%'");
            cmd.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;


        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int admissionNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Addmission_Number"].Value);
                NewStudentEntry st = new NewStudentEntry();
                st.AdmissionNo = admissionNo;
                st.Operation = "Update";
                st.Show();
                this.Close();
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;

            
        }
    }
}
