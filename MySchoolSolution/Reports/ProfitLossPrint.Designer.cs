namespace MySchoolSolution.Reports
{
    partial class ProfitLossPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProfitLossView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ProfitLossView
            // 
            this.ProfitLossView.ActiveViewIndex = -1;
            this.ProfitLossView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfitLossView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProfitLossView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfitLossView.Location = new System.Drawing.Point(0, 0);
            this.ProfitLossView.Name = "ProfitLossView";
            this.ProfitLossView.Size = new System.Drawing.Size(284, 262);
            this.ProfitLossView.TabIndex = 0;
            // 
            // ProfitLossPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ProfitLossView);
            this.Name = "ProfitLossPrint";
            this.Text = "ProfitLossPrint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProfitLossPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ProfitLossView;
    }
}