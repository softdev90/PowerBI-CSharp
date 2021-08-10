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
    /// Admin operations.
    /// </summary>
    public partial interface IAdmin
    {
        /// <summary>
        /// Adds an encryption key for Power BI workspaces assigned to a
        /// capacity.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;This API allows 600 requests per hour at
        /// maximum. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='tenantKeyCreationRequest'>
        /// Tenant key information
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
        Task<HttpOperationResponse<TenantKey>> AddPowerBIEncryptionKeyWithHttpMessagesAsync(TenantKeyCreationRequest tenantKeyCreationRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the encryption keys for the tenant.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API or authenticate via service principal.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
        /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are
        /// supported. &lt;br/&gt;To set the permissions scope, see [Register
        /// an
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
        Task<HttpOperationResponse<TenantKeys>> GetPowerBIEncryptionKeysWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Rotate the encryption key for Power BI workspaces assigned to a
        /// capacity.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;This API allows 600 requests per hour at
        /// maximum. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='tenantKeyId'>
        /// Tenant key id
        /// </param>
        /// <param name='tenantKeyRotationRequest'>
        /// Tenant key information
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
        Task<HttpOperationResponse<TenantKey>> RotatePowerBIEncryptionKeyWithHttpMessagesAsync(System.Guid tenantKeyId, TenantKeyRotationRequest tenantKeyRotationRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of capacities for the organization.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API or authenticate via service principal.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
        /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are
        /// supported. &lt;br/&gt;To set the permissions scope, see [Register
        /// an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='expand'>
        /// Expands related entities inline
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
        Task<HttpOperationResponse<Capacities>> GetCapacitiesAsAdminWithHttpMessagesAsync(string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Changes the specific capacity information. Currently, only supports
        /// changing the capacity encryption key
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity Id
        /// </param>
        /// <param name='capacityPatchRequest'>
        /// Patch capacity information
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> PatchCapacityAsAdminWithHttpMessagesAsync(System.Guid capacityId, CapacityPatchRequest capacityPatchRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of refreshables for the organization within a
        /// capacity
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API or authenticate via service principal.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
        /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are
        /// supported. &lt;br/&gt;To set the permissions scope, see [Register
        /// an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline, receives a comma-separated list of
        /// data types. Supported: capacities and groups
        /// </param>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results. Use with top to fetch results beyond the
        /// first 1000.
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
        Task<HttpOperationResponse<Refreshables>> GetRefreshablesWithHttpMessagesAsync(int top, string expand = default(string), string filter = default(string), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of refreshables for the specified capacity the user
        /// has access to
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API or authenticate via service principal.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
        /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are
        /// supported. &lt;br/&gt;To set the permissions scope, see [Register
        /// an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity id
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline, receives a comma-separated list of
        /// data types. Supported: capacities and groups
        /// </param>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results. Use with top to fetch results beyond the
        /// first 1000.
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
        Task<HttpOperationResponse<Refreshables>> GetRefreshablesForCapacityWithHttpMessagesAsync(System.Guid capacityId, int top, string expand = default(string), string filter = default(string), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified refreshable for the specified capacity the
        /// user has access to
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API or authenticate via service principal.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
        /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are
        /// supported. &lt;br/&gt;To set the permissions scope, see [Register
        /// an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity id
        /// </param>
        /// <param name='refreshableId'>
        /// The refreshable id
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline, receives a comma-separated list of
        /// data types. Supported: capacities and groups
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
        Task<HttpOperationResponse<Refreshables>> GetRefreshableForCapacityWithHttpMessagesAsync(System.Guid capacityId, string refreshableId, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of audit activity events for a tenant.
        /// </summary>
        /// <remarks>
        /// **Note:** Activity logging isn’t supported for Microsoft Cloud
        /// Deutschland. The user must have administrator rights (such as
        /// Office 365 Global Administrator or Power BI Service Administrator)
        /// to call this API or authenticate via service principal.
        /// &lt;br/&gt;This API allows 200 requests per hour at maximum.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
        /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are
        /// supported. &lt;br/&gt;To call this API, provide either a
        /// continuation token or both a start and end date time. StartDateTime
        /// and EndDateTime must be in the same UTC day and should be wrapped
        /// in ''.
        /// </remarks>
        /// <param name='startDateTime'>
        /// Start date and time of the window for audit event results. Must be
        /// in ISO 8601 compliant UTC format.
        /// </param>
        /// <param name='endDateTime'>
        /// End date and time of the window for audit event results. Must be in
        /// ISO 8601 compliant UTC format.
        /// </param>
        /// <param name='continuationToken'>
        /// Token required to get the next chunk of the result set
        /// </param>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition, using 'Activity',
        /// 'UserId', or both properties. Supports only 'eq' and 'and'
        /// operators.
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
        Task<HttpOperationResponse<ActivityEventResponse>> GetActivityEventsWithHttpMessagesAsync(string startDateTime = default(string), string endDateTime = default(string), string continuationToken = default(string), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
