using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PekaraData
{
    public class ProizvodData
    {
        public List<Proizvod> DohvatiProizvode()
        {
            using (var db = new PekaraEntities())
            {
                return db.Proizvods.ToList();
            }
        }
    }
}
