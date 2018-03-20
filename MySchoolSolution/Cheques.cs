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
    public partial class Cheques : Form
    {
        public Cheques()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvCheques.Rows.Count; i++)
            {

                if (Convert.ToBoolean(gvCheques.Rows[i].Cells[0].Value) == true)
                {
                    int FeeID = Convert.ToInt32(gvCheques.Rows[i].Cells[1].Value);
                    using (SqlConnection con = Connection.Connection_string)
                    {
                        SqlCommand cmd = new SqlCommand("update tbl_Student_MonthlyFeeDeposit set ChequeStatus='Clear' where FeeId=" + FeeID + "", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    gvCheques.Rows.RemoveAt(i);
                }

            }

        }

        private void btnBounced_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvCheques.Rows.Count; i++)
            {

                if (Convert.ToBoolean(gvCheques.Rows[i].Cells[0].Value) == true)
                {
                    int FeeID = Convert.ToInt32(gvCheques.Rows[i].Cells[1].Value);
                    using (SqlConnection con = Connection.Connection_string)
                    {
                        SqlCommand cmd = new SqlCommand("update tbl_Student_MonthlyFeeDeposit set ChequeStatus='Bounced' where FeeId=" + FeeID + "", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    gvCheques.Rows.RemoveAt(i);
                }

            }
        }

        private void Cheques_Load(object sender, EventArgs e)
        {
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", CommonFunctions.GetCurrentSession);



            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectChequesBySession", m);
            gvCheques.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gvCheques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
