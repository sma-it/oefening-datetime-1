using System;

namespace First
{
    class Program
    {
        /* Schrijf een functie waarmee de gebruiker kan nagaan op welke dag van de week hij/zij geboren is. De functie vraagt in 3 aparte vragen de
         * dag, maand en jaar waarop de gebruiker geboren is. Aan de hand van deze gegevens wordt een DateTime object samengesteld.
         * De weekdag waarop de ingegeven datum viel, wordt als functieresultaat gegeven.
        */

        public static string WeekdagGeboorte()
        {
            // schrijf hier je code
            return "";
        }

        /* Maak een functie die aantal dagen dat als argument meegegeven wordt, bij vandaag telt en 
         * als returnwaarde geeft welke datum het over dit aantal dagen zal zijn.
         * Zoek in DateTime struct een gepaste functie.
         */

        public static DateTime TelDagenBij(int dagen)
        {
            // schrijf hier je code

            return DateTime.Now;
        }


        /* Ontwerp een functie die bepaalt hoeveel dagen er tussen twee opgegeven datums liggen. De datums worden meegegeven
         * als functieargument.
         * Tips: Je kan de - operator gebruiken op DateTime objecten. Het resultaat plaats je in een TimeSpan object (zoek even op hoe je dit maakt).
         */

        public static double BepaalAantalDagen(DateTime datum1, DateTime datum2)
        {
            // schrijf hier je code

            return 0;
        }

        /* Deze functie doet hetzelfde als de vorige functie (BepaalAantalDagen), maar je werkt nu niet met de - operator, maar met de method Substract.
         * Beide alternatieven werken identiek en leveren een TimeSpan object af.
         */

        public static double BepaalAantalDagenVersie2(DateTime datum1, DateTime datum2)
        {
            // schrijf hier je code

            return 0;
        }


        /* Schrijf een functie die nagaat of een eerste datum vroeger, gelijk of later valt dan een tweede 
         * datum. Beide datums worden als functieargument meegegeven.
         * Als uitvoer geef je:
         * Dag 1 is vroeger: als het eerste functieargument voor het tweede valt.
         * Dag 2 is vroeger: als het tweede functieargument voor het eerste valt.
         * De datums vallen samen: als beide datums hetzelfde zijn.
         */

        public static string VergelijkDatums(DateTime dag1, DateTime dag2)
        {
            // schrijf hier je code
            return "";
        }

       /* Maak nu een tweede versie die hetzelfde nagaat als de functie VergelijkDatums, maar gebruik
        * hierbij nu de method Compare.
        * Merk op dat beide functies hetzelfde doen, maar het resultaat onder andere vorm returnen. 
        * Afhankelijk van welke functionaliteit er uitgewerkt wordt, zal er een bepaalde werkwijze gekozen worden.
        */

        public static string VergelijkDatumsVersie2(DateTime dag1, DateTime dag2)
        {
            // schrijf hier je code
            return "";
        }

        /* Schrijf een functie die het aantal overblijvende dagen van de maand uit de als argument meegegeven datum geeft. 
        * De datum wordt als functieargument meegegeven. 
        * Tip: Gebruik zoveel mogelijk de properties en methods uit DateTime. Dit kan met 1 lijn code opgelost worden.
        */

        public static int RestAantalDagen(DateTime datum)
        {
            // schrijf hier je code
            return 0;
        }

        /* Schrijf een functie die een datum in het lange datumformaat toont (bv. vrijdag 24 augustus 2018).
         * Tip: Kijk de mogelijke opties bij de method ToString hiervoor na.
         */
        public static string ToonDagLang(DateTime dag)
        {
            return "";
        }

        /* Schrijf een functie die telt hoeveel schrikkeljaren er tussen twee opgegeven jaren zitten (de opgegeven
         * jaartallen neem je mee op in je berekeningen).
         * Tip: Schrikkeljaar in het Engels is 'leapyear' -> Kijk bij de methods of er iets geschikt tussen zit.
         */
        public static int TelSchrikkeljaren(int jaarBegin, int jaarEinde)
        {
            // schrijf hier je code
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Naam Oefening  \t\t Verwacht Resultaat \t\tJouw Resultaat");
            Console.WriteLine("WeekdagGeboorte \t Hangt af van invoer \t\t" + WeekdagGeboorte());
            Console.WriteLine("TelDagenBij \t\t Datum vandaag + 5 dagen \t" + TelDagenBij(5));
            Console.WriteLine("BepaalAantalDagen \t 14697 \t\t\t\t" + BepaalAantalDagen(new DateTime(1990, 2, 5), new DateTime(2030, 5, 3)));
            Console.WriteLine("BepaalAantalDagenVersie2 \t 14697 \t\t\t\t" + BepaalAantalDagenVersie2(new DateTime(1990, 2, 5), new DateTime(2030, 5, 3)));
            Console.WriteLine("VergelijkDatums \t Dag 1 is vroeger \t\t" + VergelijkDatums(new DateTime(2015, 2, 5), new DateTime(2020, 5, 7)));
            Console.WriteLine("VergelijkDatums \t Dag 2 is vroeger \t\t" + VergelijkDatums(new DateTime(2025, 2, 5), new DateTime(2020, 3, 10)));
            Console.WriteLine("VergelijkDatums \t De datums vallen samen \t" + VergelijkDatums(new DateTime(2025, 2, 5), new DateTime(2025, 2, 5)));
            Console.WriteLine("VergelijkDatumsVersie2 \t Dag 1 is vroeger \t\t" + VergelijkDatums(new DateTime(2015, 2, 5), new DateTime(2020, 5, 7)));
            Console.WriteLine("VergelijkDatumsVersie2 \t Dag 2 is vroeger \t\t" + VergelijkDatums(new DateTime(2025, 2, 5), new DateTime(2020, 3, 10)));
            Console.WriteLine("VergelijkDatumsVersie2 \t De datums vallen samen \t" + VergelijkDatums(new DateTime(2025, 2, 5), new DateTime(2025, 2, 5)));
            Console.WriteLine("RestAantalDagen \t 23 \t\t\t\t" + RestAantalDagen(new DateTime(2025, 2, 5)));
            Console.WriteLine("RestAantalDagen \t 24 \t\t\t\t" + RestAantalDagen(new DateTime(2004, 2, 5)));
            Console.WriteLine("RestAantalDagen \t 26 \t\t\t\t" + RestAantalDagen(new DateTime(2025, 3, 5)));
            Console.WriteLine("RestAantalDagen \t 25 \t\t\t\t" + RestAantalDagen(new DateTime(2025, 4, 5)));
            Console.WriteLine("ToonDagLang \t\t zondag 5 april 2020 \t\t" + ToonDagLang(new DateTime(2020, 4, 5)));
            Console.WriteLine("TelSchrikkeljaren \t 4 \t\t\t\t" + TelSchrikkeljaren(2007, 2021));
            Console.WriteLine("TelSchrikkeljaren \t 3 \t\t\t\t" + TelSchrikkeljaren(2008, 2016));
        
            Console.ReadKey();
        }
    }
}
