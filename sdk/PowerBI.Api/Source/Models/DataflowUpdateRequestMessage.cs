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
    /// A request to update dataflow information
    /// </summary>
    public partial class DataflowUpdateRequestMessage
    {
        /// <summary>
        /// Initializes a new instance of the DataflowUpdateRequestMessage
        /// class.
        /// </summary>
        public DataflowUpdateRequestMessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataflowUpdateRequestMessage
        /// class.
        /// </summary>
        /// <param name="name">The new name for the dataflow</param>
        /// <param name="description">The new description for the
        /// dataflow</param>
        /// <param name="allowNativeQueries">Whether to allow native
        /// queries</param>
        /// <param name="computeEngineBehavior">The behavior of the compute
        /// engine. Possible values include: 'computeOptimized', 'computeOn',
        /// 'computeDisabled'</param>
        public DataflowUpdateRequestMessage(string name = default(string), string description = default(string), bool? allowNativeQueries = default(bool?), string computeEngineBehavior = default(string))
        {
            Name = name;
            Description = description;
            AllowNativeQueries = allowNativeQueries;
            ComputeEngineBehavior = computeEngineBehavior;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the new name for the dataflow
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the new description for the dataflow
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether to allow native queries
        /// </summary>
        [JsonProperty(PropertyName = "allowNativeQueries")]
        public bool? AllowNativeQueries { get; set; }

        /// <summary>
        /// Gets or sets the behavior of the compute engine. Possible values
        /// include: 'computeOptimized', 'computeOn', 'computeDisabled'
        /// </summary>
        [JsonProperty(PropertyName = "computeEngineBehavior")]
        public string ComputeEngineBehavior { get; set; }

    }
}
