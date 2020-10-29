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
    public partial class SaveLeverancier : Form
    {
        public SaveLeverancier()
        {
            InitializeComponent();
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

        private void SaveLeverancier_Load(object sender, EventArgs e)
        {
            try
            {
                if (ManageLeverancier.IsNewLeverancier)
                {
                    txtPersoon.Clear();
                    mtbTelefoonnummer.Clear();
                    txtEmailadres.Clear();
                    txtStraatnaam.Clear();
                    txtHuisNummer.Clear();
                    txtBus.Clear();
                    txtPostcode.Clear();
                    txtGemeente.Clear();
                }
                else
                {
                    int leverancierId = ManageLeverancier.LeverancierId;

                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        var selectedLeverancier = ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault();

                        if (selectedLeverancier != null)
                        {
                            txtPersoon.Text = selectedLeverancier.Contactpersoon;
                            mtbTelefoonnummer.Text = selectedLeverancier.Telefoonnummer;
                            txtEmailadres.Text = selectedLeverancier.Emailadres;
                            txtStraatnaam.Text = selectedLeverancier.Straatnaam;
                            txtHuisNummer.Text = selectedLeverancier.Huisnummer;
                            txtBus.Text = selectedLeverancier.Bus;
                            txtPostcode.Text = selectedLeverancier.Postcode.ToString();
                            txtGemeente.Text = selectedLeverancier.Gemeente;
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
                if (ManageLeverancier.IsNewLeverancier)
                {
                    DisplayErrorMessage();

                    if (txtPersoon.Text.Trim().Length > 0 && mtbTelefoonnummer.Text.Trim().Length == 17 && txtEmailadres.Text.Trim().Length > 0
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
                                Gemeente = txtGemeente.Text.Trim()
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
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    DisplayErrorMessage();

                    int leverancierId = ManageLeverancier.LeverancierId;
                    if (txtPersoon.Text.Trim().Length > 0 && mtbTelefoonnummer.Text.Trim().Length == 17 && txtEmailadres.Text.Trim().Length > 0
                            && txtStraatnaam.Text.Trim().Length > 0 && txtHuisNummer.Text.Trim().Length > 0 && txtBus.Text.Trim().Length > 0
                            && txtPostcode.Text.Trim().Length > 0 && txtGemeente.Text.Trim().Length > 0)
                    {
                        string levarancier = txtPersoon.Text;
                        using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                        {
                            ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault().Contactpersoon = txtPersoon.Text.Trim();
                            ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault().Telefoonnummer = mtbTelefoonnummer.Text.Trim();
                            ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault().Emailadres = txtEmailadres.Text.Trim();
                            ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault().Straatnaam = txtStraatnaam.Text.Trim();
                            ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault().Huisnummer = txtHuisNummer.Text.Trim();
                            ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault().Bus = txtBus.Text.Trim();
                            ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault().Postcode = Convert.ToInt32(txtPostcode.Text.Trim());
                            ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault().Gemeente = txtGemeente.Text.Trim();
                            ctx.SaveChanges();
                        }
                        MessageBox.Show(levarancier + " is succesvol bijgewerkt");
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
