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
    /// A publish data source to gateway request
    /// </summary>
    public partial class PublishDatasourceToGatewayRequest
    {
        /// <summary>
        /// Initializes a new instance of the PublishDatasourceToGatewayRequest
        /// class.
        /// </summary>
        public PublishDatasourceToGatewayRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublishDatasourceToGatewayRequest
        /// class.
        /// </summary>
        /// <param name="dataSourceType">The data source type</param>
        /// <param name="connectionDetails">The connection details</param>
        /// <param name="dataSourceName">The data source name</param>
        public PublishDatasourceToGatewayRequest(string dataSourceType, string connectionDetails, CredentialDetails credentialDetails, string dataSourceName)
        {
            DataSourceType = dataSourceType;
            ConnectionDetails = connectionDetails;
            CredentialDetails = credentialDetails;
            DataSourceName = dataSourceName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data source type
        /// </summary>
        [JsonProperty(PropertyName = "dataSourceType")]
        public string DataSourceType { get; set; }

        /// <summary>
        /// Gets or sets the connection details
        /// </summary>
        [JsonProperty(PropertyName = "connectionDetails")]
        public string ConnectionDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentialDetails")]
        public CredentialDetails CredentialDetails { get; set; }

        /// <summary>
        /// Gets or sets the data source name
        /// </summary>
        [JsonProperty(PropertyName = "dataSourceName")]
        public string DataSourceName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataSourceType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSourceType");
            }
            if (ConnectionDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionDetails");
            }
            if (CredentialDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CredentialDetails");
            }
            if (DataSourceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSourceName");
            }
            if (CredentialDetails != null)
            {
                CredentialDetails.Validate();
            }
        }
    }
}
