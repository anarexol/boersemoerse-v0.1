using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoerseMoerse.Model
{
    class HandelBareAktienModel
    {
        public static List<AktienModel> AktienPool = new List<AktienModel>();

        public static void AktienHinzufuegen() {
            AktienPool.Add(new AktienModel() { Name = "Google", AktienID = 0001, Wert = 1572.70M, MengeImAktDepot = 200 });
            AktienPool.Add(new AktienModel() { Name = "BitLC", AktienID = 0002, Wert = 14.60M, MengeImAktDepot = 100 }); //test123
        }

        public static void hinzufuegen(AktienModel aktie) {
            AktienPool.Add(aktie);
        }
        

    }
}
