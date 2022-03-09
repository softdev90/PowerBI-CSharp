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
    /// A Power BI dataflow storage account
    /// </summary>
    public partial class DataflowStorageAccount
    {
        /// <summary>
        /// Initializes a new instance of the DataflowStorageAccount class.
        /// </summary>
        public DataflowStorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataflowStorageAccount class.
        /// </summary>
        /// <param name="id">The Power BI dataflow storage account ID</param>
        /// <param name="isEnabled">Whether workspaces can be assigned to this
        /// storage account</param>
        /// <param name="name">The Power BI dataflow storage account
        /// name</param>
        public DataflowStorageAccount(System.Guid id, bool isEnabled, string name = default(string))
        {
            Id = id;
            Name = name;
            IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Power BI dataflow storage account ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the Power BI dataflow storage account name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether workspaces can be assigned to this storage
        /// account
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
