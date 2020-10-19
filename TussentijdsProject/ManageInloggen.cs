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

        public static bool IsNewUser = false;
        public static int UserId = 0;

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            if (cbUsername.SelectedIndex >= 0)
            {
                IsNewUser = false;
                UserId = (int)cbUsername.SelectedValue;
                InloggenScreen.IsWachtwoordVergeten = false;
                SaveInloggen saveInloggen = new SaveInloggen();
                if (saveInloggen.ShowDialog() == DialogResult.OK)
                {
                    DisplayUserNaam();
                }
            }
            else
            {
                MessageBox.Show("Selecteer een username om te bewerken");
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (cbUsername.SelectedIndex >= 0)
            {
                string username = cbUsername.Text;
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.InLoggens.RemoveRange(ctx.InLoggens.Where(x => x.InloggenId == (int)cbUsername.SelectedValue));
                    ctx.SaveChanges();
                }
                MessageBox.Show(username + " is succesvol verwijderd");
                DisplayUserNaam();
            }
            else
            {
                MessageBox.Show("Selecteer een categorie om te verwijderen");
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            IsNewUser = true;
            SaveInloggen saveInloggen = new SaveInloggen();
            if (saveInloggen.ShowDialog() == DialogResult.OK)
            {
                DisplayUserNaam();
            }
        }

        public void DisplayUserNaam()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for CategorieNaam
                var userNaamLijst = ctx.InLoggens.Select(x => new
                {
                    Naam = x.Username,
                    Id = x.InloggenId
                }).ToList();
                cbUsername.DisplayMember = "Naam";
                cbUsername.ValueMember = "Id";
                cbUsername.DataSource = userNaamLijst;
                if (userNaamLijst.Count == 0)
                {
                    cbUsername.Text = "";
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

        public void DisplayGebruiker()
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
        }

        private void cbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsername.SelectedIndex >= 0)
            {
                int userId = Convert.ToInt32(cbUsername.SelectedValue);

                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    var selectedUser = ctx.InLoggens.Where(x => x.InloggenId == userId).FirstOrDefault();

                    if (selectedUser != null)
                    {
                        txtUsername.Text = selectedUser.Username;
                        //txtPassword.Text = DecryptWachtwoord(selectedUser.Wachtwoord);
                        cbGebruiker.SelectedValue = selectedUser.GebruikerId;
                    }
                }
            }
        }

        private void ManageInloggen_Load(object sender, EventArgs e)
        {
            DisplayGebruiker();
            DisplayUserNaam();            
        }

        //public static string DecryptWachtwoord(string pass)
        //{
        //    using (MD5 md5 = MD5.Create())
        //    {
        //        byte[] input = Encoding.UTF8.GetBytes(pass);
        //        byte[] hash = md5.ComputeHash(input);
        //        return BitConverter.ToString(hash).Replace("-", "");
        //    }
        //}
    }
}
