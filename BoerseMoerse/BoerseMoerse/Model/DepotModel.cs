using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerseMoerse.Model
{

    class DepotModel
    {

        // Properties

        public int DepotID { get; set; }

        public List<AktienModel> Portfolio { get; set; } = new List<AktienModel>();    
    

        // Methoden

    }
}
