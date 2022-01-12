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
    /// A Power BI dataset returned by WorkspaceInfo APIs. The API returns a
    /// subset of the following list of dataset properties. The subset depends
    /// on the API called, caller permissions, and the availability of the data
    /// in the Power BI database.
    /// </summary>
    public partial class WorkspaceInfoDataset
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDataset class.
        /// </summary>
        public WorkspaceInfoDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDataset class.
        /// </summary>
        /// <param name="id">The dataset ID</param>
        /// <param name="name">The dataset name</param>
        /// <param name="configuredBy">The dataset owner</param>
        /// <param name="createdDate">The dataset creation date and
        /// time</param>
        /// <param name="contentProviderType">The content provider type for the
        /// dataset</param>
        /// <param name="description">The dataset description</param>
        /// <param name="upstreamDataflows">The upstream dataflows</param>
        /// <param name="tables">The dataset tables</param>
        /// <param name="schemaRetrievalError">The dataset schema retrieval
        /// error</param>
        /// <param name="schemaMayNotBeUpToDate">Whether the dataset schema
        /// might not be up to date</param>
        /// <param name="endorsementDetails">The endorsement details</param>
        /// <param name="sensitivityLabel">The sensitivity label</param>
        /// <param name="targetStorageMode">The dataset storage mode</param>
        /// <param name="datasourceUsages">The datasource usages</param>
        /// <param name="upstreamDatasets">The upstream datasets</param>
        public WorkspaceInfoDataset(string id, string name = default(string), string configuredBy = default(string), System.DateTime? createdDate = default(System.DateTime?), string contentProviderType = default(string), string description = default(string), IList<DependentDataflow> upstreamDataflows = default(IList<DependentDataflow>), IList<Table> tables = default(IList<Table>), string schemaRetrievalError = default(string), bool? schemaMayNotBeUpToDate = default(bool?), EndorsementDetails endorsementDetails = default(EndorsementDetails), SensitivityLabel sensitivityLabel = default(SensitivityLabel), string targetStorageMode = default(string), IList<DatasourceUsage> datasourceUsages = default(IList<DatasourceUsage>), IList<DependentDataset> upstreamDatasets = default(IList<DependentDataset>))
        {
            Id = id;
            Name = name;
            ConfiguredBy = configuredBy;
            CreatedDate = createdDate;
            ContentProviderType = contentProviderType;
            Description = description;
            UpstreamDataflows = upstreamDataflows;
            Tables = tables;
            SchemaRetrievalError = schemaRetrievalError;
            SchemaMayNotBeUpToDate = schemaMayNotBeUpToDate;
            EndorsementDetails = endorsementDetails;
            SensitivityLabel = sensitivityLabel;
            TargetStorageMode = targetStorageMode;
            DatasourceUsages = datasourceUsages;
            UpstreamDatasets = upstreamDatasets;
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
        /// Gets or sets the dataset creation date and time
        /// </summary>
        [JsonProperty(PropertyName = "CreatedDate")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the content provider type for the dataset
        /// </summary>
        [JsonProperty(PropertyName = "ContentProviderType")]
        public string ContentProviderType { get; set; }

        /// <summary>
        /// Gets or sets the dataset description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the upstream dataflows
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDataflows")]
        public IList<DependentDataflow> UpstreamDataflows { get; set; }

        /// <summary>
        /// Gets or sets the dataset tables
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<Table> Tables { get; set; }

        /// <summary>
        /// Gets or sets the dataset schema retrieval error
        /// </summary>
        [JsonProperty(PropertyName = "schemaRetrievalError")]
        public string SchemaRetrievalError { get; set; }

        /// <summary>
        /// Gets or sets whether the dataset schema might not be up to date
        /// </summary>
        [JsonProperty(PropertyName = "schemaMayNotBeUpToDate")]
        public bool? SchemaMayNotBeUpToDate { get; set; }

        /// <summary>
        /// Gets or sets the endorsement details
        /// </summary>
        [JsonProperty(PropertyName = "endorsementDetails")]
        public EndorsementDetails EndorsementDetails { get; set; }

        /// <summary>
        /// Gets or sets the sensitivity label
        /// </summary>
        [JsonProperty(PropertyName = "sensitivityLabel")]
        public SensitivityLabel SensitivityLabel { get; set; }

        /// <summary>
        /// Gets or sets the dataset storage mode
        /// </summary>
        [JsonProperty(PropertyName = "targetStorageMode")]
        public string TargetStorageMode { get; set; }

        /// <summary>
        /// Gets or sets the datasource usages
        /// </summary>
        [JsonProperty(PropertyName = "datasourceUsages")]
        public IList<DatasourceUsage> DatasourceUsages { get; set; }

        /// <summary>
        /// Gets or sets the upstream datasets
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDatasets")]
        public IList<DependentDataset> UpstreamDatasets { get; set; }

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
            if (Tables != null)
            {
                foreach (var element in Tables)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (SensitivityLabel != null)
            {
                SensitivityLabel.Validate();
            }
            if (DatasourceUsages != null)
            {
                foreach (var element1 in DatasourceUsages)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}