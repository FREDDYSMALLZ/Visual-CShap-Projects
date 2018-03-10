namespace Federal_Inome_Tax_Clalculator
{
    partial class fedTaxCalculator
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
            this.filingStatusPromptLBL = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.incomePromptLBL = new System.Windows.Forms.Label();
            this.incomeTaxDIisplayLBL = new System.Windows.Forms.Label();
            this.incomeDispLabel = new System.Windows.Forms.Label();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.calculateTaxBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filingStatusPromptLBL
            // 
            this.filingStatusPromptLBL.Location = new System.Drawing.Point(42, 9);
            this.filingStatusPromptLBL.Name = "filingStatusPromptLBL";
            this.filingStatusPromptLBL.Size = new System.Drawing.Size(391, 152);
            this.filingStatusPromptLBL.TabIndex = 0;
            this.filingStatusPromptLBL.Text = "Please Enter the Filing Status(Number Only);\r\n0-Single Filers.\r\n1-Married Jointly" +
    " or qualifying widow(er)\r\n2-Married Separetely.\r\n3-Head of Household.\r\n";
            this.filingStatusPromptLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(46, 122);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(317, 28);
            this.statusTextBox.TabIndex = 1;
            // 
            // incomePromptLBL
            // 
            this.incomePromptLBL.Location = new System.Drawing.Point(46, 150);
            this.incomePromptLBL.Name = "incomePromptLBL";
            this.incomePromptLBL.Size = new System.Drawing.Size(317, 37);
            this.incomePromptLBL.TabIndex = 2;
            this.incomePromptLBL.Text = "Please Enter your Income:";
            this.incomePromptLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomeTaxDIisplayLBL
            // 
            this.incomeTaxDIisplayLBL.BackColor = System.Drawing.Color.White;
            this.incomeTaxDIisplayLBL.Location = new System.Drawing.Point(43, 241);
            this.incomeTaxDIisplayLBL.Name = "incomeTaxDIisplayLBL";
            this.incomeTaxDIisplayLBL.Size = new System.Drawing.Size(320, 89);
            this.incomeTaxDIisplayLBL.TabIndex = 3;
            this.incomeTaxDIisplayLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incomeDispLabel
            // 
            this.incomeDispLabel.Location = new System.Drawing.Point(46, 208);
            this.incomeDispLabel.Name = "incomeDispLabel";
            this.incomeDispLabel.Size = new System.Drawing.Size(317, 33);
            this.incomeDispLabel.TabIndex = 4;
            this.incomeDispLabel.Text = "Federal Tax:";
            this.incomeDispLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(46, 180);
            this.incomeTextBox.Multiline = true;
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(317, 25);
            this.incomeTextBox.TabIndex = 5;
           
            // 
            // calculateTaxBtn
            // 
            this.calculateTaxBtn.Location = new System.Drawing.Point(58, 333);
            this.calculateTaxBtn.Name = "calculateTaxBtn";
            this.calculateTaxBtn.Size = new System.Drawing.Size(105, 33);
            this.calculateTaxBtn.TabIndex = 6;
            this.calculateTaxBtn.Text = "C&alculate Tax";
            this.calculateTaxBtn.UseVisualStyleBackColor = true;
            this.calculateTaxBtn.Click += new System.EventHandler(this.calculateTaxBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(169, 333);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(80, 33);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "C&lear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(256, 333);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(98, 33);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // fedTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(418, 382);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateTaxBtn);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.incomeDispLabel);
            this.Controls.Add(this.incomeTaxDIisplayLBL);
            this.Controls.Add(this.incomePromptLBL);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.filingStatusPromptLBL);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fedTaxCalculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEDERAL INCOME TAX CALCULATOR";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filingStatusPromptLBL;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label incomePromptLBL;
        private System.Windows.Forms.Label incomeTaxDIisplayLBL;
        private System.Windows.Forms.Label incomeDispLabel;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.Button calculateTaxBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

