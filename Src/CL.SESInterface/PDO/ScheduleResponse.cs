using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.SESInterface.PDO
{
    public class ValidationResult
    {
        public string Coil_Id { get; set; }
        public string Feedback_Text { get; set; }
        public string Status { get; set; }
    }

    public class ScheduleResponse
    {
        public ScheduleResponse()
        {
            this.ValidationResults = new List<ValidationResult>();
        }

        public long Schedule_Id { get; set; }
        public string Status { get; set; }
        public List<ValidationResult> ValidationResults { get; set; }
    }
}
