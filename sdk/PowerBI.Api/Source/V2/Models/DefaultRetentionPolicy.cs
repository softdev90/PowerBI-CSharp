// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DefaultRetentionPolicy.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DefaultRetentionPolicy
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        /// <summary>
        /// basicFIFO
        /// </summary>
        [EnumMember(Value = "basicFIFO")]
        BasicFIFO
    }
    internal static class DefaultRetentionPolicyEnumExtension
    {
        internal static string ToSerializedValue(this DefaultRetentionPolicy? value)
        {
            return value == null ? null : ((DefaultRetentionPolicy)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DefaultRetentionPolicy value)
        {
            switch( value )
            {
                case DefaultRetentionPolicy.None:
                    return "None";
                case DefaultRetentionPolicy.BasicFIFO:
                    return "basicFIFO";
            }
            return null;
        }

        internal static DefaultRetentionPolicy? ParseDefaultRetentionPolicy(this string value)
        {
            switch( value )
            {
                case "None":
                    return DefaultRetentionPolicy.None;
                case "basicFIFO":
                    return DefaultRetentionPolicy.BasicFIFO;
            }
            return null;
        }
    }
}
