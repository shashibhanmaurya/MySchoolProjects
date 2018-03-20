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
    public partial class NewPurpose : Form
    {
        public NewPurpose()
        {
            InitializeComponent();
        }

        private void NewPurpose_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPurpose.Text == "")

                {
                    MessageBox.Show("Enter New Purpose");
                }
           else
                {
                    SqlParameter[] m = new SqlParameter[5];
                    m[0] = new SqlParameter("@Id", SqlDbType.Int);
                    m[1] = new SqlParameter("@Expenses", txtPurpose.Text);
                    m[2] = new SqlParameter("@UDF1", txtDescription.Text);
                    m[3] = new SqlParameter("@UDF2", SqlDbType.Text);
                    m[4] = new SqlParameter("@UDF3", SqlDbType.Text);
                    SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "OtherExpenses_Insert", m);
                    MessageBox.Show("Request Submitted Successfully");
                    Expenses su = new Expenses();
                    su.Show();
                    this.Hide();
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
