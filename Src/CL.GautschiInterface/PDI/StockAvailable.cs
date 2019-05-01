using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.GautschiInterface.PDI
{
    public class StockAvailable
    {
        public string Serial_Number { get; set; }
        public long Pass { get; set; }
        public bool Available { get; set; }
    }
}
