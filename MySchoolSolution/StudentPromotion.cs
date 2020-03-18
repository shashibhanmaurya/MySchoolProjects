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
    public partial class StudentPromotion : Form
    {

        public StudentPromotion()
        {
            InitializeComponent();
        }
        DataTable dtAllStudents = new DataTable();


        private void StudentPromotion_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
            ddlCurrentClass.DataSource = CommonFunctions.GetClasses;
            ddlPromotingClass.DataSource = CommonFunctions.GetClasses;
            string[] SessionSplit = lblSession.Text.Split('-');
            string nextSession = (Convert.ToInt32(SessionSplit[0]) + 1).ToString() + "-" + (Convert.ToInt32(SessionSplit[1]) + 1).ToString();
            lblPromotedSession.Text = nextSession;
            ddlPromotingClass.SelectedIndex = 1;
        }

        private void ddlCurrentClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCurrentClass.SelectedIndex <= 13)
            {
                lstCurrentClassStudent.Items.Clear();
                ddlPromotingClass.SelectedIndex = ddlCurrentClass.SelectedIndex + 1;
                SqlParameter[] m = new SqlParameter[2];

                m[0] = new SqlParameter("@Class", ddlCurrentClass.Text);
                m[1] = new SqlParameter("@Session", lblSession.Text);

                DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_ForPromotion", m);


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ((ListBox)this.lstCurrentClassStudent).Items.Add(ds.Tables[0].Rows[i]["Addmission_Number"] + "_" + ds.Tables[0].Rows[i]["Name"]);
                }
            }
            else {
                CommonFunctions.ShowError("Can not be promoted further!");

            }

        }

        private void btnPromote_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lstCurrentClassStudent.Items.Count; i++)
            {
                bool b = lstCurrentClassStudent.GetItemChecked(i);
                if (b == true)
                {

                    lstPromotedStudent.Items.Add(((ListBox)lstCurrentClassStudent).Items[i]);

                }

            }
            int total = lstCurrentClassStudent.CheckedItems.Count;
            for (int x = 0; x < total; x++)
            {
                lstCurrentClassStudent.Items.Remove(lstCurrentClassStudent.CheckedItems[0]);
            }

        }

        private void btnDemote_Click(object sender, EventArgs e)
        {
            foreach (string item in lstPromotedStudent.SelectedItems)
            {
                ((ListBox)this.lstCurrentClassStudent).Items.Add(item);
            }
            int total = lstPromotedStudent.SelectedItems.Count;
            for (int x = 0; x < total; x++)
                lstPromotedStudent.Items.Remove(lstPromotedStudent.SelectedItems[0]);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (lstPromotedStudent.Items.Count == 0)
            {
                CommonFunctions.ShowError("Please select Students to Promote !");
            }
            else
            {
                try
                {
                    bool updated = false;
                    for (int i = 0; i <= lstPromotedStudent.Items.Count - 1; i++)
                    {
                        int AdmissionNo = Convert.ToInt32(lstPromotedStudent.Items[i].ToString().Split('_')[0]);
                        SqlParameter[] m1 = new SqlParameter[2];

                        m1[0] = new SqlParameter("@Addmission_Number", Convert.ToInt32(AdmissionNo));
                        m1[1] = new SqlParameter("@Session", lblPromotedSession.Text);
                        SqlDataReader dr1 = SqlHelper.ExecuteReader(Connection.Connection_string, "StudentInfo_SelectOneBySession", m1);
                        if (!dr1.Read())
                        {
                            m1[1] = new SqlParameter("@Session", lblSession.Text);

                            SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "StudentInfo_SelectOneBySession", m1);

                            PromoteStudent(dr);
                            updated = true;
                        }
                       else CommonFunctions.ShowWarning(lstPromotedStudent.Items[i].ToString().Split('_')[1]+" is already promoted");
                    }
                    if (updated)
                    {
                        
                        CommonFunctions.ShowMessage("Student(s) Promoted successfully");
                        this.Close();
                        StudentPromotion sp = new StudentPromotion();
                        sp.Show();
                    }
                        
                    
                }
                catch (Exception ex)
                {
                    CommonFunctions.ShowError(ex.Message);
                }
            }
        }

        private void PromoteStudent(SqlDataReader dr)
        {
            while (dr.Read())
            {
                SqlParameter[] m = new SqlParameter[61];
                m[0] = new SqlParameter("@Name", dr["Name"].ToString());
                m[1] = new SqlParameter("@Stud_In_Class", dr["Class"].ToString());
                m[2] = new SqlParameter("@Class",ddlPromotingClass.Text);
                m[3] = new SqlParameter("@Session_Year", lblPromotedSession.Text);
                m[4] = new SqlParameter("@RollNumber", dr["RollNumber"].ToString());
                m[5] = new SqlParameter("@Addmission_Number", dr["Addmission_Number"].ToString());
                m[6] = new SqlParameter("@Admission_Date", dr["Admission_Date"].ToString());
                m[7] = new SqlParameter("@Acc_Number", dr["Acc_Number"].ToString());
                m[8] = new SqlParameter("@FatherName", dr["FatherName"].ToString());
                m[9] = new SqlParameter("@MotherName", dr["MotherName"].ToString());
                m[10] = new SqlParameter("@Gender", dr["Gender"].ToString());
                m[11] = new SqlParameter("@Category", dr["Category"].ToString());
                m[12] = new SqlParameter("@SiblingClass", dr["SiblingClass"].ToString());
                m[13] = new SqlParameter("@SiblingSchool", dr["SiblingSchool"].ToString());
                m[14] = new SqlParameter("@Nationality", dr["Nationality"].ToString());
                m[15] = new SqlParameter("@EmailId", dr["EmailId"].ToString());
                m[16] = new SqlParameter("@Address1", dr["Address1"].ToString());
                m[17] = new SqlParameter("@Address2", dr["Address2"].ToString());
                m[18] = new SqlParameter("@City", dr["City"].ToString());
                m[19] = new SqlParameter("@PhoneRes", dr["PhoneRes"].ToString());
                m[20] = new SqlParameter("@PhoneOff", dr["PhoneOff"].ToString());
                m[21] = new SqlParameter("@AadharCardNo", dr["AadharCardNo"].ToString());
                m[22] = new SqlParameter("@SRN_No", dr["SRN_No"].ToString());
                m[23] = new SqlParameter("@CBSC_REG_No", dr["CBSC_REG_No"].ToString());
                m[24] = new SqlParameter("@BankAccount_No", dr["BankAccount_No"].ToString());
                m[25] = new SqlParameter("@IFSC", dr["IFSC"].ToString());
                m[26] = new SqlParameter("@DiscountType", dr["DiscountType"].ToString());
                m[27] = new SqlParameter("@BloodGroup", dr["BloodGroup"].ToString());
                m[28] = new SqlParameter("@BoarderRequired", dr["BoarderRequired"].ToString());
                m[29] = new SqlParameter("@Route_No", dr["Route_No"].ToString());
                m[30] = new SqlParameter("@ORG_Adm_no", dr["ORG_Adm_no"].ToString());
                m[31] = new SqlParameter("@MobileSms", dr["MobileSms"].ToString());
                m[32] = new SqlParameter("@Stopage", dr["Stopage"].ToString());
                m[33] = new SqlParameter("@Income", dr["Income"].ToString());
                m[34] = new SqlParameter("@DND", dr["DND"].ToString());
                m[35] = new SqlParameter("@BPL", dr["BPL"].ToString());
                m[36] = new SqlParameter("@DisabilityType", dr["DisabilityType"].ToString());
                m[37] = new SqlParameter("@CWSN", dr["CWSN"].ToString());
                m[38] = new SqlParameter("@HomeLessChild", dr["HomeLessChild"].ToString());
                m[39] = new SqlParameter("@Extra_Exam", dr["Extra_Exam"].ToString());
                m[40] = new SqlParameter("@Last_Exam_Appear", dr["Last_Exam_Appear"].ToString());
                m[41] = new SqlParameter("@Last_Exam_Passed", dr["Last_Exam_Passed"].ToString());
                m[42] = new SqlParameter("@Last_Exam_Percent", dr["Last_Exam_Percent"].ToString());
                m[43] = new SqlParameter("@Stream_11", dr["Stream_11"].ToString());
                m[44] = new SqlParameter("@Free_Edu", dr["Free_Edu"].ToString());
                m[45] = new SqlParameter("@Trade_Skill", dr["Trade_Skill"].ToString());
                m[46] = new SqlParameter("@DisAdvantages", dr["DisAdvantages"].ToString());
                m[47] = new SqlParameter("@MotherToung", dr["MotherToung"].ToString());
                m[48] = new SqlParameter("@Medium_of_Instruction", dr["Medium_of_Instruction"].ToString());
                m[49] = new SqlParameter("@Previous_year_Att", dr["Previous_year_Att"].ToString());
                m[50] = new SqlParameter("@Previous_Year_Status", dr["Previous_Year_Status"].ToString());
                m[51] = new SqlParameter("@Other_Info", dr["Other_Info"].ToString());
                m[52] = new SqlParameter("@DOB", Convert.ToDateTime(dr["DOB"]));
                m[53] = new SqlParameter("@StdId", SqlDbType.Int);
                m[54] = new SqlParameter("@UDF1", dr["UDF1"].ToString());
                m[55] = new SqlParameter("@UDF2", dr["UDF2"].ToString());
                m[56] = new SqlParameter("@UDF3", dr["UDF3"].ToString());
                m[57] = new SqlParameter("@UserName", CommonFunctions.UserName);
                var nullValue = DBNull.Value;
                //QR code
                byte[] QRCode = null;
                if (dr["QRCode"] != DBNull.Value)
                {
                    QRCode = (byte[])dr["QRCode"];
                    m[58] = new SqlParameter("@QRCode", QRCode);
                }
                else
                {
                    m[58] = new SqlParameter("@QRCode", nullValue);
                }
               

                
                
                m[59] = new SqlParameter("@Section", dr["Section"].ToString());

                byte[] studentPhoto = null;
                //Student Photo
                if (dr["StudentPhoto"] != DBNull.Value)
                {
                    studentPhoto = (byte[])dr["StudentPhoto"];
                    m[60] = new SqlParameter("@StudentPhoto", studentPhoto);
                }
                else
                {
                    m[60] = new SqlParameter("@StudentPhoto", nullValue);
                    m[60].SqlDbType = SqlDbType.Image;
                }

                
               

                SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "StudentInfo_Insert", m);

            }
        }

        private void btnBounced_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
