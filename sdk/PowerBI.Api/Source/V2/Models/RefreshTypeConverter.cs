// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;

    using System.Reflection;

    /// <summary>
    /// Defines values for RefreshType.
    /// </summary>
    public sealed class RefreshTypeConverter : JsonConverter
    {

        /// <summary>
        /// Returns if objectType can be converted to RefreshType by the
        /// converter.
        /// </summary>
        public override bool CanConvert(System.Type objectType)
        {
            return typeof(RefreshType).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        /// <summary>
        /// Overrides ReadJson and converts token to RefreshType.
        /// </summary>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
            {
                return null;
            }
            return (RefreshType)serializer.Deserialize<string>(reader);
        }

        /// <summary>
        /// Overriding WriteJson for RefreshType for serialization.
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

    }
}
