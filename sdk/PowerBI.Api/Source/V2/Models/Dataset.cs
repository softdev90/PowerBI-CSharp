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
    /// A Power BI dataset
    /// </summary>
    public partial class Dataset
    {
        /// <summary>
        /// Initializes a new instance of the Dataset class.
        /// </summary>
        public Dataset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dataset class.
        /// </summary>
        /// <param name="id">The dataset id</param>
        /// <param name="name">The dataset name</param>
        /// <param name="configuredBy">The dataset owner</param>
        /// <param name="addRowsAPIEnabled">Whether dataset allows adding new
        /// rows</param>
        /// <param name="webUrl">The dataset web url</param>
        /// <param name="isRefreshable">Can this dataset be refreshed</param>
        /// <param name="isEffectiveIdentityRequired">Dataset requires
        /// effective identity</param>
        /// <param name="isEffectiveIdentityRolesRequired">Dataset requires
        /// roles</param>
        /// <param name="isOnPremGatewayRequired">Dataset requires an
        /// On-premises Data Gateway</param>
        /// <param name="encryption">The dataset encryption information (Only
        /// applicable when $expand is specified)</param>
        public Dataset(System.Guid id, string name = default(string), string configuredBy = default(string), bool? addRowsAPIEnabled = default(bool?), string webUrl = default(string), bool? isRefreshable = default(bool?), bool? isEffectiveIdentityRequired = default(bool?), bool? isEffectiveIdentityRolesRequired = default(bool?), bool? isOnPremGatewayRequired = default(bool?), Encryption encryption = default(Encryption))
        {
            Id = id;
            Name = name;
            ConfiguredBy = configuredBy;
            AddRowsAPIEnabled = addRowsAPIEnabled;
            WebUrl = webUrl;
            IsRefreshable = isRefreshable;
            IsEffectiveIdentityRequired = isEffectiveIdentityRequired;
            IsEffectiveIdentityRolesRequired = isEffectiveIdentityRolesRequired;
            IsOnPremGatewayRequired = isOnPremGatewayRequired;
            Encryption = encryption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataset id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the dataset name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dataset owner
        /// </summary>
        [JsonProperty(PropertyName = "configuredBy")]
        public string ConfiguredBy { get; set; }

        /// <summary>
        /// Gets or sets whether dataset allows adding new rows
        /// </summary>
        [JsonProperty(PropertyName = "addRowsAPIEnabled")]
        public bool? AddRowsAPIEnabled { get; set; }

        /// <summary>
        /// Gets or sets the dataset web url
        /// </summary>
        [JsonProperty(PropertyName = "webUrl")]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or sets can this dataset be refreshed
        /// </summary>
        [JsonProperty(PropertyName = "IsRefreshable")]
        public bool? IsRefreshable { get; set; }

        /// <summary>
        /// Gets or sets dataset requires effective identity
        /// </summary>
        [JsonProperty(PropertyName = "IsEffectiveIdentityRequired")]
        public bool? IsEffectiveIdentityRequired { get; set; }

        /// <summary>
        /// Gets or sets dataset requires roles
        /// </summary>
        [JsonProperty(PropertyName = "IsEffectiveIdentityRolesRequired")]
        public bool? IsEffectiveIdentityRolesRequired { get; set; }

        /// <summary>
        /// Gets or sets dataset requires an On-premises Data Gateway
        /// </summary>
        [JsonProperty(PropertyName = "IsOnPremGatewayRequired")]
        public bool? IsOnPremGatewayRequired { get; set; }

        /// <summary>
        /// Gets or sets the dataset encryption information (Only applicable
        /// when $expand is specified)
        /// </summary>
        [JsonProperty(PropertyName = "Encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
