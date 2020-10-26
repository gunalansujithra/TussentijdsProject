using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace TussentijdsProject
{
    public partial class BestellingLeverancier : Form
    {
        public BestellingLeverancier()
        {
            InitializeComponent();
        }

        public List<Product> LeverancierProductLijst = new List<Product>();

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Product
                if (cbCategorie.SelectedIndex >= 0)
                {
                    var productLijst = ctx.Products.Select(x => new
                    {
                        Naam = x.Naam + " (Prijs: " + (x.Inkoopprijs + x.Marge) + ")",
                        Id = x.ProductID,
                        CategorieID = x.CategorieID
                    }).Where(p => p.CategorieID == (int)cbCategorie.SelectedValue).ToList();
                    lbProduct.DisplayMember = "Naam";
                    lbProduct.ValueMember = "Id";
                    lbProduct.DataSource = productLijst;
                }
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (cbPersoneelsLid.SelectedIndex >= 0 && cbLeverancier.SelectedIndex >= 0 //&& cbCategorie.SelectedIndex >= 0
                        && lbProduct.SelectedItems.Count > 0 && txtUnits.Text.Trim().Length > 0)
            {
                int productId = Convert.ToInt32(lbProduct.SelectedValue);

                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    var selectedProduct = ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault();
                    int units = Convert.ToInt32(txtUnits.Text.Trim());
                    decimal productPrijs = Convert.ToDecimal(selectedProduct.Inkoopprijs) + Convert.ToDecimal(selectedProduct.Marge);
                    Product product = new Product()
                    {
                        ProductID = selectedProduct.ProductID,
                        Naam = selectedProduct.Naam + " (Prijs: " + productPrijs + ")",
                        Inkoopprijs = selectedProduct.Inkoopprijs,
                        Marge = selectedProduct.Marge,
                        Aantal = Convert.ToInt32(txtUnits.Text),
                        Eenheid = selectedProduct.Eenheid,
                        BTW = selectedProduct.BTW,
                        LeverancierID = selectedProduct.LeverancierID,
                        CategorieID = selectedProduct.CategorieID
                    };

                    LeverancierProductLijst.Add(product);
                }

                lbKaart.DataSource = null;
                lbKaart.DisplayMember = "Naam";
                lbKaart.ValueMember = "ProductID";
                lbKaart.DataSource = LeverancierProductLijst;

                CalculateTotaalPrijs();
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (lbKaart.SelectedItems.Count > 0)
            {
                string product = lbKaart.Text;
                int index = lbKaart.SelectedIndex;
                LeverancierProductLijst.RemoveAt(index);

                MessageBox.Show(product + " is verwijderd uit de winkelmandje");

                lbKaart.DataSource = null;
                lbKaart.DisplayMember = "Naam";
                lbKaart.ValueMember = "ProductID";
                lbKaart.DataSource = LeverancierProductLijst;
                CalculateTotaalPrijs();
            }
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            LeverancierProductLijst.Clear();
            lbKaart.DataSource = null;
            CalculateTotaalPrijs();
        }

        private void btnAfrekenen_Click(object sender, EventArgs e)
        {
            if (LeverancierProductLijst.Count > 0)
            {
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    //Inserting rows into Bestellings table
                    ctx.Bestellings.Add(new Bestelling()
                    {
                        DatumOpgemaakt = DateTime.Now,
                        PersoneelslidID = Convert.ToInt32(cbPersoneelsLid.SelectedValue),
                        LeverancierID = Convert.ToInt32(cbLeverancier.SelectedValue)
                    });
                    ctx.SaveChanges();

                    int bestellingId = ctx.Bestellings.Max(x => x.BestellingID);
                    foreach (var item in LeverancierProductLijst)
                    {
                        //Inserting rows into BestellingProducts table
                        ctx.BestellingProducts.Add(new BestellingProduct()
                        {
                            BestellingID = bestellingId,
                            ProductID = item.ProductID
                        });
                        ctx.SaveChanges();

                        //Updating Products table
                        ctx.Products.Where(x => x.ProductID == item.ProductID).FirstOrDefault().Aantal += item.Aantal;
                        ctx.SaveChanges();
                    }
                }
                MessageBox.Show("Uw bestelling is succesvol afrekend");

                cbPersoneelsLid.SelectedIndex = -1;
                cbLeverancier.SelectedIndex = -1;
                cbCategorie.SelectedIndex = -1;
                LeverancierProductLijst.Clear();
                lbKaart.DataSource = null;
                txtUnits.Clear();
                txtTotaalPrijs.Clear();
                DisplayProduct();
            }
            else
            {
                MessageBox.Show("Winkelmandje is leeg.");
            }
        }

        private void BestellingLeverancier_Load(object sender, EventArgs e)
        {
            DisplayPersoneelsLid();
            DisplayLeverancies();
            DisplayCategorieNaam();
            cbCategorie.SelectedIndex = -1;
            DisplayProduct();
        }

        public void DisplayErrorMessage()
        {
            string errorMessage = "";

            if (cbPersoneelsLid.SelectedIndex < 0)
            {
                epPersoneelLids.SetError(cbPersoneelsLid, "PersoneelLids is niet geselecteerd");
                errorMessage += "\r\n" + "PersoneelLids is niet geselecteerd";
            }
            else
            {
                epPersoneelLids.Clear();
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

            if (lbProduct.SelectedItems.Count <= 0)
            {
                epProduct.SetError(lbProduct, "Product is niet geselecteerd");
                errorMessage += "\r\n" + "Product is niet geselecteerd";
            }
            else
            {
                epProduct.Clear();
            }

            if (txtUnits.Text.Trim().Length == 0)
            {
                epUnits.SetError(txtUnits, "Units is niet ingevuld");
                errorMessage += "\r\n" + "Units is niet ingevuld";
            }
            else
            {
                epUnits.Clear();
            }

            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
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
                cbPersoneelsLid.DisplayMember = "Naam";
                cbPersoneelsLid.ValueMember = "Id";
                cbPersoneelsLid.DataSource = personeelsLidLijst;
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

        public void DisplayProduct()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Product
                var productLijst = ctx.Products.Select(x => new
                {
                    Naam = x.Naam + " (Prijs: " + (x.Inkoopprijs + x.Marge) + ")",
                    Id = x.ProductID
                }).ToList();
                lbProduct.DisplayMember = "Naam";
                lbProduct.ValueMember = "Id";
                lbProduct.DataSource = productLijst;
            }
        }
        public void CalculateTotaalPrijs()
        {
            decimal totaal = 0;
            if (LeverancierProductLijst.Count > 0)
            {
                foreach (var item in LeverancierProductLijst)
                {
                    decimal prijs = Convert.ToDecimal(item.Inkoopprijs) + Convert.ToDecimal(item.Marge);
                    totaal += prijs * Convert.ToInt32(item.Aantal);
                }
            }
            txtTotaalPrijs.Text = totaal.ToString();
        }

        
    }
}
