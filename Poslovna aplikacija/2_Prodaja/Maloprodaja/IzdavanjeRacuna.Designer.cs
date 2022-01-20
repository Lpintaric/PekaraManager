namespace Poslovna_aplikacija
{
    partial class IzdavanjeRacuna
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
            this.btnUnesiStavku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifraProizvoda = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNazivProizvoda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnesiStavku
            // 
            this.btnUnesiStavku.BackColor = System.Drawing.Color.GhostWhite;
            this.btnUnesiStavku.Location = new System.Drawing.Point(156, 216);
            this.btnUnesiStavku.Name = "btnUnesiStavku";
            this.btnUnesiStavku.Size = new System.Drawing.Size(107, 46);
            this.btnUnesiStavku.TabIndex = 1;
            this.btnUnesiStavku.Text = "Unesi stavku";
            this.btnUnesiStavku.UseVisualStyleBackColor = false;
            this.btnUnesiStavku.Click += new System.EventHandler(this.buttonUnesiStavku_Click);
            this.btnUnesiStavku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUnesiStavku_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Šifra proizvoda :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Količina :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cijena :";
            // 
            // txtSifraProizvoda
            // 
            this.txtSifraProizvoda.Location = new System.Drawing.Point(156, 100);
            this.txtSifraProizvoda.Name = "txtSifraProizvoda";
            this.txtSifraProizvoda.Size = new System.Drawing.Size(63, 22);
            this.txtSifraProizvoda.TabIndex = 5;
            this.txtSifraProizvoda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifraProizvoda_KeyDown);
            this.txtSifraProizvoda.Leave += new System.EventHandler(this.txtSifraProizvoda_Leave);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(156, 177);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(158, 22);
            this.txtKolicina.TabIndex = 6;
            this.txtKolicina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKolicina_KeyDown);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(156, 139);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(158, 22);
            this.txtCijena.TabIndex = 7;
            // 
            // txtNazivProizvoda
            // 
            this.txtNazivProizvoda.Location = new System.Drawing.Point(226, 100);
            this.txtNazivProizvoda.Name = "txtNazivProizvoda";
            this.txtNazivProizvoda.ReadOnly = true;
            this.txtNazivProizvoda.Size = new System.Drawing.Size(135, 22);
            this.txtNazivProizvoda.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Naziv";
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIzdajRacun.Location = new System.Drawing.Point(51, 461);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(107, 46);
            this.btnIzdajRacun.TabIndex = 10;
            this.btnIzdajRacun.Text = "Izdaj račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = false;
            this.btnIzdajRacun.Click += new System.EventHandler(this.buttonIzdajRacun_Click);
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(445, 69);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.RowTemplate.Height = 24;
            this.dgvStavkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(685, 438);
            this.dgvStavkeRacuna.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnObrisiStavku);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnUnesiStavku);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNazivProizvoda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCijena);
            this.panel1.Controls.Add(this.txtSifraProizvoda);
            this.panel1.Controls.Add(this.txtKolicina);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 381);
            this.panel1.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "kom";
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.BackColor = System.Drawing.Color.GhostWhite;
            this.btnObrisiStavku.Location = new System.Drawing.Point(283, 304);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(107, 61);
            this.btnObrisiStavku.TabIndex = 12;
            this.btnObrisiStavku.Text = "Obriši odabranu stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = false;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "kn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stavka :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stavke računa :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zaposlenik :";
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(103, 6);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(172, 24);
            this.cbZaposlenik.TabIndex = 14;
            this.cbZaposlenik.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbZaposlenik_Format);
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Location = new System.Drawing.Point(1016, 522);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.Size = new System.Drawing.Size(85, 22);
            this.txtUkupanIznos.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(908, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ukupan iznos :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Datum :";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd/MM/yyyy - hh:mm:ss";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(356, 3);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(290, 22);
            this.dtpDatum.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1107, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "kn";
            // 
            // IzdavanjeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1214, 579);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUkupanIznos);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.btnIzdajRacun);
            this.Name = "IzdavanjeRacuna";
            this.Text = "Izdavanje računa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IzdavanjeRacuna_FormClosed);
            this.Load += new System.EventHandler(this.IzdavanjeRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUnesiStavku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifraProizvoda;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNazivProizvoda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}