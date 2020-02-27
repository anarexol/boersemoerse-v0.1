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
        public static
        List<BoersianerModel> list = new List<BoersianerModel>();


        public static void geldEinzahlen(BoersianerModel boersianer, decimal betrag)
        {
            boersianer.Konto.Kapital += betrag;
        }
      
        public static void geldAbziehen(BoersianerModel boersianer, decimal betrag)
        {
            boersianer.Konto.Kapital-=betrag;
        }
        public static void aktieKaufen(BoersianerModel boersianer, AktienModel aktie, int menge)
        {            
            for (int i = 0; i < menge; i++)
			{
                boersianer.Konto.Depot.Aktien.Add(aktie);
			}
            
            boersianer.Konto.Kapital-=aktie.Wert;
        }
        public static void aktieVerkaufen(BoersianerModel boersianer, AktienModel aktie)
        {
            boersianer.Konto.Depot.Aktien.Remove(aktie);
            boersianer.Konto.Kapital+=aktie.Wert;
        }

        public static bool Login(string name, string passwort)
        {
            foreach (var item in list)
            {
                
                if (name == item.Benutzername && passwort == item.Passwort)
                {
                    item.Login = true;
                    return true;
                   
                }
               
            }

            return false; 
        
        }
    }
}
