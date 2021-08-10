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
    /// A Power BI dashboard. Below is a list of properties that may be
    /// returned for a dashboard. Only a subset of the properties will be
    /// returned depending on the API called, the caller permissions and the
    /// availability of the data in the Power BI database.
    /// </summary>
    public partial class Dashboard
    {
        /// <summary>
        /// Initializes a new instance of the Dashboard class.
        /// </summary>
        public Dashboard()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dashboard class.
        /// </summary>
        /// <param name="id">The dashboard id</param>
        /// <param name="displayName">The dashboard display name</param>
        /// <param name="isReadOnly">Is ReadOnly dashboard</param>
        /// <param name="embedUrl">The dashboard embed url</param>
        /// <param name="tiles">The tiles that belong to the dashboard.</param>
        /// <param name="dataClassification">The data classification tag of the
        /// dashboard</param>
        /// <param name="sensitivityLabel">The dashboard sensitivity
        /// label</param>
        /// <param name="users">The Dashboard User Access Details, only apply
        /// when user information is requested explicitly.</param>
        public Dashboard(System.Guid id, string displayName = default(string), bool? isReadOnly = default(bool?), string embedUrl = default(string), IList<Tile> tiles = default(IList<Tile>), string dataClassification = default(string), SensitivityLabel sensitivityLabel = default(SensitivityLabel), IList<DashboardUser> users = default(IList<DashboardUser>))
        {
            Id = id;
            DisplayName = displayName;
            IsReadOnly = isReadOnly;
            EmbedUrl = embedUrl;
            Tiles = tiles;
            DataClassification = dataClassification;
            SensitivityLabel = sensitivityLabel;
            Users = users;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dashboard id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the dashboard display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets is ReadOnly dashboard
        /// </summary>
        [JsonProperty(PropertyName = "isReadOnly")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the dashboard embed url
        /// </summary>
        [JsonProperty(PropertyName = "embedUrl")]
        public string EmbedUrl { get; set; }

        /// <summary>
        /// Gets or sets the tiles that belong to the dashboard.
        /// </summary>
        [JsonProperty(PropertyName = "tiles")]
        public IList<Tile> Tiles { get; set; }

        /// <summary>
        /// Gets or sets the data classification tag of the dashboard
        /// </summary>
        [JsonProperty(PropertyName = "dataClassification")]
        public string DataClassification { get; set; }

        /// <summary>
        /// Gets or sets the dashboard sensitivity label
        /// </summary>
        [JsonProperty(PropertyName = "sensitivityLabel")]
        public SensitivityLabel SensitivityLabel { get; set; }

        /// <summary>
        /// Gets or sets the Dashboard User Access Details, only apply when
        /// user information is requested explicitly.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<DashboardUser> Users { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Tiles != null)
            {
                foreach (var element in Tiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (SensitivityLabel != null)
            {
                SensitivityLabel.Validate();
            }
            if (Users != null)
            {
                foreach (var element1 in Users)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
