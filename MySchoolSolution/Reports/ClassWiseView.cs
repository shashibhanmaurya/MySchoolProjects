using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution.Reports
{
    public partial class ClassWiseView : Form
    {
        public DataSet dataSet { get; set; }
        public ClassWiseView()
        {
            InitializeComponent();
        }

        private void ClassWiseView_Load(object sender, EventArgs e)
        {
            Reports.StudentInfoByClass st = new Reports.StudentInfoByClass();
            st.SetDataSource(dataSet.Tables[0]);
            st.SetDatabaseLogon("sa", "abc123");
            crystalReportViewer1.ReportSource = st;
        }
    }
}
