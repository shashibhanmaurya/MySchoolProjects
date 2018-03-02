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
   
    public partial class CheckSiblingDetails : Form
    {
        public int siblingNo { get; set; }
        public CheckSiblingDetails()
        {
            InitializeComponent();
            
        }

        private void BindgridForSibling()
        {
            SqlParameter[] m = new SqlParameter[2];
            m[0] = new SqlParameter("@Session", lblSession.Text);
            m[1] = new SqlParameter("@Sibling", txtSiblingNo.Text);
            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "GetSiblingNumberBySession", m);
            if (ds.Tables[0].Rows.Count > 0)
            {
                gvSibling.DataSource = ds.Tables[0];
            }
        }

        private void CheckSiblingDetails_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
           
            if (siblingNo > 0)
            {
                txtSiblingNo.Text = siblingNo.ToString();
            }
            BindgridForSibling();
        }

        private void gvSibling_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int admissionNo = Convert.ToInt32(gvSibling.Rows[e.RowIndex].Cells["Addmission_Number"].Value);
                FeeDeposit fd = new FeeDeposit();
                fd.AdmissionNo = admissionNo;
                fd.Show();
                this.Close();
            }
        }
    }
}
