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
    public partial class SaveInloggen : Form
    {
        public SaveInloggen()
        {
            InitializeComponent();
        }

        private void ManageInloggen_Load(object sender, EventArgs e)
        {
            try
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

                    cbGebruiker.SelectedIndex = -1;
                }

                if (ManageInloggen.IsNewUser)
                {
                    lblGebruiker.Visible = true;
                    cbGebruiker.Visible = true;
                    lblWachtwoord.Text = "Wachtwoord";
                }
                else if (!ManageInloggen.IsNewUser)
                {
                    lblGebruiker.Visible = true;
                    cbGebruiker.Visible = true;
                    lblWachtwoord.Text = "Wachtwoord";

                    int userId = ManageInloggen.UserId;

                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        var selectedUser = ctx.InLoggens.Where(x => x.InloggenId == userId).FirstOrDefault();

                        if (selectedUser != null)
                        {
                            txtUsername.Text = selectedUser.Username;
                            cbGebruiker.SelectedValue = selectedUser.GebruikerId;
                        }
                    }

                }
                if (InloggenScreen.IsWachtwoordVergeten == true)
                {
                    lblGebruiker.Visible = false;
                    cbGebruiker.Visible = false;
                    lblWachtwoord.Text = "Nieuw Wachtwoord";
                    txtUsername.Text = InloggenScreen.UserName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        public void DisplayPasswordErrorMessage()
        {
            string errorMessage = "";

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

        public void DisplayErrorMessage()
        {
            string errorMessage = "";

            if (cbGebruiker.SelectedIndex < 0)
            {
                epGebruiker.SetError(cbGebruiker, "Gebruiker is niet geselecteerd");
                errorMessage += "\r\n" + "Gebruiker is niet geselecteerd";
            }
            else
            {
                epGebruiker.Clear();
            }

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

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManageInloggen.IsNewUser == true)
                {
                    DisplayErrorMessage();

                    if (txtUsername.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0 && cbGebruiker.SelectedIndex >= 0)
                    {
                        string validErrorMsg = CheckPassword(txtPassword.Text.Trim());

                        if (validErrorMsg.Length > 0)
                        {
                            MessageBox.Show(validErrorMsg);
                        }
                        else
                        {
                            string gebruiker = txtUsername.Text;
                            string encrypWW = EncryptWachtwoord(txtPassword.Text.Trim());
                            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                            {
                                var usersDetails = ctx.InLoggens.Where(x => x.Username == gebruiker && x.GebruikerId == (int)cbGebruiker.SelectedValue).FirstOrDefault();

                                if (usersDetails != null && usersDetails.Username.ToLower() == gebruiker.ToLower())
                                {
                                    MessageBox.Show(gebruiker + " bestaat al. Kies een andere naam.");
                                    txtUsername.Clear();
                                    txtPassword.Clear();
                                }
                                else
                                {
                                    ctx.InLoggens.Add(new InLoggen() { Username = txtUsername.Text, Wachtwoord = encrypWW, GebruikerId = (int)cbGebruiker.SelectedValue });
                                    ctx.SaveChanges();
                                    MessageBox.Show(gebruiker + " is succesvol toegevoegd");
                                    this.DialogResult = DialogResult.OK;
                                }
                            }
                        }
                    }
                }
                else
                {
                    DisplayPasswordErrorMessage();

                    if (txtUsername.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
                    {
                        string validErrorMsg = CheckPassword(txtPassword.Text.Trim());

                        if (validErrorMsg.Length > 0)
                        {
                            MessageBox.Show(validErrorMsg);
                        }
                        else
                        {
                            string gebruiker = txtUsername.Text;
                            string encrypWW = EncryptWachtwoord(txtPassword.Text.Trim());

                            bool isUpdated = false;
                            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                            {
                                var usersDetails = ctx.InLoggens.Where(x => x.Username == gebruiker).FirstOrDefault();

                                if (usersDetails != null && usersDetails.Username == gebruiker)
                                {
                                    ctx.InLoggens.Where(x => x.InloggenId == usersDetails.InloggenId).FirstOrDefault().Wachtwoord = encrypWW;
                                    if (ManageInloggen.IsNewUser == false && InloggenScreen.IsWachtwoordVergeten == false)
                                    {
                                        ctx.InLoggens.Where(x => x.InloggenId == usersDetails.InloggenId).FirstOrDefault().Username = gebruiker;
                                        ctx.InLoggens.Where(x => x.InloggenId == usersDetails.InloggenId).FirstOrDefault().GebruikerId = (int)cbGebruiker.SelectedValue;
                                    }
                                    ctx.SaveChanges();

                                    MessageBox.Show("Gegevens is succesvol bijgewerkt");
                                    isUpdated = true;
                                }
                                else
                                {
                                    MessageBox.Show("Onjuist Username");
                                }
                            }
                            if (isUpdated)
                                this.DialogResult = DialogResult.OK;
                            else
                                this.DialogResult = DialogResult.Cancel;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string CheckPassword(string wachtwoord)
        {
            string errorMessage = "";

            if (wachtwoord.Length < 8 || wachtwoord.Length > 20)
            {
                errorMessage += "Een lengte van 8-20 characters" + "\n";
            }

            if (!wachtwoord.Any(c => char.IsUpper(c)))
            {
                errorMessage += "Minstens 1 hoofdletter" + "\n";
            }

            if (!wachtwoord.Any(c => char.IsLower(c)))
            {
                errorMessage += "Minstens 1 kleine letter" + "\n";
            }

            if (!wachtwoord.Any(c => char.IsDigit(c)))
            {
                errorMessage += "Minstens 1 cijfer" + "\n";
            }

            if (wachtwoord.IndexOfAny("!@#$%^&*?_~-£().,".ToCharArray()) == -1)
            {
                errorMessage += "Minstens 1 vreemd teken" + "\n";
            }

            return errorMessage;
        }
    }
}
