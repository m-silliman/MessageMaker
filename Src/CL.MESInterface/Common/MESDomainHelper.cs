/**************************************************************************\
Event2 Name:  MESDomainHelper.cs
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

namespace CL.MESInterface
{
    /// <summary>
    /// MES Message Helper class used to allow modification and creation of the
    /// message header.  This class contains static and extender functions for
    /// the MESHeader object
    /// </summary>
    public static class MESMessageHelper
    {
        /// <summary>
        /// Creates the specified plant code.
        /// </summary>
        /// <param name="plantCode">The plant code.</param>
        /// <param name="interfaceId">The interface identifier.</param>
        /// <param name="messageName">Name of the message.</param>
        /// <param name="receiver">The receiver.</param>
        /// <returns></returns>
        public static MESHeader Create(string interfaceId, string messageName, string receiver, AcknowledgementEnum ackType = AcknowledgementEnum.No)
        {
            MESHeader header = new MESHeader();

            header.InterfaceId = interfaceId;
            header.MessageName = messageName;
            header.Sender = Environment.MachineName;
            header.Receiver = receiver;
            header.AckReq = ackType;

            return header;
        }

        /// <summary>
        /// This function will acknowledge the MES header message with a particular status and telegram number
        /// </summary>
        /// <param name="m">The m.</param>
        /// <param name="ackType">Type of the ack.</param>
        /// <param name="telegramNo">The telegram no.</param>
        /// <returns></returns>
        public static MESHeader Acknowledgement(this MESHeader m, AcknowledgementEnum ackType, string telegramNo = "")
        {
            m.AckReq = ackType;

            if(!string.IsNullOrEmpty(telegramNo))
                m.TelegramNo = telegramNo;

            return m;
        }

        /// <summary>
        /// Mark the status of the MES message in the header
        /// </summary>
        /// <param name="m">Actual MES header message</param>
        /// <param name="status">Status string indicating the actual status of the message</param>
        /// <returns>Returns an instance of itself</returns>
        public static MESHeader Status(this MESHeader m, string status)
        {
            m.Status = status;

            return m;
        }

    }
}
