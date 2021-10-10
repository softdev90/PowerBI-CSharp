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
    /// Set label details.
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
        /// <param name="artifacts">A composite of artifact ID lists for each
        /// type</param>
        /// <param name="labelId">Label ID (must be in the user’s
        /// policy).</param>
        /// <param name="delegatedUser">Delegated user details. A delegated
        /// user is a user in the admin’s organization on whose behalf the
        /// admin sets a label. Although the admin sets the label, the
        /// delegated user is marked as the label issuer.</param>
        /// <param name="assignmentMethod">Specifies whether the assigned label
        /// is to be regarded as having been set manually or as the result of
        /// automatic labeling. (default value is Standard). Possible values
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
        /// Gets or sets a composite of artifact ID lists for each type
        /// </summary>
        [JsonProperty(PropertyName = "artifacts")]
        public InformationProtectionArtifactsChangeLabel Artifacts { get; set; }

        /// <summary>
        /// Gets or sets label ID (must be in the user’s policy).
        /// </summary>
        [JsonProperty(PropertyName = "labelId")]
        public System.Guid LabelId { get; set; }

        /// <summary>
        /// Gets or sets delegated user details. A delegated user is a user in
        /// the admin’s organization on whose behalf the admin sets a label.
        /// Although the admin sets the label, the delegated user is marked as
        /// the label issuer.
        /// </summary>
        [JsonProperty(PropertyName = "delegatedUser")]
        public DelegatedUser DelegatedUser { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the assigned label is to be regarded
        /// as having been set manually or as the result of automatic labeling.
        /// (default value is Standard). Possible values include: 'Standard',
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
