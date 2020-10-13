namespace TussentijdsProject
{
    partial class ManageKlant
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbKlant = new System.Windows.Forms.ListBox();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnBewerken = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStraatnaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHuisNummer = new System.Windows.Forms.TextBox();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.txtGemeente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmailadres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOpmerking = new System.Windows.Forms.TextBox();
            this.mtbTelefoonnummer = new System.Windows.Forms.MaskedTextBox();
            this.epVoornaam = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAchternaam = new System.Windows.Forms.ErrorProvider(this.components);
            this.epStraatnaam = new System.Windows.Forms.ErrorProvider(this.components);
            this.epHuisnummer = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBus = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPostcode = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGemeente = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefoon = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOpmerking = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epVoornaam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAchternaam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStraatnaam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHuisnummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPostcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGemeente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpmerking)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Voornaam";
            // 
            // lbKlant
            // 
            this.lbKlant.FormattingEnabled = true;
            this.lbKlant.ItemHeight = 16;
            this.lbKlant.Location = new System.Drawing.Point(47, 426);
            this.lbKlant.Name = "lbKlant";
            this.lbKlant.Size = new System.Drawing.Size(325, 292);
            this.lbKlant.TabIndex = 24;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(571, 525);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(160, 50);
            this.btnVerwijderen.TabIndex = 23;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnBewerken
            // 
            this.btnBewerken.Location = new System.Drawing.Point(389, 525);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(160, 50);
            this.btnBewerken.TabIndex = 22;
            this.btnBewerken.Text = "Bewerken";
            this.btnBewerken.UseVisualStyleBackColor = true;
            this.btnBewerken.Click += new System.EventHandler(this.btnBewerken_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(497, 96);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(160, 50);
            this.btnToevoegen.TabIndex = 21;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Straatnaam";
            // 
            // txtStraatnaam
            // 
            this.txtStraatnaam.Location = new System.Drawing.Point(190, 133);
            this.txtStraatnaam.Name = "txtStraatnaam";
            this.txtStraatnaam.Size = new System.Drawing.Size(255, 22);
            this.txtStraatnaam.TabIndex = 19;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(190, 85);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(255, 22);
            this.txtAchternaam.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Achternaam";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(190, 36);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(255, 22);
            this.txtVoornaam.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Huisnummer";
            // 
            // txtHuisNummer
            // 
            this.txtHuisNummer.Location = new System.Drawing.Point(190, 187);
            this.txtHuisNummer.Name = "txtHuisNummer";
            this.txtHuisNummer.Size = new System.Drawing.Size(67, 22);
            this.txtHuisNummer.TabIndex = 30;
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(378, 187);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(67, 22);
            this.txtBus.TabIndex = 32;
            // 
            // txtGemeente
            // 
            this.txtGemeente.Location = new System.Drawing.Point(378, 232);
            this.txtGemeente.Name = "txtGemeente";
            this.txtGemeente.Size = new System.Drawing.Size(67, 22);
            this.txtGemeente.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Postcode";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(190, 232);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(67, 22);
            this.txtPostcode.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Gemeente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Telefoonnummer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Emailadres";
            // 
            // txtEmailadres
            // 
            this.txtEmailadres.Location = new System.Drawing.Point(190, 327);
            this.txtEmailadres.Name = "txtEmailadres";
            this.txtEmailadres.Size = new System.Drawing.Size(255, 22);
            this.txtEmailadres.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "Opmerking";
            // 
            // txtOpmerking
            // 
            this.txtOpmerking.Location = new System.Drawing.Point(190, 368);
            this.txtOpmerking.Name = "txtOpmerking";
            this.txtOpmerking.Size = new System.Drawing.Size(255, 22);
            this.txtOpmerking.TabIndex = 40;
            // 
            // mtbTelefoonnummer
            // 
            this.mtbTelefoonnummer.Location = new System.Drawing.Point(225, 280);
            this.mtbTelefoonnummer.Mask = "+32 (000)  000-000";
            this.mtbTelefoonnummer.Name = "mtbTelefoonnummer";
            this.mtbTelefoonnummer.Size = new System.Drawing.Size(220, 22);
            this.mtbTelefoonnummer.TabIndex = 42;
            // 
            // epVoornaam
            // 
            this.epVoornaam.ContainerControl = this;
            // 
            // epAchternaam
            // 
            this.epAchternaam.ContainerControl = this;
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
            // epOpmerking
            // 
            this.epOpmerking.ContainerControl = this;
            // 
            // ManageKlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 757);
            this.Controls.Add(this.mtbTelefoonnummer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOpmerking);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmailadres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGemeente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHuisNummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKlant);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnBewerken);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStraatnaam);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.label1);
            this.Name = "ManageKlant";
            this.Text = "AddKlant";
            this.Load += new System.EventHandler(this.ManageKlant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epVoornaam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAchternaam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStraatnaam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHuisnummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPostcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGemeente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpmerking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbKlant;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnBewerken;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStraatnaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHuisNummer;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.TextBox txtGemeente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmailadres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOpmerking;
        private System.Windows.Forms.MaskedTextBox mtbTelefoonnummer;
        private System.Windows.Forms.ErrorProvider epVoornaam;
        private System.Windows.Forms.ErrorProvider epAchternaam;
        private System.Windows.Forms.ErrorProvider epStraatnaam;
        private System.Windows.Forms.ErrorProvider epHuisnummer;
        private System.Windows.Forms.ErrorProvider epBus;
        private System.Windows.Forms.ErrorProvider epPostcode;
        private System.Windows.Forms.ErrorProvider epGemeente;
        private System.Windows.Forms.ErrorProvider epTelefoon;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epOpmerking;
    }
}