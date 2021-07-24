using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution
{
    public partial class FeeStatementByMonthAndClassForASession : Form
    {
        public DataTable dsReport { get; set; }
        public FeeStatementByMonthAndClassForASession()
        {
            InitializeComponent();
        }
        private void GetStatement()
        {
            int month = DTMonth.Value.Month;
            string sMonths = "4,5,6,7,8,9,10,11,12";
            string forMonths = string.Empty;
            string forMonths1 = string.Empty;
            if (month < 4)
            {
                for (int i = 1; i <= month; i++)
                {

                    forMonths1 = forMonths1 + "," + i.ToString();
                }
                if (forMonths1 != string.Empty)
                {
                    forMonths = sMonths + ","+forMonths1.Substring(1, forMonths1.Length - 1);
                }

            }

            else
            {
                for (int i = 4; i <= month; i++)
                {

                    forMonths1 = forMonths1 + "," + i.ToString();
                }
                forMonths = forMonths1.Substring(1, forMonths1.Length - 1);
            }
            gvSearchResult.DataSource = null;
            SqlParameter[] m = new SqlParameter[3];
            m[0] = new SqlParameter("@Session", lblSession.Text);
            m[1] = new SqlParameter("@Class", comboClassForStatement.Text);
            m[2] = new SqlParameter("@ForMonth", forMonths);


            DataTable ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "TillMonthWiseStudent_FeeStatementBySessionAndClass", m).Tables[0];

            DataTable dtAmountToBePaid = GetAmountToBePaid();
            ds.PrimaryKey = new DataColumn[] { ds.Columns["Addmission_Number"] };
            dtAmountToBePaid.PrimaryKey = new DataColumn[] { dtAmountToBePaid.Columns["Addmission_Number"] };
            ds.Merge(dtAmountToBePaid);
            gvSearchResult.DataSource = ds;
            dsReport = ds;
            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.HeaderText = "";
            //checkBoxColumn.Width = 30;
            //checkBoxColumn.Name = "checkStudent";
            //checkBoxColumn.HeaderText = "Select";
            //gvSearchResult.Columns.Insert(0, checkBoxColumn);
        }
        private void comboClassForStatement_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStatement();
        }
        private DataTable GetAmountToBePaid()
        {
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@Class", comboClassForStatement.SelectedValue);
            m[1] = new SqlParameter("@Session", lblSession.Text);
            SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "StudentAnnualFeeStructureSelectByClass", m);

            DataTable dtPayableAmount = new DataTable();
            dtPayableAmount.Columns.Add("Addmission_Number", typeof(int));
            dtPayableAmount.Columns.Add("AmountPayable", typeof(double));
            while (dr.Read())
            {
                int multiplier = 1;
                int diff = 0;
                if (DTMonth.Value.Month >= 4)
                {
                    diff = DTMonth.Value.Month - 3;
                    if (diff > 0)
                    {
                        multiplier = diff;
                    }
                }
                else
                {
                    multiplier = (9 + DTMonth.Value.Month);
                }
                if (multiplier < 0)
                {
                    multiplier = 0;
                }
                int admNo = Convert.ToInt32(dr["Addmission_Number"]);
                if (admNo == 577)
                {
                }
                double MiscAmt = 0.0;
                double TotalExamFee = 0.0;
                double TotalDiscount = 0.0;
                double TotalPayableFromMonthlyFee = 0.0;
                int TotalMonthCount = 0;
                try
                {
                    SqlParameter[] m2 = new SqlParameter[2];

                    m2[0] = new SqlParameter("@Admission_Number", admNo);
                    m2[1] = new SqlParameter("@Session", lblSession.Text);
                    SqlDataReader dr2 = SqlHelper.ExecuteReader(Connection.Connection_string, "SelectOtherTotal", m2);
                    while (dr2.Read())
                    {
                        MiscAmt = Convert.ToDouble(dr2["TotalMiscCharges"]);
                        TotalExamFee = Convert.ToDouble(dr2["TotalExamFee"]);
                        TotalDiscount = Convert.ToDouble(dr2["TotalDiscount"]);
                        TotalPayableFromMonthlyFee = Convert.ToDouble(dr2["TotalAmountPayable"]);
                        TotalMonthCount = Convert.ToInt32(dr2["TotalMonthPaid"]);
                    }
                }
                catch
                {
                }
                multiplier = multiplier - TotalMonthCount;
                double registrationFee = Convert.ToDouble(dr["Act_RegistrationFee"]);
                double AdmissionFeeAct = Convert.ToDouble(dr["Act_AddmissionFee"]);
                double AnnualChargesAct = Convert.ToDouble(dr["Act_AnnualCharges"]);
                double QuarterlyFeeAct = Convert.ToDouble(dr["Act_QuaterlyFee"]);

                double TutionFeeAct = (Convert.ToDouble(dr["Act_TutionFee"]) * (multiplier));
                double TransportFeeAct = (Convert.ToDouble(dr["Act_TransportFee"]) * (multiplier)); //dr["Act_TransportFee"].ToString();
                double TotalPayableAmount = 0;

                if (TotalMonthCount > 0)
                {
                    TotalPayableAmount = TotalPayableFromMonthlyFee + TransportFeeAct + TutionFeeAct - TotalDiscount;

                }
                else
                {
                    TotalPayableAmount = MiscAmt + TotalExamFee + registrationFee + AdmissionFeeAct + AnnualChargesAct + QuarterlyFeeAct + TransportFeeAct + TutionFeeAct - TotalDiscount;
                }


                dtPayableAmount.Rows.Add(admNo, TotalPayableAmount);

            }
            return dtPayableAmount;
        }
        private double GetMiscAmount(int AdmNo, string Session)
        {
            double MiscAmt = 0.0;
            try
            {
                SqlParameter[] m = new SqlParameter[2];

                m[0] = new SqlParameter("@Admission_Number", AdmNo);
                m[1] = new SqlParameter("@Session", lblSession.Text);
                SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "SelectTotalMiscChargesForStudent", m);
                while (dr.Read())
                {
                    MiscAmt = Convert.ToDouble(dr["TotalMiscCharges"]);
                }
            }
            catch
            {


            }
            return MiscAmt;
        }

        private double GetTotalDiscountGiven(int AdmNo, string Session)
        {
            double Discount = 0.0;
            try
            {
                SqlParameter[] m = new SqlParameter[2];

                m[0] = new SqlParameter("@Admission_Number", AdmNo);
                m[1] = new SqlParameter("@Session", lblSession.Text);
                SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "SelectTotalDiscountForStudent", m);
                while (dr.Read())
                {
                    Discount = Convert.ToDouble(dr["TotalDiscount"]);
                }
            }
            catch
            {


            }
            return Discount;
        }

        private double GetTotalExamFee(int AdmNo, string Session)
        {
            double ExamFee = 0.0;
            try
            {
                SqlParameter[] m = new SqlParameter[2];

                m[0] = new SqlParameter("@Admission_Number", AdmNo);
                m[1] = new SqlParameter("@Session", lblSession.Text);
                SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "SelectTotalExamFeeForStudent", m);
                while (dr.Read())
                {
                    ExamFee = Convert.ToDouble(dr["TotalExamFee"]);
                }
            }
            catch
            {


            }
            return ExamFee;
        }
        private double GetBalance(int AdmNo, string Session)
        {
            double Balance = 0.0;
            try
            {
                SqlParameter[] m = new SqlParameter[2];

                m[0] = new SqlParameter("@Admission_Number", AdmNo);
                m[1] = new SqlParameter("@Session", lblSession.Text);
                SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "SelectBalanceOfStudentForAmountDue", m);
                while (dr.Read())
                {
                    Balance = Convert.ToDouble(dr["Balance"]);
                }
            }
            catch
            {


            }

            return Balance;
        }
        private void DTMonth_ValueChanged(object sender, EventArgs e)
        {
            txtMonth.Text = (CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DTMonth.Value.Month));
            GetStatement();
        }

        private void FeeStatementByMonthAndClassForASession_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
            comboClassForStatement.DataSource = CommonFunctions.GetClasses;
            DTMonth.MinDate = DateTime.Now.Date;
            txtMonth.Text = (CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DTMonth.Value.Month));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.FeeStatementWithAmountDue r = new Reports.FeeStatementWithAmountDue();
            r.dsReport = dsReport;
            r.Class = comboClassForStatement.Text;
            r.Session = lblSession.Text;
            r.TillMonthValue = txtMonth.Text;
            r.Show();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gvSearchResult.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkStudent"].Value);
                if (isSelected)
                {
                    double dueAmount = Convert.ToDouble(row.Cells[18].Value) - Convert.ToDouble(row.Cells[17].Value);
                    CommonFunctions.SendSMS(row.Cells[4].Value.ToString(), "Dear " + row.Cells[2].Value.ToString() + " Your current due amount is " + dueAmount.ToString() + ". Kindly pay it as earliest to avoid any late charges.");
                }
            }
        }
    }
}
