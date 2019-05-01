using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.TenovaInterface.PDO
{
    public class ValidationResult
    {
        public int Schedule_Input_Coil_Id { get; set; }
        public string Feedback_Text { get; set; }
        public ScheduleStatusEnum Status { get; set; }
    }

    public class ScheduleResponse
    {
        public ScheduleResponse()
        {
            this.ValidationResults = new List<ValidationResult>();
        }

        public int Schedule_Id { get; set; }
        public ScheduleStatusEnum Status { get; set; }
        public List<ValidationResult> ValidationResults { get; set; }
    }

   
}
