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
    /// OData response wrapper for a Power BI capacity list
    /// </summary>
    public partial class Capacities
    {
        /// <summary>
        /// Initializes a new instance of the Capacities class.
        /// </summary>
        public Capacities()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Capacities class.
        /// </summary>
        /// <param name="value">The capacity list</param>
        public Capacities(string odatacontext = default(string), IList<Capacity> value = default(IList<Capacity>))
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
        /// Gets or sets the capacity list
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Capacity> Value { get; set; }

    }
}
