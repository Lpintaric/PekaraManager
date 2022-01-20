using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PekaraData;

namespace PekaraBussines
{
    public class KupacBusiness
    {
        private KupacData kupacD;

        public KupacBusiness()
        {
            kupacD = new KupacData();
        }
        public List<Kupac> DohvatiKupce()
        {
            List<Kupac> lista = kupacD.DohvatiKupce();
            return lista;
        }

        public Kupac DohvatiKupca(int id)
        {
            List<Kupac> kupci = DohvatiKupce();
            Kupac kupac = null;
            foreach (Kupac item in kupci)
            {
                if (item.ID_kupca == id)
                {
                    kupac = item;
                }
            }
            return kupac;
            
        }
    }
}
