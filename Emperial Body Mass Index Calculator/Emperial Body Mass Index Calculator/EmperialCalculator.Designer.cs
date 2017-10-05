namespace Emperial_Body_Mass_Index_Calculator
{
    partial class EmperialCalculator
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
            this.weightPromptLBL = new System.Windows.Forms.Label();
            this.inchesPromptLBL = new System.Windows.Forms.Label();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.inchesTextBox = new System.Windows.Forms.TextBox();
            this.calculateBMI_btn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.BodyMassIndexLabel = new System.Windows.Forms.Label();
            this.BMI_OutPutLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightPromptLBL
            // 
            this.weightPromptLBL.Location = new System.Drawing.Point(26, 42);
            this.weightPromptLBL.Name = "weightPromptLBL";
            this.weightPromptLBL.Size = new System.Drawing.Size(303, 35);
            this.weightPromptLBL.TabIndex = 0;
            this.weightPromptLBL.Text = "Enter Weight (in Pounds):";
            this.weightPromptLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inchesPromptLBL
            // 
            this.inchesPromptLBL.Location = new System.Drawing.Point(26, 89);
            this.inchesPromptLBL.Name = "inchesPromptLBL";
            this.inchesPromptLBL.Size = new System.Drawing.Size(303, 35);
            this.inchesPromptLBL.TabIndex = 1;
            this.inchesPromptLBL.Text = "Enter Height (in Inches):";
            this.inchesPromptLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Location = new System.Drawing.Point(335, 43);
            this.poundsTextBox.Multiline = true;
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(377, 35);
            this.poundsTextBox.TabIndex = 2;
            // 
            // inchesTextBox
            // 
            this.inchesTextBox.Location = new System.Drawing.Point(335, 90);
            this.inchesTextBox.Multiline = true;
            this.inchesTextBox.Name = "inchesTextBox";
            this.inchesTextBox.Size = new System.Drawing.Size(377, 35);
            this.inchesTextBox.TabIndex = 3;
            // 
            // calculateBMI_btn
            // 
            this.calculateBMI_btn.Location = new System.Drawing.Point(180, 270);
            this.calculateBMI_btn.Name = "calculateBMI_btn";
            this.calculateBMI_btn.Size = new System.Drawing.Size(174, 64);
            this.calculateBMI_btn.TabIndex = 4;
            this.calculateBMI_btn.Text = "C&alculate BMI";
            this.calculateBMI_btn.UseVisualStyleBackColor = true;
            this.calculateBMI_btn.Click += new System.EventHandler(this.calculateBMI_btn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(360, 270);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(174, 64);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Cl&ear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(538, 270);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(174, 64);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // BodyMassIndexLabel
            // 
            this.BodyMassIndexLabel.Location = new System.Drawing.Point(72, 185);
            this.BodyMassIndexLabel.Name = "BodyMassIndexLabel";
            this.BodyMassIndexLabel.Size = new System.Drawing.Size(207, 43);
            this.BodyMassIndexLabel.TabIndex = 7;
            this.BodyMassIndexLabel.Text = "Body Mass Index:";
            this.BodyMassIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMI_OutPutLBL
            // 
            this.BMI_OutPutLBL.BackColor = System.Drawing.Color.White;
            this.BMI_OutPutLBL.ForeColor = System.Drawing.Color.Black;
            this.BMI_OutPutLBL.Location = new System.Drawing.Point(330, 185);
            this.BMI_OutPutLBL.Name = "BMI_OutPutLBL";
            this.BMI_OutPutLBL.Size = new System.Drawing.Size(382, 43);
            this.BMI_OutPutLBL.TabIndex = 8;
            this.BMI_OutPutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmperialCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 401);
            this.Controls.Add(this.BMI_OutPutLBL);
            this.Controls.Add(this.BodyMassIndexLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBMI_btn);
            this.Controls.Add(this.inchesTextBox);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.inchesPromptLBL);
            this.Controls.Add(this.weightPromptLBL);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EmperialCalculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emperial_BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightPromptLBL;
        private System.Windows.Forms.Label inchesPromptLBL;
        private System.Windows.Forms.TextBox poundsTextBox;
        private System.Windows.Forms.TextBox inchesTextBox;
        private System.Windows.Forms.Button calculateBMI_btn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label BodyMassIndexLabel;
        private System.Windows.Forms.Label BMI_OutPutLBL;
    }
}

