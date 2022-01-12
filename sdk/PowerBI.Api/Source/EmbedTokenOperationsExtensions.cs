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
    /// Extension methods for EmbedTokenOperations.
    /// </summary>
    public static partial class EmbedTokenOperationsExtensions
    {
            /// <summary>
            /// Generates an embed token for multiple reports, datasets, and target
            /// workspaces.
            /// </summary>
            /// <remarks>
            ///
            /// - Reports and datasets don't have to be related.
            /// - You can bind a report to a dataset during embedding.
            /// - You can only create a report in workspaces specified by the
            /// `targetWorkspaces` parameter.
            ///
            /// &gt; [!IMPORTANT]
            /// &gt; This API is only relevant to the [embed for your
            /// customers](/power-bi/developer/embed-sample-for-customers) scenario. To
            /// learn more about using this API, see [Considerations when generating an
            /// embed token](/power-bi/developer/embedded/generate-embed-token).
            ///
            /// ## Permissions
            ///
            /// - When using a service principal for authentication, refer to [Embed Power
            /// BI content with service
            /// principal](/power-bi/developer/embed-service-principal) and [Considerations
            /// and
            /// limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
            /// - For PowerBI reports with a paginated visual, include the paginated report
            /// ID in the API call. For more information, see
            /// [example](/rest/api/power-bi/embed-token/generate-token#examples).
            ///
            /// ## Required Scope
            ///
            /// All of the following, unless a requirement doesn't apply:
            ///
            /// - Content.Create, required if a target workspace is specified in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
            /// - Report.ReadWrite.All or Report.Read.All, required if a report is
            /// specified in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
            /// - Report.ReadWrite.All, required if the `allowEdit` flag is specified for
            /// at least one report in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
            /// - Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// - You can only create a report in workspaces specified by the
            /// `targetWorkspaces` parameter.
            /// - All reports and datasets must reside in a **V2** workspace.
            /// - All target workspaces must be **V2** workspaces.
            /// - Maximum 50 reports.
            /// - Maximum 50 datasets.
            /// - Maximum 50 target workspaces.
            /// - For Azure Analysis Services or Analysis Services on-premises live
            /// connection reports, generating an embed token with row-level security (RLS)
            /// might not work for several minutes after a
            /// [rebind](/rest/api/power-bi/reports/rebind-report).
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Generate token parameters
            /// </param>
            public static EmbedToken GenerateToken(this IEmbedTokenOperations operations, GenerateTokenRequestV2 requestParameters)
            {
                return operations.GenerateTokenAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates an embed token for multiple reports, datasets, and target
            /// workspaces.
            /// </summary>
            /// <remarks>
            ///
            /// - Reports and datasets don't have to be related.
            /// - You can bind a report to a dataset during embedding.
            /// - You can only create a report in workspaces specified by the
            /// `targetWorkspaces` parameter.
            ///
            /// &gt; [!IMPORTANT]
            /// &gt; This API is only relevant to the [embed for your
            /// customers](/power-bi/developer/embed-sample-for-customers) scenario. To
            /// learn more about using this API, see [Considerations when generating an
            /// embed token](/power-bi/developer/embedded/generate-embed-token).
            ///
            /// ## Permissions
            ///
            /// - When using a service principal for authentication, refer to [Embed Power
            /// BI content with service
            /// principal](/power-bi/developer/embed-service-principal) and [Considerations
            /// and
            /// limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
            /// - For PowerBI reports with a paginated visual, include the paginated report
            /// ID in the API call. For more information, see
            /// [example](/rest/api/power-bi/embed-token/generate-token#examples).
            ///
            /// ## Required Scope
            ///
            /// All of the following, unless a requirement doesn't apply:
            ///
            /// - Content.Create, required if a target workspace is specified in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
            /// - Report.ReadWrite.All or Report.Read.All, required if a report is
            /// specified in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
            /// - Report.ReadWrite.All, required if the `allowEdit` flag is specified for
            /// at least one report in
            /// [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
            /// - Dataset.ReadWrite.All or Dataset.Read.All
            ///
            /// ## Limitations
            ///
            /// - You can only create a report in workspaces specified by the
            /// `targetWorkspaces` parameter.
            /// - All reports and datasets must reside in a **V2** workspace.
            /// - All target workspaces must be **V2** workspaces.
            /// - Maximum 50 reports.
            /// - Maximum 50 datasets.
            /// - Maximum 50 target workspaces.
            /// - For Azure Analysis Services or Analysis Services on-premises live
            /// connection reports, generating an embed token with row-level security (RLS)
            /// might not work for several minutes after a
            /// [rebind](/rest/api/power-bi/reports/rebind-report).
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Generate token parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EmbedToken> GenerateTokenAsync(this IEmbedTokenOperations operations, GenerateTokenRequestV2 requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateTokenWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
