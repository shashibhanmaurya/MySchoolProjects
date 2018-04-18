using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution.Reports
{
    public partial class ProfitLossPrint : Form
    {
        public string Purpose { get; set; }
        public string Total { get; set; }
        public string Cash { get; set; }
        public string Cheque { get; set; }
        public string Paytm { get; set; }
        public string Card { get; set; }
        public string BankTransfer { get; set; }
        public ProfitLossPrint()
        {
            InitializeComponent();
        }

        private void ProfitLossPrint_Load(object sender, EventArgs e)
        {
            Reports.ProfitLossReport mr = new Reports.ProfitLossReport();
            CrystalDecisions.CrystalReports.Engine.TextObject txtPurpose = mr.ReportDefinition.ReportObjects["Purpose"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            CrystalDecisions.CrystalReports.Engine.TextObject txtTotal = mr.ReportDefinition.ReportObjects["txtTotal"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            CrystalDecisions.CrystalReports.Engine.TextObject txtCash = mr.ReportDefinition.ReportObjects["txtCash"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            CrystalDecisions.CrystalReports.Engine.TextObject txtCheque = mr.ReportDefinition.ReportObjects["txtCheque"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            CrystalDecisions.CrystalReports.Engine.TextObject txtPaytm = mr.ReportDefinition.ReportObjects["txtPaytm"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            CrystalDecisions.CrystalReports.Engine.TextObject txtCard = mr.ReportDefinition.ReportObjects["txtCard"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            CrystalDecisions.CrystalReports.Engine.TextObject txtBankTranfer = mr.ReportDefinition.ReportObjects["txtBankTransfer"] as CrystalDecisions.CrystalReports.Engine.TextObject;
           // CrystalDecisions.CrystalReports.Engine.TextObject txtPurpose = mr.ReportDefinition.ReportObjects["txtPurpose"] as CrystalDecisions.CrystalReports.Engine.TextObject;


            txtPurpose.Text = Purpose;
            txtTotal.Text = Total;
            txtCash.Text = Cash;
            txtCheque.Text = Cheque;
            txtPaytm.Text = Paytm;
            txtCard.Text = Card;
            txtBankTranfer.Text = BankTransfer;
            ProfitLossView.ReportSource = mr;

        }
    }
}
