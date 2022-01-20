namespace Poslovna_aplikacija
{
    partial class PregledZaposlenika
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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnIzmjeniZaposlenika = new System.Windows.Forms.Button();
            this.btnObrisiZaposlenika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(22, 45);
            this.dgvZaposlenici.MultiSelect = false;
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(742, 434);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista zaposlenika :";
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(849, 59);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(105, 48);
            this.btnDodajZaposlenika.TabIndex = 2;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = false;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // btnIzmjeniZaposlenika
            // 
            this.btnIzmjeniZaposlenika.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIzmjeniZaposlenika.Location = new System.Drawing.Point(849, 148);
            this.btnIzmjeniZaposlenika.Name = "btnIzmjeniZaposlenika";
            this.btnIzmjeniZaposlenika.Size = new System.Drawing.Size(105, 64);
            this.btnIzmjeniZaposlenika.TabIndex = 3;
            this.btnIzmjeniZaposlenika.Text = "Izmjeni podatke o zaposleniku";
            this.btnIzmjeniZaposlenika.UseVisualStyleBackColor = false;
            this.btnIzmjeniZaposlenika.Click += new System.EventHandler(this.btnIzmjeniZaposlenika_Click);
            // 
            // btnObrisiZaposlenika
            // 
            this.btnObrisiZaposlenika.BackColor = System.Drawing.Color.GhostWhite;
            this.btnObrisiZaposlenika.Location = new System.Drawing.Point(849, 238);
            this.btnObrisiZaposlenika.Name = "btnObrisiZaposlenika";
            this.btnObrisiZaposlenika.Size = new System.Drawing.Size(105, 48);
            this.btnObrisiZaposlenika.TabIndex = 4;
            this.btnObrisiZaposlenika.Text = "Obriši zaposlenika";
            this.btnObrisiZaposlenika.UseVisualStyleBackColor = false;
            this.btnObrisiZaposlenika.Click += new System.EventHandler(this.btnObrisiZaposlenika_Click);
            // 
            // PregledZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1000, 525);
            this.Controls.Add(this.btnObrisiZaposlenika);
            this.Controls.Add(this.btnIzmjeniZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "PregledZaposlenika";
            this.Text = "PregledZaposlenika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PregledZaposlenika_FormClosed);
            this.Load += new System.EventHandler(this.PregledZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnIzmjeniZaposlenika;
        private System.Windows.Forms.Button btnObrisiZaposlenika;
    }
}