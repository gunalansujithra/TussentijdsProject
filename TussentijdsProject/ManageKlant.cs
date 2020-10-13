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
            DisplayErrorMessage();

            if (txtVoornaam.Text.Trim().Length > 0 && txtAchternaam.Text.Trim().Length > 0 && txtStraatnaam.Text.Trim().Length > 0
                    && txtHuisNummer.Text.Trim().Length > 0 && txtBus.Text.Trim().Length > 0 && txtPostcode.Text.Trim().Length > 0
                    && txtGemeente.Text.Trim().Length > 0 && mtbTelefoonnummer.Text.Trim().Length < 16 && txtEmailadres.Text.Trim().Length > 0
                    && txtOpmerking.Text.Trim().Length > 0)
            {
                string klant = txtVoornaam.Text + " " + txtAchternaam.Text;
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.Klants.Add(new Klant()
                    {
                        Voornaam = txtVoornaam.Text.Trim(),
                        Achternaam = txtAchternaam.Text.Trim(),
                        Straatnaam = txtStraatnaam.Text.Trim(),
                        Huisnummer = txtHuisNummer.Text.Trim(),
                        Bus = txtBus.Text.Trim(),
                        Postcode = Convert.ToInt32(txtPostcode.Text.Trim()),
                        Gemeente = txtGemeente.Text.Trim(),
                        Telefoonnummer = mtbTelefoonnummer.Text.Trim(),
                        Emailadres = txtEmailadres.Text.Trim(),
                        AangemaaktOp = DateTime.Now,
                        Opmerking = txtOpmerking.Text.Trim()
                    });
                    ctx.SaveChanges();
                }
                MessageBox.Show(klant + " is succesvol toegevoegd");
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
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (txtVoornaam.Text.Trim().Length > 0 && txtAchternaam.Text.Trim().Length > 0 && txtStraatnaam.Text.Trim().Length > 0
                    && txtHuisNummer.Text.Trim().Length > 0 && txtBus.Text.Trim().Length > 0 && txtPostcode.Text.Trim().Length > 0
                    && txtGemeente.Text.Trim().Length > 0 && mtbTelefoonnummer.Text.Trim().Length < 16 && txtEmailadres.Text.Trim().Length > 0
                    && txtOpmerking.Text.Trim().Length > 0)
            {
                string klant = txtVoornaam.Text + " " + txtAchternaam.Text;
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
                MessageBox.Show(klant + " is succesvol bijgewerkt");
                DisplayKlants();
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            string klant = lbKlant.Text;
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Klants.RemoveRange(ctx.Klants.Where(x => x.KlantID == (int)lbKlant.SelectedValue));
                ctx.SaveChanges();
            }
            MessageBox.Show(klant + " is succesvol verwijderd");
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

        public void DisplayErrorMessage()
        {
            string errorMessage = "";
            if (txtVoornaam.Text.Trim().Length == 0)
            {
                epVoornaam.SetError(txtVoornaam, "Voornaam is niet ingevuld");
                errorMessage += "\r\n" + "Voornaam is niet ingevuld";
            }
            else
            {
                epVoornaam.Clear();
            }

            if (txtAchternaam.Text.Trim().Length == 0)
            {
                epAchternaam.SetError(txtAchternaam, "Achternaam is niet ingevuld");
                errorMessage += "\r\n" + "Achternaam is niet ingevuld";
            }
            else
            {
                epAchternaam.Clear();
            }

            if (txtStraatnaam.Text.Trim().Length == 0)
            {
                epStraatnaam.SetError(txtStraatnaam, "Straatnaam is niet ingevuld");
                errorMessage += "\r\n" + "Straatnaam is niet ingevuld";
            }
            else
            {
                epStraatnaam.Clear();
            }

            if (txtHuisNummer.Text.Trim().Length == 0)
            {
                epHuisnummer.SetError(txtHuisNummer, "Huisnummer is niet ingevuld");
                errorMessage += "\r\n" + "Huisnummer is niet ingevuld";
            }
            else
            {
                epHuisnummer.Clear();
            }

            if (txtBus.Text.Trim().Length == 0)
            {
                epBus.SetError(txtBus, "Bus is niet ingevuld");
                errorMessage += "\r\n" + "Bus is niet ingevuld";
            }
            else
            {
                epBus.Clear();
            }

            if (txtPostcode.Text.Trim().Length == 0)
            {
                epPostcode.SetError(txtPostcode, "Postcode is niet ingevuld");
                errorMessage += "\r\n" + "Postcode is niet ingevuld";
            }
            else
            {
                epPostcode.Clear();
            }

            if (txtGemeente.Text.Trim().Length == 0)
            {
                epGemeente.SetError(txtGemeente, "Gemeente is niet ingevuld");
                errorMessage += "\r\n" + "Gemeente is niet ingevuld";
            }
            else
            {
                epGemeente.Clear();
            }

            if (mtbTelefoonnummer.Text.Trim().Length < 16)
            {
                epTelefoon.SetError(mtbTelefoonnummer, "Telefoon nummer is niet ingevuld");
                errorMessage += "\r\n" + "Telefoon nummer is niet ingevuld";
            }
            else
            {
                epTelefoon.Clear();
            }

            if (txtEmailadres.Text.Trim().Length == 0)
            {
                epEmail.SetError(txtEmailadres, "E-mailadres is niet ingevuld");
                errorMessage += "\r\n" + "E-mailadres is niet ingevuld";
            }
            else
            {
                epEmail.Clear();
            }

            if (txtOpmerking.Text.Trim().Length == 0)
            {
                epOpmerking.SetError(txtOpmerking, "Opmerking is niet ingevuld");
                errorMessage += "\r\n" + "Opmerking is niet ingevuld";
            }
            else
            {
                epOpmerking.Clear();
            }

            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}
