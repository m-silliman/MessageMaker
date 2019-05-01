/**************************************************************************\
Event2 Name:  ProductionDataMessage.cs
Project:      MES.Domain
Copyright (c) Novelis Corporation Inc, Deadline Solutions, Inc.

 * * Defines the production data message that is sent when product is created

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
    /// Definition of the production data message
    /// </summary>
    public class ProductionDataMessage
    {
        private ProductionDataMessageBody _messageBody;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionDataMessage"/> class.
        /// </summary>
        public ProductionDataMessage()
        {
            Header = new MESHeader();
            Header.MessageName = "ProductionData";
            Header.InterfaceId = "OS_ALL_L2L3_105";

            MessageBody = new ProductionDataMessageBody();
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
        public ProductionDataMessageBody MessageBody
        { get => _messageBody; set => _messageBody = value; }

    }

    /// <summary>
    /// Production data message body
    /// </summary>
    public class ProductionDataMessageBody 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionDataMessageBody"/> class.
        /// </summary>
        public ProductionDataMessageBody()
        {
            BatchInputData = new List<BatchInputDetail>();
            ProductionData = new List<ProductionDetail>();
        }

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
        /// Gets or sets the duration in seconds.
        /// </summary>
        public long DurationInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the batch input data.
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public List<BatchInputDetail> BatchInputData { get; set; }

        /// <summary>
        /// Gets or sets the production data.
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public List<ProductionDetail> ProductionData { get; set; }
    }

    /// <summary>
    /// Defines the input material used for the production message
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class BatchInputDetail : ICloneable
    {
        /// <summary>
        /// Reference material number for the batch input;  Could me raw material or coil number
        /// </summary>
        public string BatchNoInput { get; set; }

        /// <summary>
        /// Level 2 identifier or unique identifier for the piece
        /// </summary>
        public string L2Id { get; set; }

        /// <summary>
        /// Change date and time for transaction
        /// </summary>
        public DateTime DtTmUTC { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get; set; }

        /// <summary>
        /// Add in the process scrap weight
        /// </summary>
        public double ProcessScrapWeight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BatchInputDetail"/> is reprocess.
        /// </summary>
        /// <value>
        ///   <c>true</c> if reprocess; otherwise, <c>false</c>.
        /// </value>
        public bool Reprocess { get; set; }

        /// <summary>
        /// Gets or sets the name of the local alloy.
        /// </summary>
        public string LocalAlloyName { get; set; }

        /// <summary>
        /// Gets or sets the shape identifier.
        /// </summary>
        public long? ShapeId { get; set; }

        /// <summary>
        /// Gets or sets the shape description
        /// </summary>
        public string ShapeDesc { get; set; }

        /// <summary>
        /// Gets or sets the gauge identifier 10 or 11 (remelt).
        /// </summary>
        public long? GaugeId { get; set; }

        /// <summary>
        /// Gets or sets the gauge description
        /// </summary>
        public string GaugeDesc { get; set; }

        /// <summary>
        /// Gets or sets the name of the source name
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// Gets or sets the sap bulk batch number
        /// </summary>
        public string SapBulkBatch { get; set; }

        /// <summary>
        /// Gets or sets the sap material name / number.
        /// </summary>
        public string SapMaterialNumber { get; set; }

        /// <summary>
        /// Gets or sets the stock location
        /// </summary>
        public string SLoc { get; set; }

        /// <summary>
        /// Gets or sets the type of the wi.
        /// </summary>
        /// <value>
        /// The type of the wi.
        /// </value>
        public string WIType { get; set; }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }

    /// <summary>
    /// Production detail record will list the outputs for this production data record
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class ProductionDetail : ICloneable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionDetail"/> class.
        /// </summary>
        public ProductionDetail()
        {
            QualityData = new List<QualityDataBody>();
        }

        /// <summary>
        /// Gets or sets the UTC WIP event date and time
        /// </summary>
        public DateTime WipChgDtTmUTC { get; set; }

        /// <summary>
        /// Gets or sets the batch no produced for the coil or ingot
        /// </summary>
        public string BatchNoOutput { get; set; }

        /// <summary>
        /// Gets or sets the l2 identifier used for reference
        /// </summary>
        public string L2Id { get; set; }

        /// <summary>
        /// Gets or sets the disposition of the output piece.  Quality disposition to identify
        /// Good Weight, Scrap Weight, Loss Weight
        /// </summary>
        public DispositionEnum Disposition { get; set; }

         /// <summary>
        /// Gets or sets the product order identifier.
        /// </summary>
         public string ProdOrderId { get; set; }

        /// <summary>
        /// Gets or sets the route path number
        /// </summary>
        public string RoutePathNo { get; set; }

        /// <summary>
        /// Gets or sets the output weight.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the weight method used: calculated, measured or estimated
        /// </summary>
        public WeightTypeEnum WeightMethod { get; set; }

        /// <summary>
        /// Gets or sets the gauge or thickness
        /// </summary>
        public double Gauge { get; set; }

        /// <summary>
        /// Gets or sets the width of the piece
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Gets or sets the temper.
        /// </summary>
        public string Temper { get; set; }

        /// <summary>
        /// Gets or sets the 'MakeAs' alloy.
        /// </summary>
        public string MakeAsAlloy { get; set; }

        /// <summary>
        /// Gets or sets the type of the core.  Either Alucore, Steel, Fiber or None
        /// </summary>
        public CoreTypeEnum? CoreType { get; set; }

        /// <summary>
        /// Gets or sets the nominal core od. (Opotional)
        /// </summary>
        public double? NominalCoreOD { get; set; }

        /// <summary>
        /// Gets or sets the width of the core. (Optional)
        /// </summary>
        public double? CoreWidth { get; set; }

        /// <summary>
        /// Gets or sets the strand seq. (Optional)
        /// </summary>
        public string StrandSeq { get; set; }

        /// <summary>
        /// Gets or sets the sub seq. (Optional)
        /// </summary>
        public string SubSeq { get; set; }

        /// <summary>
        /// Gets or sets the operation status.  NOP = Operation completed, did not process through machine
        /// RTW Operation not completed, did not process end child through machine
        /// ABORT No child created, intended process/operation not completed for parent
        /// </summary>
        public OperationStatusEnum? OperationStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [surface orient changed from operation] (Head->Tail or Tail->Head).  True or False if 
        /// </summary>
        /// <value>
        ///   <c>true</c> if [surface orient CHG]; otherwise, <c>false</c>.
        /// </value>
        public bool SurfaceOrientChg { get; set; }

        /// <summary>
        /// Gets or sets the collection of quality data records.
        /// </summary>
        public List<QualityDataBody> QualityData { get; set; }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
