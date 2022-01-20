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
    public partial class ProdajaNaVeliko : Form
    {
        TabPage page;
        TabControl control;

        NarudzbaProdajeBusiness narudzbaProdajeB = new NarudzbaProdajeBusiness();
        KupacBusiness kupacB = new KupacBusiness();
        ZaposlenikBusiness zaposlenikB = new ZaposlenikBusiness();
        ProizvodBusiness proizvodB = new ProizvodBusiness();
        StavkaNarudzbeProdajeBusiness stavkaB = new StavkaNarudzbeProdajeBusiness();

        List<Stavka_narudzbeProdaje> listaStavki;
        NarudzbaProdaje trenutnaNarudzba;
        List<NarudzbaProdaje> listaNarudzba;

        //konstruktor
        public ProdajaNaVeliko(TabPage page, TabControl control)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.page = page;
            this.control = control;
        }

        //postavljanje vrijednosti na formi 
        private void PostaviVrijednostiNarudzbe(NarudzbaProdaje narudzba)
        {
            txtSifraNarudzbe.Text = narudzba.ID_narudzbeProdaje.ToString();
            
            string nazivKupca = kupacB.DohvatiKupca((int)narudzba.ID_kupca).Naziv;
            txtKupac.Text = nazivKupca;
            Zaposlenik zaposlenik = zaposlenikB.DohvatiZaposlenika((int)narudzba.ID_zaposlenika);
            txtZaposlenik.Text = zaposlenik.Ime + " " + zaposlenik.Prezime;


            dtpDatumIzrade.Text = narudzba.Datum.ToString();
            
        }

        //osvježavanje podataka prilikom prikaza odabrane narudžbe
        private void OsvjeziPodatkeNarudzbe()
        {
            listaNarudzba = narudzbaProdajeB.DohvatiSveNarudzbe();
            int brojNarudzba = listaNarudzba.Count;

            if (brojNarudzba > 0)
            {
                trenutnaNarudzba = listaNarudzba[brojNarudzba-1] as NarudzbaProdaje;
                PostaviVrijednostiNarudzbe(trenutnaNarudzba);
            }
        }

        //osvježavanje podataka stavki narudžbe
        private void OsvjeziStavke()
        {
            listaStavki = stavkaB.DohvatiStavkeNarudzbe(int.Parse(txtSifraNarudzbe.Text));
            var listaStavkiZaPrikaz = stavkaB.DohvatiSveStavkeZaPregled(int.Parse(txtSifraNarudzbe.Text));
            dgvStavkeNarudzbe.DataSource = listaStavkiZaPrikaz;
            decimal iznos = 0;
            foreach (var item in listaStavki)
            {
                Proizvod proizvod = proizvodB.DohvatiProizvod(item.ID_proizvoda);
                iznos =(iznos + ((decimal)item.Kolicina * (decimal)proizvod.Cijena));
            }
            txtIznos.Text = iznos.ToString();
        }

        private void PostaviVrijednostiComboBox()
        {
            List<Proizvod> listaProizvoda = proizvodB.DohvatiSveProizvode();
            cbNazivProizvoda.DataSource = listaProizvoda;
            cbNazivProizvoda.DisplayMember = "Naziv";
            cbNazivProizvoda.ResetText();
        }

        private void OcistiPolja()
        {
            txtSifraProizvoda.Clear();
            cbNazivProizvoda.ResetText();
            txtKolicina.Clear();

        }

        private void ProdajaNaVeliko_Load(object sender, EventArgs e)
        {
            OsvjeziPodatkeNarudzbe();

            PostaviVrijednostiComboBox();

            OsvjeziStavke();
        }

        

        private void btnNovaNarudzba_Click(object sender, EventArgs e)
        {
            ProdajaNaVelikoNarudzba narudzba = new ProdajaNaVelikoNarudzba();
            narudzba.ShowDialog();
            OsvjeziPodatkeNarudzbe();
            OsvjeziStavke();
            
        }

        

        //Dodavanje stavki u narudzbu
        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            Stavka_narudzbeProdaje stavka = new Stavka_narudzbeProdaje();
            int id;
            try
            {
                id = int.Parse(txtSifraProizvoda.Text);
            }
            catch
            {
                MessageBox.Show("Neispravni format šifre");
                txtSifraProizvoda.Focus();
                return;
            }

            try
            {
                stavka.Kolicina = int.Parse(txtKolicina.Text);
            }
            catch
            {
                MessageBox.Show("Neispravni format količine");
                txtKolicina.Focus();
                return;
            }
            stavkaB.DodajNovuStavku(stavka, narudzbaProdajeB.DohvatiNarudzbu(int.Parse(txtSifraNarudzbe.Text)), proizvodB.DohvatiProizvod(id));

            OsvjeziStavke();
            OcistiPolja();

            narudzbaProdajeB.AzurirajIznos(int.Parse(txtSifraNarudzbe.Text), float.Parse(txtIznos.Text));
            txtSifraProizvoda.Focus();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            int indexOdabraneStavke = dgvStavkeNarudzbe.CurrentRow.Index;
            Stavka_narudzbeProdaje odabranaStavka = listaStavki[indexOdabraneStavke];
            stavkaB.ObrisiStavku(odabranaStavka);
            OsvjeziStavke();
            narudzbaProdajeB.AzurirajIznos(int.Parse(txtSifraNarudzbe.Text), float.Parse(txtIznos.Text));
        }

        private void txtSifraProizvoda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id = 0;
                try
                {
                    id = int.Parse(txtSifraProizvoda.Text);
                }
                catch
                {
                    MessageBox.Show("Krivi format unosa !");
                    txtSifraProizvoda.Focus();
                    return;
                }

                    Proizvod proizvod = proizvodB.DohvatiProizvod(id);
                    List<Proizvod> lista = proizvodB.DohvatiSveProizvode();

                if (proizvod == null)
                {
                    MessageBox.Show("Pogrešna šifra");
                    txtSifraProizvoda.Focus();
                }
                else
                {
                    cbNazivProizvoda.Text = "";
                    cbNazivProizvoda.SelectedText = proizvod.Naziv;
                    txtKolicina.Focus();
                }
            }
        }

        private void txtSifraProizvoda_Leave(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = int.Parse(txtSifraProizvoda.Text);
            }
            catch
            {
                MessageBox.Show("Krivi format unosa !");
                txtSifraProizvoda.Focus();
                return;
            }

            Proizvod proizvod = proizvodB.DohvatiProizvod(id);
            List<Proizvod> lista = proizvodB.DohvatiSveProizvode();

            if (proizvod == null)
            {
                MessageBox.Show("Pogrešna šifra");
                txtSifraProizvoda.Focus();
            }
            else
            {
                cbNazivProizvoda.Text = "";
                cbNazivProizvoda.SelectedText = proizvod.Naziv;
            }
        }

        private void cbNazivProizvoda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Proizvod proizvod = cbNazivProizvoda.SelectedItem as Proizvod;
            txtSifraProizvoda.Text = proizvod.ID_proizvoda.ToString();
        }


        private void txtKolicina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int kolicina = 0;
                try
                {
                    kolicina = int.Parse(txtKolicina.Text);
                }
                catch
                {
                    MessageBox.Show("Krivi format unosa !");
                    txtSifraProizvoda.Focus();
                    return;
                }
                btnDodajStavku.Focus();
            }

        }

        private void txtKolicina_Leave(object sender, EventArgs e)
        {
            int kolicina = 0;
            try
            {
                kolicina = int.Parse(txtKolicina.Text);
            }
            catch
            {
                MessageBox.Show("Krivi format unosa !");
                txtSifraProizvoda.Focus();
                return;
            }
        }

        private void btnPrethodni_Click(object sender, EventArgs e)
        {
            int index = listaNarudzba.FindIndex(x => x.ID_narudzbeProdaje == trenutnaNarudzba.ID_narudzbeProdaje);
            if (index > 0)
            {
                trenutnaNarudzba = listaNarudzba[index - 1];
                PostaviVrijednostiNarudzbe(trenutnaNarudzba);
                OsvjeziStavke();
            }
            else
            {
                MessageBox.Show("Ne postoji prethodna narudžba");
            }
        }

        private void btnSljedeci_Click(object sender, EventArgs e)
        {
            int index = listaNarudzba.FindIndex(x => x.ID_narudzbeProdaje == trenutnaNarudzba.ID_narudzbeProdaje);
            if (index < listaNarudzba.Count - 1)
            {
                trenutnaNarudzba = listaNarudzba[index + 1];
                PostaviVrijednostiNarudzbe(trenutnaNarudzba);
                OsvjeziStavke();
            }
            else
            {
                MessageBox.Show("Ne postoji sljedeća narudžba");
            }
        }

        private void ProdajaNaVeliko_FormClosed(object sender, FormClosedEventArgs e)
        {
            control.TabPages.Remove(page);
        }

    }
}
