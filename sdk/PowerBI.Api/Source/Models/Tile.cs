// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class Tile
    {
        /// <summary>
        /// Initializes a new instance of the Tile class.
        /// </summary>
        public Tile() { }

        /// <summary>
        /// Initializes a new instance of the Tile class.
        /// </summary>
        public Tile(string id = default(string), string title = default(string), string subTitle = default(string), TileAction action = default(TileAction), TileDefinition definition = default(TileDefinition), string embedUrl = default(string), string embedData = default(string), PowerBIApiODataErrorResponse filterError = default(PowerBIApiODataErrorResponse), int? rowSpan = default(int?), int? colSpan = default(int?))
        {
            Id = id;
            Title = title;
            SubTitle = subTitle;
            Action = action;
            Definition = definition;
            EmbedUrl = embedUrl;
            EmbedData = embedData;
            FilterError = filterError;
            RowSpan = rowSpan;
            ColSpan = colSpan;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subTitle")]
        public string SubTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public TileAction Action { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "definition")]
        public TileDefinition Definition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "embedUrl")]
        public string EmbedUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "embedData")]
        public string EmbedData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filterError")]
        public PowerBIApiODataErrorResponse FilterError { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rowSpan")]
        public int? RowSpan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "colSpan")]
        public int? ColSpan { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Action != null)
            {
                this.Action.Validate();
            }
            if (this.Definition != null)
            {
                this.Definition.Validate();
            }
        }
    }
}
