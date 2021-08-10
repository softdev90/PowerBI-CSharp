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
    /// Assignment contract for migrating workspaces to premium capacity as
    /// tenant admin
    /// </summary>
    public partial class CapacityMigrationAssignment
    {
        /// <summary>
        /// Initializes a new instance of the CapacityMigrationAssignment
        /// class.
        /// </summary>
        public CapacityMigrationAssignment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityMigrationAssignment
        /// class.
        /// </summary>
        /// <param name="workspacesToAssign">Workspace Ids to be migrated to
        /// premium capacity</param>
        /// <param name="targetCapacityObjectId">premium Capacity id</param>
        public CapacityMigrationAssignment(IList<string> workspacesToAssign, string targetCapacityObjectId)
        {
            WorkspacesToAssign = workspacesToAssign;
            TargetCapacityObjectId = targetCapacityObjectId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets workspace Ids to be migrated to premium capacity
        /// </summary>
        [JsonProperty(PropertyName = "workspacesToAssign")]
        public IList<string> WorkspacesToAssign { get; set; }

        /// <summary>
        /// Gets or sets premium Capacity id
        /// </summary>
        [JsonProperty(PropertyName = "targetCapacityObjectId")]
        public string TargetCapacityObjectId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (WorkspacesToAssign == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkspacesToAssign");
            }
            if (TargetCapacityObjectId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetCapacityObjectId");
            }
        }
    }
}
