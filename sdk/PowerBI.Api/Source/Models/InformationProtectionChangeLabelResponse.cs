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
    /// A composite of the ID and information protection label change status
    /// for one or more Power BI items organized by type
    /// </summary>
    public partial class InformationProtectionChangeLabelResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InformationProtectionChangeLabelResponse class.
        /// </summary>
        public InformationProtectionChangeLabelResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InformationProtectionChangeLabelResponse class.
        /// </summary>
        /// <param name="dashboards">A list containing the unique ID and
        /// information protection label change status of one or more
        /// dashboards</param>
        /// <param name="reports">A list containing the unique ID and
        /// information protection label change status of one or more
        /// reports</param>
        /// <param name="dataflows">A list containing the unique ID and
        /// information protection label change status of one or more
        /// dataflows</param>
        /// <param name="datasets">A list containing the unique ID and
        /// information protection label change status of one or more
        /// datasets</param>
        public InformationProtectionChangeLabelResponse(IList<ChangeLabelStatus> dashboards = default(IList<ChangeLabelStatus>), IList<ChangeLabelStatus> reports = default(IList<ChangeLabelStatus>), IList<ChangeLabelStatus> dataflows = default(IList<ChangeLabelStatus>), IList<ChangeLabelStatus> datasets = default(IList<ChangeLabelStatus>))
        {
            Dashboards = dashboards;
            Reports = reports;
            Dataflows = dataflows;
            Datasets = datasets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list containing the unique ID and information
        /// protection label change status of one or more dashboards
        /// </summary>
        [JsonProperty(PropertyName = "dashboards")]
        public IList<ChangeLabelStatus> Dashboards { get; set; }

        /// <summary>
        /// Gets or sets a list containing the unique ID and information
        /// protection label change status of one or more reports
        /// </summary>
        [JsonProperty(PropertyName = "reports")]
        public IList<ChangeLabelStatus> Reports { get; set; }

        /// <summary>
        /// Gets or sets a list containing the unique ID and information
        /// protection label change status of one or more dataflows
        /// </summary>
        [JsonProperty(PropertyName = "dataflows")]
        public IList<ChangeLabelStatus> Dataflows { get; set; }

        /// <summary>
        /// Gets or sets a list containing the unique ID and information
        /// protection label change status of one or more datasets
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public IList<ChangeLabelStatus> Datasets { get; set; }

    }
}
