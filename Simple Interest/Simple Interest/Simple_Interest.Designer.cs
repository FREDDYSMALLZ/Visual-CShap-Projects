namespace Simple_Interest
{
    partial class Simple_Interest
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
            this.PrincipalAmount = new System.Windows.Forms.Label();
            this.Loan_Time = new System.Windows.Forms.Label();
            this.Interest_Rate = new System.Windows.Forms.Label();
            this.textBox_AmountBorrowed = new System.Windows.Forms.TextBox();
            this.textBox_LoanTime = new System.Windows.Forms.TextBox();
            this.textBox_InterestRate = new System.Windows.Forms.TextBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TotalAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrincipalAmount
            // 
            this.PrincipalAmount.AutoSize = true;
            this.PrincipalAmount.Location = new System.Drawing.Point(90, 79);
            this.PrincipalAmount.Name = "PrincipalAmount";
            this.PrincipalAmount.Size = new System.Drawing.Size(163, 22);
            this.PrincipalAmount.TabIndex = 0;
            this.PrincipalAmount.Text = "Amount Borrowed:";
            // 
            // Loan_Time
            // 
            this.Loan_Time.AutoSize = true;
            this.Loan_Time.Location = new System.Drawing.Point(90, 164);
            this.Loan_Time.Name = "Loan_Time";
            this.Loan_Time.Size = new System.Drawing.Size(100, 22);
            this.Loan_Time.TabIndex = 1;
            this.Loan_Time.Text = "Loan Time:";
            // 
            // Interest_Rate
            // 
            this.Interest_Rate.AutoSize = true;
            this.Interest_Rate.Location = new System.Drawing.Point(90, 117);
            this.Interest_Rate.Name = "Interest_Rate";
            this.Interest_Rate.Size = new System.Drawing.Size(115, 22);
            this.Interest_Rate.TabIndex = 2;
            this.Interest_Rate.Text = "Interest Rate:";
            // 
            // textBox_AmountBorrowed
            // 
            this.textBox_AmountBorrowed.Location = new System.Drawing.Point(300, 71);
            this.textBox_AmountBorrowed.Name = "textBox_AmountBorrowed";
            this.textBox_AmountBorrowed.Size = new System.Drawing.Size(367, 30);
            this.textBox_AmountBorrowed.TabIndex = 11;
            // 
            // textBox_LoanTime
            // 
            this.textBox_LoanTime.Location = new System.Drawing.Point(300, 164);
            this.textBox_LoanTime.Name = "textBox_LoanTime";
            this.textBox_LoanTime.Size = new System.Drawing.Size(367, 30);
            this.textBox_LoanTime.TabIndex = 4;
            // 
            // textBox_InterestRate
            // 
            this.textBox_InterestRate.Location = new System.Drawing.Point(300, 117);
            this.textBox_InterestRate.Name = "textBox_InterestRate";
            this.textBox_InterestRate.Size = new System.Drawing.Size(367, 30);
            this.textBox_InterestRate.TabIndex = 5;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(484, 265);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(183, 51);
            this.Clear_Button.TabIndex = 6;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Amount of Money:";
            // 
            // textBox_TotalAmount
            // 
            this.textBox_TotalAmount.Location = new System.Drawing.Point(300, 214);
            this.textBox_TotalAmount.Name = "textBox_TotalAmount";
            this.textBox_TotalAmount.Size = new System.Drawing.Size(367, 30);
            this.textBox_TotalAmount.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Simple_Interest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(791, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_TotalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.textBox_InterestRate);
            this.Controls.Add(this.textBox_LoanTime);
            this.Controls.Add(this.textBox_AmountBorrowed);
            this.Controls.Add(this.Interest_Rate);
            this.Controls.Add(this.Loan_Time);
            this.Controls.Add(this.PrincipalAmount);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Simple_Interest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Interest Calculator";
            this.Load += new System.EventHandler(this.Simple_Interest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrincipalAmount;
        private System.Windows.Forms.Label Loan_Time;
        private System.Windows.Forms.Label Interest_Rate;
        private System.Windows.Forms.TextBox textBox_AmountBorrowed;
        private System.Windows.Forms.TextBox textBox_LoanTime;
        private System.Windows.Forms.TextBox textBox_InterestRate;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TotalAmount;
        private System.Windows.Forms.Button button1;
    }
}

