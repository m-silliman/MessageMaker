using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.SESInterface.PDI
{
    public class ScheduleCoil
    {
        public string Coil_Id { get; set; }
        public string Mes_Dest { get; set; }
        public string Recipe_Code { get; set; }
        public string Message_Code { get; set; }
    }

    public class Schedule 
    {
        public Schedule()
        {
            this.Coils = new List<ScheduleCoil>();
        }

        public long Schedule_Id { get; set; }

        public string Status { get; set; }

        public List<ScheduleCoil> Coils { get; set; }
    }
}
