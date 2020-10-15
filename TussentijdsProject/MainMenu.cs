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
            ManageCategorie manageCategorie = new ManageCategorie();
            manageCategorie.TopLevel = false;
            pnlDisplay.Controls.Clear();
            pnlDisplay.Controls.Add(manageCategorie);
            manageCategorie.Show();
            
        }

        private void personeelslidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePersoneelslid managePersoneelslid = new ManagePersoneelslid();
            managePersoneelslid.TopLevel = false;
            pnlDisplay.Controls.Clear();
            pnlDisplay.Controls.Add(managePersoneelslid);
            managePersoneelslid.Show();
        }

        private void leverancierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLeverancier manageLeverancier = new ManageLeverancier();
            manageLeverancier.TopLevel = false;
            pnlDisplay.Controls.Clear();
            pnlDisplay.Controls.Add(manageLeverancier);
            manageLeverancier.Show();
        }

        private void klantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageKlant manageKlant = new ManageKlant();
            manageKlant.TopLevel = false;
            pnlDisplay.Controls.Clear();
            pnlDisplay.Controls.Add(manageKlant);
            manageKlant.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct();
            manageProduct.TopLevel = false;
            pnlDisplay.Controls.Clear();
            pnlDisplay.Controls.Add(manageProduct);
            manageProduct.Show();
        }
    }
}
