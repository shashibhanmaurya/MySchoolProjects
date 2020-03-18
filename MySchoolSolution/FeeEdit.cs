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
    public partial class FeeEdit : Form
    {
        public FeeEdit()
        {
            InitializeComponent();
        }

        private void txtRecieptNumber_TextChanged(object sender, EventArgs e)
        {


        }
        private void GetDetails()
        {
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@ReceiptNO", Convert.ToInt32(txtRecieptNumber.Text));
            SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "SelectOneMonthlyFeeForStudent_WithBankDetails", m);

            int i = 0;
            while (dr.Read())
            {
                txtAdmissionNo.Text = dr["Addmission_Number"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtClass.Text = dr["Class"].ToString();
                txtAccountNo.Text = dr["Acc_Number"].ToString();
                txtTotalAmount.Text = dr["TotalAmount"].ToString();
                txtPaidAmount.Text = dr["PaidAmount"].ToString();
                txtBalance.Text = dr["Balance"].ToString();
                ddlPaymentType.Text = dr["PaymentType"].ToString();
                txtChequeNumber.Text = dr["ChequeNo"].ToString();
                txtBankName.Text = dr["BankName"].ToString();
                dtChequeDate.Text = dr["ChequeDate"].ToString();
                i = 1;
            }
            if (i==0)
            {
                CommonFunctions.ShowError("Please enter a Valid Receipt No!");
            }

        }
        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            if (txtRecieptNumber.Text != "")
            {
                txtName.Text = string.Empty;
                txtClass.Text = string.Empty;
                txtAccountNo.Text = string.Empty;
                txtAdmissionNo.Text = string.Empty;
                txtTotalAmount.Text = "0.00";
                txtBalance.Text = "0.00";
                txtPaidAmount.Text = "0.00";
                txtChequeNumber.Text = string.Empty;
                txtBankName.Text = string.Empty;
                
                GetDetails();

            }
            else
            {
                CommonFunctions.ShowMessage("Please enter a Valid Receipt No!");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FeeEdit_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlParameter[] m = new SqlParameter[7];
            m[0] = new SqlParameter("@PaidAmount", txtPaidAmount.Text);
            m[1] = new SqlParameter("@Balance", txtBalance.Text);
            m[2] = new SqlParameter("@PaymentType", ddlPaymentType.Text);
            m[3] = new SqlParameter("@ChequeNo", txtChequeNumber.Text);
            m[4] = new SqlParameter("@BankName", txtBankName.Text);
            m[5] = new SqlParameter("@CheckDate", DateTime.Now.ToShortDateString());
            m[6] = new SqlParameter("@RecieptNumber", txtRecieptNumber.Text);
            SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "FeeDetails_Update", m);
            MessageBox.Show("Details Updated!");
        }
        private void CalculateBalence()
        {
            double balence, Total, Paid;
            Total = Convert.ToDouble(txtTotalAmount.Text);
            Paid = Convert.ToDouble(txtPaidAmount);
            balence = Total - Paid;
            txtBalance.Text = balence.ToString();
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
        private void ddlPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpChequeDetail.Visible = false;


            if (ddlPaymentType.Text == "Cheque")
            {
                grpChequeDetail.Visible = true;

                LoadBanksForCheque();

            }
        }
    }
}
