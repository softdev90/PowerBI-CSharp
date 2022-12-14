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
    /// An update request for a Power BI dataset parameter
    /// </summary>
    public partial class UpdateMashupParametersRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateMashupParametersRequest
        /// class.
        /// </summary>
        public UpdateMashupParametersRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateMashupParametersRequest
        /// class.
        /// </summary>
        /// <param name="updateDetails">A list of dataset parameters to
        /// update</param>
        public UpdateMashupParametersRequest(IList<UpdateMashupParameterDetails> updateDetails)
        {
            UpdateDetails = updateDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of dataset parameters to update
        /// </summary>
        [JsonProperty(PropertyName = "updateDetails")]
        public IList<UpdateMashupParameterDetails> UpdateDetails { get; set; }

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
