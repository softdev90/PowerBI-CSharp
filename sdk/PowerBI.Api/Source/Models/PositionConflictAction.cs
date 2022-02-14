// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for PositionConflictAction.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(PositionConflictActionConverter))]
    public struct PositionConflictAction : System.IEquatable<PositionConflictAction>
    {
        private PositionConflictAction(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// In the event of position conflict, the tile will be added at the
        /// end of the specified dashboard.
        /// </summary>
        public static readonly PositionConflictAction Tail = "Tail";

        /// <summary>
        /// In the event of position conflict, the request will be cancelled.
        /// </summary>
        public static readonly PositionConflictAction Abort = "Abort";


        /// <summary>
        /// Underlying value of enum PositionConflictAction
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for PositionConflictAction
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type PositionConflictAction
        /// </summary>
        public bool Equals(PositionConflictAction e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to PositionConflictAction
        /// </summary>
        public static implicit operator PositionConflictAction(string value)
        {
            return new PositionConflictAction(value);
        }

        /// <summary>
        /// Implicit operator to convert PositionConflictAction to string
        /// </summary>
        public static implicit operator string(PositionConflictAction e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum PositionConflictAction
        /// </summary>
        public static bool operator == (PositionConflictAction e1, PositionConflictAction e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum PositionConflictAction
        /// </summary>
        public static bool operator != (PositionConflictAction e1, PositionConflictAction e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for PositionConflictAction
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is PositionConflictAction && Equals((PositionConflictAction)obj);
        }

        /// <summary>
        /// Returns for hashCode PositionConflictAction
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
