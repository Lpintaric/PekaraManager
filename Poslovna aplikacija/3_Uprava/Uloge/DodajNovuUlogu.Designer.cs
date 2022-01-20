namespace Poslovna_aplikacija
{
    partial class DodajNovuUlogu
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSpremi.Location = new System.Drawing.Point(33, 212);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(83, 28);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(110, 53);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(204, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(53, 53);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(51, 17);
            this.Naziv.TabIndex = 3;
            this.Naziv.Text = "Naziv :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(59, 118);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(45, 17);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Opis :";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.GhostWhite;
            this.btnOdustani.Location = new System.Drawing.Point(231, 212);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(83, 28);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(110, 118);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(204, 69);
            this.rtbOpis.TabIndex = 6;
            this.rtbOpis.Text = "";
            // 
            // DodajNovuUlogu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(504, 301);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSpremi);
            this.Name = "DodajNovuUlogu";
            this.Text = "Podaci o ulozi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodajNovuUlogu_FormClosed);
            this.Load += new System.EventHandler(this.DodajNovuUlogu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.RichTextBox rtbOpis;
    }
}