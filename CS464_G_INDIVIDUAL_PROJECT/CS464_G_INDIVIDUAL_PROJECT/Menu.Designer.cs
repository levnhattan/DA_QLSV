
namespace CS464_G_INDIVIDUAL_PROJECT
{
    partial class Menu
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
            this.QuanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLyToolStripMenuItem,
            this.SinhVienToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QuanLyToolStripMenuItem
            // 
            this.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem";
            this.QuanLyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.QuanLyToolStripMenuItem.Text = "Quản lý môn học";
            this.QuanLyToolStripMenuItem.Click += new System.EventHandler(this.QuanLyToolStripMenuItem_Click);
            // 
            // SinhVienToolStripMenuItem
            // 
            this.SinhVienToolStripMenuItem.Name = "SinhVienToolStripMenuItem";
            this.SinhVienToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.SinhVienToolStripMenuItem.Text = "Quản lý sinh viên";
            this.SinhVienToolStripMenuItem.Click += new System.EventHandler(this.SinhVienToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QuanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}