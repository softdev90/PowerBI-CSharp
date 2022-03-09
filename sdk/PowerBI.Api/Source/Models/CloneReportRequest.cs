// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI clone report request
    /// </summary>
    public partial class CloneReportRequest
    {
        /// <summary>
        /// Initializes a new instance of the CloneReportRequest class.
        /// </summary>
        public CloneReportRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloneReportRequest class.
        /// </summary>
        /// <param name="name">The new report name</param>
        /// <param name="targetWorkspaceId">Optional. Parameter for specifying
        /// the target workspace ID. An empty GUID
        /// (`00000000-0000-0000-0000-000000000000`) indicates **My
        /// workspace**. If this parameter isn't provided, the new report will
        /// be cloned within the same workspace as the source report.</param>
        /// <param name="targetModelId">Optional. Parameter for specifying the
        /// target associated dataset ID. If not provided, the new report will
        /// be associated with the same dataset as the source report.</param>
        public CloneReportRequest(string name, System.Guid? targetWorkspaceId = default(System.Guid?), string targetModelId = default(string))
        {
            Name = name;
            TargetWorkspaceId = targetWorkspaceId;
            TargetModelId = targetModelId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the new report name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets optional. Parameter for specifying the target
        /// workspace ID. An empty GUID
        /// (`00000000-0000-0000-0000-000000000000`) indicates **My
        /// workspace**. If this parameter isn't provided, the new report will
        /// be cloned within the same workspace as the source report.
        /// </summary>
        [JsonProperty(PropertyName = "targetWorkspaceId")]
        public System.Guid? TargetWorkspaceId { get; set; }

        /// <summary>
        /// Gets or sets optional. Parameter for specifying the target
        /// associated dataset ID. If not provided, the new report will be
        /// associated with the same dataset as the source report.
        /// </summary>
        [JsonProperty(PropertyName = "targetModelId")]
        public string TargetModelId { get; set; }

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
        }
    }
}
