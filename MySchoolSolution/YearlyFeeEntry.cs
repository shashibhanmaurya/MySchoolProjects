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
                SqlParameter[] m = new SqlParameter[28];
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

                SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "StudentAnnualFeeStructure_Insert", m);
                MessageBox.Show("Fee Structure Saved Successfully");
                FeeDeposit fd = new FeeDeposit();
                fd.AdmissionNo = Convert.ToInt32(txtAdmissionNo.Text);
                fd.NewAdmission = true;
                fd.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        double TotalAmount;
        //private void Calculation()
        //{
            
        //    if(txtRegistrationFeeDisc.Text!="" || txtRegistrationFeeDisc.Text != DBNull.Value.ToString())
        //    {
        //        TotalAmount = ((Convert.ToDouble(txtRegistrationFee.Text)) - (Convert.ToDouble(txtRegistrationFeeDisc.Text)));
        //    }
        //}
        private void txtRegistrationFeeDisc_TextChanged(object sender, EventArgs e)
        {
            if (txtRegistrationFeeDisc.Text != "" || txtRegistrationFeeDisc.Text != DBNull.Value.ToString())
            {
                TotalAmount = ((Convert.ToDouble(txtRegistrationFee.Text)) - (Convert.ToDouble(txtRegistrationFeeDisc.Text)));
                txtRegistrationFeeAct.Text = TotalAmount.ToString();
            }
        }

        private void txtRegistrationFee_TextChanged(object sender, EventArgs e)
        {

            txtRegistrationFeeAct.Text = txtRegistrationFee.Text;

        }

        private void txtRegistrationFeeAct_TextChanged(object sender, EventArgs e)
        {
            if (txtRegistrationFeeAct.Text == "")
            {
                txtRegistrationFeeAct.Text = "0";
            }
            else
            {
                txtTotalAmount.Text = txtRegistrationFeeAct.Text;
            }
        }

        private void txtAdmissionFee_TextChanged(object sender, EventArgs e)
        {
            txtAdmissionFeeAct.Text = txtAdmissionFee.Text;
        }

        private void txtAdmissionFeeDisc_TextChanged(object sender, EventArgs e)
        {
            if (txtAdmissionFeeDisc.Text != "" || txtAdmissionFeeDisc.Text != DBNull.Value.ToString())
            {
                TotalAmount = ((Convert.ToDouble(txtAdmissionFee.Text)) - (Convert.ToDouble(txtAdmissionFeeDisc.Text)));
                txtAdmissionFeeAct.Text = TotalAmount.ToString();
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
            if (txtAnnualChargesDisc.Text == "")
            {
                txtAdmissionFeeDisc.Text = "0";
            }
            else
            {
                double netAmount3 = 0;
                netAmount3 = ((Convert.ToDouble(txtAnnualCharges.Text)) - (Convert.ToDouble(txtAnnualChargesDisc.Text)));
                txtAnnualChargesAct.Text = netAmount3.ToString();
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
            if (txtTutionFeeDisc.Text == "")
            {
                txtTutionFeeDisc.Text = "0";
            }
            else
            {
                double netAmount4 = 0;
                netAmount4 = ((Convert.ToDouble(txtTutionFee.Text)) - (Convert.ToDouble(txtTutionFeeDisc.Text)));
                txtTutionFeeAct.Text = netAmount4.ToString();
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
            if (txtQuarterlyFeeDisc.Text == "")
            {
                txtQuarterlyFeeDisc.Text = "0";
            }
            else
            {
                double netAmount5 = 0;
                netAmount5 = ((Convert.ToDouble(txtQuarterlyFee.Text)) - (Convert.ToDouble(txtQuarterlyFeeDisc.Text)));
                txtQuarterlyFeeAct.Text = netAmount5.ToString();
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
            if (txtTransportFeeDisc.Text == "")
            {
                txtTransportFeeDisc.Text = "0";
            }
            else
            {
                double netAmount6 = 0;
                netAmount6 = ((Convert.ToDouble(txtTransportFee.Text)) - (Convert.ToDouble(txtTransportFeeDisc.Text)));
                txtTransportFeeAct.Text = netAmount6.ToString();
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
