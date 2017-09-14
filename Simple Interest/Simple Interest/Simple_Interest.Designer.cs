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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.calculateSIBtn = new System.Windows.Forms.Button();
            this.TotalAmountLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.loanTimeTextBox = new System.Windows.Forms.TextBox();
            this.amountBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.Interest_Rate = new System.Windows.Forms.Label();
            this.Loan_Time = new System.Windows.Forms.Label();
            this.PrincipalAmount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.calculateSIBtn);
            this.groupBox1.Controls.Add(this.TotalAmountLBL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Clear_Button);
            this.groupBox1.Controls.Add(this.interestRateTextBox);
            this.groupBox1.Controls.Add(this.loanTimeTextBox);
            this.groupBox1.Controls.Add(this.amountBorrowedTextBox);
            this.groupBox1.Controls.Add(this.Interest_Rate);
            this.groupBox1.Controls.Add(this.Loan_Time);
            this.groupBox1.Controls.Add(this.PrincipalAmount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simple Interest Calculator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(441, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 51);
            this.button1.TabIndex = 26;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // calculateSIBtn
            // 
            this.calculateSIBtn.BackColor = System.Drawing.Color.Lime;
            this.calculateSIBtn.Location = new System.Drawing.Point(51, 236);
            this.calculateSIBtn.Name = "calculateSIBtn";
            this.calculateSIBtn.Size = new System.Drawing.Size(183, 51);
            this.calculateSIBtn.TabIndex = 25;
            this.calculateSIBtn.Text = "Calculate SI";
            this.calculateSIBtn.UseVisualStyleBackColor = false;
            // 
            // TotalAmountLBL
            // 
            this.TotalAmountLBL.BackColor = System.Drawing.Color.White;
            this.TotalAmountLBL.Location = new System.Drawing.Point(256, 185);
            this.TotalAmountLBL.Name = "TotalAmountLBL";
            this.TotalAmountLBL.Size = new System.Drawing.Size(368, 31);
            this.TotalAmountLBL.TabIndex = 24;
            this.TotalAmountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total Amount of Money:";
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Clear_Button.Location = new System.Drawing.Point(240, 236);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(183, 51);
            this.Clear_Button.TabIndex = 21;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(257, 88);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(367, 30);
            this.interestRateTextBox.TabIndex = 20;
            // 
            // loanTimeTextBox
            // 
            this.loanTimeTextBox.Location = new System.Drawing.Point(257, 135);
            this.loanTimeTextBox.Name = "loanTimeTextBox";
            this.loanTimeTextBox.Size = new System.Drawing.Size(367, 30);
            this.loanTimeTextBox.TabIndex = 19;
            // 
            // amountBorrowedTextBox
            // 
            this.amountBorrowedTextBox.Location = new System.Drawing.Point(257, 42);
            this.amountBorrowedTextBox.Name = "amountBorrowedTextBox";
            this.amountBorrowedTextBox.Size = new System.Drawing.Size(367, 30);
            this.amountBorrowedTextBox.TabIndex = 23;
            // 
            // Interest_Rate
            // 
            this.Interest_Rate.AutoSize = true;
            this.Interest_Rate.Location = new System.Drawing.Point(47, 88);
            this.Interest_Rate.Name = "Interest_Rate";
            this.Interest_Rate.Size = new System.Drawing.Size(115, 22);
            this.Interest_Rate.TabIndex = 18;
            this.Interest_Rate.Text = "Interest Rate:";
            // 
            // Loan_Time
            // 
            this.Loan_Time.AutoSize = true;
            this.Loan_Time.Location = new System.Drawing.Point(47, 135);
            this.Loan_Time.Name = "Loan_Time";
            this.Loan_Time.Size = new System.Drawing.Size(100, 22);
            this.Loan_Time.TabIndex = 17;
            this.Loan_Time.Text = "Loan Time:";
            // 
            // PrincipalAmount
            // 
            this.PrincipalAmount.AutoSize = true;
            this.PrincipalAmount.Location = new System.Drawing.Point(47, 50);
            this.PrincipalAmount.Name = "PrincipalAmount";
            this.PrincipalAmount.Size = new System.Drawing.Size(163, 22);
            this.PrincipalAmount.TabIndex = 16;
            this.PrincipalAmount.Text = "Amount Borrowed:";
            // 
            // Simple_Interest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(694, 353);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(716, 409);
            this.Name = "Simple_Interest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Interest Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calculateSIBtn;
        private System.Windows.Forms.Label TotalAmountLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox loanTimeTextBox;
        private System.Windows.Forms.TextBox amountBorrowedTextBox;
        private System.Windows.Forms.Label Interest_Rate;
        private System.Windows.Forms.Label Loan_Time;
        private System.Windows.Forms.Label PrincipalAmount;
    }
}

