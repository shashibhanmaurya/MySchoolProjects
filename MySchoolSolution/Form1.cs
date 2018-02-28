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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime dt = new DateTime();
            label3.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudentEntry ne = new NewStudentEntry();
            ne.Show();
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

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students ne = new Students();
            ne.Show();
        }

        private void feeStructureListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeStructureList ne = new FeeStructureList();
            ne.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FeeDeposit fd = new FeeDeposit();
            fd.Show();
        }

        private void otherExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses fd = new Expenses();
            fd.Show();
        }
    }
}
