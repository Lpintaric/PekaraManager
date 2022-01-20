using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PekaraData;

namespace PekaraBussines
{
    public class NarudzbaProdajeBusiness
    {
        private NarudzbaProdajeData narudzbaProdajeD;
        private KupacData kupacD;
        private ZaposlenikData zaposlenikD;
        

        public NarudzbaProdajeBusiness() // konstruktor
        {
            narudzbaProdajeD = new NarudzbaProdajeData();
            kupacD = new KupacData();
            zaposlenikD = new ZaposlenikData();
        }

        public List<NarudzbaProdaje> DohvatiSveNarudzbe()
        {
            return narudzbaProdajeD.DohvatiSveNarudzbe();
        }

        public List<NarudzbaProdaje> DohvatiNarudzbePremaDatumu(DateTime pocetniDatum, DateTime zavrsniDatum)
        {
            List<NarudzbaProdaje> listaNarudzba = narudzbaProdajeD.DohvatiSveNarudzbe();
            var novaLista = (from l in listaNarudzba
                             where l.Datum >= pocetniDatum && l.Datum <= zavrsniDatum
                             select l).ToList();

            return novaLista;
        }

        public object DohvatiNarudzbePremaDatumuZaIspis(DateTime pocetniDatum, DateTime zavrsniDatum)
        {
            List<NarudzbaProdaje> listaNarudzba = narudzbaProdajeD.DohvatiSveNarudzbe();
            List<Zaposlenik> listaZaposlenika = zaposlenikD.DohvatiZaposlenike();
            List<Kupac> listaKupaca = kupacD.DohvatiKupce();

            var novaLista = (from l in listaNarudzba
                            from k in listaKupaca
                            from z in listaZaposlenika
                            where l.ID_kupca == k.ID_kupca && l.ID_zaposlenika == z.ID_zaposlenika && l.Datum >= pocetniDatum && l.Datum <= zavrsniDatum
                            select new
                            {
                                Zaposlenik = z.Ime + z.Prezime,
                                Kupac = k.Naziv,
                                l.Datum,
                                l.Iznos
                            }).ToList();

            return novaLista;
        }

        public NarudzbaProdaje DohvatiNarudzbu(int idNarudzbe)
        {
            return narudzbaProdajeD.DohvatiNarudzbu(idNarudzbe);
        }

        public void DodajNovuNarudzbu(NarudzbaProdaje narudzba, Kupac kupac, Zaposlenik zaposlenik)
        {

            narudzbaProdajeD.DodajNovuNarudzbu(narudzba, kupac, zaposlenik);
        }

        public void AzurirajIznos(int id, float iznos)
        {
            NarudzbaProdaje narudzba = DohvatiNarudzbu(id);
            narudzbaProdajeD.AzurirajIznos(narudzba, iznos);
        }

        public void ObrisiNarudzbu(NarudzbaProdaje narudzba)
        {
            narudzbaProdajeD.ObrisiNarudzbu(narudzba);
        }

        public void IzmjeniNarudzbu(NarudzbaProdaje narudzba)
        {
            narudzbaProdajeD.IzmjeniNarudzbu(narudzba);
        }
    }
}
