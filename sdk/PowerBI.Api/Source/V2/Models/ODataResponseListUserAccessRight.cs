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
    /// Odata response wrapper for a Power BI user Access Right for datasource
    /// List
    /// </summary>
    public partial class ODataResponseListUserAccessRight
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListUserAccessRight
        /// class.
        /// </summary>
        public ODataResponseListUserAccessRight()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListUserAccessRight
        /// class.
        /// </summary>
        /// <param name="value">The user Access Right for datasource
        /// List</param>
        public ODataResponseListUserAccessRight(string odatacontext = default(string), IList<UserAccessRight> value = default(IList<UserAccessRight>))
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
        /// Gets or sets the user Access Right for datasource List
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<UserAccessRight> Value { get; set; }

    }
}
