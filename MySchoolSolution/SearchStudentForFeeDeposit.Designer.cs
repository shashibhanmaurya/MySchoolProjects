namespace MySchoolSolution
{
    partial class SearchStudentForFeeDeposit
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(307, 8);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(49, 13);
            this.lblSession.TabIndex = 0;
            this.lblSession.Text = "session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            // 
            // comboClass
            // 
            this.comboClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Location = new System.Drawing.Point(336, 40);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(121, 21);
            this.comboClass.TabIndex = 3;
            this.comboClass.SelectedIndexChanged += new System.EventHandler(this.comboClass_SelectedIndexChanged);
            // 
            // gvStudents
            // 
            this.gvStudents.AllowUserToAddRows = false;
            this.gvStudents.AllowUserToDeleteRows = false;
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Location = new System.Drawing.Point(3, 104);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.ReadOnly = true;
            this.gvStudents.Size = new System.Drawing.Size(712, 336);
            this.gvStudents.TabIndex = 4;
            this.gvStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudents_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(336, 67);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(121, 20);
            this.txtStudentName.TabIndex = 6;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // SearchStudentForFeeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 452);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvStudents);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSession);
            this.Name = "SearchStudentForFeeDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchStudentForFeeDeposit";
            this.Load += new System.EventHandler(this.SearchStudentForFeeDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
    }
}