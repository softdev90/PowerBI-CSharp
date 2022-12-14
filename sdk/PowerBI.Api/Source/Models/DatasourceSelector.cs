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
    /// An object that uniquely identifies a single data source by its
    /// connection details.
    /// </summary>
    public partial class DatasourceSelector
    {
        /// <summary>
        /// Initializes a new instance of the DatasourceSelector class.
        /// </summary>
        public DatasourceSelector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasourceSelector class.
        /// </summary>
        /// <param name="datasourceType">The type of the [data
        /// source](/power-bi/connect-data/power-bi-data-sources).
        ///
        ///
        /// | API name for the data source | | |
        /// |-|-|-|
        /// | ActiveDirectory | AdobeAnalytics | AdoDotNet |
        /// | AnalysisServices | AzureBlobs | AzureDataLakeStorage |
        /// | AzureMarketplace | AzureTables | BizTalk |
        /// | CDPA | CustomConnector | CustomHttpApi |
        /// | DB2 | Essbase | EventHub |
        /// | Excel | Exchange | Extension |
        /// | Facebook | File | Folder |
        /// | GoogleAnalytics | Hdfs | HDInsight |
        /// | Informix | MQ | MySql |
        /// | OData | ODBC | OleDb |
        /// | Oracle | PostgreSql | PowerQueryMashup
        /// | PubNub | Salesforce | SAPBW |
        /// | SAPBWMessageServer | SapErp | SAPHana |
        /// | SharePoint | SharePointDocLib | SharePointList |
        /// | Sql | Sybase | Teradata |
        /// | UIFlow | Web |</param>
        /// <param name="connectionDetails">The data source connection details.
        /// You can obtain the connection details using [Get Datasources for
        /// paginated
        /// reports](/rest/api/power-bi/reports/get-datasources-in-group) and
        /// [Get Datasources for powerbi
        /// reports](/rest/api/power-bi/datasets/get-datasources-in-group)
        /// APIs.</param>
        public DatasourceSelector(string datasourceType, DatasourceConnectionDetails connectionDetails)
        {
            DatasourceType = datasourceType;
            ConnectionDetails = connectionDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the [data
        /// source](/power-bi/connect-data/power-bi-data-sources).
        ///
        ///
        /// | API name for the data source | | |
        /// |-|-|-|
        /// | ActiveDirectory | AdobeAnalytics | AdoDotNet |
        /// | AnalysisServices | AzureBlobs | AzureDataLakeStorage |
        /// | AzureMarketplace | AzureTables | BizTalk |
        /// | CDPA | CustomConnector | CustomHttpApi |
        /// | DB2 | Essbase | EventHub |
        /// | Excel | Exchange | Extension |
        /// | Facebook | File | Folder |
        /// | GoogleAnalytics | Hdfs | HDInsight |
        /// | Informix | MQ | MySql |
        /// | OData | ODBC | OleDb |
        /// | Oracle | PostgreSql | PowerQueryMashup
        /// | PubNub | Salesforce | SAPBW |
        /// | SAPBWMessageServer | SapErp | SAPHana |
        /// | SharePoint | SharePointDocLib | SharePointList |
        /// | Sql | Sybase | Teradata |
        /// | UIFlow | Web |
        /// </summary>
        [JsonProperty(PropertyName = "datasourceType")]
        public string DatasourceType { get; set; }

        /// <summary>
        /// Gets or sets the data source connection details.
        /// You can obtain the connection details using [Get Datasources for
        /// paginated
        /// reports](/rest/api/power-bi/reports/get-datasources-in-group) and
        /// [Get Datasources for powerbi
        /// reports](/rest/api/power-bi/datasets/get-datasources-in-group)
        /// APIs.
        /// </summary>
        [JsonProperty(PropertyName = "connectionDetails")]
        public DatasourceConnectionDetails ConnectionDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DatasourceType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DatasourceType");
            }
            if (ConnectionDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionDetails");
            }
        }
    }
}
