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
    /// A deployment execution plan
    /// </summary>
    public partial class DeploymentExecutionPlan
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentExecutionPlan class.
        /// </summary>
        public DeploymentExecutionPlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentExecutionPlan class.
        /// </summary>
        /// <param name="steps">The collection of execution plan steps</param>
        public DeploymentExecutionPlan(IList<DeploymentExecutionStep> steps = default(IList<DeploymentExecutionStep>))
        {
            Steps = steps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the collection of execution plan steps
        /// </summary>
        [JsonProperty(PropertyName = "steps")]
        public IList<DeploymentExecutionStep> Steps { get; set; }

    }
}
