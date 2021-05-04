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
    /// A Power BI user access right entry for dataflow
    /// </summary>
    public partial class DataflowUser
    {
        /// <summary>
        /// Initializes a new instance of the DataflowUser class.
        /// </summary>
        public DataflowUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataflowUser class.
        /// </summary>
        /// <param name="dataflowUserAccessRight">Access rights user has for
        /// the dataflow. Possible values include: 'None', 'Read', 'ReadWrite',
        /// 'ReadReshare', 'Owner'</param>
        /// <param name="emailAddress">Email address of the user</param>
        /// <param name="displayName">Display name of the principal</param>
        /// <param name="identifier">Identifier of the principal</param>
        /// <param name="graphId">Identifier of the principal in Microsoft
        /// Graph. Only available for admin APIs.</param>
        /// <param name="principalType">Possible values include: 'None',
        /// 'User', 'Group', 'App'</param>
        public DataflowUser(DataflowUserAccessRight? dataflowUserAccessRight = default(DataflowUserAccessRight?), string emailAddress = default(string), string displayName = default(string), string identifier = default(string), string graphId = default(string), PrincipalType? principalType = default(PrincipalType?))
        {
            DataflowUserAccessRight = dataflowUserAccessRight;
            EmailAddress = emailAddress;
            DisplayName = displayName;
            Identifier = identifier;
            GraphId = graphId;
            PrincipalType = principalType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets access rights user has for the dataflow. Possible
        /// values include: 'None', 'Read', 'ReadWrite', 'ReadReshare', 'Owner'
        /// </summary>
        [JsonProperty(PropertyName = "DataflowUserAccessRight")]
        public DataflowUserAccessRight? DataflowUserAccessRight { get; set; }

        /// <summary>
        /// Gets or sets email address of the user
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets display name of the principal
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets identifier of the principal
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets identifier of the principal in Microsoft Graph. Only
        /// available for admin APIs.
        /// </summary>
        [JsonProperty(PropertyName = "graphId")]
        public string GraphId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'User', 'Group',
        /// 'App'
        /// </summary>
        [JsonProperty(PropertyName = "principalType")]
        public PrincipalType? PrincipalType { get; set; }

    }
}
