using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PekaraData;

namespace PekaraBussines
{
    public class StavkaNarudzbeProdajeBusiness
    {
        private StavkaNarudzbeProdajeData stavkaNarudzbeProdajeD;
        private ProizvodBusiness proizvodB;

        public StavkaNarudzbeProdajeBusiness() // konstruktor
        {
            stavkaNarudzbeProdajeD = new StavkaNarudzbeProdajeData();
            proizvodB = new ProizvodBusiness();
        }

        public List<Stavka_narudzbeProdaje> DohvatiStavkeNarudzbe(int idNarudzbe)
        {
            return stavkaNarudzbeProdajeD.DohvatiStavkeNarudzbe(idNarudzbe);
        }

        public object DohvatiSveStavkeZaPregled(int idNarudzbe)
        {
            List<Stavka_narudzbeProdaje> stavkeNarudzbe = DohvatiStavkeNarudzbe(idNarudzbe);
            List<Proizvod> proizvodi = proizvodB.DohvatiSveProizvode();

            var listaZaPregled = (from a in stavkeNarudzbe
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

        public void DodajNovuStavku(Stavka_narudzbeProdaje stavka, NarudzbaProdaje narudzba, Proizvod proizvod)
        {

            stavkaNarudzbeProdajeD.DodajNovuStavku(stavka, narudzba, proizvod);
        }

        public void ObrisiStavku(Stavka_narudzbeProdaje stavka)
        {
            stavkaNarudzbeProdajeD.ObrisiStavku(stavka);
        }

        public void IzmjeniStavku(Stavka_narudzbeProdaje stavka)
        {
            stavkaNarudzbeProdajeD.IzmjeniStavku(stavka);
        }
    }
}
