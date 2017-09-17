namespace Library_Management_System
{
    partial class LibraryManagementSystem
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionRackMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOutRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mamberTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.menuStrip.Size = new System.Drawing.Size(1185, 45);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 879);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(3, 0, 33, 0);
            this.statusStrip.Size = new System.Drawing.Size(1185, 30);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.planToolStripMenuItem,
            this.rackToolStripMenuItem,
            this.sectionToolStripMenuItem,
            this.sectionRackMapToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.mastersToolStripMenuItem.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(107, 35);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.bookInRegisterToolStripMenuItem,
            this.bookOutRegisterToolStripMenuItem,
            this.mamberTransactionToolStripMenuItem});
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(134, 35);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(109, 35);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.roleToolStripMenuItem.Text = "Role";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.planToolStripMenuItem.Text = "Plan";
            this.planToolStripMenuItem.Click += new System.EventHandler(this.planToolStripMenuItem_Click);
            // 
            // rackToolStripMenuItem
            // 
            this.rackToolStripMenuItem.Name = "rackToolStripMenuItem";
            this.rackToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.rackToolStripMenuItem.Text = "Rack";
            this.rackToolStripMenuItem.Click += new System.EventHandler(this.rackToolStripMenuItem_Click);
            // 
            // sectionToolStripMenuItem
            // 
            this.sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            this.sectionToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.sectionToolStripMenuItem.Text = "Section";
            this.sectionToolStripMenuItem.Click += new System.EventHandler(this.sectionToolStripMenuItem_Click);
            // 
            // sectionRackMapToolStripMenuItem
            // 
            this.sectionRackMapToolStripMenuItem.Name = "sectionRackMapToolStripMenuItem";
            this.sectionRackMapToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.sectionRackMapToolStripMenuItem.Text = "Section Rack Map";
            this.sectionRackMapToolStripMenuItem.Click += new System.EventHandler(this.sectionRackMapToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(323, 36);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // bookInRegisterToolStripMenuItem
            // 
            this.bookInRegisterToolStripMenuItem.Name = "bookInRegisterToolStripMenuItem";
            this.bookInRegisterToolStripMenuItem.Size = new System.Drawing.Size(323, 36);
            this.bookInRegisterToolStripMenuItem.Text = "Book In Register";
            this.bookInRegisterToolStripMenuItem.Click += new System.EventHandler(this.bookInRegisterToolStripMenuItem_Click);
            // 
            // bookOutRegisterToolStripMenuItem
            // 
            this.bookOutRegisterToolStripMenuItem.Name = "bookOutRegisterToolStripMenuItem";
            this.bookOutRegisterToolStripMenuItem.Size = new System.Drawing.Size(323, 36);
            this.bookOutRegisterToolStripMenuItem.Text = "Book Out Register";
            this.bookOutRegisterToolStripMenuItem.Click += new System.EventHandler(this.bookOutRegisterToolStripMenuItem_Click);
            // 
            // mamberTransactionToolStripMenuItem
            // 
            this.mamberTransactionToolStripMenuItem.Name = "mamberTransactionToolStripMenuItem";
            this.mamberTransactionToolStripMenuItem.Size = new System.Drawing.Size(323, 36);
            this.mamberTransactionToolStripMenuItem.Text = "Mamber Transaction";
            this.mamberTransactionToolStripMenuItem.Click += new System.EventHandler(this.mamberTransactionToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // LibraryManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1185, 909);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "LibraryManagementSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagementSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibraryManagementSystem_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionRackMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOutRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mamberTransactionToolStripMenuItem;
    }
}



