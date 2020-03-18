namespace MySchoolSolution
{
    partial class FeeEdit
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
            this.dtChequeDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ChqNumber = new System.Windows.Forms.Label();
            this.txtChequeNumber = new System.Windows.Forms.TextBox();
            this.lblUname = new System.Windows.Forms.Label();
            this.grpChequeDetail = new System.Windows.Forms.GroupBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.RichTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ddlPaymentType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdmissionNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecieptNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpChequeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtChequeDate
            // 
            this.dtChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtChequeDate.Location = new System.Drawing.Point(108, 68);
            this.dtChequeDate.Name = "dtChequeDate";
            this.dtChequeDate.Size = new System.Drawing.Size(124, 20);
            this.dtChequeDate.TabIndex = 230;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 18);
            this.label23.TabIndex = 229;
            this.label23.Text = "Date :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 18);
            this.label21.TabIndex = 227;
            this.label21.Text = "Bank Name :";
            // 
            // ChqNumber
            // 
            this.ChqNumber.AutoSize = true;
            this.ChqNumber.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChqNumber.Location = new System.Drawing.Point(-1, 17);
            this.ChqNumber.Name = "ChqNumber";
            this.ChqNumber.Size = new System.Drawing.Size(105, 18);
            this.ChqNumber.TabIndex = 226;
            this.ChqNumber.Text = "Cheque Number :";
            // 
            // txtChequeNumber
            // 
            this.txtChequeNumber.Location = new System.Drawing.Point(108, 15);
            this.txtChequeNumber.Name = "txtChequeNumber";
            this.txtChequeNumber.Size = new System.Drawing.Size(171, 20);
            this.txtChequeNumber.TabIndex = 222;
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(652, 77);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 13);
            this.lblUname.TabIndex = 288;
            this.lblUname.Visible = false;
            // 
            // grpChequeDetail
            // 
            this.grpChequeDetail.Controls.Add(this.dtChequeDate);
            this.grpChequeDetail.Controls.Add(this.label23);
            this.grpChequeDetail.Controls.Add(this.label21);
            this.grpChequeDetail.Controls.Add(this.ChqNumber);
            this.grpChequeDetail.Controls.Add(this.txtBankName);
            this.grpChequeDetail.Controls.Add(this.txtChequeNumber);
            this.grpChequeDetail.Location = new System.Drawing.Point(565, 189);
            this.grpChequeDetail.Name = "grpChequeDetail";
            this.grpChequeDetail.Size = new System.Drawing.Size(291, 124);
            this.grpChequeDetail.TabIndex = 287;
            this.grpChequeDetail.TabStop = false;
            this.grpChequeDetail.Text = "Cheque Details";
            this.grpChequeDetail.Visible = false;
            // 
            // txtBankName
            // 
            this.txtBankName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBankName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBankName.Location = new System.Drawing.Point(108, 39);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(171, 20);
            this.txtBankName.TabIndex = 223;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Blue;
            this.txtBalance.Location = new System.Drawing.Point(459, 156);
            this.txtBalance.Multiline = false;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(111, 27);
            this.txtBalance.TabIndex = 282;
            this.txtBalance.Text = "0.00";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(986, 514);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // ddlPaymentType
            // 
            this.ddlPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlPaymentType.FormattingEnabled = true;
            this.ddlPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Paytm",
            "Credit / Debit Card",
            "Bank Transfer"});
            this.ddlPaymentType.Location = new System.Drawing.Point(702, 161);
            this.ddlPaymentType.Name = "ddlPaymentType";
            this.ddlPaymentType.Size = new System.Drawing.Size(125, 21);
            this.ddlPaymentType.TabIndex = 234;
            this.ddlPaymentType.Text = "Cash";
            this.ddlPaymentType.SelectedIndexChanged += new System.EventHandler(this.ddlPaymentType_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(386, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 20);
            this.label17.TabIndex = 281;
            this.label17.Text = "Balance :";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.ForeColor = System.Drawing.Color.Blue;
            this.txtPaidAmount.Location = new System.Drawing.Point(244, 156);
            this.txtPaidAmount.Multiline = false;
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.ReadOnly = true;
            this.txtPaidAmount.Size = new System.Drawing.Size(125, 27);
            this.txtPaidAmount.TabIndex = 4;
            this.txtPaidAmount.Text = "0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(114, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 20);
            this.label18.TabIndex = 280;
            this.label18.Text = "Paid Amount :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(576, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 20);
            this.label19.TabIndex = 279;
            this.label19.Text = "Payment Type :";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(348, 6);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(84, 27);
            this.lblSession.TabIndex = 274;
            this.lblSession.Text = "session";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(327, 27);
            this.label14.TabIndex = 273;
            this.label14.Text = "Fee Edit For a Student Session";
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(425, 264);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 33);
            this.button10.TabIndex = 6;
            this.button10.Text = "Exit";
            this.button10.UseCompatibleTextRendering = true;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.buttonPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrint.Enabled = false;
            this.buttonPrint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrint.Location = new System.Drawing.Point(352, 264);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 33);
            this.buttonPrint.TabIndex = 5;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseCompatibleTextRendering = true;
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalAmount.Location = new System.Drawing.Point(244, 123);
            this.txtTotalAmount.Multiline = false;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(125, 27);
            this.txtTotalAmount.TabIndex = 269;
            this.txtTotalAmount.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(114, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 20);
            this.label13.TabIndex = 268;
            this.label13.Text = "Total Amount :";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNo.Location = new System.Drawing.Point(619, 81);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.ReadOnly = true;
            this.txtAccountNo.Size = new System.Drawing.Size(94, 21);
            this.txtAccountNo.TabIndex = 252;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 251;
            this.label3.Text = "A/C No. :";
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtClass.Enabled = false;
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.Black;
            this.txtClass.Location = new System.Drawing.Point(459, 81);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(94, 21);
            this.txtClass.TabIndex = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 249;
            this.label2.Text = "Class :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(209, 81);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(203, 21);
            this.txtName.TabIndex = 248;
            // 
            // txtAdmissionNo
            // 
            this.txtAdmissionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmissionNo.Location = new System.Drawing.Point(118, 81);
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.ReadOnly = true;
            this.txtAdmissionNo.Size = new System.Drawing.Size(85, 21);
            this.txtAdmissionNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 247;
            this.label1.Text = "Admission No. :";
            // 
            // txtRecieptNumber
            // 
            this.txtRecieptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecieptNumber.Location = new System.Drawing.Point(118, 43);
            this.txtRecieptNumber.Name = "txtRecieptNumber";
            this.txtRecieptNumber.Size = new System.Drawing.Size(85, 21);
            this.txtRecieptNumber.TabIndex = 1;
            this.txtRecieptNumber.TextChanged += new System.EventHandler(this.txtRecieptNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 296;
            this.label4.Text = "Receipt No. :";
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnGetDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetDetails.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetDetails.Location = new System.Drawing.Point(209, 38);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(105, 33);
            this.btnGetDetails.TabIndex = 2;
            this.btnGetDetails.Text = "Get Details";
            this.btnGetDetails.UseCompatibleTextRendering = true;
            this.btnGetDetails.UseVisualStyleBackColor = true;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(266, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 298;
            this.button1.Text = "Save";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FeeEdit
            // 
            this.AcceptButton = this.btnGetDetails;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetDetails);
            this.Controls.Add(this.txtRecieptNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.grpChequeDetail);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.ddlPaymentType);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAdmissionNo);
            this.Controls.Add(this.label1);
            this.Name = "FeeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeeEdit";
            this.Load += new System.EventHandler(this.FeeEdit_Load);
            this.grpChequeDetail.ResumeLayout(false);
            this.grpChequeDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtChequeDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label ChqNumber;
        private System.Windows.Forms.TextBox txtChequeNumber;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.GroupBox grpChequeDetail;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.RichTextBox txtBalance;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ComboBox ddlPaymentType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txtPaidAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.RichTextBox txtTotalAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdmissionNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecieptNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetDetails;
        private System.Windows.Forms.Button button1;
    }
}