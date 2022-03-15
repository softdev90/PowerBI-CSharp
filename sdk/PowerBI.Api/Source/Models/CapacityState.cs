// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for CapacityState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(CapacityStateConverter))]
    public struct CapacityState : System.IEquatable<CapacityState>
    {
        private CapacityState(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Unsupported
        /// </summary>
        public static readonly CapacityState NotActivated = "NotActivated";

        /// <summary>
        /// The capacity is ready to use
        /// </summary>
        public static readonly CapacityState Active = "Active";

        /// <summary>
        /// Activation of the capacity is in progress
        /// </summary>
        public static readonly CapacityState Provisioning = "Provisioning";

        /// <summary>
        /// Provisioning of the capacity failed
        /// </summary>
        public static readonly CapacityState ProvisionFailed = "ProvisionFailed";

        /// <summary>
        /// Use of the capacity is suspended
        /// </summary>
        public static readonly CapacityState Suspended = "Suspended";

        /// <summary>
        /// Unsupported
        /// </summary>
        public static readonly CapacityState PreSuspended = "PreSuspended";

        /// <summary>
        /// Deletion of the capacity is in progress
        /// </summary>
        public static readonly CapacityState Deleting = "Deleting";

        /// <summary>
        /// The capacity was deleted and is unavailable
        /// </summary>
        public static readonly CapacityState Deleted = "Deleted";

        /// <summary>
        /// The capacity can't be used
        /// </summary>
        public static readonly CapacityState Invalid = "Invalid";

        /// <summary>
        /// A capacity SKU change is in progress
        /// </summary>
        public static readonly CapacityState UpdatingSku = "UpdatingSku";


        /// <summary>
        /// Underlying value of enum CapacityState
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for CapacityState
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type CapacityState
        /// </summary>
        public bool Equals(CapacityState e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to CapacityState
        /// </summary>
        public static implicit operator CapacityState(string value)
        {
            return new CapacityState(value);
        }

        /// <summary>
        /// Implicit operator to convert CapacityState to string
        /// </summary>
        public static implicit operator string(CapacityState e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum CapacityState
        /// </summary>
        public static bool operator == (CapacityState e1, CapacityState e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum CapacityState
        /// </summary>
        public static bool operator != (CapacityState e1, CapacityState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for CapacityState
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is CapacityState && Equals((CapacityState)obj);
        }

        /// <summary>
        /// Returns for hashCode CapacityState
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
