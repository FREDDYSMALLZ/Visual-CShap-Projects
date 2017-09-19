namespace Library_Management_System
{
    partial class Plan
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
            this.planRows_Count_OutputLBL = new System.Windows.Forms.Label();
            this.plan_rowsCountLBL = new System.Windows.Forms.Label();
            this.plan_dataGridView = new System.Windows.Forms.DataGridView();
            this.update_UpdateBTN = new System.Windows.Forms.Button();
            this.plan_DeleteBTN = new System.Windows.Forms.Button();
            this.plan_SaveBTN = new System.Windows.Forms.Button();
            this.planNewBTN = new System.Windows.Forms.Button();
            this.status_SectionComboBox = new System.Windows.Forms.ComboBox();
            this.planNameTextbox = new System.Windows.Forms.TextBox();
            this.plan_IdTextBox = new System.Windows.Forms.TextBox();
            this.planLBL = new System.Windows.Forms.Label();
            this.status_SectionLBL = new System.Windows.Forms.Label();
            this.plan_IdLBL = new System.Windows.Forms.Label();
            this.planDateCreationLBL = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.planLimitLBL = new System.Windows.Forms.Label();
            this.planLimitTextBox = new System.Windows.Forms.TextBox();
            this.planBKHoldLBL = new System.Windows.Forms.Label();
            this.planBKtextBox = new System.Windows.Forms.TextBox();
            this.planValidityLBL = new System.Windows.Forms.Label();
            this.planValidityTextBox = new System.Windows.Forms.TextBox();
            this.planAmountLBL = new System.Windows.Forms.Label();
            this.planAmountTextBox = new System.Windows.Forms.TextBox();
            this.planDiscLBL = new System.Windows.Forms.Label();
            this.planDiscTextBox = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.plan_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // planRows_Count_OutputLBL
            // 
            this.planRows_Count_OutputLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.planRows_Count_OutputLBL.Location = new System.Drawing.Point(946, 793);
            this.planRows_Count_OutputLBL.Name = "planRows_Count_OutputLBL";
            this.planRows_Count_OutputLBL.Size = new System.Drawing.Size(238, 42);
            this.planRows_Count_OutputLBL.TabIndex = 38;
            this.planRows_Count_OutputLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plan_rowsCountLBL
            // 
            this.plan_rowsCountLBL.Location = new System.Drawing.Point(773, 793);
            this.plan_rowsCountLBL.Name = "plan_rowsCountLBL";
            this.plan_rowsCountLBL.Size = new System.Drawing.Size(167, 42);
            this.plan_rowsCountLBL.TabIndex = 37;
            this.plan_rowsCountLBL.Text = "Rows Count:";
            this.plan_rowsCountLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // plan_dataGridView
            // 
            this.plan_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plan_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.plan_dataGridView.Location = new System.Drawing.Point(24, 443);
            this.plan_dataGridView.Name = "plan_dataGridView";
            this.plan_dataGridView.RowTemplate.Height = 28;
            this.plan_dataGridView.Size = new System.Drawing.Size(1160, 332);
            this.plan_dataGridView.TabIndex = 36;
            // 
            // update_UpdateBTN
            // 
            this.update_UpdateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update_UpdateBTN.Location = new System.Drawing.Point(420, 372);
            this.update_UpdateBTN.Name = "update_UpdateBTN";
            this.update_UpdateBTN.Size = new System.Drawing.Size(216, 46);
            this.update_UpdateBTN.TabIndex = 35;
            this.update_UpdateBTN.Text = "Update";
            this.update_UpdateBTN.UseVisualStyleBackColor = false;
            // 
            // plan_DeleteBTN
            // 
            this.plan_DeleteBTN.BackColor = System.Drawing.Color.Red;
            this.plan_DeleteBTN.Location = new System.Drawing.Point(663, 372);
            this.plan_DeleteBTN.Name = "plan_DeleteBTN";
            this.plan_DeleteBTN.Size = new System.Drawing.Size(216, 46);
            this.plan_DeleteBTN.TabIndex = 34;
            this.plan_DeleteBTN.Text = "Delete";
            this.plan_DeleteBTN.UseVisualStyleBackColor = false;
            // 
            // plan_SaveBTN
            // 
            this.plan_SaveBTN.BackColor = System.Drawing.Color.Lime;
            this.plan_SaveBTN.Location = new System.Drawing.Point(903, 372);
            this.plan_SaveBTN.Name = "plan_SaveBTN";
            this.plan_SaveBTN.Size = new System.Drawing.Size(216, 46);
            this.plan_SaveBTN.TabIndex = 33;
            this.plan_SaveBTN.Text = "Save";
            this.plan_SaveBTN.UseVisualStyleBackColor = false;
            // 
            // planNewBTN
            // 
            this.planNewBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.planNewBTN.Location = new System.Drawing.Point(185, 372);
            this.planNewBTN.Name = "planNewBTN";
            this.planNewBTN.Size = new System.Drawing.Size(216, 46);
            this.planNewBTN.TabIndex = 32;
            this.planNewBTN.Text = "New";
            this.planNewBTN.UseVisualStyleBackColor = false;
            // 
            // status_SectionComboBox
            // 
            this.status_SectionComboBox.FormattingEnabled = true;
            this.status_SectionComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_SectionComboBox.Location = new System.Drawing.Point(818, 250);
            this.status_SectionComboBox.Name = "status_SectionComboBox";
            this.status_SectionComboBox.Size = new System.Drawing.Size(366, 39);
            this.status_SectionComboBox.TabIndex = 31;
            // 
            // planNameTextbox
            // 
            this.planNameTextbox.Location = new System.Drawing.Point(208, 100);
            this.planNameTextbox.Name = "planNameTextbox";
            this.planNameTextbox.Size = new System.Drawing.Size(366, 39);
            this.planNameTextbox.TabIndex = 30;
            // 
            // plan_IdTextBox
            // 
            this.plan_IdTextBox.Location = new System.Drawing.Point(208, 46);
            this.plan_IdTextBox.Name = "plan_IdTextBox";
            this.plan_IdTextBox.Size = new System.Drawing.Size(366, 39);
            this.plan_IdTextBox.TabIndex = 29;
            // 
            // planLBL
            // 
            this.planLBL.Location = new System.Drawing.Point(27, 93);
            this.planLBL.Name = "planLBL";
            this.planLBL.Size = new System.Drawing.Size(184, 42);
            this.planLBL.TabIndex = 28;
            this.planLBL.Text = "Plan Name:";
            this.planLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // status_SectionLBL
            // 
            this.status_SectionLBL.Location = new System.Drawing.Point(674, 243);
            this.status_SectionLBL.Name = "status_SectionLBL";
            this.status_SectionLBL.Size = new System.Drawing.Size(138, 42);
            this.status_SectionLBL.TabIndex = 27;
            this.status_SectionLBL.Text = "Status:";
            this.status_SectionLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // plan_IdLBL
            // 
            this.plan_IdLBL.Location = new System.Drawing.Point(64, 39);
            this.plan_IdLBL.Name = "plan_IdLBL";
            this.plan_IdLBL.Size = new System.Drawing.Size(138, 42);
            this.plan_IdLBL.TabIndex = 26;
            this.plan_IdLBL.Text = "Plan Id:";
            this.plan_IdLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // planDateCreationLBL
            // 
            this.planDateCreationLBL.Location = new System.Drawing.Point(1, 165);
            this.planDateCreationLBL.Name = "planDateCreationLBL";
            this.planDateCreationLBL.Size = new System.Drawing.Size(201, 42);
            this.planDateCreationLBL.TabIndex = 39;
            this.planDateCreationLBL.Text = "Date of Creation:";
            this.planDateCreationLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(366, 39);
            this.dateTimePicker1.TabIndex = 40;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // planLimitLBL
            // 
            this.planLimitLBL.Location = new System.Drawing.Point(18, 233);
            this.planLimitLBL.Name = "planLimitLBL";
            this.planLimitLBL.Size = new System.Drawing.Size(184, 42);
            this.planLimitLBL.TabIndex = 41;
            this.planLimitLBL.Text = "Limit:";
            this.planLimitLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // planLimitTextBox
            // 
            this.planLimitTextBox.Location = new System.Drawing.Point(208, 240);
            this.planLimitTextBox.Name = "planLimitTextBox";
            this.planLimitTextBox.Size = new System.Drawing.Size(366, 39);
            this.planLimitTextBox.TabIndex = 42;
            // 
            // planBKHoldLBL
            // 
            this.planBKHoldLBL.Location = new System.Drawing.Point(1, 307);
            this.planBKHoldLBL.Name = "planBKHoldLBL";
            this.planBKHoldLBL.Size = new System.Drawing.Size(201, 42);
            this.planBKHoldLBL.TabIndex = 43;
            this.planBKHoldLBL.Text = "Book Can Hold:";
            this.planBKHoldLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // planBKtextBox
            // 
            this.planBKtextBox.Location = new System.Drawing.Point(208, 310);
            this.planBKtextBox.Name = "planBKtextBox";
            this.planBKtextBox.Size = new System.Drawing.Size(366, 39);
            this.planBKtextBox.TabIndex = 44;
            // 
            // planValidityLBL
            // 
            this.planValidityLBL.Location = new System.Drawing.Point(674, 56);
            this.planValidityLBL.Name = "planValidityLBL";
            this.planValidityLBL.Size = new System.Drawing.Size(138, 42);
            this.planValidityLBL.TabIndex = 45;
            this.planValidityLBL.Text = "Validity:";
            this.planValidityLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // planValidityTextBox
            // 
            this.planValidityTextBox.Location = new System.Drawing.Point(818, 63);
            this.planValidityTextBox.Name = "planValidityTextBox";
            this.planValidityTextBox.Size = new System.Drawing.Size(366, 39);
            this.planValidityTextBox.TabIndex = 46;
            // 
            // planAmountLBL
            // 
            this.planAmountLBL.Location = new System.Drawing.Point(674, 110);
            this.planAmountLBL.Name = "planAmountLBL";
            this.planAmountLBL.Size = new System.Drawing.Size(138, 42);
            this.planAmountLBL.TabIndex = 47;
            this.planAmountLBL.Text = "Amount:";
            this.planAmountLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // planAmountTextBox
            // 
            this.planAmountTextBox.Location = new System.Drawing.Point(818, 117);
            this.planAmountTextBox.Name = "planAmountTextBox";
            this.planAmountTextBox.Size = new System.Drawing.Size(366, 39);
            this.planAmountTextBox.TabIndex = 48;
            // 
            // planDiscLBL
            // 
            this.planDiscLBL.Location = new System.Drawing.Point(674, 175);
            this.planDiscLBL.Name = "planDiscLBL";
            this.planDiscLBL.Size = new System.Drawing.Size(138, 42);
            this.planDiscLBL.TabIndex = 49;
            this.planDiscLBL.Text = "Discount:";
            this.planDiscLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // planDiscTextBox
            // 
            this.planDiscTextBox.Location = new System.Drawing.Point(818, 182);
            this.planDiscTextBox.Name = "planDiscTextBox";
            this.planDiscTextBox.Size = new System.Drawing.Size(366, 39);
            this.planDiscTextBox.TabIndex = 50;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Plan Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Doc";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Limit";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Hold";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Validity";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Discount";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Status";
            this.Column9.Name = "Column9";
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1193, 847);
            this.Controls.Add(this.planDiscTextBox);
            this.Controls.Add(this.planDiscLBL);
            this.Controls.Add(this.planAmountTextBox);
            this.Controls.Add(this.planAmountLBL);
            this.Controls.Add(this.planValidityTextBox);
            this.Controls.Add(this.planValidityLBL);
            this.Controls.Add(this.planBKtextBox);
            this.Controls.Add(this.planBKHoldLBL);
            this.Controls.Add(this.planLimitTextBox);
            this.Controls.Add(this.planLimitLBL);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.planDateCreationLBL);
            this.Controls.Add(this.planRows_Count_OutputLBL);
            this.Controls.Add(this.plan_rowsCountLBL);
            this.Controls.Add(this.plan_dataGridView);
            this.Controls.Add(this.update_UpdateBTN);
            this.Controls.Add(this.plan_DeleteBTN);
            this.Controls.Add(this.plan_SaveBTN);
            this.Controls.Add(this.planNewBTN);
            this.Controls.Add(this.status_SectionComboBox);
            this.Controls.Add(this.planNameTextbox);
            this.Controls.Add(this.plan_IdTextBox);
            this.Controls.Add(this.planLBL);
            this.Controls.Add(this.status_SectionLBL);
            this.Controls.Add(this.plan_IdLBL);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1219, 907);
            this.MinimumSize = new System.Drawing.Size(1219, 907);
            this.Name = "Plan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan";
            ((System.ComponentModel.ISupportInitialize)(this.plan_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label planRows_Count_OutputLBL;
        private System.Windows.Forms.Label plan_rowsCountLBL;
        private System.Windows.Forms.DataGridView plan_dataGridView;
        private System.Windows.Forms.Button update_UpdateBTN;
        private System.Windows.Forms.Button plan_DeleteBTN;
        private System.Windows.Forms.Button plan_SaveBTN;
        private System.Windows.Forms.Button planNewBTN;
        private System.Windows.Forms.ComboBox status_SectionComboBox;
        private System.Windows.Forms.TextBox planNameTextbox;
        private System.Windows.Forms.TextBox plan_IdTextBox;
        private System.Windows.Forms.Label planLBL;
        private System.Windows.Forms.Label status_SectionLBL;
        private System.Windows.Forms.Label plan_IdLBL;
        private System.Windows.Forms.Label planDateCreationLBL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label planLimitLBL;
        private System.Windows.Forms.TextBox planLimitTextBox;
        private System.Windows.Forms.Label planBKHoldLBL;
        private System.Windows.Forms.TextBox planBKtextBox;
        private System.Windows.Forms.Label planValidityLBL;
        private System.Windows.Forms.TextBox planValidityTextBox;
        private System.Windows.Forms.Label planAmountLBL;
        private System.Windows.Forms.TextBox planAmountTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label planDiscLBL;
        private System.Windows.Forms.TextBox planDiscTextBox;
    }
}