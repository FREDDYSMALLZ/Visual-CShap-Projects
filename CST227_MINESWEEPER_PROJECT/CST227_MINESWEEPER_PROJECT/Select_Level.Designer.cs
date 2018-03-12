namespace CST227_MINESWEEPER_PROJECT
{
    partial class Select_Level
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
            this.selectLevel_LBL = new System.Windows.Forms.Label();
            this.rd_Bttn_Easy = new System.Windows.Forms.RadioButton();
            this.rdBttn_Moderate = new System.Windows.Forms.RadioButton();
            this.rdBttn_Difficult = new System.Windows.Forms.RadioButton();
            this.bttn_Cancel = new System.Windows.Forms.Button();
            this.bttn_StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectLevel_LBL
            // 
            this.selectLevel_LBL.AutoSize = true;
            this.selectLevel_LBL.Location = new System.Drawing.Point(95, 70);
            this.selectLevel_LBL.Name = "selectLevel_LBL";
            this.selectLevel_LBL.Size = new System.Drawing.Size(432, 26);
            this.selectLevel_LBL.TabIndex = 0;
            this.selectLevel_LBL.Text = "Please Select the Level to Start the Game";
            // 
            // rd_Bttn_Easy
            // 
            this.rd_Bttn_Easy.AutoSize = true;
            this.rd_Bttn_Easy.Location = new System.Drawing.Point(100, 138);
            this.rd_Bttn_Easy.Name = "rd_Bttn_Easy";
            this.rd_Bttn_Easy.Size = new System.Drawing.Size(86, 30);
            this.rd_Bttn_Easy.TabIndex = 1;
            this.rd_Bttn_Easy.TabStop = true;
            this.rd_Bttn_Easy.Text = "&Easy";
            this.rd_Bttn_Easy.UseVisualStyleBackColor = true;
            this.rd_Bttn_Easy.CheckedChanged += new System.EventHandler(this.rd_Bttn_Easy_CheckedChanged);
            // 
            // rdBttn_Moderate
            // 
            this.rdBttn_Moderate.AutoSize = true;
            this.rdBttn_Moderate.Location = new System.Drawing.Point(100, 222);
            this.rdBttn_Moderate.Name = "rdBttn_Moderate";
            this.rdBttn_Moderate.Size = new System.Drawing.Size(138, 30);
            this.rdBttn_Moderate.TabIndex = 2;
            this.rdBttn_Moderate.TabStop = true;
            this.rdBttn_Moderate.Text = "&Moderate";
            this.rdBttn_Moderate.UseVisualStyleBackColor = true;
            this.rdBttn_Moderate.CheckedChanged += new System.EventHandler(this.rdBttn_Moderate_CheckedChanged);
            // 
            // rdBttn_Difficult
            // 
            this.rdBttn_Difficult.AutoSize = true;
            this.rdBttn_Difficult.Location = new System.Drawing.Point(100, 307);
            this.rdBttn_Difficult.Name = "rdBttn_Difficult";
            this.rdBttn_Difficult.Size = new System.Drawing.Size(121, 30);
            this.rdBttn_Difficult.TabIndex = 3;
            this.rdBttn_Difficult.TabStop = true;
            this.rdBttn_Difficult.Text = "&Difficult";
            this.rdBttn_Difficult.UseVisualStyleBackColor = true;
            this.rdBttn_Difficult.CheckedChanged += new System.EventHandler(this.rdBttn_Difficult_CheckedChanged);
            // 
            // bttn_Cancel
            // 
            this.bttn_Cancel.Location = new System.Drawing.Point(100, 381);
            this.bttn_Cancel.Name = "bttn_Cancel";
            this.bttn_Cancel.Size = new System.Drawing.Size(210, 45);
            this.bttn_Cancel.TabIndex = 4;
            this.bttn_Cancel.Text = "&Cancel";
            this.bttn_Cancel.UseVisualStyleBackColor = true;
            this.bttn_Cancel.Click += new System.EventHandler(this.bttn_Cancel_Click);
            // 
            // bttn_StartGame
            // 
            this.bttn_StartGame.Location = new System.Drawing.Point(402, 381);
            this.bttn_StartGame.Name = "bttn_StartGame";
            this.bttn_StartGame.Size = new System.Drawing.Size(210, 45);
            this.bttn_StartGame.TabIndex = 5;
            this.bttn_StartGame.Text = "&Start Game";
            this.bttn_StartGame.UseVisualStyleBackColor = true;
            this.bttn_StartGame.Click += new System.EventHandler(this.bttn_StartGame_Click);
            // 
            // Select_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 456);
            this.Controls.Add(this.bttn_StartGame);
            this.Controls.Add(this.bttn_Cancel);
            this.Controls.Add(this.rdBttn_Difficult);
            this.Controls.Add(this.rdBttn_Moderate);
            this.Controls.Add(this.rd_Bttn_Easy);
            this.Controls.Add(this.selectLevel_LBL);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Select_Level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Level";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Select_Level_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectLevel_LBL;
        private System.Windows.Forms.RadioButton rd_Bttn_Easy;
        private System.Windows.Forms.RadioButton rdBttn_Moderate;
        private System.Windows.Forms.RadioButton rdBttn_Difficult;
        private System.Windows.Forms.Button bttn_Cancel;
        private System.Windows.Forms.Button bttn_StartGame;
    }
}