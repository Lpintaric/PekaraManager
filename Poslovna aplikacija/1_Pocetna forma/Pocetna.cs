using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poslovna_aplikacija
{
    public partial class FormPocetna : Form
    {
        
        public FormPocetna()
        {
            InitializeComponent();

            
        }

         //Veleprodaja početak
        private void lblPregledNarudzba_Click(object sender, EventArgs e)
        {

            TabPage page = new TabPage("Pregled narudžba prodaje");
            ProdajaNaVeliko narudzba = new ProdajaNaVeliko(page, tabControl1);
            narudzba.TopLevel = false;

            tabControl1.TabPages.Add(page);
            

            page.Controls.Add(narudzba);

            tabControl1.SelectTab(page);

            narudzba.Show();
        }

        //Veleprodaja kraj

        //Maloprodaja početak
        private void lblKasa_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage("Izdavanje računa");
            IzdavanjeRacuna izdavanjeRacuna = new IzdavanjeRacuna(page, tabControl1);
            izdavanjeRacuna.TopLevel = false;

            tabControl1.TabPages.Add(page);

            page.Controls.Add(izdavanjeRacuna);

            tabControl1.SelectTab(page);

            izdavanjeRacuna.Show();

        }

        //Maloprodaja kraj


        //Uprava početak
        private void lblUloge_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage("Pregled uloga");
            PregledUloga pregledUloga = new PregledUloga(page, tabControl1);
            pregledUloga.TopLevel = false;

            tabControl1.TabPages.Add(page);

            page.Controls.Add(pregledUloga);

            tabControl1.SelectTab(page);

            pregledUloga.Show();
        }

        private void lblZaposlenici_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage("Pregled zaposlenika");
            PregledZaposlenika pregledZaposlenika = new PregledZaposlenika(page, tabControl1);
            pregledZaposlenika.TopLevel = false;

            tabControl1.TabPages.Add(page);

            page.Controls.Add(pregledZaposlenika);

            tabControl1.SelectTab(page);

            pregledZaposlenika.Show(); 
        }

        private void lblPromet_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage("Promet prodaje");
            StatistikePrometProdaje prometProdaje = new StatistikePrometProdaje(page, tabControl1);
            prometProdaje.TopLevel = false;

            tabControl1.TabPages.Add(page);

            page.Controls.Add(prometProdaje);

            tabControl1.SelectTab(page);

            prometProdaje.Show();
        }

        private void lblPomoc_Click(object sender, EventArgs e)
        {
            string filename = "KorisnickaDokumentacijaPM.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        //Uprava kraj


    }
}
