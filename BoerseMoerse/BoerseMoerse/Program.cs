﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoerseMoerse.Model;
using BoerseMoerse.Controller;
using BoerseMoerse.View;

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
            BoersianerModel boersianer1 = new BoersianerModel();
            boersianer1.ID = 2;
            boersianer1.Benutzername = "Semi";
            boersianer1.Passwort = "dual";
            BoersianerController.list.Add(boersianer1);
            BoersianerController.list.Add(boersianer);
            menu.AuswahlMenü(menu.LoginBenutzer());

        }
    }
}
