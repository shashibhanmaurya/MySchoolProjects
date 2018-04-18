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
    public partial class Attendance : Form
    {

        public Attendance()
        {
            InitializeComponent();





        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            ddlClass.DataSource = CommonFunctions.GetClasses;
            lblSession.Text = CommonFunctions.GetCurrentSession;
            BindGridForAttendance();
        }
        private void BindGridForAttendance()
        {
            gvAttendance.DataSource = null;
            SqlParameter[] m = new SqlParameter[3];
            m[0] = new SqlParameter("@SearchPhrase", string.Empty);
            m[1] = new SqlParameter("@Class", this.ddlClass.SelectedItem);
            m[2] = new SqlParameter("@Session", lblSession.Text);

            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfo_SearchForFeeDeposit", m);
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvAttendance.DataSource = ds.Tables[0];
                for (int i = 0; i < gvAttendance.Rows.Count; i++)
                {
                    gvAttendance.Rows[i].Cells[0].Value = true;
                }
            }
        }
        private void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridForAttendance();
        }

        private void btnBounced_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Present_Click(object sender, EventArgs e)
        {
            SqlParameter[] m1 = new SqlParameter[3];
            m1[0] = new SqlParameter("@date", DateTime.Now.ToShortDateString());
            m1[1] = new SqlParameter("@Class", this.ddlClass.SelectedItem);
            m1[2] = new SqlParameter("@Session", lblSession.Text);
            int chk =Convert.ToInt32( SqlHelper.ExecuteScalar(Connection.Connection_string, "CheckByClassAndSession", m1));
            if (chk>0)
            {
                MessageBox.Show("Attendance for this class is already saved !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                bool status = false;
                for (int i = 0; i < gvAttendance.Rows.Count; i++)
                {

                    //if (Convert.ToBoolean(gvAttendance.Rows[i].Cells[0].Value) == true)
                    //{
                    SqlParameter[] m = new SqlParameter[5];
                    m[0] = new SqlParameter("@Admission_Number", Convert.ToInt32(gvAttendance.Rows[i].Cells["Addmission_Number"].Value));
                    m[1] = new SqlParameter("@Session", lblSession.Text);
                    m[2] = new SqlParameter("@Class", this.ddlClass.SelectedItem);

                    // m[3] = new SqlParameter("@Attendance", gvAttendance.Rows[i].Cells[0].Value);
                    if (Convert.ToBoolean(gvAttendance.Rows[i].Cells[0].Value) == true)
                    {
                        m[3] = new SqlParameter("@Attendance", "P");
                    }
                    else
                    {
                        m[3] = new SqlParameter("@Attendance", "A");
                    }
                    m[4] = new SqlParameter("@CrateDate", DateTime.Now);

                    int aa = SqlHelper.ExecuteNonQuery(Connection.Connection_string, "AttendanceInsert", m);
                    status = true;

                    //int StdId = Convert.ToInt32(gvAttendance.Rows[i].Cells[1].Value);
                    //using (SqlConnection con = Connection.Connection_string)
                    //{
                    //    SqlCommand cmd = new SqlCommand("update tbl_Attendance set UDF3='P' where StdId=" + StdId + "", con);
                    //    con.Open();
                    //    cmd.ExecuteNonQuery();
                    //    con.Close();
                    //}

                    // }

                }
                if (status == true)
                {
                    MessageBox.Show("Attendance saved for class " + ddlClass.Text + "");
                }
            }
        }

        private void ddlClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;



        }
    }
}
