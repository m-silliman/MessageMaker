/**************************************************************************\
Event2 Name:  ProductionStatusMessage.cs
Project:      MES.Domain
Copyright (c) Novelis Corporation Inc, Deadline Solutions, Inc.

 * * Defines the production status message to be sent to the MES system

All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CL.MESInterface
{
    /// <summary>
    /// Defines the production status message
    /// </summary>
    public class ProductionStatusMessage  
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionStatusMessage"/> class.
        /// </summary>
        public ProductionStatusMessage()
        {
            Header = new MESHeader();
            Header.MessageName = "ProductionStatus";
            Header.InterfaceId = "OS_ALL_L2L3_104";

            MessageBody = new ProductionStatusMessageBody();
        }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [JsonProperty(Order = -2)]
        public MESHeader Header { get; set; }

        /// <summary>
        /// Gets or sets the message body.
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public ProductionStatusMessageBody MessageBody
        { get; set; }

    }

    /// <summary>
    /// Defines the message body portion of the production message
    /// </summary>
    /// <seealso cref="CL.MESInterface.MessageBody" />
    public class ProductionStatusMessageBody 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionStatusMessageBody"/> class.
        /// </summary>
        public ProductionStatusMessageBody()
        {
            ProductionStatusDetail = new List<ProductionStatusDetailData>();
            WipChgDtTmUTC = DateTime.UtcNow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionStatusMessageBody"/> class.
        /// </summary>
        /// <param name="eventName">Name of the production status event.</param>
        /// <param name="l2Id">The l2 identifier.</param>
        /// <param name="curDateTime">The current date time.</param>
        public ProductionStatusMessageBody(ProductionStatusEventEnum eventName, string l2Id, DateTime curDateTime)
        {
            ProductionStatusDetail = new List<ProductionStatusDetailData>();
            WipChgDtTmUTC = curDateTime;
            Event = eventName;
        }

        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        public ProductionStatusEventEnum Event { get; set; }

        /// <summary>
        /// Gets or sets the UTC wip CHG dt tm.
        /// </summary>
        public DateTime WipChgDtTmUTC { get; set; }

        /// <summary>
        /// Gets or sets the l2 identifier.
        /// </summary>
        public string L2Id { get; set; }

        /// <summary>
        /// Gets or sets the production status detail.
        /// </summary>
        public List<ProductionStatusDetailData> ProductionStatusDetail { get; set; }
    }

    /// <summary>
    /// Defines the array of objects for the production status detail
    /// </summary>
    public class ProductionStatusDetailData : ICloneable
    {
        /// <summary>
        /// Gets or sets the batch no.
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// Gets or sets the product order identifier.
        /// </summary>
        public string ProdOrderId { get; set; }

        /// <summary>
        /// Gets or sets the route path no.
        /// </summary>
        public string RoutePathNo { get; set; }

        /// <summary>
        /// Gets or sets the state of the wip.
        /// </summary>
        public WipStatusEnum WipState { get; set; }

        /// <summary>
        /// Gets or sets the wip qty.
        /// </summary>
        public string WipQty { get; set; }

        /// <summary>
        /// Gets or sets the pass count.
        /// </summary>
        public long PassCnt { get; set; }

        /// <summary>
        /// Gets or sets the ident.
        /// </summary>
        public string Ident { get; set; }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
