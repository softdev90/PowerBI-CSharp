// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.PowerBI.Api.V1;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI gateway datasource
    /// </summary>
    public partial class GatewayDatasource
    {
        /// <summary>
        /// Initializes a new instance of the GatewayDatasource class.
        /// </summary>
        public GatewayDatasource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayDatasource class.
        /// </summary>
        /// <param name="id">The unique id for this gateway datasource</param>
        /// <param name="gatewayId">The associated gateway id</param>
        /// <param name="datasourceType">The datasource type</param>
        /// <param name="connectionDetails">The datasource connection
        /// details</param>
        /// <param name="credentialType">The datasource credential type</param>
        /// <param name="basicCredentials">The datasource basic
        /// credential</param>
        public GatewayDatasource(string id = default(string), string gatewayId = default(string), string datasourceType = default(string), string connectionDetails = default(string), string credentialType = default(string), BasicCredentials basicCredentials = default(BasicCredentials))
        {
            Id = id;
            GatewayId = gatewayId;
            DatasourceType = datasourceType;
            ConnectionDetails = connectionDetails;
            CredentialType = credentialType;
            BasicCredentials = basicCredentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique id for this gateway datasource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the associated gateway id
        /// </summary>
        [JsonProperty(PropertyName = "gatewayId")]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or sets the datasource type
        /// </summary>
        [JsonProperty(PropertyName = "datasourceType")]
        public string DatasourceType { get; set; }

        /// <summary>
        /// Gets or sets the datasource connection details
        /// </summary>
        [JsonProperty(PropertyName = "connectionDetails")]
        public string ConnectionDetails { get; set; }

        /// <summary>
        /// Gets or sets the datasource credential type
        /// </summary>
        [JsonProperty(PropertyName = "credentialType")]
        public string CredentialType { get; set; }

        /// <summary>
        /// Gets or sets the datasource basic credential
        /// </summary>
        [JsonProperty(PropertyName = "basicCredentials")]
        public BasicCredentials BasicCredentials { get; set; }

    }
}
