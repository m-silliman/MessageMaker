/**************************************************************************\
Event2 Name:  DowntimeMessage.cs
Project:      MES.Domain
Copyright (c) Novelis Corporation Inc, Deadline Solutions, Inc.

 * * Defines what a downtime message for the MES system

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
    /// Defines the downtime message that is sent for Planned, Unplanned and Bottleneck
    /// </summary>
    public class DowntimeMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DowntimeMessage"/> class.
        /// </summary>
        public DowntimeMessage()
        {
            Header = new MESHeader();
            Header.MessageName = "Downtime";
            Header.InterfaceId = "OS_ALL_L2L3_102";

            MessageBody = new DowntimeMessageBody();
        }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        [JsonProperty(Order = -2)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public MESHeader Header { get; set; }

        /// <summary>
        /// Gets or sets the message body.
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public DowntimeMessageBody MessageBody
        { get; set; }

    }

    /// <summary>
    /// Downtime message body contains the contents for a given downtime message,  This section
    /// containers the overall information of the downtime message.
    /// </summary>
    public class DowntimeMessageBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DowntimeMessageBody"/> class.
        /// </summary>
        public DowntimeMessageBody()
        {
            DowntimeDetails = new List<DownTimeDetailBody>();
            Action = ActionEnum.UPSERT;
        }

        /// <summary>
        /// Gets or sets the Batch Number.  Hotmill will be NULL
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// Gets or sets the cycle identifier for the given downtime.  Used by Remelt.
        /// </summary>
        public string CycleId { get; set; }

        /// <summary>
        /// Identifies the input/piece number as tracked by level 2
        /// </summary>
        public string L2Id { get; set; }

        /// <summary>
        /// Gets or sets down time identifier.  This Id correlates with the L2 identifier in the source system
        /// </summary>
        public string DownTimeId { get; set; }

        /// <summary>
        /// Gets or sets the UTC start time.
        /// </summary>
        public DateTime StartTimeUTC { get; set; }

        /// <summary>
        /// Gets or sets the UTC end time. Can be nullable if the downtime is active
        /// </summary>
        public DateTime? EndTimeUTC { get; set; }

        /// <summary>
        /// Gets or sets the action.  When Down start Action = Insert and when it ends it will be Upsert
        /// </summary>
        public ActionEnum Action { get; set; }

        /// <summary>
        /// Gets or sets the event name which will either be START_DOWNTIME or END_DOWNTIME
        /// </summary>
        public DowntimeEventEnum Event { get; set; }

        /// <summary>
        /// Gets or sets the collection of downtime detail's that is associated source downtime.
        /// </summary>
        public List<DownTimeDetailBody> DowntimeDetails { get; set; }
    }

    /// <summary>
    /// Defines the detail record for why the downtime has been created.  This is stored as a collection
    /// since some areas may assign multiple reasons for a given downtime event
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class DownTimeDetailBody : ICloneable
    {
        /// <summary>
        /// Gets or sets the category.  Should be U, P or B
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public DowntimeTypeEnum Category { get; set; }

        /// <summary>
        /// Downtime classification the default to pass should be Process, IT Maint
        /// </summary>
        /// <value>
        /// The discipline.
        /// </value>
        public string Discipline { get; set; }

        /// <summary>
        /// Group classification of the downtimes, RM (Phases)
        /// </summary>
        /// <value>
        /// The subsystem.
        /// </value>
        public string Subsystem { get; set; }

        /// <summary>
        /// Gets or sets the code.  Downtime mnemonic reason code. L2 DT Code
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the duration.  Downtime durations in seconds
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public long Duration { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string Comment { get; set; }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }

}
