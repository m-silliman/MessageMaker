using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.TenovaInterface.PDO
{

    public class Flaw
    {
        public int Flaw_Note_Level2_Id { get; set; }
        public DateTime Create_Time { get; set; }
        public string Note { get; set; }
        public int Start_MM { get; set; }
        public int End_MM { get; set; }
        public int Reason_Id { get; set; }
    }

    public class OutputCoil
    {
        public OutputCoil()
        {
            this.Flaws = new List<Flaw>();
        }

        public int Output_Coil_Level2_Id { get; set; }
        public int Schedule_Output_Coil_Id { get; set; }
        public string Serial_Number { get; set; }
        public int Pass { get; set; }
        public int Piece_Number { get; set; }
        public int Pass_Line { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public double Gauge { get; set; }
        public int Calculated_Weight { get; set; }
        public int Outside_Diameter { get; set; }
        public string Disposition_Status { get; set; }
        public int Disposition_Reason_Id { get; set; }
        public string Disposition_Comment { get; set; }
        public int Disposition_Employee_Id { get; set; }
        public string Rewind_Orientation { get; set; }
        public int Unwind_Start_MM { get; set; }
        public int Unwind_End_MM { get; set; }
        public string Rewind_Type { get; set; }
        public string Status { get; set; }
        public int Product_Id { get; set; }
        public int Exit_Temperature { get; set; }
        public bool Displaced_Coil { get; set; }
        public List<Flaw> Flaws { get; set; }
    }
}
