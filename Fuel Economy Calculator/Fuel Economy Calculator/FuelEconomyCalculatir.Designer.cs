namespace Fuel_Economy_Calculator
{
    partial class FuelEconomyCalculatir
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
            this.milesDrivenLbl = new System.Windows.Forms.Label();
            this.gallonsUsedLbl = new System.Windows.Forms.Label();
            this.vehicleLbl = new System.Windows.Forms.Label();
            this.milesDrivenTextBox = new System.Windows.Forms.TextBox();
            this.numberOfGallonsTextBox = new System.Windows.Forms.TextBox();
            this.vehicleMPGLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesDrivenLbl
            // 
            this.milesDrivenLbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesDrivenLbl.Location = new System.Drawing.Point(41, 53);
            this.milesDrivenLbl.Name = "milesDrivenLbl";
            this.milesDrivenLbl.Size = new System.Drawing.Size(305, 53);
            this.milesDrivenLbl.TabIndex = 0;
            this.milesDrivenLbl.Text = "Enter the number of miles driven:";
            // 
            // gallonsUsedLbl
            // 
            this.gallonsUsedLbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsUsedLbl.Location = new System.Drawing.Point(41, 94);
            this.gallonsUsedLbl.Name = "gallonsUsedLbl";
            this.gallonsUsedLbl.Size = new System.Drawing.Size(339, 53);
            this.gallonsUsedLbl.TabIndex = 1;
            this.gallonsUsedLbl.Text = "Enter the number of gas gallons used:";
            // 
            // vehicleLbl
            // 
            this.vehicleLbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLbl.Location = new System.Drawing.Point(41, 163);
            this.vehicleLbl.Name = "vehicleLbl";
            this.vehicleLbl.Size = new System.Drawing.Size(305, 53);
            this.vehicleLbl.TabIndex = 2;
            this.vehicleLbl.Text = "Vehicle\'s Miles Per Gallon:";
            // 
            // milesDrivenTextBox
            // 
            this.milesDrivenTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesDrivenTextBox.Location = new System.Drawing.Point(416, 50);
            this.milesDrivenTextBox.Name = "milesDrivenTextBox";
            this.milesDrivenTextBox.Size = new System.Drawing.Size(297, 30);
            this.milesDrivenTextBox.TabIndex = 3;
            // 
            // numberOfGallonsTextBox
            // 
            this.numberOfGallonsTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfGallonsTextBox.Location = new System.Drawing.Point(416, 94);
            this.numberOfGallonsTextBox.Name = "numberOfGallonsTextBox";
            this.numberOfGallonsTextBox.Size = new System.Drawing.Size(297, 30);
            this.numberOfGallonsTextBox.TabIndex = 4;
            // 
            // vehicleMPGLabel
            // 
            this.vehicleMPGLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleMPGLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleMPGLabel.Location = new System.Drawing.Point(416, 162);
            this.vehicleMPGLabel.Name = "vehicleMPGLabel";
            this.vehicleMPGLabel.Size = new System.Drawing.Size(297, 37);
            this.vehicleMPGLabel.TabIndex = 5;
            this.vehicleMPGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(272, 281);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(177, 57);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(536, 281);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 57);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // FuelEconomyCalculatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(776, 391);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.vehicleMPGLabel);
            this.Controls.Add(this.numberOfGallonsTextBox);
            this.Controls.Add(this.milesDrivenTextBox);
            this.Controls.Add(this.vehicleLbl);
            this.Controls.Add(this.gallonsUsedLbl);
            this.Controls.Add(this.milesDrivenLbl);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(798, 447);
            this.Name = "FuelEconomyCalculatir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Economy Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesDrivenLbl;
        private System.Windows.Forms.Label gallonsUsedLbl;
        private System.Windows.Forms.Label vehicleLbl;
        private System.Windows.Forms.TextBox milesDrivenTextBox;
        private System.Windows.Forms.TextBox numberOfGallonsTextBox;
        private System.Windows.Forms.Label vehicleMPGLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

