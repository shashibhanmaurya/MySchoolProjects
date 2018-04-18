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
        public string Operation { get; set; }
        public YearlyFeeEntry()
        {
            InitializeComponent();
            lblSession.Text = CommonFunctions.GetCurrentSession;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdmissionNo.Text == string.Empty)
                {
                    CommonFunctions.ShowError("Please enter Registration Number!");
                }
                else if (txtRegistrationFee.Text == "")
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
                else if (ValidateFeeEntry() == true && Operation != "Update")
                {
                    MessageBox.Show("Fee Structure for this student is already saved !");
                }
                else
                {
                    if (Operation == "Update")
                    {
                        SqlConnection con = new SqlConnection(Connection.Connection_string.ConnectionString);
                        SqlCommand cmd = new SqlCommand("delete tbl_StudentAnnualFeeStructure WHERE Addmission_Number='" + txtAdmissionNo.Text + "' AND Session='" + lblSession.Text + "'");
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
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
                    CommonFunctions.ShowMessage("Fee Structure Saved Successfully");
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
        private bool ValidateFeeEntry()
        {
            bool b = false;
            if (txtAdmissionNo.Text != "" && txtAdmissionNo.Text != "0")
            {
                SqlParameter[] m = new SqlParameter[2];
                m[0] = new SqlParameter("@Session", lblSession.Text);
                m[1] = new SqlParameter("@Addmission_Number", txtAdmissionNo.Text);
                DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "ValidateYearlyFeeEntry", m);
                if (ds.Tables[0].Rows.Count > 0)
                    b = true;
                else
                    b = false;
            }
            return b;
        }
        private void GetYearlyFeeForStudent()
        {
            try
            {
                if (txtAdmissionNo.Text != string.Empty)
                {

                    SqlParameter[] m = new SqlParameter[2];

                    m[0] = new SqlParameter("@Admission_Number", Convert.ToInt32(txtAdmissionNo.Text.Trim()));
                    m[1] = new SqlParameter("@Session", lblSession.Text);
                    SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "StudentAnnualFeeStructureSelectOne", m);
                    int chk = 0;
                    while (dr.Read())
                    {
                        txtRegistrationFee.Text = dr["RegistrationFee"].ToString();
                        txtAdmissionFee.Text = dr["AddmissionFee"].ToString();
                        txtAnnualCharges.Text = dr["AnnualCharges"].ToString();
                        txtTutionFee.Text = (Convert.ToDouble(dr["TutionFee"])).ToString();
                        txtQuarterlyFee.Text = dr["QuaterlyFee"].ToString();
                        txtTransportFee.Text = dr["TransportFee"].ToString();

                        txtRegistrationFeeDisc.Text = dr["RegistrationFee_Disc"].ToString();
                        txtAdmissionFeeDisc.Text = dr["AddmissionFee_Disc"].ToString();
                        txtAnnualChargesDisc.Text = dr["AnnualCharges_Disc"].ToString();
                        txtTutionFeeDisc.Text = dr["TutionFee_Disc"].ToString();// dr["TutionFee_Disc"].ToString();
                        txtQuarterlyFeeDisc.Text = dr["QuaterlyFee_Disc"].ToString();
                        txtTransportFeeDisc.Text = dr["TransportFee_Disc"].ToString();

                        txtRegistrationFeeAct.Text = dr["Act_RegistrationFee"].ToString();
                        txtAdmissionFeeAct.Text = dr["Act_AddmissionFee"].ToString();
                        txtAnnualChargesAct.Text = dr["Act_AnnualCharges"].ToString();
                        txtQuarterlyFeeAct.Text = dr["Act_QuaterlyFee"].ToString();

                        txtTutionFeeAct.Text = dr["Act_TutionFee"].ToString();

                        txtTransportFeeAct.Text = dr["Act_TransportFee"].ToString(); //dr["Act_TransportFee"].ToString();

                        txtTotalAmount.Text = (Convert.ToDouble(txtRegistrationFeeAct.Text) + Convert.ToDouble(txtAdmissionFeeAct.Text) +
                            Convert.ToDouble(txtAnnualChargesAct.Text) + Convert.ToDouble(txtQuarterlyFeeAct.Text) + Convert.ToDouble(txtTransportFeeAct.Text) +
                            Convert.ToDouble(txtTutionFeeAct.Text)).ToString();

                        chk = 1;

                    }
                    if (chk == 0)
                    {
                        txtRegistrationFee.Text = "0.00";
                        txtAdmissionFee.Text = "0.00";
                        txtAnnualCharges.Text = "0.00";
                        txtTutionFee.Text = "0.00";
                        txtQuarterlyFee.Text = "0.00";
                        txtTransportFee.Text = "0.00";

                        txtRegistrationFeeDisc.Text = "0.00";
                        txtAdmissionFeeDisc.Text = "0.00";
                        txtAnnualChargesDisc.Text = "0.00";
                        txtTutionFeeDisc.Text = "0.00";
                        txtQuarterlyFeeDisc.Text = "0.00";
                        txtTransportFeeDisc.Text = "0.00";
                        txtTotalAmount.Text = "0.00";
                        txtRegistrationFeeAct.Text = "0"; ;
                        txtAdmissionFeeAct.Text = "0"; ;
                        txtAnnualChargesAct.Text = "0"; ;
                        txtQuarterlyFeeAct.Text = "0"; ;

                        MessageBox.Show("Please enter a Valid Admission number !");
                    }

                }
                else
                {
                    txtRegistrationFee.Text = "0.00";
                    txtAdmissionFee.Text = "0.00";
                    txtAnnualCharges.Text = "0.00";
                    txtTutionFee.Text = "0.00";
                    txtQuarterlyFee.Text = "0.00";
                    txtTransportFee.Text = "0.00";

                    txtRegistrationFeeDisc.Text = "0.00";
                    txtAdmissionFeeDisc.Text = "0.00";
                    txtAnnualChargesDisc.Text = "0.00";
                    txtTutionFeeDisc.Text = "0.00";
                    txtQuarterlyFeeDisc.Text = "0.00";
                    txtTransportFeeDisc.Text = "0.00";
                    txtTotalAmount.Text = "0.00";
                    txtRegistrationFeeAct.Text = "0"; ;
                    txtAdmissionFeeAct.Text = "0"; ;
                    txtAnnualChargesAct.Text = "0"; ;
                    txtQuarterlyFeeAct.Text = "0"; ;

                }
            }
            catch (Exception ex)
            {
                txtRegistrationFee.Text = "0.00";
                txtAdmissionFee.Text = "0.00";
                txtAnnualCharges.Text = "0.00";
                txtTutionFee.Text = "0.00";
                txtQuarterlyFee.Text = "0.00";
                txtTransportFee.Text = "0.00";

                txtRegistrationFeeDisc.Text = "0.00";
                txtAdmissionFeeDisc.Text = "0.00";
                txtAnnualChargesDisc.Text = "0.00";
                txtTutionFeeDisc.Text = "0.00";
                txtQuarterlyFeeDisc.Text = "0.00";
                txtTransportFeeDisc.Text = "0.00";
                txtTotalAmount.Text = "0.00";
                txtRegistrationFeeAct.Text = "0"; ;
                txtAdmissionFeeAct.Text = "0"; ;
                txtAnnualChargesAct.Text = "0"; ;
                txtQuarterlyFeeAct.Text = "0"; ;

                MessageBox.Show(ex.Message);
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
            txtAdmissionNo.Focus();
        }


        private void txtRegistrationFee_TextChanged(object sender, EventArgs e)
        {
            if (txtRegistrationFee.Text != "")
            {
                txtRegistrationFeeAct.Text = (Convert.ToDouble(txtRegistrationFee.Text) - Convert.ToDouble(txtRegistrationFeeDisc.Text)).ToString();
                CalculateTotal();
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
            if (txtAdmissionFee.Text != string.Empty)
            {
                txtAdmissionFeeAct.Text = (Convert.ToDouble(txtAdmissionFee.Text) - Convert.ToDouble(txtAdmissionFeeDisc.Text)).ToString();

                CalculateTotal();
            }

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
            if (txtAnnualCharges.Text != string.Empty)
            {
                txtAnnualChargesAct.Text = (Convert.ToDouble(txtAnnualCharges.Text) - Convert.ToDouble(txtAnnualChargesDisc.Text)).ToString();

                CalculateTotal();
            }

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
            if (txtTutionFee.Text != string.Empty)
            {
                txtTutionFeeAct.Text = (Convert.ToDouble(txtTutionFee.Text) - Convert.ToDouble(txtTutionFeeDisc.Text)).ToString();

                CalculateTotal();
            }

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
            if (txtQuarterlyFee.Text != string.Empty)
            {
                txtQuarterlyFeeAct.Text = (Convert.ToDouble(txtQuarterlyFee.Text) - Convert.ToDouble(txtQuarterlyFeeDisc.Text)).ToString();

                CalculateTotal();
            }

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
            if (txtTransportFee.Text != string.Empty)
            {
                txtTransportFeeAct.Text = (Convert.ToDouble(txtTransportFee.Text) - Convert.ToDouble(txtTransportFeeDisc.Text)).ToString();

                CalculateTotal();
            }

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
                        //if (Operation == "Update")
                        //{
                        //    GetYearlyFeeForStudent();
                        //}
                    }

                }
                else
                {
                    txtRegistrationFee.Text = "0";
                    txtAdmissionFee.Text = "0";
                    txtAnnualCharges.Text = "0";
                    txtName.Text = "0";
                    txtClass.Text = "0";
                    txtAccountNo.Text = "0";
                    txtTutionFee.Text = "0";
                    txtQuarterlyFee.Text = "0";
                    txtTransportFee.Text = "0";

                    txtRegistrationFeeAct.Text = "0";
                    txtAdmissionFeeAct.Text = "0";
                    txtAnnualChargesAct.Text = "0";
                    txtTutionFeeAct.Text = "0";
                    txtQuarterlyFeeAct.Text = "0";
                    txtTransportFeeAct.Text = "0";

                    txtRegistrationFeeDisc.Text = "0";
                    txtAdmissionFeeDisc.Text = "0";
                    txtAnnualChargesDisc.Text = "0";
                    txtTutionFeeDisc.Text = "0";
                    txtQuarterlyFeeDisc.Text = "0";
                    txtTransportFeeDisc.Text = "0";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void txtAdmissionNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtRegistrationFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtAdmissionFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtAnnualCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtTutionFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtQuarterlyFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtTransportFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtRegistrationFeeDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtAdmissionFeeDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtAnnualChargesDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtTutionFeeDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtQuarterlyFeeDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtTransportFeeDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }


    }
}

