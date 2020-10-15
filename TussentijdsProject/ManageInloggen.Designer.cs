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
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cbGebruiker = new System.Windows.Forms.ComboBox();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.epGebruiker = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.epUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWachtwoord = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epGebruiker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWachtwoord)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWachtwoord.Location = new System.Drawing.Point(124, 214);
            this.lblWachtwoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(133, 23);
            this.lblWachtwoord.TabIndex = 10;
            this.lblWachtwoord.Text = "Wachtwoord";
            // 
            // txtPassword
            // 
            this.epWachtwoord.SetIconAlignment(this.txtPassword, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.epGebruiker.SetIconAlignment(this.txtPassword, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.txtPassword.Location = new System.Drawing.Point(322, 214);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(380, 32);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(322, 145);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 32);
            this.txtUsername.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(124, 145);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 23);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // cbGebruiker
            // 
            this.cbGebruiker.FormattingEnabled = true;
            this.epWachtwoord.SetIconAlignment(this.cbGebruiker, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.epGebruiker.SetIconAlignment(this.cbGebruiker, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.cbGebruiker.Location = new System.Drawing.Point(322, 80);
            this.cbGebruiker.Margin = new System.Windows.Forms.Padding(4);
            this.cbGebruiker.Name = "cbGebruiker";
            this.cbGebruiker.Size = new System.Drawing.Size(380, 31);
            this.cbGebruiker.TabIndex = 15;
            this.cbGebruiker.Text = "Select Gebruiker";
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.Location = new System.Drawing.Point(124, 75);
            this.lblGebruiker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(106, 23);
            this.lblGebruiker.TabIndex = 16;
            this.lblGebruiker.Text = "Gubruiker";
            // 
            // epGebruiker
            // 
            this.epGebruiker.ContainerControl = this;
            this.epGebruiker.RightToLeft = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epGebruiker.SetIconAlignment(this.label4, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.label4.Location = new System.Drawing.Point(531, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(224, 85);
            this.label4.TabIndex = 19;
            this.label4.Text = "Een lengte van 8-20 characters\r\nMinstens 1 vreemd teken\r\nMinstens 1 hoofdletter\r\n" +
    "Minstens 1 kleine letter\r\nMinstens 1 cijfer";
            // 
            // epUserName
            // 
            this.epUserName.ContainerControl = this;
            // 
            // epWachtwoord
            // 
            this.epWachtwoord.ContainerControl = this;
            this.epWachtwoord.RightToLeft = true;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.White;
            this.btnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToevoegen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToevoegen.Location = new System.Drawing.Point(290, 387);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(205, 57);
            this.btnToevoegen.TabIndex = 17;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.White;
            this.btnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleren.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuleren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnnuleren.Location = new System.Drawing.Point(503, 387);
            this.btnAnnuleren.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(205, 57);
            this.btnAnnuleren.TabIndex = 18;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // ManageInloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1065, 677);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.cbGebruiker);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageInloggen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageInloggen";
            this.Load += new System.EventHandler(this.ManageInloggen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epGebruiker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWachtwoord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbGebruiker;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.ErrorProvider epGebruiker;
        private System.Windows.Forms.ErrorProvider epUserName;
        private System.Windows.Forms.ErrorProvider epWachtwoord;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label label4;
    }
}