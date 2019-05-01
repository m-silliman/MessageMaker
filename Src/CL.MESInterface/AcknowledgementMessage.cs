/**************************************************************************\
Event2 Name:  AcknowledgementMessage.cs
Project:      MES.Domain
Copyright (c) Novelis Corporation Inc, Deadline Solutions, Inc.

 * * Acknowledgement message definition

All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using Newtonsoft.Json;
using System.ComponentModel;

namespace CL.MESInterface
{
    /// <summary>
    /// Definition of a message that is sent used to acknowledge a previous message
    /// that has been sent
    /// </summary>
    public class AcknowledgementMessage 
    {
        public AcknowledgementMessage()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcknowledgementMessage"/> class.
        /// </summary>
        /// <param name="state">Defines the state of the message either being ERROR or OK.</param>
        /// <param name="telegramNo">The telegram no.</param>
        /// <param name="infoText">The information text.</param>
        public AcknowledgementMessage(AcknowledgementStateEnum state, string telegramNo, string infoText = "")
        {
            Header = new MESHeader();
            Header.AckReq = CL.MESInterface.AcknowledgementEnum.No;
            Header.MessageName = "GeneralAck";
            
            MessageBody = new AcknowledgementMessageBody();

            MessageBody.AckState = state;
            MessageBody.AckTelegramNo = telegramNo;
            MessageBody.InfoText = infoText;

        }

        /// <summary>
        /// Instance of the header
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [JsonProperty(Order = -2)]
        public MESHeader Header { get; set; }

        /// <summary>
        /// Instance of the message body.
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public AcknowledgementMessageBody MessageBody { get; set; }

        /// <summary>
        /// Creates an OK telegram for acknowledgement of a message
        /// </summary>
        /// <param name="telegramNo">Telegram number being acknowledged</param>
        /// <param name="infoText">Information text being passed along</param>
        public static AcknowledgementMessage OK(string telegramNo, string infoText = "")
        {
            return new AcknowledgementMessage(AcknowledgementStateEnum.OK, telegramNo, infoText);
        }

        /// <summary>
        /// Creates an ERROR telegram for acknowledgement of a message
        /// </summary>
        /// <param name="telegramNo">Telegram number being acknowledged</param>
        /// <param name="infoText">Information text being passed along</param>
        public static AcknowledgementMessage ERROR(string telegramNo, string infoText = "")
        {
            return new AcknowledgementMessage(AcknowledgementStateEnum.ERROR, telegramNo, infoText);
        }
    }

    /// <summary>
    /// Class is used to define a message body
    /// </summary>
    public class AcknowledgementMessageBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcknowledgementMessageBody"/> class.
        /// </summary>
        public AcknowledgementMessageBody()
        {

        }

        /// <summary>
        /// Gets or sets the state of the ack.
        /// </summary>
        public AcknowledgementStateEnum AckState { get; set; }

        /// <summary>
        /// Gets or sets the information text.
        /// </summary>
        public string InfoText { get; set; }

        /// <summary>
        /// Gets or sets the ack telegram no.
        /// </summary>
        public string AckTelegramNo { get; set; }
    }

}
