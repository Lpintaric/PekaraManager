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
    public partial class IzdavanjeRacuna : Form
    {
        TabPage page;
        TabControl control;

        ZaposlenikBusiness zaposlenikB = new ZaposlenikBusiness();
        RacunBusiness racunB = new RacunBusiness();
        ProizvodBusiness proizvodB = new ProizvodBusiness();
        StavkaRacunaBusiness stavkaRacunaB = new StavkaRacunaBusiness();
        public bool odustati = false;

        List<StavkaRacuna> listaStavki = new List<StavkaRacuna>();
        double ukupniIznos = 0;

        public IzdavanjeRacuna()
        {

        }

        //konstruktor
        public IzdavanjeRacuna(TabPage page, TabControl control)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.page = page;
            this.control = control;
        }

        private void OsvjeziGrid()
        {
            List<Proizvod> proizvodi = proizvodB.DohvatiSveProizvode();

            var listaZaPregled = (from a in listaStavki
                                  from b in proizvodi
                                  where a.ID_proizvoda == b.ID_proizvoda
                                  select new
                                  {
                                      b.Naziv,
                                      Cijena = ((float)b.Cijena).ToString(".00"),
                                      a.Kolicina,
                                      Iznos = ((float)(b.Cijena * a.Kolicina)).ToString(".00"),
                                      Iznos2 = b.Cijena * a.Kolicina
                                  }).ToList();
            ukupniIznos = 0;
            for (int i = 0; i < listaZaPregled.Count; i++)
            {
                ukupniIznos += (float)listaZaPregled[i].Iznos2;
            }
            txtUkupanIznos.Text = ((float)ukupniIznos).ToString(".00");
            dgvStavkeRacuna.DataSource = listaZaPregled;
            dgvStavkeRacuna.Columns["Iznos2"].Visible = false;
        }

        private void PostaviVrijednostiComboboxZaposlenici()
        {
            List<Zaposlenik> listaZaposlenika = zaposlenikB.DohvatiZaposlenike();
            cbZaposlenik.DataSource = listaZaposlenika;
            
        }

        private void OcistiPoljaZaUnos()
        {
            txtSifraProizvoda.Clear();
            txtCijena.Clear();
            txtKolicina.Clear();
            txtNazivProizvoda.Clear();
        }

        private void OcistiSveObjekte()
        {
            txtSifraProizvoda.Clear();
            txtCijena.Clear();
            txtKolicina.Clear();
            txtNazivProizvoda.Clear();
            dgvStavkeRacuna.DataSource = null;
            listaStavki.Clear();
            txtUkupanIznos.Clear();
        }

        private void IzdavanjeRacuna_Load(object sender, EventArgs e)
        {
            PostaviVrijednostiComboboxZaposlenici();
        }

        // formatiranje combobox-a sa zaposlenicima
        private void cbZaposlenik_Format(object sender, ListControlConvertEventArgs e)
        {
            string Ime = ((Zaposlenik)e.ListItem).Ime;
            string Prezime = ((Zaposlenik)e.ListItem).Prezime;
            e.Value = Ime + Prezime;
        }

        private void txtSifraProizvoda_Leave(object sender, EventArgs e)
        {
            if(btnIzdajRacun.Focused == false)
            {
                if (txtSifraProizvoda.Text == "")
                {
                    MessageBox.Show("Nesmije biti prazno");
                    txtSifraProizvoda.Focus();
                }
                else
                {
                    Proizvod proizvod = proizvodB.DohvatiProizvod(int.Parse(txtSifraProizvoda.Text));
                    if (proizvod != null)
                    {
                        txtNazivProizvoda.Text = proizvod.Naziv;
                        txtCijena.Text = ((float)proizvod.Cijena).ToString(".00");
                        txtKolicina.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kriva šifra !");
                        txtSifraProizvoda.Focus();
                    }
                }
            }
            
        }

        private void txtSifraProizvoda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSifraProizvoda.Text == "")
                {
                    MessageBox.Show("Nesmije biti prazno");
                    txtSifraProizvoda.Focus();
                }
                else
                {
                    Proizvod proizvod = proizvodB.DohvatiProizvod(int.Parse(txtSifraProizvoda.Text));
                    if (proizvod != null)
                    {
                        txtNazivProizvoda.Text = proizvod.Naziv;
                        txtCijena.Text = ((float)proizvod.Cijena).ToString(".00");
                        txtKolicina.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kriva šifra !");
                        txtSifraProizvoda.Focus();
                    }
                }
                e.SuppressKeyPress = true;

            }
        }

        private void txtKolicina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtKolicina.Text == "")
                {
                    MessageBox.Show("Nesmije biti prazno");
                }
                else
                {

                    btnUnesiStavku.Focus();
                    e.SuppressKeyPress = true;
                } 
            }       
        }

        private void buttonUnesiStavku_Click(object sender, EventArgs e)
        {
            StavkaRacuna stavka = new StavkaRacuna();
            stavka.ID_proizvoda = int.Parse(txtSifraProizvoda.Text);
            stavka.Kolicina = int.Parse(txtKolicina.Text);
            listaStavki.Add(stavka);
            OsvjeziGrid();
            OcistiPoljaZaUnos();
            txtSifraProizvoda.Focus();
        }

        private void btnUnesiStavku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StavkaRacuna stavka = new StavkaRacuna();
                stavka.ID_proizvoda = int.Parse(txtSifraProizvoda.Text);
                stavka.Kolicina = int.Parse(txtKolicina.Text);
                listaStavki.Add(stavka);
                OsvjeziGrid();
                OcistiPoljaZaUnos();
                txtSifraProizvoda.Focus();
            }


        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            int index = dgvStavkeRacuna.CurrentRow.Index;
            listaStavki.Remove(listaStavki[index]);
            OsvjeziGrid();
        }

        private void buttonIzdajRacun_Click(object sender, EventArgs e)
        {
            dtpDatum.ResetText();
            PotvrdaRacuna izdavanjeRacunaPotvrda = new PotvrdaRacuna(ukupniIznos, listaStavki, cbZaposlenik.SelectedItem as Zaposlenik, dtpDatum.Value, this);
            izdavanjeRacunaPotvrda.ShowDialog();

            //ako je u formi PotvrdaRacuna pritisnut gumb odustani stavke računa i ostali podaci se neće obristi u glavnoj formi
            if (odustati == false)
            {
                Racun racun = racunB.DohvatiSveRacune().Last();
                IspisRacuna ispisRacuna = new IspisRacuna(racun);
                ispisRacuna.ShowDialog();
                OcistiSveObjekte();
            }
            odustati = false;
        }

        private void IzdavanjeRacuna_FormClosed(object sender, FormClosedEventArgs e)
        {
            control.TabPages.Remove(page);

        }

        
    }
}
