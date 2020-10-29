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
    public partial class SaveKlant : Form
    {
        public SaveKlant()
        {
            InitializeComponent();
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

            if (mtbTelefoonnummer.Text.Trim().Length < 17)
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

        private void SaveKlant_Load(object sender, EventArgs e)
        {
            try
            {
                if (ManageKlant.IsNewKlant)
                {
                    txtVoornaam.Clear();
                    txtAchternaam.Clear();
                    this.txtStraatnaam.Clear();
                    txtHuisNummer.Clear();
                    txtBus.Clear();
                    txtPostcode.Clear();
                    txtGemeente.Clear();
                    mtbTelefoonnummer.Clear();
                    txtEmailadres.Clear();
                    txtOpmerking.Clear();
                }
                else
                {
                    int klantId = ManageKlant.KlantId;

                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        var selectedklant = ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault();

                        if (selectedklant != null)
                        {
                            txtVoornaam.Text = selectedklant.Voornaam;
                            txtAchternaam.Text = selectedklant.Achternaam;
                            this.txtStraatnaam.Text = selectedklant.Straatnaam;
                            txtHuisNummer.Text = selectedklant.Huisnummer;
                            txtBus.Text = selectedklant.Bus;
                            txtPostcode.Text = selectedklant.Postcode.ToString();
                            txtGemeente.Text = selectedklant.Gemeente;
                            mtbTelefoonnummer.Text = selectedklant.Telefoonnummer;
                            txtEmailadres.Text = selectedklant.Emailadres;
                            txtOpmerking.Text = selectedklant.Opmerking;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManageKlant.IsNewKlant)
                {
                    DisplayErrorMessage();

                    if (txtVoornaam.Text.Trim().Length > 0 && txtAchternaam.Text.Trim().Length > 0 && this.txtStraatnaam.Text.Trim().Length > 0
                            && txtHuisNummer.Text.Trim().Length > 0 && txtBus.Text.Trim().Length > 0 && txtPostcode.Text.Trim().Length > 0
                            && txtGemeente.Text.Trim().Length > 0 && mtbTelefoonnummer.Text.Trim().Length == 17 && txtEmailadres.Text.Trim().Length > 0
                            && txtOpmerking.Text.Trim().Length > 0)
                    {
                        string klant = txtVoornaam.Text + " " + txtAchternaam.Text;
                        using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                        {
                            ctx.Klants.Add(new Klant()
                            {
                                Voornaam = txtVoornaam.Text.Trim(),
                                Achternaam = txtAchternaam.Text.Trim(),
                                Straatnaam = this.txtStraatnaam.Text.Trim(),
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
                        this.txtStraatnaam.Clear();
                        txtHuisNummer.Clear();
                        txtBus.Clear();
                        txtPostcode.Clear();
                        txtGemeente.Clear();
                        mtbTelefoonnummer.Clear();
                        txtEmailadres.Clear();
                        txtOpmerking.Clear();
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    DisplayErrorMessage();

                    int klantId = ManageKlant.KlantId;

                    if (txtVoornaam.Text.Trim().Length > 0 && txtAchternaam.Text.Trim().Length > 0 && this.txtStraatnaam.Text.Trim().Length > 0
                            && txtHuisNummer.Text.Trim().Length > 0 && txtBus.Text.Trim().Length > 0 && txtPostcode.Text.Trim().Length > 0
                            && txtGemeente.Text.Trim().Length > 0 && mtbTelefoonnummer.Text.Trim().Length == 17 && txtEmailadres.Text.Trim().Length > 0
                            && txtOpmerking.Text.Trim().Length > 0)
                    {
                        string klant = txtVoornaam.Text + " " + txtAchternaam.Text;
                        using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                        {
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Voornaam = txtVoornaam.Text.Trim();
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Achternaam = txtAchternaam.Text.Trim();
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Straatnaam = this.txtStraatnaam.Text.Trim();
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Huisnummer = txtHuisNummer.Text.Trim();
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Bus = txtBus.Text.Trim();
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Postcode = Convert.ToInt32(txtPostcode.Text.Trim());
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Gemeente = txtGemeente.Text.Trim();
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Telefoonnummer = mtbTelefoonnummer.Text.Trim();
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Emailadres = txtEmailadres.Text.Trim();
                            ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault().Opmerking = txtOpmerking.Text.Trim();
                            ctx.SaveChanges();
                        }
                        MessageBox.Show(klant + " is succesvol bijgewerkt");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
