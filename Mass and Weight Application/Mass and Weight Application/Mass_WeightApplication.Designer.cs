namespace Mass_and_Weight_Application
{
    partial class Mass_WeightApplication
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
            this.massPromtLBL = new System.Windows.Forms.Label();
            this.mass_textBox = new System.Windows.Forms.TextBox();
            this.weightLBL = new System.Windows.Forms.Label();
            this.weightOutputLBL = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // massPromtLBL
            // 
            this.massPromtLBL.Location = new System.Drawing.Point(28, 70);
            this.massPromtLBL.Name = "massPromtLBL";
            this.massPromtLBL.Size = new System.Drawing.Size(408, 41);
            this.massPromtLBL.TabIndex = 0;
            this.massPromtLBL.Text = "Enter Object\'s Mass(In Kilograms) :";
            this.massPromtLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mass_textBox
            // 
            this.mass_textBox.Location = new System.Drawing.Point(442, 70);
            this.mass_textBox.Multiline = true;
            this.mass_textBox.Name = "mass_textBox";
            this.mass_textBox.Size = new System.Drawing.Size(337, 41);
            this.mass_textBox.TabIndex = 1;
            // 
            // weightLBL
            // 
            this.weightLBL.Location = new System.Drawing.Point(28, 191);
            this.weightLBL.Name = "weightLBL";
            this.weightLBL.Size = new System.Drawing.Size(408, 41);
            this.weightLBL.TabIndex = 2;
            this.weightLBL.Text = "The Object\'s Weight (In Newtons is):";
            this.weightLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightOutputLBL
            // 
            this.weightOutputLBL.BackColor = System.Drawing.Color.White;
            this.weightOutputLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightOutputLBL.ForeColor = System.Drawing.Color.Black;
            this.weightOutputLBL.Location = new System.Drawing.Point(442, 191);
            this.weightOutputLBL.Name = "weightOutputLBL";
            this.weightOutputLBL.Size = new System.Drawing.Size(337, 41);
            this.weightOutputLBL.TabIndex = 3;
            this.weightOutputLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 271);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(249, 84);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Weight";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(559, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 84);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(288, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(249, 84);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Cl&ear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Mass_WeightApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 393);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.weightOutputLBL);
            this.Controls.Add(this.weightLBL);
            this.Controls.Add(this.mass_textBox);
            this.Controls.Add(this.massPromtLBL);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Mass_WeightApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mass and Weight Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label massPromtLBL;
        private System.Windows.Forms.TextBox mass_textBox;
        private System.Windows.Forms.Label weightLBL;
        private System.Windows.Forms.Label weightOutputLBL;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

