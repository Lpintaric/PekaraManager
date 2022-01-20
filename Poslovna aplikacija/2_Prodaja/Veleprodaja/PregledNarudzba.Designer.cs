namespace Poslovna_aplikacija
{
    partial class ProdajaNaVeliko
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrethodni = new System.Windows.Forms.Button();
            this.btnSljedeci = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifraNarudzbe = new System.Windows.Forms.TextBox();
            this.dtpDatumIzrade = new System.Windows.Forms.DateTimePicker();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.dgvStavkeNarudzbe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.btnNovaNarudzba = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.txtSifraProizvoda = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNazivProizvoda = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum izrade :";
            // 
            // btnPrethodni
            // 
            this.btnPrethodni.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPrethodni.Location = new System.Drawing.Point(320, 79);
            this.btnPrethodni.Name = "btnPrethodni";
            this.btnPrethodni.Size = new System.Drawing.Size(88, 31);
            this.btnPrethodni.TabIndex = 3;
            this.btnPrethodni.Text = "Prethodna";
            this.btnPrethodni.UseVisualStyleBackColor = false;
            this.btnPrethodni.Click += new System.EventHandler(this.btnPrethodni_Click);
            // 
            // btnSljedeci
            // 
            this.btnSljedeci.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSljedeci.Location = new System.Drawing.Point(466, 79);
            this.btnSljedeci.Name = "btnSljedeci";
            this.btnSljedeci.Size = new System.Drawing.Size(88, 31);
            this.btnSljedeci.TabIndex = 4;
            this.btnSljedeci.Text = "Sljedeća";
            this.btnSljedeci.UseVisualStyleBackColor = false;
            this.btnSljedeci.Click += new System.EventHandler(this.btnSljedeci_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Šifra narudžbe :";
            // 
            // txtSifraNarudzbe
            // 
            this.txtSifraNarudzbe.Location = new System.Drawing.Point(132, 30);
            this.txtSifraNarudzbe.Name = "txtSifraNarudzbe";
            this.txtSifraNarudzbe.Size = new System.Drawing.Size(100, 22);
            this.txtSifraNarudzbe.TabIndex = 8;
            // 
            // dtpDatumIzrade
            // 
            this.dtpDatumIzrade.CustomFormat = "dd/MM/yyyy";
            this.dtpDatumIzrade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumIzrade.Location = new System.Drawing.Point(770, 30);
            this.dtpDatumIzrade.Name = "dtpDatumIzrade";
            this.dtpDatumIzrade.Size = new System.Drawing.Size(158, 22);
            this.dtpDatumIzrade.TabIndex = 9;
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.BackColor = System.Drawing.Color.GhostWhite;
            this.btnObrisiStavku.Location = new System.Drawing.Point(302, 541);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(137, 43);
            this.btnObrisiStavku.TabIndex = 10;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = false;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // dgvStavkeNarudzbe
            // 
            this.dgvStavkeNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNarudzbe.Location = new System.Drawing.Point(523, 212);
            this.dgvStavkeNarudzbe.Name = "dgvStavkeNarudzbe";
            this.dgvStavkeNarudzbe.RowTemplate.Height = 24;
            this.dgvStavkeNarudzbe.Size = new System.Drawing.Size(547, 408);
            this.dgvStavkeNarudzbe.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kupac :";
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(320, 29);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(100, 22);
            this.txtKupac.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Zaposlenik :";
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(537, 29);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(100, 22);
            this.txtZaposlenik.TabIndex = 16;
            // 
            // btnNovaNarudzba
            // 
            this.btnNovaNarudzba.BackColor = System.Drawing.Color.GhostWhite;
            this.btnNovaNarudzba.Location = new System.Drawing.Point(1097, 50);
            this.btnNovaNarudzba.Name = "btnNovaNarudzba";
            this.btnNovaNarudzba.Size = new System.Drawing.Size(137, 41);
            this.btnNovaNarudzba.TabIndex = 17;
            this.btnNovaNarudzba.Text = "Nova narudžba";
            this.btnNovaNarudzba.UseVisualStyleBackColor = false;
            this.btnNovaNarudzba.Click += new System.EventHandler(this.btnNovaNarudzba_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Stavke narudžbe :";
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDodajStavku.Location = new System.Drawing.Point(127, 263);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(137, 43);
            this.btnDodajStavku.TabIndex = 19;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // txtSifraProizvoda
            // 
            this.txtSifraProizvoda.Location = new System.Drawing.Point(181, 94);
            this.txtSifraProizvoda.Name = "txtSifraProizvoda";
            this.txtSifraProizvoda.Size = new System.Drawing.Size(163, 22);
            this.txtSifraProizvoda.TabIndex = 20;
            this.txtSifraProizvoda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifraProizvoda_KeyDown);
            this.txtSifraProizvoda.Leave += new System.EventHandler(this.txtSifraProizvoda_Leave);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(181, 194);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(163, 22);
            this.txtKolicina.TabIndex = 21;
            this.txtKolicina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKolicina_KeyDown);
            this.txtKolicina.Leave += new System.EventHandler(this.txtKolicina_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Šifra proizvoda :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Količina :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Naziv :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Stavka :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.cbNazivProizvoda);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnDodajStavku);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSifraProizvoda);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtKolicina);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(30, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 347);
            this.panel1.TabIndex = 27;
            // 
            // cbNazivProizvoda
            // 
            this.cbNazivProizvoda.FormattingEnabled = true;
            this.cbNazivProizvoda.Location = new System.Drawing.Point(182, 147);
            this.cbNazivProizvoda.Name = "cbNazivProizvoda";
            this.cbNazivProizvoda.Size = new System.Drawing.Size(162, 24);
            this.cbNazivProizvoda.TabIndex = 27;
            this.cbNazivProizvoda.SelectionChangeCommitted += new System.EventHandler(this.cbNazivProizvoda_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.dtpDatumIzrade);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSifraNarudzbe);
            this.panel2.Controls.Add(this.txtZaposlenik);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnPrethodni);
            this.panel2.Controls.Add(this.btnSljedeci);
            this.panel2.Controls.Add(this.txtKupac);
            this.panel2.Location = new System.Drawing.Point(30, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 129);
            this.panel2.TabIndex = 28;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(1138, 598);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(96, 22);
            this.txtIznos.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1083, 601);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Iznos :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1240, 601);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "kn";
            // 
            // ProdajaNaVeliko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1396, 671);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNovaNarudzba);
            this.Controls.Add(this.dgvStavkeNarudzbe);
            this.Controls.Add(this.btnObrisiStavku);
            this.Name = "ProdajaNaVeliko";
            this.Text = "Narudžbe kupaca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProdajaNaVeliko_FormClosed);
            this.Load += new System.EventHandler(this.ProdajaNaVeliko_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrethodni;
        private System.Windows.Forms.Button btnSljedeci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifraNarudzbe;
        private System.Windows.Forms.DateTimePicker dtpDatumIzrade;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.DataGridView dgvStavkeNarudzbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.Button btnNovaNarudzba;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.TextBox txtSifraProizvoda;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbNazivProizvoda;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}