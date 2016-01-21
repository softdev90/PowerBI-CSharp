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
    public partial class Dashboard
    {
        /// <summary>
        /// Initializes a new instance of the Dashboard class.
        /// </summary>
        public Dashboard() { }

        /// <summary>
        /// Initializes a new instance of the Dashboard class.
        /// </summary>
        public Dashboard(string id = default(string), string displayName = default(string), bool? isReadOnly = default(bool?), IList<Tile> tiles = default(IList<Tile>))
        {
            Id = id;
            DisplayName = displayName;
            IsReadOnly = isReadOnly;
            Tiles = tiles;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isReadOnly")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tiles")]
        public IList<Tile> Tiles { get; set; }

    }
}
