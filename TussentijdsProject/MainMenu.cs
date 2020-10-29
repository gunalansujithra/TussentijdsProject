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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ManageCategorie manageCategorie = new ManageCategorie();
                manageCategorie.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(manageCategorie);
                manageCategorie.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void personeelslidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ManagePersoneelslid managePersoneelslid = new ManagePersoneelslid();
                managePersoneelslid.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(managePersoneelslid);
                managePersoneelslid.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void leverancierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ManageLeverancier manageLeverancier = new ManageLeverancier();
                manageLeverancier.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(manageLeverancier);
                manageLeverancier.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void klantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ManageKlant manageKlant = new ManageKlant();
                manageKlant.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(manageKlant);
                manageKlant.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ManageProduct manageProduct = new ManageProduct();
                manageProduct.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(manageProduct);
                manageProduct.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usernaamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ManageInloggen manageInloggen = new ManageInloggen();
                manageInloggen.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(manageInloggen);
                manageInloggen.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void leverancierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                BestellingLeverancier bestellingLeverancier = new BestellingLeverancier();
                bestellingLeverancier.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(bestellingLeverancier);
                bestellingLeverancier.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void klantToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                BestellingKlant bestellingKlant = new BestellingKlant();
                bestellingKlant.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(bestellingKlant);
                bestellingKlant.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ManageStocks manageStocks = new ManageStocks();
                manageStocks.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(manageStocks);
                manageStocks.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProductTemplate productTemplate = new ProductTemplate();
                productTemplate.TopLevel = false;
                pnlDisplay.Controls.Clear();
                pnlDisplay.Controls.Add(productTemplate);
                productTemplate.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
