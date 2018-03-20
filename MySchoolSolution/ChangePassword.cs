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
    public partial class ChangePassword : Form
    {
      
        public ChangePassword()
        {
            InitializeComponent();
            
        }
      
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Enter User Name");
            }
            else if(txtNewPassword.Text!=txtConfirmPassword.Text)
            {
                MessageBox.Show("New password and confirm password does not match !");
            }
            else
            {
                try
                {
                    SqlParameter[] m = new SqlParameter[5];
                    m[0] = new SqlParameter("@UserID", SqlDbType.Int);
                    m[1] = new SqlParameter("@UserName", txtUserName.Text.Trim());
                    m[2] = new SqlParameter("@OldPassword", txtOldPassword.Text.Trim());
                    m[3] = new SqlParameter("@NewPassword", txtNewPassword.Text.Trim());
                    m[4] = new SqlParameter("@status", SqlDbType.Int);
                    m[4].Direction = ParameterDirection.Output;
                    SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "UserChangePassword", m);
                    int retVal = Convert.ToInt32(m[4].Value);
                    if (retVal == 1)
                    {
                        MessageBox.Show("Password has been changed successfully");                       
                    }
                    else
                    {
                        MessageBox.Show("Wrong old username/password. Please re-enter.");                        
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
