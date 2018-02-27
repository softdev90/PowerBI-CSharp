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
    /// Odata response wrapper for a Power BI dataset parameter list
    /// </summary>
    public partial class ODataResponseListDatasetParameter
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListDatasetParameter
        /// class.
        /// </summary>
        public ODataResponseListDatasetParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListDatasetParameter
        /// class.
        /// </summary>
        /// <param name="value">The dataset parameter List</param>
        public ODataResponseListDatasetParameter(string odatacontext = default(string), IList<DatasetParameter> value = default(IList<DatasetParameter>))
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
        /// Gets or sets the dataset parameter List
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<DatasetParameter> Value { get; set; }

    }
}
