// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Beta.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class TileUrl
    {
        /// <summary>
        /// Initializes a new instance of the TileUrl class.
        /// </summary>
        public TileUrl() { }

        /// <summary>
        /// Initializes a new instance of the TileUrl class.
        /// </summary>
        public TileUrl(string targetUrl)
        {
            TargetUrl = targetUrl;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetUrl")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (TargetUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetUrl");
            }
        }
    }
}
