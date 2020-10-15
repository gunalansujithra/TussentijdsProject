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

        public static bool IsNewLeverancier = false;

        public static int LeverancierId = 0;

        private void btnToevoegen_Click(object sender, EventArgs e)
        {            
            IsNewLeverancier = true;
            SaveLeverancier saveLeverancier = new SaveLeverancier();
            if (saveLeverancier.ShowDialog() == DialogResult.OK)
            {
                DisplayLeverancies();
            }            
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            if (cbLeverancier.SelectedIndex >= 0)
            {
                IsNewLeverancier = false;
                LeverancierId = (int)cbLeverancier.SelectedValue;
                SaveLeverancier saveLeverancier = new SaveLeverancier();
                if (saveLeverancier.ShowDialog() == DialogResult.OK)
                {
                    DisplayLeverancies();
                }
            }
            else
            {
                MessageBox.Show("Selecteer een leverancier om te bewerken");
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (cbLeverancier.SelectedIndex >= 0)
            {
                string levarancier = cbLeverancier.Text;
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.Leveranciers.RemoveRange(ctx.Leveranciers.Where(x => x.LeverancierID == (int)cbLeverancier.SelectedValue));
                    ctx.SaveChanges();
                }
                MessageBox.Show(levarancier + " is succesvol verwijderd");
                DisplayLeverancies();
            }
            else
            {
                MessageBox.Show("Selecteer een leverancier om te verwijderen");
            }
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
                cbLeverancier.DisplayMember = "Naam";
                cbLeverancier.ValueMember = "Id";
                cbLeverancier.DataSource = LeveranciesLijst;
                if (LeveranciesLijst.Count == 0)
                {
                    cbLeverancier.Text = "";
                    txtPersoon.Clear();
                    txtTelefoon.Clear();
                    txtEmailadres.Clear();
                    txtStraatnaam.Clear();
                    txtHuisNummer.Clear();
                    txtBus.Clear();
                    txtPostcode.Clear();
                    txtGemeente.Clear();
                }
            }
        }

        private void cbLeverancier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLeverancier.SelectedIndex >= 0)
            {
                int leverancierId = Convert.ToInt32(cbLeverancier.SelectedValue);

                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    var selectedLeverancier = ctx.Leveranciers.Where(x => x.LeverancierID == leverancierId).FirstOrDefault();

                    if (selectedLeverancier != null)
                    {
                        txtPersoon.Text = selectedLeverancier.Contactpersoon;
                        txtTelefoon.Text = selectedLeverancier.Telefoonnummer;
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
    }
}
