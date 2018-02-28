using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            DateTime dt = new DateTime();
            label4.Text = DateTime.Now.ToString();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudentEntry ne = new NewStudentEntry();
            ne.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students ne = new Students();
            ne.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FeeDeposit fd = new FeeDeposit();
            fd.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fee_Structure ne = new Fee_Structure();
            ne.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            YearlyFeeEntry ne = new YearlyFeeEntry();
            ne.Show();
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
    }
}

