// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.PowerBI.Api.V2;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The identity that the generated token should reflect
    /// </summary>
    public partial class RlsContext
    {
        /// <summary>
        /// Initializes a new instance of the RlsContext class.
        /// </summary>
        public RlsContext()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RlsContext class.
        /// </summary>
        /// <param name="username">The effective username reflected by a token
        /// for applying RLS rules</param>
        /// <param name="aadToken">An AAD token representing the effective
        /// identity reflected by a token for applying RLS rules</param>
        /// <param name="roles">An array of roles reflected by a token when
        /// applying RLS rules</param>
        public RlsContext(string username = default(string), string aadToken = default(string), IList<string> roles = default(IList<string>))
        {
            Username = username;
            AadToken = aadToken;
            Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the effective username reflected by a token for
        /// applying RLS rules
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets an AAD token representing the effective identity
        /// reflected by a token for applying RLS rules
        /// </summary>
        [JsonProperty(PropertyName = "aadToken")]
        public string AadToken { get; set; }

        /// <summary>
        /// Gets or sets an array of roles reflected by a token when applying
        /// RLS rules
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }

    }
}
