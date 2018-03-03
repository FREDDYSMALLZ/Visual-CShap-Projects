namespace The_South_America_Application
{
    partial class southAmerica
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
            this.countriesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // countriesButton
            // 
            this.countriesButton.Location = new System.Drawing.Point(88, 406);
            this.countriesButton.Name = "countriesButton";
            this.countriesButton.Size = new System.Drawing.Size(183, 54);
            this.countriesButton.TabIndex = 0;
            this.countriesButton.Text = "Get Countries";
            this.countriesButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(386, 406);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(183, 54);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 20;
            this.countriesListBox.Location = new System.Drawing.Point(88, 33);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(481, 344);
            this.countriesListBox.TabIndex = 2;
            // 
            // southAmerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 477);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countriesButton);
            this.Name = "southAmerica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button countriesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox countriesListBox;
    }
}

