using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PekaraData;

namespace PekaraBussines
{
    public class UlogaBusiness
    {
        private UlogaData ulogaD;

        public UlogaBusiness()
        {
            ulogaD = new UlogaData();
        }

        public List<Uloga> DohavtiUloge()
        {
            return ulogaD.DohvatiUloge();
        }

        public void DodajNovuUlogu(Uloga uloga)
        {

            ulogaD.DodajNovuUlogu(uloga);
        }

        public void ObrisiUlogu(Uloga uloga)
        {
            ulogaD.ObrisiUlogu(uloga);
        }

        public void IzmjeniUlogu(Uloga uloga)
        {
            ulogaD.IzmjeniUlogu(uloga);
        }
    }
}
