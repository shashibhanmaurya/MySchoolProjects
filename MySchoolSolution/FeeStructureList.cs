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
    public partial class FeeStructureList : Form
    {
        public FeeStructureList()
        {
            InitializeComponent();
            bindFeeStructure();
        }
        private void bindFeeStructure()
        {
            
              SqlParameter[] m = new SqlParameter[1];

           
            m[0] = new SqlParameter("@Session", CommonFunctions.GetCurrentSession);
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "ClasswiseAnnualFeeStructure_SelectAllBySession", m);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void FeeStructureList_Load(object sender, EventArgs e)
        {

        }
    }
}
