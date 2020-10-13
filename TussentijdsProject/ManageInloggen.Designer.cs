namespace TussentijdsProject
{
    partial class ManageInloggen
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
            this.btnBewerken = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.ListBox();
            this.cbGebruiker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.epGebruiker = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWachtwoord = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epGebruiker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWachtwoord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBewerken
            // 
            this.btnBewerken.Location = new System.Drawing.Point(395, 399);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(160, 50);
            this.btnBewerken.TabIndex = 12;
            this.btnBewerken.Text = "Bewerken";
            this.btnBewerken.UseVisualStyleBackColor = true;
            this.btnBewerken.Click += new System.EventHandler(this.btnBewerken_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(522, 112);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(160, 50);
            this.btnToevoegen.TabIndex = 11;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wachtwoord";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(215, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(255, 22);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(215, 101);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(255, 22);
            this.txtUsername.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(577, 399);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(160, 50);
            this.btnVerwijderen.TabIndex = 13;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.FormattingEnabled = true;
            this.lbUsername.ItemHeight = 16;
            this.lbUsername.Location = new System.Drawing.Point(53, 284);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(309, 308);
            this.lbUsername.TabIndex = 14;
            // 
            // cbGebruiker
            // 
            this.cbGebruiker.FormattingEnabled = true;
            this.cbGebruiker.Location = new System.Drawing.Point(215, 56);
            this.cbGebruiker.Name = "cbGebruiker";
            this.cbGebruiker.Size = new System.Drawing.Size(255, 24);
            this.cbGebruiker.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gubruiker";
            // 
            // epGebruiker
            // 
            this.epGebruiker.ContainerControl = this;
            // 
            // epUserName
            // 
            this.epUserName.ContainerControl = this;
            // 
            // epWachtwoord
            // 
            this.epWachtwoord.ContainerControl = this;
            // 
            // ManageInloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGebruiker);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnBewerken);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "ManageInloggen";
            this.Text = "ManageInloggen";
            this.Load += new System.EventHandler(this.ManageInloggen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epGebruiker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWachtwoord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBewerken;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.ListBox lbUsername;
        private System.Windows.Forms.ComboBox cbGebruiker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epGebruiker;
        private System.Windows.Forms.ErrorProvider epUserName;
        private System.Windows.Forms.ErrorProvider epWachtwoord;
    }
}