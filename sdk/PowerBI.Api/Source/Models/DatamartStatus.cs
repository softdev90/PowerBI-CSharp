// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for DatamartStatus.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(DatamartStatusConverter))]
    public struct DatamartStatus : System.IEquatable<DatamartStatus>
    {
        private DatamartStatus(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// The datamart has invalid status
        /// </summary>
        public static readonly DatamartStatus Invalid = "Invalid";

        /// <summary>
        /// The datamart is available
        /// </summary>
        public static readonly DatamartStatus Available = "Available";

        /// <summary>
        /// The datamart is suspended in critical phase
        /// </summary>
        public static readonly DatamartStatus SuspendedInCriticalPhase = "SuspendedInCriticalPhase";

        /// <summary>
        /// The datamart is in progress
        /// </summary>
        public static readonly DatamartStatus InProgress = "InProgress";

        /// <summary>
        /// The datamart has error status
        /// </summary>
        public static readonly DatamartStatus Error = "Error";

        /// <summary>
        /// The datamart is out of region
        /// </summary>
        public static readonly DatamartStatus OutOfRegion = "OutOfRegion";

        /// <summary>
        /// The datamart has no capacity
        /// </summary>
        public static readonly DatamartStatus NoCapacity = "NoCapacity";


        /// <summary>
        /// Underlying value of enum DatamartStatus
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for DatamartStatus
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type DatamartStatus
        /// </summary>
        public bool Equals(DatamartStatus e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to DatamartStatus
        /// </summary>
        public static implicit operator DatamartStatus(string value)
        {
            return new DatamartStatus(value);
        }

        /// <summary>
        /// Implicit operator to convert DatamartStatus to string
        /// </summary>
        public static implicit operator string(DatamartStatus e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum DatamartStatus
        /// </summary>
        public static bool operator == (DatamartStatus e1, DatamartStatus e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum DatamartStatus
        /// </summary>
        public static bool operator != (DatamartStatus e1, DatamartStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for DatamartStatus
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is DatamartStatus && Equals((DatamartStatus)obj);
        }

        /// <summary>
        /// Returns for hashCode DatamartStatus
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
