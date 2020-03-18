namespace MySchoolSolution
{
    partial class Users
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.User_Insert = new System.Windows.Forms.Button();
            this.gvMenu = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.ddlUsers = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(222, 42);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(216, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(147, 45);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(66, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User Name :";
            // 
            // User_Insert
            // 
            this.User_Insert.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.User_Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_Insert.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User_Insert.Location = new System.Drawing.Point(145, 378);
            this.User_Insert.Name = "User_Insert";
            this.User_Insert.Size = new System.Drawing.Size(94, 33);
            this.User_Insert.TabIndex = 3;
            this.User_Insert.Text = "Save";
            this.User_Insert.UseCompatibleTextRendering = true;
            this.User_Insert.UseVisualStyleBackColor = true;
            this.User_Insert.Click += new System.EventHandler(this.User_Insert_Click);
            // 
            // gvMenu
            // 
            this.gvMenu.AllowUserToAddRows = false;
            this.gvMenu.AllowUserToDeleteRows = false;
            this.gvMenu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.gvMenu.Location = new System.Drawing.Point(150, 135);
            this.gvMenu.Name = "gvMenu";
            this.gvMenu.Size = new System.Drawing.Size(288, 221);
            this.gvMenu.TabIndex = 154;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 156;
            this.label1.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(222, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 158;
            this.label2.Text = "Mobile :";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(222, 96);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(216, 20);
            this.txtMobile.TabIndex = 2;
            // 
            // ddlUsers
            // 
            this.ddlUsers.FormattingEnabled = true;
            this.ddlUsers.Location = new System.Drawing.Point(222, 15);
            this.ddlUsers.Name = "ddlUsers";
            this.ddlUsers.Size = new System.Drawing.Size(216, 21);
            this.ddlUsers.TabIndex = 159;
            this.ddlUsers.Visible = false;
            this.ddlUsers.SelectedIndexChanged += new System.EventHandler(this.ddlUsers_SelectedIndexChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Exit.Location = new System.Drawing.Point(245, 378);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 33);
            this.btn_Exit.TabIndex = 160;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseCompatibleTextRendering = true;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Location = new System.Drawing.Point(147, 18);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(68, 13);
            this.lblSelectUser.TabIndex = 161;
            this.lblSelectUser.Text = "Select User :";
            this.lblSelectUser.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(348, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 33);
            this.btnDelete.TabIndex = 162;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCompatibleTextRendering = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Users
            // 
            this.AcceptButton = this.User_Insert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 441);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSelectUser);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.ddlUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.gvMenu);
            this.Controls.Add(this.User_Insert);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.txtUserName);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button User_Insert;
        private System.Windows.Forms.DataGridView gvMenu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.ComboBox ddlUsers;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.Button btnDelete;
    }
}