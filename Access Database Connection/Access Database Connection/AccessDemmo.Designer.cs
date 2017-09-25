namespace Access_Database_Connection
{
    partial class AccessDemmo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label customerAddressLabel;
            System.Windows.Forms.Label balanceDueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessDemmo));
            this.newBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.salesDataSet = new Access_Database_Connection.SalesDataSet();
            this.customerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTBLTableAdapter = new Access_Database_Connection.SalesDataSetTableAdapters.CustomerTBLTableAdapter();
            this.tableAdapterManager = new Access_Database_Connection.SalesDataSetTableAdapters.TableAdapterManager();
            this.customerTBLBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerTBLBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.balanceDueTextBox = new System.Windows.Forms.TextBox();
            this.customerTBLDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            customerIdLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            customerAddressLabel = new System.Windows.Forms.Label();
            balanceDueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBLBindingNavigator)).BeginInit();
            this.customerTBLBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBLDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIdLabel.Location = new System.Drawing.Point(12, 74);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(182, 37);
            customerIdLabel.TabIndex = 5;
            customerIdLabel.Text = "Customer Id:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerNameLabel.Location = new System.Drawing.Point(12, 119);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(233, 37);
            customerNameLabel.TabIndex = 7;
            customerNameLabel.Text = "Customer Name:";
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerAddressLabel.Location = new System.Drawing.Point(12, 164);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new System.Drawing.Size(258, 37);
            customerAddressLabel.TabIndex = 9;
            customerAddressLabel.Text = "Customer Address:";
            // 
            // balanceDueLabel
            // 
            balanceDueLabel.AutoSize = true;
            balanceDueLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            balanceDueLabel.Location = new System.Drawing.Point(12, 209);
            balanceDueLabel.Name = "balanceDueLabel";
            balanceDueLabel.Size = new System.Drawing.Size(177, 37);
            balanceDueLabel.TabIndex = 11;
            balanceDueLabel.Text = "Balance Due:";
            // 
            // newBTN
            // 
            this.newBTN.Location = new System.Drawing.Point(1519, 47);
            this.newBTN.Name = "newBTN";
            this.newBTN.Size = new System.Drawing.Size(246, 55);
            this.newBTN.TabIndex = 0;
            this.newBTN.Text = "N&ew";
            this.newBTN.UseVisualStyleBackColor = true;
            this.newBTN.Click += new System.EventHandler(this.newBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.Lime;
            this.saveBTN.Location = new System.Drawing.Point(1519, 108);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(246, 55);
            this.saveBTN.TabIndex = 1;
            this.saveBTN.Text = "S&ave";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(1519, 169);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(246, 55);
            this.deleteBTN.TabIndex = 2;
            this.deleteBTN.Text = "D&elete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(1519, 230);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(246, 55);
            this.updateBTN.TabIndex = 3;
            this.updateBTN.Text = "U&pdate";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // salesDataSet
            // 
            this.salesDataSet.DataSetName = "SalesDataSet";
            this.salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTBLBindingSource
            // 
            this.customerTBLBindingSource.DataMember = "CustomerTBL";
            this.customerTBLBindingSource.DataSource = this.salesDataSet;
            // 
            // customerTBLTableAdapter
            // 
            this.customerTBLTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTBLTableAdapter = this.customerTBLTableAdapter;
            this.tableAdapterManager.ItemTBLTableAdapter = null;
            this.tableAdapterManager.OrderItemTBLTableAdapter = null;
            this.tableAdapterManager.OrdersTBLTableAdapter = null;
            this.tableAdapterManager.SalesPersonTBLTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Access_Database_Connection.SalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTBLBindingNavigator
            // 
            this.customerTBLBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerTBLBindingNavigator.BindingSource = this.customerTBLBindingSource;
            this.customerTBLBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerTBLBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerTBLBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.customerTBLBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customerTBLBindingNavigatorSaveItem});
            this.customerTBLBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerTBLBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerTBLBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerTBLBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerTBLBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerTBLBindingNavigator.Name = "customerTBLBindingNavigator";
            this.customerTBLBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerTBLBindingNavigator.Size = new System.Drawing.Size(1831, 31);
            this.customerTBLBindingNavigator.TabIndex = 4;
            this.customerTBLBindingNavigator.Text = "bindingNavigator1";
            this.customerTBLBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // customerTBLBindingNavigatorSaveItem
            // 
            this.customerTBLBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerTBLBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerTBLBindingNavigatorSaveItem.Image")));
            this.customerTBLBindingNavigatorSaveItem.Name = "customerTBLBindingNavigatorSaveItem";
            this.customerTBLBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.customerTBLBindingNavigatorSaveItem.Text = "Save Data";
            this.customerTBLBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerTBLBindingNavigatorSaveItem_Click);
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBLBindingSource, "CustomerId", true));
            this.customerIdTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdTextBox.Location = new System.Drawing.Point(277, 68);
            this.customerIdTextBox.Multiline = true;
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(353, 45);
            this.customerIdTextBox.TabIndex = 6;
            this.customerIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBLBindingSource, "CustomerName", true));
            this.customerNameTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(277, 119);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(353, 44);
            this.customerNameTextBox.TabIndex = 8;
            this.customerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBLBindingSource, "CustomerAddress", true));
            this.customerAddressTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressTextBox.Location = new System.Drawing.Point(277, 164);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(353, 44);
            this.customerAddressTextBox.TabIndex = 10;
            this.customerAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // balanceDueTextBox
            // 
            this.balanceDueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBLBindingSource, "BalanceDue", true));
            this.balanceDueTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceDueTextBox.Location = new System.Drawing.Point(277, 209);
            this.balanceDueTextBox.Name = "balanceDueTextBox";
            this.balanceDueTextBox.Size = new System.Drawing.Size(353, 44);
            this.balanceDueTextBox.TabIndex = 12;
            this.balanceDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerTBLDataGridView
            // 
            this.customerTBLDataGridView.AllowUserToAddRows = false;
            this.customerTBLDataGridView.AutoGenerateColumns = false;
            this.customerTBLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTBLDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.customerTBLDataGridView.DataSource = this.customerTBLBindingSource;
            this.customerTBLDataGridView.Location = new System.Drawing.Point(653, 47);
            this.customerTBLDataGridView.Name = "customerTBLDataGridView";
            this.customerTBLDataGridView.RowTemplate.Height = 28;
            this.customerTBLDataGridView.Size = new System.Drawing.Size(860, 235);
            this.customerTBLDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustomerAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BalanceDue";
            this.dataGridViewTextBoxColumn4.HeaderText = "BalanceDue";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // AccessDemmo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1831, 926);
            this.Controls.Add(this.customerTBLDataGridView);
            this.Controls.Add(customerIdLabel);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(customerAddressLabel);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(balanceDueLabel);
            this.Controls.Add(this.balanceDueTextBox);
            this.Controls.Add(this.customerTBLBindingNavigator);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.newBTN);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AccessDemmo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Database Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBLBindingNavigator)).EndInit();
            this.customerTBLBindingNavigator.ResumeLayout(false);
            this.customerTBLBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBLDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private SalesDataSet salesDataSet;
        private System.Windows.Forms.BindingSource customerTBLBindingSource;
        private SalesDataSetTableAdapters.CustomerTBLTableAdapter customerTBLTableAdapter;
        private SalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerTBLBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customerTBLBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox balanceDueTextBox;
        private System.Windows.Forms.DataGridView customerTBLDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

