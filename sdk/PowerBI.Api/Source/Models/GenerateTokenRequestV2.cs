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
    /// Power BI Generate Token Request V2
    /// </summary>
    public partial class GenerateTokenRequestV2
    {
        /// <summary>
        /// Initializes a new instance of the GenerateTokenRequestV2 class.
        /// </summary>
        public GenerateTokenRequestV2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenerateTokenRequestV2 class.
        /// </summary>
        /// <param name="datasets">A list of datasets</param>
        /// <param name="reports">A list of reports</param>
        /// <param name="targetWorkspaces">The list of workspaces that the
        /// embed token will allow saving to</param>
        /// <param name="identities">The list of identities to use for
        /// row-level security rules</param>
        /// <param name="lifetimeInMinutes">The maximum lifetime of the token
        /// in minutes, starting from the time it was generated. Can be used to
        /// shorten the token's expiration time, but not to extend it. The
        /// value must be a positive integer. Zero (`0`) is equivalent to
        /// `null`, and will set the default expiration time.</param>
        /// <param name="datasourceIdentities">List of identities to use when
        /// connecting to data sources with Single Sign-On (SSO)
        /// enabled.</param>
        public GenerateTokenRequestV2(IList<GenerateTokenRequestV2Dataset> datasets = default(IList<GenerateTokenRequestV2Dataset>), IList<GenerateTokenRequestV2Report> reports = default(IList<GenerateTokenRequestV2Report>), IList<GenerateTokenRequestV2TargetWorkspace> targetWorkspaces = default(IList<GenerateTokenRequestV2TargetWorkspace>), IList<EffectiveIdentity> identities = default(IList<EffectiveIdentity>), int? lifetimeInMinutes = default(int?), IList<DatasourceIdentity> datasourceIdentities = default(IList<DatasourceIdentity>))
        {
            Datasets = datasets;
            Reports = reports;
            TargetWorkspaces = targetWorkspaces;
            Identities = identities;
            LifetimeInMinutes = lifetimeInMinutes;
            DatasourceIdentities = datasourceIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of datasets
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public IList<GenerateTokenRequestV2Dataset> Datasets { get; set; }

        /// <summary>
        /// Gets or sets a list of reports
        /// </summary>
        [JsonProperty(PropertyName = "reports")]
        public IList<GenerateTokenRequestV2Report> Reports { get; set; }

        /// <summary>
        /// Gets or sets the list of workspaces that the embed token will allow
        /// saving to
        /// </summary>
        [JsonProperty(PropertyName = "targetWorkspaces")]
        public IList<GenerateTokenRequestV2TargetWorkspace> TargetWorkspaces { get; set; }

        /// <summary>
        /// Gets or sets the list of identities to use for row-level security
        /// rules
        /// </summary>
        [JsonProperty(PropertyName = "identities")]
        public IList<EffectiveIdentity> Identities { get; set; }

        /// <summary>
        /// Gets or sets the maximum lifetime of the token in minutes, starting
        /// from the time it was generated. Can be used to shorten the token's
        /// expiration time, but not to extend it. The value must be a positive
        /// integer. Zero (`0`) is equivalent to `null`, and will set the
        /// default expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "lifetimeInMinutes")]
        public int? LifetimeInMinutes { get; set; }

        /// <summary>
        /// Gets or sets list of identities to use when connecting to data
        /// sources with Single Sign-On (SSO) enabled.
        /// </summary>
        [JsonProperty(PropertyName = "datasourceIdentities")]
        public IList<DatasourceIdentity> DatasourceIdentities { get; set; }

    }
}
