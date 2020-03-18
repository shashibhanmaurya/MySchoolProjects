namespace MySchoolSolution
{
    partial class FeeStatementByMonthAndClassForASession
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
            this.lblSession = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboClassForStatement = new System.Windows.Forms.ComboBox();
            this.GrpFeeStatementByClass = new System.Windows.Forms.GroupBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.DTMonth = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gvSearchResult = new System.Windows.Forms.DataGridView();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.checkStudent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GrpFeeStatementByClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(179, 23);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(56, 17);
            this.lblSession.TabIndex = 2;
            this.lblSession.Text = "session";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Class:";
            // 
            // comboClassForStatement
            // 
            this.comboClassForStatement.FormattingEnabled = true;
            this.comboClassForStatement.Location = new System.Drawing.Point(236, 60);
            this.comboClassForStatement.Name = "comboClassForStatement";
            this.comboClassForStatement.Size = new System.Drawing.Size(142, 24);
            this.comboClassForStatement.TabIndex = 0;
            this.comboClassForStatement.SelectedIndexChanged += new System.EventHandler(this.comboClassForStatement_SelectedIndexChanged);
            // 
            // GrpFeeStatementByClass
            // 
            this.GrpFeeStatementByClass.Controls.Add(this.txtMonth);
            this.GrpFeeStatementByClass.Controls.Add(this.DTMonth);
            this.GrpFeeStatementByClass.Controls.Add(this.btnPrint);
            this.GrpFeeStatementByClass.Controls.Add(this.lblSession);
            this.GrpFeeStatementByClass.Controls.Add(this.label5);
            this.GrpFeeStatementByClass.Controls.Add(this.comboClassForStatement);
            this.GrpFeeStatementByClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpFeeStatementByClass.Location = new System.Drawing.Point(260, 33);
            this.GrpFeeStatementByClass.Name = "GrpFeeStatementByClass";
            this.GrpFeeStatementByClass.Size = new System.Drawing.Size(470, 193);
            this.GrpFeeStatementByClass.TabIndex = 170;
            this.GrpFeeStatementByClass.TabStop = false;
            this.GrpFeeStatementByClass.Text = "Fee Statement by Class";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(236, 101);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(128, 23);
            this.txtMonth.TabIndex = 156;
            // 
            // DTMonth
            // 
            this.DTMonth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTMonth.Location = new System.Drawing.Point(360, 101);
            this.DTMonth.Name = "DTMonth";
            this.DTMonth.Size = new System.Drawing.Size(19, 23);
            this.DTMonth.TabIndex = 155;
            this.DTMonth.ValueChanged += new System.EventHandler(this.DTMonth_ValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Location = new System.Drawing.Point(192, 136);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 33);
            this.btnPrint.TabIndex = 154;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseCompatibleTextRendering = true;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gvSearchResult
            // 
            this.gvSearchResult.AllowUserToAddRows = false;
            this.gvSearchResult.AllowUserToDeleteRows = false;
            this.gvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkStudent});
            this.gvSearchResult.Location = new System.Drawing.Point(96, 240);
            this.gvSearchResult.Name = "gvSearchResult";
            this.gvSearchResult.Size = new System.Drawing.Size(851, 259);
            this.gvSearchResult.TabIndex = 169;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendMail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSendMail.Location = new System.Drawing.Point(799, 505);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(148, 33);
            this.btnSendMail.TabIndex = 171;
            this.btnSendMail.Text = "Send Message";
            this.btnSendMail.UseCompatibleTextRendering = true;
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // checkStudent
            // 
            this.checkStudent.HeaderText = "Select";
            this.checkStudent.Name = "checkStudent";
            // 
            // FeeStatementByMonthAndClassForASession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 587);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.GrpFeeStatementByClass);
            this.Controls.Add(this.gvSearchResult);
            this.Name = "FeeStatementByMonthAndClassForASession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeeStatementByMonthAndClassForASession";
            this.Load += new System.EventHandler(this.FeeStatementByMonthAndClassForASession_Load);
            this.GrpFeeStatementByClass.ResumeLayout(false);
            this.GrpFeeStatementByClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboClassForStatement;
        private System.Windows.Forms.GroupBox GrpFeeStatementByClass;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView gvSearchResult;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.DateTimePicker DTMonth;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkStudent;
    }
}