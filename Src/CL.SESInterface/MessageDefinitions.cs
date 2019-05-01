using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CL.SESInterface
{
    /* ACK Message */
    public class AcknowledgementMessage : Message
    {
        public AcknowledgementMessage() : base(MessageDefinitions.ACKNOWLEDGEMENT)
        {
         
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Acknowledgement Body { get; set; }
    }

    /* PDI Messages */
    public class ScheduleMessage : Message
    {
        public ScheduleMessage() : base(MessageDefinitions.SCHEDULE)
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


    public class CoilReceivedMessage : Message
    {
        public CoilReceivedMessage() : base(MessageDefinitions.COIL_RECEIVED)
        {
            this.Body = new PDO.CoilReceived();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.CoilReceived Body { get; set; }
    }

    public class CoilStoredMessage : Message
    {
        public CoilStoredMessage() : base(MessageDefinitions.COIL_STORED)
        {
            this.Body = new PDO.CoilStored();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.CoilStored Body { get; set; }
    }

    public class PackingStartMessage : Message
    {
        public PackingStartMessage() : base(MessageDefinitions.PACKING_START)
        {
            this.Body = new PDO.PackingInfo();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.PackingInfo Body { get; set; }
    }

    public class PackingCompleteMessage : Message
    {
        public PackingCompleteMessage() : base(MessageDefinitions.PACKING_COMPLETE)
        {
            this.Body = new PDO.PackingInfo();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.PackingInfo Body { get; set; }
    }

    public class CoilShipmentMessage : Message
    {
        public CoilShipmentMessage() : base(MessageDefinitions.COIL_SHIPMENT)
        {
            this.Body = new PDO.PackingInfo();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.PackingInfo Body { get; set; }
    }

    public class CoilReturnMessage : Message
    {
        public CoilReturnMessage() : base(MessageDefinitions.COIL_RETURN)
        {
            this.Body = new PDO.PackingInfo();
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PDO.PackingInfo Body { get; set; }
    }

    public class ScheduleResponseMessage : Message
    {
        public ScheduleResponseMessage() : base(MessageDefinitions.SCHEDULE_RESPONSE)
        {

        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public object Body { get; set; }
    }

    public static class MessageDefinitions
    {
        // COMMON
        public static string ACKNOWLEDGEMENT = "Acknowledgement";

        // PDI
        public static string SCHEDULE = "Schedule";

        // PDO
        public static string COIL_RECEIVED = "Coil_Received";
        public static string COIL_STORED = "Coil_Stored";
        public static string PACKING_START = "Packing_Start";
        public static string PACKING_COMPLETE = "Packing_Complete";
        public static string COIL_SHIPMENT = "Coil_Shipment";
        public static string COIL_RETURN = "Coil_Return";
        public static string SCHEDULE_RESPONSE = "Schedule_Response";

    }

}
