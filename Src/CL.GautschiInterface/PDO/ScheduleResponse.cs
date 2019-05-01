using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.GautschiInterface.PDO
{
    public class InputCoilStatus
    {
        public string Serial_Number { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }

    public class ValidationResult
    {
        public ValidationResult()
        {
            this.Coils = new List<InputCoilStatus>();
        }

        public string ChargeId { get; set; }
        public string FeedbackText { get; set; }
        public string Status { get; set; }

        public List<InputCoilStatus> Coils { get; set; }
    }

    public class ScheduleResponse
    {
        public ScheduleResponse()
        {
            this.ValidationResults = new List<ValidationResult>();
        }

        public long Id { get; set; }
        public string Status { get; set; }
        public List<ValidationResult> ValidationResults { get; set; }
    }
}
