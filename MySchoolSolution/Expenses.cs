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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            BindComboBox();
            txtDate.Text = DateTime.Now.ToString();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] m = new SqlParameter[9];
                m[0] = new SqlParameter("@Id", SqlDbType.Int);
                m[2] = new SqlParameter("@Purpose", ddlPurpose.Text);
                m[3] = new SqlParameter("@Quantity", txtQuantity.Text);
                m[4] = new SqlParameter("@Amount", txtAmount.Text);
                m[5] = new SqlParameter("@Date", txtDate.Text);
                m[6] = new SqlParameter("@UDF1", SqlDbType.Text);
                m[7] = new SqlParameter("@UDF2", SqlDbType.Text);
                m[8] = new SqlParameter("@UDF3", SqlDbType.Text);
                SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "InvestmentForOtherPurposes_Insert", m);
                MessageBox.Show("Request Submitted Successfully");
                //InvestmentForOtherPurposes su = new InvestmentForOtherPurposes();
                //su.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BindComboBox()
        {
            DataRow dr;
            //SqlParameter[] m = new SqlParameter[5];
            //SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "StudentInfo_Insert", m);
            //DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_OtherExpenses",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select--" };
            dt.Rows.InsertAt(dr, 0);
            ddlPurpose.ValueMember = "Id";
            ddlPurpose.DisplayMember = "Expenses";
            ddlPurpose.DataSource = dt;
            con.Close();

        }

        private void btnAddNewPorpose_Click(object sender, EventArgs e)
        {
            NewPurpose su = new NewPurpose();
            su.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
