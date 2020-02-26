using BoerseMoerse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerseMoerse.Controller
{
    class BoersianerController
    {
        
        public static void geldEinzahlen(BoersianerModel boersianer, decimal betrag)
        {
            boersianer.Konto.Kapital+=betrag;
        }
        public static void geldAbziehen(BoersianerModel boersianer, decimal betrag)
        {
            boersianer.Konto.Kapital-=betrag;
        }
        public static void aktieKaufen(BoersianerModel boersianer, AktienModel aktie, int menge)
        {
            
            boersianer.Konto.Kapital-=aktie.Wert*menge;
        }
        public static void aktieVerkaufen(BoersianerModel boersianer, AktienModel aktie, int menge)
        {
            boersianer.Konto.Kapital+=aktie.Wert*menge;
        }
    }
}
