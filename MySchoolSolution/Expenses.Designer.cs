namespace MySchoolSolution
{
    partial class Expenses
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
            System.Windows.Forms.Button button9;
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlPurpose = new System.Windows.Forms.ComboBox();
            this.btnAddNewPorpose = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button9
            // 
            button9.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button9.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            button9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button9.Location = new System.Drawing.Point(282, 192);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(75, 33);
            button9.TabIndex = 251;
            button9.Text = "Delete";
            button9.UseCompatibleTextRendering = true;
            button9.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 216;
            this.label10.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 214;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 213;
            this.label5.Text = "Amount :";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(172, 144);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(262, 21);
            this.txtDate.TabIndex = 210;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(172, 111);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(262, 21);
            this.txtAmount.TabIndex = 209;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.HideSelection = false;
            this.txtQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtQuantity.Location = new System.Drawing.Point(172, 81);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(262, 21);
            this.txtQuantity.TabIndex = 208;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(319, 27);
            this.label14.TabIndex = 253;
            this.label14.Text = "Expenses For Other Purposes ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 255;
            this.label1.Text = "Purpose:";
            // 
            // ddlPurpose
            // 
            this.ddlPurpose.FormattingEnabled = true;
            this.ddlPurpose.Location = new System.Drawing.Point(172, 51);
            this.ddlPurpose.Name = "ddlPurpose";
            this.ddlPurpose.Size = new System.Drawing.Size(262, 21);
            this.ddlPurpose.TabIndex = 256;
            // 
            // btnAddNewPorpose
            // 
            this.btnAddNewPorpose.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnAddNewPorpose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewPorpose.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPorpose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewPorpose.Location = new System.Drawing.Point(428, 192);
            this.btnAddNewPorpose.Name = "btnAddNewPorpose";
            this.btnAddNewPorpose.Size = new System.Drawing.Size(99, 33);
            this.btnAddNewPorpose.TabIndex = 257;
            this.btnAddNewPorpose.Text = "Add New";
            this.btnAddNewPorpose.UseCompatibleTextRendering = true;
            this.btnAddNewPorpose.UseVisualStyleBackColor = true;
            this.btnAddNewPorpose.Click += new System.EventHandler(this.btnAddNewPorpose_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(356, 192);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 33);
            this.button10.TabIndex = 252;
            this.button10.Text = "Exit";
            this.button10.UseCompatibleTextRendering = true;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(209, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 33);
            this.button8.TabIndex = 250;
            this.button8.Text = "Edit";
            this.button8.UseCompatibleTextRendering = true;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(136, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 33);
            this.button7.TabIndex = 249;
            this.button7.Text = "Print";
            this.button7.UseCompatibleTextRendering = true;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Save.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Location = new System.Drawing.Point(62, 192);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 33);
            this.btn_Save.TabIndex = 248;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseCompatibleTextRendering = true;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 318);
            this.Controls.Add(this.btnAddNewPorpose);
            this.Controls.Add(this.ddlPurpose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button10);
            this.Controls.Add(button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtQuantity);
            this.Name = "Expenses";
            this.Text = "InvestmentForOtherPurposes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlPurpose;
        private System.Windows.Forms.Button btnAddNewPorpose;
    }
}