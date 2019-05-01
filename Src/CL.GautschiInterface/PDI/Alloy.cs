using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.GautschiInterface.PDI
{
    public class TemperatureLookup
    {
        public float Temperature { get; set; }
        public float ThermalConductivity { get; set; }
        public float ThermalCapacity { get; set; }
    }

    public class Alloy
    {
        public Alloy()
        {
            TemperatureLookups = new List<TemperatureLookup>();
        }

        public long Id { get; set; }
        public float Density { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public float MeltTemperature { get; set; }
        public List<TemperatureLookup> TemperatureLookups { get; set; }
    }
}
