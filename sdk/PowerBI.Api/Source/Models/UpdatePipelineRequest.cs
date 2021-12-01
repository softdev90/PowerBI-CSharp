// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A request to update an existing deployment pipeline. An updated display
    /// name and/or a description is required.
    /// </summary>
    public partial class UpdatePipelineRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdatePipelineRequest class.
        /// </summary>
        public UpdatePipelineRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdatePipelineRequest class.
        /// </summary>
        /// <param name="displayName">The updated display name for the
        /// deployment pipeline</param>
        /// <param name="description">The updated description for the
        /// deployment pipeline</param>
        public UpdatePipelineRequest(string displayName = default(string), string description = default(string))
        {
            DisplayName = displayName;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the updated display name for the deployment pipeline
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the updated description for the deployment pipeline
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName != null)
            {
                if (DisplayName.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 256);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 1024)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 1024);
                }
            }
        }
    }
}
