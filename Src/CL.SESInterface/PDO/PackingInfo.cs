using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.SESInterface.PDO
{
    public class PackingInfo
    {
        public string Coil_Id { get; set; }
        public string Recipe_Code { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
