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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ReportsOperations operations.
    /// </summary>
    public partial interface IReportsOperations
    {
        /// <summary>
        /// Returns a list of reports from **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
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
        Task<HttpOperationResponse<Reports>> GetReportsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified report from **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse<Report>> GetReportWithHttpMessagesAsync(System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified report from **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All &lt;br/&gt;To
        /// set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse> DeleteReportWithHttpMessagesAsync(System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Clones the specified report from **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;Reports with live connection will lose the live
        /// connection when cloning, and will have a direct binding to the
        /// target dataset.&lt;br/&gt;**Required scope**:
        /// Content.Create&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='reportId'>
        /// The report id
        /// </param>
        /// <param name='requestParameters'>
        /// Clone report parameters
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
        Task<HttpOperationResponse<Report>> CloneReportWithHttpMessagesAsync(System.Guid reportId, CloneReportRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Exports the specified report from **"My Workspace"** to a .pbix
        /// file.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// &lt;h2&gt;Restrictions&lt;/h2&gt;Export of a report with [Power BI
        /// service live
        /// connection](https://docs.microsoft.com/en-us/power-bi/desktop-report-lifecycle-datasets)
        /// after calling [rebind
        /// report](/rest/api/power-bi/reports/RebindReport) is not
        /// supported.&lt;br/&gt;
        /// </remarks>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse<Stream>> ExportReportWithHttpMessagesAsync(System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified report from **"My Workspace"** to have the
        /// same content as the report in the request body.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All &lt;br/&gt;To
        /// set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='reportId'>
        /// The report id
        /// </param>
        /// <param name='requestParameters'>
        /// UpdateReportContent parameters
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
        Task<HttpOperationResponse<Report>> UpdateReportContentWithHttpMessagesAsync(System.Guid reportId, UpdateReportContentRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Rebinds the specified report from **"My Workspace"** to the
        /// requested dataset.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;Reports with live connection will lose the live
        /// connection when rebinding, and will have a direct binding to the
        /// target dataset.&lt;br/&gt;**Required scope**: Report.ReadWrite.All
        /// &lt;br/&gt;To set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='reportId'>
        /// The report id
        /// </param>
        /// <param name='requestParameters'>
        /// Rebind report parameters
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
        Task<HttpOperationResponse> RebindReportWithHttpMessagesAsync(System.Guid reportId, RebindReportRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of pages within the specified report from **"My
        /// Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse<Pages>> GetPagesWithHttpMessagesAsync(System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified page within the specified report from **"My
        /// Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='reportId'>
        /// The report id
        /// </param>
        /// <param name='pageName'>
        /// The page name
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
        Task<HttpOperationResponse<Page>> GetPageWithHttpMessagesAsync(System.Guid reportId, string pageName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of datasources for the specified RDL report from
        /// **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse<Datasources>> GetDatasourcesWithHttpMessagesAsync(System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of reports from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
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
        Task<HttpOperationResponse<Reports>> GetReportsInGroupWithHttpMessagesAsync(System.Guid groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified report from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse<Report>> GetReportInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified report from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All &lt;br/&gt;To
        /// set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse> DeleteReportInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Clones the specified report from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;Reports with live connection will lose the live
        /// connection when cloning, and will have a direct binding to the
        /// target dataset.&lt;br/&gt;**Required scope**: Content.Create
        /// &lt;br/&gt;To set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
        /// The report id
        /// </param>
        /// <param name='requestParameters'>
        /// Clone report parameters
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
        Task<HttpOperationResponse<Report>> CloneReportInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, CloneReportRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Exports the specified report from the specified workspace to a
        /// .pbix file.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// &lt;h2&gt;Restrictions&lt;/h2&gt;Export of a report with [Power BI
        /// service live
        /// connection](https://docs.microsoft.com/en-us/power-bi/desktop-report-lifecycle-datasets)
        /// after calling [rebind
        /// report](/rest/api/power-bi/reports/RebindReport) is not
        /// supported.&lt;br/&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse<Stream>> ExportReportInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified report from the specified workspace to have
        /// the same content as the specified report in the request body.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All &lt;br/&gt;To
        /// set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
        /// The report id
        /// </param>
        /// <param name='requestParameters'>
        /// UpdateReportContent parameters
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
        Task<HttpOperationResponse<Report>> UpdateReportContentInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, UpdateReportContentRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Rebinds the specified report from the specified workspace to the
        /// requested dataset.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;Reports with live connection will lose the live
        /// connection when rebinding, and will have a direct binding to the
        /// target dataset.&lt;br/&gt;**Required scope**: Report.ReadWrite.All
        /// &lt;br/&gt;To set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
        /// The report id
        /// </param>
        /// <param name='requestParameters'>
        /// Rebind report parameters
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
        Task<HttpOperationResponse> RebindReportInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, RebindReportRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of pages within the specified report from the
        /// specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse<Pages>> GetPagesInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified page within the specified report from the
        /// specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Report.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
        /// The report id
        /// </param>
        /// <param name='pageName'>
        /// The page name
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
        Task<HttpOperationResponse<Page>> GetPageInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, string pageName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of datasources for the specified RDL report from the
        /// specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or
        /// Reportt.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
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
        Task<HttpOperationResponse<Datasources>> GetDatasourcesInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generates an embed token to allow report creation on the specified
        /// workspace based on the specified dataset.&lt;br/&gt;This API is
        /// relevant only to ['App owns data' embed
        /// scenario](https://docs.microsoft.com/power-bi/developer/embed-sample-for-customers).
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: (all of the below)
        /// &lt;ul&gt;&lt;li&gt;Content.Create&lt;/li&gt;&lt;li&gt;Report.ReadWrite.All
        /// or Report.Read.All&lt;/li&gt;&lt;li&gt;Dataset.ReadWrite.All or
        /// Dataset.Read.All&lt;/li&gt;&lt;/ul&gt; &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// &lt;h2&gt;Restrictions&lt;/h2&gt;Generating Embed Token with RLS
        /// may not work for AS Azure or AS OnPrem live connection reports for
        /// several minutes after a
        /// [Rebind](/rest/api/power-bi/reports/RebindReport).&lt;br/&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
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
        Task<HttpOperationResponse<EmbedToken>> GenerateTokenForCreateInGroupWithHttpMessagesAsync(System.Guid groupId, GenerateTokenRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generates an embed token to view or edit the specified report from
        /// the specified workspace.&lt;br/&gt;This API is relevant only to
        /// ['App owns data' embed
        /// scenario](https://docs.microsoft.com/power-bi/developer/embed-sample-for-customers).
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: (all of the below)
        /// &lt;ul&gt;&lt;li&gt;Report.ReadWrite.All or
        /// Report.Read.All&lt;/li&gt;&lt;li&gt;Dataset.ReadWrite.All or
        /// Dataset.Read.All&lt;/li&gt;&lt;li&gt;Content.Create - required only
        /// if allowSaveAs specified in
        /// [GenerateTokenRequest](/rest/api/power-bi/embedtoken/reports_generatetokeningroup#GenerateTokenRequest)&lt;/li&gt;&lt;/ul&gt;
        /// &lt;br/&gt;To set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// &lt;h2&gt;Restrictions&lt;/h2&gt;Generating Embed Token with RLS
        /// may not work for AS Azure or AS OnPrem live connection reports for
        /// several minutes after a
        /// [Rebind](/rest/api/power-bi/reports/RebindReport).&lt;br/&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='reportId'>
        /// The report id
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
        Task<HttpOperationResponse<EmbedToken>> GenerateTokenInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid reportId, GenerateTokenRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of reports from the specified workspace.
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
        Task<HttpOperationResponse<Reports>> GetReportsInGroupAsAdminWithHttpMessagesAsync(System.Guid groupId, string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of reports for the organization.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
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
        Task<HttpOperationResponse<Reports>> GetReportsAsAdminWithHttpMessagesAsync(string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
