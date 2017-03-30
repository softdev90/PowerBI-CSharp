// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Datasets.
    /// </summary>
    public static partial class DatasetsExtensions
    {
            /// <summary>
            /// Returns the datasets
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            public static ODataResponseListDataset GetDatasets(this IDatasets operations, string collectionName, string workspaceId)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).GetDatasetsAsync(collectionName, workspaceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the datasets
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListDataset> GetDatasetsAsync(this IDatasets operations, string collectionName, string workspaceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasetsWithHttpMessagesAsync(collectionName, workspaceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Post a new entity to datasets
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='dataset'>
            /// Create dataset parameters
            /// </param>
            public static object PostDataset(this IDatasets operations, string collectionName, string workspaceId, Dataset dataset)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).PostDatasetAsync(collectionName, workspaceId, dataset), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post a new entity to datasets
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='dataset'>
            /// Create dataset parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostDatasetAsync(this IDatasets operations, string collectionName, string workspaceId, Dataset dataset, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostDatasetWithHttpMessagesAsync(collectionName, workspaceId, dataset, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Posts new data rows into the specified table
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='tableName'>
            /// The table name
            /// </param>
            /// <param name='requestMessage'>
            /// The request message
            /// </param>
            public static object PostRows(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, string tableName, object requestMessage)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).PostRowsAsync(collectionName, workspaceId, datasetKey, tableName, requestMessage), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Posts new data rows into the specified table
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='tableName'>
            /// The table name
            /// </param>
            /// <param name='requestMessage'>
            /// The request message
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostRowsAsync(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, string tableName, object requestMessage, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostRowsWithHttpMessagesAsync(collectionName, workspaceId, datasetKey, tableName, requestMessage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes all rows from the specified table
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='tableName'>
            /// The table name
            /// </param>
            public static object DeleteRows(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, string tableName)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).DeleteRowsAsync(collectionName, workspaceId, datasetKey, tableName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes all rows from the specified table
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='tableName'>
            /// The table name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteRowsAsync(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, string tableName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteRowsWithHttpMessagesAsync(collectionName, workspaceId, datasetKey, tableName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all tables within the specified dataset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            public static ODataResponseListTable GetTables(this IDatasets operations, string collectionName, string workspaceId, string datasetKey)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).GetTablesAsync(collectionName, workspaceId, datasetKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all tables within the specified dataset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListTable> GetTablesAsync(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTablesWithHttpMessagesAsync(collectionName, workspaceId, datasetKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a schema and metadata for the specified table
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='tableName'>
            /// The table name
            /// </param>
            /// <param name='requestMessage'>
            /// The request message
            /// </param>
            public static object PutTable(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, string tableName, object requestMessage)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).PutTableAsync(collectionName, workspaceId, datasetKey, tableName, requestMessage), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a schema and metadata for the specified table
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='tableName'>
            /// The table name
            /// </param>
            /// <param name='requestMessage'>
            /// The request message
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PutTableAsync(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, string tableName, object requestMessage, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutTableWithHttpMessagesAsync(collectionName, workspaceId, datasetKey, tableName, requestMessage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the dataset metadata for the specifeid dataset id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            public static Dataset GetDatasetById(this IDatasets operations, string collectionName, string workspaceId, string datasetKey)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).GetDatasetByIdAsync(collectionName, workspaceId, datasetKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the dataset metadata for the specifeid dataset id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Dataset> GetDatasetByIdAsync(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasetByIdWithHttpMessagesAsync(collectionName, workspaceId, datasetKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the dataset with the specified id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            public static object DeleteDatasetById(this IDatasets operations, string collectionName, string workspaceId, string datasetKey)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).DeleteDatasetByIdAsync(collectionName, workspaceId, datasetKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the dataset with the specified id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteDatasetByIdAsync(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteDatasetByIdWithHttpMessagesAsync(collectionName, workspaceId, datasetKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of bound gateway datasources for the specified dataset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            public static ODataResponseListGatewayDatasource GetGatewayDatasources(this IDatasets operations, string collectionName, string workspaceId, string datasetKey)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).GetGatewayDatasourcesAsync(collectionName, workspaceId, datasetKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of bound gateway datasources for the specified dataset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGatewayDatasource> GetGatewayDatasourcesAsync(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGatewayDatasourcesWithHttpMessagesAsync(collectionName, workspaceId, datasetKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of datasource for the specified dataset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// </param>
            public static ODataResponseListDatasource GetDatasources(this IDatasets operations, string collectionName, string workspaceId, string datasetKey)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).GetDatasourcesAsync(collectionName, workspaceId, datasetKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of datasource for the specified dataset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListDatasource> GetDatasourcesAsync(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasourcesWithHttpMessagesAsync(collectionName, workspaceId, datasetKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets all connections for the specified dataset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='parameters'>
            /// The body
            /// </param>
            public static object SetAllConnections(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, object parameters)
            {
                return Task.Factory.StartNew(s => ((IDatasets)s).SetAllConnectionsAsync(collectionName, workspaceId, datasetKey, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets all connections for the specified dataset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetKey'>
            /// The dataset id
            /// </param>
            /// <param name='parameters'>
            /// The body
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SetAllConnectionsAsync(this IDatasets operations, string collectionName, string workspaceId, string datasetKey, object parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetAllConnectionsWithHttpMessagesAsync(collectionName, workspaceId, datasetKey, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
