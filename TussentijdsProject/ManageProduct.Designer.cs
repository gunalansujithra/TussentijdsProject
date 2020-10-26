namespace TussentijdsProject
{
    partial class ManageProduct
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
            this.components = new System.ComponentModel.Container();
            this.txtInkoopprijs = new System.Windows.Forms.TextBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.epContactPersoon = new System.Windows.Forms.ErrorProvider(this.components);
            this.epStraatnaam = new System.Windows.Forms.ErrorProvider(this.components);
            this.epHuisnummer = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBus = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPostcode = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGemeente = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefoon = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnBewerken = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtLeverancier = new System.Windows.Forms.TextBox();
            this.txtBtw = new System.Windows.Forms.TextBox();
            this.txtEenheid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.epAantal = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epContactPersoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStraatnaam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHuisnummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPostcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGemeente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInkoopprijs
            // 
            this.txtInkoopprijs.Enabled = false;
            this.txtInkoopprijs.Location = new System.Drawing.Point(368, 168);
            this.txtInkoopprijs.Margin = new System.Windows.Forms.Padding(5);
            this.txtInkoopprijs.Name = "txtInkoopprijs";
            this.txtInkoopprijs.Size = new System.Drawing.Size(318, 28);
            this.txtInkoopprijs.TabIndex = 90;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(368, 43);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(318, 29);
            this.cbProduct.TabIndex = 88;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // epContactPersoon
            // 
            this.epContactPersoon.ContainerControl = this;
            // 
            // epStraatnaam
            // 
            this.epStraatnaam.ContainerControl = this;
            // 
            // epHuisnummer
            // 
            this.epHuisnummer.ContainerControl = this;
            // 
            // epBus
            // 
            this.epBus.ContainerControl = this;
            // 
            // epPostcode
            // 
            this.epPostcode.ContainerControl = this;
            // 
            // epGemeente
            // 
            this.epGemeente.ContainerControl = this;
            // 
            // epTelefoon
            // 
            this.epTelefoon.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "Select Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(188, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 87;
            this.label9.Text = "Marge";
            // 
            // txtMarge
            // 
            this.txtMarge.Enabled = false;
            this.txtMarge.Location = new System.Drawing.Point(368, 230);
            this.txtMarge.Margin = new System.Windows.Forms.Padding(5);
            this.txtMarge.Name = "txtMarge";
            this.txtMarge.Size = new System.Drawing.Size(318, 28);
            this.txtMarge.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 85;
            this.label8.Text = "Inkoopprijs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 413);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 79;
            this.label5.Text = "BTW";
            // 
            // txtNaam
            // 
            this.txtNaam.Enabled = false;
            this.txtNaam.Location = new System.Drawing.Point(368, 104);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(5);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(318, 28);
            this.txtNaam.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 75;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "Eenheid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 92;
            this.label4.Text = "Leverancier";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(188, 539);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(104, 23);
            this.lblCategorie.TabIndex = 93;
            this.lblCategorie.Text = "Categorie";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackColor = System.Drawing.Color.White;
            this.btnVerwijderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijderen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerwijderen.Location = new System.Drawing.Point(589, 600);
            this.btnVerwijderen.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(200, 66);
            this.btnVerwijderen.TabIndex = 97;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnBewerken
            // 
            this.btnBewerken.BackColor = System.Drawing.Color.White;
            this.btnBewerken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBewerken.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewerken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBewerken.Location = new System.Drawing.Point(367, 600);
            this.btnBewerken.Margin = new System.Windows.Forms.Padding(4);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(200, 66);
            this.btnBewerken.TabIndex = 96;
            this.btnBewerken.Text = "Bewerken";
            this.btnBewerken.UseVisualStyleBackColor = false;
            this.btnBewerken.Click += new System.EventHandler(this.btnBewerken_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.White;
            this.btnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToevoegen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToevoegen.Location = new System.Drawing.Point(141, 600);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(200, 66);
            this.btnToevoegen.TabIndex = 95;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // txtAantal
            // 
            this.txtAantal.Enabled = false;
            this.txtAantal.Location = new System.Drawing.Point(368, 288);
            this.txtAantal.Margin = new System.Windows.Forms.Padding(5);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(318, 28);
            this.txtAantal.TabIndex = 98;
            // 
            // txtCategorie
            // 
            this.txtCategorie.Enabled = false;
            this.txtCategorie.Location = new System.Drawing.Point(368, 537);
            this.txtCategorie.Margin = new System.Windows.Forms.Padding(5);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(318, 28);
            this.txtCategorie.TabIndex = 107;
            // 
            // txtLeverancier
            // 
            this.txtLeverancier.Enabled = false;
            this.txtLeverancier.Location = new System.Drawing.Point(368, 471);
            this.txtLeverancier.Margin = new System.Windows.Forms.Padding(5);
            this.txtLeverancier.Name = "txtLeverancier";
            this.txtLeverancier.Size = new System.Drawing.Size(318, 28);
            this.txtLeverancier.TabIndex = 106;
            // 
            // txtBtw
            // 
            this.txtBtw.Enabled = false;
            this.txtBtw.Location = new System.Drawing.Point(368, 411);
            this.txtBtw.Margin = new System.Windows.Forms.Padding(5);
            this.txtBtw.Name = "txtBtw";
            this.txtBtw.Size = new System.Drawing.Size(318, 28);
            this.txtBtw.TabIndex = 105;
            // 
            // txtEenheid
            // 
            this.txtEenheid.Enabled = false;
            this.txtEenheid.Location = new System.Drawing.Point(368, 349);
            this.txtEenheid.Margin = new System.Windows.Forms.Padding(5);
            this.txtEenheid.Name = "txtEenheid";
            this.txtEenheid.Size = new System.Drawing.Size(318, 28);
            this.txtEenheid.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 108;
            this.label6.Text = "Aantal";
            // 
            // epAantal
            // 
            this.epAantal.ContainerControl = this;
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1014, 718);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtLeverancier);
            this.Controls.Add(this.txtBtw);
            this.Controls.Add(this.txtEenheid);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnBewerken);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInkoopprijs);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMarge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageProduct";
            this.Text = "ManageProduct";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epContactPersoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStraatnaam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHuisnummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPostcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGemeente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAantal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInkoopprijs;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ErrorProvider epContactPersoon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider epStraatnaam;
        private System.Windows.Forms.ErrorProvider epHuisnummer;
        private System.Windows.Forms.ErrorProvider epBus;
        private System.Windows.Forms.ErrorProvider epPostcode;
        private System.Windows.Forms.ErrorProvider epGemeente;
        private System.Windows.Forms.ErrorProvider epTelefoon;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnBewerken;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtLeverancier;
        private System.Windows.Forms.TextBox txtBtw;
        private System.Windows.Forms.TextBox txtEenheid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider epAantal;
    }
}