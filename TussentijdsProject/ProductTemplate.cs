using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace TussentijdsProject
{
    public partial class ProductTemplate : Form
    {
        public ProductTemplate()
        {
            InitializeComponent();
        }

        List<string> ProductDetails = new List<string>();

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("ExistingProductTemplate.txt"))
                {
                    var fileStream = File.Create("ExistingProductTemplate.txt");
                    fileStream.Close();
                }

                using (StreamReader reader = new StreamReader("ExistingProductTemplate.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        ProductDetails.Add(reader.ReadLine());
                    }
                    reader.Close();
                }

                string productNaam = "";
                decimal inkoopPrijs = 0;
                decimal marge = 0;
                int eenheid = 0;
                int btw = 0;
                int leverancierId = 0;
                int categorieId = 0;

                foreach (var item in ProductDetails)
                {
                    string[] columnName = item.Split(':');

                    if (columnName[1].Trim().Length > 0)
                    {

                        switch (columnName[0].ToLower())
                        {
                            case "product":
                                productNaam = columnName[1];
                                break;

                            case "inkoopprijs":
                                inkoopPrijs = Convert.ToDecimal(columnName[1]);
                                break;

                            case "marge":
                                marge = Convert.ToDecimal(columnName[1]);
                                break;

                            case "eenheid":
                                eenheid = Convert.ToInt32(columnName[1]);
                                break;

                            case "btw":
                                btw = Convert.ToInt32(columnName[1]);
                                break;

                            case "leverancier":
                                leverancierId = Convert.ToInt32(columnName[1]);
                                break;

                            case "categorie":
                                categorieId = Convert.ToInt32(columnName[1]);
                                break;
                        }
                    }
                }

                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    var inputProduct = ctx.Products.Where(x => x.Naam.ToLower() == productNaam.ToLower()).FirstOrDefault();
                    int productId = inputProduct.ProductID;
                    if (productId > 0)
                    {
                        if (inkoopPrijs > 0)
                            ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().Inkoopprijs = inkoopPrijs;
                        if (marge > 0)
                            ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().Marge = marge;
                        if (eenheid > 0)
                            ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().Eenheid += eenheid;
                        if (btw > 0)
                            ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault().BTW = btw;

                        ctx.SaveChanges();
                        MessageBox.Show("Product template is succesvol ingeroepen");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductTemplate_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("ExistingProductTemplate.txt"))
                {
                    var fileStream = File.Create("ExistingProductTemplate.txt");
                    fileStream.Close();
                }

                using (StreamReader reader = new StreamReader("ExistingProductTemplate.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        ProductDetails.Add(reader.ReadLine());
                    }
                    reader.Close();
                }


                foreach (var item in ProductDetails)
                {
                    string[] columnName = item.Split(':');

                    if (columnName[1].Trim().Length > 0)
                    {

                        switch (columnName[0].ToLower())
                        {
                            case "product":
                                txtNaam.Text = columnName[1];
                                break;

                            case "inkoopprijs":
                                txtInkoopprijs.Text = columnName[1];
                                break;

                            case "marge":
                                txtMarge.Text = columnName[1];
                                break;

                            case "eenheid":
                                txtEenheid.Text = columnName[1];
                                break;

                            case "btw":
                                txtBtw.Text = columnName[1];
                                break;

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
