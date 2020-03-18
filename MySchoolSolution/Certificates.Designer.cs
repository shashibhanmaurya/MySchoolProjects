namespace MySchoolSolution
{
    partial class Certificates
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
            this.GrpCertificate = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.StudentwiseFeePrint = new System.Windows.Forms.Button();
            this.lblSession = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpCertificate.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpCertificate
            // 
            this.GrpCertificate.BackColor = System.Drawing.SystemColors.Control;
            this.GrpCertificate.Controls.Add(this.label2);
            this.GrpCertificate.Controls.Add(this.lblSession);
            this.GrpCertificate.Controls.Add(this.label7);
            this.GrpCertificate.Controls.Add(this.txtStudent);
            this.GrpCertificate.Controls.Add(this.StudentwiseFeePrint);
            this.GrpCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCertificate.Location = new System.Drawing.Point(165, 59);
            this.GrpCertificate.Name = "GrpCertificate";
            this.GrpCertificate.Size = new System.Drawing.Size(368, 187);
            this.GrpCertificate.TabIndex = 163;
            this.GrpCertificate.TabStop = false;
            this.GrpCertificate.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 157;
            this.label7.Text = "Student";
            // 
            // txtStudent
            // 
            this.txtStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStudent.Location = new System.Drawing.Point(104, 74);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(238, 23);
            this.txtStudent.TabIndex = 156;
            // 
            // StudentwiseFeePrint
            // 
            this.StudentwiseFeePrint.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.StudentwiseFeePrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StudentwiseFeePrint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentwiseFeePrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentwiseFeePrint.Location = new System.Drawing.Point(136, 113);
            this.StudentwiseFeePrint.Name = "StudentwiseFeePrint";
            this.StudentwiseFeePrint.Size = new System.Drawing.Size(92, 33);
            this.StudentwiseFeePrint.TabIndex = 155;
            this.StudentwiseFeePrint.Text = "Print";
            this.StudentwiseFeePrint.UseCompatibleTextRendering = true;
            this.StudentwiseFeePrint.UseVisualStyleBackColor = true;
            this.StudentwiseFeePrint.Click += new System.EventHandler(this.StudentwiseFeePrint_Click);
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(101, 31);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(58, 17);
            this.lblSession.TabIndex = 158;
            this.lblSession.Text = "Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 159;
            this.label2.Text = "Session";
            // 
            // Certificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 531);
            this.Controls.Add(this.GrpCertificate);
            this.Name = "Certificates";
            this.Text = "Certificates";
            this.Load += new System.EventHandler(this.Certificates_Load);
            this.GrpCertificate.ResumeLayout(false);
            this.GrpCertificate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpCertificate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button StudentwiseFeePrint;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label label2;
    }
}