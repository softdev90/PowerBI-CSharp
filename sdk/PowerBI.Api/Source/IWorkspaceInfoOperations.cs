// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// WorkspaceInfoOperations operations.
    /// </summary>
    public partial interface IWorkspaceInfoOperations
    {
        /// <summary>
        /// Initiate a call to receive metadata for the requested list of
        /// workspaces. (Preview)
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as
        /// Microsoft 365 Global Administrator or Power BI Service
        /// Administrator) to call this API or authenticate via service
        /// principal. &lt;br/&gt;This API allows a maximum of 500 requests per
        /// hour, and not more than 16 simultaneously.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
        /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='requiredWorkspaces'>
        /// Required workspace IDs to get info for
        /// </param>
        /// <param name='lineage'>
        /// Whether to return lineage info (upstream dataflows, tiles,
        /// datasource IDs)​
        /// </param>
        /// <param name='datasourceDetails'>
        /// Whether to return datasource details​
        /// </param>
        /// <param name='getArtifactUsers'>
        /// Whether to return artifact user details​
        /// <param name='datasetSchema'>
        /// Whether to return dataset schema (Tables, Columns and Measures)​
        /// </param>
        /// <param name='datasetExpressions'>
        /// Whether to return dataset expressions (Dax query and Mashup)​
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ScanRequest>> PostWorkspaceInfoWithHttpMessagesAsync(RequiredWorkspaces requiredWorkspaces, bool? lineage = default(bool?), bool? datasourceDetails = default(bool?), bool? datasetSchema = default(bool?), bool? datasetExpressions = default(bool?), bool? getArtifactUsers = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets scan status for the specified scan. (Preview)
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as
        /// Microsoft 365 Global Administrator or Power BI Service
        /// Administrator) to call this API or authenticate via service
        /// principal. &lt;br/&gt;This API allows a maximum of 10000 requests
        /// per hour. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='scanId'>
        /// The scan id to provide is the one from the response of
        /// workspaces/getInfo API which triggered the scan
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ScanRequest>> GetScanStatusWithHttpMessagesAsync(System.Guid scanId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets scan result for the specified scan (should be called only
        /// after getting status Succeeded in the scan status API). Scan result
        /// will be available for up to 24 hours. (Preview)
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as
        /// Microsoft 365 Global Administrator or Power BI Service
        /// Administrator) to call this API or authenticate via service
        /// principal. &lt;br/&gt;This API allows a maximum of 500 requests per
        /// hour. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
        /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='scanId'>
        /// The scan id to provide is the one from the response of
        /// workspaces/getInfo API which triggered the scan
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<WorkspaceInfoResponse>> GetScanResultWithHttpMessagesAsync(System.Guid scanId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of workspace IDs in the organization. When using
        /// modifiedSince, returns only the IDs of workspaces that had changed
        /// since the time specified in the modifiedSince parameter. If not
        /// provided, returns a list of all workspace IDs in the organization.
        /// modifiedSince parameter should range from 30 minutes to 30 days
        /// ago. Notice changes can take up to 30 minutes to take effect.
        /// (Preview)
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as
        /// Microsoft 365 Global Administrator or Power BI Service
        /// Administrator) to call this API or authenticate via service
        /// principal. &lt;br/&gt;This API allows a maximum of 30 requests per
        /// hour. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
        /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='modifiedSince'>
        /// Last modified date​ (must be in ISO 8601 compliant UTC format)
        /// </param>
        /// <param name='excludePersonalWorkspaces'>
        /// Whether to exclude personal workspaces​
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ModifiedWorkspaces>> GetModifiedWorkspacesWithHttpMessagesAsync(System.DateTime? modifiedSince = default(System.DateTime?), bool? excludePersonalWorkspaces = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
