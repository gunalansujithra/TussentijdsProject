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
    public partial class BestellingKlant : Form
    {
        public BestellingKlant()
        {
            InitializeComponent();
        }

        private void BestellingKlant_Load(object sender, EventArgs e)
        {
            DisplayPersoneelsLid();
            DisplayKlants();
            DisplayCategorieNaam();
            cbCategorie.SelectedIndex = -1;
            DisplayProduct();
        }

        public List<Product> KlantProductLijst = new List<Product>();

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

        public void DisplayKlants()
        {
            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                //code for Klant
                var klantsLijst = ctx.Klants.Select(x => new
                {
                    Naam = x.Voornaam + " " + x.Achternaam,
                    Id = x.KlantID
                }).ToList();
                cbKlant.DisplayMember = "Naam";
                cbKlant.ValueMember = "Id";
                cbKlant.DataSource = klantsLijst;
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

        private void btnWissen_Click(object sender, EventArgs e)
        {
            KlantProductLijst.Clear();
            lbKaart.DataSource = null;
            CalculateTotaalPrijs();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            DisplayErrorMessage();

            if (cbPersoneelsLid.SelectedIndex >= 0 && cbKlant.SelectedIndex >= 0 //&& cbCategorie.SelectedIndex >= 0
                        && lbProduct.SelectedItems.Count > 0 && txtUnits.Text.Trim().Length > 0)
            {
                int productId = Convert.ToInt32(lbProduct.SelectedValue);

                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    var selectedProduct = ctx.Products.Where(x => x.ProductID == productId).FirstOrDefault();
                    int units = Convert.ToInt32(txtUnits.Text.Trim());

                    if (units <= selectedProduct.Eenheid)
                    {
                        decimal productPrijs = Convert.ToDecimal(selectedProduct.Inkoopprijs) + Convert.ToDecimal(selectedProduct.Marge);
                        Product product = new Product()
                        {
                            ProductID = selectedProduct.ProductID,
                            Naam = selectedProduct.Naam + " (Prijs: " + productPrijs + ")",
                            Inkoopprijs = selectedProduct.Inkoopprijs,
                            Marge = selectedProduct.Marge,
                            Eenheid = Convert.ToInt32(txtUnits.Text),
                            BTW = selectedProduct.BTW,
                            LeverancierID = selectedProduct.LeverancierID,
                            CategorieID = selectedProduct.CategorieID
                        };

                        KlantProductLijst.Add(product);
                    }
                    else
                    {
                        MessageBox.Show("De beschikbare voorraad is " + selectedProduct.Eenheid + ", Geef een getal kleiner dan of gelijk aan de beschikbaarheid");
                    }
                }

                lbKaart.DataSource = null;
                lbKaart.DisplayMember = "Naam";
                lbKaart.ValueMember = "ProductID";
                lbKaart.DataSource = KlantProductLijst;

                CalculateTotaalPrijs();
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

            if (cbKlant.SelectedIndex < 0)
            {
                epKlant.SetError(cbKlant, "Klant is niet geselecteerd");
                errorMessage += "\r\n" + "Klant is niet geselecteerd";
            }
            else
            {
                epKlant.Clear();
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

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (lbKaart.SelectedItems.Count > 0)
            {
                string product = lbKaart.Text;
                int index = lbKaart.SelectedIndex;
                KlantProductLijst.RemoveAt(index);

                MessageBox.Show(product + " is verwijderd uit de winkelmandje");

                lbKaart.DataSource = null;
                lbKaart.DisplayMember = "Naam";
                lbKaart.ValueMember = "ProductID";
                lbKaart.DataSource = KlantProductLijst;
                CalculateTotaalPrijs();
            }
        }

        private void btnAfrekenen_Click(object sender, EventArgs e)
        {
            if (KlantProductLijst.Count > 0)
            {
                using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                {
                    //Inserting rows into Bestellings table
                    ctx.Bestellings.Add(new Bestelling()
                    {
                        DatumOpgemaakt = DateTime.Now,
                        PersoneelslidID = Convert.ToInt32(cbPersoneelsLid.SelectedValue),
                        KlantID = Convert.ToInt32(cbKlant.SelectedValue)
                    });
                    ctx.SaveChanges();

                    
                    int bestellingId = ctx.Bestellings.Max(x => x.BestellingID);
                    foreach (var item in KlantProductLijst)
                    {
                        //Inserting rows into BestellingProducts table
                        ctx.BestellingProducts.Add(new BestellingProduct()
                        {
                            BestellingID = bestellingId,
                            ProductID = item.ProductID
                        });
                        ctx.SaveChanges();

                        //Updating Products table
                        ctx.Products.Where(x => x.ProductID == item.ProductID).FirstOrDefault().Eenheid -= item.Eenheid;
                        ctx.SaveChanges();
                    }
                }                
                MessageBox.Show("Uw bestelling is succesvol afrekend");

                //cbPersoneelsLid.SelectedIndex = -1;
                //cbKlant.SelectedIndex = -1;
                //cbCategorie.SelectedIndex = -1;
                //KlantProductLijst.Clear();
                //lbKaart.DataSource = null;
                //txtUnits.Clear();
                //txtTotaalPrijs.Clear();
                //DisplayProduct();
            }
            else
            {
                MessageBox.Show("Winkelmandje is leeg.");
            }
        }

        public void CalculateTotaalPrijs()
        {
            decimal totaal = 0;
            if (KlantProductLijst.Count > 0)
            {                
                foreach (var item in KlantProductLijst)
                {
                    decimal prijs = Convert.ToDecimal(item.Inkoopprijs) + Convert.ToDecimal(item.Marge);
                    totaal += prijs * Convert.ToInt32(item.Eenheid);
                }                
            }
            txtTotaalPrijs.Text = totaal.ToString();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Word.Application objWord = new Word.Application();
            objWord.Visible = true;
            objWord.WindowState = Word.WdWindowState.wdWindowStateNormal;

            Word.Document objDoc = objWord.Documents.Add();

            Word.Paragraph objPara;
            objPara = objDoc.Paragraphs.Add();
            objPara.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            objPara.Range.Text = "Bestellingen\nDat betaal ik zelf wel.";

            using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
            {
                var klant = ctx.Klants.Where(x => x.KlantID == (int)cbKlant.SelectedValue).FirstOrDefault();
                Word.Paragraph klantPara;
                klantPara = objDoc.Paragraphs.Add();
                klantPara.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                klantPara.Format.LineSpacing = 1;


                klantPara.Range.Text = klant.Voornaam + " " + klant.Achternaam + "\n" + klant.Straatnaam + " " + klant.Huisnummer
                                        + "Bus " + klant.Bus + "\n" + klant.Postcode + " " + klant.Gemeente;


                Word.Paragraph headerPara;
                headerPara = objDoc.Paragraphs.Add();
                headerPara.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                headerPara.Format.LineSpacing = 1;

                headerPara.Range.Text = "Artikel\t\t\t\t Aantal\tPrij per stuk\tBTW\tPrijs incl. BTW";

                //object oEndOfDoc = "\\endofdoc";
                //Word.Table klantTable;
                //Word.Range wrdRng = objDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                //object oMissing = System.Reflection.Missing.Value;
                //klantTable = objDoc.Tables.Add(wrdRng, 2, 5, ref oMissing, ref oMissing);

                //klantTable.Rows[0].Cells[0]

                //SendMessage("Opening Word");

                //Word.Application word = null;



                //Word.Document doc = null;
                //object oMissing = System.Reflection.Missing.Value;
                //object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
                //try
                //{
                //    word = new word.ApplicationClass();
                //    word.Visible = true;
                //    doc = word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                //}
                //catch (Exception ex)
                //{
                //    ErrorLog(ex);
                //}
                //finally
                //{
                //}
                //if (word != null && doc != null)
                //{
                //    word.Table newTable;
                //    word.Range wrdRng = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                //    newTable = doc.Tables.Add(wrdRng, 1, dgv.Columns.Count - 1, ref oMissing, ref oMissing);
                //    newTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                //    newTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                //    newTable.AllowAutoFit = true;

                //    foreach (DataGridViewCell cell in dgv.Rows[0].Cells)
                //    {
                //        newTable.Cell(newTable.Rows.Count, cell.ColumnIndex).Range.Text = dgv.Columns[cell.ColumnIndex].Name;

                //    }
                //    newTable.Rows.Add();

                //    foreach (DataGridViewRow row in dgv.Rows)
                //    {
                //        foreach (DataGridViewCell cell in row.Cells)
                //        {
                //            newTable.Cell(newTable.Rows.Count, cell.ColumnIndex).Range.Text = cell.Value.ToString();
                //        }
                //        newTable.Rows.Add();
                //    }
                //}


                //Word.Table producttable;
                //producttable = objDoc.Tables.Add(producttable, 2, 5, )
                //producttable.Rows[0].c
                //int bestellingId = ctx.Bestellings.Max(x => x.BestellingID);
                //foreach (var item in KlantProductLijst)
                //{
                //    //Inserting rows into BestellingProducts table
                //    ctx.BestellingProducts.Add(new BestellingProduct()
                //    {
                //        BestellingID = bestellingId,
                //        ProductID = item.ProductID
                //    });
                //    ctx.SaveChanges();
                //}


                //using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                //{
                //    //Inserting rows into Bestellings table
                //    ctx.Bestellings.Add(new Bestelling()
                //    {
                //        DatumOpgemaakt = DateTime.Now,
                //        PersoneelslidID = Convert.ToInt32(cbPersoneelsLid.SelectedValue),
                //        KlantID = Convert.ToInt32(cbKlant.SelectedValue)
                //    });
                //    ctx.SaveChanges();


                //    int bestellingId = ctx.Bestellings.Max(x => x.BestellingID);
                //    foreach (var item in KlantProductLijst)
                //    {
                //        //Inserting rows into BestellingProducts table
                //        ctx.BestellingProducts.Add(new BestellingProduct()
                //        {
                //            BestellingID = bestellingId,
                //            ProductID = item.ProductID
                //        });
                //        ctx.SaveChanges();

                //        //Updating Products table
                //        ctx.Products.Where(x => x.ProductID == item.ProductID).FirstOrDefault().Eenheid -= item.Eenheid;
                //        ctx.SaveChanges();
                //    }
                //}

                objDoc.SaveAs2("C:\\Users\\Krëfel\\source\\repos\\TussentijdsProject\\TussentijdsProject\\bin\\Debug\\Suji.docx");
                objDoc.Close();
                objWord.Quit();
            }
        }
    }
}
