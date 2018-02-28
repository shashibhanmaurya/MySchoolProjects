using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution
{
    public partial class AllInventories : Form
    {
        public AllInventories()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPurpose.Text == "")

                {
                    MessageBox.Show("Enter New Item");
                }
                else
                {
                    SqlParameter[] m = new SqlParameter[4];
                    m[0] = new SqlParameter("@Id", SqlDbType.Int);
                    m[1] = new SqlParameter("@ItemName", txtPurpose.Text);
                    m[2] = new SqlParameter("@Description", txtDescription.Text);
                    m[3] = new SqlParameter("@UDF1", SqlDbType.Text);
                    SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "AllInventories_Insert", m);
                    MessageBox.Show("Request Submitted Successfully");
                    Inventory su = new Inventory();
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
