namespace MySchoolSolution
{
    partial class Search
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
            this.grpBetweenDates = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvSearchResult = new System.Windows.Forms.DataGridView();
            this.grpSearchByName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSearchByFather = new System.Windows.Forms.GroupBox();
            this.tctFatherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpRollNo = new System.Windows.Forms.GroupBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.RollNo = new System.Windows.Forms.Label();
            this.grpAdmissionNo = new System.Windows.Forms.GroupBox();
            this.txtAdmissionNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBetweenDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).BeginInit();
            this.grpSearchByName.SuspendLayout();
            this.grpSearchByFather.SuspendLayout();
            this.grpRollNo.SuspendLayout();
            this.grpAdmissionNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBetweenDates
            // 
            this.grpBetweenDates.BackColor = System.Drawing.SystemColors.Control;
            this.grpBetweenDates.Controls.Add(this.btnSearch);
            this.grpBetweenDates.Controls.Add(this.dtTo);
            this.grpBetweenDates.Controls.Add(this.dtFrom);
            this.grpBetweenDates.Controls.Add(this.label2);
            this.grpBetweenDates.Controls.Add(this.label1);
            this.grpBetweenDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBetweenDates.Location = new System.Drawing.Point(257, 12);
            this.grpBetweenDates.Name = "grpBetweenDates";
            this.grpBetweenDates.Size = new System.Drawing.Size(368, 187);
            this.grpBetweenDates.TabIndex = 0;
            this.grpBetweenDates.TabStop = false;
            this.grpBetweenDates.Text = "Search Between Dates";
            this.grpBetweenDates.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(143, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 155;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseCompatibleTextRendering = true;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(143, 95);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(126, 23);
            this.dtTo.TabIndex = 5;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(143, 52);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(126, 23);
            this.dtFrom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // gvSearchResult
            // 
            this.gvSearchResult.AllowUserToAddRows = false;
            this.gvSearchResult.AllowUserToDeleteRows = false;
            this.gvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearchResult.Location = new System.Drawing.Point(12, 223);
            this.gvSearchResult.Name = "gvSearchResult";
            this.gvSearchResult.ReadOnly = true;
            this.gvSearchResult.Size = new System.Drawing.Size(851, 275);
            this.gvSearchResult.TabIndex = 1;
            // 
            // grpSearchByName
            // 
            this.grpSearchByName.BackColor = System.Drawing.SystemColors.Control;
            this.grpSearchByName.Controls.Add(this.txtName);
            this.grpSearchByName.Controls.Add(this.label4);
            this.grpSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchByName.Location = new System.Drawing.Point(256, 11);
            this.grpSearchByName.Name = "grpSearchByName";
            this.grpSearchByName.Size = new System.Drawing.Size(368, 187);
            this.grpSearchByName.TabIndex = 2;
            this.grpSearchByName.TabStop = false;
            this.grpSearchByName.Text = "Search by Name";
            this.grpSearchByName.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // grpSearchByFather
            // 
            this.grpSearchByFather.BackColor = System.Drawing.SystemColors.Control;
            this.grpSearchByFather.Controls.Add(this.tctFatherName);
            this.grpSearchByFather.Controls.Add(this.label3);
            this.grpSearchByFather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchByFather.Location = new System.Drawing.Point(255, 10);
            this.grpSearchByFather.Name = "grpSearchByFather";
            this.grpSearchByFather.Size = new System.Drawing.Size(368, 187);
            this.grpSearchByFather.TabIndex = 3;
            this.grpSearchByFather.TabStop = false;
            this.grpSearchByFather.Text = "Search by Father";
            this.grpSearchByFather.Visible = false;
            // 
            // tctFatherName
            // 
            this.tctFatherName.Location = new System.Drawing.Point(161, 77);
            this.tctFatherName.Name = "tctFatherName";
            this.tctFatherName.Size = new System.Drawing.Size(149, 23);
            this.tctFatherName.TabIndex = 2;
            this.tctFatherName.TextChanged += new System.EventHandler(this.tctFatherName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Father Name";
            // 
            // grpRollNo
            // 
            this.grpRollNo.BackColor = System.Drawing.SystemColors.Control;
            this.grpRollNo.Controls.Add(this.txtRollNo);
            this.grpRollNo.Controls.Add(this.RollNo);
            this.grpRollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRollNo.Location = new System.Drawing.Point(249, 30);
            this.grpRollNo.Name = "grpRollNo";
            this.grpRollNo.Size = new System.Drawing.Size(368, 187);
            this.grpRollNo.TabIndex = 4;
            this.grpRollNo.TabStop = false;
            this.grpRollNo.Text = "Search by Roll Number";
            this.grpRollNo.Visible = false;
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(161, 77);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(149, 23);
            this.txtRollNo.TabIndex = 2;
            this.txtRollNo.TextChanged += new System.EventHandler(this.txtRollNo_TextChanged);
            // 
            // RollNo
            // 
            this.RollNo.AutoSize = true;
            this.RollNo.Location = new System.Drawing.Point(58, 80);
            this.RollNo.Name = "RollNo";
            this.RollNo.Size = new System.Drawing.Size(86, 17);
            this.RollNo.TabIndex = 1;
            this.RollNo.Text = "Roll Number";
            // 
            // grpAdmissionNo
            // 
            this.grpAdmissionNo.BackColor = System.Drawing.SystemColors.Control;
            this.grpAdmissionNo.Controls.Add(this.txtAdmissionNo);
            this.grpAdmissionNo.Controls.Add(this.label5);
            this.grpAdmissionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdmissionNo.Location = new System.Drawing.Point(228, 52);
            this.grpAdmissionNo.Name = "grpAdmissionNo";
            this.grpAdmissionNo.Size = new System.Drawing.Size(368, 187);
            this.grpAdmissionNo.TabIndex = 5;
            this.grpAdmissionNo.TabStop = false;
            this.grpAdmissionNo.Text = "Search by Roll Number";
            this.grpAdmissionNo.Visible = false;
            // 
            // txtAdmissionNo
            // 
            this.txtAdmissionNo.Location = new System.Drawing.Point(186, 77);
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.Size = new System.Drawing.Size(149, 23);
            this.txtAdmissionNo.TabIndex = 2;
            this.txtAdmissionNo.TextChanged += new System.EventHandler(this.txtAdmissionNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Admission Number";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 510);
            this.Controls.Add(this.grpAdmissionNo);
            this.Controls.Add(this.grpRollNo);
            this.Controls.Add(this.grpSearchByFather);
            this.Controls.Add(this.grpSearchByName);
            this.Controls.Add(this.gvSearchResult);
            this.Controls.Add(this.grpBetweenDates);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.grpBetweenDates.ResumeLayout(false);
            this.grpBetweenDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).EndInit();
            this.grpSearchByName.ResumeLayout(false);
            this.grpSearchByName.PerformLayout();
            this.grpSearchByFather.ResumeLayout(false);
            this.grpSearchByFather.PerformLayout();
            this.grpRollNo.ResumeLayout(false);
            this.grpRollNo.PerformLayout();
            this.grpAdmissionNo.ResumeLayout(false);
            this.grpAdmissionNo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBetweenDates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gvSearchResult;
        private System.Windows.Forms.GroupBox grpSearchByName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpSearchByFather;
        private System.Windows.Forms.TextBox tctFatherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpRollNo;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label RollNo;
        private System.Windows.Forms.GroupBox grpAdmissionNo;
        private System.Windows.Forms.TextBox txtAdmissionNo;
        private System.Windows.Forms.Label label5;
    }
}