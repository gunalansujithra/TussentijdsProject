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
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Personeelslids.Add(new Personeelslid() { Voornaam = txtName.Text});
                ctx.SaveChanges();
            }
            txtName.Clear();
            DisplayPersoneelsLid();
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Personeelslids.Where(x => x.PersoneelslidID == (int)lbPersoneelslid.SelectedValue).FirstOrDefault().Voornaam = txtName.Text.Trim();
                ctx.SaveChanges();
            }

            DisplayPersoneelsLid();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Personeelslids.RemoveRange(ctx.Personeelslids.Where(x => x.PersoneelslidID == (int)lbPersoneelslid.SelectedValue));
                ctx.SaveChanges();
            }

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
    }
}
