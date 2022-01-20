namespace Poslovna_aplikacija
{
    partial class PregledUloga
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
            this.dgvUloge = new System.Windows.Forms.DataGridView();
            this.btnDodajNovuUlogu = new System.Windows.Forms.Button();
            this.btnIzmjeniUlogu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiUlogu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUloge
            // 
            this.dgvUloge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUloge.Location = new System.Drawing.Point(29, 84);
            this.dgvUloge.MultiSelect = false;
            this.dgvUloge.Name = "dgvUloge";
            this.dgvUloge.ReadOnly = true;
            this.dgvUloge.RowTemplate.Height = 24;
            this.dgvUloge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUloge.Size = new System.Drawing.Size(658, 419);
            this.dgvUloge.TabIndex = 0;
            // 
            // btnDodajNovuUlogu
            // 
            this.btnDodajNovuUlogu.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDodajNovuUlogu.Location = new System.Drawing.Point(768, 84);
            this.btnDodajNovuUlogu.Name = "btnDodajNovuUlogu";
            this.btnDodajNovuUlogu.Size = new System.Drawing.Size(130, 49);
            this.btnDodajNovuUlogu.TabIndex = 1;
            this.btnDodajNovuUlogu.Text = "Dodaj novu ulogu";
            this.btnDodajNovuUlogu.UseVisualStyleBackColor = false;
            this.btnDodajNovuUlogu.Click += new System.EventHandler(this.btnDodajNovuUlogu_Click);
            // 
            // btnIzmjeniUlogu
            // 
            this.btnIzmjeniUlogu.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIzmjeniUlogu.Location = new System.Drawing.Point(768, 171);
            this.btnIzmjeniUlogu.Name = "btnIzmjeniUlogu";
            this.btnIzmjeniUlogu.Size = new System.Drawing.Size(130, 58);
            this.btnIzmjeniUlogu.TabIndex = 2;
            this.btnIzmjeniUlogu.Text = "Izmjeni označenu ulogu";
            this.btnIzmjeniUlogu.UseVisualStyleBackColor = false;
            this.btnIzmjeniUlogu.Click += new System.EventHandler(this.btnIzmjeniUlogu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Popis uloga :";
            // 
            // btnObrisiUlogu
            // 
            this.btnObrisiUlogu.BackColor = System.Drawing.Color.GhostWhite;
            this.btnObrisiUlogu.Location = new System.Drawing.Point(768, 260);
            this.btnObrisiUlogu.Name = "btnObrisiUlogu";
            this.btnObrisiUlogu.Size = new System.Drawing.Size(130, 49);
            this.btnObrisiUlogu.TabIndex = 4;
            this.btnObrisiUlogu.Text = "Obriši označenu ulogu";
            this.btnObrisiUlogu.UseVisualStyleBackColor = false;
            this.btnObrisiUlogu.Click += new System.EventHandler(this.btnObrisiUlogu_Click);
            // 
            // PregledUloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1238, 616);
            this.Controls.Add(this.btnObrisiUlogu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzmjeniUlogu);
            this.Controls.Add(this.btnDodajNovuUlogu);
            this.Controls.Add(this.dgvUloge);
            this.Name = "PregledUloga";
            this.Text = "PregledUloga";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PregledUloga_FormClosed);
            this.Load += new System.EventHandler(this.PregledUloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUloge;
        private System.Windows.Forms.Button btnDodajNovuUlogu;
        private System.Windows.Forms.Button btnIzmjeniUlogu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiUlogu;
    }
}