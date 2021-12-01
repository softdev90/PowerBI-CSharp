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
    /// The OData response wrapper for a Power BI refresh history list
    /// </summary>
    public partial class Refreshes
    {
        /// <summary>
        /// Initializes a new instance of the Refreshes class.
        /// </summary>
        public Refreshes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Refreshes class.
        /// </summary>
        /// <param name="value">The refresh history list</param>
        public Refreshes(string odatacontext = default(string), IList<Refresh> value = default(IList<Refresh>))
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
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the refresh history list
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Refresh> Value { get; set; }

    }
}
