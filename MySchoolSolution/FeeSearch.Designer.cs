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
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvSearchResult = new System.Windows.Forms.DataGridView();
            this.groupSessionAndClass = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.comboSession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupSearchBySession = new System.Windows.Forms.GroupBox();
            this.PrintbySession = new System.Windows.Forms.Button();
            this.comboSession1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupSelectAll = new System.Windows.Forms.GroupBox();
            this.PrintOverAll = new System.Windows.Forms.Button();
            this.GrpFeeStatementByClass = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblSession = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboClassForStatement = new System.Windows.Forms.ComboBox();
            this.grpDailyCollection = new System.Windows.Forms.GroupBox();
            this.btnDailyCollectionPrint = new System.Windows.Forms.Button();
            this.GrpStudentWiseFee = new System.Windows.Forms.GroupBox();
            this.btnStudentwiseSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.StudentwiseFeePrint = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.grpBetweenDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).BeginInit();
            this.groupSessionAndClass.SuspendLayout();
            this.groupSearchBySession.SuspendLayout();
            this.groupSelectAll.SuspendLayout();
            this.GrpFeeStatementByClass.SuspendLayout();
            this.grpDailyCollection.SuspendLayout();
            this.GrpStudentWiseFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBetweenDates
            // 
            this.grpBetweenDates.BackColor = System.Drawing.SystemColors.Control;
            this.grpBetweenDates.Controls.Add(this.button2);
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
            // button2
            // 
            this.button2.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(224, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 156;
            this.button2.Text = "Print";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.gvSearchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearchResult_CellClick);
            this.gvSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearchResult_CellContentClick);
            // 
            // groupSessionAndClass
            // 
            this.groupSessionAndClass.BackColor = System.Drawing.SystemColors.Control;
            this.groupSessionAndClass.Controls.Add(this.button1);
            this.groupSessionAndClass.Controls.Add(this.comboClass);
            this.groupSessionAndClass.Controls.Add(this.comboSession);
            this.groupSessionAndClass.Controls.Add(this.label3);
            this.groupSessionAndClass.Controls.Add(this.label4);
            this.groupSessionAndClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSessionAndClass.Location = new System.Drawing.Point(255, 17);
            this.groupSessionAndClass.Name = "groupSessionAndClass";
            this.groupSessionAndClass.Size = new System.Drawing.Size(368, 187);
            this.groupSessionAndClass.TabIndex = 6;
            this.groupSessionAndClass.TabStop = false;
            this.groupSessionAndClass.Text = "Search By Class and Session";
            this.groupSessionAndClass.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(144, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 157;
            this.button1.Text = "Print";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.comboSession.SelectedIndexChanged += new System.EventHandler(this.comboSession_SelectedIndexChanged);
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
            this.groupSearchBySession.Controls.Add(this.PrintbySession);
            this.groupSearchBySession.Controls.Add(this.comboSession1);
            this.groupSearchBySession.Controls.Add(this.label6);
            this.groupSearchBySession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearchBySession.Location = new System.Drawing.Point(257, 11);
            this.groupSearchBySession.Name = "groupSearchBySession";
            this.groupSearchBySession.Size = new System.Drawing.Size(362, 178);
            this.groupSearchBySession.TabIndex = 7;
            this.groupSearchBySession.TabStop = false;
            this.groupSearchBySession.Text = "Search By Session";
            this.groupSearchBySession.Visible = false;
            // 
            // PrintbySession
            // 
            this.PrintbySession.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.PrintbySession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintbySession.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintbySession.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrintbySession.Location = new System.Drawing.Point(137, 115);
            this.PrintbySession.Name = "PrintbySession";
            this.PrintbySession.Size = new System.Drawing.Size(92, 33);
            this.PrintbySession.TabIndex = 156;
            this.PrintbySession.Text = "Print";
            this.PrintbySession.UseCompatibleTextRendering = true;
            this.PrintbySession.UseVisualStyleBackColor = true;
            this.PrintbySession.Click += new System.EventHandler(this.PrintbySession_Click);
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
            this.groupSelectAll.Controls.Add(this.PrintOverAll);
            this.groupSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSelectAll.Location = new System.Drawing.Point(192, 30);
            this.groupSelectAll.Name = "groupSelectAll";
            this.groupSelectAll.Size = new System.Drawing.Size(368, 187);
            this.groupSelectAll.TabIndex = 8;
            this.groupSelectAll.TabStop = false;
            this.groupSelectAll.Text = "Overall Collection";
            this.groupSelectAll.Visible = false;
            // 
            // PrintOverAll
            // 
            this.PrintOverAll.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.PrintOverAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintOverAll.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintOverAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrintOverAll.Location = new System.Drawing.Point(138, 77);
            this.PrintOverAll.Name = "PrintOverAll";
            this.PrintOverAll.Size = new System.Drawing.Size(92, 33);
            this.PrintOverAll.TabIndex = 155;
            this.PrintOverAll.Text = "Print";
            this.PrintOverAll.UseCompatibleTextRendering = true;
            this.PrintOverAll.UseVisualStyleBackColor = true;
            this.PrintOverAll.Click += new System.EventHandler(this.PrintOverAll_Click);
            // 
            // GrpFeeStatementByClass
            // 
            this.GrpFeeStatementByClass.Controls.Add(this.btnPrint);
            this.GrpFeeStatementByClass.Controls.Add(this.lblSession);
            this.GrpFeeStatementByClass.Controls.Add(this.label5);
            this.GrpFeeStatementByClass.Controls.Add(this.comboClassForStatement);
            this.GrpFeeStatementByClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpFeeStatementByClass.Location = new System.Drawing.Point(227, 33);
            this.GrpFeeStatementByClass.Name = "GrpFeeStatementByClass";
            this.GrpFeeStatementByClass.Size = new System.Drawing.Size(430, 166);
            this.GrpFeeStatementByClass.TabIndex = 9;
            this.GrpFeeStatementByClass.TabStop = false;
            this.GrpFeeStatementByClass.Text = "Fee Statement by Class";
            this.GrpFeeStatementByClass.Visible = false;
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
            this.label5.Location = new System.Drawing.Point(158, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Class:";
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
            // grpDailyCollection
            // 
            this.grpDailyCollection.Controls.Add(this.btnDailyCollectionPrint);
            this.grpDailyCollection.Location = new System.Drawing.Point(179, 50);
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
            // GrpStudentWiseFee
            // 
            this.GrpStudentWiseFee.BackColor = System.Drawing.SystemColors.Control;
            this.GrpStudentWiseFee.Controls.Add(this.btnStudentwiseSearch);
            this.GrpStudentWiseFee.Controls.Add(this.label7);
            this.GrpStudentWiseFee.Controls.Add(this.txtStudent);
            this.GrpStudentWiseFee.Controls.Add(this.StudentwiseFeePrint);
            this.GrpStudentWiseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpStudentWiseFee.Location = new System.Drawing.Point(218, 18);
            this.GrpStudentWiseFee.Name = "GrpStudentWiseFee";
            this.GrpStudentWiseFee.Size = new System.Drawing.Size(368, 187);
            this.GrpStudentWiseFee.TabIndex = 156;
            this.GrpStudentWiseFee.TabStop = false;
            this.GrpStudentWiseFee.Text = "Student Fee Search";
            this.GrpStudentWiseFee.Visible = false;
            // 
            // btnStudentwiseSearch
            // 
            this.btnStudentwiseSearch.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnStudentwiseSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentwiseSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentwiseSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentwiseSearch.Location = new System.Drawing.Point(105, 101);
            this.btnStudentwiseSearch.Name = "btnStudentwiseSearch";
            this.btnStudentwiseSearch.Size = new System.Drawing.Size(75, 33);
            this.btnStudentwiseSearch.TabIndex = 158;
            this.btnStudentwiseSearch.Text = "Search";
            this.btnStudentwiseSearch.UseCompatibleTextRendering = true;
            this.btnStudentwiseSearch.UseVisualStyleBackColor = true;
            this.btnStudentwiseSearch.Click += new System.EventHandler(this.btnStudentwiseSearch_Click);
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
            this.txtStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStudent.Location = new System.Drawing.Point(104, 32);
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
            this.StudentwiseFeePrint.Location = new System.Drawing.Point(199, 101);
            this.StudentwiseFeePrint.Name = "StudentwiseFeePrint";
            this.StudentwiseFeePrint.Size = new System.Drawing.Size(92, 33);
            this.StudentwiseFeePrint.TabIndex = 155;
            this.StudentwiseFeePrint.Text = "Print";
            this.StudentwiseFeePrint.UseCompatibleTextRendering = true;
            this.StudentwiseFeePrint.UseVisualStyleBackColor = true;
            this.StudentwiseFeePrint.Click += new System.EventHandler(this.StudentwiseFeePrint_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnPrintReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintReceipt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintReceipt.Location = new System.Drawing.Point(328, 507);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(110, 33);
            this.btnPrintReceipt.TabIndex = 157;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseCompatibleTextRendering = true;
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Location = new System.Drawing.Point(233, 517);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(84, 13);
            this.lblReceipt.TabIndex = 158;
            this.lblReceipt.Text = "Receipt Number";
            // 
            // FeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 552);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.groupSelectAll);
            this.Controls.Add(this.GrpStudentWiseFee);
            this.Controls.Add(this.GrpFeeStatementByClass);
            this.Controls.Add(this.groupSessionAndClass);
            this.Controls.Add(this.groupSearchBySession);
            this.Controls.Add(this.grpDailyCollection);
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
            this.groupSelectAll.ResumeLayout(false);
            this.GrpFeeStatementByClass.ResumeLayout(false);
            this.GrpFeeStatementByClass.PerformLayout();
            this.grpDailyCollection.ResumeLayout(false);
            this.GrpStudentWiseFee.ResumeLayout(false);
            this.GrpStudentWiseFee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button PrintOverAll;
        private System.Windows.Forms.Button PrintbySession;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox GrpStudentWiseFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button StudentwiseFeePrint;
        private System.Windows.Forms.Button btnStudentwiseSearch;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Label lblReceipt;
    }
}