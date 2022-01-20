using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PekaraData;

namespace PekaraData
{
    public class StavkaRacunaData
    {
        public List<StavkaRacuna> DohvatiStavkeRacuna(int idRacuna)
        {
            using (var db = new PekaraEntities())
            {
                var listaStavki = from a in db.StavkaRacunas
                                  where a.ID_racuna == idRacuna
                                  select a;
                return listaStavki.ToList();
            }
        }

        public void DodajNovuStavku(StavkaRacuna stavka, Racun racun, Proizvod proizvod)
        {
            using (var db = new PekaraEntities())
            {
                db.StavkaRacunas.Attach(stavka);
                db.Racuns.Attach(racun);
                db.Proizvods.Attach(proizvod);

                db.StavkaRacunas.Add(stavka);
                racun.StavkaRacunas.Add(stavka);
                proizvod.StavkaRacunas.Add(stavka);

                db.SaveChanges();
            }
        }

        public void ObrisiStavku(StavkaRacuna stavka)
        {
            using (var db = new PekaraEntities())
            {
                db.StavkaRacunas.Attach(stavka);
                db.StavkaRacunas.Remove(stavka);
                db.SaveChanges();

            }
        }
    }
}
