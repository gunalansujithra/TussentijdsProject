namespace TussentijdsProject
{
    partial class ManageCategorie
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
            this.lbCategorie = new System.Windows.Forms.ListBox();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnBewerken = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtCategorieNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCategorie
            // 
            this.lbCategorie.FormattingEnabled = true;
            this.lbCategorie.ItemHeight = 16;
            this.lbCategorie.Location = new System.Drawing.Point(62, 173);
            this.lbCategorie.Name = "lbCategorie";
            this.lbCategorie.Size = new System.Drawing.Size(309, 308);
            this.lbCategorie.TabIndex = 30;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(586, 288);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(160, 50);
            this.btnVerwijderen.TabIndex = 29;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnBewerken
            // 
            this.btnBewerken.Location = new System.Drawing.Point(404, 288);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(160, 50);
            this.btnBewerken.TabIndex = 28;
            this.btnBewerken.Text = "Bewerken";
            this.btnBewerken.UseVisualStyleBackColor = true;
            this.btnBewerken.Click += new System.EventHandler(this.btnBewerken_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(524, 64);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(160, 50);
            this.btnToevoegen.TabIndex = 27;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // txtCategorieNaam
            // 
            this.txtCategorieNaam.Location = new System.Drawing.Point(218, 78);
            this.txtCategorieNaam.Name = "txtCategorieNaam";
            this.txtCategorieNaam.Size = new System.Drawing.Size(255, 22);
            this.txtCategorieNaam.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Categorie Naam";
            // 
            // ManageCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.lbCategorie);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnBewerken);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtCategorieNaam);
            this.Controls.Add(this.label1);
            this.Name = "ManageCategorie";
            this.Text = "ManageCategorie";
            this.Load += new System.EventHandler(this.ManageCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCategorie;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnBewerken;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtCategorieNaam;
        private System.Windows.Forms.Label label1;
    }
}