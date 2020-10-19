namespace TussentijdsProject
{
    partial class InloggenScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InloggenScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.epUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWachtwoord = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWachtwoord = new System.Windows.Forms.CheckBox();
            this.lntWwVergeten = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWachtwoord)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(242, 250);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 32);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(242, 339);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(380, 32);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wachtwoord";
            // 
            // btnInloggen
            // 
            this.btnInloggen.BackColor = System.Drawing.Color.White;
            this.btnInloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInloggen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInloggen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInloggen.Location = new System.Drawing.Point(289, 439);
            this.btnInloggen.Margin = new System.Windows.Forms.Padding(4);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(257, 57);
            this.btnInloggen.TabIndex = 5;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = false;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // epUserName
            // 
            this.epUserName.ContainerControl = this;
            // 
            // epWachtwoord
            // 
            this.epWachtwoord.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShutdown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 79);
            this.panel1.TabIndex = 7;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.Location = new System.Drawing.Point(803, 12);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(58, 45);
            this.btnShutdown.TabIndex = 1;
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bestellingen ";
            // 
            // cbWachtwoord
            // 
            this.cbWachtwoord.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbWachtwoord.AutoSize = true;
            this.cbWachtwoord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWachtwoord.Image = ((System.Drawing.Image)(resources.GetObject("cbWachtwoord.Image")));
            this.cbWachtwoord.Location = new System.Drawing.Point(633, 339);
            this.cbWachtwoord.Name = "cbWachtwoord";
            this.cbWachtwoord.Size = new System.Drawing.Size(31, 31);
            this.cbWachtwoord.TabIndex = 8;
            this.cbWachtwoord.UseVisualStyleBackColor = true;
            this.cbWachtwoord.CheckedChanged += new System.EventHandler(this.cbWachtwoord_CheckedChanged);
            // 
            // lntWwVergeten
            // 
            this.lntWwVergeten.AutoSize = true;
            this.lntWwVergeten.DisabledLinkColor = System.Drawing.Color.White;
            this.lntWwVergeten.LinkColor = System.Drawing.Color.White;
            this.lntWwVergeten.Location = new System.Drawing.Point(420, 382);
            this.lntWwVergeten.Name = "lntWwVergeten";
            this.lntWwVergeten.Size = new System.Drawing.Size(245, 23);
            this.lntWwVergeten.TabIndex = 9;
            this.lntWwVergeten.TabStop = true;
            this.lntWwVergeten.Text = "Wachtwoord vergeten?";
            this.lntWwVergeten.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lntWwVergeten_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Log in op uw account";
            // 
            // InloggenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(873, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lntWwVergeten);
            this.Controls.Add(this.cbWachtwoord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InloggenScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InloggenScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWachtwoord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.ErrorProvider epUserName;
        private System.Windows.Forms.ErrorProvider epWachtwoord;
        private System.Windows.Forms.CheckBox cbWachtwoord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lntWwVergeten;
    }
}

