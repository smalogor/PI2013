﻿namespace Skladiste_PI
{
    
    partial class frmPregledDobavljaca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsUredjivanje = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuIzmjeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObrisi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.panelPozadina = new System.Windows.Forms.Panel();
            this.cmsUredjivanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.panelPozadina.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsUredjivanje
            // 
            this.cmsUredjivanje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIzmjeni,
            this.mnuObrisi});
            this.cmsUredjivanje.Name = "cmsUredjivanje";
            this.cmsUredjivanje.Size = new System.Drawing.Size(113, 48);
            // 
            // mnuIzmjeni
            // 
            this.mnuIzmjeni.Name = "mnuIzmjeni";
            this.mnuIzmjeni.Size = new System.Drawing.Size(112, 22);
            this.mnuIzmjeni.Text = "&Izmjeni";
            this.mnuIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // mnuObrisi
            // 
            this.mnuObrisi.Name = "mnuObrisi";
            this.mnuObrisi.Size = new System.Drawing.Size(112, 22);
            this.mnuObrisi.Text = "O&briši";
            this.mnuObrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(591, 328);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 32);
            this.btnZatvori.TabIndex = 5;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrisi.Location = new System.Drawing.Point(510, 328);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 32);
            this.btnBrisi.TabIndex = 4;
            this.btnBrisi.Text = "O&briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(13, 328);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 32);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "&Dodaj novog";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmjeni.Location = new System.Drawing.Point(429, 328);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 32);
            this.btnIzmjeni.TabIndex = 3;
            this.btnIzmjeni.Text = "&Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.AllowUserToAddRows = false;
            this.dgvDobavljaci.AllowUserToDeleteRows = false;
            this.dgvDobavljaci.AllowUserToOrderColumns = true;
            this.dgvDobavljaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.ContextMenuStrip = this.cmsUredjivanje;
            this.dgvDobavljaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDobavljaci.Location = new System.Drawing.Point(10, 10);
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.ReadOnly = true;
            this.dgvDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDobavljaci.ShowEditingIcon = false;
            this.dgvDobavljaci.Size = new System.Drawing.Size(659, 312);
            this.dgvDobavljaci.TabIndex = 2;
            this.dgvDobavljaci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDobavljaci_CellContentClick);
            this.dgvDobavljaci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDobavljaci_CellDoubleClick);
            // 
            // panelPozadina
            // 
            this.panelPozadina.Controls.Add(this.dgvDobavljaci);
            this.panelPozadina.Controls.Add(this.btnIzmjeni);
            this.panelPozadina.Controls.Add(this.btnDodaj);
            this.panelPozadina.Controls.Add(this.btnZatvori);
            this.panelPozadina.Controls.Add(this.btnBrisi);
            this.panelPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPozadina.Location = new System.Drawing.Point(0, 0);
            this.panelPozadina.Name = "panelPozadina";
            this.panelPozadina.Padding = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.panelPozadina.Size = new System.Drawing.Size(679, 372);
            this.panelPozadina.TabIndex = 7;
            // 
            // frmPregledDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(679, 372);
            this.Controls.Add(this.panelPozadina);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmPregledDobavljaca";
            this.Text = "Pregled dobavljača";
            this.Activated += new System.EventHandler(this.frmPregledDobavljaca_Activated);
            this.Load += new System.EventHandler(this.frmPregledDobavljaca_Load);
            this.cmsUredjivanje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            this.panelPozadina.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsUredjivanje;
        private System.Windows.Forms.ToolStripMenuItem mnuIzmjeni;
        private System.Windows.Forms.ToolStripMenuItem mnuObrisi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
        private System.Windows.Forms.Panel panelPozadina;
    }
}