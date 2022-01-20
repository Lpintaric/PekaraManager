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
    public partial class PregledZaposlenika : Form
    {
        TabPage page;
        TabControl control;

        ZaposlenikBusiness zaposlenikB;

        List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();

        public PregledZaposlenika(TabPage page, TabControl control)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.page = page;
            this.control = control;

            zaposlenikB = new ZaposlenikBusiness();
        }

        private void OsvjeziPodatke()
        {     
            listaZaposlenika = zaposlenikB.DohvatiZaposlenike(); // Lista sa "Zaposlenik"objektima

            dgvZaposlenici.DataSource = null;
            dgvZaposlenici.DataSource = zaposlenikB.DohvatiZaposlenikeZaPrikaz(); // Dodajemo listu uređenu za prikaz

        }

        private void PregledZaposlenika_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            DodajZaposlenika dodajZaposlenika = new DodajZaposlenika();
            dodajZaposlenika.ShowDialog();

            OsvjeziPodatke();
        }

        private void btnIzmjeniZaposlenika_Click(object sender, EventArgs e)
        {
            int index = dgvZaposlenici.CurrentRow.Index;
            Zaposlenik odabraniZaposlenik = listaZaposlenika[index];
            

            DodajZaposlenika dodajZaposlenika = new DodajZaposlenika(odabraniZaposlenik);
            dodajZaposlenika.ShowDialog();

            OsvjeziPodatke();
        }

        private void btnObrisiZaposlenika_Click(object sender, EventArgs e)
        {
            int indexOdabranogZaposlenika = dgvZaposlenici.CurrentRow.Index;
            Zaposlenik odabraniZaposlenik = listaZaposlenika[indexOdabranogZaposlenika];

            zaposlenikB.ObrisiZaposlenika(odabraniZaposlenik);

            OsvjeziPodatke();
        }

        private void PregledZaposlenika_FormClosed(object sender, FormClosedEventArgs e)
        {
            control.TabPages.Remove(page);
        }
    }
}
