namespace TussentijdsProject
{
    partial class ManagePersoneelslid
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
            this.lbPersoneelslid = new System.Windows.Forms.ListBox();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnBewerken = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPersoneelslid
            // 
            this.lbPersoneelslid.FormattingEnabled = true;
            this.lbPersoneelslid.ItemHeight = 16;
            this.lbPersoneelslid.Location = new System.Drawing.Point(80, 161);
            this.lbPersoneelslid.Name = "lbPersoneelslid";
            this.lbPersoneelslid.Size = new System.Drawing.Size(309, 308);
            this.lbPersoneelslid.TabIndex = 24;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(604, 276);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(160, 50);
            this.btnVerwijderen.TabIndex = 23;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnBewerken
            // 
            this.btnBewerken.Location = new System.Drawing.Point(422, 276);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(160, 50);
            this.btnBewerken.TabIndex = 22;
            this.btnBewerken.Text = "Bewerken";
            this.btnBewerken.UseVisualStyleBackColor = true;
            this.btnBewerken.Click += new System.EventHandler(this.btnBewerken_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(508, 52);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(160, 50);
            this.btnToevoegen.TabIndex = 21;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(207, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 22);
            this.txtName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Voornaam";
            // 
            // ManagePersoneelslid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 659);
            this.Controls.Add(this.lbPersoneelslid);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnBewerken);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "ManagePersoneelslid";
            this.Text = "ManagePersoneelslid";
            this.Load += new System.EventHandler(this.ManagePersoneelslid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbPersoneelslid;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnBewerken;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}