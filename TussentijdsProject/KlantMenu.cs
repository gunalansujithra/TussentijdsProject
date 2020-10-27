﻿using System;
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
    public partial class KlantMenu : Form
    {
        public KlantMenu()
        {
            InitializeComponent();
        }

        private void klantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageKlant manageKlant = new ManageKlant();
            manageKlant.TopLevel = false;
            pnlDisplay.Controls.Clear();
            pnlDisplay.Controls.Add(manageKlant);
            manageKlant.Show();
        }

        private void klantToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BestellingKlant bestellingKlant = new BestellingKlant();
            bestellingKlant.TopLevel = false;
            pnlDisplay.Controls.Clear();
            pnlDisplay.Controls.Add(bestellingKlant);
            bestellingKlant.Show();
        }
    }
}
