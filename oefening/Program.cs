using System;

namespace First
{
    class Program
    {
        /* Schrijf een functie waarmee de gebruiker kan nagaan op welke dag van de week hij/zij geboren is. De geboortedatum
         * wordt meegegeven als functieargument. De weekdag waarop deze datum valt, wordt als functieresultaat gegeven.
        */

        public static string WeekdagGeboorte(DateTime geboortedatum)
        {
            // schrijf hier je code
            return "";
        }

        /* Ontwerp een functie die bepaalt hoeveel dagen er tussen twee opgegeven datums liggen. De datums worden meegegeven
         * als functieargument.
         * Tip: Maak bij deze oefening gebruik van een TimeSpan object.
         */

        public static double BepaalAantalDagen(DateTime datum1, DateTime datum2)
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


        /* Schrijf een functie die het aantal overblijvende dagen van de maand geeft. De datum wordt als functieargument
         * meegegeven.
         */

        public static int RestAantalDagen(DateTime datum)
        {
            // schrijf hier je code
            return 0;
        }

        /* Schrijf een functie die een datum in het lange datumformaat toont (bv. vrijdag 24 augustus 2018). 
         */
        public static string ToonDagLang(DateTime dag)
        {
            return "";
        }

        /* Schrijf een functie die telt hoeveel schrikkeljaren er tussen twee opgegeven jaren zitten (de opgegeven
         * jaartallen neem je mee op in je berekeningen).
         */
        public static int TelSchrikkeljaren(int jaarBegin, int jaarEinde)
        {
            // schrijf hier je code
            return 0;
        }

        /*Schrijf een functie die een DateTime object in lokale tijd omzet naar UTC tijd, er een uur bij telt en het object
         * terug omzet naar lokale tijd. Deze verhoogde lokale tijd wordt als functiewaarde gegeven.
         */

        public static DateTime ZetOmTijd(DateTime tijd)
        {
            // schrijf hier je code
            return DateTime.Now;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Naam Oefening  \t\t Verwacht Resultaat \t\tJouw Resultaat");
            Console.WriteLine("WeekdagGeboorte \t Monday \t\t\t" + WeekdagGeboorte(new DateTime(1990, 2, 5)));
            Console.WriteLine("BepaalAantalDagen \t 14697 \t\t\t\t" + BepaalAantalDagen(new DateTime(1990, 2, 5), new DateTime(2030, 5, 3)));
            Console.WriteLine("VergelijkDatums \t Dag 1 is vroeger \t\t" + VergelijkDatums(new DateTime(2015, 2, 5), new DateTime(2020, 5, 7)));
            Console.WriteLine("VergelijkDatums \t Dag 2 is vroeger \t\t" + VergelijkDatums(new DateTime(2025, 2, 5), new DateTime(2020, 3, 10)));
            Console.WriteLine("VergelijkDatums \t De datums vallen samen \t" + VergelijkDatums(new DateTime(2025, 2, 5), new DateTime(2025, 2, 5)));
            Console.WriteLine("RestAantalDagen \t 23 \t\t\t\t" + RestAantalDagen(new DateTime(2025, 2, 5)));
            Console.WriteLine("RestAantalDagen \t 24 \t\t\t\t" + RestAantalDagen(new DateTime(2004, 2, 5)));
            Console.WriteLine("RestAantalDagen \t 26 \t\t\t\t" + RestAantalDagen(new DateTime(2025, 3, 5)));
            Console.WriteLine("RestAantalDagen \t 25 \t\t\t\t" + RestAantalDagen(new DateTime(2025, 4, 5)));
            Console.WriteLine("ToonDagLang \t\t zondag 5 april 2020 \t\t" + ToonDagLang(new DateTime(2020, 4, 5)));
            Console.WriteLine("TelSchrikkeljaren \t 4 \t\t\t\t" + TelSchrikkeljaren(2007, 2021));
            Console.WriteLine("TelSchrikkeljaren \t 3 \t\t\t\t" + TelSchrikkeljaren(2008, 2016));
            Console.WriteLine("ZetOmTijd \t\t 9/03/2020 15:30:25 \t\t" + ZetOmTijd(new DateTime(2020, 3, 9, 14, 30, 25)));

            Console.ReadKey();
        }
    }
}
