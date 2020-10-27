namespace TussentijdsProject
{
    partial class LeverancierMenu
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
            this.leverancierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leverancierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDisplay = new System.Windows.Forms.Panel();
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
            this.menuStrip1.Size = new System.Drawing.Size(1018, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asfdcasdfToolStripMenuItem
            // 
            this.asfdcasdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leverancierToolStripMenuItem});
            this.asfdcasdfToolStripMenuItem.Name = "asfdcasdfToolStripMenuItem";
            this.asfdcasdfToolStripMenuItem.Size = new System.Drawing.Size(191, 38);
            this.asfdcasdfToolStripMenuItem.Text = "Databaheer";
            // 
            // leverancierToolStripMenuItem
            // 
            this.leverancierToolStripMenuItem.Name = "leverancierToolStripMenuItem";
            this.leverancierToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.leverancierToolStripMenuItem.Text = "Leverancier";
            this.leverancierToolStripMenuItem.Click += new System.EventHandler(this.leverancierToolStripMenuItem_Click);
            // 
            // overzichtToolStripMenuItem
            // 
            this.overzichtToolStripMenuItem.Name = "overzichtToolStripMenuItem";
            this.overzichtToolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.overzichtToolStripMenuItem.Text = "Overzicht";
            // 
            // bestellingToolStripMenuItem
            // 
            this.bestellingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leverancierToolStripMenuItem1});
            this.bestellingToolStripMenuItem.Name = "bestellingToolStripMenuItem";
            this.bestellingToolStripMenuItem.Size = new System.Drawing.Size(157, 38);
            this.bestellingToolStripMenuItem.Text = "Bestelling";
            // 
            // leverancierToolStripMenuItem1
            // 
            this.leverancierToolStripMenuItem1.Name = "leverancierToolStripMenuItem1";
            this.leverancierToolStripMenuItem1.Size = new System.Drawing.Size(264, 38);
            this.leverancierToolStripMenuItem1.Text = "Leverancier";
            this.leverancierToolStripMenuItem1.Click += new System.EventHandler(this.leverancierToolStripMenuItem1_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Location = new System.Drawing.Point(11, 56);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(990, 757);
            this.pnlDisplay.TabIndex = 2;
            // 
            // LeverancierMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1018, 841);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LeverancierMenu";
            this.Text = "LeverancierMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asfdcasdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leverancierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestellingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leverancierToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlDisplay;
    }
}