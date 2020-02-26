using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoerseMoerse.Model;

namespace BoerseMoerse.Controller
{
    static class AktuelleKursNotierung {
        static void AktieHinzufuegen() {
            new AktienModel() { Name = "Google", AktienID = 0001, Wert = 0 };
            new AktienModel() { Name = "BitLC", AktienID = 0002, Wert = 0 }; //test123
        }
    }
}
