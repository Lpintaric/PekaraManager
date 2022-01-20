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
    public partial class PotvrdaRacuna : Form
    {
        RacunBusiness racunB = new RacunBusiness();
        StavkaRacunaBusiness stavkaRacunaB = new StavkaRacunaBusiness();
        ProizvodBusiness proizvodB = new ProizvodBusiness();
        IzdavanjeRacuna izdavanjeRacuna = new IzdavanjeRacuna();

        List<StavkaRacuna> listaStavki;
        Zaposlenik zaposlenik;
        DateTime datum;
        double ukupniIznos = 0;
        double ukupniIznosPopust = 0;

        public PotvrdaRacuna(double ukupniIznos, List<StavkaRacuna> lista, Zaposlenik zaposlenik, DateTime datum, IzdavanjeRacuna forma )
        {
            InitializeComponent();
            this.ukupniIznos = ukupniIznos;
            listaStavki = lista;
            this.zaposlenik = zaposlenik;
            this.datum = datum;
            izdavanjeRacuna = forma;

        }

        private void IzdavanjeRacunaPotvrda_Load(object sender, EventArgs e)
        {
            txtUkupniIznos.Text = ukupniIznos.ToString(".00");
            txtPopust.Text = "0";
            cbNacinPlacanja.SelectedIndex = 0;

        }

        private void txtPopust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ukupniIznosPopust = ukupniIznos * (1 - float.Parse(txtPopust.Text) / 100);
                txtUkupniIznos.Text = ukupniIznosPopust.ToString(".00");
                e.SuppressKeyPress = true;
            }
        }

        private void txtPopust_Leave(object sender, EventArgs e)
        {
            if (txtPopust.Text == "")
            {
                txtPopust.Text = "0";
                txtUkupniIznos.Text = ukupniIznos.ToString(".00");
            }
            else
            {
                ukupniIznosPopust = ukupniIznos * (1 - float.Parse(txtPopust.Text) / 100);
                txtUkupniIznos.Text = ukupniIznosPopust.ToString(".00");
            }
            
        }

        private void btnProvediRacun_Click(object sender, EventArgs e)
        {
            // dodavanje računa u bazu
            Racun noviRacun = new Racun();
            noviRacun.PocetniIznos = ukupniIznos;
            noviRacun.KonacniIznos = float.Parse(txtUkupniIznos.Text);
            noviRacun.NacinPlacanja = cbNacinPlacanja.SelectedItem as string;
            noviRacun.Popust = float.Parse(txtPopust.Text);
            noviRacun.Datum = datum;
            racunB.DodajNoviRacun(noviRacun, zaposlenik);

            //dodavanje stavki računa u bazu
            foreach (StavkaRacuna stavka in listaStavki)
            {
                stavkaRacunaB.DodajNovuStavku(stavka, noviRacun, proizvodB.DohvatiProizvod(stavka.ID_proizvoda));
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            
            izdavanjeRacuna.odustati = true;
            Close();
        }

 
    }
}
