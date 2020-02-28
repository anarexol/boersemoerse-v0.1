using BoerseMoerse.Controller;
using BoerseMoerse.Model;
using System;
using System.Threading;


namespace BoerseMoerse.View
{
    class menu
    {

        public static BoersianerModel LoginBenutzer()
        {
            ConsoleKeyInfo key;
            string pass = string.Empty;
            Console.WriteLine("[0]Neuen Benutzer Anlegen");
            Console.WriteLine("[1] Anmelden ");
            int auswahl = Convert.ToInt16(Console.ReadLine());

            switch (auswahl)
            {

                case 0:
                    {                      
                        BoersianerController.list.Add(BenutzerErstellen());
                        break;
                    }

            }

            Console.WriteLine("Willkommen");
            Console.Write("Benutzername: ");    
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
                                      "[0] Benutzer Verwalten\n"+
                                      "[1] Geld Einzahlen \n" +
                                      "[2] Geld Auszahlen \n" +
                                      "[3] Aktie Kaufen \n" +
                                      "[4] Aktie Verkaufen\n" +
                                      "[5] Kontostand Anzeigen\n" +
                                      "[6] Depot einsehen\n" +
                                      "[7] Abmelden \n");

                    Console.Write("==> ");
                    auswahl = Convert.ToInt16(Console.ReadLine());

                    switch (auswahl)
                    {


                        case 0: 
                            {
                                BenutzerVerwalten(boersianer);




                                break;
                            }


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
                            {   Console.WriteLine();
                                Console.WriteLine("Welche Aktien möchten Sie kaufen");
                                ShowAktienVerfuegbar();
                                Console.WriteLine();
                                Console.Write("Bitte zum Kauf AktienID angeben ==> ");
                                string suche = Console.ReadLine();
                                Console.Write("Menge? ==> ");
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
            Console.WriteLine("Momentan bieten wir folgende Aktien zum Kauf an:\n");
            foreach (var item in HandelBareAktienModel.AktienPool)
                Console.WriteLine("Company: {0}, AktienID: {1}, Aktueller Kurs: {2} EUR", item.Name, item.AktienID, item.Wert);
        }
    

        public static void ShowPortfolio(BoersianerModel boersianer)
        {
            Console.WriteLine("Aktien im Depot:\n");
            decimal temp = 0;
            foreach (var item in boersianer.Depot.Portfolio)
            {
                Console.WriteLine("Company: {0}, AktienID: {1}, Aktueller Kurs: {2} EUR, Anzahl:{3}, Gesamtwert: {4} ", item.Name, item.AktienID, item.Wert, item.MengeImAktDepot, item.Wert*item.MengeImAktDepot);
                temp += item.Wert*item.MengeImAktDepot;

            }
            Console.WriteLine("\nGesamtwert Ihres Depots: {0} EUR", temp);
        }

        public static BoersianerModel BenutzerErstellen()
        {
            BoersianerModel benutzer = new BoersianerModel(); 
            Console.WriteLine("Wie lautet ihr Benutzer Name ?");
            benutzer.Benutzername = Console.ReadLine();
            Console.WriteLine("Geben sie ihr Passwort ein. ");
            benutzer.Passwort = Console.ReadLine();

            return benutzer; 
        } 
        public static void BenutzerVerwalten(BoersianerModel boersianer)
        {
            Console.WriteLine("Was wollen sie tun ?\n" +
                              "[1] Benutzername ändern ?\n" +
                              "[2] Passwort ändern ?\n" +
                              "[3] Benutzer Löschen ?");
            int auswahl = Convert.ToInt16(Console.ReadLine());
            switch (auswahl)
            {
                case 1:
                    {
                        Console.WriteLine($"Alter Benutzername : {boersianer.Benutzername}");
                        Console.Write("Bitte geben Sie ihren neuen Benutzernamen ein : ");
                        boersianer.Benutzername = Console.ReadLine();
                        Console.WriteLine($"Neuer Benutzername : {boersianer.Benutzername}");
                        Console.ReadLine();
                        Console.Clear();
                        break; 
                    }

                case 2:
                    {
                        ConsoleKeyInfo key;
                        string pass = string.Empty;
                        Console.WriteLine($"Bitte geben sie ihr neues Passwort ein :");
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
                        string passwort = pass.Substring(0, pass.Length - 1);
                        if (boersianer.Passwort != passwort)
                        {
                            boersianer.Passwort = passwort;
                        }
                        else
                        {
                            Console.WriteLine("Ihr neues Passwort entspricht ihrem alten Passwort");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;
                    }
            }





        } 
    }

    
}
