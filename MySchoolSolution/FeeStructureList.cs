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
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ClasswiseAnnualFeeStructure_SelectAll";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
