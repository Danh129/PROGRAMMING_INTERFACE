namespace baitapgiaodien
{
    partial class Bai5C4LamThem
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
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuWindows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.toolStripSeparator1,
            this.menuClose,
            this.menuExit});
            this.menuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.MergeIndex = 0;
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(224, 26);
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuClose
            // 
            this.menuClose.MergeIndex = 6;
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(224, 26);
            this.menuClose.Text = "Close All";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // menuExit
            // 
            this.menuExit.MergeIndex = 7;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(224, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeIndex = 5;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuWindows
            // 
            this.menuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCascade,
            this.menuHorizontal,
            this.menuVertical});
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(84, 24);
            this.menuWindows.Text = "Windows";
            // 
            // menuCascade
            // 
            this.menuCascade.Name = "menuCascade";
            this.menuCascade.Size = new System.Drawing.Size(224, 26);
            this.menuCascade.Text = "Cascade";
            this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);
            // 
            // menuHorizontal
            // 
            this.menuHorizontal.Name = "menuHorizontal";
            this.menuHorizontal.Size = new System.Drawing.Size(224, 26);
            this.menuHorizontal.Text = "Tile Horizontal";
            this.menuHorizontal.Click += new System.EventHandler(this.menuHorizontal_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(224, 26);
            this.menuVertical.Text = "Tile vertical";
            this.menuVertical.Click += new System.EventHandler(this.menuVertical_Click);
            // 
            // Bai5C4LamThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 630);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bai5C4LamThem";
            this.Text = "Bai5C4LamThem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bai5C4LamThem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuWindows;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuVertical;
    }
}