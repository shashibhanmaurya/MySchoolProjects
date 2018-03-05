namespace MySchoolSolution.Reports
{
    partial class Reprint_Reciept
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
            this.txtRecieptNumber = new System.Windows.Forms.TextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecieptNumber
            // 
            this.txtRecieptNumber.Location = new System.Drawing.Point(162, 65);
            this.txtRecieptNumber.Name = "txtRecieptNumber";
            this.txtRecieptNumber.Size = new System.Drawing.Size(196, 20);
            this.txtRecieptNumber.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.buttonPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrint.Location = new System.Drawing.Point(162, 102);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(103, 33);
            this.buttonPrint.TabIndex = 201;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseCompatibleTextRendering = true;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 18);
            this.label10.TabIndex = 202;
            this.label10.Text = "Reciept Number:";
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::MySchoolSolution.Properties.Resources.patient_midbg2;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(271, 102);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 33);
            this.button10.TabIndex = 204;
            this.button10.Text = "Exit";
            this.button10.UseCompatibleTextRendering = true;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Reprint_Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 262);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.txtRecieptNumber);
            this.Name = "Reprint_Reciept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprint_Reciept";
            this.Load += new System.EventHandler(this.Reprint_Reciept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecieptNumber;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
    }
}