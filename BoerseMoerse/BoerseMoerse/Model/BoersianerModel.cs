using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerseMoerse.Model
{
    
    class BoersianerModel
    {

        // Properties

        public int ID { get; set; }
        public string Benutzername { get; set; }
        public string Nachname  { get; set; }
        public KontoModel Konto { get; set; }
        public bool Login { get; set; }
        public string Passwort { get; set; }
        // Methoden
    }
}
