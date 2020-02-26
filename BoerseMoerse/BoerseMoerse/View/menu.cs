using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerseMoerse.View
{
    class menu
    {

        public static void LoginBenutzer()
        {
            Console.WriteLine("Willkommen");
            Console.Write("Benutzername : ");
            string name = Console.ReadLine();
            Console.WriteLine("Passwort : ");
            string passwort = Console.ReadLine();
            BoerseMoerse.Controller.BoersianerController.Login(name , passwort);


        }
    }
}
