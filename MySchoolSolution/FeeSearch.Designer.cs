namespace MySchoolSolution
{
    partial class FeeSearch
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
            this.groupSessionAndClass = new System.Windows.Forms.GroupBox();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.comboSession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupSearchBySession = new System.Windows.Forms.GroupBox();
            this.comboSession1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupSelectAll = new System.Windows.Forms.GroupBox();
            this.GrpFeeStatementByClass = new System.Windows.Forms.GroupBox();
            this.comboClassForStatement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpDailyCollection = new System.Windows.Forms.GroupBox();
            this.btnDailyCollectionPrint = new System.Windows.Forms.Button();
            this.grpBetweenDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).BeginInit();
            this.groupSessionAndClass.SuspendLayout();
            this.groupSearchBySession.SuspendLayout();
            this.GrpFeeStatementByClass.SuspendLayout();
            this.grpDailyCollection.SuspendLayout();
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
            this.grpBetweenDates.Location = new System.Drawing.Point(254, 8);
            this.grpBetweenDates.Name = "grpBetweenDates";
            this.grpBetweenDates.Size = new System.Drawing.Size(368, 187);
            this.grpBetweenDates.TabIndex = 4;
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
            this.gvSearchResult.Location = new System.Drawing.Point(12, 227);
            this.gvSearchResult.Name = "gvSearchResult";
            this.gvSearchResult.ReadOnly = true;
            this.gvSearchResult.Size = new System.Drawing.Size(851, 259);
            this.gvSearchResult.TabIndex = 5;
            // 
            // groupSessionAndClass
            // 
            this.groupSessionAndClass.BackColor = System.Drawing.SystemColors.Control;
            this.groupSessionAndClass.Controls.Add(this.comboClass);
            this.groupSessionAndClass.Controls.Add(this.comboSession);
            this.groupSessionAndClass.Controls.Add(this.label3);
            this.groupSessionAndClass.Controls.Add(this.label4);
            this.groupSessionAndClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSessionAndClass.Location = new System.Drawing.Point(253, 11);
            this.groupSessionAndClass.Name = "groupSessionAndClass";
            this.groupSessionAndClass.Size = new System.Drawing.Size(368, 187);
            this.groupSessionAndClass.TabIndex = 6;
            this.groupSessionAndClass.TabStop = false;
            this.groupSessionAndClass.Text = "Search By Class and Session";
            this.groupSessionAndClass.Visible = false;
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Location = new System.Drawing.Point(163, 96);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(147, 24);
            this.comboClass.TabIndex = 5;
            this.comboClass.SelectedIndexChanged += new System.EventHandler(this.comboClass_SelectedIndexChanged);
            // 
            // comboSession
            // 
            this.comboSession.FormattingEnabled = true;
            this.comboSession.Location = new System.Drawing.Point(163, 48);
            this.comboSession.Name = "comboSession";
            this.comboSession.Size = new System.Drawing.Size(147, 24);
            this.comboSession.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Session";
            // 
            // groupSearchBySession
            // 
            this.groupSearchBySession.BackColor = System.Drawing.SystemColors.Control;
            this.groupSearchBySession.Controls.Add(this.comboSession1);
            this.groupSearchBySession.Controls.Add(this.label6);
            this.groupSearchBySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearchBySession.Location = new System.Drawing.Point(253, 12);
            this.groupSearchBySession.Name = "groupSearchBySession";
            this.groupSearchBySession.Size = new System.Drawing.Size(368, 187);
            this.groupSearchBySession.TabIndex = 7;
            this.groupSearchBySession.TabStop = false;
            this.groupSearchBySession.Text = "Search By Session";
            this.groupSearchBySession.Visible = false;
            // 
            // comboSession1
            // 
            this.comboSession1.FormattingEnabled = true;
            this.comboSession1.Location = new System.Drawing.Point(163, 48);
            this.comboSession1.Name = "comboSession1";
            this.comboSession1.Size = new System.Drawing.Size(147, 24);
            this.comboSession1.TabIndex = 4;
            this.comboSession1.SelectedIndexChanged += new System.EventHandler(this.comboSession1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Session";
            // 
            // groupSelectAll
            // 
            this.groupSelectAll.BackColor = System.Drawing.SystemColors.Control;
            this.groupSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSelectAll.Location = new System.Drawing.Point(208, 12);
            this.groupSelectAll.Name = "groupSelectAll";
            this.groupSelectAll.Size = new System.Drawing.Size(368, 187);
            this.groupSelectAll.TabIndex = 8;
            this.groupSelectAll.TabStop = false;
            this.groupSelectAll.Text = "Overall Collection";
            this.groupSelectAll.Visible = false;
            // 
            // GrpFeeStatementByClass
            // 
            this.GrpFeeStatementByClass.Controls.Add(this.btnPrint);
            this.GrpFeeStatementByClass.Controls.Add(this.lblSession);
            this.GrpFeeStatementByClass.Controls.Add(this.label5);
            this.GrpFeeStatementByClass.Controls.Add(this.comboClassForStatement);
            this.GrpFeeStatementByClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpFeeStatementByClass.Location = new System.Drawing.Point(191, 27);
            this.GrpFeeStatementByClass.Name = "GrpFeeStatementByClass";
            this.GrpFeeStatementByClass.Size = new System.Drawing.Size(430, 166);
            this.GrpFeeStatementByClass.TabIndex = 9;
            this.GrpFeeStatementByClass.TabStop = false;
            this.GrpFeeStatementByClass.Text = "Fee Statement by Class";
            this.GrpFeeStatementByClass.Visible = false;
            // 
            // comboClassForStatement
            // 
            this.comboClassForStatement.FormattingEnabled = true;
            this.comboClassForStatement.Location = new System.Drawing.Point(236, 78);
            this.comboClassForStatement.Name = "comboClassForStatement";
            this.comboClassForStatement.Size = new System.Drawing.Size(142, 24);
            this.comboClassForStatement.TabIndex = 0;
            this.comboClassForStatement.SelectedIndexChanged += new System.EventHandler(this.comboClassForStatement_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Class:";
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
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Location = new System.Drawing.Point(189, 117);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 33);
            this.btnPrint.TabIndex = 154;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseCompatibleTextRendering = true;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpDailyCollection
            // 
            this.grpDailyCollection.Controls.Add(this.btnDailyCollectionPrint);
            this.grpDailyCollection.Location = new System.Drawing.Point(314, 29);
            this.grpDailyCollection.Name = "grpDailyCollection";
            this.grpDailyCollection.Size = new System.Drawing.Size(200, 100);
            this.grpDailyCollection.TabIndex = 10;
            this.grpDailyCollection.TabStop = false;
            this.grpDailyCollection.Text = "Daily Collection";
            this.grpDailyCollection.Visible = false;
            // 
            // btnDailyCollectionPrint
            // 
            this.btnDailyCollectionPrint.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnDailyCollectionPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDailyCollectionPrint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyCollectionPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDailyCollectionPrint.Location = new System.Drawing.Point(29, 34);
            this.btnDailyCollectionPrint.Name = "btnDailyCollectionPrint";
            this.btnDailyCollectionPrint.Size = new System.Drawing.Size(109, 33);
            this.btnDailyCollectionPrint.TabIndex = 154;
            this.btnDailyCollectionPrint.Text = "Print";
            this.btnDailyCollectionPrint.UseCompatibleTextRendering = true;
            this.btnDailyCollectionPrint.UseVisualStyleBackColor = true;
            this.btnDailyCollectionPrint.Click += new System.EventHandler(this.btnDailyCollectionPrint_Click);
            // 
            // FeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 498);
            this.Controls.Add(this.grpDailyCollection);
            this.Controls.Add(this.GrpFeeStatementByClass);
            this.Controls.Add(this.groupSelectAll);
            this.Controls.Add(this.groupSearchBySession);
            this.Controls.Add(this.groupSessionAndClass);
            this.Controls.Add(this.gvSearchResult);
            this.Controls.Add(this.grpBetweenDates);
            this.Name = "FeeSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeeSearch";
            this.Load += new System.EventHandler(this.FeeSearch_Load);
            this.grpBetweenDates.ResumeLayout(false);
            this.grpBetweenDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).EndInit();
            this.groupSessionAndClass.ResumeLayout(false);
            this.groupSessionAndClass.PerformLayout();
            this.groupSearchBySession.ResumeLayout(false);
            this.groupSearchBySession.PerformLayout();
            this.GrpFeeStatementByClass.ResumeLayout(false);
            this.GrpFeeStatementByClass.PerformLayout();
            this.grpDailyCollection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBetweenDates;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvSearchResult;
        private System.Windows.Forms.GroupBox groupSessionAndClass;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.ComboBox comboSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupSearchBySession;
        private System.Windows.Forms.ComboBox comboSession1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupSelectAll;
        private System.Windows.Forms.GroupBox GrpFeeStatementByClass;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboClassForStatement;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpDailyCollection;
        private System.Windows.Forms.Button btnDailyCollectionPrint;
    }
}