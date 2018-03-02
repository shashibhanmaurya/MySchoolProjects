namespace MySchoolSolution
{
    partial class CheckSiblingDetails
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
            this.gvSibling = new System.Windows.Forms.DataGridView();
            this.txtSiblingNo = new System.Windows.Forms.TextBox();
            this.lblSession = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvSibling)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSibling
            // 
            this.gvSibling.AllowUserToAddRows = false;
            this.gvSibling.AllowUserToDeleteRows = false;
            this.gvSibling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSibling.Location = new System.Drawing.Point(87, 45);
            this.gvSibling.Name = "gvSibling";
            this.gvSibling.ReadOnly = true;
            this.gvSibling.Size = new System.Drawing.Size(355, 174);
            this.gvSibling.TabIndex = 6;
            this.gvSibling.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSibling_CellDoubleClick);
            // 
            // txtSiblingNo
            // 
            this.txtSiblingNo.Location = new System.Drawing.Point(218, 8);
            this.txtSiblingNo.Name = "txtSiblingNo";
            this.txtSiblingNo.Size = new System.Drawing.Size(100, 20);
            this.txtSiblingNo.TabIndex = 224;
            this.txtSiblingNo.Visible = false;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(324, 11);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(49, 13);
            this.lblSession.TabIndex = 223;
            this.lblSession.Text = "session";
            // 
            // CheckSiblingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 262);
            this.Controls.Add(this.txtSiblingNo);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.gvSibling);
            this.Name = "CheckSiblingDetails";
            this.Text = "CheckSiblingDetails";
            this.Load += new System.EventHandler(this.CheckSiblingDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSibling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSibling;
        private System.Windows.Forms.TextBox txtSiblingNo;
        private System.Windows.Forms.Label lblSession;
    }
}