﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Xceed.Words.NET;
using System.Xml;
using Xceed.Document.NET;
using Microsoft.Office.Interop.Word;

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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            try
            {
                LeverancierProductLijst.Clear();
                lbKaart.DataSource = null;
                CalculateTotaalPrijs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAfrekenen_Click(object sender, EventArgs e)
        {
            try
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
                                ProductID = item.ProductID,
                                Aantal = item.Aantal
                            });
                            ctx.SaveChanges();

                            //Updating Products table
                            ctx.Products.Where(x => x.ProductID == item.ProductID).FirstOrDefault().Aantal += item.Aantal;
                            ctx.SaveChanges();
                        }
                    }

                    PrintToWordDocument();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BestellingLeverancier_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayPersoneelsLid();
                DisplayLeverancies();
                DisplayCategorieNaam();
                cbCategorie.SelectedIndex = -1;
                DisplayProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void PrintToWordDocument()
        {
            Word.Application objWord = new Word.Application();
            objWord.Visible = true;
            objWord.WindowState = Word.WdWindowState.wdWindowStateNormal;

            Word.Document objDoc = objWord.Documents.Add();

            var objPara = objDoc.Paragraphs.Add();
            objPara.Range.Font.Name = "Calibri";
            objPara.Range.Font.Size = 18;
            objPara.Range.Text = "Bestellingen\nDat betaal ik zelf wel.";
            objPara.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.InsertParagraphAfter();

            string leverancierNaam = "";
            int bestellingId = 0;

            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                var leveranciers = ctx.Leveranciers.Where(x => x.LeverancierID == (int)cbLeverancier.SelectedValue).FirstOrDefault();
                var leverancierPara = objDoc.Paragraphs.Add();
                leverancierPara.Range.Font.Name = "Calibri";
                leverancierPara.Range.Font.Size = 12;
                leverancierPara.Range.Text = leveranciers.Contactpersoon + "\n" + leveranciers.Straatnaam + " " + leveranciers.Huisnummer + "Bus " + leveranciers.Bus + "\n" + leveranciers.Postcode + " " + leveranciers.Gemeente;
                leverancierPara.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                leverancierPara.Range.InsertParagraphAfter();

                leverancierNaam = leveranciers.Contactpersoon;

                Word.InlineShape line1 = objDoc.Paragraphs.Last.Range.InlineShapes.AddHorizontalLineStandard();
                line1.Height = 2;
                line1.Fill.Solid();
                line1.HorizontalLineFormat.NoShade = true;
                line1.Fill.ForeColor.RGB = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                line1.HorizontalLineFormat.PercentWidth = 100;
                line1.HorizontalLineFormat.Alignment = WdHorizontalLineAlignment.wdHorizontalLineAlignCenter;

                var tableHeader = objDoc.Paragraphs.Add();
                tableHeader.Range.Font.Name = "Calibri";
                tableHeader.Range.Font.Size = 12;
                tableHeader.Range.Text = "Artikel\t\t\t\t Aantal\tPrijs per stuk\tBTW   Prijs excl. BTW\tPrijs incl. BTW";
                tableHeader.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tableHeader.Range.InsertParagraphAfter();

                Word.InlineShape line2 = objDoc.Paragraphs.Last.Range.InlineShapes.AddHorizontalLineStandard();
                line2.Height = 2;
                line2.Fill.Solid();
                line2.HorizontalLineFormat.NoShade = true;
                line2.Fill.ForeColor.RGB = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                line2.HorizontalLineFormat.PercentWidth = 100;
                line2.HorizontalLineFormat.Alignment = WdHorizontalLineAlignment.wdHorizontalLineAlignCenter;

                var leverancierBestelling = ctx.Bestellings.Where(b => b.LeverancierID != null);
                bestellingId = leverancierBestelling.Max(x => x.BestellingID);

                var bestelling = ctx.BestellingProducts.Where(x => x.BestellingID == bestellingId).ToList();

                var tablePara = objDoc.Paragraphs.Add();
                tablePara.Range.Font.Name = "Calibri";
                tablePara.Range.Font.Size = 12;

                string tableContent = "";
                decimal totaal = 0;

                foreach (BestellingProduct item in bestelling)
                {
                    var product = ctx.Products.Where(p => p.ProductID == item.ProductID).FirstOrDefault();
                    string productNaam = "";
                    if (product.Naam.Trim().Length <= 7)
                    {
                        productNaam = product.Naam + "\t\t\t\t";
                    }
                    else if (product.Naam.Trim().Length > 7 && product.Naam.Trim().Length < 14)
                    {
                        productNaam = product.Naam + "\t\t\t";
                    }

                    decimal actualPrijs = Convert.ToDecimal(product.Inkoopprijs) + Convert.ToDecimal(product.Marge);
                    decimal prijsInclBtw = Convert.ToDecimal(item.Aantal) * actualPrijs;
                    decimal prijsExclBtw = Math.Round(prijsInclBtw - (prijsInclBtw * (Convert.ToDecimal(product.BTW) / 100)), 2);
                    string prijsExclBtwValue = prijsExclBtw.ToString() + "\t";
                    totaal += prijsInclBtw;

                    string prijsPerStuckValue = actualPrijs.ToString();
                    if (prijsPerStuckValue.Trim().Length > 3)
                    {
                        prijsPerStuckValue += "\t";
                    }
                    else
                    {
                        prijsPerStuckValue += "\t\t";
                    }

                    tableContent += productNaam + "   " + item.Aantal + "\t  €" + prijsPerStuckValue + product.BTW + "\t€" + prijsExclBtwValue + "€" + prijsInclBtw + "\n";
                }
                tablePara.Range.Text = tableContent;

                tablePara.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tablePara.Range.InsertParagraphAfter();

                Word.InlineShape line3 = objDoc.Paragraphs.Last.Range.InlineShapes.AddHorizontalLineStandard();
                line3.Height = 2;
                line3.Fill.Solid();
                line3.HorizontalLineFormat.NoShade = true;
                line3.Fill.ForeColor.RGB = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                line3.HorizontalLineFormat.PercentWidth = 100;
                line3.HorizontalLineFormat.Alignment = WdHorizontalLineAlignment.wdHorizontalLineAlignCenter;


                var footerPara = objDoc.Paragraphs.Add();
                footerPara.Range.Font.Name = "Calibri";
                footerPara.Range.Font.Size = 12;
                footerPara.Range.Text = "Totaal\t    €" + totaal + "\t\t";
                footerPara.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                footerPara.Range.InsertParagraphAfter();

                string filePath = "C:\\Users\\Krëfel\\source\\repos\\TussentijdsProject\\TussentijdsProject\\bin\\Debug\\";
                string fileName = filePath + leverancierNaam + " " + DateTime.Now.ToString("dd-MM-yyyy") + " " + "(" + bestellingId.ToString() + ")" + ".docx";
                objDoc.SaveAs2(fileName);
                objDoc.Close();
                objWord.Quit();
            }
        }
    }
}
