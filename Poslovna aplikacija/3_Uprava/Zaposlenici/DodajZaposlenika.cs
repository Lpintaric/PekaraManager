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
    public partial class DodajZaposlenika : Form
    {
        Zaposlenik zaposlenik = null;

        UlogaBusiness ulogaB = new UlogaBusiness();
        ZaposlenikBusiness zaposlenikB = new ZaposlenikBusiness();

        public DodajZaposlenika()
        {
            InitializeComponent();
        }

        

        public DodajZaposlenika(Zaposlenik odabraniZaposlenik)
        {
            InitializeComponent();
            zaposlenik = odabraniZaposlenik;

            txtIme.Text = zaposlenik.Ime;
            txtPrezime.Text = zaposlenik.Prezime;
            txtKontakt.Text = zaposlenik.Kontakt;
            txtAdresa.Text = zaposlenik.Adresa;

            //List<Uloga> listaUloga = ulogaB.DohavtiUloge();

            //Uloga uloga = (from a in listaUloga
            //               where a.ID_uloge == zaposlenik.ID_uloge
            //               select a) as Uloga;

            //cbUloga.SelectedValue = uloga;
        }

        private void DodajZaposlenika_Load(object sender, EventArgs e)
        {
            cbUloga.DataSource = ulogaB.DohavtiUloge();
            cbUloga.DisplayMember = "Naziv";

            if(zaposlenik != null)
            {
                txtIme.Text = zaposlenik.Ime;
                txtPrezime.Text = zaposlenik.Prezime;
                txtKontakt.Text = zaposlenik.Kontakt;
                txtAdresa.Text = zaposlenik.Adresa;

                List<Uloga> listaUloga = ulogaB.DohavtiUloge();

                


                //var uloga = from a in listaUloga
                //              where a.ID_uloge == zaposlenik.ID_uloge
                //              select a;

                cbUloga.SelectedIndex = (int)zaposlenik.ID_uloge - 1;
                
            }
        }
        
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (zaposlenik != null) // radi se promjena nad odabranim zaposlenikom
            {
                zaposlenik.Ime = txtIme.Text;
                zaposlenik.Prezime = txtPrezime.Text;
                zaposlenik.Kontakt = txtKontakt.Text;
                zaposlenik.Adresa = txtAdresa.Text;
                

                zaposlenikB.IzmjeniZaposlenika(zaposlenik, cbUloga.SelectedItem as Uloga);
            }
            else // kreira se novi zaposlenik
            {
                zaposlenik = new Zaposlenik();

                zaposlenik.Ime = txtIme.Text;
                zaposlenik.Prezime = txtPrezime.Text;
                zaposlenik.Kontakt = txtKontakt.Text;
                zaposlenik.Adresa = txtAdresa.Text;
                

                zaposlenikB.DodajNovogZaposlenika(zaposlenik, cbUloga.SelectedItem as Uloga);
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
