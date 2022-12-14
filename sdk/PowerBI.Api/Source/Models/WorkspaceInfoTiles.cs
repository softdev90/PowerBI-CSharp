// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The OData response wrapper for a Power BI tile collection
    /// </summary>
    public partial class WorkspaceInfoTiles
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoTiles class.
        /// </summary>
        public WorkspaceInfoTiles()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoTiles class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The tile collection</param>
        public WorkspaceInfoTiles(string odatacontext = default(string), IList<WorkspaceInfoTile> value = default(IList<WorkspaceInfoTile>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oData context
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the tile collection
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<WorkspaceInfoTile> Value { get; set; }

    }
}
