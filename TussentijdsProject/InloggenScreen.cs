﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TussentijdsProject
{
    public partial class InloggenScreen : Form
    {
        public InloggenScreen()
        {
            InitializeComponent();
        }

        public static bool IsWachtwoordVergeten = false;
        public static string UserName = "";
        private void btnInloggen_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayErrorMessage();

                if (txtUsername.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
                {
                    using (BestellingenDatabaseEntities ctx = new BestellingenDatabaseEntities())
                    {
                        //code for Usernames
                        string gebruiker = txtUsername.Text;
                        string encrypWW = EncryptWachtwoord(txtPassword.Text.Trim());
                        var usersDetails = ctx.InLoggens.Where(x => x.Username.ToLower() == gebruiker.ToLower()).FirstOrDefault();

                        if (usersDetails != null && usersDetails.Username.ToLower() == gebruiker.ToLower() && usersDetails.Wachtwoord == encrypWW)
                        {
                            if (usersDetails.GebruikerId == 1)
                            {
                                MainMenu mainMenu = new MainMenu();
                                this.Hide();
                                mainMenu.Show();
                            }
                            else if (usersDetails.GebruikerId == 2)
                            {
                                LeverancierMenu leverancierMenu = new LeverancierMenu();
                                this.Hide();
                                leverancierMenu.Show();
                            }
                            else if (usersDetails.GebruikerId == 3)
                            {
                                KlantMenu klantMenu = new KlantMenu();
                                this.Hide();
                                klantMenu.Show();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Onjuist Username / Wachtwoord is succesvol toegevoegd");
                            txtUsername.Clear();
                            txtPassword.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string EncryptWachtwoord(string input)
        {
            MD5CryptoServiceProvider csp = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = csp.ComputeHash(bs);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            string password = sb.ToString();
            return password;
        }

        public void DisplayErrorMessage()
        {
            string errorMessage = "";
            if (txtUsername.Text.Trim().Length == 0)
            {
                epUserName.SetError(txtUsername, "Usernaam is niet ingevuld");
                errorMessage += "\r\n" + "Usernaam is niet ingevuld";
            }
            else
            {
                epUserName.Clear();
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                epWachtwoord.SetError(txtPassword, "Wacthwoord naam is niet ingevuld");
                errorMessage += "\r\n" + "Wacthwoord naam is niet ingevuld";
            }
            else
            {
                epWachtwoord.Clear();
            }

            if (errorMessage.Trim().Length > 0)
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void cbWachtwoord_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbWachtwoord.Checked)
                {
                    txtPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InloggenScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lntWwVergeten_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                IsWachtwoordVergeten = true;
                UserName = txtUsername.Text;
                SaveInloggen manageInloggen = new SaveInloggen();
                if (manageInloggen.ShowDialog() == DialogResult.OK)
                {
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
