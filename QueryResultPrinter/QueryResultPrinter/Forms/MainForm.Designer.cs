
namespace TotalInventory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.totalInventoryStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedInventoryStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalInventoryDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInOutDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semifinishedInOutDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.menuStrip);
            this.panelMenu.Location = new System.Drawing.Point(13, 11);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(2042, 49);
            this.panelMenu.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalInventoryStatusToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(1, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(252, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // totalInventoryStatusToolStripMenuItem
            // 
            this.totalInventoryStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closedInventoryStatusToolStripMenuItem,
            this.totalInventoryDetailToolStripMenuItem,
            this.productInOutDetailToolStripMenuItem,
            this.semifinishedInOutDetailToolStripMenuItem});
            this.totalInventoryStatusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.totalInventoryStatusToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalInventoryStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("totalInventoryStatusToolStripMenuItem.Image")));
            this.totalInventoryStatusToolStripMenuItem.Name = "totalInventoryStatusToolStripMenuItem";
            this.totalInventoryStatusToolStripMenuItem.Size = new System.Drawing.Size(244, 32);
            this.totalInventoryStatusToolStripMenuItem.Text = "Total Inventory Status";
            // 
            // closedInventoryStatusToolStripMenuItem
            // 
            this.closedInventoryStatusToolStripMenuItem.Name = "closedInventoryStatusToolStripMenuItem";
            this.closedInventoryStatusToolStripMenuItem.Size = new System.Drawing.Size(360, 32);
            this.closedInventoryStatusToolStripMenuItem.Text = "Closed Inventory Status";
            this.closedInventoryStatusToolStripMenuItem.Click += new System.EventHandler(this.closedInventoryStatusToolStripMenuItem_Click);
            // 
            // totalInventoryDetailToolStripMenuItem
            // 
            this.totalInventoryDetailToolStripMenuItem.Name = "totalInventoryDetailToolStripMenuItem";
            this.totalInventoryDetailToolStripMenuItem.Size = new System.Drawing.Size(360, 32);
            this.totalInventoryDetailToolStripMenuItem.Text = "Total Inventory Detail";
            this.totalInventoryDetailToolStripMenuItem.Click += new System.EventHandler(this.totalInventoryDetailToolStripMenuItem_Click);
            // 
            // productInOutDetailToolStripMenuItem
            // 
            this.productInOutDetailToolStripMenuItem.Name = "productInOutDetailToolStripMenuItem";
            this.productInOutDetailToolStripMenuItem.Size = new System.Drawing.Size(360, 32);
            this.productInOutDetailToolStripMenuItem.Text = "Product In / Out Detail";
            this.productInOutDetailToolStripMenuItem.Click += new System.EventHandler(this.productInOutDetailToolStripMenuItem_Click);
            // 
            // semifinishedInOutDetailToolStripMenuItem
            // 
            this.semifinishedInOutDetailToolStripMenuItem.Name = "semifinishedInOutDetailToolStripMenuItem";
            this.semifinishedInOutDetailToolStripMenuItem.Size = new System.Drawing.Size(360, 32);
            this.semifinishedInOutDetailToolStripMenuItem.Text = "Semi-finished In / Out Detail";
            this.semifinishedInOutDetailToolStripMenuItem.Click += new System.EventHandler(this.semifinishedInOutDetailToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(13, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2042, 71);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(69, 44);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registerToolStripMenuItem.Image")));
            this.registerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(81, 44);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excelToolStripMenuItem.Image")));
            this.excelToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(58, 44);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(15, 133);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2040, 833);
            this.tabControl.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(15, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2040, 830);
            this.panel2.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2067, 978);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Total Inventory Status";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolStripMenuItem totalInventoryStatusToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem closedInventoryStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalInventoryDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInOutDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semifinishedInOutDetailToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel panel2;
    }
}