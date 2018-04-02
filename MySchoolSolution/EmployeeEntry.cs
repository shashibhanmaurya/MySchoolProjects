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
    public partial class EmployeeEntry : Form
    {
        public int EmployeeId { get; set; }
        public string Operation { get; set; }
        public EmployeeEntry()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            txtDOB.Text = dt.ToString("dd-MMM-yy");
        }

        private void EmployeeInfo_Insert_Click(object sender, EventArgs e)
        {

            string gender = string.Empty;
            if (RBMale.Checked)
            {
                gender = "M";
            }
            else if (rbFemale.Checked)
            {
                gender = "F";
            }
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Name  can not be blank");
                    txtName.Focus();
                }

                else if (txtFatherName.Text == "")
                {
                    MessageBox.Show("Please fill Father name ");
                    txtFatherName.Focus();
                }

                else if (txtMotherName.Text == "")
                {
                    MessageBox.Show("Please fill Mother name ");
                    txtMotherName.Focus();
                }
                else if (txtDOB.Text == "")
                {
                    MessageBox.Show("Please Select Date of Birth");
                    txtDOB.Focus();
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please fill  Address ");
                    txtAddress.Focus();
                }
                else if (txtCity.Text == "")
                {
                    MessageBox.Show("Please fill City  ");
                    txtCity.Focus();
                }
                else if (txtAadharNo.Text == "")
                {
                    MessageBox.Show("Please fill your Adhar Card number ");
                    txtAadharNo.Focus();
                }
                else if (txtNationality.Text == "")
                {
                    MessageBox.Show("Please select your Nationality ");
                    txtNationality.Focus();
                }
                else if (gender == "")
                {
                    MessageBox.Show(" Please select Gender ");
                }

                else
                {
                    SqlParameter[] m = new SqlParameter[23];
                    m[0] = new SqlParameter("@Name", txtName.Text);
                    m[1] = new SqlParameter("@FatherName", txtFatherName.Text);
                    m[2] = new SqlParameter("@MotherName", txtMotherName.Text);
                    m[3] = new SqlParameter("@Gender", gender);
                    m[4] = new SqlParameter("@Age", txtage.Text);
                    m[5] = new SqlParameter("@Qualification", txtqualification.Text);
                    m[6] = new SqlParameter("@Nationality", txtNationality.Text);
                    m[7] = new SqlParameter("@EMail", txtEmail.Text);
                    m[8] = new SqlParameter("@Address1", txtAddress.Text);
                    m[9] = new SqlParameter("@JobTitle", txtDesignation.Text);
                    m[10] = new SqlParameter("@City", txtCity.Text);
                    m[11] = new SqlParameter("@PhoneNumber", txtphoneno.Text);
                    m[12] = new SqlParameter("@AadharCardNo", txtAadharNo.Text);
                    m[13] = new SqlParameter("@DOB", Convert.ToDateTime(txtDOB.Text));
                    m[14] = new SqlParameter("@ExperienceInYear", ddlExperience.Text);
                    m[15] = new SqlParameter("@Salary", txtSalary.Text);
                    m[16] = new SqlParameter("@JoiningDate", Convert.ToDateTime(txtDOB.Text));
                    m[17] = new SqlParameter("@EmpId", SqlDbType.Int);
                    m[18] = new SqlParameter("@UDF1", SqlDbType.Text);
                    m[19] = new SqlParameter("@UDF2", SqlDbType.Text);
                    m[20] = new SqlParameter("@UDF3", SqlDbType.Text);
                    m[21] = new SqlParameter("@MaritalStatus", ddlMaritalStatus.Text);
                    m[22] = new SqlParameter("@Session", lblSession.Text);

                    if (Operation == "Update")
                    {
                        m[17] = new SqlParameter("@EmpId", Convert.ToInt32(lblEmpId.Text));
                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "EmployeeInfo_Update", m);                    
                        MessageBox.Show("Information update Successfull");
                        Employees emp = new Employees();
                        emp.Show();
                    }
                    else
                    {
                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "EmployeeInfo_Insert", m);
                        CommonFunctions.ShowMessage("Employee Details Submitted");
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GetEmployeeDetailstoUpdate()
        {

            try
            {
                if (lblEmpId.Text != string.Empty)
                {
                    SqlParameter[] m = new SqlParameter[2];

                    m[0] = new SqlParameter("@EmpId", Convert.ToInt32(lblEmpId.Text.Trim()));
                    m[1] = new SqlParameter("@Session", lblSession.Text);
                    SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "EmployeeInfo_SelectAllBySession", m);
                    while (dr.Read())
                    {
                        txtName.Text = dr["Name"].ToString();
                        txtFatherName.Text = dr["FatherName"].ToString();
                        txtMotherName.Text = dr["MotherName"].ToString();
                        txtDOB.Text = dr["DOB"].ToString();
                        txtage.Text = dr["Age"].ToString();
                        ddlMaritalStatus.Text = dr["MaritalStatus"].ToString();
                        if (dr["Gender"].ToString() == "M")
                        {
                            RBMale.Checked = true;
                        }
                        else if (dr["Gender"].ToString() == "F")
                        {
                            rbFemale.Checked = true;
                        }
                        txtEmail.Text = dr["Email"].ToString();
                        txtphoneno.Text = dr["PhoneNumber"].ToString();
                        txtAddress.Text = dr["Address1"].ToString();
                        txtCity.Text = dr["City"].ToString();
                        txtDesignation.Text = dr["JobTitle"].ToString();
                        txtqualification.Text = dr["Qualification"].ToString();
                        ddlExperience.Text = dr["ExperienceInYear"].ToString();
                        txtSalary.Text = dr["Salary"].ToString();
                        txtJoiningDate.Text = dr["HireDate"].ToString();
                        txtNationality.Text = dr["Nationality"].ToString();
                        txtAadharNo.Text = dr["AadharCardNo"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                // txtName.Text = string.Empty;

                MessageBox.Show(ex.Message);
            }


        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker2.Value;
            txtJoiningDate.Text = dt.ToString("dd-MMM-yy");
        }

        private void EmployeeEntry_Load(object sender, EventArgs e)
        {
            if (Operation == "Update")
            {
                lblEmpId.Visible = false;
                if (EmployeeId > 0)
                {
                    lblEmpId.Text = EmployeeId.ToString();
                }
            }
            lblSession.Text = CommonFunctions.GetCurrentSession;
            GetEmployeeDetailstoUpdate();
        }
    }
}
