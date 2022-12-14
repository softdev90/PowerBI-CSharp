// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI installed app
    /// </summary>
    public partial class App
    {
        /// <summary>
        /// Initializes a new instance of the App class.
        /// </summary>
        public App()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the App class.
        /// </summary>
        /// <param name="id">The app ID</param>
        /// <param name="name">The app name</param>
        /// <param name="description">The app description</param>
        /// <param name="lastUpdate">The date and time the app was last
        /// updated</param>
        /// <param name="publishedBy">The app publisher</param>
        public App(System.Guid id, string name = default(string), string description = default(string), System.DateTime? lastUpdate = default(System.DateTime?), string publishedBy = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            LastUpdate = lastUpdate;
            PublishedBy = publishedBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the app ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the app name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the app description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date and time the app was last updated
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdate")]
        public System.DateTime? LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the app publisher
        /// </summary>
        [JsonProperty(PropertyName = "publishedBy")]
        public string PublishedBy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
