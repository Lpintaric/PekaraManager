namespace Poslovna_aplikacija
{
    partial class StatistikePrometProdaje
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUkupniIznosPrometa = new System.Windows.Forms.TextBox();
            this.dgvPrikazPrometa = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOdjel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazPrometa)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parametri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Od :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Do :";
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "dd/MM/yyyy";
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd.Location = new System.Drawing.Point(66, 168);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(168, 22);
            this.dtpOd.TabIndex = 9;
            // 
            // dtpDo
            // 
            this.dtpDo.CustomFormat = "dd/MM/yyyy";
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDo.Location = new System.Drawing.Point(65, 211);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(169, 22);
            this.dtpDo.TabIndex = 10;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPrikazi.Location = new System.Drawing.Point(87, 259);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(114, 41);
            this.btnPrikazi.TabIndex = 11;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(836, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ukupni promet za razdoblje :";
            // 
            // txtUkupniIznosPrometa
            // 
            this.txtUkupniIznosPrometa.Location = new System.Drawing.Point(1031, 467);
            this.txtUkupniIznosPrometa.Name = "txtUkupniIznosPrometa";
            this.txtUkupniIznosPrometa.Size = new System.Drawing.Size(113, 22);
            this.txtUkupniIznosPrometa.TabIndex = 13;
            // 
            // dgvPrikazPrometa
            // 
            this.dgvPrikazPrometa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazPrometa.Location = new System.Drawing.Point(293, 79);
            this.dgvPrikazPrometa.Name = "dgvPrikazPrometa";
            this.dgvPrikazPrometa.RowTemplate.Height = 24;
            this.dgvPrikazPrometa.Size = new System.Drawing.Size(870, 369);
            this.dgvPrikazPrometa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Odjel :";
            // 
            // cbOdjel
            // 
            this.cbOdjel.FormattingEnabled = true;
            this.cbOdjel.Items.AddRange(new object[] {
            "Veleprodaja",
            "Maloprodaja"});
            this.cbOdjel.Location = new System.Drawing.Point(65, 132);
            this.cbOdjel.Name = "cbOdjel";
            this.cbOdjel.Size = new System.Drawing.Size(170, 24);
            this.cbOdjel.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1150, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "kn";
            // 
            // StatistikePrometProdaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1649, 986);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbOdjel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPrikazPrometa);
            this.Controls.Add(this.txtUkupniIznosPrometa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "StatistikePrometProdaje";
            this.Text = "StatistikePrometProdaje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatistikePrometProdaje_FormClosed);
            this.Load += new System.EventHandler(this.StatistikePrometProdaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazPrometa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUkupniIznosPrometa;
        private System.Windows.Forms.DataGridView dgvPrikazPrometa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOdjel;
        private System.Windows.Forms.Label label7;
    }
}