// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.PowerBI.Api.V2;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Odata response wrapper for a Power BI Refresh history
    /// </summary>
    public partial class ODataResponseListRefresh
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListRefresh class.
        /// </summary>
        public ODataResponseListRefresh()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListRefresh class.
        /// </summary>
        /// <param name="value">The Refresh history list</param>
        public ODataResponseListRefresh(string odatacontext = default(string), IList<Refresh> value = default(IList<Refresh>))
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
        /// Gets or sets the Refresh history list
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Refresh> Value { get; set; }

    }
}
