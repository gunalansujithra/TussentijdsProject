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
    public partial class ManagePersoneelslid : Form
    {
        public ManagePersoneelslid()
        {
            InitializeComponent();
        }

        public static bool IsNewPersoneelsLid = false;
        public static int PersoneelsLidId = 0;

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                IsNewPersoneelsLid = true;
                SavePersoneelsLid savePersoneelsLid = new SavePersoneelsLid();
                if (savePersoneelsLid.ShowDialog() == DialogResult.OK)
                {
                    DisplayPersoneelsLid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPersoneelsLid.SelectedIndex >= 0)
                {
                    IsNewPersoneelsLid = false;
                    PersoneelsLidId = (int)cbPersoneelsLid.SelectedValue;
                    SavePersoneelsLid savePersoneelsLid = new SavePersoneelsLid();
                    if (savePersoneelsLid.ShowDialog() == DialogResult.OK)
                    {
                        DisplayPersoneelsLid();
                    }
                }
                else
                {
                    MessageBox.Show("Selecteer een personeelsLid om te bewerken");
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
                if (cbPersoneelsLid.SelectedIndex >= 0)
                {
                    string personeelslid = cbPersoneelsLid.Text;
                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        ctx.Personeelslids.RemoveRange(ctx.Personeelslids.Where(x => x.PersoneelslidID == (int)cbPersoneelsLid.SelectedValue));
                        ctx.SaveChanges();
                    }
                    MessageBox.Show(personeelslid + " is succesvol verwijderd");
                    DisplayPersoneelsLid();
                }
                else
                {
                    MessageBox.Show("Selecteer een personeelsLid om te verwijderen");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManagePersoneelslid_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayPersoneelsLid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (personeelsLidLijst.Count == 0)
                {
                    cbPersoneelsLid.Text = "";
                    txtName.Clear();
                }
            }
        }

        private void cbPersoneelsLid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPersoneelsLid.SelectedIndex >= 0)
                {
                    int personeelsLid = Convert.ToInt32(cbPersoneelsLid.SelectedValue);

                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        var selectedPersoneelsLid = ctx.Personeelslids.Where(x => x.PersoneelslidID == personeelsLid).FirstOrDefault();

                        if (selectedPersoneelsLid != null)
                        {
                            txtName.Text = selectedPersoneelsLid.Voornaam;
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
