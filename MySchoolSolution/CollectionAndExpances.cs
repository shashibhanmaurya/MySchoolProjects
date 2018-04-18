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
    public partial class CollectionAndExpances : Form
    {
        public CollectionAndExpances()
        {
            InitializeComponent();
        }

        private void TabClassWiseCollection_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection.Connection_string.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dtFrom.Text + "' and CreateDate<='" + dtTo.Text + "'";
            cmd.Connection = con;
            con.Open();
            lblTotal.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dtFrom.Text + "' and CreateDate<='" + dtTo.Text + "' and PaymentType='Cash'";
            lblCash.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dtFrom.Text + "' and CreateDate<='" + dtTo.Text + "' and PaymentType='Cheque'";
            lblCheque.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dtFrom.Text + "' and CreateDate<='" + dtTo.Text + "' and PaymentType='Paytm'";
            lblPaytm.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dtFrom.Text + "' and CreateDate<='" + dtTo.Text + "' and PaymentType='Credit / Debit Card'";
            lblCard.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dtFrom.Text + "' and CreateDate<='" + dtTo.Text + "' and PaymentType='Bank Transfer'";
            lblBankTransfer.Text = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
        }

        private void CollectionAndExpances_Load(object sender, EventArgs e)
        {
            ddlClass.DataSource = CommonFunctions.GetClasses;
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectSession");
            ddlSession.DataSource = ds.Tables[0];

            ddlSession.DisplayMember = "Session_Year";
            ddlSession.ValueMember = "Session_Year";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection.Connection_string.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dateTimePicker2.Text + "' and CreateDate<='" + dateTimePicker1.Text + "'and Class='" + ddlClass.Text + "'";
            cmd.Connection = con;
            con.Open();
            lblTotal.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dateTimePicker2.Text + "' and CreateDate<='" + dateTimePicker1.Text + "'and Class='" + ddlClass.Text + "' and PaymentType='Cash'";
            lblCash.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dateTimePicker2.Text + "' and CreateDate<='" + dateTimePicker1.Text + "'and Class='" + ddlClass.Text + "' and PaymentType='Cheque'";
            lblCheque.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dateTimePicker2.Text + "' and CreateDate<='" + dateTimePicker1.Text + "'and Class='" + ddlClass.Text + "' and PaymentType='Paytm'";
            lblPaytm.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dateTimePicker2.Text + "' and CreateDate<='" + dateTimePicker1.Text + "'and Class='" + ddlClass.Text + "' and PaymentType='Credit / Debit Card'";
            lblCard.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where CreateDate>='" + dateTimePicker2.Text + "' and CreateDate<='" + dateTimePicker1.Text + "'and Class='" + ddlClass.Text + "' and PaymentType='Bank Transfer'";
            lblBankTransfer.Text = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection.Connection_string.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where Session='" + ddlSession.Text + "'";
            cmd.Connection = con;
            con.Open();
            lblTotal.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where Session='" + ddlSession.Text + "'and PaymentType='Cash'";
            lblCash.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where Session='" + ddlSession.Text + "'and PaymentType='Cheque'";
            lblCheque.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where Session='" + ddlSession.Text + "'and PaymentType='Paytm'";
            lblPaytm.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where Session='" + ddlSession.Text + "'and PaymentType='Credit / Debit Card'";
            lblCard.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd.CommandText = "select SUM(PaidAmount) as TotalCollection from tbl_Student_MonthlyFeeDeposit where Session='" + ddlSession.Text + "'and PaymentType='Bank Transfer'";
            lblBankTransfer.Text = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports.ProfitLossPrint pp = new Reports.ProfitLossPrint();
            pp.Purpose = "Fee Collection between "+dtFrom.Text+" and "+dtTo.Text+"";
            pp.Total = lblTotal.Text;
            pp.Cash = lblCash.Text;
            pp.Cheque = lblCheque.Text;
            pp.Paytm = lblPaytm.Text;
            pp.Card = lblCard.Text;
            pp.BankTransfer = lblBankTransfer.Text;
            pp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports.ProfitLossPrint pp = new Reports.ProfitLossPrint();
            pp.Purpose = "Fee Collection for class "+ddlClass.Text+" between " + dtFrom.Text + " and " + dtTo.Text + "";
            pp.Total = lblTotal.Text;
            pp.Cash = lblCash.Text;
            pp.Cheque = lblCheque.Text;
            pp.Paytm = lblPaytm.Text;
            pp.Card = lblCard.Text;
            pp.BankTransfer = lblBankTransfer.Text;
            pp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports.ProfitLossPrint pp = new Reports.ProfitLossPrint();
            pp.Purpose = "Fee Collection for Session " + ddlSession.Text;
            pp.Total = lblTotal.Text;
            pp.Cash = lblCash.Text;
            pp.Cheque = lblCheque.Text;
            pp.Paytm = lblPaytm.Text;
            pp.Card = lblCard.Text;
            pp.BankTransfer = lblBankTransfer.Text;
            pp.Show();
        }
    }
}
