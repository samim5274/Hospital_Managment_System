namespace SanitariumProject
{
    partial class MotherForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specimenDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outdoorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOfTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indoorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.outdoorToolStripMenuItem,
            this.indoorToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.accountToolStripMenuItem1,
            this.createAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 39);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentDetailToolStripMenuItem,
            this.groupDetailToolStripMenuItem,
            this.categoryDetailToolStripMenuItem,
            this.subCategoryDetailToolStripMenuItem,
            this.specimenDetailToolStripMenuItem});
            this.generalToolStripMenuItem.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(91, 35);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // departmentDetailToolStripMenuItem
            // 
            this.departmentDetailToolStripMenuItem.Name = "departmentDetailToolStripMenuItem";
            this.departmentDetailToolStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.departmentDetailToolStripMenuItem.Text = "Department Detail";
            this.departmentDetailToolStripMenuItem.Click += new System.EventHandler(this.departmentDetailToolStripMenuItem_Click);
            // 
            // groupDetailToolStripMenuItem
            // 
            this.groupDetailToolStripMenuItem.Name = "groupDetailToolStripMenuItem";
            this.groupDetailToolStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.groupDetailToolStripMenuItem.Text = "Group Detail";
            this.groupDetailToolStripMenuItem.Click += new System.EventHandler(this.groupDetailToolStripMenuItem_Click);
            // 
            // categoryDetailToolStripMenuItem
            // 
            this.categoryDetailToolStripMenuItem.Name = "categoryDetailToolStripMenuItem";
            this.categoryDetailToolStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.categoryDetailToolStripMenuItem.Text = "Category Detail";
            this.categoryDetailToolStripMenuItem.Click += new System.EventHandler(this.categoryDetailToolStripMenuItem_Click);
            // 
            // subCategoryDetailToolStripMenuItem
            // 
            this.subCategoryDetailToolStripMenuItem.Name = "subCategoryDetailToolStripMenuItem";
            this.subCategoryDetailToolStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.subCategoryDetailToolStripMenuItem.Text = "Sub Category Detail";
            this.subCategoryDetailToolStripMenuItem.Click += new System.EventHandler(this.subCategoryDetailToolStripMenuItem_Click);
            // 
            // specimenDetailToolStripMenuItem
            // 
            this.specimenDetailToolStripMenuItem.Name = "specimenDetailToolStripMenuItem";
            this.specimenDetailToolStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.specimenDetailToolStripMenuItem.Text = "Specimen Detail";
            this.specimenDetailToolStripMenuItem.Click += new System.EventHandler(this.specimenDetailToolStripMenuItem_Click);
            // 
            // outdoorToolStripMenuItem
            // 
            this.outdoorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleOfTestToolStripMenuItem,
            this.testSaleToolStripMenuItem});
            this.outdoorToolStripMenuItem.Font = new System.Drawing.Font("Titillium Web", 12F);
            this.outdoorToolStripMenuItem.Name = "outdoorToolStripMenuItem";
            this.outdoorToolStripMenuItem.Size = new System.Drawing.Size(135, 35);
            this.outdoorToolStripMenuItem.Text = "Investigation";
            // 
            // saleOfTestToolStripMenuItem
            // 
            this.saleOfTestToolStripMenuItem.Name = "saleOfTestToolStripMenuItem";
            this.saleOfTestToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.saleOfTestToolStripMenuItem.Text = "Test Detail";
            this.saleOfTestToolStripMenuItem.Click += new System.EventHandler(this.saleOfTestToolStripMenuItem_Click);
            // 
            // testSaleToolStripMenuItem
            // 
            this.testSaleToolStripMenuItem.Name = "testSaleToolStripMenuItem";
            this.testSaleToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.testSaleToolStripMenuItem.Text = "Test Sale";
            // 
            // indoorToolStripMenuItem
            // 
            this.indoorToolStripMenuItem.Font = new System.Drawing.Font("Titillium Web", 12F);
            this.indoorToolStripMenuItem.Name = "indoorToolStripMenuItem";
            this.indoorToolStripMenuItem.Size = new System.Drawing.Size(84, 35);
            this.indoorToolStripMenuItem.Text = "Report";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Titillium Web", 12F);
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(88, 35);
            this.accountToolStripMenuItem.Text = "History";
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.Font = new System.Drawing.Font("Titillium Web", 12F);
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(96, 35);
            this.accountToolStripMenuItem1.Text = "Account";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Font = new System.Drawing.Font("Titillium Web", 12F);
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(155, 35);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // MotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 676);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MotherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotherForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outdoorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indoorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoryDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specimenDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOfTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;

    }
}



