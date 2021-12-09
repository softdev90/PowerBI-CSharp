// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GatewaysOperations.
    /// </summary>
    public static partial class GatewaysOperationsExtensions
    {
            /// <summary>
            /// Returns a list of gateways for which the user is an admin.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Gateways GetGateways(this IGatewaysOperations operations)
            {
                return operations.GetGatewaysAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of gateways for which the user is an admin.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Gateways> GetGatewaysAsync(this IGatewaysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGatewaysWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            public static Gateway GetGateway(this IGatewaysOperations operations, System.Guid gatewayId)
            {
                return operations.GetGatewayAsync(gatewayId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Gateway> GetGatewayAsync(this IGatewaysOperations operations, System.Guid gatewayId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGatewayWithHttpMessagesAsync(gatewayId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of data sources from the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            public static GatewayDatasources GetDatasources(this IGatewaysOperations operations, System.Guid gatewayId)
            {
                return operations.GetDatasourcesAsync(gatewayId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of data sources from the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayDatasources> GetDatasourcesAsync(this IGatewaysOperations operations, System.Guid gatewayId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasourcesWithHttpMessagesAsync(gatewayId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new data source on the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// To encrypt credentials, see [Configure credentials
            /// programmatically](/power-bi/developer/automation/configure-credentials).
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceToGatewayRequest'>
            /// The datasource requested to create
            /// </param>
            public static GatewayDatasource CreateDatasource(this IGatewaysOperations operations, System.Guid gatewayId, PublishDatasourceToGatewayRequest datasourceToGatewayRequest)
            {
                return operations.CreateDatasourceAsync(gatewayId, datasourceToGatewayRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new data source on the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// To encrypt credentials, see [Configure credentials
            /// programmatically](/power-bi/developer/automation/configure-credentials).
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceToGatewayRequest'>
            /// The datasource requested to create
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayDatasource> CreateDatasourceAsync(this IGatewaysOperations operations, System.Guid gatewayId, PublishDatasourceToGatewayRequest datasourceToGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateDatasourceWithHttpMessagesAsync(gatewayId, datasourceToGatewayRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified data source from the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            public static GatewayDatasource GetDatasource(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId)
            {
                return operations.GetDatasourceAsync(gatewayId, datasourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified data source from the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayDatasource> GetDatasourceAsync(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasourceWithHttpMessagesAsync(gatewayId, datasourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified data source from the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            public static void DeleteDatasource(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId)
            {
                operations.DeleteDatasourceAsync(gatewayId, datasourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified data source from the specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteDatasourceAsync(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteDatasourceWithHttpMessagesAsync(gatewayId, datasourceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates the credentials of the specified data source from the specified
            /// gateway.
            /// </summary>
            /// <remarks>
            ///
            /// &gt; [!NOTE]
            /// &gt; To encrypt credentials, see [Configure credentials
            /// programmatically](/power-bi/developer/embedded/configure-credentials) for
            /// Power BI and review the EncryptCredentials [.NET
            /// Core](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/.NET%20Core/EncryptCredentials)
            /// and
            /// [Java](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/Java/EncryptCredentials)
            /// examples.
            ///
            /// - Set the parameter `useEndUserOAuth2Credentials` to `False` when changing
            /// from single sign-on to other credential types, such as **Basic** or
            /// **OAuth2**. See the [Basic credentials
            /// example](/rest/api/power-bi/gateways/update-datasource#basic-credentials-example).
            /// - For the **OAuth2** credential type, make sure the generated OAuth2 token
            /// audience was set correctly according to the data source type.
            /// - For **Extension** data sources, don't set `useCallerAADIdentity` to
            /// `true`. To set **OAuth2** credentials for other data sources, send the
            /// OAuth2 token in the payload as shown in the [OAuth2 credentials
            /// example](/rest/api/power-bi/gateways/update-datasource#oauth2-credentials-example).
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='updateDatasourceRequest'>
            /// The update datasource request
            /// </param>
            public static void UpdateDatasource(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, UpdateDatasourceRequest updateDatasourceRequest)
            {
                operations.UpdateDatasourceAsync(gatewayId, datasourceId, updateDatasourceRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the credentials of the specified data source from the specified
            /// gateway.
            /// </summary>
            /// <remarks>
            ///
            /// &gt; [!NOTE]
            /// &gt; To encrypt credentials, see [Configure credentials
            /// programmatically](/power-bi/developer/embedded/configure-credentials) for
            /// Power BI and review the EncryptCredentials [.NET
            /// Core](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/.NET%20Core/EncryptCredentials)
            /// and
            /// [Java](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/Java/EncryptCredentials)
            /// examples.
            ///
            /// - Set the parameter `useEndUserOAuth2Credentials` to `False` when changing
            /// from single sign-on to other credential types, such as **Basic** or
            /// **OAuth2**. See the [Basic credentials
            /// example](/rest/api/power-bi/gateways/update-datasource#basic-credentials-example).
            /// - For the **OAuth2** credential type, make sure the generated OAuth2 token
            /// audience was set correctly according to the data source type.
            /// - For **Extension** data sources, don't set `useCallerAADIdentity` to
            /// `true`. To set **OAuth2** credentials for other data sources, send the
            /// OAuth2 token in the payload as shown in the [OAuth2 credentials
            /// example](/rest/api/power-bi/gateways/update-datasource#oauth2-credentials-example).
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='updateDatasourceRequest'>
            /// The update datasource request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateDatasourceAsync(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, UpdateDatasourceRequest updateDatasourceRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateDatasourceWithHttpMessagesAsync(gatewayId, datasourceId, updateDatasourceRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Checks the connectivity status of the specified data source from the
            /// specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            public static void GetDatasourceStatus(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId)
            {
                operations.GetDatasourceStatusAsync(gatewayId, datasourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the connectivity status of the specified data source from the
            /// specified gateway.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetDatasourceStatusAsync(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetDatasourceStatusWithHttpMessagesAsync(gatewayId, datasourceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of users who have access to the specified data source.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            public static DatasourceUsers GetDatasourceUsers(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId)
            {
                return operations.GetDatasourceUsersAsync(gatewayId, datasourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of users who have access to the specified data source.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatasourceUsers> GetDatasourceUsersAsync(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasourceUsersWithHttpMessagesAsync(gatewayId, datasourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Grants or updates the permissions required to use the specified data source
            /// for the specified user.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='addUserToDatasourceRequest'>
            /// The add user to datasource request
            /// </param>
            public static void AddDatasourceUser(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, DatasourceUser addUserToDatasourceRequest)
            {
                operations.AddDatasourceUserAsync(gatewayId, datasourceId, addUserToDatasourceRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Grants or updates the permissions required to use the specified data source
            /// for the specified user.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='addUserToDatasourceRequest'>
            /// The add user to datasource request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddDatasourceUserAsync(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, DatasourceUser addUserToDatasourceRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddDatasourceUserWithHttpMessagesAsync(gatewayId, datasourceId, addUserToDatasourceRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Removes the specified user from the specified data source.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='emailAdress'>
            /// The user's email address or the object ID of the service principal
            /// </param>
            public static void DeleteDatasourceUser(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, string emailAdress)
            {
                operations.DeleteDatasourceUserAsync(gatewayId, datasourceId, emailAdress).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes the specified user from the specified data source.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have gateway admin permissions.
            ///
            /// ## Required scope
            ///
            /// Dataset.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Virtual network (VNet) gateways aren't supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway ID. When using a gateway cluster, the gateway ID refers to the
            /// primary (first) gateway in the cluster. In such cases, gateway ID is
            /// similar to gateway cluster ID.
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource ID
            /// </param>
            /// <param name='emailAdress'>
            /// The user's email address or the object ID of the service principal
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteDatasourceUserAsync(this IGatewaysOperations operations, System.Guid gatewayId, System.Guid datasourceId, string emailAdress, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteDatasourceUserWithHttpMessagesAsync(gatewayId, datasourceId, emailAdress, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
