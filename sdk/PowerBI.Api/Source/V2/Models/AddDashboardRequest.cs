// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI add dashboard request
    /// </summary>
    public partial class AddDashboardRequest
    {
        /// <summary>
        /// Initializes a new instance of the AddDashboardRequest class.
        /// </summary>
        public AddDashboardRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddDashboardRequest class.
        /// </summary>
        /// <param name="name">The name of the new dashboard</param>
        public AddDashboardRequest(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the new dashboard
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
