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
        
        public int AdmissionNo { get; set; }
        public string Session { get; set; }
        private void PrintAdmissionForm_Load(object sender, EventArgs e)
        {
            SqlParameter[] m = new SqlParameter[2];

            m[0] = new SqlParameter("@Addmission_Number", AdmissionNo);
            m[1] = new SqlParameter("@Session", Session);
            DataSet ds1 = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SelectOneBySession", m);
            Reports.AdmissionForm mr = new Reports.AdmissionForm();
            // mr.SetParameterValue("@ReceiptNo", Convert.ToInt32(temp));
            mr.SetDataSource(ds1.Tables[0]);
            mr.SetDatabaseLogon("sa", "abc123");
            reportViewer.ReportSource = mr;
        }
    }
}
