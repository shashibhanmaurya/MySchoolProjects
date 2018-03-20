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
    public partial class YearlyFeeEntry : Form
    {
        public int admissionNo { get; set; }

        public YearlyFeeEntry()
        {
            InitializeComponent();
            lblSession.Text = CommonFunctions.GetCurrentSession;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegistrationFee.Text == "")
                {
                    MessageBox.Show("Please Enter Registration Fee!");
                }
                else if (txtAdmissionFee.Text == "")
                {
                    MessageBox.Show("Please Enter Admission Fee!");
                }
                else if (txtTutionFee.Text == "")
                {
                    MessageBox.Show("Please Enter Tution Fee!");
                }
                else
                {
                    SqlParameter[] m = new SqlParameter[29];
                    m[0] = new SqlParameter("@FeeId", SqlDbType.Int);
                    m[1] = new SqlParameter("@RegistrationFee", txtRegistrationFee.Text);
                    m[2] = new SqlParameter("@AddmissionFee", txtAdmissionFee.Text);
                    m[3] = new SqlParameter("@AnnualCharges", txtAnnualCharges.Text);
                    m[4] = new SqlParameter("@TutionFee", txtTutionFee.Text);
                    m[5] = new SqlParameter("@QuaterlyFee", txtQuarterlyFee.Text);
                    m[6] = new SqlParameter("@TransportFee", txtTransportFee.Text);
                    m[7] = new SqlParameter("@RegistrationFee_Disc", txtRegistrationFeeDisc.Text);
                    m[8] = new SqlParameter("@AddmissionFee_Disc", txtAdmissionFeeDisc.Text);
                    m[9] = new SqlParameter("@AnnualCharges_Disc", txtAnnualChargesDisc.Text);
                    m[10] = new SqlParameter("@TutionFee_Disc", txtTutionFeeDisc.Text);
                    m[11] = new SqlParameter("@QuaterlyFee_Disc", txtQuarterlyFeeDisc.Text);
                    m[12] = new SqlParameter("@TransportFee_Disc", txtTransportFeeDisc.Text);
                    m[13] = new SqlParameter("@Act_RegistrationFee", txtRegistrationFeeAct.Text);
                    m[14] = new SqlParameter("@Act_AddmissionFee", txtAdmissionFeeAct.Text);
                    m[15] = new SqlParameter("@Act_AnnualCharges", txtAnnualChargesAct.Text);
                    m[16] = new SqlParameter("@Act_TutionFee", txtTutionFeeAct.Text);
                    m[17] = new SqlParameter("@Act_QuaterlyFee", txtQuarterlyFeeAct.Text);
                    m[18] = new SqlParameter("@Act_TransportFee", txtTransportFeeAct.Text);
                    m[19] = new SqlParameter("@Addmission_Number", txtAdmissionNo.Text);
                    // m[20] = new SqlParameter("@Month", DateTime.Now.Month);
                    m[20] = new SqlParameter("@Class", txtClass.Text);
                    m[21] = new SqlParameter("@Acc_Number", txtAccountNo.Text);
                    m[22] = new SqlParameter("@TotalAmount", txtTotalAmount.Text);
                    m[23] = new SqlParameter("@UDF1", SqlDbType.Text);
                    m[24] = new SqlParameter("@UDF2", SqlDbType.Text);
                    m[25] = new SqlParameter("@UDF3", SqlDbType.Text);
                    m[26] = new SqlParameter("@Session", lblSession.Text);
                    m[27] = new SqlParameter("@Name", txtName.Text);
                    m[28] = new SqlParameter("@UserName", lblUname.Text);

                    SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "StudentAnnualFeeStructure_Insert", m);
                    MessageBox.Show("Fee Structure Saved Successfully");
                    FeeDeposit fd = new FeeDeposit();
                    fd.AdmissionNo = Convert.ToInt32(txtAdmissionNo.Text);
                    fd.NewAdmission = true;
                    fd.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        double TotalAmount;
        private void txtRegistrationFeeDisc_TextChanged(object sender, EventArgs e)
        {
            if (txtRegistrationFeeDisc.Text != "")
            {
                TotalAmount = ((Convert.ToDouble(txtRegistrationFee.Text)) - (Convert.ToDouble(txtRegistrationFeeDisc.Text)));
                txtRegistrationFeeAct.Text = TotalAmount.ToString();
                CalculateTotal();
            }
            else
            {
                txtRegistrationFeeDisc.Text = "0";
            }
        }

        private void CalculateTotal()
        {
            txtTotalAmount.Text = (Convert.ToDouble(txtRegistrationFeeAct.Text) + Convert.ToDouble(txtAdmissionFeeAct.Text)
                 + Convert.ToDouble(txtTutionFeeAct.Text) + Convert.ToDouble(txtAnnualChargesAct.Text)
                 + Convert.ToDouble(txtTransportFeeAct.Text) + Convert.ToDouble(txtQuarterlyFeeAct.Text)).ToString();
        }

        private void txtRegistrationFee_TextChanged(object sender, EventArgs e)
        {
            if(txtRegistrationFee.Text!="")
            {
                txtRegistrationFeeAct.Text = txtRegistrationFee.Text;
            }
            else
            {
                txtRegistrationFee.Text = "0";
            }

        }

        private void txtRegistrationFeeAct_TextChanged(object sender, EventArgs e)
        {
            if (txtRegistrationFeeAct.Text != "")
            {
                txtTotalAmount.Text = txtRegistrationFeeAct.Text;
            }
            else
            {
                txtRegistrationFeeAct.Text = "0";
            }
        }

        private void txtAdmissionFee_TextChanged(object sender, EventArgs e)
        {
            txtAdmissionFeeAct.Text = txtAdmissionFee.Text;
        }

        private void txtAdmissionFeeDisc_TextChanged(object sender, EventArgs e)
        {
            if (txtAdmissionFeeDisc.Text != "")
            {
                TotalAmount = ((Convert.ToDouble(txtAdmissionFee.Text)) - (Convert.ToDouble(txtAdmissionFeeDisc.Text)));
                txtAdmissionFeeAct.Text = TotalAmount.ToString();
                CalculateTotal();
            }
            else
            {
                txtAdmissionFeeDisc.Text = "0";
            }

        }

        private void txtAdmissionFeeAct_TextChanged(object sender, EventArgs e)
        {
            if (txtAdmissionFee.Text == "")
            {
                txtAdmissionFee.Text = "0";
            }
            else
            {
                double Totalfee = 0;
                Totalfee = Convert.ToDouble(txtRegistrationFeeAct.Text) + Convert.ToDouble(txtAdmissionFeeAct.Text);
                txtTotalAmount.Text = Totalfee.ToString();
            }
        }

        private void txtAnnualCharges_TextChanged(object sender, EventArgs e)
        {
            txtAnnualChargesAct.Text = txtAnnualCharges.Text;
        }

        private void txtAnnualChargesDisc_TextChanged(object sender, EventArgs e)
        {
            if (txtAnnualChargesDisc.Text != "")
            {
                TotalAmount = ((Convert.ToDouble(txtAnnualCharges.Text)) - (Convert.ToDouble(txtAnnualChargesDisc.Text)));
                txtAnnualChargesAct.Text = TotalAmount.ToString();
                CalculateTotal();
            }
            else
            {
                txtAnnualChargesDisc.Text = "0";
            }
        }

        private void txtAnnualChargesAct_TextChanged(object sender, EventArgs e)
        {
            if (txtAnnualCharges.Text == "")
            {
                txtAnnualCharges.Text = "0";
            }
            else
            {
                double Totalfee = 0;
                Totalfee = Convert.ToDouble(txtRegistrationFeeAct.Text) + Convert.ToDouble(txtAdmissionFeeAct.Text) + Convert.ToDouble(txtAnnualChargesAct.Text);
                txtTotalAmount.Text = Totalfee.ToString();
            }
        }

        private void txtTutionFee_TextChanged(object sender, EventArgs e)
        {
            txtTutionFeeAct.Text = txtTutionFee.Text;
        }

        private void txtTutionFeeDisc_TextChanged(object sender, EventArgs e)
        {
            if (txtTutionFeeDisc.Text != "")
            {
                TotalAmount = ((Convert.ToDouble(txtTutionFee.Text)) - (Convert.ToDouble(txtTutionFeeDisc.Text)));
                txtTutionFeeAct.Text = TotalAmount.ToString();
                CalculateTotal();
            }
            else
            {
                txtTutionFeeDisc.Text = "0";
            }
        }

        private void txtTutionFeeAct_TextChanged(object sender, EventArgs e)
        {
            if (txtTutionFee.Text == "")
            {
                txtTutionFee.Text = "0";
            }
            else
            {
                double Totalfee = 0;
                Totalfee = Convert.ToDouble(txtRegistrationFeeAct.Text) + Convert.ToDouble(txtAdmissionFeeAct.Text) + Convert.ToDouble(txtAnnualChargesAct.Text) + Convert.ToDouble(txtTutionFeeAct.Text);
                txtTotalAmount.Text = Totalfee.ToString();
            }
        }

        private void txtQuarterlyFee_TextChanged(object sender, EventArgs e)
        {
            txtQuarterlyFeeAct.Text = txtQuarterlyFee.Text;
        }

        private void txtQuarterlyFeeDisc_TextChanged(object sender, EventArgs e)
        {
            if (txtQuarterlyFeeDisc.Text != "")
            {
                TotalAmount = ((Convert.ToDouble(txtQuarterlyFee.Text)) - (Convert.ToDouble(txtQuarterlyFeeDisc.Text)));
                txtQuarterlyFeeAct.Text = TotalAmount.ToString();
                CalculateTotal();
            }
            else
            {
                txtQuarterlyFeeDisc.Text = "0";
            }
        }

        private void txtQuarterlyFeeAct_TextChanged(object sender, EventArgs e)
        {
            if (txtQuarterlyFee.Text == "")
            {
                txtQuarterlyFee.Text = "0";
            }
            else
            {
                double Totalfee = 0;
                Totalfee = Convert.ToDouble(txtRegistrationFeeAct.Text) + Convert.ToDouble(txtAdmissionFeeAct.Text) + Convert.ToDouble(txtAnnualChargesAct.Text) + Convert.ToDouble(txtTutionFeeAct.Text) + Convert.ToDouble(txtQuarterlyFeeAct.Text);
                txtTotalAmount.Text = Totalfee.ToString();
            }
        }

        private void txtTransportFee_TextChanged(object sender, EventArgs e)
        {
            txtTransportFeeAct.Text = txtTransportFee.Text;
        }

        private void txtTransportFeeDisc_TextChanged(object sender, EventArgs e)
        {
            if (txtTransportFeeDisc.Text != "")
            {
                TotalAmount = ((Convert.ToDouble(txtTransportFee.Text)) - (Convert.ToDouble(txtTransportFeeDisc.Text)));
                txtTransportFeeAct.Text = TotalAmount.ToString();
                CalculateTotal();
            }
            else
            {
                txtTransportFeeDisc.Text = "0";
            }
        }

        private void txtTransportFeeAct_TextChanged(object sender, EventArgs e)
        {
            if (txtTransportFee.Text == "")
            {
                txtTransportFee.Text = "0";
            }
            else
            {
                double Totalfee = 0;
                Totalfee = Convert.ToDouble(txtRegistrationFeeAct.Text) + Convert.ToDouble(txtAdmissionFeeAct.Text) + Convert.ToDouble(txtAnnualChargesAct.Text) + Convert.ToDouble(txtTutionFeeAct.Text) + Convert.ToDouble(txtQuarterlyFeeAct.Text) + Convert.ToDouble(txtTransportFeeAct.Text);
                txtTotalAmount.Text = Totalfee.ToString();
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdmissionNo_TextChanged(object sender, EventArgs e)
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
                        txtClass.Text = dr["Class"].ToString();
                        txtAccountNo.Text = txtAdmissionNo.Text;
                        GetFeeStructureForStudentsClass();
                    }

                }
                else
                {
                    txtRegistrationFee.Text = string.Empty;
                    txtAdmissionFee.Text = string.Empty;
                    txtAnnualCharges.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtClass.Text = string.Empty;
                    txtAccountNo.Text = string.Empty;
                    txtTutionFee.Text = string.Empty;
                    txtQuarterlyFee.Text = string.Empty;
                    txtTransportFee.Text = string.Empty;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GetFeeStructureForStudentsClass()
        {
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@Session", lblSession.Text);
            m[1] = new SqlParameter("@Class", txtClass.Text);

            SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "ClasswiseAnnualFeeStructure_SelectAllByClassAndSession", m);
            while (dr.Read())
            {
                txtRegistrationFee.Text = dr["RegistrationFee"].ToString();
                txtAdmissionFee.Text = dr["AdmissionFee"].ToString();
                txtAnnualCharges.Text = dr["AnnualCharge"].ToString();
                txtTutionFee.Text = (Convert.ToDouble(dr["TutionFee"])).ToString();
                txtQuarterlyFee.Text = dr["ExamFee"].ToString();
                txtTransportFee.Text = dr["TransportFee"].ToString();
            }
        }
        private void YearlyFeeEntry_Load(object sender, EventArgs e)
        {
            if (admissionNo > 0)
            {
                txtAdmissionNo.Text = admissionNo.ToString();
            }
            GetFeeStructureForStudentsClass();
        }


    }
}
