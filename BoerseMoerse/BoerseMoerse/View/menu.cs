using BoerseMoerse.Controller;
using BoerseMoerse.Model;
using System;


namespace BoerseMoerse.View
{
    class menu
    {

        public static BoersianerModel LoginBenutzer()
        {
            Console.WriteLine("Willkommen");
            Console.Write("Benutzername : ");
            string name = Console.ReadLine();
            Console.Write("Passwort : ");
            string passwort = Console.ReadLine();
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



                                break;
                            }
                        case 4:
                            {




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
    }
}
