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
    /// DashboardsOperations operations.
    /// </summary>
    public partial interface IDashboardsOperations
    {
        /// <summary>
        /// Returns a list of dashboards from **My workspace**.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All or Dashboard.Read.All
        ///
        /// ######
        ///
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
        /// Creates a new empty dashboard in **My workspace**.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required scope
        ///
        /// Content.Create
        ///
        /// ######
        ///
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
        /// Returns the specified dashboard from **My workspace**.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All or Dashboard.Read.All
        ///
        /// ######
        ///
        /// </remarks>
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
        Task<HttpOperationResponse<Dashboard>> GetDashboardWithHttpMessagesAsync(System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of tiles within the specified dashboard from **My
        /// workspace**.
        /// </summary>
        /// <remarks>
        ///
        /// Supported tiles include datasets and live tiles that contain an
        /// entire report page.
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All or Dashboard.Read.All
        ///
        /// ######
        ///
        /// </remarks>
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
        Task<HttpOperationResponse<Tiles>> GetTilesWithHttpMessagesAsync(System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified tile within the specified dashboard from **My
        /// workspace**.
        /// </summary>
        /// <remarks>
        ///
        /// Supported tiles include datasets and live tiles that contain an
        /// entire report page.
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All or Dashboard.Read.All
        ///
        /// ######
        ///
        /// </remarks>
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
        Task<HttpOperationResponse<Tile>> GetTileWithHttpMessagesAsync(System.Guid dashboardId, System.Guid tileId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Clones the specified tile from **My workspace**.
        /// </summary>
        /// <remarks>
        ///
        /// When a tile is cloned to another workspace and bound to another
        /// report and dataset, it's cloned as is with its underlying query
        /// containing the original report filters.
        ///
        /// If the target report ID and target dataset are missing, the
        /// following can occur:
        /// - If you're cloning a tile within the same workspace, the report
        /// and dataset links will be cloned from the source tile.
        /// - If you're cloning a tile within a different workspace, report and
        /// dataset links will be removed, and the tile will be broken.
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='dashboardId'>
        /// The dashboard ID
        /// </param>
        /// <param name='tileId'>
        /// The tile ID
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
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All or Dashboard.Read.All
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
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
        /// Creates a new empty dashboard in the specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required scope
        ///
        /// Content.Create
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
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
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All or Dashboard.Read.All
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
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
        Task<HttpOperationResponse<Dashboard>> GetDashboardInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of tiles within the specified dashboard from the
        /// specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// Supported tiles include datasets and live tiles that contain an
        /// entire report page.
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All or Dashboard.Read.All
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
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
        Task<HttpOperationResponse<Tiles>> GetTilesInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified tile within the specified dashboard from the
        /// specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// Supported tiles include datasets and live tiles that contain an
        /// entire report page.
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All or Dashboard.Read.All
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
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
        Task<HttpOperationResponse<Tile>> GetTileInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, System.Guid tileId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Clones the specified tile from the specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// When a tile is cloned to another workspace and bound to another
        /// report and dataset, it's cloned as is with its underlying query
        /// containing the original report filters.
        ///
        /// If the target report ID and target dataset are missing, the
        /// following can occur:
        /// - If you're cloning a tile within the same workspace, the report
        /// and dataset links will be cloned from the source tile.
        /// - If you're cloning a tile within a different workspace, report and
        /// dataset links will be removed, and the tile will be broken.
        ///
        /// ## Required scope
        ///
        /// Dashboard.ReadWrite.All
        ///
        /// ######
        ///
        /// </remarks>
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
        /// specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// &gt; [!IMPORTANT]
        /// &gt; This API is only relevant to the [embed for your
        /// customers](/power-bi/developer/embed-sample-for-customers)
        /// scenario. To learn more about using this API, see [Considerations
        /// when generating an embed
        /// token](/power-bi/developer/embedded/generate-embed-token).
        ///
        /// ## Permissions
        ///
        /// When using a service principal for authentication, refer to [Embed
        /// Power BI content with service
        /// principal](/power-bi/developer/embed-service-principal) and
        /// [Considerations and
        /// limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
        ///
        /// ## Required scope
        ///
        /// All of the following:
        ///
        /// - Dashboard.ReadWrite.All or Dashboard.Read.All
        /// - Report.ReadWrite.All or Report.Read.All
        /// - Dataset.ReadWrite.All or Dataset.Read.All
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard ID
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
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
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
        /// <param name='groupId'>
        /// The workspace ID
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
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
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
        /// <param name='expand'>
        /// Expands related entities inline, receives a comma-separated list of
        /// data types. Supported: tiles
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
        Task<HttpOperationResponse<Dashboards>> GetDashboardsAsAdminWithHttpMessagesAsync(string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of tiles within the specified dashboard.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
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
        Task<HttpOperationResponse<Tiles>> GetTilesAsAdminWithHttpMessagesAsync(System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of users that have access to the specified
        /// dashboard. This is a preview API call.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
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
        Task<HttpOperationResponse<DashboardUsers>> GetDashboardUsersAsAdminWithHttpMessagesAsync(System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of subscriptions along with subscribees that the
        /// dashboard subscribed to. This is a preview API call.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
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
        Task<HttpOperationResponse<Subscriptions>> GetDashboardSubscriptionsAsAdminWithHttpMessagesAsync(System.Guid dashboardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
