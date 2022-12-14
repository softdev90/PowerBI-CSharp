// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatamartSensitivityLabelProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DatamartSensitivityLabelProperties class.
        /// </summary>
        public DatamartSensitivityLabelProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DatamartSensitivityLabelProperties class.
        /// </summary>
        /// <param name="sensitivityLabel">The datamart sensitivity
        /// label</param>
        public DatamartSensitivityLabelProperties(SensitivityLabel sensitivityLabel = default(SensitivityLabel))
        {
            SensitivityLabel = sensitivityLabel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the datamart sensitivity label
        /// </summary>
        [JsonProperty(PropertyName = "sensitivityLabel")]
        public SensitivityLabel SensitivityLabel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SensitivityLabel != null)
            {
                SensitivityLabel.Validate();
            }
        }
    }
}
