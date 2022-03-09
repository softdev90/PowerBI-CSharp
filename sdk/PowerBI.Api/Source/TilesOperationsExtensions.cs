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
    /// Extension methods for TilesOperations.
    /// </summary>
    public static partial class TilesOperationsExtensions
    {
            /// <summary>
            /// Generates an embed token to view the specified tile from the specified
            /// workspace.
            /// </summary>
            /// <remarks>
            ///
            /// &gt; [!IMPORTANT]
            /// &gt; This API call is only relevant to the [embed for your
            /// customers](/power-bi/developer/embed-sample-for-customers) scenario. To
            /// learn more about using this API, see [Considerations when generating an
            /// embed token](/power-bi/developer/embedded/generate-embed-token).
            ///
            /// ## Permissions
            ///
            /// When using a service principal for authentication, refer to [Embed Power BI
            /// content with service
            /// principal](/power-bi/developer/embed-service-principal) and [Considerations
            /// and
            /// limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
            ///
            /// ## Required Scope
            ///
            /// All of the following:
            ///
            /// - Dashboard.ReadWrite.All or Dashboard.Read.All
            /// - Report.ReadWrite.All or Report.Read.All
            /// - Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace ID
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard ID
            /// </param>
            /// <param name='tileId'>
            /// The tile ID
            /// </param>
            /// <param name='requestParameters'>
            /// Generate token parameters
            /// </param>
            public static EmbedToken GenerateTokenInGroup(this ITilesOperations operations, System.Guid groupId, System.Guid dashboardId, System.Guid tileId, GenerateTokenRequest requestParameters)
            {
                return operations.GenerateTokenInGroupAsync(groupId, dashboardId, tileId, requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates an embed token to view the specified tile from the specified
            /// workspace.
            /// </summary>
            /// <remarks>
            ///
            /// &gt; [!IMPORTANT]
            /// &gt; This API call is only relevant to the [embed for your
            /// customers](/power-bi/developer/embed-sample-for-customers) scenario. To
            /// learn more about using this API, see [Considerations when generating an
            /// embed token](/power-bi/developer/embedded/generate-embed-token).
            ///
            /// ## Permissions
            ///
            /// When using a service principal for authentication, refer to [Embed Power BI
            /// content with service
            /// principal](/power-bi/developer/embed-service-principal) and [Considerations
            /// and
            /// limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
            ///
            /// ## Required Scope
            ///
            /// All of the following:
            ///
            /// - Dashboard.ReadWrite.All or Dashboard.Read.All
            /// - Report.ReadWrite.All or Report.Read.All
            /// - Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace ID
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard ID
            /// </param>
            /// <param name='tileId'>
            /// The tile ID
            /// </param>
            /// <param name='requestParameters'>
            /// Generate token parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EmbedToken> GenerateTokenInGroupAsync(this ITilesOperations operations, System.Guid groupId, System.Guid dashboardId, System.Guid tileId, GenerateTokenRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateTokenInGroupWithHttpMessagesAsync(groupId, dashboardId, tileId, requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
