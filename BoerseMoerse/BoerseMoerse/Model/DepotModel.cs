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
      //  public Dictionary<AktienModel, int> portfolio {get; set;}
        public List<AktienModel> Aktien { get; set; }


        // Methoden

    }
}
