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
    public partial class Login : Form
    {
        public string AllowedMenu { get; set; }
        public string username { get; set; }
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {           
            SqlParameter[] m = new SqlParameter[2];

            m[0] = new SqlParameter("@Username", txtUserName.Text);
            m[1] = new SqlParameter("@password", txtPassword.Text);
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectUserDetailsOne", m);
            if (ds.Tables[0].Rows.Count > 0)
            {
                AllowedMenu = ds.Tables[0].Rows[0]["MenuAccess"].ToString();
                username = txtUserName.Text;
                DialogResult = DialogResult.OK;
              
            }
            else { MessageBox.Show("Invalid Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            
            //Form ff= this.ParentForm;
            //HomeMenu hm = new HomeMenu();

            //Control[] ctrl = hm.Controls.Find("menuStrip1", true);
            //MenuStrip menuStrip1 = ctrl.FirstOrDefault() as MenuStrip;
            //foreach (ToolStripMenuItem toolItem in menuStrip1.Items)
            //{
            //    if (toolItem.Name== "masterToolStripMenuItem")
            //    {
            //        toolItem.Enabled = true;
            //    }
            //}
           // hm.Show();
          //  this.Close();
            
        }
      
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
