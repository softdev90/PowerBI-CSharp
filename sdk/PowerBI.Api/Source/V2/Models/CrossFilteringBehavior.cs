// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for CrossFilteringBehavior.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(CrossFilteringBehaviorConverter))]
    public struct CrossFilteringBehavior : System.IEquatable<CrossFilteringBehavior>
    {
        private CrossFilteringBehavior(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// For filtering purposes, filter will be applied on the table where
        /// values are being aggregated
        /// </summary>
        public static readonly CrossFilteringBehavior OneDirection = "OneDirection";

        /// <summary>
        /// For filtering purposes, both tables are treated as if they're a
        /// single table
        /// </summary>
        public static readonly CrossFilteringBehavior BothDirections = "BothDirections";

        /// <summary>
        /// Cross filtering behavior defined automatically
        /// </summary>
        public static readonly CrossFilteringBehavior Automatic = "Automatic";


        /// <summary>
        /// Underlying value of enum CrossFilteringBehavior
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for CrossFilteringBehavior
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type CrossFilteringBehavior
        /// </summary>
        public bool Equals(CrossFilteringBehavior e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to CrossFilteringBehavior
        /// </summary>
        public static implicit operator CrossFilteringBehavior(string value)
        {
            return new CrossFilteringBehavior(value);
        }

        /// <summary>
        /// Implicit operator to convert CrossFilteringBehavior to string
        /// </summary>
        public static implicit operator string(CrossFilteringBehavior e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum CrossFilteringBehavior
        /// </summary>
        public static bool operator == (CrossFilteringBehavior e1, CrossFilteringBehavior e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum CrossFilteringBehavior
        /// </summary>
        public static bool operator != (CrossFilteringBehavior e1, CrossFilteringBehavior e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for CrossFilteringBehavior
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is CrossFilteringBehavior && Equals((CrossFilteringBehavior)obj);
        }

        /// <summary>
        /// Returns for hashCode CrossFilteringBehavior
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
