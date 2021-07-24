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
    public partial class Certificates : Form
    {
        public Certificates()
        {
            InitializeComponent();
            lblSession.Text = CommonFunctions.GetCurrentSession;
        }

      

        private void GetStudentAutoComplete()
        {
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", lblSession.Text);
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "StudentInfoAutoComplete", m);
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            for (int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                MyCollection.Add(ds.Tables[0].Rows[i][0].ToString());
                
            }
            txtStudent.AutoCompleteCustomSource = MyCollection;
            //while (dr.Read())
            //{
            //    try
            //    {
            //        MyCollection.Add(dr.GetString(0));
            //        txtStudent.AutoCompleteCustomSource = MyCollection;
            //    }
            //    catch
            //    {


            //    }

            //}


        }

        private void Certificates_Load(object sender, EventArgs e)
        {
            GetStudentAutoComplete();
        }

        private void StudentwiseFeePrint_Click(object sender, EventArgs e)
        {
            int admissionNo = 0;
            DataSet ds = new DataSet();

            string[] chk = txtStudent.Text.Split('_');
            if (chk.Count() > 0)
            {
                admissionNo = Convert.ToInt32(chk.ElementAt(1));
               
                

            }
            if (GrpCertificate.Text== "Fee Certificate")
            {
                SqlParameter[] m = new SqlParameter[2];
                m[0] = new SqlParameter("@AdmissionNo", admissionNo);
                m[1] = new SqlParameter("@Session", lblSession.Text);

                ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "TutionFeeCertificate", m);

                Reports.CertificateView cv = new Reports.CertificateView();
                cv.purpose = "FeeCertificate";
                cv.dataSet = ds;
                cv.Show();
                this.Hide();
            }

            if (GrpCertificate.Text == "Birth Certificate")
            {
                SqlParameter[] m = new SqlParameter[2];
                m[0] = new SqlParameter("@AdmissionNo", admissionNo);
                m[1] = new SqlParameter("@Session", lblSession.Text);

                ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "SelectBirthCertificate", m);

                Reports.CertificateView cv = new Reports.CertificateView();
                cv.purpose = "BirthCertificate";
                cv.dataSet = ds;
                cv.Show();
                this.Hide();
            }
        }
    }
}
