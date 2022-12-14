// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for AssignmentStatus.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(AssignmentStatusConverter))]
    public struct AssignmentStatus : System.IEquatable<AssignmentStatus>
    {
        private AssignmentStatus(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// The assignment request was received, but the assignment operation
        /// hasn't started.
        /// </summary>
        public static readonly AssignmentStatus Pending = "Pending";

        /// <summary>
        /// The assignment operation is in progress
        /// </summary>
        public static readonly AssignmentStatus InProgress = "InProgress";

        /// <summary>
        /// The assignment operation has completed successfully
        /// </summary>
        public static readonly AssignmentStatus CompletedSuccessfully = "CompletedSuccessfully";

        /// <summary>
        /// The assignment operation failed
        /// </summary>
        public static readonly AssignmentStatus AssignmentFailed = "AssignmentFailed";


        /// <summary>
        /// Underlying value of enum AssignmentStatus
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for AssignmentStatus
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type AssignmentStatus
        /// </summary>
        public bool Equals(AssignmentStatus e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to AssignmentStatus
        /// </summary>
        public static implicit operator AssignmentStatus(string value)
        {
            return new AssignmentStatus(value);
        }

        /// <summary>
        /// Implicit operator to convert AssignmentStatus to string
        /// </summary>
        public static implicit operator string(AssignmentStatus e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum AssignmentStatus
        /// </summary>
        public static bool operator == (AssignmentStatus e1, AssignmentStatus e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum AssignmentStatus
        /// </summary>
        public static bool operator != (AssignmentStatus e1, AssignmentStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for AssignmentStatus
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is AssignmentStatus && Equals((AssignmentStatus)obj);
        }

        /// <summary>
        /// Returns for hashCode AssignmentStatus
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
