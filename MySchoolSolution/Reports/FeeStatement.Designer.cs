﻿namespace MySchoolSolution.Reports
{
    partial class FeeStatement
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
            this.rvFeeStatement.Size = new System.Drawing.Size(284, 262);
            this.rvFeeStatement.TabIndex = 0;
            // 
            // FeeStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rvFeeStatement);
            this.Name = "FeeStatement";
            this.Text = "FeeStatement";
            this.Load += new System.EventHandler(this.FeeStatement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rvFeeStatement;
    }
}