using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PekaraData
{
    public class KupacData
    {
        public List<Kupac> DohvatiKupce()
        {
            using (var db = new PekaraEntities())
            {
                return db.Kupacs.ToList();
            }
        }
    }
}
