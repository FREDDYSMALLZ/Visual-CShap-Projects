namespace String_Variable_Demo
{
    partial class String_Demo
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.showNamebtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.firstNametextBox = new System.Windows.Forms.TextBox();
            this.lastNametextBox = new System.Windows.Forms.TextBox();
            this.fullNametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(23, 27);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(215, 34);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Enter your First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(23, 95);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(215, 34);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Enter your Last Name:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Location = new System.Drawing.Point(23, 179);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(215, 34);
            this.fullNameLabel.TabIndex = 2;
            this.fullNameLabel.Text = "This is your Full Name:";
            // 
            // showNamebtn
            // 
            this.showNamebtn.Location = new System.Drawing.Point(162, 261);
            this.showNamebtn.Name = "showNamebtn";
            this.showNamebtn.Size = new System.Drawing.Size(146, 41);
            this.showNamebtn.TabIndex = 3;
            this.showNamebtn.Text = "Show Name";
            this.showNamebtn.UseVisualStyleBackColor = true;
            this.showNamebtn.Click += new System.EventHandler(this.showNamebtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(457, 261);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(146, 41);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // firstNametextBox
            // 
            this.firstNametextBox.Location = new System.Drawing.Point(236, 34);
            this.firstNametextBox.Name = "firstNametextBox";
            this.firstNametextBox.Size = new System.Drawing.Size(367, 30);
            this.firstNametextBox.TabIndex = 5;
            // 
            // lastNametextBox
            // 
            this.lastNametextBox.Location = new System.Drawing.Point(236, 99);
            this.lastNametextBox.Name = "lastNametextBox";
            this.lastNametextBox.Size = new System.Drawing.Size(367, 30);
            this.lastNametextBox.TabIndex = 6;
            // 
            // fullNametextBox
            // 
            this.fullNametextBox.Location = new System.Drawing.Point(236, 176);
            this.fullNametextBox.Name = "fullNametextBox";
            this.fullNametextBox.Size = new System.Drawing.Size(367, 30);
            this.fullNametextBox.TabIndex = 7;
            // 
            // String_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 314);
            this.Controls.Add(this.fullNametextBox);
            this.Controls.Add(this.lastNametextBox);
            this.Controls.Add(this.firstNametextBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showNamebtn);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "String_Demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button showNamebtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox firstNametextBox;
        private System.Windows.Forms.TextBox lastNametextBox;
        private System.Windows.Forms.TextBox fullNametextBox;
    }
}

