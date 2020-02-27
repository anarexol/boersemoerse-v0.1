using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoerseMoerse.Model;
using System.Threading;

namespace BoerseMoerse.Controller {

    static class AktuelleKursNotierung {

        public static Random rndm = new Random();

        static void AktieHinzufuegen() {
            new AktienModel() { Name = "Google", AktienID = 0001, Wert = 0 };
            new AktienModel() { Name = "BitLC", AktienID = 0002, Wert = 0 }; //test123
        }

        static void Wertangleichung(AktienModel aktie, BoersianerModel boersianer)
        {
            foreach (var item in boersianer.Konto.Depot.Aktien)//Die Aktienliste muss noch an das Dictionary von Martin angepasst werden.
	            {
                    item.Wert=aktie.Wert;
	            }
        }

        static void Kursänderung(ref AktienModel aktie){
            while(true){

                decimal i= rndm.Next(-1,1);                
                aktie.Wert+=i;
                int x = rndm.Next(1000,10000);
                Thread.Sleep(x);
            }
        }
    }
}