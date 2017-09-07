namespace Payroll_with_Overtime_Application
{
    partial class PayrollOT
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
            this.hrsWorkedLBL = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateLBL = new System.Windows.Forms.Label();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.grossPayLBL = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hrsWorkedLBL
            // 
            this.hrsWorkedLBL.Location = new System.Drawing.Point(24, 46);
            this.hrsWorkedLBL.Name = "hrsWorkedLBL";
            this.hrsWorkedLBL.Size = new System.Drawing.Size(203, 38);
            this.hrsWorkedLBL.TabIndex = 0;
            this.hrsWorkedLBL.Text = "Hours Worked:";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(252, 46);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(244, 33);
            this.hoursWorkedTextBox.TabIndex = 1;
            // 
            // hourlyPayRateLBL
            // 
            this.hourlyPayRateLBL.Location = new System.Drawing.Point(24, 116);
            this.hourlyPayRateLBL.Name = "hourlyPayRateLBL";
            this.hourlyPayRateLBL.Size = new System.Drawing.Size(203, 38);
            this.hourlyPayRateLBL.TabIndex = 2;
            this.hourlyPayRateLBL.Text = "Hourly pay rate:";
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(252, 121);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(244, 33);
            this.hourlyPayRateTextBox.TabIndex = 3;
            // 
            // grossPayLBL
            // 
            this.grossPayLBL.Location = new System.Drawing.Point(24, 203);
            this.grossPayLBL.Name = "grossPayLBL";
            this.grossPayLBL.Size = new System.Drawing.Size(203, 38);
            this.grossPayLBL.TabIndex = 4;
            this.grossPayLBL.Text = "Gross pay:";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Location = new System.Drawing.Point(247, 203);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(249, 38);
            this.grossPayLabel.TabIndex = 5;
            this.grossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateBtn.Location = new System.Drawing.Point(29, 270);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(209, 46);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Calculate Gross Pay";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clearBtn.Location = new System.Drawing.Point(247, 270);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(138, 46);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(388, 270);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 46);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // PayrollOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 359);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.grossPayLBL);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hourlyPayRateLBL);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hrsWorkedLBL);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(567, 415);
            this.MinimumSize = new System.Drawing.Size(556, 415);
            this.Name = "PayrollOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll with Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hrsWorkedLBL;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label hourlyPayRateLBL;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Label grossPayLBL;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

