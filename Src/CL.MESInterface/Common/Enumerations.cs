using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.MESInterface
{
    /// <summary>
    /// Defines 
    /// </summary>
    public enum DowntimeTypeEnum
    {
        /// <summary>
        /// Unplanned
        /// </summary>
        U,
        /// <summary>
        /// Planned
        /// </summary>
        P,
        /// <summary>
        /// Bottleneck
        /// </summary>
        B
    }

    public enum UOMEnum
    {
        /// <summary>
        /// Pass in the undefined unit of measure
        /// </summary>
        Undefined,
        /// <summary>
        /// British thermal units
        /// </summary>
        BTU,
        /// <summary>
        /// Centemeters
        /// </summary>
        CM,
        /// <summary>
        /// Square ft per minute
        /// </summary>
       FT2_MIN,
        /// <summary>
        /// Meters cubed
        /// </summary>
        M3,
        /// <summary>
        /// Foot
        /// </summary>
        FT,
        /// <summary>
        /// Gallons
        /// </summary>
        GAL,
        /// <summary>
        /// Grams
        /// </summary>
        G,
        /// <summary>
        /// Inch
        /// </summary>
        @IN,
        /// <summary>
        /// Kilo-gram
        /// </summary>
        KG,
        /// <summary>
        /// Liter
        /// </summary>
        L,
        /// <summary>
        /// Meter
        /// </summary>
        M,
        /// <summary>
        /// Millimeter
        /// </summary>
        MM,
        /// <summary>
        /// Lbs
        /// </summary>
        LB,
    }

    public enum PosAcrossLengthEnum
    {
        FrontEnd,
        Middle,
        BackEnd,
        Both
    }

    public enum PosAcrossWidthEnum
    {
        OperatorSide,
        DriveSide,
        Both
    }

    public enum WeightTypeEnum
    {
        Measured,
        Calculated,
        Estimated
    }

    public enum PosAcrossSurfaceEnum
    {
        Top,
        Bottom,
        Both
    }

    public enum ConditionTypeEnum
    {
        PartialScrap,
        Flaw,
        FeedForward,
        FullScrap,
        Hold    
    }

    public enum AcknowledgementEnum
    {
        [Obsolete("Use None, All or Failure")]
        ErrorOnly,
        [Obsolete("Use None, All or Failure")]
        Yes,
        [Obsolete("Use None, All or Failure")]
        No,
        None,
        All,
        Failure
    }

    public enum CoreTypeEnum
    {
        Alucore,
        Steel,
        Fiber,
        None
    }

    public enum OperationStatusEnum
    {
        /// <summary>
        /// Operation completed.  Did not process through machine
        /// </summary>
        NOP,
        /// <summary>
        /// Operation not completed.  Did not process end child through machine
        /// </summary>
        RTW,
        /// <summary>
        /// No child created.  Intended process/operation not completed for parent
        /// </summary>
        ABORT
    }

    public enum AcknowledgementStateEnum
    {
        /// <summary>
        /// Application is OK
        /// </summary>
        OK,
        /// <summary>
        /// Message is in error
        /// </summary>
        ERROR
    }

    public enum DispositionEnum
    {
        GOOD,
        SCRAP,
        HOLD,
        CONCESSION,
        REGRADE,
        REWORK
    }

    public enum ActionEnum
    {
        UPSERT,
        DELETE,
        SYNC
    }

    public enum DowntimeEventEnum
    {
        START_DOWNTIME,
        END_DOWNTIME
    }

    public enum WipStatusEnum
    {
        Staged,
        InProcess,
        Wait,
        Complete
    }

    public enum ProductionStatusEventEnum
    {
        GOODS_ISSUE,
        START_BATCH,
        END_BATCH,
        MOVE_LOT,
        ADJUST_LOT,
        CHARGE_BATCH,
        CHARGECANCEL_BATCH,
        STOP_BATCH
    }

    public enum RemeltByProductActionEnum
    {
        HEEL_UPSERT,
        HEEL_DELETE
    }

    public static class ConditionSeverity
    { 
        public const string Slight = "1";
        public const string Minor = "2";
        public const string Moderate = "3";
        public const string Major = "4";
        public const string Prime = "5";
    }
}
