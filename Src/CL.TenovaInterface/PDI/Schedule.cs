using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.TenovaInterface.PDI
{
    public class InputCoilRecipe
    {
        public int Schedule_Input_Coil_Id { get; set; }
        public string Section { get; set; }
        public string Recipe_Number { get; set; }
    }

    public class OutputCoil
    {
        public int Schedule_Output_Coil_Id { get; set; }
        public int Schedule_Input_Coil_Id { get; set; }
        public int Piece_Number { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Weight { get; set; }
        public string Outside_Diameter { get; set; }
        public string Spool_Type { get; set; }
        public string Rewind_Type { get; set; }
        public string Rewind_Orientation { get; set; }
        public int Product_Id { get; set; }
    }

    public class Sample
    {
        public string Location { get; set; }
        public int Sequence { get; set; }
        public int Length { get; set; }
    }

    public class InputCoil
    {
        public InputCoil()
        {
            this.Output_Coils = new List<OutputCoil>();
            this.Input_Coil_Recipes = new List<InputCoilRecipe>();
            this.Samples = new List<Sample>();
        }

        public int Id { get; set; }
        public string Serial_Number { get; set; }
        public int Schedule_Id { get; set; }
        public int Sequence { get; set; }
        public int Alloy_Id { get; set; }
        public double Gauge { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int Pass { get; set; }
        public string Tail_Orientation { get; set; }
        public bool Unavailable { get; set; }
        public string Remarks { get; set; }
        public string Production_Order_Number { get; set; }
        public string Scrap_Priority { get; set; }
        public bool Hard_Practice { get; set; }
        public bool Transition_Coil { get; set; }
        public int Transition_Head_Length { get; set; }
        public int Transition_Tail_Length { get; set; }
        public string Master_Setup_Id { get; set; }
        public List<InputCoilRecipe> Input_Coil_Recipes { get; set; }
        public List<OutputCoil> Output_Coils { get; set; }
        public List<Sample> Samples { get; set; }
    }

    public class Schedule
    {
        public Schedule()
        {
            this.Coils = new List<InputCoil>();
        }

        public int Id { get; set; }
        public string Comment { get; set; }
        public List<InputCoil> Coils { get; set; }
    }
}
