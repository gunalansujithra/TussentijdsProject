using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TussentijdsProject
{
    public partial class InloggenScreen : Form
    {
        public InloggenScreen()
        {
            InitializeComponent();
        }

        public static bool IsNewUser = false;
        public static string UserName = "";
        private void btnInloggen_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (txtUsername.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    //code for Usernames
                    string gebruiker = txtUsername.Text;
                    string encrypWW = EncryptWachtwoord(txtPassword.Text.Trim());
                    var usersDetails = ctx.InLoggens.Where(x => x.Username == gebruiker).FirstOrDefault();

                    if (usersDetails != null && usersDetails.Username == gebruiker && usersDetails.Wachtwoord == encrypWW)
                    {
                        HomePage homePage = new HomePage();
                        this.Hide();
                        homePage.Show();
                    }
                    else
                    {
                        MessageBox.Show("Onjuist Username / Wachtwoord is succesvol toegevoegd");
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
            }
        }

        public static string EncryptWachtwoord(string input)
        {
            MD5CryptoServiceProvider csp = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = csp.ComputeHash(bs);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            string password = sb.ToString();
            return password;
        }

        public void DisplayErrorMessage()
        {
            string errorMessage = "";
            if (txtUsername.Text.Trim().Length == 0)
            {
                epUserName.SetError(txtUsername, "Usernaam is niet ingevuld");
                errorMessage += "\r\n" + "Usernaam is niet ingevuld";
            }
            else
            {
                epUserName.Clear();
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                epWachtwoord.SetError(txtPassword, "Wacthwoord naam is niet ingevuld");
                errorMessage += "\r\n" + "Wacthwoord naam is niet ingevuld";
            }
            else
            {
                epWachtwoord.Clear();
            }

            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
        }       

        private void cbWachtwoord_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWachtwoord.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void InloggenScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsNewUser = true;
            ManageInloggen manageInloggen = new ManageInloggen();
            if (manageInloggen.ShowDialog() == DialogResult.OK)
            {
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void lntWwVergeten_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsNewUser = false;
            UserName = txtUsername.Text;
            ManageInloggen manageInloggen = new ManageInloggen();
            if (manageInloggen.ShowDialog() == DialogResult.OK)
            {
                txtPassword.Clear();
            }
        }
    }
}
