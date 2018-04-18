namespace MySchoolSolution
{
    partial class StudentPromotion
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
            this.lstCurrentClassStudent = new System.Windows.Forms.CheckedListBox();
            this.lstPromotedStudent = new System.Windows.Forms.ListBox();
            this.btnPromote = new System.Windows.Forms.Button();
            this.grpCurrentClass = new System.Windows.Forms.GroupBox();
            this.lblSession = new System.Windows.Forms.Label();
            this.ddlCurrentClass = new System.Windows.Forms.ComboBox();
            this.grpPromotedClass = new System.Windows.Forms.GroupBox();
            this.lblPromotedSession = new System.Windows.Forms.Label();
            this.ddlPromotingClass = new System.Windows.Forms.ComboBox();
            this.btnDemote = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBounced = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.grpCurrentClass.SuspendLayout();
            this.grpPromotedClass.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCurrentClassStudent
            // 
            this.lstCurrentClassStudent.CheckOnClick = true;
            this.lstCurrentClassStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCurrentClassStudent.FormattingEnabled = true;
            this.lstCurrentClassStudent.Location = new System.Drawing.Point(21, 47);
            this.lstCurrentClassStudent.Margin = new System.Windows.Forms.Padding(4);
            this.lstCurrentClassStudent.Name = "lstCurrentClassStudent";
            this.lstCurrentClassStudent.Size = new System.Drawing.Size(260, 418);
            this.lstCurrentClassStudent.Sorted = true;
            this.lstCurrentClassStudent.TabIndex = 0;
            // 
            // lstPromotedStudent
            // 
            this.lstPromotedStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPromotedStudent.FormattingEnabled = true;
            this.lstPromotedStudent.ItemHeight = 16;
            this.lstPromotedStudent.Location = new System.Drawing.Point(19, 47);
            this.lstPromotedStudent.Margin = new System.Windows.Forms.Padding(4);
            this.lstPromotedStudent.Name = "lstPromotedStudent";
            this.lstPromotedStudent.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPromotedStudent.Size = new System.Drawing.Size(265, 420);
            this.lstPromotedStudent.Sorted = true;
            this.lstPromotedStudent.TabIndex = 1;
            // 
            // btnPromote
            // 
            this.btnPromote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPromote.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnPromote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromote.ForeColor = System.Drawing.Color.White;
            this.btnPromote.Location = new System.Drawing.Point(399, 269);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(42, 27);
            this.btnPromote.TabIndex = 8;
            this.btnPromote.Text = ">>";
            this.btnPromote.UseVisualStyleBackColor = false;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // grpCurrentClass
            // 
            this.grpCurrentClass.Controls.Add(this.lblSession);
            this.grpCurrentClass.Controls.Add(this.ddlCurrentClass);
            this.grpCurrentClass.Controls.Add(this.lstCurrentClassStudent);
            this.grpCurrentClass.Location = new System.Drawing.Point(77, 53);
            this.grpCurrentClass.Name = "grpCurrentClass";
            this.grpCurrentClass.Size = new System.Drawing.Size(303, 486);
            this.grpCurrentClass.TabIndex = 9;
            this.grpCurrentClass.TabStop = false;
            this.grpCurrentClass.Text = "Current Class";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(223, 20);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(56, 17);
            this.lblSession.TabIndex = 3;
            this.lblSession.Text = "session";
            // 
            // ddlCurrentClass
            // 
            this.ddlCurrentClass.BackColor = System.Drawing.Color.White;
            this.ddlCurrentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCurrentClass.ForeColor = System.Drawing.Color.Black;
            this.ddlCurrentClass.FormattingEnabled = true;
            this.ddlCurrentClass.Items.AddRange(new object[] {
            "Mike Gold",
            "Sivaraman",
            "Harshit viyas",
            "Deepak",
            "Jetendra"});
            this.ddlCurrentClass.Location = new System.Drawing.Point(96, 16);
            this.ddlCurrentClass.Name = "ddlCurrentClass";
            this.ddlCurrentClass.Size = new System.Drawing.Size(100, 24);
            this.ddlCurrentClass.TabIndex = 2;
            this.ddlCurrentClass.SelectedIndexChanged += new System.EventHandler(this.ddlCurrentClass_SelectedIndexChanged);
            // 
            // grpPromotedClass
            // 
            this.grpPromotedClass.Controls.Add(this.lblPromotedSession);
            this.grpPromotedClass.Controls.Add(this.ddlPromotingClass);
            this.grpPromotedClass.Controls.Add(this.lstPromotedStudent);
            this.grpPromotedClass.Location = new System.Drawing.Point(468, 53);
            this.grpPromotedClass.Name = "grpPromotedClass";
            this.grpPromotedClass.Size = new System.Drawing.Size(303, 486);
            this.grpPromotedClass.TabIndex = 10;
            this.grpPromotedClass.TabStop = false;
            this.grpPromotedClass.Text = "Promoting Class";
            // 
            // lblPromotedSession
            // 
            this.lblPromotedSession.AutoSize = true;
            this.lblPromotedSession.Location = new System.Drawing.Point(203, 20);
            this.lblPromotedSession.Name = "lblPromotedSession";
            this.lblPromotedSession.Size = new System.Drawing.Size(56, 17);
            this.lblPromotedSession.TabIndex = 4;
            this.lblPromotedSession.Text = "session";
            // 
            // ddlPromotingClass
            // 
            this.ddlPromotingClass.BackColor = System.Drawing.Color.White;
            this.ddlPromotingClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPromotingClass.Enabled = false;
            this.ddlPromotingClass.ForeColor = System.Drawing.Color.Black;
            this.ddlPromotingClass.FormattingEnabled = true;
            this.ddlPromotingClass.Items.AddRange(new object[] {
            "Mike Gold",
            "Sivaraman",
            "Harshit viyas",
            "Deepak",
            "Jetendra"});
            this.ddlPromotingClass.Location = new System.Drawing.Point(86, 16);
            this.ddlPromotingClass.Name = "ddlPromotingClass";
            this.ddlPromotingClass.Size = new System.Drawing.Size(100, 24);
            this.ddlPromotingClass.TabIndex = 2;
            // 
            // btnDemote
            // 
            this.btnDemote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDemote.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnDemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemote.ForeColor = System.Drawing.Color.White;
            this.btnDemote.Location = new System.Drawing.Point(399, 320);
            this.btnDemote.Name = "btnDemote";
            this.btnDemote.Size = new System.Drawing.Size(42, 27);
            this.btnDemote.TabIndex = 11;
            this.btnDemote.Text = "<<";
            this.btnDemote.UseVisualStyleBackColor = false;
            this.btnDemote.Click += new System.EventHandler(this.btnDemote_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnBounced);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(303, 541);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 69);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btnBounced
            // 
            this.btnBounced.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnBounced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBounced.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBounced.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBounced.Location = new System.Drawing.Point(173, 23);
            this.btnBounced.Name = "btnBounced";
            this.btnBounced.Size = new System.Drawing.Size(75, 33);
            this.btnBounced.TabIndex = 203;
            this.btnBounced.Text = "Exit";
            this.btnBounced.UseCompatibleTextRendering = true;
            this.btnBounced.UseVisualStyleBackColor = true;
            this.btnBounced.Click += new System.EventHandler(this.btnBounced_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Save.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Location = new System.Drawing.Point(76, 23);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 33);
            this.btn_Save.TabIndex = 202;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseCompatibleTextRendering = true;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // StudentPromotion
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDemote);
            this.Controls.Add(this.grpPromotedClass);
            this.Controls.Add(this.grpCurrentClass);
            this.Controls.Add(this.btnPromote);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentPromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPromotion";
            this.Load += new System.EventHandler(this.StudentPromotion_Load);
            this.grpCurrentClass.ResumeLayout(false);
            this.grpCurrentClass.PerformLayout();
            this.grpPromotedClass.ResumeLayout(false);
            this.grpPromotedClass.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstCurrentClassStudent;
        private System.Windows.Forms.ListBox lstPromotedStudent;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.GroupBox grpCurrentClass;
        private System.Windows.Forms.ComboBox ddlCurrentClass;
        private System.Windows.Forms.GroupBox grpPromotedClass;
        private System.Windows.Forms.ComboBox ddlPromotingClass;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Button btnDemote;
        private System.Windows.Forms.Label lblPromotedSession;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBounced;
        private System.Windows.Forms.Button btn_Save;
    }
}