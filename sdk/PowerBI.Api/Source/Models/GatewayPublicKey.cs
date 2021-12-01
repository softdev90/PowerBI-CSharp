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
    /// A Power BI gateway public key
    /// </summary>
    public partial class GatewayPublicKey
    {
        /// <summary>
        /// Initializes a new instance of the GatewayPublicKey class.
        /// </summary>
        public GatewayPublicKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayPublicKey class.
        /// </summary>
        /// <param name="exponent">The public key exponent</param>
        /// <param name="modulus">The public key modulus</param>
        public GatewayPublicKey(string exponent = default(string), string modulus = default(string))
        {
            Exponent = exponent;
            Modulus = modulus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the public key exponent
        /// </summary>
        [JsonProperty(PropertyName = "exponent")]
        public string Exponent { get; set; }

        /// <summary>
        /// Gets or sets the public key modulus
        /// </summary>
        [JsonProperty(PropertyName = "modulus")]
        public string Modulus { get; set; }

    }
}
