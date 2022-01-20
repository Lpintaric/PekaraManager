using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PekaraData
{
   public class StavkaNarudzbeProdajeData
    {
        public List<Stavka_narudzbeProdaje> DohvatiStavkeNarudzbe(int idNarudzbe)
        {
            using (var db = new PekaraEntities())
            {
                var listaStavki = from a in db.Stavka_narudzbeProdaje
                                  where a.ID_narudzbeProdaje == idNarudzbe
                                  select a;
                return listaStavki.ToList() ;
            }
        }

        public void DodajNovuStavku(Stavka_narudzbeProdaje stavka, NarudzbaProdaje narudzba, Proizvod proizvod)
        {
            using (var db = new PekaraEntities())
            {
                db.Stavka_narudzbeProdaje.Attach(stavka);
                db.NarudzbaProdajes.Attach(narudzba);
                db.Proizvods.Attach(proizvod);

                db.Stavka_narudzbeProdaje.Add(stavka);
                narudzba.Stavka_narudzbeProdaje.Add(stavka);
                proizvod.Stavka_narudzbeProdaje.Add(stavka);
                
                db.SaveChanges();
            }
        }

        public void ObrisiStavku(Stavka_narudzbeProdaje stavka)
        {
            using (var db = new PekaraEntities())
            {
                db.Stavka_narudzbeProdaje.Attach(stavka);
                db.Stavka_narudzbeProdaje.Remove(stavka);
                db.SaveChanges();

            }
        }
        public void IzmjeniStavku(Stavka_narudzbeProdaje stavka)
        {
            using (var db = new PekaraEntities())
            {
                db.Stavka_narudzbeProdaje.Attach(stavka);
                db.Entry(stavka).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
