// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Gateways.
    /// </summary>
    public static partial class GatewaysExtensions
    {
            /// <summary>
            /// Updates the credentials for the specified datasource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            public static object PatchDatasource(this IGateways operations, string gatewayId, string datasourceId, object datasourceDelta)
            {
                return operations.PatchDatasourceAsync(gatewayId, datasourceId, datasourceDelta).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the credentials for the specified datasource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            public static async Task<object> PatchDatasourceAsync(this IGateways operations, string gatewayId, string datasourceId, object datasourceDelta, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchDatasourceWithHttpMessagesAsync(gatewayId, datasourceId, datasourceDelta, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the credentials for the specified datasource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
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
            public static object PatchDatasourceInGroup(this IGateways operations, string groupId, string gatewayId, string datasourceId, object datasourceDelta)
            {
                return operations.PatchDatasourceInGroupAsync(groupId, gatewayId, datasourceId, datasourceDelta).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the credentials for the specified datasource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
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
            public static async Task<object> PatchDatasourceInGroupAsync(this IGateways operations, string groupId, string gatewayId, string datasourceId, object datasourceDelta, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchDatasourceInGroupWithHttpMessagesAsync(groupId, gatewayId, datasourceId, datasourceDelta, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
