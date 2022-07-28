// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for RefreshType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(RefreshTypeConverter))]
    public struct RefreshType : System.IEquatable<RefreshType>
    {
        private RefreshType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// The refresh was triggered by a dataset refresh schedule setting
        /// </summary>
        public static readonly RefreshType Scheduled = "Scheduled";

        /// <summary>
        /// The refresh was triggered interactively through the Power BI portal
        /// </summary>
        public static readonly RefreshType OnDemand = "OnDemand";

        /// <summary>
        /// The refresh was triggered by an API call
        /// </summary>
        public static readonly RefreshType ViaApi = "ViaApi";

        /// <summary>
        /// The refresh was triggered through Power BI public XMLA endpoint
        /// </summary>
        public static readonly RefreshType ViaXmlaEndpoint = "ViaXmlaEndpoint";

        /// <summary>
        /// The refresh was triggered by an enhanced refresh REST API call
        /// </summary>
        public static readonly RefreshType ViaEnhancedApi = "ViaEnhancedApi";

        /// <summary>
        /// The refresh was triggered interactively through the Power BI portal
        /// with automatic aggregations training
        /// </summary>
        public static readonly RefreshType OnDemandTraining = "OnDemandTraining";


        /// <summary>
        /// Underlying value of enum RefreshType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for RefreshType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type RefreshType
        /// </summary>
        public bool Equals(RefreshType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to RefreshType
        /// </summary>
        public static implicit operator RefreshType(string value)
        {
            return new RefreshType(value);
        }

        /// <summary>
        /// Implicit operator to convert RefreshType to string
        /// </summary>
        public static implicit operator string(RefreshType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum RefreshType
        /// </summary>
        public static bool operator == (RefreshType e1, RefreshType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum RefreshType
        /// </summary>
        public static bool operator != (RefreshType e1, RefreshType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for RefreshType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is RefreshType && Equals((RefreshType)obj);
        }

        /// <summary>
        /// Returns for hashCode RefreshType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
