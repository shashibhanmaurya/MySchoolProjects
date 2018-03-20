using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution
{
    public partial class HomeMenu : Form
    {
      
        public HomeMenu()
        {
            InitializeComponent();
            
           
        }
      
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudentEntry pr = new NewStudentEntry();
            string userName = lblUserName.Text.Replace("Welcome ", "");
            Control[] ctrl = pr.Controls.Find("lblUname", true);
            Label lblUname = (Label)ctrl.FirstOrDefault();
            lblUname.Text = userName;

            pr.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Students ne = new Students();
            //ne.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FeeDeposit fd = new FeeDeposit();
            string userName = lblUserName.Text.Replace("Welcome ", "");
            Control[] ctrl = fd.Controls.Find("lblUname", true);
            Label lblUname = (Label)ctrl.FirstOrDefault();
            lblUname.Text = userName;

            fd.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fee_Structure fs = new Fee_Structure();
            string userName = lblUserName.Text.Replace("Welcome ", "");
            Control[] ctrl = fs.Controls.Find("lblUname", true);
            Label lblUname = (Label)ctrl.FirstOrDefault();
            lblUname.Text = userName;

            fs.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            YearlyFeeEntry ne = new YearlyFeeEntry();
            string userName = lblUserName.Text.Replace("Welcome ", "");
            Control[] ctrl = ne.Controls.Find("lblUname", true);
            Label lblUname = (Label)ctrl.FirstOrDefault();
            lblUname.Text = userName;

            ne.Show(); ;
        }

        private void feeStructureListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeStructureList ne = new FeeStructureList();
            ne.Show();
        }

        private void otherExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses ne = new Expenses();
            ne.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EmployeeEntry ne = new EmployeeEntry();
            ne.Show();
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
            lblSession.Text = CommonFunctions.GetCurrentSession;
            
            Login l = new Login();
            DialogResult dr = l.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string AllowedMenu = l.AllowedMenu;
                lblUserName.Text = "Welcome " + l.username;
                string[] allowedMenuItems = AllowedMenu.Split(',');
                foreach (string allowedMenuItem in allowedMenuItems)
                {
                    menuStrip1.Items[allowedMenuItem].Enabled = true; ;
                }

                //foreach (ToolStripMenuItem toolItem in menuStrip1.Items)
                //{
                //    if (toolItem.Name == "masterToolStripMenuItem")
                //    {
                //        toolItem.Enabled = true;
                //    }


                //}

                l.Dispose();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            //this.Hide();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search ss = new Search();
            Control[] ctrl = ss.Controls.Find("grpSearchByName", true);
            GroupBox grpSearchByName = ctrl.FirstOrDefault() as GroupBox;
            grpSearchByName.Visible = true;
            ss.Show();

        }

        private void byFatherNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search ss = new Search();
            Control[] ctrl = ss.Controls.Find("grpSearchByFather", true);
            GroupBox grpSearchByFather = ctrl.FirstOrDefault() as GroupBox;
            grpSearchByFather.Visible = true;
            ss.Show();
        }

        private void byRollNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search ss = new Search();
            Control[] ctrl = ss.Controls.Find("grpRollNo", true);
            GroupBox grpRollNo = ctrl.FirstOrDefault() as GroupBox;
            grpRollNo.Visible = true;
            ss.Show();
        }

        private void admissionBetweenTwoDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search ss = new Search();
            Control[] ctrl = ss.Controls.Find("grpBetweenDates", true);
            GroupBox grpBetweenDates = ctrl.FirstOrDefault() as GroupBox;
            grpBetweenDates.Visible = true;
            ss.Show();
        }

        private void betweenTwoDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeSearch ss = new FeeSearch();
            Control[] ctrl = ss.Controls.Find("grpBetweenDates", true);
            GroupBox grpBetweenDates = ctrl.FirstOrDefault() as GroupBox;
            grpBetweenDates.Visible = true;
            ss.Show();

        }

        private void byClassAndSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeSearch ss = new FeeSearch();
            Control[] ctrl = ss.Controls.Find("groupSessionAndClass", true);
            GroupBox groupSessionAndClass = ctrl.FirstOrDefault() as GroupBox;
            groupSessionAndClass.Visible = true;
            ss.SearchFor = "SessionAndClass";
            ss.Show();

        }

        private void forASeesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeSearch ss = new FeeSearch();
            Control[] ctrl = ss.Controls.Find("groupSearchBySession", true);
            GroupBox groupSearchBySession = ctrl.FirstOrDefault() as GroupBox;
            groupSearchBySession.Visible = true;
            ss.SearchFor = "ForSession";
            ss.Show();

        }

        private void overAllCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeSearch ss = new FeeSearch();
            Control[] ctrl = ss.Controls.Find("groupSelectAll", true);
            GroupBox groupSelectAll = ctrl.FirstOrDefault() as GroupBox;
            groupSelectAll.Visible = true;
            ss.Show();

        }

        private void studentWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeSearch ss = new FeeSearch();
            Control[] ctrl = ss.Controls.Find("GrpStudentWiseFee", true);
            GroupBox GrpStudentWiseFee = ctrl.FirstOrDefault() as GroupBox;
            ss.SearchFor = "StudentWiseSearch";
            GrpStudentWiseFee.Visible = true;
            ss.Show();
        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            us.Show();
        }

        private void studentFeeStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeSearch ss = new FeeSearch();
            Control[] ctrl = ss.Controls.Find("GrpFeeStatementByClass", true);
            GroupBox GrpFeeStatementByClass = ctrl.FirstOrDefault() as GroupBox;
            GrpFeeStatementByClass.Visible = true;
            ss.SearchFor = "Statement";
            ss.Show();
        }

        private void dailyReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FeeSearch ss = new FeeSearch();
            Control[] ctrl1 = ss.Controls.Find("grpDailyCollection", true);
            GroupBox grpDailyCollection = ctrl1.FirstOrDefault() as GroupBox;
            grpDailyCollection.Visible = true;

            Control[] ctrl = ss.Controls.Find("gvSearchResult", true);
            DataGridView gvSearchResult = ctrl.FirstOrDefault() as DataGridView;
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Date", DateTime.Now.ToShortDateString());



            DataSet ds = SqlHelper.ExecuteDataset(Connection.Connection_string, "DailyFeeCollection", m);
            gvSearchResult.DataSource = ds.Tables[0];
            ss.Show();
        }

        private void reprintReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Reprint_Reciept pr = new Reports.Reprint_Reciept();
            pr.Show();

        }

        private void ChangePasswordMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword pr = new ChangePassword();
           string userName = lblUserName.Text.Replace("Welcome ","");
            Control[] ctrl = pr.Controls.Find("txtUserName",true);
            TextBox txtUserName = (TextBox)ctrl.FirstOrDefault();
            txtUserName.Text = userName;

            pr.Show();
        }

        private void PendingChequeMenuItem_Click(object sender, EventArgs e)
        {
            Cheques cq = new Cheques();
            cq.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Students st = new Students();
            st.Show();
        }
    }
}

