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
    /// A Power BI goal status rule
    /// </summary>
    public partial class GoalsRulesRuleCondition
    {
        /// <summary>
        /// Initializes a new instance of the GoalsRulesRuleCondition class.
        /// </summary>
        public GoalsRulesRuleCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GoalsRulesRuleCondition class.
        /// </summary>
        /// <param name="fieldComparison">The field comparison definition when
        /// `expression` isn't defined</param>
        /// <param name="expression">The rule condition expression when
        /// `fieldComparison` isn't defined</param>
        public GoalsRulesRuleCondition(GoalsRulesFieldComparison fieldComparison = default(GoalsRulesFieldComparison), string expression = default(string))
        {
            FieldComparison = fieldComparison;
            Expression = expression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the field comparison definition when `expression`
        /// isn't defined
        /// </summary>
        [JsonProperty(PropertyName = "fieldComparison")]
        public GoalsRulesFieldComparison FieldComparison { get; set; }

        /// <summary>
        /// Gets or sets the rule condition expression when `fieldComparison`
        /// isn't defined
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }

    }
}
