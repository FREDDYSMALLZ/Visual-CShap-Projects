namespace WindowsFormsApp1
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
            this.Calculate_button = new System.Windows.Forms.Button();
            this.Pricipal_Lbl = new System.Windows.Forms.Label();
            this.Duration_Time_Lbl = new System.Windows.Forms.Label();
            this.Interest_Rate_Lbl = new System.Windows.Forms.Label();
            this.PrincipalAmount_textBox = new System.Windows.Forms.TextBox();
            this.Interest_RatetextBox = new System.Windows.Forms.TextBox();
            this.TimeDuration_textBox = new System.Windows.Forms.TextBox();
            this.Interest_textBox = new System.Windows.Forms.TextBox();
            this.Amount_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate_button
            // 
            this.Calculate_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Calculate_button.Location = new System.Drawing.Point(367, 260);
            this.Calculate_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(283, 57);
            this.Calculate_button.TabIndex = 0;
            this.Calculate_button.Text = "Calculate";
            this.Calculate_button.UseVisualStyleBackColor = false;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // Pricipal_Lbl
            // 
            this.Pricipal_Lbl.AutoSize = true;
            this.Pricipal_Lbl.Location = new System.Drawing.Point(42, 61);
            this.Pricipal_Lbl.Name = "Pricipal_Lbl";
            this.Pricipal_Lbl.Size = new System.Drawing.Size(187, 27);
            this.Pricipal_Lbl.TabIndex = 1;
            this.Pricipal_Lbl.Text = "Principal Amount:";
            // 
            // Duration_Time_Lbl
            // 
            this.Duration_Time_Lbl.AutoSize = true;
            this.Duration_Time_Lbl.Location = new System.Drawing.Point(42, 193);
            this.Duration_Time_Lbl.Name = "Duration_Time_Lbl";
            this.Duration_Time_Lbl.Size = new System.Drawing.Size(163, 27);
            this.Duration_Time_Lbl.TabIndex = 2;
            this.Duration_Time_Lbl.Text = "Duration_Time:";
            // 
            // Interest_Rate_Lbl
            // 
            this.Interest_Rate_Lbl.AutoSize = true;
            this.Interest_Rate_Lbl.Location = new System.Drawing.Point(42, 123);
            this.Interest_Rate_Lbl.Name = "Interest_Rate_Lbl";
            this.Interest_Rate_Lbl.Size = new System.Drawing.Size(142, 27);
            this.Interest_Rate_Lbl.TabIndex = 3;
            this.Interest_Rate_Lbl.Text = "Interest Rate:";
            // 
            // PrincipalAmount_textBox
            // 
            this.PrincipalAmount_textBox.Location = new System.Drawing.Point(255, 54);
            this.PrincipalAmount_textBox.Multiline = true;
            this.PrincipalAmount_textBox.Name = "PrincipalAmount_textBox";
            this.PrincipalAmount_textBox.Size = new System.Drawing.Size(548, 34);
            this.PrincipalAmount_textBox.TabIndex = 4;
            this.PrincipalAmount_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Interest_RatetextBox
            // 
            this.Interest_RatetextBox.Location = new System.Drawing.Point(255, 116);
            this.Interest_RatetextBox.Multiline = true;
            this.Interest_RatetextBox.Name = "Interest_RatetextBox";
            this.Interest_RatetextBox.Size = new System.Drawing.Size(548, 34);
            this.Interest_RatetextBox.TabIndex = 5;
            this.Interest_RatetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TimeDuration_textBox
            // 
            this.TimeDuration_textBox.Location = new System.Drawing.Point(255, 186);
            this.TimeDuration_textBox.Multiline = true;
            this.TimeDuration_textBox.Name = "TimeDuration_textBox";
            this.TimeDuration_textBox.Size = new System.Drawing.Size(548, 34);
            this.TimeDuration_textBox.TabIndex = 6;
            this.TimeDuration_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Interest_textBox
            // 
            this.Interest_textBox.Location = new System.Drawing.Point(255, 364);
            this.Interest_textBox.Name = "Interest_textBox";
            this.Interest_textBox.ReadOnly = true;
            this.Interest_textBox.Size = new System.Drawing.Size(548, 35);
            this.Interest_textBox.TabIndex = 7;
            this.Interest_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Amount_Label
            // 
            this.Amount_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Amount_Label.Location = new System.Drawing.Point(255, 420);
            this.Amount_Label.Name = "Amount_Label";
            this.Amount_Label.Size = new System.Drawing.Size(548, 39);
            this.Amount_Label.TabIndex = 8;
            // 
            // Simple_Interest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1097, 472);
            this.Controls.Add(this.Amount_Label);
            this.Controls.Add(this.Interest_textBox);
            this.Controls.Add(this.TimeDuration_textBox);
            this.Controls.Add(this.Interest_RatetextBox);
            this.Controls.Add(this.PrincipalAmount_textBox);
            this.Controls.Add(this.Interest_Rate_Lbl);
            this.Controls.Add(this.Duration_Time_Lbl);
            this.Controls.Add(this.Pricipal_Lbl);
            this.Controls.Add(this.Calculate_button);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Simple_Interest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Interst Calculator";
            this.Load += new System.EventHandler(this.Simple_Interest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Label Pricipal_Lbl;
        private System.Windows.Forms.Label Duration_Time_Lbl;
        private System.Windows.Forms.Label Interest_Rate_Lbl;
        private System.Windows.Forms.TextBox PrincipalAmount_textBox;
        private System.Windows.Forms.TextBox Interest_RatetextBox;
        private System.Windows.Forms.TextBox TimeDuration_textBox;
        private System.Windows.Forms.TextBox Interest_textBox;
        private System.Windows.Forms.Label Amount_Label;
    }
}

