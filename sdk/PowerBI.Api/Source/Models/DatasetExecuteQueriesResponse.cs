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
    /// The response to a dataset execute queries request
    /// </summary>
    public partial class DatasetExecuteQueriesResponse
    {
        /// <summary>
        /// Initializes a new instance of the DatasetExecuteQueriesResponse
        /// class.
        /// </summary>
        public DatasetExecuteQueriesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetExecuteQueriesResponse
        /// class.
        /// </summary>
        /// <param name="informationProtectionLabel">The details of the
        /// information protection label, if any, associated with the
        /// dataset.</param>
        /// <param name="results">The list of results, one per input
        /// query.</param>
        /// <param name="error">The details of an error, if present.</param>
        public DatasetExecuteQueriesResponse(DatasetExecuteQueriesInformationProtectionLabel informationProtectionLabel = default(DatasetExecuteQueriesInformationProtectionLabel), IList<DatasetExecuteQueriesQueryResult> results = default(IList<DatasetExecuteQueriesQueryResult>), DatasetExecuteQueriesError error = default(DatasetExecuteQueriesError))
        {
            InformationProtectionLabel = informationProtectionLabel;
            Results = results;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the details of the information protection label, if
        /// any, associated with the dataset.
        /// </summary>
        [JsonProperty(PropertyName = "informationProtectionLabel")]
        public DatasetExecuteQueriesInformationProtectionLabel InformationProtectionLabel { get; set; }

        /// <summary>
        /// Gets or sets the list of results, one per input query.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<DatasetExecuteQueriesQueryResult> Results { get; set; }

        /// <summary>
        /// Gets or sets the details of an error, if present.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public DatasetExecuteQueriesError Error { get; set; }

    }
}
