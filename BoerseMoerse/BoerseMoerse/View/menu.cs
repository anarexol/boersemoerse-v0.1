using BoerseMoerse.Controller;
using BoerseMoerse.Model;
using System;


namespace BoerseMoerse.View
{
    class menu
    {

        public static BoersianerModel LoginBenutzer()
        {
            ConsoleKeyInfo key;
            string pass = string.Empty;
            Console.WriteLine("Willkommen");
            Console.Write("Benutzername : ");
            string name = Console.ReadLine();
            Console.Write("Passwort : ");
            
            do
            {
                key = Console.ReadKey(true);

                
                if (key.Key != ConsoleKey.Backspace)
                {
                   pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }
            }
            while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            string passwort = pass.Substring(0,pass.Length - 1) ;
            return BoersianerController.Login(name, passwort);
        }

        public static void AuswahlMenü(BoersianerModel boersianer)
        {
            if (boersianer.Login == false)
            {
                Console.WriteLine("Login Fehlgeschlagen ");
                Console.ReadLine();
            }
            else
            {
                int auswahl;
                while (boersianer.Login == true)
                {


                    Console.WriteLine("Was möchten sie tun?\n" +
                                      "[1] Geld Einzahlen \n" +
                                      "[2] Geld Auszahlen \n" +
                                      "[3] Aktie Kaufen \n" +
                                      "[4] Aktie Verkaufen\n" +
                                      "[5] Konostand Anzeigen\n" +
                                      "[6] Depot einsehen\n" +
                                      "[7] Abmelden ");

                    auswahl = Convert.ToInt16(Console.ReadLine());

                    switch (auswahl)
                    {

                        case 1:
                            {
                                Console.WriteLine("Derzeitiger Kontostand : " + BoersianerController.geldAnzeigen(boersianer) + " Euro");
                                int geld = 0;
                                Console.WriteLine("Wie viel Geld möchten Sie einzaheln ? ");
                                geld = Convert.ToInt32(Console.ReadLine());
                                BoersianerController.geldEinzahlen(boersianer, geld);
                                Console.WriteLine("Neuer Kontostand : " + BoersianerController.geldAnzeigen(boersianer) + " Euro");
                                Console.ReadLine();
                                Console.Clear();

                                break;
                            }
                        case 2:
                            {
                                int geld = 0;
                                Console.WriteLine("Wie viel Geld möchten sie abheben? ");
                                Console.WriteLine("Derzeitiger Kontostand :" + BoersianerController.geldAnzeigen(boersianer) + " Euro");
                                BoersianerController.geldAbziehen(boersianer, geld);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine("Welche Aktien möchten Sie kaufen");
                                ShowAktienVerfuegbar();
                                Console.WriteLine("Bitte zum Kauf AktienID oder Companyname angeben");
                                Console.Write("AktienID oder Companyname? =>");
                                string suche = Console.ReadLine();
                                Console.WriteLine("Menge? =>");
                                int menge = Convert.ToInt32(Console.ReadLine());
                                BoersianerController.aktieKaufen(boersianer, suche, menge);
                                Console.Clear();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Welche Aktien möchten Sie verkaufen");
                                ShowPortfolio(boersianer);
                                Console.WriteLine("Bitte zum Kauf AktienID oder Companyname angeben");
                                Console.Write("AktienID oder Companyname? =>");
                                string suche = Console.ReadLine();
                                Console.WriteLine("Menge? =>");
                                int menge = Convert.ToInt32(Console.ReadLine());
                                BoersianerController.aktieVerkaufen(boersianer, suche, menge);
                                Console.Clear();


                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Derzeitiger Kontostand : " + BoersianerController.geldAnzeigen(boersianer) + " Euro");
                                Console.ReadLine();
                                Console.Clear();                              
                                break;
                            }
                        case 6:
                            {

                                ShowPortfolio(boersianer);
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("Sie werden abgemeldet !");
                                boersianer.Login = false;
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                    }

                }
            }
        }


        public static void ShowAktienVerfuegbar()
        {
            Console.WriteLine("Momentan bieten wir folgende Aktien zum Kauf an:");
            foreach (var item in HandelBareAktienModel.AktienPool)
                Console.WriteLine("Company: {0}, AktienID: {1}, Aktueller Kurs: {2} EUR", item.Name, item.AktienID, item.Wert);
        }
    

        public static void ShowPortfolio(BoersianerModel boersianer)
        {
            Console.WriteLine("Sie haben folgende Aktien zum Verkauf");
            foreach (var item in boersianer.Depot.Portfolio)
            {
                Console.WriteLine("Company: {0}, AktienID: {1}, Aktueller Kurs: {2} EUR, Anazhl an Aktien:{3} ", item.Name, item.AktienID, item.Wert, item.MengeImAktDepot);
            }

        }
    }

    
}
