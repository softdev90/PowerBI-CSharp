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
    /// The datasource credential details
    /// </summary>
    public partial class GatewayDatasourceCredentialDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GatewayDatasourceCredentialDetails class.
        /// </summary>
        public GatewayDatasourceCredentialDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GatewayDatasourceCredentialDetails class.
        /// </summary>
        /// <param name="useEndUserOAuth2Credentials">Indicates if the end-user
        /// OAuth2 credentials are used for connecting to the datasource in
        /// DirectQuery mode.</param>
        public GatewayDatasourceCredentialDetails(bool? useEndUserOAuth2Credentials = default(bool?))
        {
            UseEndUserOAuth2Credentials = useEndUserOAuth2Credentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates if the end-user OAuth2 credentials are used
        /// for connecting to the datasource in DirectQuery mode.
        /// </summary>
        [JsonProperty(PropertyName = "useEndUserOAuth2Credentials")]
        public bool? UseEndUserOAuth2Credentials { get; set; }

    }
}
