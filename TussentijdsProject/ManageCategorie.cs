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

        public static bool IsNewCategorie = false;
        public static int CategorieId = 0;

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                IsNewCategorie = true;
                SaveCategorie saveCategorie = new SaveCategorie();
                if (saveCategorie.ShowDialog() == DialogResult.OK)
                {
                    DisplayCategorieNaam();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCategorie.SelectedIndex >= 0)
                {
                    IsNewCategorie = false;
                    CategorieId = (int)cbCategorie.SelectedValue;
                    SaveCategorie saveCategorie = new SaveCategorie();
                    if (saveCategorie.ShowDialog() == DialogResult.OK)
                    {
                        DisplayCategorieNaam();
                    }
                }
                else
                {
                    MessageBox.Show("Selecteer een categorie om te bewerken");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCategorie.SelectedIndex >= 0)
                {
                    string categorie = cbCategorie.Text;
                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        ctx.Categories.RemoveRange(ctx.Categories.Where(x => x.CategorieID == (int)cbCategorie.SelectedValue));
                        ctx.SaveChanges();
                    }
                    MessageBox.Show(categorie + " is succesvol verwijderd");
                    DisplayCategorieNaam();
                }
                else
                {
                    MessageBox.Show("Selecteer een categorie om te verwijderen");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageCategorie_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayCategorieNaam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                if (categorieNaamLijst.Count == 0)
                {
                    cbCategorie.Text = "";
                    txtCategorieNaam.Clear();
                }
            }
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCategorie.SelectedIndex >= 0)
                {
                    int categorieId = Convert.ToInt32(cbCategorie.SelectedValue);

                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        var selectedCategorie = ctx.Categories.Where(x => x.CategorieID == categorieId).FirstOrDefault();

                        if (selectedCategorie != null)
                        {
                            txtCategorieNaam.Text = selectedCategorie.CategorieNaam;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
