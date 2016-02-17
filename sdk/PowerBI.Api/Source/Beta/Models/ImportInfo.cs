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
    public partial class ImportInfo
    {
        /// <summary>
        /// Initializes a new instance of the ImportInfo class.
        /// </summary>
        public ImportInfo() { }

        /// <summary>
        /// Initializes a new instance of the ImportInfo class.
        /// </summary>
        public ImportInfo(string filePath = default(string), string connectionType = default(string))
        {
            FilePath = filePath;
            ConnectionType = connectionType;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionType")]
        public string ConnectionType { get; set; }

    }
}
