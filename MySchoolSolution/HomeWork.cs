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
    public partial class HomeWork : Form
    {
        public HomeWork()
        {
            InitializeComponent();
        }

        private void HomeWork_Load(object sender, EventArgs e)
        {
            ddlClass.DataSource = CommonFunctions.GetClasses;
            lblSession.Text = CommonFunctions.GetCurrentSession;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtHomeWork.Text==string.Empty)
            { CommonFunctions.ShowError("Please enter the homework !"); }
            else { 
                try
                {


                    bool status = false;
                    SqlParameter[] m = new SqlParameter[3];
                    m[0] = new SqlParameter("@SearchPhrase", string.Empty);
                    m[1] = new SqlParameter("@Class", ddlClass.Text);
                    m[2] = new SqlParameter("@Session", lblSession.Text);

                    DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SearchForFeeDeposit", m);
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        string mobileNumber = Convert.ToString(dr["PhoneRes"]);
                        CommonFunctions.SendSMS(mobileNumber, txtHomeWork.Text);
                        status = true;
                    }
                    if (status == true)
                        CommonFunctions.ShowMessage("Homework sent successfully for class " + ddlClass.Text);
                }
                catch (Exception ex)
                {

                    CommonFunctions.ShowError(ex.Message + " Homework could not be sent !");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
