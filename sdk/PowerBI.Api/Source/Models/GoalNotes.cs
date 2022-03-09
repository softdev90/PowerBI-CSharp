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
    /// The OData response wrapper for a Power BI goal value note collection
    /// </summary>
    public partial class GoalNotes
    {
        /// <summary>
        /// Initializes a new instance of the GoalNotes class.
        /// </summary>
        public GoalNotes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GoalNotes class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The goal value note collection</param>
        public GoalNotes(string odatacontext = default(string), IList<GoalNote> value = default(IList<GoalNote>))
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
        /// Gets or sets the goal value note collection
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<GoalNote> Value { get; set; }

    }
}
