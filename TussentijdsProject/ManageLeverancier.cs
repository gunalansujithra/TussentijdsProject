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
    public partial class ManageLeverancier : Form
    {
        public ManageLeverancier()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (txtPersoon.Text.Trim().Length > 0 && mtbTelefoonnummer.Text.Trim().Length < 16 && txtEmailadres.Text.Trim().Length > 0
                    && txtStraatnaam.Text.Trim().Length > 0 && txtHuisNummer.Text.Trim().Length > 0 && txtBus.Text.Trim().Length > 0 
                    && txtPostcode.Text.Trim().Length > 0 && txtGemeente.Text.Trim().Length > 0)
            {
                string levarancier = txtPersoon.Text;
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.Leveranciers.Add(new Leverancier()
                    {
                        Contactpersoon = txtPersoon.Text.Trim(),
                        Telefoonnummer = mtbTelefoonnummer.Text.Trim(),
                        Emailadres = txtEmailadres.Text.Trim(),
                        Straatnaam = txtStraatnaam.Text.Trim(),
                        Huisnummer = txtHuisNummer.Text.Trim(),
                        Bus = txtBus.Text.Trim(),
                        Postcode = Convert.ToInt32(txtPostcode.Text.Trim()),
                        Gemeente = txtGemeente.Text.Trim(),

                    });
                    ctx.SaveChanges();
                }
                MessageBox.Show(levarancier + " is succesvol toegevoegd");
                txtPersoon.Clear();
                mtbTelefoonnummer.Clear();
                txtEmailadres.Clear();
                txtStraatnaam.Clear();
                txtHuisNummer.Clear();
                txtBus.Clear();
                txtPostcode.Clear();
                txtGemeente.Clear();
                DisplayLeverancies();
            }
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (txtPersoon.Text.Trim().Length > 0 && mtbTelefoonnummer.Text.Trim().Length < 16 && txtEmailadres.Text.Trim().Length > 0
                    && txtStraatnaam.Text.Trim().Length > 0 && txtHuisNummer.Text.Trim().Length > 0 && txtBus.Text.Trim().Length > 0
                    && txtPostcode.Text.Trim().Length > 0 && txtGemeente.Text.Trim().Length > 0)
            {
                string levarancier = txtPersoon.Text;
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.Leveranciers.Where(x => x.LeverancierID == (int)lbLevancier.SelectedValue).FirstOrDefault().Contactpersoon = txtPersoon.Text.Trim();
                    ctx.Leveranciers.Where(x => x.LeverancierID == (int)lbLevancier.SelectedValue).FirstOrDefault().Telefoonnummer = mtbTelefoonnummer.Text.Trim();
                    ctx.Leveranciers.Where(x => x.LeverancierID == (int)lbLevancier.SelectedValue).FirstOrDefault().Emailadres = txtEmailadres.Text.Trim();
                    ctx.Leveranciers.Where(x => x.LeverancierID == (int)lbLevancier.SelectedValue).FirstOrDefault().Straatnaam = txtStraatnaam.Text.Trim();
                    ctx.Leveranciers.Where(x => x.LeverancierID == (int)lbLevancier.SelectedValue).FirstOrDefault().Huisnummer = txtHuisNummer.Text.Trim();
                    ctx.Leveranciers.Where(x => x.LeverancierID == (int)lbLevancier.SelectedValue).FirstOrDefault().Bus = txtBus.Text.Trim();
                    ctx.Leveranciers.Where(x => x.LeverancierID == (int)lbLevancier.SelectedValue).FirstOrDefault().Postcode = Convert.ToInt32(txtPostcode.Text.Trim());
                    ctx.Leveranciers.Where(x => x.LeverancierID == (int)lbLevancier.SelectedValue).FirstOrDefault().Gemeente = txtGemeente.Text.Trim();
                    ctx.SaveChanges();
                }
                MessageBox.Show(levarancier + " is succesvol bijgewerkt");

                DisplayLeverancies();
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            string levarancier = lbLevancier.Text;
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Leveranciers.RemoveRange(ctx.Leveranciers.Where(x => x.LeverancierID == (int)lbLevancier.SelectedValue));
                ctx.SaveChanges();
            }
            MessageBox.Show(levarancier + " is succesvol verwijderd");
            DisplayLeverancies();
        }

        private void ManageLeverancier_Load(object sender, EventArgs e)
        {
            DisplayLeverancies();
        }

        public void DisplayLeverancies()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Leverancies
                var LeveranciesLijst = ctx.Leveranciers.Select(x => new
                {
                    Naam = x.Contactpersoon,
                    Id = x.LeverancierID
                }).ToList();
                lbLevancier.DisplayMember = "Naam";
                lbLevancier.ValueMember = "Id";
                lbLevancier.DataSource = LeveranciesLijst;
            }
        }

        public void DisplayErrorMessage()
        {
            string errorMessage = "";
            if (txtPersoon.Text.Trim().Length == 0)
            {
                epContactPersoon.SetError(txtPersoon, "Contact persoon is niet ingevuld");
                errorMessage += "\r\n" + "Contact persoon is niet ingevuld";
            }
            else
            {
                epContactPersoon.Clear();
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

            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}
