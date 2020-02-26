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
