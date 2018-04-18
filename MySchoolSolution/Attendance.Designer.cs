namespace MySchoolSolution
{
    partial class Attendance
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
            this.gvAttendance = new System.Windows.Forms.DataGridView();
            this.Present = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ddlClass = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBounced = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lblSession = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttendance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvAttendance
            // 
            this.gvAttendance.AllowUserToAddRows = false;
            this.gvAttendance.AllowUserToDeleteRows = false;
            this.gvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Present});
            this.gvAttendance.Location = new System.Drawing.Point(12, 75);
            this.gvAttendance.Name = "gvAttendance";
            this.gvAttendance.Size = new System.Drawing.Size(785, 355);
            this.gvAttendance.TabIndex = 1;
            // 
            // Present
            // 
            this.Present.FalseValue = "false";
            this.Present.HeaderText = "Attendance";
            this.Present.Name = "Present";
            this.Present.TrueValue = "true";
            // 
            // ddlClass
            // 
            this.ddlClass.FormattingEnabled = true;
            this.ddlClass.Location = new System.Drawing.Point(316, 37);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(185, 21);
            this.ddlClass.TabIndex = 2;
            this.ddlClass.Text = "--Select--";
            this.ddlClass.SelectedIndexChanged += new System.EventHandler(this.ddlClass_SelectedIndexChanged);
            this.ddlClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ddlClass_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(228, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 168;
            this.label10.Text = "Select Class :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 169;
            this.label1.Text = "Daily Attendance";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnBounced);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(249, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 69);
            this.groupBox1.TabIndex = 170;
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
            this.btn_Save.Click += new System.EventHandler(this.btn_Present_Click);
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(553, 24);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(49, 13);
            this.lblSession.TabIndex = 224;
            this.lblSession.Text = "session";
            this.lblSession.Visible = false;
            // 
            // Attendance
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 504);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ddlClass);
            this.Controls.Add(this.gvAttendance);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAttendance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvAttendance;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBounced;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Present;
    }
}