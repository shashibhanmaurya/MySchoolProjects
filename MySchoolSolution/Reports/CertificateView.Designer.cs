namespace MySchoolSolution.Reports
{
    partial class CertificateView
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
            this.CertificateViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CertificateViewer
            // 
            this.CertificateViewer.ActiveViewIndex = -1;
            this.CertificateViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CertificateViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CertificateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CertificateViewer.Location = new System.Drawing.Point(0, 0);
            this.CertificateViewer.Name = "CertificateViewer";
            this.CertificateViewer.Size = new System.Drawing.Size(284, 261);
            this.CertificateViewer.TabIndex = 0;
            this.CertificateViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // CertificateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CertificateViewer);
            this.Name = "CertificateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Certificate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CertificateViewer;
    }
}