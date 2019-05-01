using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.GautschiInterface.PDO
{
    public class CoilPosition
    {
        public string Serial_Number { get; set; }
        public long Position { get; set; }
    }

    public class RecipeValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Measure
    {
        public string Name { get; set; }
        public float Max { get; set; }
        public float Min { get; set; }
        public float StdDev { get; set; }
        public float Sigma { get; set; }
    }

    public class Consumption
    {
        public string Name { get; set; }
        public float Value { get; set; }
    }

    public class Downtime
    {
        public long Reason_Id { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public bool Scheduled { get; set; }
        public string Discipline { get; set; }
        public string Comment { get; set; }
    }

    public class ChargeStatus
    { 
        public ChargeStatus()
        {
            this.Coils = new List<CoilPosition>();
            this.Recipe = new List<RecipeValue>();
            this.Consumptions = new List<Consumption>();
            this.Recipe = new List<RecipeValue>();
        }

        public string ChargeId { get; set; }
        public string Furnace { get; set; }        
        public DateTime Start_Time { get; set; }
        public DateTime? End_Time { get; set; }
        public string Dispostion { get; set; }
        public long? Disposition_Reason_Id { get; set; }
        public List<CoilPosition> Coils { get; set; }
        public List<Measure> Measures { get; set; }
        public List<Consumption> Consumptions { get; set; }
        public List<RecipeValue> Recipe { get; set; }
    }
}
