using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CL.TenovaInterface.PDO
{
    public class StitchToCoil
    {
        public StitchToCoil() { }
        public StitchToCoil(string serialNumber, int pass) { this.Serial_Number = serialNumber; this.Pass = pass; }

        public string Serial_Number { get; set; }
        public int Pass { get; set; }
    }

    public class RecipeUsed
    {
        public string Section { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Scrap
    {
        public int Scrap_Level2_Id { get; set; }
        public string Scrap_Name { get; set; }
        public int Start_MM { get; set; }
        public int End_MM { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public string Comment { get; set; }
        public int Reason_Id { get; set; }
    }

    public class InputCoil
    {
        public InputCoil()
        {
            this.Recipe_Used = new List<RecipeUsed>();
            this.Scrap = new List<Scrap>();
        }

        public int Input_Coil_Level2_Id { get; set; }
        public string Serial_Number { get; set; }
        public int Pass { get; set; }
        public int Schedule_Input_Coil_Id { get; set; }
        public int Passline { get; set; }
        public DateTime On_Mandrel_Time { get; set; }
        public DateTime? Processing_Start { get; set; }
        public DateTime? Processing_End { get; set; }
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public StitchToCoil Stitch_To_Coil { get; set; }
        public List<RecipeUsed> Recipe_Used { get; set; }
        public List<Scrap> Scrap { get; set; }
    }

}
