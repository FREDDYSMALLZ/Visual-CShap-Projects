namespace Time_Zone_Application
{
    partial class TimeApplication
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
            this.citylistBox = new System.Windows.Forms.ListBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.time_ZoneLBL = new System.Windows.Forms.Label();
            this.display_Time_ZoneLBL = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // citylistBox
            // 
            this.citylistBox.FormattingEnabled = true;
            this.citylistBox.ItemHeight = 31;
            this.citylistBox.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapollis",
            "New York",
            "San Francisco",
            "Arlington",
            "Grand Prairie",
            "Mansfield",
            "Knoxville",
            "Forworth",
            "Alabama",
            "Mason city",
            "Phoenix",
            "Sweet Waters",
            "Salt Lake city"});
            this.citylistBox.Location = new System.Drawing.Point(64, 75);
            this.citylistBox.Name = "citylistBox";
            this.citylistBox.Size = new System.Drawing.Size(526, 159);
            this.citylistBox.TabIndex = 0;
            // 
            // promptLabel
            // 
            this.promptLabel.Location = new System.Drawing.Point(58, 23);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(532, 39);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = "Select a City and I will give you the time zone.";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_ZoneLBL
            // 
            this.time_ZoneLBL.AutoSize = true;
            this.time_ZoneLBL.Location = new System.Drawing.Point(67, 282);
            this.time_ZoneLBL.Name = "time_ZoneLBL";
            this.time_ZoneLBL.Size = new System.Drawing.Size(141, 31);
            this.time_ZoneLBL.TabIndex = 2;
            this.time_ZoneLBL.Text = "Time Zone:";
            // 
            // display_Time_ZoneLBL
            // 
            this.display_Time_ZoneLBL.BackColor = System.Drawing.Color.White;
            this.display_Time_ZoneLBL.Location = new System.Drawing.Point(214, 282);
            this.display_Time_ZoneLBL.Name = "display_Time_ZoneLBL";
            this.display_Time_ZoneLBL.Size = new System.Drawing.Size(376, 31);
            this.display_Time_ZoneLBL.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(220, 356);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(155, 49);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(435, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TimeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(654, 418);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.display_Time_ZoneLBL);
            this.Controls.Add(this.time_ZoneLBL);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.citylistBox);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TimeApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Zone Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox citylistBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label time_ZoneLBL;
        private System.Windows.Forms.Label display_Time_ZoneLBL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
    }
}

