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
    /// OData response wrapper for a collection of Power BI deployment pipeline
    /// users
    /// </summary>
    public partial class PipelineUsers
    {
        /// <summary>
        /// Initializes a new instance of the PipelineUsers class.
        /// </summary>
        public PipelineUsers()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineUsers class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The collection of deployment pipeline
        /// users</param>
        public PipelineUsers(string odatacontext = default(string), IList<PipelineUser> value = default(IList<PipelineUser>))
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
        /// Gets or sets the collection of deployment pipeline users
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PipelineUser> Value { get; set; }

    }
}
