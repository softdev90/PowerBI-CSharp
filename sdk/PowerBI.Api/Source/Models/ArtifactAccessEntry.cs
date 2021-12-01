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
    /// A user access entry for a Power BI item
    /// </summary>
    public partial class ArtifactAccessEntry
    {
        /// <summary>
        /// Initializes a new instance of the ArtifactAccessEntry class.
        /// </summary>
        public ArtifactAccessEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArtifactAccessEntry class.
        /// </summary>
        /// <param name="artifactId">The Power BI item ID</param>
        /// <param name="displayName">The display name of the Power BI
        /// item</param>
        /// <param name="artifactType">The type of Power BI item</param>
        /// <param name="accessRight">The access right that the user has for
        /// the Power BI item</param>
        public ArtifactAccessEntry(string artifactId, string displayName, string artifactType, string accessRight)
        {
            ArtifactId = artifactId;
            DisplayName = displayName;
            ArtifactType = artifactType;
            AccessRight = accessRight;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Power BI item ID
        /// </summary>
        [JsonProperty(PropertyName = "artifactId")]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the Power BI item
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the type of Power BI item
        /// </summary>
        [JsonProperty(PropertyName = "artifactType")]
        public string ArtifactType { get; set; }

        /// <summary>
        /// Gets or sets the access right that the user has for the Power BI
        /// item
        /// </summary>
        [JsonProperty(PropertyName = "accessRight")]
        public string AccessRight { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ArtifactId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ArtifactId");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (ArtifactType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ArtifactType");
            }
            if (AccessRight == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessRight");
            }
        }
    }
}
