namespace WinApp
{
    partial class Main_Window
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayByCustomCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.displayStudentToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.displayByCustomCardToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.newStudentToolStripMenuItem.Text = "Registration";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click);
            // 
            // displayStudentToolStripMenuItem
            // 
            this.displayStudentToolStripMenuItem.Name = "displayStudentToolStripMenuItem";
            this.displayStudentToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.displayStudentToolStripMenuItem.Text = "DisplayAll In Table";
            this.displayStudentToolStripMenuItem.Click += new System.EventHandler(this.displayStudentToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDepartmentToolStripMenuItem,
            this.displayDepartmentToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newDepartmentToolStripMenuItem
            // 
            this.newDepartmentToolStripMenuItem.Name = "newDepartmentToolStripMenuItem";
            this.newDepartmentToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.newDepartmentToolStripMenuItem.Text = "New Department";
            // 
            // displayDepartmentToolStripMenuItem
            // 
            this.displayDepartmentToolStripMenuItem.Name = "displayDepartmentToolStripMenuItem";
            this.displayDepartmentToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.displayDepartmentToolStripMenuItem.Text = "Display Department";
            // 
            // displayByCustomCardToolStripMenuItem
            // 
            this.displayByCustomCardToolStripMenuItem.Name = "displayByCustomCardToolStripMenuItem";
            this.displayByCustomCardToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.displayByCustomCardToolStripMenuItem.Text = "Display By CustomCard";
            this.displayByCustomCardToolStripMenuItem.Click += new System.EventHandler(this.displayByCustomCardToolStripMenuItem_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Window";
            this.Text = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayByCustomCardToolStripMenuItem;
    }
}