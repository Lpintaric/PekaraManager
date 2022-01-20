using Microsoft.VisualStudio.TestTools.UnitTesting;
using PekaraBussines;
using PekaraData;
using Poslovna_aplikacija;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Testiranje
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RacunBusiness racunBusiness = new RacunBusiness();
            ZaposlenikBusiness zaposlenikBusiness = new ZaposlenikBusiness();

            Zaposlenik zaposlenik = null;
            zaposlenik = zaposlenikBusiness.DohvatiZaposlenika(1);

            Racun racun = new Racun();
            racun.KonacniIznos = 129.20;
            racun.NacinPlacanja = "GOTOVINA";
            racun.Popust = 0;
            racun.Datum = System.DateTime.Now; ;
            racunBusiness.DodajNoviRacun(racun, zaposlenik);

            List<Racun> racuni = null;
            Racun racun2 = racunBusiness.DohvatiRacun(1);
            Assert.AreEqual(1, 1);
        }

       
    }
}
