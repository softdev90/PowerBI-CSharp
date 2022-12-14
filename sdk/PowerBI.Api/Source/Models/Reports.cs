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
    /// The OData response wrapper for a Power BI report collection
    /// </summary>
    public partial class Reports
    {
        /// <summary>
        /// Initializes a new instance of the Reports class.
        /// </summary>
        public Reports()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Reports class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The report collection</param>
        public Reports(string odatacontext = default(string), IList<Report> value = default(IList<Report>))
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
        /// Gets or sets the report collection
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Report> Value { get; set; }

    }
}
