using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PekaraData
{
    public class RacunData
    {
        public List<Racun> DohvatiSveRacune()
        {
            using (var db = new PekaraEntities())
            {
                return db.Racuns.ToList();
            }
        }

        public Racun DohvatiRacun(int idRacuna)
        {
            Racun racun = null;
            List<Racun> lista = DohvatiSveRacune();
            foreach (Racun item in lista)
            {
                if (item.ID_racuna == idRacuna)
                {
                    racun = item;
                    break;
                }
            }

            return racun;
        }

        public void DodajNoviRacun(Racun racun, Zaposlenik zaposlenik)
        {
            using (var db = new PekaraEntities())
            {
                db.Zaposleniks.Attach(zaposlenik);
                db.Racuns.Attach(racun);

                racun.Zaposlenik = zaposlenik;
                db.Racuns.Add(racun);
                db.SaveChanges();
            }
        }
    }
}
