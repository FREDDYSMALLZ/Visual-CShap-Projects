namespace Library_Management_System
{
    partial class Role
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
            this.role_IdLBL = new System.Windows.Forms.Label();
            this.status_RoleLBL = new System.Windows.Forms.Label();
            this.roleLBL = new System.Windows.Forms.Label();
            this.role_IdTextBox = new System.Windows.Forms.TextBox();
            this.roleTextbox = new System.Windows.Forms.TextBox();
            this.status_RoleComboBox = new System.Windows.Forms.ComboBox();
            this.roleNewBTN = new System.Windows.Forms.Button();
            this.role_SaveBTN = new System.Windows.Forms.Button();
            this.role_DeleteBTN = new System.Windows.Forms.Button();
            this.role_UpdateBTN = new System.Windows.Forms.Button();
            this.role_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowsCountLBL = new System.Windows.Forms.Label();
            this.rows_Count_OutputLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.role_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // role_IdLBL
            // 
            this.role_IdLBL.Location = new System.Drawing.Point(31, 32);
            this.role_IdLBL.Name = "role_IdLBL";
            this.role_IdLBL.Size = new System.Drawing.Size(138, 42);
            this.role_IdLBL.TabIndex = 0;
            this.role_IdLBL.Text = "Role Id:";
            this.role_IdLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // status_RoleLBL
            // 
            this.status_RoleLBL.Location = new System.Drawing.Point(40, 146);
            this.status_RoleLBL.Name = "status_RoleLBL";
            this.status_RoleLBL.Size = new System.Drawing.Size(138, 42);
            this.status_RoleLBL.TabIndex = 1;
            this.status_RoleLBL.Text = "Status:";
            this.status_RoleLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // roleLBL
            // 
            this.roleLBL.Location = new System.Drawing.Point(40, 86);
            this.roleLBL.Name = "roleLBL";
            this.roleLBL.Size = new System.Drawing.Size(138, 42);
            this.roleLBL.TabIndex = 2;
            this.roleLBL.Text = "Role:";
            this.roleLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // role_IdTextBox
            // 
            this.role_IdTextBox.Location = new System.Drawing.Point(175, 39);
            this.role_IdTextBox.Name = "role_IdTextBox";
            this.role_IdTextBox.Size = new System.Drawing.Size(366, 39);
            this.role_IdTextBox.TabIndex = 3;
            // 
            // roleTextbox
            // 
            this.roleTextbox.Location = new System.Drawing.Point(175, 93);
            this.roleTextbox.Name = "roleTextbox";
            this.roleTextbox.Size = new System.Drawing.Size(366, 39);
            this.roleTextbox.TabIndex = 4;
            // 
            // status_RoleComboBox
            // 
            this.status_RoleComboBox.FormattingEnabled = true;
            this.status_RoleComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_RoleComboBox.Location = new System.Drawing.Point(175, 153);
            this.status_RoleComboBox.Name = "status_RoleComboBox";
            this.status_RoleComboBox.Size = new System.Drawing.Size(366, 39);
            this.status_RoleComboBox.TabIndex = 5;
            // 
            // roleNewBTN
            // 
            this.roleNewBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roleNewBTN.Location = new System.Drawing.Point(655, 39);
            this.roleNewBTN.Name = "roleNewBTN";
            this.roleNewBTN.Size = new System.Drawing.Size(216, 46);
            this.roleNewBTN.TabIndex = 6;
            this.roleNewBTN.Text = "New";
            this.roleNewBTN.UseVisualStyleBackColor = false;
            // 
            // role_SaveBTN
            // 
            this.role_SaveBTN.BackColor = System.Drawing.Color.Lime;
            this.role_SaveBTN.Location = new System.Drawing.Point(655, 195);
            this.role_SaveBTN.Name = "role_SaveBTN";
            this.role_SaveBTN.Size = new System.Drawing.Size(216, 46);
            this.role_SaveBTN.TabIndex = 7;
            this.role_SaveBTN.Text = "Save";
            this.role_SaveBTN.UseVisualStyleBackColor = false;
            // 
            // role_DeleteBTN
            // 
            this.role_DeleteBTN.BackColor = System.Drawing.Color.Red;
            this.role_DeleteBTN.Location = new System.Drawing.Point(655, 143);
            this.role_DeleteBTN.Name = "role_DeleteBTN";
            this.role_DeleteBTN.Size = new System.Drawing.Size(216, 46);
            this.role_DeleteBTN.TabIndex = 8;
            this.role_DeleteBTN.Text = "Delete";
            this.role_DeleteBTN.UseVisualStyleBackColor = false;
            // 
            // role_UpdateBTN
            // 
            this.role_UpdateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.role_UpdateBTN.Location = new System.Drawing.Point(655, 91);
            this.role_UpdateBTN.Name = "role_UpdateBTN";
            this.role_UpdateBTN.Size = new System.Drawing.Size(216, 46);
            this.role_UpdateBTN.TabIndex = 9;
            this.role_UpdateBTN.Text = "Update";
            this.role_UpdateBTN.UseVisualStyleBackColor = false;
            // 
            // role_dataGridView
            // 
            this.role_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.role_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.role_dataGridView.Location = new System.Drawing.Point(46, 247);
            this.role_dataGridView.Name = "role_dataGridView";
            this.role_dataGridView.RowTemplate.Height = 28;
            this.role_dataGridView.Size = new System.Drawing.Size(825, 302);
            this.role_dataGridView.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Role Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Role";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            // 
            // rowsCountLBL
            // 
            this.rowsCountLBL.Location = new System.Drawing.Point(460, 567);
            this.rowsCountLBL.Name = "rowsCountLBL";
            this.rowsCountLBL.Size = new System.Drawing.Size(167, 42);
            this.rowsCountLBL.TabIndex = 11;
            this.rowsCountLBL.Text = "Rows Count:";
            this.rowsCountLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rows_Count_OutputLBL
            // 
            this.rows_Count_OutputLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rows_Count_OutputLBL.Location = new System.Drawing.Point(633, 567);
            this.rows_Count_OutputLBL.Name = "rows_Count_OutputLBL";
            this.rows_Count_OutputLBL.Size = new System.Drawing.Size(238, 42);
            this.rows_Count_OutputLBL.TabIndex = 12;
            this.rows_Count_OutputLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(934, 621);
            this.Controls.Add(this.rows_Count_OutputLBL);
            this.Controls.Add(this.rowsCountLBL);
            this.Controls.Add(this.role_dataGridView);
            this.Controls.Add(this.role_UpdateBTN);
            this.Controls.Add(this.role_DeleteBTN);
            this.Controls.Add(this.role_SaveBTN);
            this.Controls.Add(this.roleNewBTN);
            this.Controls.Add(this.status_RoleComboBox);
            this.Controls.Add(this.roleTextbox);
            this.Controls.Add(this.role_IdTextBox);
            this.Controls.Add(this.roleLBL);
            this.Controls.Add(this.status_RoleLBL);
            this.Controls.Add(this.role_IdLBL);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(960, 681);
            this.Name = "Role";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role";
            ((System.ComponentModel.ISupportInitialize)(this.role_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label role_IdLBL;
        private System.Windows.Forms.Label status_RoleLBL;
        private System.Windows.Forms.Label roleLBL;
        private System.Windows.Forms.TextBox role_IdTextBox;
        private System.Windows.Forms.TextBox roleTextbox;
        private System.Windows.Forms.ComboBox status_RoleComboBox;
        private System.Windows.Forms.Button roleNewBTN;
        private System.Windows.Forms.Button role_SaveBTN;
        private System.Windows.Forms.Button role_DeleteBTN;
        private System.Windows.Forms.Button role_UpdateBTN;
        private System.Windows.Forms.DataGridView role_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label rowsCountLBL;
        private System.Windows.Forms.Label rows_Count_OutputLBL;
    }
}