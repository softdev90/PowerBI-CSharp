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
    /// The credential details
    /// </summary>
    public partial class CredentialDetails
    {
        /// <summary>
        /// Initializes a new instance of the CredentialDetails class.
        /// </summary>
        public CredentialDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialDetails class.
        /// </summary>
        /// <param name="credentials">The credentials</param>
        /// <param name="credentialType">The connection type</param>
        /// <param name="encryptedConnection">The encrypted connection</param>
        /// <param name="encryptionAlgorithm">The encryption algorithm</param>
        /// <param name="privacyLevel">The privacy level</param>
        public CredentialDetails(string credentials = default(string), string credentialType = default(string), string encryptedConnection = default(string), string encryptionAlgorithm = default(string), string privacyLevel = default(string))
        {
            Credentials = credentials;
            CredentialType = credentialType;
            EncryptedConnection = encryptedConnection;
            EncryptionAlgorithm = encryptionAlgorithm;
            PrivacyLevel = privacyLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the credentials
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public string Credentials { get; set; }

        /// <summary>
        /// Gets or sets the connection type
        /// </summary>
        [JsonProperty(PropertyName = "credentialType")]
        public string CredentialType { get; set; }

        /// <summary>
        /// Gets or sets the encrypted connection
        /// </summary>
        [JsonProperty(PropertyName = "encryptedConnection")]
        public string EncryptedConnection { get; set; }

        /// <summary>
        /// Gets or sets the encryption algorithm
        /// </summary>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        public string EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the privacy level
        /// </summary>
        [JsonProperty(PropertyName = "privacyLevel")]
        public string PrivacyLevel { get; set; }

    }
}
