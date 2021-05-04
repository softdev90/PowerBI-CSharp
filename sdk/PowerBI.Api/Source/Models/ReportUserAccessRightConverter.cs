// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    using System.Reflection;

    /// <summary>
    /// Defines values for ReportUserAccessRight.
    /// </summary>
    public sealed class ReportUserAccessRightConverter : JsonConverter
    {

        /// <summary>
        /// Returns if objectType can be converted to ReportUserAccessRight by
        /// the converter.
        /// </summary>
        public override bool CanConvert(System.Type objectType)
        {
            return typeof(ReportUserAccessRight).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        /// <summary>
        /// Overrides ReadJson and converts token to ReportUserAccessRight.
        /// </summary>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
            {
                return null;
            }
            return (ReportUserAccessRight)serializer.Deserialize<string>(reader);
        }

        /// <summary>
        /// Overriding WriteJson for ReportUserAccessRight for serialization.
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

    }
}
