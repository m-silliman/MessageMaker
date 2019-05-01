/**************************************************************************\
Event2 Name:  MESHeader.cs
Project:      MES.Domain
Copyright (c) Novelis Corporation Inc, Deadline Solutions, Inc.

 * * Defines the common MES header as used for each telegram being sent and
 * * received from MES to L2 Automation

All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/
using System;
using System.Configuration;

namespace CL.MESInterface
{
    /// <summary>
    /// MES Header class that is embedded with every message
    /// </summary>
    public class MESHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MESHeader"/> class.
        /// The telegram number and timestamp for each message is auto-generated.
        /// 
        /// To have the Plant, ShopId and PscgId filled in, define these in the app.config settings
        /// file.
        /// </summary>
        public MESHeader()
        {
            // Generate the telegram 
            TelegramNo = Guid.NewGuid().ToString();
            TimeStamp = DateTime.UtcNow;
            Status = "NEW";

            Sender = Environment.MachineName;
            Receiver = "MES";
            AckReq = AcknowledgementEnum.None;
            InterfaceId = "";

            // Default settings as found int he app.config.  If these items are not defined
            // we will leave them as the default values of blank
            string plantSetting = ConfigurationManager.AppSettings["Plant"];
            if(!string.IsNullOrEmpty(plantSetting))
            {
                Plant = plantSetting;
            }

            string shopId = ConfigurationManager.AppSettings["ShopId"];
            if (!string.IsNullOrEmpty(shopId))
                this.ShopId = shopId;

            string pcsgId = ConfigurationManager.AppSettings["PcsgId"];
            if (!string.IsNullOrEmpty(pcsgId))
                this.PcsgId = pcsgId;
        }

        /// <summary>
        /// Gets or sets the telegram no.
        /// </summary>
        public string TelegramNo { get; set; }

        /// <summary>
        /// Gets or sets the name of the message.  The name of message is the friendly name as defined
        /// from the document
        /// </summary>
        public string MessageName { get; set; }

        /// <summary>
        /// Gets or sets the interface identifier declared in the NNA MES Plant Automation Interfaces document
        ///  - Examples would be: OS_ALL_L2L3_102, OS_ALL_L2L3_104 ...
        /// </summary>
        public string InterfaceId { get; set; }

        /// <summary>
        /// Gets or sets the sender.
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Gets or sets the receiver.
        /// </summary>
        public string Receiver { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the ack req.
        /// </summary>
        public AcknowledgementEnum AckReq { get; set; }

        /// <summary>
        /// Gets or sets the time stamp.  The desired timestamp would be in UTC
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the plant.
        /// </summary>
        public string Plant { get; set; }

        /// <summary>
        /// Gets or sets the shop identifier.  For Oswego this would be OSW
        /// </summary>
        public string ShopId { get; set; }

        /// <summary>
        /// Gets or sets the PCSG identifier.  RM, HM, CM
        /// </summary>
        public string PcsgId { get; set; }

        /// <summary>
        /// Gets or sets the proc identifier.
        /// </summary>
        public string ProcId { get; set; }

        /// <summary>
        /// Gets or sets the eqpt identifier.
        /// </summary>
        public string EqptId { get; set; }
    }
}
