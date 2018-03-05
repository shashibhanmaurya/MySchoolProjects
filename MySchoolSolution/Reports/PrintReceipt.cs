using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution.Reports
{
    public partial class PrintReceipt : Form
    {
        public PrintReceipt()
        {
            InitializeComponent();
        }
        private string temp;
        public string access
        {
            get
            {
                return temp;
            }
            set
            {
                temp = value;
            }
        }
        private void PrintReceipt_Load(object sender, EventArgs e)
        {
            //SqlParameter[] m = new SqlParameter[1];

            //m[0] = new SqlParameter("@ReceiptNO", Convert.ToInt32(temp));

            //DataSet ds1 = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectOneMonthlyFeeForStudent", m);
            Reports.MonthlyFeeReceipt mr = new Reports.MonthlyFeeReceipt();
            mr.SetParameterValue("@ReceiptNo", Convert.ToInt32(temp));
           // mr.SetDataSource(ds1);
            mr.SetDatabaseLogon("sa","abc123");
            PrintView.ReportSource = mr;

        }
    }
}
