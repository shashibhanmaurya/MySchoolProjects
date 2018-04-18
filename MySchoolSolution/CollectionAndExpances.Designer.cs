namespace MySchoolSolution
{
    partial class CollectionAndExpances
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
            this.TabProfitLoss = new System.Windows.Forms.TabControl();
            this.tabBetweenTwoDates = new System.Windows.Forms.TabPage();
            this.grpBetweenDates = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabClassWiseCollection = new System.Windows.Forms.TabPage();
            this.Classwise = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.ddlClass = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabSessionWiseCollection = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlSession = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBankTransfer = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblCheque = new System.Windows.Forms.Label();
            this.lblPaytm = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TabProfitLoss.SuspendLayout();
            this.tabBetweenTwoDates.SuspendLayout();
            this.grpBetweenDates.SuspendLayout();
            this.TabClassWiseCollection.SuspendLayout();
            this.Classwise.SuspendLayout();
            this.tabSessionWiseCollection.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabProfitLoss
            // 
            this.TabProfitLoss.Controls.Add(this.tabBetweenTwoDates);
            this.TabProfitLoss.Controls.Add(this.TabClassWiseCollection);
            this.TabProfitLoss.Controls.Add(this.tabSessionWiseCollection);
            this.TabProfitLoss.Location = new System.Drawing.Point(2, 2);
            this.TabProfitLoss.Name = "TabProfitLoss";
            this.TabProfitLoss.SelectedIndex = 0;
            this.TabProfitLoss.Size = new System.Drawing.Size(585, 267);
            this.TabProfitLoss.TabIndex = 0;
            // 
            // tabBetweenTwoDates
            // 
            this.tabBetweenTwoDates.Controls.Add(this.grpBetweenDates);
            this.tabBetweenTwoDates.Location = new System.Drawing.Point(4, 22);
            this.tabBetweenTwoDates.Name = "tabBetweenTwoDates";
            this.tabBetweenTwoDates.Size = new System.Drawing.Size(577, 241);
            this.tabBetweenTwoDates.TabIndex = 3;
            this.tabBetweenTwoDates.Text = "Between two Dates";
            this.tabBetweenTwoDates.UseVisualStyleBackColor = true;
            // 
            // grpBetweenDates
            // 
            this.grpBetweenDates.BackColor = System.Drawing.SystemColors.Control;
            this.grpBetweenDates.Controls.Add(this.button2);
            this.grpBetweenDates.Controls.Add(this.btnSearch);
            this.grpBetweenDates.Controls.Add(this.dtTo);
            this.grpBetweenDates.Controls.Add(this.dtFrom);
            this.grpBetweenDates.Controls.Add(this.label3);
            this.grpBetweenDates.Controls.Add(this.label4);
            this.grpBetweenDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBetweenDates.Location = new System.Drawing.Point(116, 22);
            this.grpBetweenDates.Name = "grpBetweenDates";
            this.grpBetweenDates.Size = new System.Drawing.Size(368, 187);
            this.grpBetweenDates.TabIndex = 5;
            this.grpBetweenDates.TabStop = false;
            this.grpBetweenDates.Text = "Search Between Dates";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "From";
            // 
            // TabClassWiseCollection
            // 
            this.TabClassWiseCollection.Controls.Add(this.Classwise);
            this.TabClassWiseCollection.Location = new System.Drawing.Point(4, 22);
            this.TabClassWiseCollection.Name = "TabClassWiseCollection";
            this.TabClassWiseCollection.Padding = new System.Windows.Forms.Padding(3);
            this.TabClassWiseCollection.Size = new System.Drawing.Size(577, 241);
            this.TabClassWiseCollection.TabIndex = 0;
            this.TabClassWiseCollection.Text = "Classwise Collection";
            this.TabClassWiseCollection.UseVisualStyleBackColor = true;
            this.TabClassWiseCollection.Click += new System.EventHandler(this.TabClassWiseCollection_Click);
            // 
            // Classwise
            // 
            this.Classwise.BackColor = System.Drawing.SystemColors.Control;
            this.Classwise.Controls.Add(this.label51);
            this.Classwise.Controls.Add(this.ddlClass);
            this.Classwise.Controls.Add(this.button1);
            this.Classwise.Controls.Add(this.button3);
            this.Classwise.Controls.Add(this.dateTimePicker1);
            this.Classwise.Controls.Add(this.dateTimePicker2);
            this.Classwise.Controls.Add(this.label21);
            this.Classwise.Controls.Add(this.label22);
            this.Classwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classwise.Location = new System.Drawing.Point(89, 6);
            this.Classwise.Name = "Classwise";
            this.Classwise.Size = new System.Drawing.Size(368, 203);
            this.Classwise.TabIndex = 18;
            this.Classwise.TabStop = false;
            this.Classwise.Text = "Classwise";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(71, 38);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(42, 17);
            this.label51.TabIndex = 158;
            this.label51.Text = "Class";
            // 
            // ddlClass
            // 
            this.ddlClass.FormattingEnabled = true;
            this.ddlClass.Location = new System.Drawing.Point(143, 35);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(121, 24);
            this.ddlClass.TabIndex = 157;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(224, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 156;
            this.button1.Text = "Print";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(143, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 155;
            this.button3.Text = "Search";
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(143, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(126, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(71, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "To";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(71, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "From";
            // 
            // tabSessionWiseCollection
            // 
            this.tabSessionWiseCollection.Controls.Add(this.groupBox2);
            this.tabSessionWiseCollection.Location = new System.Drawing.Point(4, 22);
            this.tabSessionWiseCollection.Name = "tabSessionWiseCollection";
            this.tabSessionWiseCollection.Padding = new System.Windows.Forms.Padding(3);
            this.tabSessionWiseCollection.Size = new System.Drawing.Size(577, 241);
            this.tabSessionWiseCollection.TabIndex = 1;
            this.tabSessionWiseCollection.Text = "Sessionwise";
            this.tabSessionWiseCollection.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.ddlSession);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(103, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 187);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Between Dates";
            // 
            // ddlSession
            // 
            this.ddlSession.FormattingEnabled = true;
            this.ddlSession.Location = new System.Drawing.Point(135, 48);
            this.ddlSession.Name = "ddlSession";
            this.ddlSession.Size = new System.Drawing.Size(121, 24);
            this.ddlSession.TabIndex = 158;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(224, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 33);
            this.button4.TabIndex = 156;
            this.button4.Text = "Print";
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(143, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 155;
            this.button5.Text = "Search";
            this.button5.UseCompatibleTextRendering = true;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(71, 48);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(58, 17);
            this.label36.TabIndex = 1;
            this.label36.Text = "Session";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Paytm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cheque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cash:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Card:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(119, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bank Transfer:";
            // 
            // lblBankTransfer
            // 
            this.lblBankTransfer.AutoSize = true;
            this.lblBankTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankTransfer.Location = new System.Drawing.Point(365, 401);
            this.lblBankTransfer.Name = "lblBankTransfer";
            this.lblBankTransfer.Size = new System.Drawing.Size(98, 17);
            this.lblBankTransfer.TabIndex = 17;
            this.lblBankTransfer.Text = "Bank Transfer";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.Location = new System.Drawing.Point(365, 378);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(38, 17);
            this.lblCard.TabIndex = 16;
            this.lblCard.Text = "Card";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(365, 306);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(40, 17);
            this.lblCash.TabIndex = 15;
            this.lblCash.Text = "Cash";
            // 
            // lblCheque
            // 
            this.lblCheque.AutoSize = true;
            this.lblCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheque.Location = new System.Drawing.Point(365, 330);
            this.lblCheque.Name = "lblCheque";
            this.lblCheque.Size = new System.Drawing.Size(57, 17);
            this.lblCheque.TabIndex = 14;
            this.lblCheque.Text = "Cheque";
            // 
            // lblPaytm
            // 
            this.lblPaytm.AutoSize = true;
            this.lblPaytm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaytm.Location = new System.Drawing.Point(365, 352);
            this.lblPaytm.Name = "lblPaytm";
            this.lblPaytm.Size = new System.Drawing.Size(47, 17);
            this.lblPaytm.TabIndex = 13;
            this.lblPaytm.Text = "Paytm";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(365, 284);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // CollectionAndExpances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 439);
            this.Controls.Add(this.lblBankTransfer);
            this.Controls.Add(this.TabProfitLoss);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCheque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPaytm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "CollectionAndExpances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CollectionAndExpances";
            this.Load += new System.EventHandler(this.CollectionAndExpances_Load);
            this.TabProfitLoss.ResumeLayout(false);
            this.tabBetweenTwoDates.ResumeLayout(false);
            this.grpBetweenDates.ResumeLayout(false);
            this.grpBetweenDates.PerformLayout();
            this.TabClassWiseCollection.ResumeLayout(false);
            this.Classwise.ResumeLayout(false);
            this.Classwise.PerformLayout();
            this.tabSessionWiseCollection.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabProfitLoss;
        private System.Windows.Forms.TabPage TabClassWiseCollection;
        private System.Windows.Forms.TabPage tabSessionWiseCollection;
        private System.Windows.Forms.TabPage tabBetweenTwoDates;
        private System.Windows.Forms.GroupBox grpBetweenDates;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBankTransfer;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblCheque;
        private System.Windows.Forms.Label lblPaytm;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Classwise;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.ComboBox ddlSession;
    }
}