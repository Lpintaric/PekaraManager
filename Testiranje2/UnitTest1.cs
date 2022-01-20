using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PekaraBussines;
using PekaraData;
using Poslovna_aplikacija;

namespace Testiranje2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ZaposlenikBusiness zaposlenikB = new ZaposlenikBusiness();
            UlogaBusiness ulogaB = new UlogaBusiness();

            List<Uloga> uloge = ulogaB.DohavtiUloge();
            Uloga uloga = uloge[1];

            Zaposlenik zaposlenik = new Zaposlenik();
            zaposlenik.Ime = "Fran";
            zaposlenik.Prezime = "Franic";

            zaposlenikB.DodajNovogZaposlenika(zaposlenik, uloga);

            List<Zaposlenik> zaposleniciL = zaposlenikB.DohvatiZaposlenike();
            Zaposlenik zaposlenik2 = (from z in zaposleniciL
                                     where z.Ime == "Fran"
                                     select z) as Zaposlenik;
            Assert.AreEqual(uloga.ID_uloge, 1);
        }
    }
}
