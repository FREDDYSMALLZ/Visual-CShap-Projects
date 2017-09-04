namespace Change_counter_Applicatiion
{
    partial class ChangeCounterApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCounterApplication));
            this.instructionalLabel = new System.Windows.Forms.Label();
            this.fiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.tenCenysPictureBox = new System.Windows.Forms.PictureBox();
            this.twentyFiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.fiftyCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalOutputLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCenysPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionalLabel
            // 
            this.instructionalLabel.Location = new System.Drawing.Point(86, 9);
            this.instructionalLabel.Name = "instructionalLabel";
            this.instructionalLabel.Size = new System.Drawing.Size(261, 41);
            this.instructionalLabel.TabIndex = 0;
            this.instructionalLabel.Text = "Click the Coins";
            this.instructionalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fiveCentsPictureBox
            // 
            this.fiveCentsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fiveCentsPictureBox.Image")));
            this.fiveCentsPictureBox.Location = new System.Drawing.Point(53, 71);
            this.fiveCentsPictureBox.Name = "fiveCentsPictureBox";
            this.fiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.fiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fiveCentsPictureBox.TabIndex = 1;
            this.fiveCentsPictureBox.TabStop = false;
            this.fiveCentsPictureBox.Click += new System.EventHandler(this.fiveCentsPictureBox_Click);
            // 
            // tenCenysPictureBox
            // 
            this.tenCenysPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tenCenysPictureBox.Image")));
            this.tenCenysPictureBox.Location = new System.Drawing.Point(184, 71);
            this.tenCenysPictureBox.Name = "tenCenysPictureBox";
            this.tenCenysPictureBox.Size = new System.Drawing.Size(125, 181);
            this.tenCenysPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tenCenysPictureBox.TabIndex = 2;
            this.tenCenysPictureBox.TabStop = false;
            this.tenCenysPictureBox.Click += new System.EventHandler(this.tenCenysPictureBox_Click);
            // 
            // twentyFiveCentsPictureBox
            // 
            this.twentyFiveCentsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("twentyFiveCentsPictureBox.Image")));
            this.twentyFiveCentsPictureBox.Location = new System.Drawing.Point(53, 258);
            this.twentyFiveCentsPictureBox.Name = "twentyFiveCentsPictureBox";
            this.twentyFiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.twentyFiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.twentyFiveCentsPictureBox.TabIndex = 3;
            this.twentyFiveCentsPictureBox.TabStop = false;
            this.twentyFiveCentsPictureBox.Click += new System.EventHandler(this.twentyFiveCentsPictureBox_Click);
            // 
            // fiftyCentsPictureBox
            // 
            this.fiftyCentsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fiftyCentsPictureBox.Image")));
            this.fiftyCentsPictureBox.Location = new System.Drawing.Point(184, 258);
            this.fiftyCentsPictureBox.Name = "fiftyCentsPictureBox";
            this.fiftyCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.fiftyCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fiftyCentsPictureBox.TabIndex = 4;
            this.fiftyCentsPictureBox.TabStop = false;
            this.fiftyCentsPictureBox.Click += new System.EventHandler(this.fiftyCentsPictureBox_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.Location = new System.Drawing.Point(120, 486);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(189, 57);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.Location = new System.Drawing.Point(385, 168);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(210, 50);
            this.totalLbl.TabIndex = 6;
            this.totalLbl.Text = "Total";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutputLbl
            // 
            this.totalOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutputLbl.Location = new System.Drawing.Point(356, 222);
            this.totalOutputLbl.Name = "totalOutputLbl";
            this.totalOutputLbl.Size = new System.Drawing.Size(239, 40);
            this.totalOutputLbl.TabIndex = 7;
            this.totalOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeCounterApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(625, 571);
            this.Controls.Add(this.totalOutputLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.fiftyCentsPictureBox);
            this.Controls.Add(this.twentyFiveCentsPictureBox);
            this.Controls.Add(this.tenCenysPictureBox);
            this.Controls.Add(this.fiveCentsPictureBox);
            this.Controls.Add(this.instructionalLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ChangeCounterApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Counter Application";
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCenysPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionalLabel;
        private System.Windows.Forms.PictureBox fiveCentsPictureBox;
        private System.Windows.Forms.PictureBox tenCenysPictureBox;
        private System.Windows.Forms.PictureBox twentyFiveCentsPictureBox;
        private System.Windows.Forms.PictureBox fiftyCentsPictureBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label totalOutputLbl;
    }
}

