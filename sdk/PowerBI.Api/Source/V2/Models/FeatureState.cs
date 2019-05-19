// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for FeatureState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(FeatureStateConverter))]
    public struct FeatureState : System.IEquatable<FeatureState>
    {
        private FeatureState(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly FeatureState Enabled = "Enabled";

        public static readonly FeatureState Disabled = "Disabled";


        /// <summary>
        /// Underlying value of enum FeatureState
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for FeatureState
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type FeatureState
        /// </summary>
        public bool Equals(FeatureState e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to FeatureState
        /// </summary>
        public static implicit operator FeatureState(string value)
        {
            return new FeatureState(value);
        }

        /// <summary>
        /// Implicit operator to convert FeatureState to string
        /// </summary>
        public static implicit operator string(FeatureState e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum FeatureState
        /// </summary>
        public static bool operator == (FeatureState e1, FeatureState e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum FeatureState
        /// </summary>
        public static bool operator != (FeatureState e1, FeatureState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for FeatureState
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is FeatureState && Equals((FeatureState)obj);
        }

        /// <summary>
        /// Returns for hashCode FeatureState
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
