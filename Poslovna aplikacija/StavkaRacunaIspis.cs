using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poslovna_aplikacija
{
    public class StavkaRacunaIspis
    {
        public string Proizvod { get; set; }
        public string Cijena { get; set; }
        public string Kolicina { get; set; }
        public string Iznos { get; set; }

        public StavkaRacunaIspis()
        {

        }

        public StavkaRacunaIspis(string proizvod, string cijena, string kolicina, string iznos)
        {
            Proizvod = proizvod;
            Cijena = cijena;
            Kolicina = kolicina;
            Iznos = iznos;
        }

        public override string ToString()
        {
            return $"{Proizvod} {Cijena} {Kolicina} {Iznos}";
        }
    }
}
