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
    /// The import object
    /// </summary>
    public partial class Import
    {
        /// <summary>
        /// Initializes a new instance of the Import class.
        /// </summary>
        public Import()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Import class.
        /// </summary>
        /// <param name="id">The import id</param>
        /// <param name="name">The import name</param>
        /// <param name="importState">The import upload state. Possible values
        /// include: 'Publishing', 'Succeeded', 'Failed'</param>
        /// <param name="reports">The reports associated with this
        /// import</param>
        /// <param name="datasets">The datasets associated with this
        /// import</param>
        /// <param name="createdDateTime">Import creation time</param>
        /// <param name="updatedDateTime">Import last update time</param>
        public Import(System.Guid id, string name = default(string), string importState = default(string), IList<Report> reports = default(IList<Report>), IList<Dataset> datasets = default(IList<Dataset>), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? updatedDateTime = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            ImportState = importState;
            Reports = reports;
            Datasets = datasets;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the import id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the import name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the import upload state. Possible values include:
        /// 'Publishing', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "importState")]
        public string ImportState { get; set; }

        /// <summary>
        /// Gets or sets the reports associated with this import
        /// </summary>
        [JsonProperty(PropertyName = "reports")]
        public IList<Report> Reports { get; set; }

        /// <summary>
        /// Gets or sets the datasets associated with this import
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public IList<Dataset> Datasets { get; set; }

        /// <summary>
        /// Gets or sets import creation time
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets import last update time
        /// </summary>
        [JsonProperty(PropertyName = "updatedDateTime")]
        public System.DateTime? UpdatedDateTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Reports != null)
            {
                foreach (var element in Reports)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Datasets != null)
            {
                foreach (var element1 in Datasets)
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
