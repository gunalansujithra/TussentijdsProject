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

        public static bool IsNewKlant = false;
        public static int KlantId = 0;

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            IsNewKlant = true;
            SaveKlant saveKlant = new SaveKlant();
            if (saveKlant.ShowDialog() == DialogResult.OK)
            {
                DisplayKlants();
            }
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            if (cbKlant.SelectedIndex >= 0)
            {
                IsNewKlant = false;
                KlantId = (int)cbKlant.SelectedValue;
                SaveKlant saveKlant = new SaveKlant();
                if (saveKlant.ShowDialog() == DialogResult.OK)
                {
                    DisplayKlants();
                }
            }
            else
            {
                MessageBox.Show("Selecteer een klant om te bewerken");
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (cbKlant.SelectedIndex >= 0)
            {
                string klant = cbKlant.Text;
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.Klants.RemoveRange(ctx.Klants.Where(x => x.KlantID == (int)cbKlant.SelectedValue));
                    ctx.SaveChanges();
                }
                MessageBox.Show(klant + " is succesvol verwijderd");
                DisplayKlants();
            }
            else
            {
                MessageBox.Show("Selecteer een klant om te verwijderen");
            }
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
                cbKlant.DisplayMember = "Naam";
                cbKlant.ValueMember = "Id";
                cbKlant.DataSource = klantsLijst;
                if (klantsLijst.Count == 0)
                {
                    cbKlant.Text = "";
                    txtVoornaam.Clear();
                    txtAchternaam.Clear();
                    txtStraatnaam.Clear();
                    txtHuisNummer.Clear();
                    txtBus.Clear();
                    txtPostcode.Clear();
                    txtGemeente.Clear();
                    txtTelefoon.Clear();
                    txtEmailadres.Clear();
                    txtAangemaaktOp.Clear();
                    txtOpmerking.Clear();
                }
            }
        }

        private void ManageKlant_Load(object sender, EventArgs e)
        {
            DisplayKlants();
        }

        private void cbKlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKlant.SelectedIndex >= 0)
            {
                int klantId = Convert.ToInt32(cbKlant.SelectedValue);

                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    var selectedklant = ctx.Klants.Where(x => x.KlantID == klantId).FirstOrDefault();

                    if (selectedklant != null)
                    {
                        txtVoornaam.Text = selectedklant.Voornaam;
                        txtAchternaam.Text = selectedklant.Achternaam;
                        txtStraatnaam.Text = selectedklant.Straatnaam;
                        txtHuisNummer.Text = selectedklant.Huisnummer;
                        txtBus.Text = selectedklant.Bus;
                        txtPostcode.Text = selectedklant.Postcode.ToString();
                        txtGemeente.Text = selectedklant.Gemeente;
                        txtTelefoon.Text = selectedklant.Telefoonnummer;
                        txtEmailadres.Text = selectedklant.Emailadres;
                        txtAangemaaktOp.Text = selectedklant.AangemaaktOp.ToString();
                        txtOpmerking.Text = selectedklant.Opmerking;                        
                    }
                }
            }
        }
    }
}
