using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.TenovaInterface.PDI
{
    public class Alloy
    {
        public int Id { get; set; }
        public int Alloy_Family_Id { get; set; }
        public string Name { get; set; }
        public int Density { get; set; }
        public bool Active { get; set; }
    }

}
