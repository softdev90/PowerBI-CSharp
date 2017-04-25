// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.PowerBI.Api.V1;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Power BI Dataset
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
        /// <param name="name">The dataset name</param>
        /// <param name="tables">The dataset tables</param>
        /// <param name="id">The dataset id</param>
        /// <param name="defaultRetentionPolicy">The dataset default data
        /// retention policy</param>
        /// <param name="webUrl">The dataset web url</param>
        /// <param name="datasources">The datasources associated with this
        /// dataset</param>
        /// <param name="defaultMode">The dataset mode or type. Possible values
        /// include: 'AsAzure', 'AsOnPrem', 'Push', 'Streaming',
        /// 'PushStreaming'</param>
        public Dataset(string name, IList<Table> tables, string id = default(string), string defaultRetentionPolicy = default(string), string webUrl = default(string), IList<Datasource> datasources = default(IList<Datasource>), string defaultMode = default(string))
        {
            Id = id;
            Name = name;
            DefaultRetentionPolicy = defaultRetentionPolicy;
            Tables = tables;
            WebUrl = webUrl;
            Datasources = datasources;
            DefaultMode = defaultMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataset id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the dataset name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dataset default data retention policy
        /// </summary>
        [JsonProperty(PropertyName = "defaultRetentionPolicy")]
        public string DefaultRetentionPolicy { get; set; }

        /// <summary>
        /// Gets or sets the dataset tables
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<Table> Tables { get; set; }

        /// <summary>
        /// Gets or sets the dataset web url
        /// </summary>
        [JsonProperty(PropertyName = "webUrl")]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or sets the datasources associated with this dataset
        /// </summary>
        [JsonProperty(PropertyName = "datasources")]
        public IList<Datasource> Datasources { get; set; }

        /// <summary>
        /// Gets or sets the dataset mode or type. Possible values include:
        /// 'AsAzure', 'AsOnPrem', 'Push', 'Streaming', 'PushStreaming'
        /// </summary>
        [JsonProperty(PropertyName = "defaultMode")]
        public string DefaultMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Tables == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tables");
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
        }
    }
}
