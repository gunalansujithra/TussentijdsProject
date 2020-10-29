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
    public partial class SaveCategorie : Form
    {
        public SaveCategorie()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManageCategorie.IsNewCategorie)
                {
                    DisplayErrorMessage();

                    if (txtCategorieNaam.Text.Trim().Length > 0)
                    {
                        string categorie = txtCategorieNaam.Text;
                        using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                        {
                            ctx.Categories.Add(new Categorie() { CategorieNaam = txtCategorieNaam.Text });
                            ctx.SaveChanges();
                        }
                        MessageBox.Show(categorie + " is succesvol toegevoegd");
                        txtCategorieNaam.Clear();
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    DisplayErrorMessage();

                    if (txtCategorieNaam.Text.Trim().Length > 0)
                    {
                        string categorie = txtCategorieNaam.Text;
                        using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                        {
                            ctx.Categories.Where(x => x.CategorieID == ManageCategorie.CategorieId).FirstOrDefault().CategorieNaam = txtCategorieNaam.Text.Trim();
                            ctx.SaveChanges();
                        }
                        MessageBox.Show(categorie + " is succesvol bijgewerkt");
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

        public void DisplayErrorMessage()
        {
            string errorMessage = "";
            if (txtCategorieNaam.Text.Trim().Length == 0)
            {
                epNaam.SetError(txtCategorieNaam, "Categorie naam is niet ingevuld");
                errorMessage += "\r\n" + "Categorie naam is niet ingevuld";
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

        private void SaveCategorie_Load(object sender, EventArgs e)
        {
            try
            {
                if (ManageCategorie.IsNewCategorie)
                {
                    txtCategorieNaam.Clear();
                }
                else
                {
                    int categorieId = ManageCategorie.CategorieId;

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
