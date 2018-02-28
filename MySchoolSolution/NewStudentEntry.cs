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

    public partial class NewStudentEntry : Form
    {

        //  SqlConnection con = new SqlConnection("data source=LAPTOP-66UUD7RS\\SARTHAK;database=SchoolManagement;uid=sa;pwd=abc123;integrated security=true");
        public NewStudentEntry()
        {

            InitializeComponent();



        }


        private void button6_Click(object sender, EventArgs e)
        {

            //---Gender--
            string gender = string.Empty;
            if (RBMale.Checked)
            {
                gender = "M";
            }
            else if (rbFemale.Checked)
            {
                gender = "F";
            }
            //---Category--
            string Category = string.Empty;
            if (rbGeneral.Checked)
            {
                Category = "General";
            }
            else if (rbSC.Checked)
            {
                Category = "SC";
            }
            else if (rbOBC.Checked)
            {
                Category = "OBC";
            }
            else if (rbBC.Checked)
            {
                Category = "BC";
            }
            else if (rbEWS.Checked)
            {
                Category = "EWS";
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
                else if (txtAddress1.Text == "")
                {
                    MessageBox.Show("Please fill  Address ");
                    txtAddress1.Focus();
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

                else if (Category == "")
                {
                    MessageBox.Show("Please select  Category ");
                }
               else if (GetSiblingNumber() == true)
                {
                    MessageBox.Show("Two siblings already added!");
                    txtSibling.Text = string.Empty;
                }
                else
                {
                    SqlParameter[] m = new SqlParameter[57];
                    m[0] = new SqlParameter("@Name", txtName.Text);
                    m[1] = new SqlParameter("@Stud_In_Class", txtStudyingClass.Text);
                    m[2] = new SqlParameter("@Class", ddlClass.Text);
                    m[3] = new SqlParameter("@Session_Year", lblSession.Text);
                    m[4] = new SqlParameter("@RollNumber", txtRollNo.Text);
                    m[5] = new SqlParameter("@Addmission_Number", Convert.ToInt32(txtAdmissionNo.Text));
                    m[6] = new SqlParameter("@Admission_Date", Convert.ToDateTime(TxtAdmissionDate.Text));
                    m[7] = new SqlParameter("@Acc_Number", txtAccNo.Text);
                    m[8] = new SqlParameter("@FatherName", txtFatherName.Text);
                    m[9] = new SqlParameter("@MotherName", txtMotherName.Text);
                    m[10] = new SqlParameter("@Gender", gender);
                    m[11] = new SqlParameter("@Category", Category);
                    m[12] = new SqlParameter("@SiblingClass", txtSibling.Text);
                    m[13] = new SqlParameter("@SiblingSchool", txtSibling.Text);
                    m[14] = new SqlParameter("@Nationality", txtNationality.Text);
                    m[15] = new SqlParameter("@EmailId", txtEmail.Text);
                    m[16] = new SqlParameter("@Address1", txtAddress1.Text);
                    m[17] = new SqlParameter("@Address2", txtAddress2.Text);
                    m[18] = new SqlParameter("@City", txtCity.Text);
                    m[19] = new SqlParameter("@PhoneRes", txtPhone.Text);
                    m[20] = new SqlParameter("@PhoneOff", txtEmergencyPhone.Text);
                    m[21] = new SqlParameter("@AadharCardNo", txtAadharNo.Text);
                    m[22] = new SqlParameter("@SRN_No", txtSRNo.Text);
                    m[23] = new SqlParameter("@CBSC_REG_No", txtCBSCNo.Text);
                    m[24] = new SqlParameter("@BankAccount_No", txtBankAccountNo.Text);
                    m[25] = new SqlParameter("@IFSC", txtIFSC.Text);
                    m[26] = new SqlParameter("@DiscountType", txtDiscountType.Text);
                    m[27] = new SqlParameter("@BloodGroup", txtBloodGroup.Text);
                    m[28] = new SqlParameter("@BoarderRequired", txtBoarder.Text);
                    m[29] = new SqlParameter("@Route_No", txtRouteNo.Text);
                    m[30] = new SqlParameter("@ORG_Adm_no", txtOrgAdmNo.Text);
                    m[31] = new SqlParameter("@MobileSms", MobileForSMS.Text);
                    m[32] = new SqlParameter("@Stopage", txtStoppage.Text);
                    m[33] = new SqlParameter("@Income", txtIncome.Text);
                    m[34] = new SqlParameter("@DND", txtDND.Text);
                    m[35] = new SqlParameter("@BPL", txtBPL.Text);
                    m[36] = new SqlParameter("@DisabilityType", txtDisabilityType.Text);
                    m[37] = new SqlParameter("@CWSN", txtFascilty.Text);
                    m[38] = new SqlParameter("@HomeLessChild", txtHomeLess.Text);
                    m[39] = new SqlParameter("@Extra_Exam", txtExtraExam.Text);
                    m[40] = new SqlParameter("@Last_Exam_Appear", txtLastExamAppear.Text);
                    m[41] = new SqlParameter("@Last_Exam_Passed", txtLastExamPassed.Text);
                    m[42] = new SqlParameter("@Last_Exam_Percent", txtLastPercentage.Text);
                    m[43] = new SqlParameter("@Stream_11", txtStream11.Text);
                    m[44] = new SqlParameter("@Free_Edu", txtFreeEducation.Text);
                    m[45] = new SqlParameter("@Trade_Skill", txtTradeSkill.Text);
                    m[46] = new SqlParameter("@DisAdvantages", txtDisadvantage.Text);
                    m[47] = new SqlParameter("@MotherToung", txtMothertongue.Text);
                    m[48] = new SqlParameter("@Medium_of_Instruction", txtMediumFoInfra.Text);
                    m[49] = new SqlParameter("@Previous_year_Att", txtPreviousYearAttendance.Text);
                    m[50] = new SqlParameter("@Previous_Year_Status", txtLastYearStatus.Text);
                    m[51] = new SqlParameter("@Other_Info", txtOtherInformation.Text);
                    m[52] = new SqlParameter("@DOB", Convert.ToDateTime(txtDOB.Text));
                    m[53] = new SqlParameter("@StdId", SqlDbType.Int);
                    m[54] = new SqlParameter("@UDF1", SqlDbType.Text);
                    m[55] = new SqlParameter("@UDF2", SqlDbType.Text);
                    m[56] = new SqlParameter("@UDF3", SqlDbType.Text);
                    m[53].Direction = ParameterDirection.Output;
                    SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "StudentInfo_Insert", m);
                    object o = m[53].Value;
                    int admissionNo = Convert.ToInt32(o);
                    MessageBox.Show("Admission Successfull");
                    YearlyFeeEntry su = new YearlyFeeEntry();
                    su.admissionNo = admissionNo;
                    su.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewStudentEntry_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
            TxtAdmissionDate.Text = DateTime.Now.ToString();
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", lblSession.Text);

            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(Connection.Connection_string, CommandType.StoredProcedure, "GetRegistrationNumber", m);
            if (ds.Tables[0].Rows[0]["RegNo"] != null && Convert.ToString(ds.Tables[0].Rows[0]["RegNo"]) != string.Empty)
            {
                txtAdmissionNo.Text = ds.Tables[0].Rows[0]["RegNo"].ToString();
            }
            else
            {
                txtAdmissionNo.Text = "1";
            }

            ddlClass.DataSource = CommonFunctions.GetClasses;
            //ddlClass.DisplayMember = "Classes";
            //ddlClass.ValueMember = "Classes";

        }
        private void GetRollNoByClass()
        {
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@Session", lblSession.Text);
            m[1] = new SqlParameter("@Class", ddlClass.Text);
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(Connection.Connection_string, CommandType.StoredProcedure, "GetRollNumberByClass", m);
            if (ds.Tables[0].Rows[0]["RollNo"] != null && Convert.ToString(ds.Tables[0].Rows[0]["RollNo"]) != string.Empty)
            {
                txtRollNo.Text = ds.Tables[0].Rows[0]["RollNo"].ToString();
            }
            else
            {
                txtRollNo.Text = "1";
            }

        }
        private bool GetSiblingNumber()
        {
            bool b = false;
            if (txtSibling.Text != "" && txtSibling.Text != "0")
            {
                SqlParameter[] m = new SqlParameter[2];
                m[0] = new SqlParameter("@Session", lblSession.Text);
                m[1] = new SqlParameter("@Sibling", txtSibling.Text);
                DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "GetSiblingNumberBySession", m);
                if (ds.Tables[0].Rows.Count >= 2)
                    b = true;
                else
                    b = false;
            }
            return b;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            txtDOB.Text = dt.ToString("dd-MMM-yy");
        }

        private void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRollNoByClass();
        }
    }
}
