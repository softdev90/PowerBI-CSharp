// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AdminApp : App
    {
        /// <summary>
        /// Initializes a new instance of the AdminApp class.
        /// </summary>
        public AdminApp()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminApp class.
        /// </summary>
        /// <param name="id">The app ID</param>
        /// <param name="name">The app name</param>
        /// <param name="description">The app description</param>
        /// <param name="lastUpdate">The date and time the app was last
        /// updated</param>
        /// <param name="publishedBy">The app publisher</param>
        /// <param name="workspaceId">Associated workspace for the app</param>
        public AdminApp(System.Guid id, string name = default(string), string description = default(string), System.DateTime? lastUpdate = default(System.DateTime?), string publishedBy = default(string), string workspaceId = default(string))
            : base(id, name, description, lastUpdate, publishedBy)
        {
            WorkspaceId = workspaceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets associated workspace for the app
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
