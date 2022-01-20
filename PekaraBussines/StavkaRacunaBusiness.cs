using PekaraData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PekaraBussines
{
    public class StavkaRacunaBusiness
    {
        private StavkaRacunaData stavkaRacunaD = new StavkaRacunaData();
        private ProizvodBusiness proizvodB = new ProizvodBusiness();

        public List<StavkaRacuna> DohvatiStavkeRacuna(int idRacuna)
        {
            return stavkaRacunaD.DohvatiStavkeRacuna(idRacuna);
        }

        public object DohvatiSveStavkeZaPregled(int idRacuna)
        {
            List<StavkaRacuna> stavkeRacuna = DohvatiStavkeRacuna(idRacuna);
            List<Proizvod> proizvodi = proizvodB.DohvatiSveProizvode();

            var listaZaPregled = (from a in stavkeRacuna
                                  from b in proizvodi
                                  where a.ID_proizvoda == b.ID_proizvoda
                                  select new
                                  {
                                      b.Naziv,
                                      b.Cijena,
                                      a.Kolicina
                                  }).ToList();
            return listaZaPregled.ToList();
        }

        public void DodajNovuStavku(StavkaRacuna stavka, Racun racun, Proizvod proizvod)
        {
            stavkaRacunaD.DodajNovuStavku(stavka, racun, proizvod);
        }

        public void ObrisiStavku(StavkaRacuna stavka)
        {
            stavkaRacunaD.ObrisiStavku(stavka);
        }
    }
}
