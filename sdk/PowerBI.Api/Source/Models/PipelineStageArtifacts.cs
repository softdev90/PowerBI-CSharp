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
    /// Supported items from a workspace assigned to a deployment pipeline
    /// stage.
    /// </summary>
    public partial class PipelineStageArtifacts
    {
        /// <summary>
        /// Initializes a new instance of the PipelineStageArtifacts class.
        /// </summary>
        public PipelineStageArtifacts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineStageArtifacts class.
        /// </summary>
        /// <param name="datasets">The datasets collection</param>
        /// <param name="reports">The reports collection</param>
        /// <param name="dashboards">The dashboards collection</param>
        public PipelineStageArtifacts(IList<PipelineStageDataset> datasets = default(IList<PipelineStageDataset>), IList<PipelineStageReport> reports = default(IList<PipelineStageReport>), IList<PipelineStageDashboard> dashboards = default(IList<PipelineStageDashboard>))
        {
            Datasets = datasets;
            Reports = reports;
            Dashboards = dashboards;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the datasets collection
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public IList<PipelineStageDataset> Datasets { get; set; }

        /// <summary>
        /// Gets or sets the reports collection
        /// </summary>
        [JsonProperty(PropertyName = "reports")]
        public IList<PipelineStageReport> Reports { get; set; }

        /// <summary>
        /// Gets or sets the dashboards collection
        /// </summary>
        [JsonProperty(PropertyName = "dashboards")]
        public IList<PipelineStageDashboard> Dashboards { get; set; }

    }
}
