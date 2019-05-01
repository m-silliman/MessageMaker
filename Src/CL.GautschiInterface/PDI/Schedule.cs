using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.GautschiInterface.PDI
{
    public class AnnealingCoil
    {
        public AnnealingCoil()
        {
            Tail_Orientation = "Over";            
        }

        public string Serial_Number { get; set; }
        public long Position { get; set; }
        public long Alloy_Id {get;set;}
        public string Alloy { get; set; }
        public float Gauge { get; set; }
        public float Width { get; set; }
        public long Weight { get; set; }
        public float OD { get; set; }
        public float ID { get; set; }
        public string Tail_Orientation { get; set; }
        public string Comment { get; set; }
        public bool Unavailable { get; set; }
    }

    public class AnnealingCharge
    {
        public AnnealingCharge()
        {
            Coils = new List<AnnealingCoil>();
        }

        public string ChargeId { get; set; }
        public string Furnace { get; set; }
        public string Recipe { get; set; }
        public DateTime Start_Time { get; set; }
        public List<AnnealingCoil> Coils { get; set; }
    }

    public class Schedule
    {
        public long Id { get; set; }
        public string Comment { get; set; }
    }
}
