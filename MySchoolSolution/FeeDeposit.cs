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
using System.Collections;
using System.Globalization;

namespace MySchoolSolution
{
    public partial class FeeDeposit : Form
    {
        public int AdmissionNo { get; set; }
        public bool NewAdmission { get; set; }
        public FeeDeposit()
        {
            InitializeComponent();

            lblSession.Text = CommonFunctions.GetCurrentSession;

        }

        private void GetBalance()
        {
            SqlParameter[] m = new SqlParameter[2];

            m[0] = new SqlParameter("@Admission_Number", Convert.ToInt32(txtAdmissionNo.Text.Trim()));
            m[1] = new SqlParameter("@Session", lblSession.Text);
            SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "SelectBalanceForStudent", m);
            while (dr.Read())
            {
                txtPreviousBal.Text = dr["Balance"].ToString();
            }
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
                        DataSet ds1 = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectMonthlyFeeForStudent", m);
                        int numberOfTotalMonthsPaid = 0;
                        int multiplier = 1;


                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            for (int paidRows = 0; paidRows <= ds1.Tables[0].Rows.Count - 1; paidRows++)
                            {
                                numberOfTotalMonthsPaid = numberOfTotalMonthsPaid + Convert.ToInt32(ds1.Tables[0].Rows[paidRows]["MonthCount"]);

                                for (int i = 0; i <= numberOfTotalMonthsPaid - 1; i++)
                                {
                                    DataGridViewCheckBoxCell cbCell = (DataGridViewCheckBoxCell)(gvPaidMonths.Rows[i].Cells[0]);
                                    cbCell.Value = true;
                                    cbCell.ReadOnly = true;
                                    cbCell.Style.BackColor = Color.Green;
                                    cbCell.Style.ForeColor = Color.Gray;

                                }
                            }
                            GetBalance();
                        }
                        else
                        { NewAdmission = true; }

                        if (DateTime.Now.Month >= 4)
                        {
                            multiplier = (DateTime.Now.Month - 3) - numberOfTotalMonthsPaid;
                        }
                        else
                        {
                            multiplier = (9 + DateTime.Now.Month) - numberOfTotalMonthsPaid;
                        }
                        if (multiplier < 0)
                        {
                            multiplier = 0;
                        }
                        int k = multiplier;
                        for (int i = 0; i < gvPaidMonths.Rows.Count; i++)
                        {

                            if (i >= numberOfTotalMonthsPaid && k > 0)
                            {
                                //for (int k = 0; k < multiplier; k++)
                                // {
                                DataGridViewCheckBoxCell cbCell = (DataGridViewCheckBoxCell)(gvPaidMonths.Rows[i].Cells[0]);
                                cbCell.Value = true;
                                k--;
                                //cbCell.ReadOnly = true;
                                //}
                            }

                        }

                        txtRegistrationFee.Text = dr["RegistrationFee"].ToString();
                        txtAdmissionFee.Text = dr["AddmissionFee"].ToString();
                        txtAnnualCharges.Text = dr["AnnualCharges"].ToString();
                        txtTutionFee.Text = (Convert.ToDouble(dr["TutionFee"])).ToString();
                        txtQuarterlyFee.Text = dr["QuaterlyFee"].ToString();
                        txtTransportFee.Text = dr["TransportFee"].ToString();

                        txtRegistrationFeeDisc.Text = dr["RegistrationFee_Disc"].ToString();
                        txtAdmissionFeeDisc.Text = dr["AddmissionFee_Disc"].ToString();
                        txtAnnualChargesDisc.Text = dr["AnnualCharges_Disc"].ToString();
                        txtTutionFeeDisc.Text = (Convert.ToDouble(dr["TutionFee_Disc"]) * (multiplier)).ToString();// dr["TutionFee_Disc"].ToString();
                        txtQuarterlyFeeDisc.Text = dr["QuaterlyFee_Disc"].ToString();
                        txtTransportFeeDisc.Text = dr["TransportFee_Disc"].ToString();
                        //  txtTotalAmount.Text = (Convert.ToDouble(dr["TotalAmount"]) * (multiplier)).ToString();// dr["TotalAmount"].ToString();

                        txtRegistrationFeeAct.Text = "0"; ;
                        txtAdmissionFeeAct.Text = "0"; ;
                        txtAnnualChargesAct.Text = "0"; ;
                        txtQuarterlyFeeAct.Text = "0"; ;
                        if (NewAdmission == true)
                        {

                            txtRegistrationFeeAct.Text = dr["Act_RegistrationFee"].ToString();
                            txtAdmissionFeeAct.Text = dr["Act_AddmissionFee"].ToString();
                            txtAnnualChargesAct.Text = dr["Act_AnnualCharges"].ToString();
                            txtQuarterlyFeeAct.Text = dr["Act_QuaterlyFee"].ToString();
                        }
                        txtTutionFeeAct.Text = (Convert.ToDouble(dr["Act_TutionFee"]) * (multiplier)).ToString();

                        txtTransportFeeAct.Text = (Convert.ToDouble(dr["Act_TransportFee"]) * (multiplier)).ToString(); //dr["Act_TransportFee"].ToString();

                        txtTotalAmount.Text = (Convert.ToDouble(txtRegistrationFeeAct.Text) + Convert.ToDouble(txtAdmissionFeeAct.Text) +
                            Convert.ToDouble(txtAnnualChargesAct.Text) + Convert.ToDouble(txtQuarterlyFeeAct.Text) + Convert.ToDouble(txtTransportFeeAct.Text) +
                            Convert.ToDouble(txtTutionFeeAct.Text) + Convert.ToDouble(txtMisc.Text) + Convert.ToDouble(txtPreviousBal.Text)).ToString();
                        btn_Save.Enabled = true;
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
        private void CheckSibling()
        {

            if (txtSiblingNo.Text != "" && txtSiblingNo.Text != "0")
            {
                SqlParameter[] m = new SqlParameter[2];
                m[0] = new SqlParameter("@Session", lblSession.Text);
                m[1] = new SqlParameter("@Sibling", txtSiblingNo.Text);
                DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "GetSiblingNumberBySession", m);
                if (ds.Tables[0].Rows.Count - 1 > 0)
                {
                    btnSibling.Text = (ds.Tables[0].Rows.Count - 1).ToString() + " Sibling Found";
                    btnSibling.Visible = true;
                }
            }

        }
        private void CalculateTotal()
        {
            txtTotalAmount.Text = (Convert.ToDouble(txtRegistrationFeeAct.Text) + Convert.ToDouble(txtAdmissionFeeAct.Text) + Convert.ToDouble(txtAnnualChargesAct.Text)
                + Convert.ToDouble(txtTransportFeeAct.Text) + Convert.ToDouble(txtQuarterlyFeeAct.Text) + Convert.ToDouble(txtTutionFeeAct.Text) + Convert.ToDouble(txtMisc.Text) + Convert.ToDouble(txtPreviousBal.Text)).ToString();


            txtBalance.Text = (Convert.ToDouble(txtTotalAmount.Text) - Convert.ToDouble(txtPaidAmount.Text)).ToString();
        }
        private void FeeDeposit_Load(object sender, EventArgs e)
        {

            lblSession.Text = CommonFunctions.GetCurrentSession;
            DateTime dt = new DateTime();


            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection appSettings = configuration.AppSettings;
            string _iSTR = appSettings.Settings["Months"].Value;



            string[] Months = _iSTR.Split(',');
            DataTable table = new DataTable();
            table.Columns.Add("Month", typeof(string));

            for (int i = 0; i < Months.Length; i++)
            {
                table.Rows.Add(Months[i]);
            }

            gvPaidMonths.DataSource = table;
            if (AdmissionNo > 0)
            {
                txtAdmissionNo.Text = AdmissionNo.ToString();
            }

            LoadBanksForCheque();
        }

        private void txtAdmissionNo_TextChanged(object sender, EventArgs e)
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
                            txtClass.Text = dr["Class"].ToString();
                            txtAccountNo.Text = txtAdmissionNo.Text;
                            txtSiblingNo.Text = dr["SiblingSchool"].ToString();
                            CheckSibling();
                        }

                    }
                    GetYearlyFeeForStudent();
                }
                catch (Exception ex)
                {
                    txtName.Text = string.Empty;
                    txtClass.Text = string.Empty;
                    txtAccountNo.Text = string.Empty;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                txtName.Text = string.Empty;
                txtClass.Text = string.Empty;
                txtAccountNo.Text = string.Empty;
            }
        }
        private void txtMisc_TextChanged(object sender, EventArgs e)
        {
            if (txtMisc.Text != string.Empty)
            {
                CalculateTotal();
            }

            //DateTime.Now.Month - 5;
        }

        private void gvPaidMonths_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                this.gvPaidMonths.CommitEdit(DataGridViewDataErrorContexts.Commit);

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if ((bool)this.gvPaidMonths.CurrentCell.Value == true && gvPaidMonths.CurrentCell.ReadOnly == false)
                {
                    txtTutionFeeAct.Text = (Convert.ToDouble(txtTutionFeeAct.Text) + Convert.ToDouble(txtTutionFee.Text) - Convert.ToDouble(txtTutionFeeDisc.Text)).ToString();
                    txtTransportFeeAct.Text = (Convert.ToDouble(txtTransportFeeAct.Text) + Convert.ToDouble(txtTransportFee.Text) - Convert.ToDouble(txtTransportFeeDisc.Text)).ToString();
                }
                else
                {
                    if (gvPaidMonths.CurrentCell.ReadOnly == false)
                    {
                        txtTutionFeeAct.Text = (Convert.ToDouble(txtTutionFeeAct.Text) - Convert.ToDouble(txtTutionFee.Text) + Convert.ToDouble(txtTutionFeeDisc.Text)).ToString();
                        txtTransportFeeAct.Text = (Convert.ToDouble(txtTransportFeeAct.Text) - Convert.ToDouble(txtTransportFee.Text) + Convert.ToDouble(txtTransportFeeDisc.Text)).ToString();

                    }

                }
                CalculateTotal();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtPaidAmount.Text != string.Empty)
            {
                CalculateTotal();
            }

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string PayingMonths = string.Empty;
                int PayingMonthsCount = 0;
                for (int i = 0; i < gvPaidMonths.Rows.Count; i++)
                {

                    if (Convert.ToBoolean(gvPaidMonths.Rows[i].Cells[0].Value) == true && Convert.ToBoolean(gvPaidMonths.Rows[i].Cells[0].ReadOnly == false))
                    {
                        PayingMonths = PayingMonths + "," + Convert.ToString(gvPaidMonths.Rows[i].Cells[1].Value);
                        PayingMonthsCount = PayingMonthsCount + 1;
                    }
                }

                if (PayingMonths != string.Empty)
                {
                    PayingMonths = PayingMonths.Substring(1, PayingMonths.Length - 1);
                }


                if (Convert.ToDouble(txtPaidAmount.Text) > 0)
                {
                    SqlParameter[] m = new SqlParameter[40];
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
                    m[20] = new SqlParameter("@Name", txtName.Text);
                    m[21] = new SqlParameter("@Class", txtClass.Text);
                    m[22] = new SqlParameter("@Acc_Number", txtAccountNo.Text);
                    m[23] = new SqlParameter("@TotalAmount", txtTotalAmount.Text);
                    m[24] = new SqlParameter("@UDF1", SqlDbType.Text);
                    m[25] = new SqlParameter("@UDF2", SqlDbType.Text);
                    m[26] = new SqlParameter("@UDF3", SqlDbType.Text);
                    m[27] = new SqlParameter("@Session", lblSession.Text);
                    m[28] = new SqlParameter("@MonthCount", PayingMonthsCount);
                    m[29] = new SqlParameter("@PaidForMonths", PayingMonths);
                    m[30] = new SqlParameter("@PaidAmount", txtPaidAmount.Text);
                    m[31] = new SqlParameter("@PaymentType", ddlPaymentType.Text);
                    m[32] = new SqlParameter("@Balance", txtBalance.Text);
                    m[33] = new SqlParameter("@MiscCharges", txtMisc.Text);
                    m[34] = new SqlParameter("@ChequeNumber", string.Empty);
                    m[35] = new SqlParameter("@BankName", string.Empty);
                    m[36] = new SqlParameter("@ChequeDate", string.Empty);
                    m[37] = new SqlParameter("@ChequeStatus", string.Empty);
                    string monthName = (CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month)).Substring(0, 3);
                    m[38] = new SqlParameter("@PaidinMonth", monthName);
                    m[39] = new SqlParameter("@UserName", lblUname.Text);
                    if (ddlPaymentType.Text == "Cheque")
                    {
                        if (txtChequeNumber.Text == "")
                        {
                            MessageBox.Show("Enter Check Number");
                        }
                        else if (txtBankName.Text == "")
                        {
                            MessageBox.Show("Enter Bank Name");
                        }

                        else
                        {
                            m[34] = new SqlParameter("@ChequeNumber", txtChequeNumber.Text);
                            m[35] = new SqlParameter("@BankName", txtBankName.Text);
                            m[36] = new SqlParameter("@ChequeDate", Convert.ToDateTime(dtChequeDate.Text));
                            m[37] = new SqlParameter("@ChequeStatus", "Pending");
                            m[0].Direction = ParameterDirection.Output;
                            SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "Student_MonthlyFee_Insert", m);
                            object ivalue = m[0].Value;
                            int receiptNo = (int)ivalue;
                            if (receiptNo > 0)
                                lblReceiptNo.Text = receiptNo.ToString();
                            MessageBox.Show("Fee Deposited Successfully");
                            AdmissionNo = 0;
                            btn_Save.Enabled = false;
                        }
                    }
                    else
                    {
                        m[0].Direction = ParameterDirection.Output;
                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "Student_MonthlyFee_Insert", m);

                        object ivalue = m[0].Value;
                        int receiptNo = (int)ivalue;
                        if (receiptNo > 0)
                            lblReceiptNo.Text = receiptNo.ToString();
                        MessageBox.Show("Fee Deposited Successfully");
                        AdmissionNo = 0;
                        btn_Save.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter paid amount!");
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
        private void ResetValues()
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Reports.PrintReceipt pr = new Reports.PrintReceipt();
            pr.access = lblReceiptNo.Text;
            pr.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudentForFeeDeposit ss = new SearchStudentForFeeDeposit();
            ss.Show();
            this.Close();
        }

        private void btnSibling_Click(object sender, EventArgs e)
        {
            CheckSiblingDetails ss = new CheckSiblingDetails();
            ss.siblingNo = Convert.ToInt32(txtSiblingNo.Text);
            ss.Show();
            this.Close();
        }

        private void ddlPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpChequeDetail.Visible = false;


            if (ddlPaymentType.Text == "Cheque")
            {
                grpChequeDetail.Visible = true;

                LoadBanksForCheque();

            }
        }

        private void LoadBanksForCheque()
        {
            //  string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            using (SqlConnection con = Connection.Connection_string)
            {
                SqlCommand cmd = new SqlCommand("SELECT BankName FROM tbl_Student_MonthlyFeeDeposit where BankName is not NULL", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                txtBankName.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
        }
    }
}