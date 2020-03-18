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
    public partial class EmployeeSalary : Form
    {
        public EmployeeSalary()
        {
            InitializeComponent();
        }

        private void EmployeeSalary_Load(object sender, EventArgs e)
        {

        }

        private void txtTutionFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] m = new SqlParameter[12];
                m[0] = new SqlParameter("@Name", txtEmpName.Text);
                m[1] = new SqlParameter("@BasicSalary", txtbasicsalary.Text);
                m[2] = new SqlParameter("@DearnessAllowance", txtdearnessallowance.Text);
                m[3] = new SqlParameter("@MedicalAllowance", txtMedicalallowance.Text);
                m[4] = new SqlParameter("@TransportAllowance", txtTransportAllowance.Text);
                m[5] = new SqlParameter("@ProfessionTax", txtprofessionaltax.Text);
                m[6] = new SqlParameter("@ProvidentFund", txtprovidentfund.Text);
                m[7] = new SqlParameter("@IncomeTax", txtincometax.Text);
                m[8] = new SqlParameter("@EmpId", SqlDbType.Int);
                m[9] = new SqlParameter("@UDF1", SqlDbType.Text);
                m[10] = new SqlParameter("@UDF2", SqlDbType.Text);
                m[11] = new SqlParameter("@UDF3", SqlDbType.Text);

                SqlHelper.ExecuteNonQuery(Connection.Connection_string, CommandType.StoredProcedure, "EmployeeSalary_Insert", m);
                MessageBox.Show("Request Submitted Successfully");
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text != string.Empty)
                {
                    SqlParameter[] m = new SqlParameter[2];
                    m[0] = new SqlParameter("@EmpId", Convert.ToInt32(txtid.Text.Trim()));
                    m[1] = new SqlParameter("@Name", txtEmpName.Text);
                   // m[2] = new SqlParameter("@BasicSalary", txtbasicsalary.Text);
                    SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "EmployeeInfo_SelectOneBySession", m);
                    while (dr.Read())
                    {
                        txtEmpName.Text = dr["Name"].ToString();
                       // txtbasicsalary.Text = dr["BasicSalary"].ToString();
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

