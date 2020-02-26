using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerseMoerse.Model
{
    class KontoModel
    {

        // Properties

        public int KontoID { get; set; }
        public decimal Kapital { get; set; }
        public DepotModel Depot { get; set; }
        public int BoersianerID { get; set; }

        // Methoden 
    }
}
