namespace MySchoolSolution
{
    partial class Cheques
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
            this.gvCheques = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBounced = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheques)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvCheques
            // 
            this.gvCheques.AllowUserToAddRows = false;
            this.gvCheques.AllowUserToDeleteRows = false;
            this.gvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.gvCheques.Location = new System.Drawing.Point(12, 59);
            this.gvCheques.Name = "gvCheques";
            this.gvCheques.Size = new System.Drawing.Size(880, 348);
            this.gvCheques.TabIndex = 0;
            this.gvCheques.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCheques_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnBounced);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(313, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.btnBounced.Text = "Bounced";
            this.btnBounced.UseCompatibleTextRendering = true;
            this.btnBounced.UseVisualStyleBackColor = true;
            this.btnBounced.Click += new System.EventHandler(this.btnBounced_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Clear.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear.Location = new System.Drawing.Point(80, 23);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 33);
            this.btn_Clear.TabIndex = 202;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseCompatibleTextRendering = true;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pending Cheques";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cheques
            // 
            this.AcceptButton = this.btn_Clear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvCheques);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cheques";
            this.Text = "Cheques";
            this.Load += new System.EventHandler(this.Cheques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCheques)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCheques;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBounced;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Label label1;
    }
}