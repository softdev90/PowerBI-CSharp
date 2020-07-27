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
    /// A paginated report datasources update request.
    /// </summary>
    public partial class UpdateRdlDatasourcesRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateRdlDatasourcesRequest
        /// class.
        /// </summary>
        public UpdateRdlDatasourcesRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateRdlDatasourcesRequest
        /// class.
        /// </summary>
        /// <param name="updateDetails">The paginated report datasources update
        /// details.</param>
        public UpdateRdlDatasourcesRequest(IList<UpdateRdlDatasourceDetails> updateDetails)
        {
            UpdateDetails = updateDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the paginated report datasources update details.
        /// </summary>
        [JsonProperty(PropertyName = "updateDetails")]
        public IList<UpdateRdlDatasourceDetails> UpdateDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UpdateDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UpdateDetails");
            }
            if (UpdateDetails != null)
            {
                foreach (var element in UpdateDetails)
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
