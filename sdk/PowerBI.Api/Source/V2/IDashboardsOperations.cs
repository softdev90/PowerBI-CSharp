// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DashboardsOperations operations.
    /// </summary>
    public partial interface IDashboardsOperations
    {
        /// <summary>
        /// Returns a list of dashboards from **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
        /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
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
        Task<HttpOperationResponse<Dashboards>> GetDashboardsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new empty dashboard on **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Content.Create &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='requestParameters'>
        /// Add dashboard parameters
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
        Task<HttpOperationResponse<Dashboard>> AddDashboardWithHttpMessagesAsync(AddDashboardRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified dashboard from **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
        /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='dashboardId'>
        /// The dashboard id
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
        Task<HttpOperationResponse<Dashboard>> GetDashboardWithHttpMessagesAsync(System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of tiles within the specified dashboard from **"My
        /// Workspace"**.
        /// </summary>
        /// <remarks>
        /// **Note**: All tile types are supported except for "model tiles",
        /// which include datasets and live tiles that contain an entire report
        /// page. &lt;br/&gt;&lt;br/&gt;**Required scope**:
        /// Dashboard.ReadWrite.All or Dashboard.Read.All &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='dashboardId'>
        /// The dashboard id
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
        Task<HttpOperationResponse<Tiles>> GetTilesWithHttpMessagesAsync(System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified tile within the specified dashboard from
        /// **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// **Note**: All tile types are supported except for "model tiles",
        /// which include datasets and live tiles that contain an entire report
        /// page. &lt;br/&gt;&lt;br/&gt;**Required scope**:
        /// Dashboard.ReadWrite.All or Dashboard.Read.All &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='dashboardId'>
        /// The dashboard id
        /// </param>
        /// <param name='tileId'>
        /// The tile id
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
        Task<HttpOperationResponse<Tile>> GetTileWithHttpMessagesAsync(System.Guid dashboardId, System.Guid tileId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Clones the specified tile from **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;If target report id and target dataset are not
        /// specified, the following can occur:&lt;li&gt;When a tile clone is
        /// performed within the same workspace, the report and dataset links
        /// will be cloned from the source tile.&lt;/li&gt;&lt;li&gt;When
        /// cloning a tile within a different workspace, report and dataset
        /// links will be rested, and the tile will be
        /// broken.&lt;/li&gt;&lt;br/&gt;**Required scope**:
        /// Dashboard.ReadWrite.All &lt;br/&gt;To set the permissions scope,
        /// see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='dashboardId'>
        /// The dashboard id
        /// </param>
        /// <param name='tileId'>
        /// The tile id
        /// </param>
        /// <param name='requestParameters'>
        /// Clone tile parameters
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
        Task<HttpOperationResponse<Tile>> CloneTileWithHttpMessagesAsync(System.Guid dashboardId, System.Guid tileId, CloneTileRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of dashboards from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
        /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
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
        Task<HttpOperationResponse<Dashboards>> GetDashboardsInGroupWithHttpMessagesAsync(System.Guid groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new empty dashboard on the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Content.Create &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='requestParameters'>
        /// Add dashboard parameters
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
        Task<HttpOperationResponse<Dashboard>> AddDashboardInGroupWithHttpMessagesAsync(System.Guid groupId, AddDashboardRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified dashboard from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
        /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard id
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
        Task<HttpOperationResponse<Dashboard>> GetDashboardInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of tiles within the specified dashboard from the
        /// specified workspace.
        /// </summary>
        /// <remarks>
        /// **Note**: All tile types are supported except for "model tiles",
        /// which include datasets and live tiles that contain an entire report
        /// page. &lt;br/&gt;&lt;br/&gt;**Required scope**:
        /// Dashboard.ReadWrite.All or Dashboard.Read.All &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard id
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
        Task<HttpOperationResponse<Tiles>> GetTilesInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified tile within the specified dashboard from the
        /// specified workspace.
        /// </summary>
        /// <remarks>
        /// **Note**: All tile types are supported except for "model tiles",
        /// which include datasets and live tiles that contain an entire report
        /// page. &lt;br/&gt;&lt;br/&gt;**Required scope**:
        /// Dashboard.ReadWrite.All or Dashboard.Read.All &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard id
        /// </param>
        /// <param name='tileId'>
        /// The tile id
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
        Task<HttpOperationResponse<Tile>> GetTileInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, System.Guid tileId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Clones the specified tile from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;If target report id and target dataset are missing, the
        /// following can occur:&lt;li&gt;When a tile clone is performed within
        /// the same workspace, the report and dataset links will be cloned
        /// from the source tile.&lt;/li&gt;&lt;li&gt;If you are cloning a tile
        /// within a different workspace, report and dataset links will be
        /// rested. The tile will be broken.&lt;/li&gt;&lt;br/&gt;**Required
        /// scope**: Dashboard.ReadWrite.All &lt;br/&gt;To set the permissions
        /// scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard id
        /// </param>
        /// <param name='tileId'>
        /// The tile id
        /// </param>
        /// <param name='requestParameters'>
        /// Clone tile parameters
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
        Task<HttpOperationResponse<Tile>> CloneTileInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, System.Guid tileId, CloneTileRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generates an embed token to view the specified dashboard from the
        /// specified workspace.&lt;br/&gt;This API is relevant only to ['App
        /// owns data' embed
        /// scenario](https://docs.microsoft.com/power-bi/developer/embed-sample-for-customers).
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: (all of the below)
        /// &lt;ul&gt;&lt;li&gt;Dashboard.ReadWrite.All or
        /// Dashboard.Read.All&lt;/li&gt;&lt;li&gt;Report.ReadWrite.All or
        /// Report.Read.All &lt;/li&gt;&lt;li&gt;Dataset.ReadWrite.All or
        /// Dataset.Read.All&lt;/li&gt;&lt;/ul&gt; &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard id
        /// </param>
        /// <param name='requestParameters'>
        /// Generate token parameters
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
        Task<HttpOperationResponse<EmbedToken>> GenerateTokenInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, GenerateTokenRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of dashboards from the specified workspace.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;This API allows 200 requests per hour at
        /// maximum. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a boolean condition
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results
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
        Task<HttpOperationResponse<Dashboards>> GetDashboardsInGroupAsAdminWithHttpMessagesAsync(System.Guid groupId, string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of dashboards for the organization.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;This API allows 200 requests per hour at
        /// maximum. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='filter'>
        /// Filters the results, based on a boolean condition
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results
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
        Task<HttpOperationResponse<Dashboards>> GetDashboardsAsAdminWithHttpMessagesAsync(string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of tiles within the specified dashboard.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;This API allows 200 requests per hour at
        /// maximum. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='dashboardId'>
        /// The dashboard id
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
        Task<HttpOperationResponse<Tiles>> GetTilesAsAdminWithHttpMessagesAsync(System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
