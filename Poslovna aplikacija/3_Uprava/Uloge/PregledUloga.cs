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
    public partial class PregledUloga : Form
    {
        TabPage page;
        TabControl control;

        public PregledUloga(TabPage page, TabControl control)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.page = page;
            this.control = control;
        }

        private void OsvjeziPodatke()
        {
            UlogaBusiness uloga = new UlogaBusiness();
            dgvUloge.DataSource = uloga.DohavtiUloge();
            dgvUloge.Columns["Zaposleniks"].Visible = false;
        }


        private void PregledUloga_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
        }

        private void btnDodajNovuUlogu_Click(object sender, EventArgs e)
        {
            DodajNovuUlogu dodajNovuUlogu = new DodajNovuUlogu();
            dodajNovuUlogu.ShowDialog();

            OsvjeziPodatke();
        }

        private void btnIzmjeniUlogu_Click(object sender, EventArgs e)
        {
            Uloga OdabranaUloga = dgvUloge.CurrentRow.DataBoundItem as Uloga;

            DodajNovuUlogu dodajNovuUlogu = new DodajNovuUlogu(OdabranaUloga);
            dodajNovuUlogu.ShowDialog();

            OsvjeziPodatke();
        }

        private void btnObrisiUlogu_Click(object sender, EventArgs e)
        {
            Uloga OdabranaUloga = dgvUloge.CurrentRow.DataBoundItem as Uloga;

            UlogaBusiness ulogaObjekt = new UlogaBusiness();
            ulogaObjekt.ObrisiUlogu(OdabranaUloga);

            OsvjeziPodatke();
        }

        private void PregledUloga_FormClosed(object sender, FormClosedEventArgs e)
        {
            control.TabPages.Remove(page);
        }
    }
}
