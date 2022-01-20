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
    public partial class DodajNovuUlogu : Form
    {
        UlogaBusiness ulogaB = new UlogaBusiness();
        Uloga uloga = null;


        public DodajNovuUlogu()
        {
            InitializeComponent();   
            
        }

        public DodajNovuUlogu(Uloga odabranaUloga)
        {
            InitializeComponent();
            uloga = odabranaUloga;
        }

        private void DodajNovuUlogu_Load(object sender, EventArgs e)
        {
            if(uloga != null) //prilikom update popunjavaju se texboxovi sa podacima
            {
                txtNaziv.Text = uloga.Naziv;
                rtbOpis.Text = uloga.Opis;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (uloga != null) // radi se sa odabranom ulogom
            {
                uloga.Naziv = txtNaziv.Text;
                uloga.Opis = rtbOpis.Text;

                ulogaB.IzmjeniUlogu(uloga);
            }
            else // kreira se nova uloga
            {
                uloga = new Uloga();

                uloga.Naziv = txtNaziv.Text;
                uloga.Opis = rtbOpis.Text;

                ulogaB.DodajNovuUlogu(uloga);
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajNovuUlogu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        
    }
}
