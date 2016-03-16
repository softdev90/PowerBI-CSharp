// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Beta
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class GatewaysExtensions
    {
            /// <summary>
            /// Updates the credentials for the specified datasource
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
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='datasourceDelta'>
            /// The datasource changes
            /// </param>
            public static object PatchDatasource(this IGateways operations, string collectionName, string workspaceId, string gatewayId, string datasourceId, object datasourceDelta)
            {
                return Task.Factory.StartNew(s => ((IGateways)s).PatchDatasourceAsync(collectionName, workspaceId, gatewayId, datasourceId, datasourceDelta), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the credentials for the specified datasource
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
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='datasourceDelta'>
            /// The datasource changes
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PatchDatasourceAsync( this IGateways operations, string collectionName, string workspaceId, string gatewayId, string datasourceId, object datasourceDelta, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchDatasourceWithHttpMessagesAsync(collectionName, workspaceId, gatewayId, datasourceId, datasourceDelta, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
