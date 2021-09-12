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
    /// AppsOperations operations.
    /// </summary>
    public partial interface IAppsOperations
    {
        /// <summary>
        /// Returns a list of installed apps.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: App.Read.All&lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
        /// Service principal authentication is not supported.&lt;br/&gt;
        /// </remarks>
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
        Task<HttpOperationResponse<Apps>> GetAppsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified installed app.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: App.Read.All&lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
        /// Service principal authentication is not supported.&lt;br/&gt;
        /// </remarks>
        /// <param name='appId'>
        /// The app ID
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
        Task<HttpOperationResponse<App>> GetAppWithHttpMessagesAsync(System.Guid appId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of reports from the specified app.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
        /// Service principal authentication is not supported.&lt;br/&gt;
        /// </remarks>
        /// <param name='appId'>
        /// The app ID
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
        Task<HttpOperationResponse<Reports>> GetReportsWithHttpMessagesAsync(System.Guid appId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified report from the specified app.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
        /// Service principal authentication is not supported.&lt;br/&gt;
        /// </remarks>
        /// <param name='appId'>
        /// The app ID
        /// </param>
        /// <param name='reportId'>
        /// The report ID
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
        Task<HttpOperationResponse<Report>> GetReportWithHttpMessagesAsync(System.Guid appId, System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of dashboards from the specified app.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
        /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
        /// Service principal authentication is not supported.&lt;br/&gt;
        /// </remarks>
        /// <param name='appId'>
        /// The app ID
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
        Task<HttpOperationResponse<Dashboards>> GetDashboardsWithHttpMessagesAsync(System.Guid appId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified dashboard from the specified app.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
        /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
        /// Service principal authentication is not supported.&lt;br/&gt;
        /// </remarks>
        /// <param name='appId'>
        /// The app ID
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard ID
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
        Task<HttpOperationResponse<Dashboard>> GetDashboardWithHttpMessagesAsync(System.Guid appId, System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of tiles within the specified dashboard from the
        /// specified app.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
        /// Dashboard.Read.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
        /// Service principal authentication is not supported.&lt;br/&gt;
        /// </remarks>
        /// <param name='appId'>
        /// The app ID
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard ID
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
        Task<HttpOperationResponse<Tiles>> GetTilesWithHttpMessagesAsync(System.Guid appId, System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified tile within the specified dashboard from the
        /// specified app.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Note**: All tile types are supported except for "model
        /// tiles", which include datasets and live tiles that contain an
        /// entire report page. &lt;br/&gt;&lt;br/&gt;**Required scope**:
        /// Dashboard.ReadWrite.All or Dashboard.Read.All &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
        /// Service principal authentication is not supported.&lt;br/&gt;
        /// </remarks>
        /// <param name='appId'>
        /// The app ID
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard ID
        /// </param>
        /// <param name='tileId'>
        /// The tile ID
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
        Task<HttpOperationResponse<Tile>> GetTileWithHttpMessagesAsync(System.Guid appId, System.Guid dashboardId, System.Guid tileId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of apps in the organization. This is a preview API
        /// call.
        /// </summary>
        /// <remarks>
        ///
        /// The query parameter $top is required.
        ///
        /// ## Permissions
        ///
        /// Delegated permissions are supported.
        ///
        /// ## Required scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='top'>
        /// The requested number of entries in the refresh history. If not
        /// provided, the default is all available entries.
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
        Task<HttpOperationResponse<Apps>> GetAppsAsAdminWithHttpMessagesAsync(int top, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of users that have access to the specified app. This
        /// is a preview API call.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// Delegated permissions are supported.
        ///
        /// ## Required scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='appId'>
        /// The app ID
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
        Task<HttpOperationResponse<AppUsers>> GetAppUsersAsAdminWithHttpMessagesAsync(System.Guid appId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
