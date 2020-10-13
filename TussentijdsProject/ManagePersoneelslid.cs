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
    public partial class ManagePersoneelslid : Form
    {
        public ManagePersoneelslid()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (txtName.Text.Trim().Length > 0)
            {
                string personeelslid = txtName.Text;
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.Personeelslids.Add(new Personeelslid() { Voornaam = txtName.Text });
                    ctx.SaveChanges();
                }
                MessageBox.Show(personeelslid + " is succesvol toegevoegd");
                txtName.Clear();
                DisplayPersoneelsLid();
            }
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (txtName.Text.Trim().Length > 0)
            {
                string personeelslid = txtName.Text;
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    ctx.Personeelslids.Where(x => x.PersoneelslidID == (int)lbPersoneelslid.SelectedValue).FirstOrDefault().Voornaam = txtName.Text.Trim();
                    ctx.SaveChanges();
                }
                MessageBox.Show(personeelslid + " is succesvol bijgewerkt");

                DisplayPersoneelsLid();
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            string personeelslid = lbPersoneelslid.Text;
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Personeelslids.RemoveRange(ctx.Personeelslids.Where(x => x.PersoneelslidID == (int)lbPersoneelslid.SelectedValue));
                ctx.SaveChanges();
            }
            MessageBox.Show(personeelslid + " is succesvol verwijderd");
            DisplayPersoneelsLid();
        }

        private void ManagePersoneelslid_Load(object sender, EventArgs e)
        {
            DisplayPersoneelsLid();
        }

        public void DisplayPersoneelsLid()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for PersoneelsLid
                var personeelsLidLijst = ctx.Personeelslids.Select(x => new
                {
                    Naam = x.Voornaam,
                    Id = x.PersoneelslidID
                }).ToList();
                lbPersoneelslid.DisplayMember = "Naam";
                lbPersoneelslid.ValueMember = "Id";
                lbPersoneelslid.DataSource = personeelsLidLijst;
            }
        }

        public void DisplayErrorMessage()
        {
            string errorMessage = "";
            if (txtName.Text.Trim().Length == 0)
            {
                epNaam.SetError(txtName, "Voornaam naam is niet ingevuld");
                errorMessage += "\r\n" + "Voornaam naam is niet ingevuld";
            }
            else
            {
                epNaam.Clear();
            }

            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}
