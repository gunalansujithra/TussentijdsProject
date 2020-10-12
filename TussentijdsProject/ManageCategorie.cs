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
    public partial class ManageCategorie : Form
    {
        public ManageCategorie()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Categories.Add(new Categorie() { CategorieNaam = txtCategorieNaam.Text });
                ctx.SaveChanges();
            }
            txtCategorieNaam.Clear();
            DisplayCategorieNaam();
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Categories.Where(x => x.CategorieID == (int)lbCategorie.SelectedValue).FirstOrDefault().CategorieNaam = txtCategorieNaam.Text.Trim();
                ctx.SaveChanges();
            }

            DisplayCategorieNaam();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                ctx.Categories.RemoveRange(ctx.Categories.Where(x => x.CategorieID == (int)lbCategorie.SelectedValue));
                ctx.SaveChanges();
            }

            DisplayCategorieNaam();
        }

        private void ManageCategorie_Load(object sender, EventArgs e)
        {
            DisplayCategorieNaam();
        }

        public void DisplayCategorieNaam()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for CategorieNaam
                var categorieNaamLijst = ctx.Categories.Select(x => new
                {
                    Naam = x.CategorieNaam,
                    Id = x.CategorieID
                }).ToList();
                lbCategorie.DisplayMember = "Naam";
                lbCategorie.ValueMember = "Id";
                lbCategorie.DataSource = categorieNaamLijst;
            }
        }
    }
}
