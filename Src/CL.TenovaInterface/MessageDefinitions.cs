using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CL.TenovaInterface
{
    /* ACK Message */
    public class AcknowledgementMessage : Message
    {
        public AcknowledgementMessage() : base(MessageDefinitions.ACKNOWLEDGEMENT)
        {
            this.Body = new Acknowledgement();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Acknowledgement Body { get; set; }
    }

    /* PDI Messages */
    public class AlloySyncMessage : Message //<PDI.Alloy[]>
    {
        public AlloySyncMessage() : base(MessageDefinitions.ALLOY_SYNC)
        {
            this.Body = new List<PDI.Alloy>();
        }

        public List<PDI.Alloy> Body { get; set; }

    }

    public class EmployeeSyncMessage : Message
    {
        public EmployeeSyncMessage() : base(MessageDefinitions.EMPLOYEE_SYNC)
        {
            this.Body = new List<PDI.Employee>();
        }

        public List<PDI.Employee> Body {get;set;}
    }

    public class ReasonSyncMessage : Message
    {
        public ReasonSyncMessage() : base(MessageDefinitions.REASON_SYNC)
        {
            this.Body = new List<PDI.Reason>();
        }

        public List<PDI.Reason> Body { get; set; }
    }

    public class ScrapCategorySyncMessage : Message
    {
        public ScrapCategorySyncMessage() : base(MessageDefinitions.SCRAP_CATEGORY_SYNC)
        {
            this.Body = new List<PDI.ScrapCategory>();
        }

        public List<PDI.ScrapCategory> Body { get; set; }
    }

    public class ScheduleValidateMessage : Message
    {
        public ScheduleValidateMessage() : base(MessageDefinitions.SCHEDULE)
        {
            this.Body = new PDI.Schedule();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDI.Schedule Body { get; set; }
    }

    /* PDO Messages */
    public class ScheduleResponseMessage : Message
    {
        public ScheduleResponseMessage() : base(MessageDefinitions.SCHEDULE_RESPONSE)
        {
            this.Body = new PDO.ScheduleResponse();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.ScheduleResponse Body { get; set; }
    }

    public class InputOnlineMessage : Message
    {
        public InputOnlineMessage() : base(MessageDefinitions.INPUT_ONLINE)
        {
            this.Body = new PDO.InputCoil();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.InputCoil Body { get; set; }

    }

    public class InputQueuedMessage : Message
    {
        public InputQueuedMessage() : base(MessageDefinitions.INPUT_QUEUED)
        {
            this.Body = new PDO.InputCoil();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.InputCoil Body { get; set; }

    }

    public class InputWorkedMessage : Message
    {
        public InputWorkedMessage() : base(MessageDefinitions.INPUT_WORKED)
        {
            this.Body = new PDO.InputCoil();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.InputCoil Body { get; set; }

    }

    public class InputStartProcessingMessage : Message
    {
        public InputStartProcessingMessage() : base(MessageDefinitions.INPUT_PROCESSING_START)
        {
            this.Body = new PDO.InputCoil();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.InputCoil Body { get; set; }

    }

    public class InputEndProcessingMessage : Message
    {
        public InputEndProcessingMessage() : base(MessageDefinitions.INPUT_PROCESSING_END)
        {
            this.Body = new PDO.InputCoil();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.InputCoil Body { get; set; }

    }

    public class OutputWorkedMessage : Message
    {
        public OutputWorkedMessage() : base(MessageDefinitions.OUTPUT_WORKED)
        {
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.OutputCoil Body { get; set; }

    }


    public class DowntimeMessage : Message
    {
        public DowntimeMessage() : base(MessageDefinitions.DOWNTIME)
        {
            Body = new PDO.Downtime();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.Downtime Body { get; set; }

    }

    public class SampleCreatedMessage : Message
    {
        public SampleCreatedMessage() : base(MessageDefinitions.SAMPLE_CREATED)
        {
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.Sample Body { get; set; }

    }

    public class ScrapRegistrationMessage : Message
    {
        public ScrapRegistrationMessage() : base(MessageDefinitions.SCRAP_REGISTRATION)
        {
            this.Body = new PDO.ScrapRegistration();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.ScrapRegistration Body { get; set; }

    }


    public static class MessageDefinitions
    {
        // COMMON
        public static string ACKNOWLEDGEMENT = "Acknowledgement";

        // PDI
        public static string ALLOY_SYNC = "Alloy_Sync";
        public static string EMPLOYEE_SYNC = "Employee_Sync";
        public static string REASON_SYNC = "Reason_Sync";
        public static string SCRAP_CATEGORY_SYNC = "Scrap_Category_Sync";
        public static string SCHEDULE = "Schedule";
        public static string STOCK_AVAILABLE = "Stock_Available";

        // PDO
        public static string SCHEDULE_RESPONSE = "Schedule_Response";
        public static string INPUT_QUEUED = "Input_Queued";
        public static string INPUT_ONLINE = "Input_Online";
        public static string INPUT_PROCESSING_START = "Input_Processing_Start";
        public static string INPUT_PROCESSING_END = "Input_Processing_End";
        public static string DOWNTIME = "Downtime";
        public static string SAMPLE_CREATED = "Sample_Created";
        public static string OUTPUT_WORKED = "Output_Worked";
        public static string INPUT_WORKED = "Input_Worked";
        public static string SCRAP_REGISTRATION = "Scrap_Registration";

    }
}
