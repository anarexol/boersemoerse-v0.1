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
            bool login;
            Console.WriteLine("Willkommen");
            Console.Write("Benutzername : ");
            string name = Console.ReadLine();
            Console.WriteLine("Passwort : ");
            string passwort = Console.ReadLine();
            login =  BoerseMoerse.Controller.BoersianerController.Login(name , passwort);
            if(login==true){
            Console.WriteLine("Login erfolgreich!");}
            if(login==false){
            Console.WriteLine("Login fehlgeschlagen!");}
            Console.ReadLine();

        }
    }
}
