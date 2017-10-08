namespace Compound_Interest_Calculator
{
    partial class ComupondInterestCalculator
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
            this.principalLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.numberOfTimesLabel = new System.Windows.Forms.Label();
            this.numberOfYearsLabel = new System.Windows.Forms.Label();
            this.compoundInteretLbael = new System.Windows.Forms.Label();
            this.compoundInterestDisplay = new System.Windows.Forms.Label();
            this.totalCompoundedLabel = new System.Windows.Forms.Label();
            this.totalCompoundedInterestDisp = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.annualInterestTextBox = new System.Windows.Forms.TextBox();
            this.numberOfTimesTextBox = new System.Windows.Forms.TextBox();
            this.numberOfYeasrTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // principalLabel
            // 
            this.principalLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalLabel.Location = new System.Drawing.Point(48, 23);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(475, 56);
            this.principalLabel.TabIndex = 0;
            this.principalLabel.Text = "Please Enter the Principal Amount here:";
            this.principalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateLabel.Location = new System.Drawing.Point(54, 79);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(469, 56);
            this.interestRateLabel.TabIndex = 1;
            this.interestRateLabel.Text = "Please Enter the annual inetrest here:";
            this.interestRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfTimesLabel
            // 
            this.numberOfTimesLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTimesLabel.Location = new System.Drawing.Point(48, 135);
            this.numberOfTimesLabel.Name = "numberOfTimesLabel";
            this.numberOfTimesLabel.Size = new System.Drawing.Size(530, 62);
            this.numberOfTimesLabel.TabIndex = 2;
            this.numberOfTimesLabel.Text = "Please Enter the number of times the interest is compounded per year here:";
            this.numberOfTimesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfYearsLabel
            // 
            this.numberOfYearsLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfYearsLabel.Location = new System.Drawing.Point(48, 214);
            this.numberOfYearsLabel.Name = "numberOfYearsLabel";
            this.numberOfYearsLabel.Size = new System.Drawing.Size(530, 62);
            this.numberOfYearsLabel.TabIndex = 3;
            this.numberOfYearsLabel.Text = "Please Enter the number of years the money is borrowed/Invested here:";
            this.numberOfYearsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compoundInteretLbael
            // 
            this.compoundInteretLbael.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compoundInteretLbael.Location = new System.Drawing.Point(412, 287);
            this.compoundInteretLbael.Name = "compoundInteretLbael";
            this.compoundInteretLbael.Size = new System.Drawing.Size(295, 47);
            this.compoundInteretLbael.TabIndex = 4;
            this.compoundInteretLbael.Text = "C&ompound Interest:";
            this.compoundInteretLbael.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compoundInterestDisplay
            // 
            this.compoundInterestDisplay.BackColor = System.Drawing.Color.White;
            this.compoundInterestDisplay.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compoundInterestDisplay.ForeColor = System.Drawing.Color.Black;
            this.compoundInterestDisplay.Location = new System.Drawing.Point(256, 334);
            this.compoundInterestDisplay.Name = "compoundInterestDisplay";
            this.compoundInterestDisplay.Size = new System.Drawing.Size(681, 123);
            this.compoundInterestDisplay.TabIndex = 5;
            this.compoundInterestDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCompoundedLabel
            // 
            this.totalCompoundedLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCompoundedLabel.Location = new System.Drawing.Point(382, 478);
            this.totalCompoundedLabel.Name = "totalCompoundedLabel";
            this.totalCompoundedLabel.Size = new System.Drawing.Size(341, 47);
            this.totalCompoundedLabel.TabIndex = 6;
            this.totalCompoundedLabel.Text = "Total C&ompounded Interest:";
            this.totalCompoundedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCompoundedInterestDisp
            // 
            this.totalCompoundedInterestDisp.BackColor = System.Drawing.Color.White;
            this.totalCompoundedInterestDisp.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCompoundedInterestDisp.ForeColor = System.Drawing.Color.Black;
            this.totalCompoundedInterestDisp.Location = new System.Drawing.Point(262, 525);
            this.totalCompoundedInterestDisp.Name = "totalCompoundedInterestDisp";
            this.totalCompoundedInterestDisp.Size = new System.Drawing.Size(675, 123);
            this.totalCompoundedInterestDisp.TabIndex = 7;
            this.totalCompoundedInterestDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(259, 713);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(221, 61);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "C&alculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(486, 713);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(221, 61);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "C&lear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(713, 713);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(221, 61);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // principalTextBox
            // 
            this.principalTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalTextBox.Location = new System.Drawing.Point(520, 23);
            this.principalTextBox.Multiline = true;
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(417, 43);
            this.principalTextBox.TabIndex = 11;
            this.principalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // annualInterestTextBox
            // 
            this.annualInterestTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualInterestTextBox.Location = new System.Drawing.Point(520, 72);
            this.annualInterestTextBox.Multiline = true;
            this.annualInterestTextBox.Name = "annualInterestTextBox";
            this.annualInterestTextBox.Size = new System.Drawing.Size(414, 57);
            this.annualInterestTextBox.TabIndex = 12;
            this.annualInterestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberOfTimesTextBox
            // 
            this.numberOfTimesTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTimesTextBox.Location = new System.Drawing.Point(576, 135);
            this.numberOfTimesTextBox.Multiline = true;
            this.numberOfTimesTextBox.Name = "numberOfTimesTextBox";
            this.numberOfTimesTextBox.Size = new System.Drawing.Size(358, 62);
            this.numberOfTimesTextBox.TabIndex = 13;
            this.numberOfTimesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberOfYeasrTextBox
            // 
            this.numberOfYeasrTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfYeasrTextBox.Location = new System.Drawing.Point(576, 214);
            this.numberOfYeasrTextBox.Multiline = true;
            this.numberOfYeasrTextBox.Name = "numberOfYeasrTextBox";
            this.numberOfYeasrTextBox.Size = new System.Drawing.Size(358, 62);
            this.numberOfYeasrTextBox.TabIndex = 14;
            this.numberOfYeasrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComupondInterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 802);
            this.Controls.Add(this.numberOfYeasrTextBox);
            this.Controls.Add(this.numberOfTimesTextBox);
            this.Controls.Add(this.annualInterestTextBox);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.totalCompoundedInterestDisp);
            this.Controls.Add(this.totalCompoundedLabel);
            this.Controls.Add(this.compoundInterestDisplay);
            this.Controls.Add(this.compoundInteretLbael);
            this.Controls.Add(this.numberOfYearsLabel);
            this.Controls.Add(this.numberOfTimesLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.principalLabel);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComupondInterestCalculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compound Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label numberOfTimesLabel;
        private System.Windows.Forms.Label numberOfYearsLabel;
        private System.Windows.Forms.Label compoundInteretLbael;
        private System.Windows.Forms.Label compoundInterestDisplay;
        private System.Windows.Forms.Label totalCompoundedLabel;
        private System.Windows.Forms.Label totalCompoundedInterestDisp;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox annualInterestTextBox;
        private System.Windows.Forms.TextBox numberOfTimesTextBox;
        private System.Windows.Forms.TextBox numberOfYeasrTextBox;
    }
}

