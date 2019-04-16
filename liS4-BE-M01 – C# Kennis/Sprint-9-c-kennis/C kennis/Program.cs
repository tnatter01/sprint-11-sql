using System;
using System.Collections.Generic;

namespace C_kennis
{
    internal class Program
    {
        //Niewe struct met naam mp3speler
        private struct mp3speler
        {
            //Declaratie van de variabelen voor de struct
            public int intID, intMBSize, intVoorraad;
            public string strMake, strModel;
            public double dblPrice;
        }

        //Nieuwe List met naam mp3list, gevuld met struct mp3speler
        private static List<mp3speler> mp3list = new List<mp3speler>
        {
            //Declaratie van 5 mp3spelers
                    new mp3speler() {intID = 1, strMake= "GET technologies .inc", strModel = "HF 410", intMBSize = 4096, dblPrice = 129.95, intVoorraad =  500},
                    new mp3speler() {intID = 2, strMake= "Far & Loud", strModel = "XM 600", intMBSize = 8192, dblPrice = 224.95, intVoorraad =  500},
                    new mp3speler() {intID = 3, strMake= "Innotivative", strModel = "Z3", intMBSize = 512, dblPrice = 79.95, intVoorraad =  500},
                    new mp3speler() {intID = 4, strMake= "Resistance S.A.", strModel = "3001", intMBSize = 4096, dblPrice = 124.95, intVoorraad =  500},
                    new mp3speler() {intID = 5, strMake= "CBA", strModel = "NXT volume", intMBSize = 2048, dblPrice = 159.05, intVoorraad =  500},
        };
        //methode met naam nieuwemp3
        public static void nieuwemp3()
        {
            //for loop zolang als i < aantal in mp3list
            for (int i = 0; i < mp3list.Count; i++)
            {
                //Schrijft alle variabelen van alles uit mp3list in console
                Console.WriteLine("\nID = {0}", mp3list[i].intID);
                Console.WriteLine("Merk = {0}", mp3list[i].strMake);
                Console.WriteLine("Model = {0}", mp3list[i].strModel);
                Console.WriteLine("Capaciteit = {0}", mp3list[i].intMBSize);
                Console.WriteLine("Prijs = {0}", mp3list[i].dblPrice);
            }
            Console.WriteLine("Druk op 8 om terug te keren naar het menu.");
            //Leest welke toets er wordt ingedrukt en als dat 8 is roept hij functie ShowMenu aan
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D8) { ShowMenu(); }
        }
        //methode met naam showVoorraad
        public static void showVoorraad()
        {
            //for loop zolang als i < aantal in mp3list
            for (int i = 0; i < mp3list.Count; i++)
            {
                //Schrijft ID en voorraad van alles uit mp3list in console
                Console.WriteLine("\nID: " + mp3list[i].intID);
                Console.WriteLine("Voorraad: " + mp3list[i].intVoorraad + " stuks");
            }
            Console.WriteLine("Druk op 8 om terug te keren naar het menu.");
            //Leest welke toets er wordt ingedrukt en als dat 8 is roept hij functie ShowMenu aan
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D8) { ShowMenu(); }
        }
        public static void muteerVoorraad()
        {
            int intMuteerID, intMutatie;
            string strPlusMin;
            Console.Write("Geef het ID op: ");
            intMuteerID = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < mp3list.Count; i++)
            {
                if (mp3list[i].intID == intMuteerID)
                {
                    Console.Write("\nID: " + mp3list[i].intID);
                    Console.Write("\nVoorraad: " + mp3list[i].intVoorraad + " stuks\n");
                    Console.Write("Geef de mutatie op: ");
                    intMutatie = Convert.ToInt32(Console.ReadLine());
                    Console.Write("+/- ");
                    strPlusMin = Convert.ToString(Console.ReadLine());
                    if (intMutatie >= mp3list[i].intVoorraad)
                    {
                        Console.WriteLine("Mutatie niet uitgevoerd: voorraad mag niet negatief worden.");
                        break;
                    }
                    mp3speler newmp3 = new mp3speler();
                    newmp3.intID = mp3list[i].intID;
                    newmp3.strMake = mp3list[i].strMake;
                    newmp3.strModel = mp3list[i].strModel;
                    newmp3.intMBSize = mp3list[i].intMBSize;
                    newmp3.dblPrice = mp3list[i].dblPrice;

                    switch (strPlusMin)
                    {
                        case ("+"):
                            newmp3.intVoorraad = mp3list[i].intVoorraad + intMutatie;
                            mp3list[i] = newmp3;
                            Console.WriteLine("Nieuwe voorraad: " + mp3list[i].intVoorraad);
                            break;
                        case ("-"):
                            newmp3.intVoorraad = mp3list[i].intVoorraad - intMutatie;
                            mp3list[i] = newmp3;
                            Console.WriteLine("Nieuwe voorraad: " + mp3list[i].intVoorraad);
                            break;
                    }
                    Console.WriteLine("Druk op 8 om terug te keren naar het menu.");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.D8) { ShowMenu(); }
                }
            }
        }

        public static void showStatistieken()
        {
            int intTotaalVoorraad = 0;
            double dblTotaalWaarde = 0;
            double dblGemiddeldeWaarde = 0;
                double dblBestePrijsPerMB = 0;
            for (int i = 0; i < mp3list.Count; i++)
            {
                intTotaalVoorraad = intTotaalVoorraad + mp3list[i].intVoorraad;
                dblTotaalWaarde = intTotaalVoorraad * mp3list[i].dblPrice;
                Console.WriteLine("De totale waarde van de mp3 spelers dat in voorraad is: " + dblTotaalWaarde);
                dblGemiddeldeWaarde = dblTotaalWaarde / intTotaalVoorraad;
            }

            Console.WriteLine("Het totale aantal mp3 spelers dat in voorraad is: " + intTotaalVoorraad);
            Console.WriteLine("De totale waarde van de mp3 spelers dat in voorraad is: " + dblTotaalWaarde);
            Console.WriteLine("De gemiddelde prijs van een mp3 speler: " + dblGemiddeldeWaarde);
        }

        public static void ShowMenu()
        {
            //Declaratie van de variabelen
            string strGekozenMenu;

            Console.WriteLine("SoundSharp\n");
            Console.WriteLine("1. Overzicht mp3 spelers");
            Console.WriteLine("2. Overzicht voorraad");
            Console.WriteLine("3. Muteer voorraad");
            Console.WriteLine("4. Statistieken");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            Console.WriteLine("8. Toon menu");
            Console.WriteLine("9. Exit");

            Console.WriteLine("Kies een menu door het getal in te voeren: ");
            strGekozenMenu = Console.ReadKey().KeyChar.ToString();

            switch (strGekozenMenu)
            {
                case "1":
                    nieuwemp3();
                    break;
                case "2":
                    showVoorraad();
                    break;
                case "3":
                    muteerVoorraad();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    Console.WriteLine("\ngekozen actie: 9. Exit");
                    break;
                default:
                    Console.WriteLine("\nOngeldige keuze");
                    return;
                    break;
            }
        }

        public static void Login()
        {
            //Declaratie van de variabelen
            const string strWachtwoord = "SHARPSOUND";
            string strNaam, strInputWachtwoord;
            int intPoging = 1;

            //Naam opvragen
            Console.Write("Geef je naam op: ");
            strNaam = Console.ReadLine();

            //Welkomstbericht weergeven
            do
            {
                switch (intPoging)
                {
                    case 1:
                        //Wachtwoord opvragen
                        Console.Write("Voer het wachtwoord in: ");
                        strInputWachtwoord = Console.ReadLine();

                        if (strInputWachtwoord == strWachtwoord)
                        {
                            Console.WriteLine("Welkom bij SoundSharp " + strNaam);
                            ShowMenu();
                            return;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Password is onjuist.");
                            Console.ResetColor();
                            intPoging++;
                            break;
                        }

                    case 2:
                        Console.WriteLine("Poging " + intPoging + " van 3");
                        Console.Write("Voer het wachtwoord in: ");
                        strInputWachtwoord = Console.ReadLine();
                        if (strInputWachtwoord == strWachtwoord)
                        {
                            Console.WriteLine("Welkom bij SoundSharp " + strNaam);
                            ShowMenu();
                            return;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Password is onjuist.");
                            Console.ResetColor();
                            intPoging++;
                            break;
                        }

                    case 3:
                        Console.WriteLine("Poging " + intPoging + " van 3");
                        Console.WriteLine("LET OP: Laatste poging! \nVoer het wachtwoord in: ");
                        strInputWachtwoord = Console.ReadLine();
                        if (strInputWachtwoord == strWachtwoord)
                        {
                            Console.WriteLine("Welkom bij SoundSharp " + strNaam);
                            ShowMenu();
                            return;
                            break;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Password is onjuist.");
                            Console.ResetColor();
                            intPoging++;
                            break;
                        }

                }
            }

            while (intPoging < 4);
        }

        private static void Main(string[] args)
        {
            showStatistieken();
            Login();
            Console.ReadLine();
        }
    }
}
