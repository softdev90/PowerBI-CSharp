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
    /// A relationship between tables in a dataset
    /// </summary>
    public partial class Relationship
    {
        /// <summary>
        /// Initializes a new instance of the Relationship class.
        /// </summary>
        public Relationship()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Relationship class.
        /// </summary>
        /// <param name="name">The relationship name and identifier</param>
        /// <param name="fromTable">The name of the foreign key table</param>
        /// <param name="fromColumn">The name of the foreign key column</param>
        /// <param name="toTable">The name of the primary key table</param>
        /// <param name="toColumn">The name of the primary key column</param>
        /// <param name="crossFilteringBehavior">The filter direction of the
        /// relationship. Possible values include: 'OneDirection',
        /// 'BothDirections', 'Automatic'</param>
        public Relationship(string name, string fromTable, string fromColumn, string toTable, string toColumn, CrossFilteringBehavior? crossFilteringBehavior = default(CrossFilteringBehavior?))
        {
            Name = name;
            CrossFilteringBehavior = crossFilteringBehavior;
            FromTable = fromTable;
            FromColumn = fromColumn;
            ToTable = toTable;
            ToColumn = toColumn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the relationship name and identifier
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the filter direction of the relationship. Possible
        /// values include: 'OneDirection', 'BothDirections', 'Automatic'
        /// </summary>
        [JsonProperty(PropertyName = "crossFilteringBehavior")]
        public CrossFilteringBehavior? CrossFilteringBehavior { get; set; }

        /// <summary>
        /// Gets or sets the name of the foreign key table
        /// </summary>
        [JsonProperty(PropertyName = "fromTable")]
        public string FromTable { get; set; }

        /// <summary>
        /// Gets or sets the name of the foreign key column
        /// </summary>
        [JsonProperty(PropertyName = "fromColumn")]
        public string FromColumn { get; set; }

        /// <summary>
        /// Gets or sets the name of the primary key table
        /// </summary>
        [JsonProperty(PropertyName = "toTable")]
        public string ToTable { get; set; }

        /// <summary>
        /// Gets or sets the name of the primary key column
        /// </summary>
        [JsonProperty(PropertyName = "toColumn")]
        public string ToColumn { get; set; }

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
            if (FromTable == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FromTable");
            }
            if (FromColumn == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FromColumn");
            }
            if (ToTable == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ToTable");
            }
            if (ToColumn == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ToColumn");
            }
            if (Name != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[\\x09\\x0A\\x0D\\x20\\x23\\x2D\\x30-\\x39\\x40-\\x5A\\x5E-\\x5F\\x61-\\x7A\\x7E-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]{1,100}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[\\x09\\x0A\\x0D\\x20\\x23\\x2D\\x30-\\x39\\x40-\\x5A\\x5E-\\x5F\\x61-\\x7A\\x7E-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]{1,100}$");
                }
            }
            if (FromTable != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(FromTable, "^[\\x09\\x0A\\x0D\\x20\\x23\\x2D\\x30-\\x39\\x40-\\x5A\\x5E-\\x5F\\x61-\\x7A\\x7E-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]{1,100}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "FromTable", "^[\\x09\\x0A\\x0D\\x20\\x23\\x2D\\x30-\\x39\\x40-\\x5A\\x5E-\\x5F\\x61-\\x7A\\x7E-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]{1,100}$");
                }
            }
            if (FromColumn != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(FromColumn, "^[\\x09\\x0A\\x0D\\x20-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "FromColumn", "^[\\x09\\x0A\\x0D\\x20-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]+$");
                }
            }
            if (ToTable != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(ToTable, "^[\\x09\\x0A\\x0D\\x20\\x23\\x2D\\x30-\\x39\\x40-\\x5A\\x5E-\\x5F\\x61-\\x7A\\x7E-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]{1,100}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ToTable", "^[\\x09\\x0A\\x0D\\x20\\x23\\x2D\\x30-\\x39\\x40-\\x5A\\x5E-\\x5F\\x61-\\x7A\\x7E-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]{1,100}$");
                }
            }
            if (ToColumn != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(ToColumn, "^[\\x09\\x0A\\x0D\\x20-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ToColumn", "^[\\x09\\x0A\\x0D\\x20-\\uD7FF\\uE000-\\uFFFD\\u10000-\\u10FFFF]+$");
                }
            }
        }
    }
}
