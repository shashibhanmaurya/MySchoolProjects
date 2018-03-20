namespace MySchoolSolution
{
    partial class chk
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
            this.GrpStudentWiseFee = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.GrpStudentWiseFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpStudentWiseFee
            // 
            this.GrpStudentWiseFee.BackColor = System.Drawing.SystemColors.Control;
            this.GrpStudentWiseFee.Controls.Add(this.label7);
            this.GrpStudentWiseFee.Controls.Add(this.txtStudent);
            this.GrpStudentWiseFee.Controls.Add(this.button3);
            this.GrpStudentWiseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpStudentWiseFee.Location = new System.Drawing.Point(96, 38);
            this.GrpStudentWiseFee.Name = "GrpStudentWiseFee";
            this.GrpStudentWiseFee.Size = new System.Drawing.Size(368, 187);
            this.GrpStudentWiseFee.TabIndex = 157;
            this.GrpStudentWiseFee.TabStop = false;
            this.GrpStudentWiseFee.Text = "Student Fee Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 157;
            this.label7.Text = "Student";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(104, 32);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(130, 23);
            this.txtStudent.TabIndex = 156;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(142, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 33);
            this.button3.TabIndex = 155;
            this.button3.Text = "Print";
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 386);
            this.Controls.Add(this.GrpStudentWiseFee);
            this.Name = "chk";
            this.Text = "chk";
            this.Load += new System.EventHandler(this.chk_Load);
            this.GrpStudentWiseFee.ResumeLayout(false);
            this.GrpStudentWiseFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpStudentWiseFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button button3;
    }
}