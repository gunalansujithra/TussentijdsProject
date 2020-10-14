namespace TussentijdsProject
{
    partial class MainMenu
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
            this.asfdcasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leverancierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeelslidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asfdcasdfToolStripMenuItem,
            this.overzichtToolStripMenuItem,
            this.bestellingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asfdcasdfToolStripMenuItem
            // 
            this.asfdcasdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leverancierToolStripMenuItem,
            this.klantToolStripMenuItem,
            this.categorieToolStripMenuItem,
            this.personeelslidToolStripMenuItem});
            this.asfdcasdfToolStripMenuItem.Name = "asfdcasdfToolStripMenuItem";
            this.asfdcasdfToolStripMenuItem.Size = new System.Drawing.Size(191, 38);
            this.asfdcasdfToolStripMenuItem.Text = "Databaheer";
            // 
            // overzichtToolStripMenuItem
            // 
            this.overzichtToolStripMenuItem.Name = "overzichtToolStripMenuItem";
            this.overzichtToolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.overzichtToolStripMenuItem.Text = "Overzicht";
            // 
            // bestellingToolStripMenuItem
            // 
            this.bestellingToolStripMenuItem.Name = "bestellingToolStripMenuItem";
            this.bestellingToolStripMenuItem.Size = new System.Drawing.Size(157, 38);
            this.bestellingToolStripMenuItem.Text = "Bestelling";
            // 
            // leverancierToolStripMenuItem
            // 
            this.leverancierToolStripMenuItem.Name = "leverancierToolStripMenuItem";
            this.leverancierToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.leverancierToolStripMenuItem.Text = "Leverancier";
            // 
            // klantToolStripMenuItem
            // 
            this.klantToolStripMenuItem.Name = "klantToolStripMenuItem";
            this.klantToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.klantToolStripMenuItem.Text = "Klant";
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.categorieToolStripMenuItem.Text = "Categorie";
            this.categorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
            // 
            // personeelslidToolStripMenuItem
            // 
            this.personeelslidToolStripMenuItem.Name = "personeelslidToolStripMenuItem";
            this.personeelslidToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.personeelslidToolStripMenuItem.Text = "Personeelslid";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1015, 736);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asfdcasdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leverancierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeelslidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestellingToolStripMenuItem;
    }
}