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
    public partial class Reprint_Reciept : Form
    {
        public Reprint_Reciept()
        {
            InitializeComponent();
        }

        private void Reprint_Reciept_Load(object sender, EventArgs e)
        {
            //SqlParameter[] m = new SqlParameter[1];
            //m[0].Direction = ParameterDirection.Output;
            //SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "Student_MonthlyFee_Insert", m);
            //object ivalue = m[0].Value;
            //int receiptNo = (int)ivalue;
            //if (receiptNo > 0)
            //    txtRecieptNumber.Text = receiptNo.ToString();
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (txtRecieptNumber.Text == "")
            {
                MessageBox.Show("Enter Reciept Number");
            }
            else
            {
                Reports.PrintReceipt pr = new Reports.PrintReceipt();
                pr.access = txtRecieptNumber.Text;
                pr.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
