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
    public partial class ManageKlant : Form
    {
        public ManageKlant()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Klants.Add(new Klant() { Voornaam = txtVoornaam.Text.Trim(), Achternaam = txtAchternaam.Text.Trim(), Straatnaam = txtStraatnaam.Text.Trim(),
                                                Huisnummer = txtHuisNummer.Text.Trim(), Bus = txtBus.Text.Trim(), Postcode = Convert.ToInt32(txtPostcode.Text.Trim()),
                                                Gemeente = txtGemeente.Text.Trim(), Telefoonnummer = mtbTelefoonnummer.Text.Trim(), Emailadres = txtEmailadres.Text.Trim(),
                                                AangemaaktOp = DateTime.Now, Opmerking = txtOpmerking.Text.Trim()
                });
                ctx.SaveChanges();
            }
            txtVoornaam.Clear();
            txtAchternaam.Clear();
            txtStraatnaam.Clear();
            txtHuisNummer.Clear();
            txtBus.Clear();
            txtPostcode.Clear();
            txtGemeente.Clear();
            mtbTelefoonnummer.Clear();
            txtEmailadres.Clear();
            txtOpmerking.Clear();
            DisplayKlants();
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Voornaam = txtVoornaam.Text.Trim();
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Achternaam = txtAchternaam.Text.Trim();
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Straatnaam = txtStraatnaam.Text.Trim();
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Huisnummer = txtHuisNummer.Text.Trim();
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Bus = txtBus.Text.Trim();
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Postcode = Convert.ToInt32(txtPostcode.Text.Trim());
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Gemeente = txtGemeente.Text.Trim();
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Telefoonnummer = mtbTelefoonnummer.Text.Trim();
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Emailadres = txtEmailadres.Text.Trim();
                ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue).FirstOrDefault().Opmerking = txtOpmerking.Text.Trim();
                ctx.SaveChanges();
            }

            DisplayKlants();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Klants.RemoveRange(ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue));
                ctx.SaveChanges();
            }

            DisplayKlants();
        }

        public void DisplayKlants()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Klant
                var klantsLijst = ctx.Klants.Select(x => new
                {
                    Naam = x.Voornaam + " " + x.Achternaam,
                    Id = x.KlantID
                }).ToList();
                lbKlant.DisplayMember = "Naam";
                lbKlant.ValueMember = "Id";
                lbKlant.DataSource = klantsLijst;
            }
        }

        private void ManageKlant_Load(object sender, EventArgs e)
        {
            DisplayKlants();
        }
    }
}
