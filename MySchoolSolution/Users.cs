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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        public string Operation { get; set; }
        private void User_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "")

                {
                    MessageBox.Show("Enter UserName!");
                }
                else
                {
                    if (Operation == "Update")
                    {
                        SqlParameter[] m1 = new SqlParameter[1];
                        m1[0] = new SqlParameter("@UserName", ddlUsers.Text);

                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "User_Delete", m1);

                    }
                    string sbMenu = string.Empty;
                    for (int i = 0; i < gvMenu.Rows.Count; i++)
                    {

                        if (Convert.ToBoolean(gvMenu.Rows[i].Cells[0].Value) == true)
                        {
                            sbMenu = sbMenu + "," + Convert.ToString(gvMenu.Rows[i].Cells[2].Value);
                        }
                    }
                    if (sbMenu != string.Empty)
                    {
                        sbMenu = sbMenu.Substring(1, sbMenu.Length - 1);
                    }
                    SqlParameter[] m = new SqlParameter[7];
                    m[0] = new SqlParameter("@UserID", SqlDbType.Int);
                    m[1] = new SqlParameter("@UserName", txtUserName.Text);
                    m[2] = new SqlParameter("@Password", txtUserName.Text);
                    m[3] = new SqlParameter("@Email", txtEmail.Text);
                    m[4] = new SqlParameter("@Mobile", txtMobile.Text);
                    m[5] = new SqlParameter("@MenuAccess", sbMenu);
                    m[6] = new SqlParameter("@CreateDate", DateTime.Now.ToString());
                    if (Operation == "Update")
                    {
                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "User_Insert", m);
                        MessageBox.Show("User and Menu Access Permission Updated");
                    }
                    else
                    {
                        SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "User_Insert", m);
                        MessageBox.Show("New User Created");
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {

            HomeMenu hm = new HomeMenu();
            Control[] ctrl = hm.Controls.Find("menuStrip1", true);
            MenuStrip menuStrip1 = ctrl.FirstOrDefault() as MenuStrip;
            DataTable tableMenu = new DataTable();

            tableMenu.Columns.Add("MenuItem", typeof(string));
            tableMenu.Columns.Add("MenuItemID", typeof(string));
            // List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in menuStrip1.Items)
            {
                tableMenu.Rows.Add(toolItem.Text, toolItem.Name);
                //string name = toolItem.Name;
                //allItems.Add(toolItem);
                //add sub items
                //allItems.AddRange(GetItems(toolItem));
            }
            gvMenu.DataSource = tableMenu;
            if (Operation == "Update")
            {
                ddlUsers.Visible = true;
                lblSelectUser.Visible = true;
                BindUsers();
            }

        }
        private void BindUsers()
        {
            DataRow dr;
            SqlConnection con = new SqlConnection(Connection.Connection_string.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_UserDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select--" };
            dt.Rows.InsertAt(dr, 0);
            ddlUsers.ValueMember = "UserID";
            ddlUsers.DisplayMember = "UserName";
            ddlUsers.DataSource = dt;
            con.Close();

        }
        private void GetUserDetails()
        {

            try
            {
                if (ddlUsers.Text == "--Select--")
                {
                    CommonFunctions.ShowError("Select User");
                }
                else
                {
                    SqlParameter[] m = new SqlParameter[1];

                    m[0] = new SqlParameter("@UserName", ddlUsers.Text);
                    SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "SelectUserDetailsAll", m);
                    string AllowedMenu = string.Empty;
                    while (dr.Read())
                    {
                        txtUserName.Text = dr["UserName"].ToString();
                        txtEmail.Text = dr["Email"].ToString();
                        txtMobile.Text = dr["MobileNo"].ToString();
                        AllowedMenu = dr["MenuAccess"].ToString();
                    }
                    if (AllowedMenu != string.Empty)
                    {
                        string[] menuStrip = AllowedMenu.Split(',');
                        foreach (DataGridViewRow gvRow in gvMenu.Rows)
                        {
                            foreach (string menustripItem in menuStrip)
                            {
                                if (menustripItem == gvRow.Cells[2].Value.ToString())
                                {
                                    gvRow.Cells[0].Value = true;
                                }
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                CommonFunctions.ShowError(ex.Message);
            }


        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ddlUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserDetails();
        }
    }
}
