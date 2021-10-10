// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for ReportUserAccessRight.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ReportUserAccessRightConverter))]
    public struct ReportUserAccessRight : System.IEquatable<ReportUserAccessRight>
    {
        private ReportUserAccessRight(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// No permission to content in report
        /// </summary>
        public static readonly ReportUserAccessRight None = "None";

        /// <summary>
        /// Grants Read access to content in report
        /// </summary>
        public static readonly ReportUserAccessRight Read = "Read";

        /// <summary>
        /// Grants Read and Write access to content in report
        /// </summary>
        public static readonly ReportUserAccessRight ReadWrite = "ReadWrite";

        /// <summary>
        /// Grants Read and Reshare access to content in report
        /// </summary>
        public static readonly ReportUserAccessRight ReadReshare = "ReadReshare";

        /// <summary>
        /// Grants Read and Copy access to content in report
        /// </summary>
        public static readonly ReportUserAccessRight ReadCopy = "ReadCopy";

        /// <summary>
        /// Grants Read, Write and Reshare access to content in report
        /// </summary>
        public static readonly ReportUserAccessRight Owner = "Owner";


        /// <summary>
        /// Underlying value of enum ReportUserAccessRight
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ReportUserAccessRight
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ReportUserAccessRight
        /// </summary>
        public bool Equals(ReportUserAccessRight e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ReportUserAccessRight
        /// </summary>
        public static implicit operator ReportUserAccessRight(string value)
        {
            return new ReportUserAccessRight(value);
        }

        /// <summary>
        /// Implicit operator to convert ReportUserAccessRight to string
        /// </summary>
        public static implicit operator string(ReportUserAccessRight e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ReportUserAccessRight
        /// </summary>
        public static bool operator == (ReportUserAccessRight e1, ReportUserAccessRight e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ReportUserAccessRight
        /// </summary>
        public static bool operator != (ReportUserAccessRight e1, ReportUserAccessRight e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ReportUserAccessRight
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ReportUserAccessRight && Equals((ReportUserAccessRight)obj);
        }

        /// <summary>
        /// Returns for hashCode ReportUserAccessRight
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
