namespace MySchoolSolution.Reports
{
    partial class FeeStatementWithAmountDue
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
            this.rvFeeStatement = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rvFeeStatement
            // 
            this.rvFeeStatement.ActiveViewIndex = -1;
            this.rvFeeStatement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rvFeeStatement.Cursor = System.Windows.Forms.Cursors.Default;
            this.rvFeeStatement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvFeeStatement.Location = new System.Drawing.Point(0, 0);
            this.rvFeeStatement.Name = "rvFeeStatement";
            this.rvFeeStatement.ShowGroupTreeButton = false;
            this.rvFeeStatement.Size = new System.Drawing.Size(284, 261);
            this.rvFeeStatement.TabIndex = 1;
            this.rvFeeStatement.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FeeStatementWithAmountDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rvFeeStatement);
            this.Name = "FeeStatementWithAmountDue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeeStatementWithAmountDue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FeeStatementWithAmountDue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rvFeeStatement;
    }
}