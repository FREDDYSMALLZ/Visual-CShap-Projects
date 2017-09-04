namespace Sale_Price_Calculator
{
    partial class salesCalculator
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
            this.originalPricePromptLabel = new System.Windows.Forms.Label();
            this.discPercentagePromptLabel = new System.Windows.Forms.Label();
            this.salePriceLbl = new System.Windows.Forms.Label();
            this.originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.percentageDiscountTextBox = new System.Windows.Forms.TextBox();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.salesPriceTextBox = new System.Windows.Forms.TextBox();
            this.calculateSalePriceButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalPricePromptLabel
            // 
            this.originalPricePromptLabel.Location = new System.Drawing.Point(35, 65);
            this.originalPricePromptLabel.Name = "originalPricePromptLabel";
            this.originalPricePromptLabel.Size = new System.Drawing.Size(341, 42);
            this.originalPricePromptLabel.TabIndex = 0;
            this.originalPricePromptLabel.Text = "Enter the item\'s original price:";
            // 
            // discPercentagePromptLabel
            // 
            this.discPercentagePromptLabel.Location = new System.Drawing.Point(35, 142);
            this.discPercentagePromptLabel.Name = "discPercentagePromptLabel";
            this.discPercentagePromptLabel.Size = new System.Drawing.Size(341, 42);
            this.discPercentagePromptLabel.TabIndex = 1;
            this.discPercentagePromptLabel.Text = "Enter the percentage discount:";
            // 
            // salePriceLbl
            // 
            this.salePriceLbl.Location = new System.Drawing.Point(186, 214);
            this.salePriceLbl.Name = "salePriceLbl";
            this.salePriceLbl.Size = new System.Drawing.Size(190, 33);
            this.salePriceLbl.TabIndex = 2;
            this.salePriceLbl.Text = "Sales Price:";
            // 
            // originalPriceTextBox
            // 
            this.originalPriceTextBox.Location = new System.Drawing.Point(451, 75);
            this.originalPriceTextBox.Name = "originalPriceTextBox";
            this.originalPriceTextBox.Size = new System.Drawing.Size(303, 32);
            this.originalPriceTextBox.TabIndex = 3;
            // 
            // percentageDiscountTextBox
            // 
            this.percentageDiscountTextBox.Location = new System.Drawing.Point(451, 139);
            this.percentageDiscountTextBox.Name = "percentageDiscountTextBox";
            this.percentageDiscountTextBox.Size = new System.Drawing.Size(303, 32);
            this.percentageDiscountTextBox.TabIndex = 4;
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.ForeColor = System.Drawing.Color.Transparent;
            this.salePriceLabel.Location = new System.Drawing.Point(446, 214);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(308, 33);
            this.salePriceLabel.TabIndex = 5;
            this.salePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesPriceTextBox
            // 
            this.salesPriceTextBox.Location = new System.Drawing.Point(451, 215);
            this.salesPriceTextBox.Name = "salesPriceTextBox";
            this.salesPriceTextBox.Size = new System.Drawing.Size(303, 32);
            this.salesPriceTextBox.TabIndex = 6;
            this.salesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculateSalePriceButton
            // 
            this.calculateSalePriceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateSalePriceButton.Location = new System.Drawing.Point(191, 292);
            this.calculateSalePriceButton.Name = "calculateSalePriceButton";
            this.calculateSalePriceButton.Size = new System.Drawing.Size(253, 62);
            this.calculateSalePriceButton.TabIndex = 7;
            this.calculateSalePriceButton.Text = "Calculate Sale Price";
            this.calculateSalePriceButton.UseVisualStyleBackColor = false;
            this.calculateSalePriceButton.Click += new System.EventHandler(this.calculateSalePriceButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(501, 292);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(253, 62);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // salesCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(815, 407);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateSalePriceButton);
            this.Controls.Add(this.salesPriceTextBox);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.percentageDiscountTextBox);
            this.Controls.Add(this.originalPriceTextBox);
            this.Controls.Add(this.salePriceLbl);
            this.Controls.Add(this.discPercentagePromptLabel);
            this.Controls.Add(this.originalPricePromptLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(837, 463);
            this.Name = "salesCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalPricePromptLabel;
        private System.Windows.Forms.Label discPercentagePromptLabel;
        private System.Windows.Forms.Label salePriceLbl;
        private System.Windows.Forms.TextBox originalPriceTextBox;
        private System.Windows.Forms.TextBox percentageDiscountTextBox;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.TextBox salesPriceTextBox;
        private System.Windows.Forms.Button calculateSalePriceButton;
        private System.Windows.Forms.Button exitButton;
    }
}

