namespace Library_Management_System
{
    partial class Section_Rack_Map
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
            this.sectionRack_Count_OutputLBL = new System.Windows.Forms.Label();
            this.section_Rack_rowsCountLBL = new System.Windows.Forms.Label();
            this.section_Rack_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_Rack_UpdateBTN = new System.Windows.Forms.Button();
            this.section__Rack_DeleteBTN = new System.Windows.Forms.Button();
            this.section__Rack_SaveBTN = new System.Windows.Forms.Button();
            this.section_RackNewBTN = new System.Windows.Forms.Button();
            this.status_SectionComboBox = new System.Windows.Forms.ComboBox();
            this.sectionRack_IdTextBox = new System.Windows.Forms.TextBox();
            this.section_RakLBL = new System.Windows.Forms.Label();
            this.status_SectionLBL = new System.Windows.Forms.Label();
            this.sectionRack_IdLBL = new System.Windows.Forms.Label();
            this.section_RackName_LBL = new System.Windows.Forms.Label();
            this.Section_Rack_comboBox = new System.Windows.Forms.ComboBox();
            this.sectionRack_PrintOrderLBL = new System.Windows.Forms.Label();
            this.section_PrintOrderTextBox = new System.Windows.Forms.TextBox();
            this.Section_RackComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.section_Rack_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionRack_Count_OutputLBL
            // 
            this.sectionRack_Count_OutputLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sectionRack_Count_OutputLBL.Location = new System.Drawing.Point(902, 690);
            this.sectionRack_Count_OutputLBL.Name = "sectionRack_Count_OutputLBL";
            this.sectionRack_Count_OutputLBL.Size = new System.Drawing.Size(238, 42);
            this.sectionRack_Count_OutputLBL.TabIndex = 38;
            this.sectionRack_Count_OutputLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section_Rack_rowsCountLBL
            // 
            this.section_Rack_rowsCountLBL.Location = new System.Drawing.Point(729, 690);
            this.section_Rack_rowsCountLBL.Name = "section_Rack_rowsCountLBL";
            this.section_Rack_rowsCountLBL.Size = new System.Drawing.Size(167, 42);
            this.section_Rack_rowsCountLBL.TabIndex = 37;
            this.section_Rack_rowsCountLBL.Text = "Rows Count:";
            this.section_Rack_rowsCountLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // section_Rack_dataGridView
            // 
            this.section_Rack_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.section_Rack_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.section_Rack_dataGridView.Location = new System.Drawing.Point(18, 372);
            this.section_Rack_dataGridView.Name = "section_Rack_dataGridView";
            this.section_Rack_dataGridView.RowTemplate.Height = 28;
            this.section_Rack_dataGridView.Size = new System.Drawing.Size(1122, 302);
            this.section_Rack_dataGridView.TabIndex = 36;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Section Rack Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Rack Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Section Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Print Order";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // section_Rack_UpdateBTN
            // 
            this.section_Rack_UpdateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.section_Rack_UpdateBTN.Location = new System.Drawing.Point(902, 117);
            this.section_Rack_UpdateBTN.Name = "section_Rack_UpdateBTN";
            this.section_Rack_UpdateBTN.Size = new System.Drawing.Size(238, 70);
            this.section_Rack_UpdateBTN.TabIndex = 35;
            this.section_Rack_UpdateBTN.Text = "Update";
            this.section_Rack_UpdateBTN.UseVisualStyleBackColor = false;
            // 
            // section__Rack_DeleteBTN
            // 
            this.section__Rack_DeleteBTN.BackColor = System.Drawing.Color.Red;
            this.section__Rack_DeleteBTN.Location = new System.Drawing.Point(902, 193);
            this.section__Rack_DeleteBTN.Name = "section__Rack_DeleteBTN";
            this.section__Rack_DeleteBTN.Size = new System.Drawing.Size(238, 70);
            this.section__Rack_DeleteBTN.TabIndex = 34;
            this.section__Rack_DeleteBTN.Text = "Delete";
            this.section__Rack_DeleteBTN.UseVisualStyleBackColor = false;
            // 
            // section__Rack_SaveBTN
            // 
            this.section__Rack_SaveBTN.BackColor = System.Drawing.Color.Lime;
            this.section__Rack_SaveBTN.Location = new System.Drawing.Point(902, 269);
            this.section__Rack_SaveBTN.Name = "section__Rack_SaveBTN";
            this.section__Rack_SaveBTN.Size = new System.Drawing.Size(238, 70);
            this.section__Rack_SaveBTN.TabIndex = 33;
            this.section__Rack_SaveBTN.Text = "Save";
            this.section__Rack_SaveBTN.UseVisualStyleBackColor = false;
            // 
            // section_RackNewBTN
            // 
            this.section_RackNewBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.section_RackNewBTN.Location = new System.Drawing.Point(902, 35);
            this.section_RackNewBTN.Name = "section_RackNewBTN";
            this.section_RackNewBTN.Size = new System.Drawing.Size(238, 70);
            this.section_RackNewBTN.TabIndex = 32;
            this.section_RackNewBTN.Text = "New";
            this.section_RackNewBTN.UseVisualStyleBackColor = false;
            // 
            // status_SectionComboBox
            // 
            this.status_SectionComboBox.FormattingEnabled = true;
            this.status_SectionComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_SectionComboBox.Location = new System.Drawing.Point(206, 282);
            this.status_SectionComboBox.Name = "status_SectionComboBox";
            this.status_SectionComboBox.Size = new System.Drawing.Size(366, 39);
            this.status_SectionComboBox.TabIndex = 31;
            // 
            // sectionRack_IdTextBox
            // 
            this.sectionRack_IdTextBox.Location = new System.Drawing.Point(206, 35);
            this.sectionRack_IdTextBox.Name = "sectionRack_IdTextBox";
            this.sectionRack_IdTextBox.Size = new System.Drawing.Size(366, 39);
            this.sectionRack_IdTextBox.TabIndex = 29;
            // 
            // section_RakLBL
            // 
            this.section_RakLBL.Location = new System.Drawing.Point(25, 82);
            this.section_RakLBL.Name = "section_RakLBL";
            this.section_RakLBL.Size = new System.Drawing.Size(184, 42);
            this.section_RakLBL.TabIndex = 28;
            this.section_RakLBL.Text = "Rack Name:";
            this.section_RakLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // status_SectionLBL
            // 
            this.status_SectionLBL.Location = new System.Drawing.Point(62, 279);
            this.status_SectionLBL.Name = "status_SectionLBL";
            this.status_SectionLBL.Size = new System.Drawing.Size(138, 42);
            this.status_SectionLBL.TabIndex = 27;
            this.status_SectionLBL.Text = "Status:";
            this.status_SectionLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // sectionRack_IdLBL
            // 
            this.sectionRack_IdLBL.Location = new System.Drawing.Point(12, 28);
            this.sectionRack_IdLBL.Name = "sectionRack_IdLBL";
            this.sectionRack_IdLBL.Size = new System.Drawing.Size(188, 42);
            this.sectionRack_IdLBL.TabIndex = 26;
            this.sectionRack_IdLBL.Text = "Section Rack Id:";
            this.sectionRack_IdLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // section_RackName_LBL
            // 
            this.section_RackName_LBL.Location = new System.Drawing.Point(12, 139);
            this.section_RackName_LBL.Name = "section_RackName_LBL";
            this.section_RackName_LBL.Size = new System.Drawing.Size(188, 42);
            this.section_RackName_LBL.TabIndex = 39;
            this.section_RackName_LBL.Text = "Section Name:";
            this.section_RackName_LBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Section_Rack_comboBox
            // 
            this.Section_Rack_comboBox.FormattingEnabled = true;
            this.Section_Rack_comboBox.Location = new System.Drawing.Point(206, 146);
            this.Section_Rack_comboBox.Name = "Section_Rack_comboBox";
            this.Section_Rack_comboBox.Size = new System.Drawing.Size(366, 39);
            this.Section_Rack_comboBox.TabIndex = 40;
            // 
            // sectionRack_PrintOrderLBL
            // 
            this.sectionRack_PrintOrderLBL.Location = new System.Drawing.Point(25, 206);
            this.sectionRack_PrintOrderLBL.Name = "sectionRack_PrintOrderLBL";
            this.sectionRack_PrintOrderLBL.Size = new System.Drawing.Size(175, 45);
            this.sectionRack_PrintOrderLBL.TabIndex = 41;
            this.sectionRack_PrintOrderLBL.Text = "Print Order:";
            // 
            // section_PrintOrderTextBox
            // 
            this.section_PrintOrderTextBox.Location = new System.Drawing.Point(206, 212);
            this.section_PrintOrderTextBox.Name = "section_PrintOrderTextBox";
            this.section_PrintOrderTextBox.Size = new System.Drawing.Size(366, 39);
            this.section_PrintOrderTextBox.TabIndex = 42;
            // 
            // Section_RackComboBox
            // 
            this.Section_RackComboBox.FormattingEnabled = true;
            this.Section_RackComboBox.Location = new System.Drawing.Point(206, 90);
            this.Section_RackComboBox.Name = "Section_RackComboBox";
            this.Section_RackComboBox.Size = new System.Drawing.Size(366, 39);
            this.Section_RackComboBox.TabIndex = 43;
            // 
            // Section_Rack_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1161, 745);
            this.Controls.Add(this.Section_RackComboBox);
            this.Controls.Add(this.section_PrintOrderTextBox);
            this.Controls.Add(this.sectionRack_PrintOrderLBL);
            this.Controls.Add(this.Section_Rack_comboBox);
            this.Controls.Add(this.section_RackName_LBL);
            this.Controls.Add(this.sectionRack_Count_OutputLBL);
            this.Controls.Add(this.section_Rack_rowsCountLBL);
            this.Controls.Add(this.section_Rack_dataGridView);
            this.Controls.Add(this.section_Rack_UpdateBTN);
            this.Controls.Add(this.section__Rack_DeleteBTN);
            this.Controls.Add(this.section__Rack_SaveBTN);
            this.Controls.Add(this.section_RackNewBTN);
            this.Controls.Add(this.status_SectionComboBox);
            this.Controls.Add(this.sectionRack_IdTextBox);
            this.Controls.Add(this.section_RakLBL);
            this.Controls.Add(this.status_SectionLBL);
            this.Controls.Add(this.sectionRack_IdLBL);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1183, 801);
            this.MinimumSize = new System.Drawing.Size(1183, 801);
            this.Name = "Section_Rack_Map";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SectionRack";
            ((System.ComponentModel.ISupportInitialize)(this.section_Rack_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sectionRack_Count_OutputLBL;
        private System.Windows.Forms.Label section_Rack_rowsCountLBL;
        private System.Windows.Forms.DataGridView section_Rack_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button section_Rack_UpdateBTN;
        private System.Windows.Forms.Button section__Rack_DeleteBTN;
        private System.Windows.Forms.Button section__Rack_SaveBTN;
        private System.Windows.Forms.Button section_RackNewBTN;
        private System.Windows.Forms.ComboBox status_SectionComboBox;
        private System.Windows.Forms.TextBox sectionRack_IdTextBox;
        private System.Windows.Forms.Label section_RakLBL;
        private System.Windows.Forms.Label status_SectionLBL;
        private System.Windows.Forms.Label sectionRack_IdLBL;
        private System.Windows.Forms.Label section_RackName_LBL;
        private System.Windows.Forms.ComboBox Section_Rack_comboBox;
        private System.Windows.Forms.Label sectionRack_PrintOrderLBL;
        private System.Windows.Forms.TextBox section_PrintOrderTextBox;
        private System.Windows.Forms.ComboBox Section_RackComboBox;
    }
}