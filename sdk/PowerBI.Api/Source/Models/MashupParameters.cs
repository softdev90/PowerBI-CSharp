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
    /// The OData response wrapper for a list of Power BI dataset parameters
    /// </summary>
    public partial class MashupParameters
    {
        /// <summary>
        /// Initializes a new instance of the MashupParameters class.
        /// </summary>
        public MashupParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MashupParameters class.
        /// </summary>
        /// <param name="value">A list of dataset parameters</param>
        public MashupParameters(string odatacontext = default(string), IList<MashupParameter> value = default(IList<MashupParameter>))
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
        /// Gets or sets a list of dataset parameters
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MashupParameter> Value { get; set; }

    }
}
