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
    /// Odata response wrapper for a Power BI Available Features List
    /// </summary>
    public partial class ODataResponseListAvailableFeature
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListAvailableFeature
        /// class.
        /// </summary>
        public ODataResponseListAvailableFeature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListAvailableFeature
        /// class.
        /// </summary>
        /// <param name="features">The Available Features List</param>
        public ODataResponseListAvailableFeature(string odatacontext = default(string), IList<AvailableFeature> features = default(IList<AvailableFeature>))
        {
            Odatacontext = odatacontext;
            Features = features;
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
        /// Gets or sets the Available Features List
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<AvailableFeature> Features { get; set; }

    }
}
