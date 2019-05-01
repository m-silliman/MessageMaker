using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.GautschiInterface.PDO
{
    public class ChargeCancellation
    {
        public string ChargeId { get; set; }
        public long Reason_Id { get; set; }
        public string Comment { get; set; }
        public DateTime Cancel_Time { get; set; }
    }
}
