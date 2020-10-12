using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.InLoggens.Add(new InLoggen() { Username = txtUsername.Text, Wachtwoord = txtPassword.Text, GebruikerId = (int)cbGebruiker.SelectedValue });
                ctx.SaveChanges();
            }
            txtUsername.Clear();
            txtPassword.Clear();
            cbGebruiker.SelectedIndex = 0;
            DisplayUsername();
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.InLoggens.Where(x => x.InloggenId == (int)lbUsername.SelectedValue).FirstOrDefault().Username = txtUsername.Text.Trim();
                ctx.InLoggens.Where(x => x.InloggenId == (int)lbUsername.SelectedValue).FirstOrDefault().Wachtwoord = txtPassword.Text.Trim();
                ctx.SaveChanges();
            }

            DisplayUsername();
            cbGebruiker.SelectedIndex = 0;
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.InLoggens.RemoveRange(ctx.InLoggens.Where(x => x.InloggenId == (int)lbUsername.SelectedValue));
                ctx.SaveChanges();
            }

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
    }
}
