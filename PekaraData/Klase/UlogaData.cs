using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PekaraData
{
    public class UlogaData
    {
        public List<Uloga> DohvatiUloge()
        {
            using (var db = new PekaraEntities())
            {
                return db.Ulogas.ToList();
            }
        }

        public void DodajNovuUlogu(Uloga uloga)
        {
            using (var db = new PekaraEntities())
            {
                db.Ulogas.Attach(uloga);
                db.Ulogas.Add(uloga);
                db.SaveChanges();
            }
        }

        public void ObrisiUlogu(Uloga uloga)
        {
            using (var db = new PekaraEntities())
            {
                db.Ulogas.Attach(uloga);
                if (uloga.Zaposleniks.Count == 0)
                {
                    db.Ulogas.Remove(uloga);
                    db.SaveChanges();
                }
                
            }
        }
        public void IzmjeniUlogu(Uloga uloga)
        {
            using (var db = new PekaraEntities())
            {
                db.Ulogas.Attach(uloga);
                db.Entry(uloga).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
