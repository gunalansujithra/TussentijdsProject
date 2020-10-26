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
    public partial class ManageStocks : Form
    {
        public ManageStocks()
        {
            InitializeComponent();
        }

        private void ManageStocks_Load(object sender, EventArgs e)
        {
            DisplayRange();
            DisplayCategorieNaam();
            cbCategorie.SelectedIndex = -1;
            DisplayProduct();
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProductResults();
        }

        private void cbKlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProductResults();
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

        public void FilterProductResults()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Product
                if (cbRange.SelectedIndex >= 0)
                {
                    var productLijst = ctx.Products.Select(x => new
                    {
                        Naam = x.Naam + " (In Stock: " + x.Aantal + ")",
                        Id = x.ProductID,
                        Aantal = x.Aantal,
                        CategorieID = x.CategorieID
                    }).ToList();

                    //var selectedProduct = new List<Product>;

                    switch (cbRange.SelectedItem.ToString())
                    {
                        case "Minder dan 10":
                            productLijst = productLijst.Where(x => x.Aantal <= 10).ToList();
                            break;

                        case "Tussen 11 tot 50":
                            productLijst = productLijst.Where(x => x.Aantal > 10 && x.Aantal <= 50).ToList();
                            break;

                        case "Tussen 51 tot 100":
                            productLijst = productLijst.Where(x => x.Aantal > 50 && x.Aantal <= 100).ToList();
                            break;

                        case "Tussen 101 tot 500":
                            productLijst = productLijst.Where(x => x.Aantal > 100 && x.Aantal <= 500).ToList();
                            break;

                        case "Tussen 501 tot 1000":
                            productLijst = productLijst.Where(x => x.Aantal > 500 && x.Aantal <= 1000).ToList();
                            break;

                        case "Meer dan 1000":
                            productLijst = productLijst.Where(x => x.Aantal > 1000).ToList();
                            break;

                        default:
                            productLijst = productLijst.ToList();
                            break;

                    }

                    if (cbCategorie.SelectedIndex >= 0)
                    {
                        productLijst = productLijst.Where(x => x.CategorieID == (int)cbCategorie.SelectedValue).ToList();
                    }
                    lbProduct.DisplayMember = "Naam";
                    lbProduct.ValueMember = "Id";
                    lbProduct.DataSource = productLijst;
                }
            }
        }

        public void DisplayProduct()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Product
                var productLijst = ctx.Products.Select(x => new
                {
                    Naam = x.Naam + " (In Stock: " + x.Aantal + ")",
                    Id = x.ProductID
                }).ToList();
                lbProduct.DisplayMember = "Naam";
                lbProduct.ValueMember = "Id";
                lbProduct.DataSource = productLijst;
            }
        }

        public void DisplayRange()
        {
            cbRange.Items.Clear();
            cbRange.Items.Add("Minder dan 10");
            cbRange.Items.Add("Tussen 11 tot 50");
            cbRange.Items.Add("Tussen 51 tot 100");
            cbRange.Items.Add("Tussen 101 tot 500");
            cbRange.Items.Add("Tussen 501 tot 1000");
            cbRange.Items.Add("Meer dan 1000");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbRange.SelectedIndex = -1;
            DisplayRange();
            DisplayCategorieNaam();
            cbCategorie.SelectedIndex = -1;           
            DisplayProduct();
        }
    }
}
