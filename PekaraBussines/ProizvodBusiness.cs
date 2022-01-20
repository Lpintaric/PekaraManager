using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PekaraData;

namespace PekaraBussines
{
    public class ProizvodBusiness
    {
        private ProizvodData proizvodD;
        public ProizvodBusiness()
        {
            proizvodD = new ProizvodData();
            
        }

        public List<Proizvod> DohvatiSveProizvode()
        {
            return proizvodD.DohvatiProizvode();
        }

        public Proizvod DohvatiProizvod(int id)
        {
            Proizvod proizvod = null;
            List<Proizvod> lista = DohvatiSveProizvode();

            foreach (Proizvod item in lista)
            {
                if (item.ID_proizvoda == id)
                {
                    proizvod = item;
                }
            }
            return proizvod;

        }
    }
}
