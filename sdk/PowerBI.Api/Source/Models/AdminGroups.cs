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
    /// The OData response wrapper for a list of Power BI groups returned by
    /// Admin APIs
    /// </summary>
    public partial class AdminGroups
    {
        /// <summary>
        /// Initializes a new instance of the AdminGroups class.
        /// </summary>
        public AdminGroups()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminGroups class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The list of groups</param>
        public AdminGroups(string odatacontext = default(string), IList<AdminGroup> value = default(IList<AdminGroup>))
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
        /// Gets or sets the list of groups
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<AdminGroup> Value { get; set; }

    }
}
