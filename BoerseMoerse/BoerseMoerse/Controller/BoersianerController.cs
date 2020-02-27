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

        public static decimal geldAnzeigen(BoersianerModel boersianer){
            return boersianer.Konto.Kapital;
        }

        


        public static void aktieKaufen(BoersianerModel boersianer, string suchbegriff, int menge)
        {
           
            List<AktienModel> tempList = HandelBareAktienModel.AktienPool;

            var numQuery = tempList.Where(x=>x.AktienID == Convert.ToInt32(suchbegriff)).First();
               

            ((AktienModel)numQuery).MengeImAktDepot = menge ;
            Console.WriteLine(numQuery.Name);
            boersianer.Depot.Portfolio.Add(numQuery);


            boersianer.Konto.Kapital -= numQuery.Wert * menge;      

        }
        public static void aktieVerkaufen(BoersianerModel boersianer,string suchbegriff, int menge)
        {
            List<AktienModel> tempList = HandelBareAktienModel.AktienPool;

            var numQuery = tempList.Where(x => x.AktienID == Convert.ToInt32(suchbegriff)).First();


            ((AktienModel)numQuery).MengeImAktDepot = menge;
            Console.WriteLine(numQuery.Name);
            boersianer.Depot.Portfolio.Remove(numQuery);


           
            boersianer.Konto.Kapital +=numQuery.Wert*menge; 
        }

        public static BoersianerModel Login(string name, string passwort)
        {
            foreach (var item in list)
            {
                
                if (name == item.Benutzername && passwort == item.Passwort)
                { 
                    item.Login = true;
                    return item;
                   
                }
               
            }

            BoersianerModel b = new BoersianerModel();
            return b;
        
        }
    }
}
