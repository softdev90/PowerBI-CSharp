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
    /// A list of security related properties of a Power BI dataset.
    /// </summary>
    public partial class DatasetSecurityProperties
    {
        /// <summary>
        /// Initializes a new instance of the DatasetSecurityProperties class.
        /// </summary>
        public DatasetSecurityProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetSecurityProperties class.
        /// </summary>
        /// <param name="isEffectiveIdentityRequired">Whether the dataset
        /// requires an effective identity, which you must send in a
        /// [GenerateToken](/rest/api/power-bi/embed-token/generate-token) API
        /// call.</param>
        /// <param name="isEffectiveIdentityRolesRequired">Whether row-level
        /// security is defined inside the Power BI .pbix file. If so, you must
        /// specify a role.</param>
        /// <param name="isOnPremGatewayRequired">Whether the dataset requires
        /// an on-premises data gateway</param>
        /// <param name="encryption">Dataset encryption information. Only
        /// applicable when `$expand` is specified.</param>
        public DatasetSecurityProperties(bool? isEffectiveIdentityRequired = default(bool?), bool? isEffectiveIdentityRolesRequired = default(bool?), bool? isOnPremGatewayRequired = default(bool?), Encryption encryption = default(Encryption))
        {
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
        /// Gets or sets whether the dataset requires an effective identity,
        /// which you must send in a
        /// [GenerateToken](/rest/api/power-bi/embed-token/generate-token) API
        /// call.
        /// </summary>
        [JsonProperty(PropertyName = "IsEffectiveIdentityRequired")]
        public bool? IsEffectiveIdentityRequired { get; set; }

        /// <summary>
        /// Gets or sets whether row-level security is defined inside the Power
        /// BI .pbix file. If so, you must specify a role.
        /// </summary>
        [JsonProperty(PropertyName = "IsEffectiveIdentityRolesRequired")]
        public bool? IsEffectiveIdentityRolesRequired { get; set; }

        /// <summary>
        /// Gets or sets whether the dataset requires an on-premises data
        /// gateway
        /// </summary>
        [JsonProperty(PropertyName = "IsOnPremGatewayRequired")]
        public bool? IsOnPremGatewayRequired { get; set; }

        /// <summary>
        /// Gets or sets dataset encryption information. Only applicable when
        /// `$expand` is specified.
        /// </summary>
        [JsonProperty(PropertyName = "Encryption")]
        public Encryption Encryption { get; set; }

    }
}
