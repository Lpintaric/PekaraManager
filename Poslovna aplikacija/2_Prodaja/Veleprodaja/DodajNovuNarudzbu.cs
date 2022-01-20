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
    public partial class ProdajaNaVelikoNarudzba : Form
    {
        KupacBusiness kupacB = new KupacBusiness();
        ZaposlenikBusiness zaposlenikB = new ZaposlenikBusiness();
        NarudzbaProdajeBusiness narudzbaProdajeB = new NarudzbaProdajeBusiness();
        
        public ProdajaNaVelikoNarudzba()
        {
            InitializeComponent();
            
        }

        private void ProdajaNaVelikoNarudzba_Load(object sender, EventArgs e)
        {
            List<Zaposlenik> listaZaposlenika = zaposlenikB.DohvatiZaposlenike();
            List<Kupac> listaKupaca = kupacB.DohvatiKupce();

            cbKupac.DataSource = listaKupaca;
            cbKupac.DisplayMember = "Naziv";

            cbZaposlenik.DataSource = listaZaposlenika;
        }

       

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            NarudzbaProdaje narudzba = new NarudzbaProdaje();
            narudzba.Datum = dtpDatum.Value.Date;
            narudzbaProdajeB.DodajNovuNarudzbu(narudzba, cbKupac.SelectedItem as Kupac, cbZaposlenik.SelectedItem as Zaposlenik);
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProdajaNaVelikoNarudzba_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        //formatiranje vrijednosti u combobox-u
        private void cbZaposlenik_Format(object sender, ListControlConvertEventArgs e)
        {
            string Ime = ((Zaposlenik)e.ListItem).Ime;
            string Prezime = ((Zaposlenik)e.ListItem).Prezime;
            e.Value = Ime + Prezime;
        }
    }
}
