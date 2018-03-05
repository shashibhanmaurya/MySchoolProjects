using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            BindComboBox();
            txtDate.Text = DateTime.Now.ToString();
            lblSession.Text = CommonFunctions.GetCurrentSession;

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string InventoryType = string.Empty;
            if (ItemIn.Checked)
            {
                InventoryType = "IN";
            }
            else if (ItemOut.Checked)
            {
                InventoryType = "OUT";
            }
            try
            {
                if (InventoryType == "")
                {
                    MessageBox.Show("Please Cheak Inventory Type!");
                }
                else if (ddlInventoryList.Text == "--Select--")
                {
                    MessageBox.Show("Please Select Inventory Name!");
                }
                else
                {
                    SqlParameter[] m = new SqlParameter[10];
                    m[0] = new SqlParameter("@Id", SqlDbType.Int);
                    m[2] = new SqlParameter("@ItemName", ddlInventoryList.Text);
                    m[3] = new SqlParameter("@Quantity", txtQuantity.Text);
                    m[4] = new SqlParameter("@Amount", txtAmount.Text);
                    m[5] = new SqlParameter("@Date", txtDate.Text);
                    m[6] = new SqlParameter("@UDF1", txtDescription.Text);
                    m[7] = new SqlParameter("@UDF2", SqlDbType.Text);
                    m[8] = new SqlParameter("@UDF3", SqlDbType.Text);
                    m[9] = new SqlParameter("@InventoryType", InventoryType);
                    SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "Inventory_Insert", m);
                    MessageBox.Show("Inventory Saved");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void BindComboBox()
        {
            DataRow dr;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AllInventories", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select--" };
            dt.Rows.InsertAt(dr, 0);
            ddlInventoryList.ValueMember = "Id";
            ddlInventoryList.DisplayMember = "ItemName";
            ddlInventoryList.DataSource = dt;
            con.Close();
        }
        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            AllInventories ai = new AllInventories();
            ai.Show();
            this.Hide();
        }
    }
}
