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
    /// A composite of label information required to update an information
    /// protection label
    /// </summary>
    public partial class InformationProtectionChangeLabelDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InformationProtectionChangeLabelDetails class.
        /// </summary>
        public InformationProtectionChangeLabelDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InformationProtectionChangeLabelDetails class.
        /// </summary>
        /// <param name="artifacts">A composite of Power BI item IDs for each
        /// item type</param>
        /// <param name="labelId">The label ID, which must be in the user's
        /// label policy.</param>
        /// <param name="delegatedUser">Delegated user details. A delegated
        /// user is a user within an organization whose admin sets a label on
        /// behalf of the user. Although the admin sets the label, the
        /// delegated user is marked as the label issuer.</param>
        /// <param name="assignmentMethod">Specifies whether the assigned label
        /// was set by an automated process or manually. Possible values
        /// include: 'Standard', 'Priviledged'</param>
        public InformationProtectionChangeLabelDetails(InformationProtectionArtifactsChangeLabel artifacts, System.Guid labelId, DelegatedUser delegatedUser = default(DelegatedUser), AssignmentMethod? assignmentMethod = default(AssignmentMethod?))
        {
            Artifacts = artifacts;
            LabelId = labelId;
            DelegatedUser = delegatedUser;
            AssignmentMethod = assignmentMethod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a composite of Power BI item IDs for each item type
        /// </summary>
        [JsonProperty(PropertyName = "artifacts")]
        public InformationProtectionArtifactsChangeLabel Artifacts { get; set; }

        /// <summary>
        /// Gets or sets the label ID, which must be in the user's label
        /// policy.
        /// </summary>
        [JsonProperty(PropertyName = "labelId")]
        public System.Guid LabelId { get; set; }

        /// <summary>
        /// Gets or sets delegated user details. A delegated user is a user
        /// within an organization whose admin sets a label on behalf of the
        /// user. Although the admin sets the label, the delegated user is
        /// marked as the label issuer.
        /// </summary>
        [JsonProperty(PropertyName = "delegatedUser")]
        public DelegatedUser DelegatedUser { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the assigned label was set by an
        /// automated process or manually. Possible values include: 'Standard',
        /// 'Priviledged'
        /// </summary>
        [JsonProperty(PropertyName = "assignmentMethod")]
        public AssignmentMethod? AssignmentMethod { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Artifacts == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Artifacts");
            }
            if (DelegatedUser != null)
            {
                DelegatedUser.Validate();
            }
        }
    }
}
