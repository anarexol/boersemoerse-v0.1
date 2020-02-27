using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoerseMoerse.Model;
using BoerseMoerse.Controller;
using BoerseMoerse;

namespace BoerseMoerse
{
    class Program
    {
        static void Main(string[] args)
        {
            AktienModel aktie1 = new AktienModel(){AktienID=111,Name="Tesla",Wert=15};
            AktienModel aktie2 = new AktienModel(){AktienID=112,Name="DeveloperDivision",Wert=150000};
            BoersianerModel boersianer = new BoersianerModel();
            boersianer.ID = 1;
            boersianer.Benutzername = "Fred";
            boersianer.Nachname = "Korn";
            boersianer.Passwort = "koko";
            BoersianerController.list.Add(boersianer);
            BoerseMoerse.View.menu.LoginBenutzer();


        }
    }
}
