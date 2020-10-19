using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TussentijdsProject
{
    public partial class SaveProduct : Form
    {
        public SaveProduct()
        {
            InitializeComponent();
        }

        private void SaveProduct_Load(object sender, EventArgs e)
        {
            DisplayCategorie();
            DisplayLeverancies();

            if (ManageProduct.IsNewProduct)
            {
                txtNaam.Clear();
                txtInkoopprijs.Clear();
                txtMarge.Clear();
                txtEenheid.Clear();
                txtBtw.Clear();
                cbLeverancier.SelectedIndex = -1;
                cbCategorie.SelectedIndex = -1;
            }
            else
            {
                int productId = ManageProduct.ProductId;

                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    var selectedProduct = ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault();

                    if (selectedProduct != null)
                    {
                        txtNaam.Text = selectedProduct.Naam;
                        txtInkoopprijs.Text = selectedProduct.Inkoopprijs.ToString();
                        txtMarge.Text = selectedProduct.Marge.ToString();
                        txtEenheid.Text = selectedProduct.Eenheid.ToString();
                        txtBtw.Text = selectedProduct.BTW.ToString();
                        cbLeverancier.SelectedValue = selectedProduct.LeverancierID;
                        cbCategorie.SelectedValue = selectedProduct.CategorieID;
                    }
                }
            }
        }

        public void DisplayCategorie()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Categorie
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
            }
        }

        public void DisplayErrorMessage()
        {
            string errorMessage = "";
            if (txtNaam.Text.Trim().Length == 0)
            {
                epNaam.SetError(txtNaam, "Naam is niet ingevuld");
                errorMessage += "\r\n" + "Naam is niet ingevuld";
            }
            else
            {
                epNaam.Clear();
            }
            
            if (txtInkoopprijs.Text.Trim().Length == 0)
            {
                epInkoopPrijs.SetError(txtInkoopprijs, "Inkoopprijs is niet ingevuld");
                errorMessage += "\r\n" + "Inkoopprijs is niet ingevuld";
            }
            else
            {
                epInkoopPrijs.Clear();
            }

            if (txtMarge.Text.Trim().Length == 0)
            {
                epMarge.SetError(txtMarge, "Marge is niet ingevuld");
                errorMessage += "\r\n" + "Marge is niet ingevuld";
            }
            else
            {
                epMarge.Clear();
            }

            if (txtEenheid.Text.Trim().Length == 0)
            {
                epEenheid.SetError(txtEenheid, "Eenheid is niet ingevuld");
                errorMessage += "\r\n" + "Eenheid is niet ingevuld";
            }
            else
            {
                epEenheid.Clear();
            }

            if (txtBtw.Text.Trim().Length == 0)
            {
                epBtw.SetError(txtBtw, "BTW is niet ingevuld");
                errorMessage += "\r\n" + "BTW is niet ingevuld";
            }
            else
            {
                epBtw.Clear();
            }

            if (cbLeverancier.SelectedIndex < 0)
            {
                epLeverancier.SetError(cbLeverancier, "Leverancier is niet geselecteerd");
                errorMessage += "\r\n" + "Leverancier is niet geselecteerd";
            }
            else
            {
                epLeverancier.Clear();
            }

            if (cbCategorie.SelectedIndex < 0)
            {
                epCategorie.SetError(cbCategorie, "Categorie is niet geselecteerd");
                errorMessage += "\r\n" + "Categorie is niet geselecteerd";
            }
            else
            {
                epCategorie.Clear();
            }

            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (ManageProduct.IsNewProduct)
            {
                DisplayErrorMessage();

                if (txtNaam.Text.Trim().Length > 0 && txtInkoopprijs.Text.Trim().Length > 0 && txtMarge.Text.Trim().Length > 0
                        && txtEenheid.Text.Trim().Length > 0 && txtBtw.Text.Trim().Length > 0 && cbLeverancier.SelectedIndex >= 0
                        && cbCategorie.SelectedIndex >= 0)
                {
                    string product = txtNaam.Text;
                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        ctx.Products.Add(new Product()
                        {
                            Naam = txtNaam.Text.Trim(),
                            Inkoopprijs = Convert.ToDecimal(txtInkoopprijs.Text.Trim()),
                            Marge = Convert.ToDecimal(txtMarge.Text.Trim()),
                            Eenheid = Convert.ToInt32(txtEenheid.Text.Trim()),
                            BTW = Convert.ToInt32(txtBtw.Text.Trim()),
                            LeverancierID = (int)cbLeverancier.SelectedValue,
                            CategorieID = (int)cbCategorie.SelectedValue
                        });
                        ctx.SaveChanges();
                    }
                    MessageBox.Show(product + " is succesvol toegevoegd");
                    txtNaam.Clear();
                    txtInkoopprijs.Clear();
                    txtMarge.Clear();
                    txtEenheid.Clear();
                    txtBtw.Clear();
                    cbLeverancier.SelectedIndex = -1;
                    cbCategorie.SelectedIndex = -1;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                DisplayErrorMessage();

                int productId = ManageProduct.ProductId;
                if (txtNaam.Text.Trim().Length > 0 && txtInkoopprijs.Text.Trim().Length > 0 && txtMarge.Text.Trim().Length > 0
                        && txtEenheid.Text.Trim().Length > 0 && txtBtw.Text.Trim().Length > 0 && cbLeverancier.SelectedIndex >= 0
                        && cbCategorie.SelectedIndex >= 0)
                {
                    string product = txtNaam.Text;
                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().Naam = txtNaam.Text.Trim();
                        ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().Inkoopprijs = Convert.ToDecimal(txtInkoopprijs.Text.Trim());
                        ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().Marge = Convert.ToDecimal(txtMarge.Text.Trim());
                        ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().Eenheid = Convert.ToInt32(txtEenheid.Text.Trim());
                        ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().BTW = Convert.ToInt32(txtBtw.Text.Trim());
                        ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().LeverancierID = (int)cbLeverancier.SelectedValue;
                        ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().CategorieID = (int)cbCategorie.SelectedValue;
                        ctx.SaveChanges();
                    }
                    MessageBox.Show(product + " is succesvol bijgewerkt");
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
