namespace Poslovna_aplikacija
{
    partial class ProdajaNaVelikoNarudzba
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKupac = new System.Windows.Forms.ComboBox();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kupac :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaposlenik :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum :";
            // 
            // cbKupac
            // 
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.Location = new System.Drawing.Point(117, 65);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(247, 24);
            this.cbKupac.TabIndex = 16;
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(117, 101);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(247, 24);
            this.cbZaposlenik.TabIndex = 17;
            this.cbZaposlenik.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbZaposlenik_Format);
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd/MM/yyyy";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(117, 139);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(247, 22);
            this.dtpDatum.TabIndex = 18;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSpremi.Location = new System.Drawing.Point(29, 243);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(126, 32);
            this.btnSpremi.TabIndex = 19;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(167, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Narudžba kupca";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.GhostWhite;
            this.btnOdustani.Location = new System.Drawing.Point(322, 243);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(126, 32);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // ProdajaNaVelikoNarudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(538, 305);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.cbKupac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProdajaNaVelikoNarudzba";
            this.Text = "ProdajaNaVelikoNarudzba";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProdajaNaVelikoNarudzba_FormClosed);
            this.Load += new System.EventHandler(this.ProdajaNaVelikoNarudzba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKupac;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOdustani;
    }
}