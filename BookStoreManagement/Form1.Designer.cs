namespace BookStoreManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bukuToolStripMenuItem,
            this.bantuanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bukuToolStripMenuItem
            // 
            this.bukuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahBukuToolStripMenuItem,
            this.lihatBukuToolStripMenuItem});
            this.bukuToolStripMenuItem.Name = "bukuToolStripMenuItem";
            this.bukuToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bukuToolStripMenuItem.Text = "Buku";
            // 
            // tambahBukuToolStripMenuItem
            // 
            this.tambahBukuToolStripMenuItem.Name = "tambahBukuToolStripMenuItem";
            this.tambahBukuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tambahBukuToolStripMenuItem.Text = "Tambah Buku";
            this.tambahBukuToolStripMenuItem.Click += new System.EventHandler(this.tambahBukuToolStripMenuItem_Click);
            // 
            // lihatBukuToolStripMenuItem
            // 
            this.lihatBukuToolStripMenuItem.Name = "lihatBukuToolStripMenuItem";
            this.lihatBukuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lihatBukuToolStripMenuItem.Text = "Lihat Buku";
            this.lihatBukuToolStripMenuItem.Click += new System.EventHandler(this.lihatBukuToolStripMenuItem_Click);
            // 
            // bantuanToolStripMenuItem
            // 
            this.bantuanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tentangToolStripMenuItem});
            this.bantuanToolStripMenuItem.Name = "bantuanToolStripMenuItem";
            this.bantuanToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bantuanToolStripMenuItem.Text = "Bantuan";
            // 
            // tentangToolStripMenuItem
            // 
            this.tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            this.tentangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tentangToolStripMenuItem.Text = "Tentang";
            this.tentangToolStripMenuItem.Click += new System.EventHandler(this.tentangToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStoreManagement.Properties.Resources.huge;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Manajemen Toko Buku Bagus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangToolStripMenuItem;
    }
}

