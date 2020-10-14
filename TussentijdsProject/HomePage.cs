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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
                
        public void MovePanel(Control btn)
        {
            pnlSlide.Width = btn.Width;
            pnlSlide.Left = btn.Left;
        }

        private void btnDatabaheer_Click(object sender, EventArgs e)
        {
            MovePanel(btnDatabaheer);
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            MovePanel(btnOverzicht);
        }

        private void btnBestelling_Click(object sender, EventArgs e)
        {
            MovePanel(btnBestelling);
        }

       

        private void btnDatabaheer_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnDatabaheer_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
