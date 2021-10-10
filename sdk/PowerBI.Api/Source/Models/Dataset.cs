// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Power BI dataset. Below is a list of properties that may be returned
    /// for a dataset. Only a subset of the properties will be returned
    /// depending on the API called, the caller permissions and the
    /// availability of the data in the Power BI database.
    /// </summary>
    public partial class Dataset
    {
        /// <summary>
        /// Initializes a new instance of the Dataset class.
        /// </summary>
        public Dataset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dataset class.
        /// </summary>
        /// <param name="id">The dataset ID</param>
        /// <param name="name">The dataset name</param>
        /// <param name="configuredBy">The dataset owner</param>
        /// <param name="addRowsAPIEnabled">Whether the dataset allows adding
        /// new rows</param>
        /// <param name="webUrl">The dataset web url</param>
        /// <param name="isRefreshable">Can this dataset be refreshed</param>
        /// <param name="isEffectiveIdentityRequired">Whether the dataset
        /// requires an effective identity. This indicates that you must send
        /// an effective identity using the GenerateToken API.</param>
        /// <param name="isEffectiveIdentityRolesRequired">Whether RLS is
        /// defined inside the PBIX file. This indicates that you must specify
        /// a role.</param>
        /// <param name="isOnPremGatewayRequired">Dataset requires an
        /// On-premises Data Gateway</param>
        /// <param name="encryption">The dataset encryption information (Only
        /// applicable when $expand is specified)</param>
        /// <param name="createdDate">DateTime of creation of this
        /// dataset</param>
        /// <param name="contentProviderType">The content provider type for the
        /// dataset</param>
        /// <param name="createReportEmbedURL">The dataset create report embed
        /// url</param>
        /// <param name="qnaEmbedURL">The dataset qna embed url</param>
        /// <param name="description">The dataset description</param>
        /// <param name="endorsementDetails">The dataset endorsement
        /// details</param>
        /// <param name="datasourceUsages">Datasource usages</param>
        /// <param name="upstreamDataflows">Upstream Dataflows</param>
        /// <param name="tables">The dataset tables</param>
        /// <param name="sensitivityLabel">The dataset sensitivity label. Only
        /// available for admin APIs.</param>
        /// <param name="users">The Dataset User Access Details. This value
        /// will be empty. It will be removed from the payload response in an
        /// upcoming release. To retrieve user information on an artifact,
        /// please consider using the Get Dataset User as Admin APIs, or the
        /// PostWorkspaceInfo API with the getArtifactUser parameter.</param>
        /// <param name="schemaRetrievalError">The dataset schema retrieval
        /// error</param>
        /// <param name="schemaMayNotBeUpToDate">Whether dataset schema may not
        /// be up to date</param>
        public Dataset(string id, string name = default(string), string configuredBy = default(string), bool? addRowsAPIEnabled = default(bool?), string webUrl = default(string), bool? isRefreshable = default(bool?), bool? isEffectiveIdentityRequired = default(bool?), bool? isEffectiveIdentityRolesRequired = default(bool?), bool? isOnPremGatewayRequired = default(bool?), Encryption encryption = default(Encryption), System.DateTime? createdDate = default(System.DateTime?), string contentProviderType = default(string), string createReportEmbedURL = default(string), string qnaEmbedURL = default(string), string description = default(string), EndorsementDetails endorsementDetails = default(EndorsementDetails), IList<DatasourceUsage> datasourceUsages = default(IList<DatasourceUsage>), IList<DependentDataflow> upstreamDataflows = default(IList<DependentDataflow>), IList<Table> tables = default(IList<Table>), SensitivityLabel sensitivityLabel = default(SensitivityLabel), IList<DatasetUser> users = default(IList<DatasetUser>), string schemaRetrievalError = default(string), bool? schemaMayNotBeUpToDate = default(bool?))
        {
            Id = id;
            Name = name;
            ConfiguredBy = configuredBy;
            AddRowsAPIEnabled = addRowsAPIEnabled;
            WebUrl = webUrl;
            IsRefreshable = isRefreshable;
            IsEffectiveIdentityRequired = isEffectiveIdentityRequired;
            IsEffectiveIdentityRolesRequired = isEffectiveIdentityRolesRequired;
            IsOnPremGatewayRequired = isOnPremGatewayRequired;
            Encryption = encryption;
            CreatedDate = createdDate;
            ContentProviderType = contentProviderType;
            CreateReportEmbedURL = createReportEmbedURL;
            QnaEmbedURL = qnaEmbedURL;
            Description = description;
            EndorsementDetails = endorsementDetails;
            DatasourceUsages = datasourceUsages;
            UpstreamDataflows = upstreamDataflows;
            Tables = tables;
            SensitivityLabel = sensitivityLabel;
            Users = users;
            SchemaRetrievalError = schemaRetrievalError;
            SchemaMayNotBeUpToDate = schemaMayNotBeUpToDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataset ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the dataset name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dataset owner
        /// </summary>
        [JsonProperty(PropertyName = "configuredBy")]
        public string ConfiguredBy { get; set; }

        /// <summary>
        /// Gets or sets whether the dataset allows adding new rows
        /// </summary>
        [JsonProperty(PropertyName = "addRowsAPIEnabled")]
        public bool? AddRowsAPIEnabled { get; set; }

        /// <summary>
        /// Gets or sets the dataset web url
        /// </summary>
        [JsonProperty(PropertyName = "webUrl")]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or sets can this dataset be refreshed
        /// </summary>
        [JsonProperty(PropertyName = "IsRefreshable")]
        public bool? IsRefreshable { get; set; }

        /// <summary>
        /// Gets or sets whether the dataset requires an effective identity.
        /// This indicates that you must send an effective identity using the
        /// GenerateToken API.
        /// </summary>
        [JsonProperty(PropertyName = "IsEffectiveIdentityRequired")]
        public bool? IsEffectiveIdentityRequired { get; set; }

        /// <summary>
        /// Gets or sets whether RLS is defined inside the PBIX file. This
        /// indicates that you must specify a role.
        /// </summary>
        [JsonProperty(PropertyName = "IsEffectiveIdentityRolesRequired")]
        public bool? IsEffectiveIdentityRolesRequired { get; set; }

        /// <summary>
        /// Gets or sets dataset requires an On-premises Data Gateway
        /// </summary>
        [JsonProperty(PropertyName = "IsOnPremGatewayRequired")]
        public bool? IsOnPremGatewayRequired { get; set; }

        /// <summary>
        /// Gets or sets the dataset encryption information (Only applicable
        /// when $expand is specified)
        /// </summary>
        [JsonProperty(PropertyName = "Encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets dateTime of creation of this dataset
        /// </summary>
        [JsonProperty(PropertyName = "CreatedDate")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the content provider type for the dataset
        /// </summary>
        [JsonProperty(PropertyName = "ContentProviderType")]
        public string ContentProviderType { get; set; }

        /// <summary>
        /// Gets or sets the dataset create report embed url
        /// </summary>
        [JsonProperty(PropertyName = "CreateReportEmbedURL")]
        public string CreateReportEmbedURL { get; set; }

        /// <summary>
        /// Gets or sets the dataset qna embed url
        /// </summary>
        [JsonProperty(PropertyName = "QnaEmbedURL")]
        public string QnaEmbedURL { get; set; }

        /// <summary>
        /// Gets or sets the dataset description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the dataset endorsement details
        /// </summary>
        [JsonProperty(PropertyName = "endorsementDetails")]
        public EndorsementDetails EndorsementDetails { get; set; }

        /// <summary>
        /// Gets or sets datasource usages
        /// </summary>
        [JsonProperty(PropertyName = "datasourceUsages")]
        public IList<DatasourceUsage> DatasourceUsages { get; set; }

        /// <summary>
        /// Gets or sets upstream Dataflows
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDataflows")]
        public IList<DependentDataflow> UpstreamDataflows { get; set; }

        /// <summary>
        /// Gets or sets the dataset tables
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<Table> Tables { get; set; }

        /// <summary>
        /// Gets or sets the dataset sensitivity label. Only available for
        /// admin APIs.
        /// </summary>
        [JsonProperty(PropertyName = "sensitivityLabel")]
        public SensitivityLabel SensitivityLabel { get; set; }

        /// <summary>
        /// Gets or sets the Dataset User Access Details. This value will be
        /// empty. It will be removed from the payload response in an upcoming
        /// release. To retrieve user information on an artifact, please
        /// consider using the Get Dataset User as Admin APIs, or the
        /// PostWorkspaceInfo API with the getArtifactUser parameter.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<DatasetUser> Users { get; set; }

        /// <summary>
        /// Gets or sets the dataset schema retrieval error
        /// </summary>
        [JsonProperty(PropertyName = "schemaRetrievalError")]
        public string SchemaRetrievalError { get; set; }

        /// <summary>
        /// Gets or sets whether dataset schema may not be up to date
        /// </summary>
        [JsonProperty(PropertyName = "schemaMayNotBeUpToDate")]
        public bool? SchemaMayNotBeUpToDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (DatasourceUsages != null)
            {
                foreach (var element in DatasourceUsages)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Tables != null)
            {
                foreach (var element1 in Tables)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (SensitivityLabel != null)
            {
                SensitivityLabel.Validate();
            }
            if (Users != null)
            {
                foreach (var element2 in Users)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
