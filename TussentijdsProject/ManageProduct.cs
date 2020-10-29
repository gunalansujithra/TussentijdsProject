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
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        public static bool IsNewProduct = false;

        public static int ProductId = 0;

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayProduct()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Product
                var productLijst = ctx.Products.Select(x => new
                {
                    Naam = x.Naam,
                    Id = x.ProductID
                }).ToList();
                cbProduct.DisplayMember = "Naam";
                cbProduct.ValueMember = "Id";
                cbProduct.DataSource = productLijst;
                if (productLijst.Count == 0)
                {
                    cbProduct.Text = "";
                    txtNaam.Text = "";
                    txtInkoopprijs.Text = "";
                    txtMarge.Text = "";
                    txtAantal.Text = "";
                    txtEenheid.Text = "";
                    txtBtw.Text = "";
                    txtLeverancier.Text = "";
                    txtCategorie.Text = "";
                }
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                IsNewProduct = true;
                SaveProduct saveProduct = new SaveProduct();
                if (saveProduct.ShowDialog() == DialogResult.OK)
                {
                    DisplayProduct();
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
                if (cbProduct.SelectedIndex >= 0)
                {
                    IsNewProduct = false;
                    ProductId = (int)cbProduct.SelectedValue;
                    SaveProduct saveProduct = new SaveProduct();
                    if (saveProduct.ShowDialog() == DialogResult.OK)
                    {
                        DisplayProduct();
                    }
                }
                else
                {
                    MessageBox.Show("Selecteer een product om te bewerken");
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
                if (cbProduct.SelectedIndex >= 0)
                {
                    string product = cbProduct.Text;
                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        ctx.Products.RemoveRange(ctx.Products.Where(x => x.ProductID == (int)cbProduct.SelectedValue));
                        ctx.SaveChanges();
                    }
                    MessageBox.Show(product + " is succesvol verwijderd");
                    DisplayProduct();
                }
                else
                {
                    MessageBox.Show("Selecteer een product om te verwijderen");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbProduct.SelectedIndex >= 0)
                {
                    int productId = Convert.ToInt32(cbProduct.SelectedValue);

                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        var selectedProduct = ctx.Products
                                                    .Join(ctx.Leveranciers,
                                                    p => p.LeverancierID,
                                                    l => l.LeverancierID,
                                                    (p, l) => new { p, l })

                                                    .Join(ctx.Categories,
                                                    p1 => p1.p.CategorieID,
                                                    c => c.CategorieID,
                                                    (p1, c) => new { p1, c }).Where(x => x.p1.p.ProductID == productId).FirstOrDefault();

                        if (selectedProduct != null)
                        {
                            txtNaam.Text = selectedProduct.p1.p.Naam;
                            txtInkoopprijs.Text = selectedProduct.p1.p.Inkoopprijs.ToString();
                            txtMarge.Text = selectedProduct.p1.p.Marge.ToString();
                            txtAantal.Text = selectedProduct.p1.p.Aantal.ToString();
                            txtEenheid.Text = selectedProduct.p1.p.Eenheid;
                            txtBtw.Text = selectedProduct.p1.p.BTW.ToString();
                            txtLeverancier.Text = selectedProduct.p1.l.Contactpersoon;
                            txtCategorie.Text = selectedProduct.c.CategorieNaam;
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
