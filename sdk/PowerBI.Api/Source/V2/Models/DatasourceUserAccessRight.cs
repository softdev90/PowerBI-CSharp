// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for DatasourceUserAccessRight.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(DatasourceUserAccessRightConverter))]
    public struct DatasourceUserAccessRight : System.IEquatable<DatasourceUserAccessRight>
    {
        private DatasourceUserAccessRight(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Removes permission to access the datasource. Only applies when
        /// updating user permissions.
        /// </summary>
        public static readonly DatasourceUserAccessRight None = "None";

        /// <summary>
        /// Indicates that datasets owned by the user has read access to this
        /// datasource.
        /// </summary>
        public static readonly DatasourceUserAccessRight Read = "Read";

        /// <summary>
        /// Indicates that user can override effective identity for Power BI
        /// Embedded.
        /// </summary>
        public static readonly DatasourceUserAccessRight ReadOverrideEffectiveIdentity = "ReadOverrideEffectiveIdentity";


        /// <summary>
        /// Underlying value of enum DatasourceUserAccessRight
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for DatasourceUserAccessRight
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type DatasourceUserAccessRight
        /// </summary>
        public bool Equals(DatasourceUserAccessRight e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to DatasourceUserAccessRight
        /// </summary>
        public static implicit operator DatasourceUserAccessRight(string value)
        {
            return new DatasourceUserAccessRight(value);
        }

        /// <summary>
        /// Implicit operator to convert DatasourceUserAccessRight to string
        /// </summary>
        public static implicit operator string(DatasourceUserAccessRight e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum DatasourceUserAccessRight
        /// </summary>
        public static bool operator == (DatasourceUserAccessRight e1, DatasourceUserAccessRight e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum DatasourceUserAccessRight
        /// </summary>
        public static bool operator != (DatasourceUserAccessRight e1, DatasourceUserAccessRight e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for DatasourceUserAccessRight
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is DatasourceUserAccessRight && Equals((DatasourceUserAccessRight)obj);
        }

        /// <summary>
        /// Returns for hashCode DatasourceUserAccessRight
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
