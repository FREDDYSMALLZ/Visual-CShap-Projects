namespace Library_Management_System
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            this.userChangeLBL = new System.Windows.Forms.Label();
            this.oldPassLBL = new System.Windows.Forms.Label();
            this.newPassLBL = new System.Windows.Forms.Label();
            this.userChangeTextBox = new System.Windows.Forms.TextBox();
            this.oldPassTextBox = new System.Windows.Forms.TextBox();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.changeBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userChangeLBL
            // 
            this.userChangeLBL.Location = new System.Drawing.Point(205, 43);
            this.userChangeLBL.Name = "userChangeLBL";
            this.userChangeLBL.Size = new System.Drawing.Size(177, 47);
            this.userChangeLBL.TabIndex = 0;
            this.userChangeLBL.Text = "   Username:";
            this.userChangeLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // oldPassLBL
            // 
            this.oldPassLBL.Location = new System.Drawing.Point(205, 101);
            this.oldPassLBL.Name = "oldPassLBL";
            this.oldPassLBL.Size = new System.Drawing.Size(177, 47);
            this.oldPassLBL.TabIndex = 1;
            this.oldPassLBL.Text = "Old Password:";
            this.oldPassLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // newPassLBL
            // 
            this.newPassLBL.Location = new System.Drawing.Point(205, 170);
            this.newPassLBL.Name = "newPassLBL";
            this.newPassLBL.Size = new System.Drawing.Size(177, 47);
            this.newPassLBL.TabIndex = 2;
            this.newPassLBL.Text = "New Password:";
            this.newPassLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // userChangeTextBox
            // 
            this.userChangeTextBox.Location = new System.Drawing.Point(405, 51);
            this.userChangeTextBox.Name = "userChangeTextBox";
            this.userChangeTextBox.Size = new System.Drawing.Size(304, 39);
            this.userChangeTextBox.TabIndex = 3;
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.Location = new System.Drawing.Point(405, 113);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.PasswordChar = '*';
            this.oldPassTextBox.Size = new System.Drawing.Size(304, 39);
            this.oldPassTextBox.TabIndex = 4;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(405, 182);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.PasswordChar = '*';
            this.newPassTextBox.Size = new System.Drawing.Size(304, 39);
            this.newPassTextBox.TabIndex = 5;
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancelBTN.Location = new System.Drawing.Point(405, 258);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(142, 59);
            this.cancelBTN.TabIndex = 6;
            this.cancelBTN.Text = "C&ancel";
            this.cancelBTN.UseVisualStyleBackColor = false;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // changeBTN
            // 
            this.changeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.changeBTN.Location = new System.Drawing.Point(566, 258);
            this.changeBTN.Name = "changeBTN";
            this.changeBTN.Size = new System.Drawing.Size(143, 59);
            this.changeBTN.TabIndex = 7;
            this.changeBTN.Text = "C&hange";
            this.changeBTN.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(725, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.changeBTN);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.oldPassTextBox);
            this.Controls.Add(this.userChangeTextBox);
            this.Controls.Add(this.newPassLBL);
            this.Controls.Add(this.oldPassLBL);
            this.Controls.Add(this.userChangeLBL);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(751, 402);
            this.MinimumSize = new System.Drawing.Size(751, 402);
            this.Name = "Change_Password";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Username";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userChangeLBL;
        private System.Windows.Forms.Label oldPassLBL;
        private System.Windows.Forms.Label newPassLBL;
        private System.Windows.Forms.TextBox userChangeTextBox;
        private System.Windows.Forms.TextBox oldPassTextBox;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button changeBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}