using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoerseMoerse.Model
{
    class HandelBareAktienModel
    {
        static List<AktienModel> AktienPool = new List<AktienModel>();

        public static void hinzufuegen(AktienModel aktie) {
            AktienPool.Add(aktie);
        }
        

    }
}
