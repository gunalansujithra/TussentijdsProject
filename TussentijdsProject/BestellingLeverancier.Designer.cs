namespace TussentijdsProject
{
    partial class BestellingLeverancier
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
            this.txtTotaalPrijs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAfrekenen = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbKaart = new System.Windows.Forms.ListBox();
            this.lbProduct = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLeverancier = new System.Windows.Forms.ComboBox();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPersoneelsLid = new System.Windows.Forms.ComboBox();
            this.epPersoneelLids = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLeverancier = new System.Windows.Forms.ErrorProvider(this.components);
            this.epProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUnits = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epPersoneelLids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLeverancier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotaalPrijs
            // 
            this.txtTotaalPrijs.Location = new System.Drawing.Point(716, 625);
            this.txtTotaalPrijs.Name = "txtTotaalPrijs";
            this.txtTotaalPrijs.Size = new System.Drawing.Size(197, 28);
            this.txtTotaalPrijs.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 630);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 77;
            this.label5.Text = "Totaalprijs";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(258, 354);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(319, 28);
            this.txtUnits.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 75;
            this.label4.Text = "Units";
            // 
            // btnAfrekenen
            // 
            this.btnAfrekenen.BackColor = System.Drawing.Color.White;
            this.btnAfrekenen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfrekenen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfrekenen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAfrekenen.Location = new System.Drawing.Point(526, 675);
            this.btnAfrekenen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfrekenen.Name = "btnAfrekenen";
            this.btnAfrekenen.Size = new System.Drawing.Size(200, 66);
            this.btnAfrekenen.TabIndex = 73;
            this.btnAfrekenen.Text = "Factuur Genereren";
            this.btnAfrekenen.UseVisualStyleBackColor = false;
            this.btnAfrekenen.Click += new System.EventHandler(this.btnAfrekenen_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.BackColor = System.Drawing.Color.White;
            this.btnWissen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWissen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWissen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnWissen.Location = new System.Drawing.Point(311, 675);
            this.btnWissen.Margin = new System.Windows.Forms.Padding(4);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(200, 66);
            this.btnWissen.TabIndex = 72;
            this.btnWissen.Text = "Winkelmandje Wissen";
            this.btnWissen.UseVisualStyleBackColor = false;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackColor = System.Drawing.Color.White;
            this.btnVerwijderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijderen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerwijderen.Location = new System.Drawing.Point(92, 675);
            this.btnVerwijderen.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(200, 66);
            this.btnVerwijderen.TabIndex = 71;
            this.btnVerwijderen.Text = "Winkelmandje Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.White;
            this.btnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToevoegen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToevoegen.Location = new System.Drawing.Point(318, 413);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(200, 66);
            this.btnToevoegen.TabIndex = 70;
            this.btnToevoegen.Text = "Voeg toe aan winkelmandje";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "Winkelmandje";
            // 
            // lbKaart
            // 
            this.lbKaart.FormattingEnabled = true;
            this.lbKaart.ItemHeight = 21;
            this.lbKaart.Location = new System.Drawing.Point(259, 502);
            this.lbKaart.Name = "lbKaart";
            this.lbKaart.Size = new System.Drawing.Size(318, 151);
            this.lbKaart.TabIndex = 68;
            // 
            // lbProduct
            // 
            this.lbProduct.FormattingEnabled = true;
            this.lbProduct.ItemHeight = 21;
            this.lbProduct.Location = new System.Drawing.Point(259, 185);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(318, 151);
            this.lbProduct.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Select Product";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 25);
            this.label11.TabIndex = 65;
            this.label11.Text = "Select Levereancier";
            // 
            // cbLeverancier
            // 
            this.cbLeverancier.FormattingEnabled = true;
            this.cbLeverancier.Location = new System.Drawing.Point(260, 75);
            this.cbLeverancier.Name = "cbLeverancier";
            this.cbLeverancier.Size = new System.Drawing.Size(317, 29);
            this.cbLeverancier.TabIndex = 64;
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(260, 132);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(320, 29);
            this.cbCategorie.TabIndex = 63;
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(58, 133);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(174, 23);
            this.lblCategorie.TabIndex = 62;
            this.lblCategorie.Text = "Select Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Select PersoneelsLid";
            // 
            // cbPersoneelsLid
            // 
            this.cbPersoneelsLid.FormattingEnabled = true;
            this.cbPersoneelsLid.Location = new System.Drawing.Point(260, 22);
            this.cbPersoneelsLid.Name = "cbPersoneelsLid";
            this.cbPersoneelsLid.Size = new System.Drawing.Size(318, 29);
            this.cbPersoneelsLid.TabIndex = 60;
            // 
            // epPersoneelLids
            // 
            this.epPersoneelLids.ContainerControl = this;
            // 
            // epLeverancier
            // 
            this.epLeverancier.ContainerControl = this;
            // 
            // epProduct
            // 
            this.epProduct.ContainerControl = this;
            // 
            // epUnits
            // 
            this.epUnits.ContainerControl = this;
            // 
            // BestellingLeverancier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 762);
            this.Controls.Add(this.txtTotaalPrijs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAfrekenen);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbKaart);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbLeverancier);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPersoneelsLid);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BestellingLeverancier";
            this.Text = "BestellingLeverancier";
            this.Load += new System.EventHandler(this.BestellingLeverancier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epPersoneelLids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLeverancier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotaalPrijs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAfrekenen;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbKaart;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbLeverancier;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPersoneelsLid;
        private System.Windows.Forms.ErrorProvider epPersoneelLids;
        private System.Windows.Forms.ErrorProvider epLeverancier;
        private System.Windows.Forms.ErrorProvider epProduct;
        private System.Windows.Forms.ErrorProvider epUnits;
    }
}