namespace Poslovna_aplikacija
{
    partial class PotvrdaRacuna
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.txtUkupniIznos = new System.Windows.Forms.TextBox();
            this.cbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.btnProvediRacun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popust :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Način plaćanja :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ukupni iznos :";
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(149, 27);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(121, 22);
            this.txtPopust.TabIndex = 4;
            this.txtPopust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPopust_KeyDown);
            this.txtPopust.Leave += new System.EventHandler(this.txtPopust_Leave);
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Location = new System.Drawing.Point(149, 138);
            this.txtUkupniIznos.Name = "txtUkupniIznos";
            this.txtUkupniIznos.ReadOnly = true;
            this.txtUkupniIznos.Size = new System.Drawing.Size(121, 22);
            this.txtUkupniIznos.TabIndex = 6;
            // 
            // cbNacinPlacanja
            // 
            this.cbNacinPlacanja.FormattingEnabled = true;
            this.cbNacinPlacanja.Items.AddRange(new object[] {
            "GOTOVINA",
            "KARTICA",
            "OSTALO"});
            this.cbNacinPlacanja.Location = new System.Drawing.Point(149, 85);
            this.cbNacinPlacanja.Name = "cbNacinPlacanja";
            this.cbNacinPlacanja.Size = new System.Drawing.Size(121, 24);
            this.cbNacinPlacanja.TabIndex = 7;
            // 
            // btnProvediRacun
            // 
            this.btnProvediRacun.BackColor = System.Drawing.Color.GhostWhite;
            this.btnProvediRacun.Location = new System.Drawing.Point(36, 218);
            this.btnProvediRacun.Name = "btnProvediRacun";
            this.btnProvediRacun.Size = new System.Drawing.Size(99, 51);
            this.btnProvediRacun.TabIndex = 8;
            this.btnProvediRacun.Text = "Provedi račun";
            this.btnProvediRacun.UseVisualStyleBackColor = false;
            this.btnProvediRacun.Click += new System.EventHandler(this.btnProvediRacun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "kn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.GhostWhite;
            this.btnOdustani.Location = new System.Drawing.Point(183, 218);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(99, 51);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // IzdavanjeRacunaPotvrda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(334, 298);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProvediRacun);
            this.Controls.Add(this.cbNacinPlacanja);
            this.Controls.Add(this.txtUkupniIznos);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "IzdavanjeRacunaPotvrda";
            this.Text = "IzdavanjeRacunaPotvrda";
            this.Load += new System.EventHandler(this.IzdavanjeRacunaPotvrda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.TextBox txtUkupniIznos;
        private System.Windows.Forms.ComboBox cbNacinPlacanja;
        private System.Windows.Forms.Button btnProvediRacun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOdustani;
    }
}