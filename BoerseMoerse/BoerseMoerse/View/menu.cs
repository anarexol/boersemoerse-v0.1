using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoerseMoerse;
using BoerseMoerse.Controller;
using BoerseMoerse.Model;

    
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
           return BoersianerController.Login(name , passwort);
        }

        public static void AuswahlMenü(BoersianerModel boersianer)
        {
            int auswahl;
            
            Console.WriteLine("Was möchten sie tun?\n" +
                              "[1] Geld Einzahlen \n" +
                              "[2] Geld Auszahlen \n" +
                              "[3] Aktie Kaufen \n" +
                              "[4] Aktie Verkaufen\n" +
                              "[5] Konostand Anzeigen\n" +
                              "[6] Depot einsehen\n");
            auswahl = Convert.ToInt16(Console.ReadLine());

            switch (auswahl)
            {

                case 1 :
                    {
                        int geld = 0; 
                        Console.WriteLine("Wie viel Geld möchten Sie einzaheln ? ");
                        geld = Convert.ToInt32(Console.ReadLine());
                        BoersianerController.geldEinzahlen( boersianer ,geld);
                        break; 
                    }
                case 2:
                    {



                        break; 
                    }

            }

        }
    }
}
