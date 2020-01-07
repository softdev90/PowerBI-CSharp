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
    /// A Power BI dataset to dataflow link
    /// </summary>
    public partial class DatasetToDataflowLinkResponse
    {
        /// <summary>
        /// Initializes a new instance of the DatasetToDataflowLinkResponse
        /// class.
        /// </summary>
        public DatasetToDataflowLinkResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetToDataflowLinkResponse
        /// class.
        /// </summary>
        /// <param name="datasetObjectId">The dataset object id</param>
        /// <param name="dataflowObjectId">The dataflow object id</param>
        /// <param name="workspaceObjectId">The workspace object id</param>
        public DatasetToDataflowLinkResponse(string datasetObjectId = default(string), string dataflowObjectId = default(string), string workspaceObjectId = default(string))
        {
            DatasetObjectId = datasetObjectId;
            DataflowObjectId = dataflowObjectId;
            WorkspaceObjectId = workspaceObjectId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataset object id
        /// </summary>
        [JsonProperty(PropertyName = "datasetObjectId")]
        public string DatasetObjectId { get; set; }

        /// <summary>
        /// Gets or sets the dataflow object id
        /// </summary>
        [JsonProperty(PropertyName = "dataflowObjectId")]
        public string DataflowObjectId { get; set; }

        /// <summary>
        /// Gets or sets the workspace object id
        /// </summary>
        [JsonProperty(PropertyName = "workspaceObjectId")]
        public string WorkspaceObjectId { get; set; }

    }
}
