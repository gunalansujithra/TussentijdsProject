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
    public partial class SavePersoneelsLid : Form
    {
        public SavePersoneelsLid()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManagePersoneelslid.IsNewPersoneelsLid)
                {
                    DisplayErrorMessage();

                    if (txtName.Text.Trim().Length > 0)
                    {
                        string personeelslid = txtName.Text;
                        using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                        {
                            ctx.Personeelslids.Add(new Personeelslid() { Voornaam = txtName.Text });
                            ctx.SaveChanges();
                        }
                        MessageBox.Show(personeelslid + " is succesvol toegevoegd");
                        txtName.Clear();
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    DisplayErrorMessage();

                    if (txtName.Text.Trim().Length > 0)
                    {
                        string personeelslid = txtName.Text;
                        using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                        {
                            ctx.Personeelslids.Where(x => x.PersoneelslidID == ManagePersoneelslid.PersoneelsLidId).FirstOrDefault().Voornaam = txtName.Text.Trim();
                            ctx.SaveChanges();
                        }
                        MessageBox.Show(personeelslid + " is succesvol bijgewerkt");

                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void DisplayErrorMessage()
        {
            string errorMessage = "";
            if (txtName.Text.Trim().Length == 0)
            {
                epNaam.SetError(txtName, "Voornaam naam is niet ingevuld");
                errorMessage += "\r\n" + "Voornaam naam is niet ingevuld";
            }
            else
            {
                epNaam.Clear();
            }

            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void SavePersoneelsLid_Load(object sender, EventArgs e)
        {
            try
            {
                if (ManagePersoneelslid.IsNewPersoneelsLid)
                {
                    txtName.Clear();
                }
                else
                {
                    int personeelsLid = ManagePersoneelslid.PersoneelsLidId;

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
