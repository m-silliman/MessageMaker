/**************************************************************************\
Event2 Name:  QualityDataMessage.cs
Project:      MES.Domain
Copyright (c) Novelis Corporation Inc, Deadline Solutions, Inc.

 * * Defines the quality data message as an indpendant message that is sent 
 * to MES external to the ProductionData message which has Quality built in
 * 
 
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CL.MESInterface
{
    /// <summary>
    /// Defines a quality data message telegram to be sent to the MES system
    /// </summary>
    public class QualityDataMessage
    {

        public QualityDataMessage()
        {
            Header = new MESHeader();
            Header.MessageName = "QualityData";
            Header.InterfaceId = "OS_ALL_L2L3_106";

            MessageBody = new QualityDataMessageBody();
        }

        /// <summary>
        /// Gets or sets the header for the state message
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [JsonProperty(Order = -2)]
        public MESHeader Header { get; set; }

        /// <summary>
        /// Gets or sets the message body for the quality data message
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public QualityDataMessageBody MessageBody
        { get; set; }

    }

    /// <summary>
    /// Defines the message body for the quality message
    /// </summary>
    public class QualityDataMessageBody 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityDataMessageBody"/> class.
        /// </summary>
        public QualityDataMessageBody()
        {
            QualityData = new List<QualityDataBody>();
            WipChgDtTmUTC = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the route path step 10,20,30... etc
        /// </summary>
        public string RoutePathNo { get; set; }

        /// <summary>
        /// Gets or sets the UTC WUO evebt date and time IN UTC
        /// </summary>
        public DateTime WipChgDtTmUTC { get; set; }

        /// <summary>
        /// Gets or sets the batch no that this applieds to
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// Gets or sets the weight uom.
        /// </summary>
        public UOMEnum WeightUOM { get; set; }

        /// <summary>
        /// Gets or sets the length uom.
        /// </summary>
        public UOMEnum LengthUOM { get; set; }

        /// <summary>
        /// Gets or sets the gauge uom.
        /// </summary>
        public UOMEnum GaugeUOM { get; set; }

        /// <summary>
        /// Gets or sets the width uom.
        /// </summary>
        public UOMEnum WidthUOM { get; set; }


        /// <summary>
        /// Gets or sets the disposition that indicates GOOD, BAD or HOLD
        /// </summary>
        public DispositionEnum Disposition { get; set; }


        /// <summary>
        /// Gets or sets the quality data array
        /// </summary>
        /// <value>
        /// The quality data.
        /// </value>
        public List<QualityDataBody> QualityData { get; set; }

               /// <summary>
        /// Gets or sets the disposition that indicates GOOD, BAD or HOLD
        /// </summary>
        public string Event { get; set; }


    }

    /// <summary>
    /// Quality data body
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class QualityDataBody : ICloneable
    {
        /// <summary>
        /// Gets or sets the weight for the piece
        /// </summary>
        public Decimal Weight { get; set; }

        /// <summary>
        /// Gets or sets the type of the weight, indicates Measured, Calculated or Estimated
        /// </summary>
        public WeightTypeEnum? WeightType { get; set; }

        /// <summary>
        /// Gets or sets the type of the condition.  Specify if the condition is FeedForward, 
        /// Flaw, FeedForward, etc..
        /// </summary>
        public ConditionTypeEnum? ConditionType { get; set; }

        /// <summary>
        /// Gets or sets the condition identifier.  This is the value of the reason code
        /// </summary>
        public string ConditionId { get; set; }

        /// <summary>
        /// Gets or sets the condition severity.
        /// 
        /// 1 Slight
        /// 2 Minor
        /// 3 Moderate
        /// 4 Major
        /// 5 Prime
        /// </summary>
        /// <value>
        /// The condition severity.
        /// </value>
        public string ConditionSeverity { get; set; }

        /// <summary>
        /// Gets or sets the responsibility for the downtime, IE: Coldmill, Hotmill, Remelt etc...
        /// </summary>
        public string Responsibility { get; set; }

        /// <summary>
        /// Gets or sets the meter mark of the start of the defect
        /// </summary>
        public long? StartPos { get; set; }

        /// <summary>
        /// Gets or sets the meter mark of the end of the defect
        /// </summary>
        public long? StopPos { get; set; }

        /// <summary>
        /// FrontEnd, Middle, BackEnd or Both for the position
        /// </summary>
        public PosAcrossLengthEnum? PosAcrossLength {get;set;}

        /// <summary>
        /// Side of the defect: Operator, Drive or Both
        /// </summary>
        public PosAcrossWidthEnum? PosAcrossWidth { get; set; }

        /// <summary>
        /// Gets or sets the across surface will be Top or Botton.
        /// </summary>
        public PosAcrossSurfaceEnum? PosAcrossSurface { get; set; }

        /// <summary>
        /// Gets or sets the l2 identifier that is provided in the PDO.  
        /// Return in PDI unless MES creates new, then it would be NULL.
        /// </summary>
        public string L2Id { get; set; }

        /// <summary>
        /// Gets or sets the operator comments for this downtime
        /// </summary>
        public string Comment { get; set; }


        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }

}