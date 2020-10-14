using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TussentijdsProject
{
    public partial class UCCategorie : UserControl
    {
        public UCCategorie()
        {
            InitializeComponent();
        }

        private void UCCategorie_Load(object sender, EventArgs e)
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
                cbCategorie.DisplayMember = "Naam";
                cbCategorie.ValueMember = "Id";
                cbCategorie.DataSource = categorieNaamLijst;
            }
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayCategorieDetails();
        }

        public void DisplayCategorieDetails()
        {
            if (cbCategorie.SelectedIndex >= 0)
            {
                int categorieId = Convert.ToInt32(cbCategorie.SelectedValue);

                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    var selectedCategorie = ctx.Categories.Where(x => x.CategorieID == categorieId).FirstOrDefault();

                    if (selectedCategorie != null)
                    {
                        txtCategorie.Text = selectedCategorie.CategorieNaam;
                    }
                }
            }
        }
    }
}
