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
    /// Odata response wrapper for a Power BI user access right for app List
    /// </summary>
    public partial class AppUsers
    {
        /// <summary>
        /// Initializes a new instance of the AppUsers class.
        /// </summary>
        public AppUsers()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppUsers class.
        /// </summary>
        /// <param name="value">The user access right for app List</param>
        public AppUsers(string odatacontext = default(string), IList<AppUser> value = default(IList<AppUser>))
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
        /// Gets or sets the user access right for app List
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<AppUser> Value { get; set; }

    }
}
