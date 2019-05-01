using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.TenovaInterface.PDO
{
    public class Reason
    {
        public int Reason_Id { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public bool Scheduled { get; set; }
        public string Discipline { get; set; }
        public string Operator_Comments { get; set; }
    }

    public class Downtime
    {
        public Downtime()
        {
            this.Reasons = new List<Reason>();
        }

        public string Serial_Number { get; set; }
        public int Pass { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public List<Reason> Reasons { get; set; }
        public string Type { get; set; }
    }
}
