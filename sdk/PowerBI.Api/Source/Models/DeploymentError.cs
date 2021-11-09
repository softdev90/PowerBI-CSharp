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
    /// Error details for the deployment step
    /// </summary>
    public partial class DeploymentError
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentError class.
        /// </summary>
        public DeploymentError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentError class.
        /// </summary>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorDetails">Additional error details</param>
        public DeploymentError(string errorCode = default(string), string errorDetails = default(string))
        {
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the error code
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets additional error details
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public string ErrorDetails { get; set; }

    }
}
