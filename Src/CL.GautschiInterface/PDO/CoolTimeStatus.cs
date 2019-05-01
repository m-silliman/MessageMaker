using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.GautschiInterface.PDO
{
    public class CoolTimeStatus
    {
        public string ChargeId { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime Expected_Complete_Time { get; set; }
    }
}
