// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for FeatureExtendedState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(FeatureExtendedStateConverter))]
    public struct FeatureExtendedState : System.IEquatable<FeatureExtendedState>
    {
        private FeatureExtendedState(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly FeatureExtendedState Enabled = "Enabled";

        public static readonly FeatureExtendedState DisabledByAdmin = "DisabledByAdmin";

        public static readonly FeatureExtendedState UserNotLicensed = "UserNotLicensed";


        /// <summary>
        /// Underlying value of enum FeatureExtendedState
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for FeatureExtendedState
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type FeatureExtendedState
        /// </summary>
        public bool Equals(FeatureExtendedState e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to FeatureExtendedState
        /// </summary>
        public static implicit operator FeatureExtendedState(string value)
        {
            return new FeatureExtendedState(value);
        }

        /// <summary>
        /// Implicit operator to convert FeatureExtendedState to string
        /// </summary>
        public static implicit operator string(FeatureExtendedState e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum FeatureExtendedState
        /// </summary>
        public static bool operator == (FeatureExtendedState e1, FeatureExtendedState e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum FeatureExtendedState
        /// </summary>
        public static bool operator != (FeatureExtendedState e1, FeatureExtendedState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for FeatureExtendedState
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is FeatureExtendedState && Equals((FeatureExtendedState)obj);
        }

        /// <summary>
        /// Returns for hashCode FeatureExtendedState
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
