using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PekaraData
{
    public class ZaposlenikData
    {
        public List<Zaposlenik> DohvatiZaposlenike()
        {
            using (var db = new PekaraEntities())
            {
                return db.Zaposleniks.ToList();
            }
        }

        //public Zaposlenik DohvatiZaposlenika(int id)
        //{  
        //    using (var db = new PekaraEntities())
        //    {
        //        var zaposlenik = from a in DohvatiZaposlenike()
        //                     where a.ID_zaposlenika == id
        //                     select a;
        //        return zaposlenik as Zaposlenik;
        //    }    
        //}


        public void DodajNovogZaposlenika(Zaposlenik zaposlenik, Uloga uloga)
        {
            using (var db = new PekaraEntities())
            {
                db.Zaposleniks.Attach(zaposlenik);
                db.Ulogas.Attach(uloga);
                zaposlenik.Uloga1 = uloga;
                db.Zaposleniks.Add(zaposlenik);
                db.SaveChanges();
            }
        }

        public void ObrisiZaposlenika(Zaposlenik zaposlenik)
        {
            using (var db = new PekaraEntities())
            {
                db.Zaposleniks.Attach(zaposlenik);
                db.Zaposleniks.Remove(zaposlenik);
                db.SaveChanges();
                

            }
        }
        public void IzmjeniZaposlenika(Zaposlenik zaposlenik, Uloga uloga)
        {
            using (var db = new PekaraEntities())
            {
                db.Zaposleniks.Attach(zaposlenik);
                db.Ulogas.Attach(uloga);
                zaposlenik.Uloga1 = uloga;
                db.Entry(zaposlenik).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
