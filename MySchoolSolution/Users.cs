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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

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
                    SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "User_Insert", m);
                    MessageBox.Show("New User Created");
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
            Control[] ctrl = hm.Controls.Find("menuStrip1",true);
            MenuStrip menuStrip1 = ctrl.FirstOrDefault() as MenuStrip;
            DataTable tableMenu = new DataTable();

            tableMenu.Columns.Add("MenuItem", typeof(string));
            tableMenu.Columns.Add("MenuItemID", typeof(string));
            // List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in menuStrip1.Items)
            {
                tableMenu.Rows.Add(toolItem.Text,toolItem.Name);
                //string name = toolItem.Name;
                //allItems.Add(toolItem);
                //add sub items
                //allItems.AddRange(GetItems(toolItem));
            }
            gvMenu.DataSource = tableMenu;
        }

       
    }
}
