using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CL.GautschiInterface
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
    public class AlloySyncMessage : Message
    {
        public AlloySyncMessage() : base(MessageDefinitions.ALLOY_SYNC)
        {
            this.Body = new List<PDI.Alloy>();
        }

        public List<PDI.Alloy> Body { get; set; }
    }

    public class ReasonSyncMessage : Message
    {
        public ReasonSyncMessage() : base(MessageDefinitions.REASON_SYNC)
        {
            this.Body = new List<PDI.Reason>();
        }

        public List<PDI.Reason> Body { get; set; }
    }

    public class ScheduleMessage : Message
    {
        public ScheduleMessage() : base(MessageDefinitions.SCHEDULE)
        {
            this.Body = new PDI.Schedule();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDI.Schedule Body { get; set; }
    }

    public class StockAvailableMessage : Message
    {
        public StockAvailableMessage() : base(MessageDefinitions.STOCK_AVAILABLE)
        {
            this.Body = new PDI.Schedule();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDI.Schedule Body { get; set; }
    }


    /* PDO Messages */
    public class ScheduleResponse : Message
    {
        public ScheduleResponse() : base(MessageDefinitions.SCHEDULE_RESPONSE)
        {
            this.Body = new PDO.ScheduleResponse();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.ScheduleResponse Body { get; set; }
    }

    public class ConfirmMessage : Message
    {
        public ConfirmMessage() : base(MessageDefinitions.CONFIRM)
        {
            this.Body = new PDO.ChargeStatus();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.ChargeStatus Body { get; set; }
    }


    public class CancelMessage : Message
    {
        public CancelMessage() : base(MessageDefinitions.CANCEL)
        {
            this.Body = new PDO.ChargeStatus();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.ChargeStatus Body { get; set; }
    }

    public class HeatMessage : Message
    {
        public HeatMessage() : base(MessageDefinitions.HEAT)
        {
            this.Body = new PDO.ChargeStatus();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.ChargeStatus Body { get; set; }
    }

    public class AbortMessage : Message
    {
        public AbortMessage() : base(MessageDefinitions.ABORT)
        {
            this.Body = new PDO.ChargeStatus();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.ChargeStatus Body { get; set; }
    }


    public class CoolMessage : Message
    {
        public CoolMessage() : base(MessageDefinitions.COOL)
        {
            this.Body = new PDO.CoolStatus();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.CoolStatus Body { get; set; }
    }

    public class CompleteMessage : Message
    {
        public CompleteMessage() : base(MessageDefinitions.COMPLETE)
        {
            this.Body = new PDO.ChargeStatus();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.ChargeStatus Body { get; set; }
    }

    public static class MessageDefinitions
    {
        // COMMON
        public static string ACKNOWLEDGEMENT = "Acknowledgement";

        // PDI
        public static string ALLOY_SYNC = "Alloy_Sync";
        public static string REASON_SYNC = "Reason_Sync";
        public static string SCHEDULE = "Schedule";
        public static string STOCK_AVAILABLE = "Stock_Available";
        public static string SCHEDULE_RESPONSE = "Schedule_Response";

        // PDO
        public static string CONFIRM = "Confirm";
        public static string CANCEL = "Cancel";
        public static string HEAT = "Heat";
        public static string ABORT = "Abort";
        public static string COOL = "Cool";
        public static string COMPLETE = "Complete";

    }


}
