using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.SESInterface.PDO
{
    public class CoilReceived
    {
        public string Coil_Id { get; set; }
        public long Width { get; set; }
        public long Diameter { get; set; }
        public long Coil_Orientation { get; set; }
        public string Message_Code { get; set; }
    }
}
