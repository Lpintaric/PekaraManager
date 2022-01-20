using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PekaraData;
using PekaraBussines;


namespace Poslovna_aplikacija
{
    public partial class StatistikePrometProdaje : Form
    {
        TabPage page;
        TabControl control;

        List<Racun> listaSortiranihRacuna = null;
        List<NarudzbaProdaje> listaSortiranihNarudzbi = null;

        RacunBusiness racunB = new RacunBusiness();
        NarudzbaProdajeBusiness narudzbaB = new NarudzbaProdajeBusiness();

        public StatistikePrometProdaje(TabPage page, TabControl control)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.page = page;
            this.control = control;
        }

        private void IzracunajUkupniIznos()
        {
            float ukupniIZnos = 0;

            if (cbOdjel.SelectedIndex == 0)
            {
                foreach (NarudzbaProdaje narudzba in listaSortiranihNarudzbi)
                {
                    if (narudzba.Iznos != null)
                    {
                        ukupniIZnos += (float)narudzba.Iznos;
                    }
                }

                txtUkupniIznosPrometa.Text = ukupniIZnos.ToString(".00");
            }
            else
            {
                foreach (Racun racun in listaSortiranihRacuna)
                {
                    if (racun.KonacniIznos != null)
                    {
                        ukupniIZnos += (float)racun.KonacniIznos;
                    }
                }

                txtUkupniIznosPrometa.Text = ukupniIZnos.ToString(".00");
            }
        }

        private void DohvatiNaruzbe()
        {
            listaSortiranihNarudzbi = narudzbaB.DohvatiNarudzbePremaDatumu(dtpOd.Value, dtpDo.Value);
            object listaSortiranihNarudzbiZaIspis = narudzbaB.DohvatiNarudzbePremaDatumuZaIspis(dtpOd.Value, dtpDo.Value);

            dgvPrikazPrometa.DataSource = listaSortiranihNarudzbiZaIspis;
            dgvPrikazPrometa.Columns["Datum"].DefaultCellStyle.Format = "dd/MM/yyyy";
            IzracunajUkupniIznos();
        }

        private void DohvatiRacune()
        {
            listaSortiranihRacuna = racunB.DohvatiRacunePremaDatumu(dtpOd.Value, dtpDo.Value);
            object listaSortiranihRacunaZaIspis = racunB.DohvatiRacunePremaDatumuZaIspis(dtpOd.Value, dtpDo.Value);

            dgvPrikazPrometa.DataSource = listaSortiranihRacunaZaIspis;
            dgvPrikazPrometa.Columns["Datum"].DefaultCellStyle.Format = "dd/MM/yyyy - hh:mm:ss";
            dgvPrikazPrometa.AutoResizeColumns();
            IzracunajUkupniIznos();
        }

        private void StatistikePrometProdaje_Load(object sender, EventArgs e)
        {
            cbOdjel.SelectedIndex = 0;
        }


        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (cbOdjel.SelectedIndex == 0)
            {
                DohvatiNaruzbe();
            }
            if(cbOdjel.SelectedIndex == 1)
            {
                DohvatiRacune();
            }
        }

        private void btnIspisPrometa_Click(object sender, EventArgs e)
        {

        }

        private void StatistikePrometProdaje_FormClosed(object sender, FormClosedEventArgs e)
        {
            control.TabPages.Remove(page);
        }

    }
}
