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
            this.amountBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.loanTimeTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalAmountLBL = new System.Windows.Forms.Label();
            this.calculateSIBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrincipalAmount
            // 
            this.PrincipalAmount.AutoSize = true;
            this.PrincipalAmount.Location = new System.Drawing.Point(32, 64);
            this.PrincipalAmount.Name = "PrincipalAmount";
            this.PrincipalAmount.Size = new System.Drawing.Size(163, 22);
            this.PrincipalAmount.TabIndex = 0;
            this.PrincipalAmount.Text = "Amount Borrowed:";
            // 
            // Loan_Time
            // 
            this.Loan_Time.AutoSize = true;
            this.Loan_Time.Location = new System.Drawing.Point(32, 149);
            this.Loan_Time.Name = "Loan_Time";
            this.Loan_Time.Size = new System.Drawing.Size(100, 22);
            this.Loan_Time.TabIndex = 1;
            this.Loan_Time.Text = "Loan Time:";
            // 
            // Interest_Rate
            // 
            this.Interest_Rate.AutoSize = true;
            this.Interest_Rate.Location = new System.Drawing.Point(32, 102);
            this.Interest_Rate.Name = "Interest_Rate";
            this.Interest_Rate.Size = new System.Drawing.Size(115, 22);
            this.Interest_Rate.TabIndex = 2;
            this.Interest_Rate.Text = "Interest Rate:";
            // 
            // amountBorrowedTextBox
            // 
            this.amountBorrowedTextBox.Location = new System.Drawing.Point(242, 56);
            this.amountBorrowedTextBox.Name = "amountBorrowedTextBox";
            this.amountBorrowedTextBox.Size = new System.Drawing.Size(367, 30);
            this.amountBorrowedTextBox.TabIndex = 11;
            // 
            // loanTimeTextBox
            // 
            this.loanTimeTextBox.Location = new System.Drawing.Point(242, 149);
            this.loanTimeTextBox.Name = "loanTimeTextBox";
            this.loanTimeTextBox.Size = new System.Drawing.Size(367, 30);
            this.loanTimeTextBox.TabIndex = 4;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(242, 102);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(367, 30);
            this.interestRateTextBox.TabIndex = 5;
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.Red;
            this.Clear_Button.Location = new System.Drawing.Point(426, 250);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(183, 51);
            this.Clear_Button.TabIndex = 6;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Amount of Money:";
            // 
            // TotalAmountLBL
            // 
            this.TotalAmountLBL.BackColor = System.Drawing.Color.White;
            this.TotalAmountLBL.Location = new System.Drawing.Point(241, 199);
            this.TotalAmountLBL.Name = "TotalAmountLBL";
            this.TotalAmountLBL.Size = new System.Drawing.Size(368, 31);
            this.TotalAmountLBL.TabIndex = 13;
            this.TotalAmountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateSIBtn
            // 
            this.calculateSIBtn.BackColor = System.Drawing.Color.Lime;
            this.calculateSIBtn.Location = new System.Drawing.Point(242, 250);
            this.calculateSIBtn.Name = "calculateSIBtn";
            this.calculateSIBtn.Size = new System.Drawing.Size(183, 51);
            this.calculateSIBtn.TabIndex = 14;
            this.calculateSIBtn.Text = "Calculate SI";
            this.calculateSIBtn.UseVisualStyleBackColor = false;
            this.calculateSIBtn.Click += new System.EventHandler(this.calculateSIBtn_Click);
            // 
            // Simple_Interest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(694, 353);
            this.Controls.Add(this.calculateSIBtn);
            this.Controls.Add(this.TotalAmountLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.loanTimeTextBox);
            this.Controls.Add(this.amountBorrowedTextBox);
            this.Controls.Add(this.Interest_Rate);
            this.Controls.Add(this.Loan_Time);
            this.Controls.Add(this.PrincipalAmount);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(716, 409);
            this.Name = "Simple_Interest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrincipalAmount;
        private System.Windows.Forms.Label Loan_Time;
        private System.Windows.Forms.Label Interest_Rate;
        private System.Windows.Forms.TextBox amountBorrowedTextBox;
        private System.Windows.Forms.TextBox loanTimeTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalAmountLBL;
        private System.Windows.Forms.Button calculateSIBtn;
    }
}

