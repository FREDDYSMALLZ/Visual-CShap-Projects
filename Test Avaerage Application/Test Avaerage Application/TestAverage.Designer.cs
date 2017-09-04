namespace Test_Avaerage_Application
{
    partial class TestAverage
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
            this.test1Lbl = new System.Windows.Forms.Label();
            this.test3Lbl = new System.Windows.Forms.Label();
            this.test2Lbl = new System.Windows.Forms.Label();
            this.averageTestLbl = new System.Windows.Forms.Label();
            this.computeAverageBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.averageTestScoreLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // test1Lbl
            // 
            this.test1Lbl.Location = new System.Drawing.Point(70, 52);
            this.test1Lbl.Name = "test1Lbl";
            this.test1Lbl.Size = new System.Drawing.Size(107, 31);
            this.test1Lbl.TabIndex = 0;
            this.test1Lbl.Text = "Test 1:";
            // 
            // test3Lbl
            // 
            this.test3Lbl.Location = new System.Drawing.Point(70, 195);
            this.test3Lbl.Name = "test3Lbl";
            this.test3Lbl.Size = new System.Drawing.Size(107, 31);
            this.test3Lbl.TabIndex = 1;
            this.test3Lbl.Text = "Test 3:";
            // 
            // test2Lbl
            // 
            this.test2Lbl.Location = new System.Drawing.Point(70, 127);
            this.test2Lbl.Name = "test2Lbl";
            this.test2Lbl.Size = new System.Drawing.Size(107, 31);
            this.test2Lbl.TabIndex = 2;
            this.test2Lbl.Text = "Test 2:";
            // 
            // averageTestLbl
            // 
            this.averageTestLbl.Location = new System.Drawing.Point(70, 251);
            this.averageTestLbl.Name = "averageTestLbl";
            this.averageTestLbl.Size = new System.Drawing.Size(228, 43);
            this.averageTestLbl.TabIndex = 3;
            this.averageTestLbl.Text = "Average Test Score:";
            // 
            // computeAverageBtn
            // 
            this.computeAverageBtn.BackColor = System.Drawing.Color.Lime;
            this.computeAverageBtn.Location = new System.Drawing.Point(75, 308);
            this.computeAverageBtn.Name = "computeAverageBtn";
            this.computeAverageBtn.Size = new System.Drawing.Size(223, 45);
            this.computeAverageBtn.TabIndex = 4;
            this.computeAverageBtn.Text = "Cumpute Average";
            this.computeAverageBtn.UseVisualStyleBackColor = false;
            this.computeAverageBtn.Click += new System.EventHandler(this.computeAverageBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clearBtn.Location = new System.Drawing.Point(304, 308);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(223, 45);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.Location = new System.Drawing.Point(533, 308);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(223, 45);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // averageTestScoreLabel
            // 
            this.averageTestScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageTestScoreLabel.Location = new System.Drawing.Point(304, 251);
            this.averageTestScoreLabel.Name = "averageTestScoreLabel";
            this.averageTestScoreLabel.Size = new System.Drawing.Size(452, 43);
            this.averageTestScoreLabel.TabIndex = 7;
            this.averageTestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(304, 49);
            this.test1TextBox.Multiline = true;
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(452, 42);
            this.test1TextBox.TabIndex = 8;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(304, 116);
            this.test2TextBox.Multiline = true;
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(452, 42);
            this.test2TextBox.TabIndex = 9;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(304, 184);
            this.test3TextBox.Multiline = true;
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(452, 42);
            this.test3TextBox.TabIndex = 10;
            // 
            // TestAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(838, 410);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.averageTestScoreLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.computeAverageBtn);
            this.Controls.Add(this.averageTestLbl);
            this.Controls.Add(this.test2Lbl);
            this.Controls.Add(this.test3Lbl);
            this.Controls.Add(this.test1Lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TestAverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Average Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1Lbl;
        private System.Windows.Forms.Label test3Lbl;
        private System.Windows.Forms.Label test2Lbl;
        private System.Windows.Forms.Label averageTestLbl;
        private System.Windows.Forms.Button computeAverageBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label averageTestScoreLabel;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
    }
}

