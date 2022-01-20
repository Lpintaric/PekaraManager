using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PekaraData
{
    public class NarudzbaProdajeData
    {
        public List<NarudzbaProdaje> DohvatiSveNarudzbe()
        {
            using (var db = new PekaraEntities())
            {
                return db.NarudzbaProdajes.ToList();
            }
        }

        public NarudzbaProdaje DohvatiNarudzbu(int idNarudzbe)
        {
            NarudzbaProdaje narudzba = null;
            List<NarudzbaProdaje> lista = DohvatiSveNarudzbe();
            foreach (NarudzbaProdaje item in lista)
            {
                if (item.ID_narudzbeProdaje == idNarudzbe)
                {
                    narudzba = item;
                    break;
                }
            }

            return narudzba;
        }

        public void DodajNovuNarudzbu(NarudzbaProdaje narudzba, Kupac kupac, Zaposlenik zaposlenik)
        {
            using (var db = new PekaraEntities())
            {
                db.Kupacs.Attach(kupac);
                db.Zaposleniks.Attach(zaposlenik);
                db.NarudzbaProdajes.Attach(narudzba);

                narudzba.Kupac = kupac;
                narudzba.Zaposlenik = zaposlenik;
                db.NarudzbaProdajes.Add(narudzba);

                db.SaveChanges();
            }
        }

        public void AzurirajIznos(NarudzbaProdaje narudzba, float iznos)
        {
            using (var db = new PekaraEntities())
            {
                db.NarudzbaProdajes.Attach(narudzba);

                narudzba.Iznos = iznos;

                db.SaveChanges();

            }
        }

        public void ObrisiNarudzbu(NarudzbaProdaje narudzba)
        {
            using (var db = new PekaraEntities())
            {
                db.NarudzbaProdajes.Attach(narudzba);
                db.NarudzbaProdajes.Remove(narudzba);
                db.SaveChanges();
                

            }
        }
        public void IzmjeniNarudzbu(NarudzbaProdaje narudzba)
        {
            using (var db = new PekaraEntities())
            {
                db.NarudzbaProdajes.Attach(narudzba);
                db.Entry(narudzba).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
