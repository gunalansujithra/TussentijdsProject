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
    public partial class LeverancierMenu : Form
    {
        public LeverancierMenu()
        {
            InitializeComponent();
        }

        private void leverancierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BestellingLeverancier bestellingLeverancier = new BestellingLeverancier();
            bestellingLeverancier.TopLevel = false;
            pnlDisplay.Controls.Clear();
            pnlDisplay.Controls.Add(bestellingLeverancier);
            bestellingLeverancier.Show();
        }

        private void leverancierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLeverancier manageLeverancier = new ManageLeverancier();
            manageLeverancier.TopLevel = false;
            pnlDisplay.Controls.Clear();
            pnlDisplay.Controls.Add(manageLeverancier);
            manageLeverancier.Show();
        }
    }
}
