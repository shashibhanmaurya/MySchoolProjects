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
using System.IO;

namespace MySchoolSolution
{

    public partial class NewStudentEntry : Form
    {
        public string Operation { get; set; }
        public int AdmissionNo { get; set; }
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
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please Enter Phone Number! ");
                    txtPhone.Focus();
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
                else if (GetSiblingNumber() == true && Operation != "Update")
                {
                    MessageBox.Show("Two siblings already added!");
                    txtSibling.Text = string.Empty;
                }
                else
                {
                    SqlParameter[] m = new SqlParameter[60];
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
                    m[57] = new SqlParameter("@UserName", lblUname.Text);

                    //qrcode
                    MemoryStream ms = new MemoryStream();
                    picQR.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    byte[] qrCode = ms.GetBuffer();
                    //  ms.Read(qrCode, 0, Convert.ToInt32(ms.Length));

                    m[58] = new SqlParameter("@QRCode", qrCode);
                    m[59] = new SqlParameter("@Section", ddlSection.Text);


                    m[53].Direction = ParameterDirection.Output;

                    if (Operation == "Update")
                    {
                        m[5] = new SqlParameter("@Addmission_Number", Convert.ToInt32(txtAdmissionNo.Text));
                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "StudentInfo_Update", m);
                        object o = m[5].Value;                      
                        int admissionNo = Convert.ToInt32(txtAdmissionNo.Text);
                       // lblReceiptNo.Text = txtAdmissionNo.Text;
                        MessageBox.Show("Information update Successfull");
                        Students st = new Students();
                        st.Show();
                    }
                    else
                    {
                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "StudentInfo_Insert", m);                     
                        MessageBox.Show("Admission Successfull");
                        //object os = m[0].Value;
                        //int receiptNo = (int)os;
                        //if (receiptNo > 0)
                        //    lblReceiptNo.Text = receiptNo.ToString();
                        YearlyFeeEntry su = new YearlyFeeEntry();
                        su.admissionNo = Convert.ToInt32(txtAdmissionNo.Text);
                        su.Show();
                        CommonFunctions.SendSMS(txtPhone.Text, "Dear " + txtName.Text + " Welcome to Aarsha Public School! Your AdmissionNo is " + txtAdmissionNo.Text + ", RollNo is " + txtRollNo.Text + " Class is " + ddlClass.Text + " " + ddlSection.Text + ".");
                        try
                        {
                            CommonFunctions.SendEmail(txtEmail.Text, "Welcome to Aarsha Public School", "Dear " + txtName.Text + "<br/><br/> Welcome to Aarsha Public School!<br/> Your AdmissionNo is " + txtAdmissionNo.Text + ", RollNo is " + txtRollNo.Text + " and Class is " + ddlClass.Text + " " + ddlSection.Text + ".");
                        }
                        catch
                        {

                        }

                        
                        this.Hide();

                    }

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
            if (Operation == "Update")
            {
                txtAdmissionNo.ReadOnly = false;
                if (AdmissionNo > 0)
                {
                    txtAdmissionNo.Text = AdmissionNo.ToString();
                }
            }
            else
            {



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
                GenerateQR();
                //ddlClass.DisplayMember = "Classes";
                //ddlClass.ValueMember = "Classes";

            }

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
        private void GetStudentDetailstoUpdate()
        {
            if (txtAdmissionNo.Text != string.Empty)
            {
                try
                {
                    if (txtAdmissionNo.Text != string.Empty)
                    {
                        SqlParameter[] m = new SqlParameter[2];

                        m[0] = new SqlParameter("@Addmission_Number", Convert.ToInt32(txtAdmissionNo.Text.Trim()));
                        m[1] = new SqlParameter("@Session", lblSession.Text);
                        SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "StudentInfo_SelectOneBySession", m);
                        while (dr.Read())
                        {
                            txtName.Text = dr["Name"].ToString();
                            ddlClass.Text = dr["Class"].ToString();
                            txtRollNo.Text = dr["RollNumber"].ToString();
                            txtStudyingClass.Text = dr["Stud_In_Class"].ToString();
                            txtAccNo.Text = dr["Acc_Number"].ToString();
                            txtFatherName.Text = dr["FatherName"].ToString();
                            txtMotherName.Text = dr["MotherName"].ToString();
                            if (dr["Gender"].ToString() == "M")
                            {
                                RBMale.Checked = true;
                            }
                            else if (dr["Gender"].ToString() == "F")
                            {
                                rbFemale.Checked = true;
                            }
                            txtDOB.Text = dr["DOB"].ToString();
                            if (dr["Category"].ToString() == "General")
                            {
                                rbGeneral.Checked = true;
                            }
                            else if (dr["Category"].ToString() == "OBC")
                            {
                                rbOBC.Checked = true;
                            }
                            else if (dr["Category"].ToString() == "SC")
                            {
                                rbSC.Checked = true;
                            }
                            else if (dr["Category"].ToString() == "BC")
                            {
                                rbBC.Checked = true;
                            }
                            else if (dr["Category"].ToString() == "EWS")
                            {
                                rbEWS.Checked = true;
                            }
                            txtSibling.Text = dr["SiblingClass"].ToString();
                            txtEmail.Text = dr["EmailId"].ToString();
                            txtAddress1.Text = dr["Address1"].ToString();
                            txtAddress2.Text = dr["Address2"].ToString();
                            txtCity.Text = dr["City"].ToString();
                            txtPhone.Text = dr["PhoneRes"].ToString();
                            txtEmergencyPhone.Text = dr["PhoneOff"].ToString();
                            txtAadharNo.Text = dr["AadharCardNo"].ToString();
                            txtSRNo.Text = dr["SRN_No"].ToString();
                            txtCBSCNo.Text = dr["CBSC_REG_No"].ToString();
                            txtBankAccountNo.Text = dr["BankAccount_No"].ToString();
                            txtIFSC.Text = dr["IFSC"].ToString();
                            txtDiscountType.Text = dr["DiscountType"].ToString();
                            txtBloodGroup.Text = dr["BloodGroup"].ToString();
                            txtBoarder.Text = dr["BoarderRequired"].ToString();
                            txtRouteNo.Text = dr["Route_No"].ToString();
                            txtOrgAdmNo.Text = dr["ORG_Adm_no"].ToString();
                            MobileForSMS.Text = dr["MobileSms"].ToString();
                            txtStoppage.Text = dr["Stopage"].ToString();
                            txtIncome.Text = dr["Income"].ToString();
                            txtDND.Text = dr["DND"].ToString();
                            txtBPL.Text = dr["BPL"].ToString();
                            txtDisabilityType.Text = dr["DisabilityType"].ToString();
                            txtFascilty.Text = dr["CWSN"].ToString();
                            txtHomeLess.Text = dr["HomeLessChild"].ToString();
                            txtExtraExam.Text = dr["Extra_Exam"].ToString();
                            txtLastExamAppear.Text = dr["Last_Exam_Appear"].ToString();
                            txtLastExamPassed.Text = dr["Last_Exam_Passed"].ToString();
                            txtLastPercentage.Text = dr["Last_Exam_Percent"].ToString();
                            txtStream11.Text = dr["Stream_11"].ToString();
                            txtFreeEducation.Text = dr["Free_Edu"].ToString();
                            txtTradeSkill.Text = dr["Trade_Skill"].ToString();
                            txtDisadvantage.Text = dr["DisAdvantages"].ToString();
                            txtMothertongue.Text = dr["MotherToung"].ToString();
                            txtMediumFoInfra.Text = dr["Medium_of_Instruction"].ToString();
                            txtPreviousYearAttendance.Text = dr["Previous_year_Att"].ToString();
                            txtLastYearStatus.Text = dr["Previous_Year_Status"].ToString();
                            txtOtherInformation.Text = dr["Other_Info"].ToString();
                            TxtAdmissionDate.Text = dr["Admission_Date"].ToString();
                            ddlSection.Text = dr["Section"].ToString();
                            //QR code
                            byte[] QRCode = (byte[])dr["QRCode"];
                            MemoryStream mstream = new MemoryStream(QRCode);

                            picQR.Image = Bitmap.FromStream(mstream);



                        }

                    }
                }
                catch (Exception ex)
                {
                    txtName.Text = string.Empty;

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                txtName.Text = string.Empty;

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

        private void button8_Click(object sender, EventArgs e)
        {
            NewStudentEntry ne = new NewStudentEntry();
            ne.Operation = "Update";
            this.Close();
            ne.Show();
        }

        private void txtAdmissionNo_TextChanged(object sender, EventArgs e)
        {
            if (Operation == "Update" && txtAdmissionNo.Text != string.Empty)
            {
                GetStudentDetailstoUpdate();
            }
        }
        private void GenerateQR()
        {
            Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            picQR.Image = qrCode.Draw(txtAdmissionNo.Text + "_" + lblSession.Text, 30);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reports.PrintAdmissionForm pr = new Reports.PrintAdmissionForm();
            pr.access = lblReceiptNo.Text;
            pr.Show();
        }
    }

}
