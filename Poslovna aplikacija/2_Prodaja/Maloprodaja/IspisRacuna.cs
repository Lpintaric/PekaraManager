using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PekaraBussines;
using PekaraData;

namespace Poslovna_aplikacija
{
    public partial class IspisRacuna : Form
    {
        StavkaRacunaBusiness stavkaRacunaB = new StavkaRacunaBusiness();
        ProizvodBusiness proizvodB = new ProizvodBusiness();

        Racun racunZaPrikaz = null;
        List<StavkaRacuna> stavkeZaIspis = new List<StavkaRacuna>();

        public IspisRacuna(Racun racun)
        {
            InitializeComponent();
            racunZaPrikaz = racun;
        }

        private void IspisRacuna_Load(object sender, EventArgs e)
        {
            PostaviVrijednotiRacuna();

            PostaviVrijednostiStavkiracuna();
        }

        private void PostaviVrijednotiRacuna()
        {
            lblBrojRacuna.Text = racunZaPrikaz.ID_racuna.ToString();

            lblDatumIVrijeme.Text = ((DateTime)racunZaPrikaz.Datum).ToString("dd/MM/yyyy hh/mm/ss");
            lblNacinPlacanja.Text = racunZaPrikaz.NacinPlacanja.ToString();
            lblUkupno.Text = ((float)racunZaPrikaz.KonacniIznos).ToString(".00");
            lblPopust.Text = racunZaPrikaz.Popust.ToString() + " " + "%" ;
        }

        private void PostaviVrijednostiStavkiracuna()
        {
            stavkeZaIspis = stavkaRacunaB.DohvatiStavkeRacuna(racunZaPrikaz.ID_racuna);
            List<StavkaRacunaIspis> listaStavki = new List<StavkaRacunaIspis>();
            String stavkaFormat = "{0, -30}{1, -10}{2, -10}{3, -10}";
            lbxStavke.Items.Add(String.Format(stavkaFormat, "Proizvod", "Cijena", "Količina", "Iznos"));

            foreach (StavkaRacuna stavka in stavkeZaIspis)
            {
                Proizvod proizvod = proizvodB.DohvatiProizvod(stavka.ID_proizvoda);
                lbxStavke.Items.Add(String.Format(stavkaFormat, proizvod.Naziv, ((float)proizvod.Cijena).ToString(".00"), stavka.Kolicina.ToString(), ((float)(stavka.Kolicina * proizvod.Cijena)).ToString(".00")));
            }
        }

    }
}
