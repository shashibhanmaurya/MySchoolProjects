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
    public partial class PrintAdmissionForm : Form
    {
        public PrintAdmissionForm()
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
        private void PrintAdmissionForm_Load(object sender, EventArgs e)
        {
            SqlParameter[] m = new SqlParameter[1];

            m[0] = new SqlParameter("@ReceiptNO", Convert.ToInt32(temp));

            DataSet ds1 = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectOneAdmissionFormForStudent", m);
            Reports.AdmissionForm mr = new Reports.AdmissionForm();
            // mr.SetParameterValue("@ReceiptNo", Convert.ToInt32(temp));
            mr.SetDataSource(ds1.Tables[0]);
            mr.SetDatabaseLogon("sa", "abc123");
            reportViewer.ReportSource = mr;
        }
    }
}
