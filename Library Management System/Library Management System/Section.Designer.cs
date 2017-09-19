namespace Library_Management_System
{
    partial class Section
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
            this.sectionRows_Count_OutputLBL = new System.Windows.Forms.Label();
            this.section_rowsCountLBL = new System.Windows.Forms.Label();
            this.section_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_UpdateBTN = new System.Windows.Forms.Button();
            this.section_DeleteBTN = new System.Windows.Forms.Button();
            this.section_SaveBTN = new System.Windows.Forms.Button();
            this.sectionNewBTN = new System.Windows.Forms.Button();
            this.status_SectionComboBox = new System.Windows.Forms.ComboBox();
            this.sectionNameTextbox = new System.Windows.Forms.TextBox();
            this.section_IdTextBox = new System.Windows.Forms.TextBox();
            this.sectionLBL = new System.Windows.Forms.Label();
            this.status_SectionLBL = new System.Windows.Forms.Label();
            this.section_IdLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.section_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionRows_Count_OutputLBL
            // 
            this.sectionRows_Count_OutputLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sectionRows_Count_OutputLBL.Location = new System.Drawing.Point(651, 559);
            this.sectionRows_Count_OutputLBL.Name = "sectionRows_Count_OutputLBL";
            this.sectionRows_Count_OutputLBL.Size = new System.Drawing.Size(238, 42);
            this.sectionRows_Count_OutputLBL.TabIndex = 25;
            this.sectionRows_Count_OutputLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section_rowsCountLBL
            // 
            this.section_rowsCountLBL.Location = new System.Drawing.Point(478, 559);
            this.section_rowsCountLBL.Name = "section_rowsCountLBL";
            this.section_rowsCountLBL.Size = new System.Drawing.Size(167, 42);
            this.section_rowsCountLBL.TabIndex = 24;
            this.section_rowsCountLBL.Text = "Rows Count:";
            this.section_rowsCountLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // section_dataGridView
            // 
            this.section_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.section_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.section_dataGridView.Location = new System.Drawing.Point(64, 239);
            this.section_dataGridView.Name = "section_dataGridView";
            this.section_dataGridView.RowTemplate.Height = 28;
            this.section_dataGridView.Size = new System.Drawing.Size(825, 302);
            this.section_dataGridView.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Section Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Section Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            // 
            // section_UpdateBTN
            // 
            this.section_UpdateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.section_UpdateBTN.Location = new System.Drawing.Point(673, 83);
            this.section_UpdateBTN.Name = "section_UpdateBTN";
            this.section_UpdateBTN.Size = new System.Drawing.Size(216, 46);
            this.section_UpdateBTN.TabIndex = 22;
            this.section_UpdateBTN.Text = "Update";
            this.section_UpdateBTN.UseVisualStyleBackColor = false;
            // 
            // section_DeleteBTN
            // 
            this.section_DeleteBTN.BackColor = System.Drawing.Color.Red;
            this.section_DeleteBTN.Location = new System.Drawing.Point(673, 135);
            this.section_DeleteBTN.Name = "section_DeleteBTN";
            this.section_DeleteBTN.Size = new System.Drawing.Size(216, 46);
            this.section_DeleteBTN.TabIndex = 21;
            this.section_DeleteBTN.Text = "Delete";
            this.section_DeleteBTN.UseVisualStyleBackColor = false;
            // 
            // section_SaveBTN
            // 
            this.section_SaveBTN.BackColor = System.Drawing.Color.Lime;
            this.section_SaveBTN.Location = new System.Drawing.Point(673, 187);
            this.section_SaveBTN.Name = "section_SaveBTN";
            this.section_SaveBTN.Size = new System.Drawing.Size(216, 46);
            this.section_SaveBTN.TabIndex = 20;
            this.section_SaveBTN.Text = "Save";
            this.section_SaveBTN.UseVisualStyleBackColor = false;
            // 
            // sectionNewBTN
            // 
            this.sectionNewBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sectionNewBTN.Location = new System.Drawing.Point(673, 31);
            this.sectionNewBTN.Name = "sectionNewBTN";
            this.sectionNewBTN.Size = new System.Drawing.Size(216, 46);
            this.sectionNewBTN.TabIndex = 19;
            this.sectionNewBTN.Text = "New";
            this.sectionNewBTN.UseVisualStyleBackColor = false;
            // 
            // status_SectionComboBox
            // 
            this.status_SectionComboBox.FormattingEnabled = true;
            this.status_SectionComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_SectionComboBox.Location = new System.Drawing.Point(193, 145);
            this.status_SectionComboBox.Name = "status_SectionComboBox";
            this.status_SectionComboBox.Size = new System.Drawing.Size(366, 39);
            this.status_SectionComboBox.TabIndex = 18;
            // 
            // sectionNameTextbox
            // 
            this.sectionNameTextbox.Location = new System.Drawing.Point(193, 85);
            this.sectionNameTextbox.Name = "sectionNameTextbox";
            this.sectionNameTextbox.Size = new System.Drawing.Size(366, 39);
            this.sectionNameTextbox.TabIndex = 17;
            // 
            // section_IdTextBox
            // 
            this.section_IdTextBox.Location = new System.Drawing.Point(193, 31);
            this.section_IdTextBox.Name = "section_IdTextBox";
            this.section_IdTextBox.Size = new System.Drawing.Size(366, 39);
            this.section_IdTextBox.TabIndex = 16;
            // 
            // sectionLBL
            // 
            this.sectionLBL.Location = new System.Drawing.Point(12, 78);
            this.sectionLBL.Name = "sectionLBL";
            this.sectionLBL.Size = new System.Drawing.Size(184, 42);
            this.sectionLBL.TabIndex = 15;
            this.sectionLBL.Text = "Section Name:";
            this.sectionLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // status_SectionLBL
            // 
            this.status_SectionLBL.Location = new System.Drawing.Point(58, 138);
            this.status_SectionLBL.Name = "status_SectionLBL";
            this.status_SectionLBL.Size = new System.Drawing.Size(138, 42);
            this.status_SectionLBL.TabIndex = 14;
            this.status_SectionLBL.Text = "Status:";
            this.status_SectionLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // section_IdLBL
            // 
            this.section_IdLBL.Location = new System.Drawing.Point(49, 24);
            this.section_IdLBL.Name = "section_IdLBL";
            this.section_IdLBL.Size = new System.Drawing.Size(138, 42);
            this.section_IdLBL.TabIndex = 13;
            this.section_IdLBL.Text = "Section Id:";
            this.section_IdLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(938, 625);
            this.Controls.Add(this.sectionRows_Count_OutputLBL);
            this.Controls.Add(this.section_rowsCountLBL);
            this.Controls.Add(this.section_dataGridView);
            this.Controls.Add(this.section_UpdateBTN);
            this.Controls.Add(this.section_DeleteBTN);
            this.Controls.Add(this.section_SaveBTN);
            this.Controls.Add(this.sectionNewBTN);
            this.Controls.Add(this.status_SectionComboBox);
            this.Controls.Add(this.sectionNameTextbox);
            this.Controls.Add(this.section_IdTextBox);
            this.Controls.Add(this.sectionLBL);
            this.Controls.Add(this.status_SectionLBL);
            this.Controls.Add(this.section_IdLBL);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(964, 685);
            this.MinimumSize = new System.Drawing.Size(964, 685);
            this.Name = "Section";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Section";
            ((System.ComponentModel.ISupportInitialize)(this.section_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sectionRows_Count_OutputLBL;
        private System.Windows.Forms.Label section_rowsCountLBL;
        private System.Windows.Forms.DataGridView section_dataGridView;
        private System.Windows.Forms.Button section_UpdateBTN;
        private System.Windows.Forms.Button section_DeleteBTN;
        private System.Windows.Forms.Button section_SaveBTN;
        private System.Windows.Forms.Button sectionNewBTN;
        private System.Windows.Forms.ComboBox status_SectionComboBox;
        private System.Windows.Forms.TextBox sectionNameTextbox;
        private System.Windows.Forms.TextBox section_IdTextBox;
        private System.Windows.Forms.Label sectionLBL;
        private System.Windows.Forms.Label status_SectionLBL;
        private System.Windows.Forms.Label section_IdLBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}