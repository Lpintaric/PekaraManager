using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PekaraData;

namespace PekaraBussines
{
    public class ZaposlenikBusiness
    {
        ZaposlenikData zaposlenikD;
        UlogaBusiness ulogaB;

        public ZaposlenikBusiness()
        {
            zaposlenikD = new ZaposlenikData();
            ulogaB = new UlogaBusiness();
        }
        public List<Zaposlenik> DohvatiZaposlenike()
        {
            return zaposlenikD.DohvatiZaposlenike();
        }

        public Zaposlenik DohvatiZaposlenika(int id)
        {
            Zaposlenik zaposlenik = null;
            List<Zaposlenik> lista = zaposlenikD.DohvatiZaposlenike();

            foreach (Zaposlenik item in lista)
            {
                if (item.ID_zaposlenika == id)
                {
                    zaposlenik = item;
                }
            }

            return zaposlenik;
            
        }

        public object DohvatiZaposlenikeZaPrikaz()
        {
            List<Zaposlenik> listaZaposlenika;
            List<Uloga> listaUloga;
            

            listaZaposlenika = DohvatiZaposlenike();
            listaUloga = ulogaB.DohavtiUloge();

            var listaZaPrikaz = from a in listaZaposlenika
                            from b in listaUloga
                            where a.ID_uloge == b.ID_uloge
                            select new
                            {
                                Sifra = a.ID_zaposlenika,
                                a.Ime,
                                a.Prezime,
                                a.Adresa,
                                a.Kontakt,
                                Uloga = b.Naziv
                            };

            return listaZaPrikaz.ToList();
                
                    
        }

        public void DodajNovogZaposlenika(Zaposlenik zaposlenik, Uloga uloga)
        {
            zaposlenikD.DodajNovogZaposlenika(zaposlenik, uloga);
        }

        public void ObrisiZaposlenika(Zaposlenik zaposlenik)
        {
            zaposlenikD.ObrisiZaposlenika(zaposlenik);
        }
        public void IzmjeniZaposlenika(Zaposlenik zaposlenik, Uloga uloga)
        {
            zaposlenikD.IzmjeniZaposlenika(zaposlenik, uloga);
        }

        
    }
}
