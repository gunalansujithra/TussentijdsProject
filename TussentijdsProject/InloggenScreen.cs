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
                    var usersDetails = ctx.InLoggens.Where(x => x.Username == gebruiker && x.Wachtwoord == encrypWW).FirstOrDefault();
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
    }
}
