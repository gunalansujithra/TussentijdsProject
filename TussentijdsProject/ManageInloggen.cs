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
    public partial class ManageInloggen : Form
    {
        public ManageInloggen()
        {
            InitializeComponent();
        }

        private void ManageInloggen_Load(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                var gebruikerLijst = ctx.Gebruikers.Select(x => new
                {
                    Naam = x.Naam,
                    Id = x.GebruikerId
                }).ToList();
                cbGebruiker.DisplayMember = "Naam";
                cbGebruiker.ValueMember = "Id";
                cbGebruiker.DataSource = gebruikerLijst;
            }
            
            DisplayUsername();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (txtUsername.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0 && cbGebruiker.SelectedIndex >= 0)
            {
                string gebruiker = txtUsername.Text;
                string encrypWW = EncryptWachtwoord(txtPassword.Text.Trim());
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.InLoggens.Add(new InLoggen() { Username = txtUsername.Text, Wachtwoord = encrypWW, GebruikerId = (int)cbGebruiker.SelectedValue });
                    ctx.SaveChanges();
                }
                MessageBox.Show(gebruiker + " is succesvol toegevoegd");
                txtUsername.Clear();
                txtPassword.Clear();
                cbGebruiker.SelectedIndex = 0;
                DisplayUsername();
            }
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (txtUsername.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0 && cbGebruiker.SelectedIndex >= 0)
            {
                string gebruiker = txtUsername.Text;
                string encrypWW = EncryptWachtwoord(txtPassword.Text.Trim());
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.InLoggens.Where(x => x.InloggenId == (int)lbUsername.SelectedValue).FirstOrDefault().Username = txtUsername.Text.Trim();
                    ctx.InLoggens.Where(x => x.InloggenId == (int)lbUsername.SelectedValue).FirstOrDefault().Wachtwoord = encrypWW;
                    ctx.SaveChanges();
                }
                MessageBox.Show(gebruiker + " is succesvol bijgewerkt");
                DisplayUsername();
                cbGebruiker.SelectedIndex = 0;
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            string gebruiker = lbUsername.Text;
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.InLoggens.RemoveRange(ctx.InLoggens.Where(x => x.InloggenId == (int)lbUsername.SelectedValue));
                ctx.SaveChanges();
            }
            MessageBox.Show(gebruiker + " is succesvol verwijderd");
            DisplayUsername();
        }

        public void DisplayUsername()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Usernames
                var usersLijst = ctx.InLoggens.Select(x => new
                {
                    Naam = x.Username,
                    Id = x.InloggenId
                }).ToList();
                lbUsername.DisplayMember = "Naam";
                lbUsername.ValueMember = "Id";
                lbUsername.DataSource = usersLijst  ;
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

            if (cbGebruiker.SelectedIndex < 0)
            {
                epGebruiker.SetError(cbGebruiker, "Gebruiker is niet geselecteerd");
                errorMessage += "\r\n" + "Gebruiker is niet geselecteerd";
            }
            else
            {
                epGebruiker.Clear();
            }

            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}
