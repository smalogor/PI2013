﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baza;

namespace Skladiste_PI
{
    
    public partial class frmPregledDobavljaca : Form
    {
        public frmPregledDobavljaca()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Popunjava DataGrid s dobavljačima iz baze
        /// </summary>
        private void DohvatiDobavljace()
        {
            List<PoslovniPartner> listaDobavljaca = PoslovniPartner.DohvatiPoslovnePartnere(); // 0 - Dobavljaci
            dgvDobavljaci.DataSource = listaDobavljaca;
        }
        
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPregledDobavljaca_Load(object sender, EventArgs e)
        {
            DohvatiDobavljace();
            dgvDobavljaci.Columns["ID_partnera"].Visible = false;
          
            dgvDobavljaci.Columns["Ime"].HeaderText = "Ime/Naziv";
            dgvDobavljaci.Columns["Email"].HeaderText = "Prezime/Vrsta";
            dgvDobavljaci.Columns["Broj_telefona"].HeaderText = "Prezime/Vrsta";
            dgvDobavljaci.Columns["Adresa"].HeaderText = "Prezime/Vrsta";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmUnosDobavljaca frmUnosDobavljaca = new frmUnosDobavljaca();
            frmUnosDobavljaca.ShowDialog();
            DohvatiDobavljace();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (dgvDobavljaci.SelectedRows.Count > 0)
            {
                switch (MessageBox.Show("Jeste li sigurni da želite obrisati " + (dgvDobavljaci.SelectedRows.Count == 1 ? "označenog dobavljača?" : "označene dobavljače?"), "Upit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        return;
                }

                foreach (DataGridViewRow row in dgvDobavljaci.SelectedRows)
                {
                    PoslovniPartner odabraniDobavljaci = row.DataBoundItem as PoslovniPartner;
                    odabraniDobavljaci.Obrisi();
                }
                DohvatiDobavljace();
            }
        }

        private void frmPregledDobavljaca_Activated(object sender, EventArgs e)
        {
            DohvatiDobavljace();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (dgvDobavljaci.SelectedRows.Count == 1)
            {
                PoslovniPartner odabraniDobavljac = dgvDobavljaci.SelectedRows[0].DataBoundItem as PoslovniPartner;
               // frmUnosDobavljaca frmUnosDobavljaca = new frmUnosDobavljaca(odabraniDobavljac);
               // frmUnosDobavljaca.ShowDialog();
                DohvatiDobavljace();
            }
            else if (dgvDobavljaci.SelectedRows.Count > 1)
                MessageBox.Show("Označite samo jednog dobavljača za izmjenu!", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDobavljaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIzmjeni_Click(null,null);
        }

        private void dgvDobavljaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
