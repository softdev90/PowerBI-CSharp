// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Odata response wrapper for a Power BI group list
    /// </summary>
    public partial class ODataResponseListGroup
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListGroup class.
        /// </summary>
        public ODataResponseListGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListGroup class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The groups</param>
        public ODataResponseListGroup(string odatacontext = default(string), IList<Group> value = default(IList<Group>))
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
        /// Gets or sets the groups
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Group> Value { get; set; }

    }
}
