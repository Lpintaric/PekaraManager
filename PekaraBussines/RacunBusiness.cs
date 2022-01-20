using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PekaraData;

namespace PekaraBussines
{
    public class RacunBusiness
    {
        RacunData racunD = new RacunData();
        ZaposlenikData zaposlenikD = new ZaposlenikData();

        public List<Racun> DohvatiSveRacune()
        {
            return racunD.DohvatiSveRacune();
        }

        public Racun DohvatiRacun(int idRacuna)
        {
            return racunD.DohvatiRacun(idRacuna);
        }

        public List<Racun> DohvatiRacunePremaDatumu(DateTime pocetniDatum, DateTime zavrsniDatum)
        {
            List<Racun> lista = racunD.DohvatiSveRacune();

            var novaLista = from l in lista
                            where l.Datum >= pocetniDatum && l.Datum <= zavrsniDatum
                            select l;

            return novaLista.ToList();
        }

        public object DohvatiRacunePremaDatumuZaIspis(DateTime pocetniDatum, DateTime zavrsniDatum)
        {
            List<Racun> listaRacuna = DohvatiRacunePremaDatumu(pocetniDatum, zavrsniDatum);
            List<Zaposlenik> listaZaposlenika = zaposlenikD.DohvatiZaposlenike();

            var listaZaPrikaz = from l in listaRacuna
                                from z in listaZaposlenika
                                where l.ID_zaposlenika == z.ID_zaposlenika && l.Datum >= pocetniDatum && l.Datum <= zavrsniDatum
                                select new
                                {
                                    Zaposlenik = z.Ime + " " + z.Prezime,
                                    l.Datum,
                                    Iznos = ((float)l.KonacniIznos).ToString(".00")
                                };
            
            return listaZaPrikaz.ToList();
        }


        public void DodajNoviRacun(Racun racun, Zaposlenik zaposlenik)
        {
            racunD.DodajNoviRacun(racun, zaposlenik);
        }
    }
}
