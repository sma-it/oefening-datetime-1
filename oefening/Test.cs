using NUnit.Framework;
using NUnitLite;
using System;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {
        // deze functie is nodig om de testen achteraf via de webinterface uit te voeren
        public static int Run(string resultPath)
        {
            string[] args = { "--work=" + resultPath };
            return new AutoRun().Execute(args);
        }

        [Test]
        public void TestWeekdagGeboorte()
        {
            Assert.That(First.Program.WeekdagGeboorte(new DateTime(2000, 3, 30)), Is.EqualTo("Thursday"));

        }

        [Test]
        public void TestBepaalAantalDagen()
        {
            Assert.That(First.Program.BepaalAantalDagen(new DateTime(2000, 5, 3), new DateTime(2000, 5, 13)), Is.EqualTo(10));

        }

        [Test]
        public void TestVergelijkDatums()
        {
            Assert.That(First.Program.VergelijkDatums(new DateTime(2010, 3, 15), new DateTime(2020, 12, 7)), Is.EqualTo("Dag 1 is vroeger"));
            Assert.That(First.Program.VergelijkDatums(new DateTime(2025, 11, 5), new DateTime(2020, 5, 7)), Is.EqualTo("Dag 2 is vroeger"));
            Assert.That(First.Program.VergelijkDatums(new DateTime(2030, 1, 15), new DateTime(2030, 1, 15)), Is.EqualTo("De datums vallen samen"));

        }

        [Test]
        public void TestRestAantalDagen()
        {
            Assert.That(First.Program.RestAantalDagen(new DateTime(2012, 2, 20)), Is.EqualTo(9));
            Assert.That(First.Program.RestAantalDagen(new DateTime(2013, 2, 20)), Is.EqualTo(8));
            Assert.That(First.Program.RestAantalDagen(new DateTime(2025, 1, 10)), Is.EqualTo(21));
            Assert.That(First.Program.RestAantalDagen(new DateTime(2025, 4, 10)), Is.EqualTo(20));
        }

        [Test]
        public void TestToonDagLang()
        {
            Assert.That(First.Program.ToonDagLang(new DateTime(2025, 9, 15)), Is.EqualTo("maandag 15 september 2025"));

        }

        [Test]
        public void TestTelSchrikkeljaren()
        {
            Assert.That(First.Program.TelSchrikkeljaren(2000, 2026), Is.EqualTo(7));
            Assert.That(First.Program.TelSchrikkeljaren(2016, 2028), Is.EqualTo(4));
        }

        [Test]
        public void TestZetOmTijd()
        {
            Assert.That(First.Program.ZetOmTijd(new DateTime(2025, 5, 29, 1, 15, 30)), Is.EqualTo(new DateTime(2025, 5, 29, 2, 15, 30)));

        }
    }
}
