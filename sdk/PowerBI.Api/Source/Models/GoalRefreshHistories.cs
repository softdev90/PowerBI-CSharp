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
    /// The OData response wrapper for a collection of Power BI goal refresh
    /// history entries
    /// </summary>
    public partial class GoalRefreshHistories
    {
        /// <summary>
        /// Initializes a new instance of the GoalRefreshHistories class.
        /// </summary>
        public GoalRefreshHistories()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GoalRefreshHistories class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The goal refresh history entries</param>
        public GoalRefreshHistories(string odatacontext = default(string), IList<GoalRefreshHistory> value = default(IList<GoalRefreshHistory>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oData context
        /// </summary>
        [JsonProperty(PropertyName = "@odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the goal refresh history entries
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<GoalRefreshHistory> Value { get; set; }

    }
}
