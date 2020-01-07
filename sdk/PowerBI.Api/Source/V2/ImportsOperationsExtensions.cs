// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ImportsOperations.
    /// </summary>
    public static partial class ImportsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of imports from **"My Workspace"**.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Imports GetImports(this IImportsOperations operations)
            {
                return operations.GetImportsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of imports from **"My Workspace"**.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Imports> GetImportsAsync(this IImportsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates new content on **"My Workspace"** from .pbix, Excel, Rdl or file
            /// path in OneDrive for Business.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All &lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// &lt;h3&gt;Notes&lt;/h3&gt;&lt;ul&gt;&lt;li&gt;To import a file, request
            /// Headers should include **Content-Type: multipart/form-data** with the file
            /// [encoded as form data](https://www.w3.org/TR/html401/interact/forms.html)
            /// in the request body. &lt;/li&gt;&lt;li&gt;To import xlsx file from OneDrive
            /// for Business, request Headers should include **Content-Type:
            /// application/json** with
            /// [ImportInfo](/rest/api/power-bi/imports/postimport#importinfo) in the
            /// request body.&lt;/li&gt;&lt;li&gt;Import .pbix file from OneDrive is not
            /// supported.&lt;/li&gt;&lt;li&gt;To import large .pbix files between 1 GB and
            /// 10 GB, see [Create Temporary Upload
            /// Location](/rest/api/power-bi/imports/createtemporaryuploadlocation),
            /// supported only for workspaces on premium capacity.&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetDisplayName'>
            /// The display name of the dataset, should include file extension. Not
            /// supported when importing from OneDrive for Business.
            /// </param>
            /// <param name='importInfo'>
            /// The import to post
            /// </param>
            /// <param name='nameConflict'>
            /// Determines what to do if a dataset with the same name already exists.
            /// Default value is 'Ignore'.&lt;br/&gt;Only Abort and Overwrite are supported
            /// with Rdl files. Possible values include: 'Ignore', 'Abort', 'Overwrite',
            /// 'CreateOrOverwrite', 'GenerateUniqueName'
            /// </param>
            /// <param name='skipReport'>
            /// Determines whether to skip report import, if specified value must be
            /// 'true'. Only supported for PBIX files.
            /// </param>
            public static Import PostImport(this IImportsOperations operations, string datasetDisplayName, ImportInfo importInfo, ImportConflictHandlerMode? nameConflict = default(ImportConflictHandlerMode?), bool? skipReport = default(bool?))
            {
                return operations.PostImportAsync(datasetDisplayName, importInfo, nameConflict, skipReport).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates new content on **"My Workspace"** from .pbix, Excel, Rdl or file
            /// path in OneDrive for Business.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All &lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// &lt;h3&gt;Notes&lt;/h3&gt;&lt;ul&gt;&lt;li&gt;To import a file, request
            /// Headers should include **Content-Type: multipart/form-data** with the file
            /// [encoded as form data](https://www.w3.org/TR/html401/interact/forms.html)
            /// in the request body. &lt;/li&gt;&lt;li&gt;To import xlsx file from OneDrive
            /// for Business, request Headers should include **Content-Type:
            /// application/json** with
            /// [ImportInfo](/rest/api/power-bi/imports/postimport#importinfo) in the
            /// request body.&lt;/li&gt;&lt;li&gt;Import .pbix file from OneDrive is not
            /// supported.&lt;/li&gt;&lt;li&gt;To import large .pbix files between 1 GB and
            /// 10 GB, see [Create Temporary Upload
            /// Location](/rest/api/power-bi/imports/createtemporaryuploadlocation),
            /// supported only for workspaces on premium capacity.&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetDisplayName'>
            /// The display name of the dataset, should include file extension. Not
            /// supported when importing from OneDrive for Business.
            /// </param>
            /// <param name='importInfo'>
            /// The import to post
            /// </param>
            /// <param name='nameConflict'>
            /// Determines what to do if a dataset with the same name already exists.
            /// Default value is 'Ignore'.&lt;br/&gt;Only Abort and Overwrite are supported
            /// with Rdl files. Possible values include: 'Ignore', 'Abort', 'Overwrite',
            /// 'CreateOrOverwrite', 'GenerateUniqueName'
            /// </param>
            /// <param name='skipReport'>
            /// Determines whether to skip report import, if specified value must be
            /// 'true'. Only supported for PBIX files.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Import> PostImportAsync(this IImportsOperations operations, string datasetDisplayName, ImportInfo importInfo, ImportConflictHandlerMode? nameConflict = default(ImportConflictHandlerMode?), bool? skipReport = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostImportWithHttpMessagesAsync(datasetDisplayName, importInfo, nameConflict, skipReport, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified import from **"My Workspace"**.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='importId'>
            /// The import id
            /// </param>
            public static Import GetImport(this IImportsOperations operations, System.Guid importId)
            {
                return operations.GetImportAsync(importId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified import from **"My Workspace"**.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='importId'>
            /// The import id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Import> GetImportAsync(this IImportsOperations operations, System.Guid importId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportWithHttpMessagesAsync(importId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a temporary blob storage to be used to import large .pbix files
            /// larger than 1 GB and up to 10 GB.
            /// </summary>
            /// <remarks>
            /// To import large .pbix files, create a temporary upload location and upload
            /// the .pbix file using the shared access signature (SAS) url from the
            /// response, and then call [Post
            /// Import](/rest/api/power-bi/imports/postimport) and specify 'fileUrl' to be
            /// the SAS url in the [Request
            /// Body](/rest/api/power-bi/imports/postimport#request-body)&lt;br/&gt;&lt;br/&gt;**Note**:
            /// Import large .pbix files is only available for workspaces on premium
            /// capacity and for .pbix files that are between 1 GB and 10 GB.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Dataset.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static TemporaryUploadLocation CreateTemporaryUploadLocation(this IImportsOperations operations)
            {
                return operations.CreateTemporaryUploadLocationAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a temporary blob storage to be used to import large .pbix files
            /// larger than 1 GB and up to 10 GB.
            /// </summary>
            /// <remarks>
            /// To import large .pbix files, create a temporary upload location and upload
            /// the .pbix file using the shared access signature (SAS) url from the
            /// response, and then call [Post
            /// Import](/rest/api/power-bi/imports/postimport) and specify 'fileUrl' to be
            /// the SAS url in the [Request
            /// Body](/rest/api/power-bi/imports/postimport#request-body)&lt;br/&gt;&lt;br/&gt;**Note**:
            /// Import large .pbix files is only available for workspaces on premium
            /// capacity and for .pbix files that are between 1 GB and 10 GB.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Dataset.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TemporaryUploadLocation> CreateTemporaryUploadLocationAsync(this IImportsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateTemporaryUploadLocationWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of imports from the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;li&gt;Import
            /// .pbix file from OneDrive is not supported.&lt;/li&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            public static Imports GetImportsInGroup(this IImportsOperations operations, System.Guid groupId)
            {
                return operations.GetImportsInGroupAsync(groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of imports from the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;li&gt;Import
            /// .pbix file from OneDrive is not supported.&lt;/li&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Imports> GetImportsInGroupAsync(this IImportsOperations operations, System.Guid groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportsInGroupWithHttpMessagesAsync(groupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates new content on the specified workspace from .pbix, .json, Excel,
            /// Rdl, or file path in OneDrive for Business.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All &lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// &lt;h3&gt;Notes&lt;/h3&gt;&lt;ul&gt;&lt;li&gt;To import a file, request
            /// Headers should include **Content-Type: multipart/form-data** with the file
            /// [encoded as form data](https://www.w3.org/TR/html401/interact/forms.html)
            /// in the request body &lt;/li&gt;&lt;li&gt;To import from OneDrive for
            /// Business, request Headers should include **Content-Type: application/json**
            /// with [ImportInfo](/rest/api/power-bi/imports/postimportingroup#importinfo)
            /// in the request body.&lt;/li&gt;&lt;li&gt;To import large .pbix files
            /// between 1 GB and 10 GB see [Create Temporary Upload Location In
            /// Group](/rest/api/power-bi/imports/createtemporaryuploadlocationingroup),
            /// supported only for workspaces on premium capacity.&lt;/li&gt;&lt;li&gt;To
            /// create a dataflow from a model.json, specify the parameter
            /// datasetDisplayName as described below.&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetDisplayName'>
            /// The display name of the dataset should include file extension. Not
            /// supported when importing from OneDrive for Business. For importing or
            /// creating dataflows, this parameter should be hardcoded to model.json.
            /// </param>
            /// <param name='importInfo'>
            /// The import to post
            /// </param>
            /// <param name='nameConflict'>
            /// Determines what to do if a dataset with the same name already exists.
            /// Default value is 'Ignore'.&lt;br/&gt;Only Abort and Overwrite are supported
            /// with Rdl files.&lt;br/&gt;Only Abort and GenerateUniqueName are supported
            /// with dataflow model.json files. Possible values include: 'Ignore', 'Abort',
            /// 'Overwrite', 'CreateOrOverwrite', 'GenerateUniqueName'
            /// </param>
            /// <param name='skipReport'>
            /// Determines whether to skip report import, if specified value must be
            /// 'true'. Only supported for PBIX files.
            /// </param>
            public static Import PostImportInGroup(this IImportsOperations operations, System.Guid groupId, string datasetDisplayName, ImportInfo importInfo, ImportConflictHandlerMode? nameConflict = default(ImportConflictHandlerMode?), bool? skipReport = default(bool?))
            {
                return operations.PostImportInGroupAsync(groupId, datasetDisplayName, importInfo, nameConflict, skipReport).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates new content on the specified workspace from .pbix, .json, Excel,
            /// Rdl, or file path in OneDrive for Business.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All &lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// &lt;h3&gt;Notes&lt;/h3&gt;&lt;ul&gt;&lt;li&gt;To import a file, request
            /// Headers should include **Content-Type: multipart/form-data** with the file
            /// [encoded as form data](https://www.w3.org/TR/html401/interact/forms.html)
            /// in the request body &lt;/li&gt;&lt;li&gt;To import from OneDrive for
            /// Business, request Headers should include **Content-Type: application/json**
            /// with [ImportInfo](/rest/api/power-bi/imports/postimportingroup#importinfo)
            /// in the request body.&lt;/li&gt;&lt;li&gt;To import large .pbix files
            /// between 1 GB and 10 GB see [Create Temporary Upload Location In
            /// Group](/rest/api/power-bi/imports/createtemporaryuploadlocationingroup),
            /// supported only for workspaces on premium capacity.&lt;/li&gt;&lt;li&gt;To
            /// create a dataflow from a model.json, specify the parameter
            /// datasetDisplayName as described below.&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetDisplayName'>
            /// The display name of the dataset should include file extension. Not
            /// supported when importing from OneDrive for Business. For importing or
            /// creating dataflows, this parameter should be hardcoded to model.json.
            /// </param>
            /// <param name='importInfo'>
            /// The import to post
            /// </param>
            /// <param name='nameConflict'>
            /// Determines what to do if a dataset with the same name already exists.
            /// Default value is 'Ignore'.&lt;br/&gt;Only Abort and Overwrite are supported
            /// with Rdl files.&lt;br/&gt;Only Abort and GenerateUniqueName are supported
            /// with dataflow model.json files. Possible values include: 'Ignore', 'Abort',
            /// 'Overwrite', 'CreateOrOverwrite', 'GenerateUniqueName'
            /// </param>
            /// <param name='skipReport'>
            /// Determines whether to skip report import, if specified value must be
            /// 'true'. Only supported for PBIX files.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Import> PostImportInGroupAsync(this IImportsOperations operations, System.Guid groupId, string datasetDisplayName, ImportInfo importInfo, ImportConflictHandlerMode? nameConflict = default(ImportConflictHandlerMode?), bool? skipReport = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostImportInGroupWithHttpMessagesAsync(groupId, datasetDisplayName, importInfo, nameConflict, skipReport, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified import from the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='importId'>
            /// The import id
            /// </param>
            public static Import GetImportInGroup(this IImportsOperations operations, System.Guid groupId, System.Guid importId)
            {
                return operations.GetImportInGroupAsync(groupId, importId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified import from the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or Dataset.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='importId'>
            /// The import id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Import> GetImportInGroupAsync(this IImportsOperations operations, System.Guid groupId, System.Guid importId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportInGroupWithHttpMessagesAsync(groupId, importId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a temporary blob storage to be used to import large .pbix files
            /// larger than 1 GB and up to 10 GB.
            /// </summary>
            /// <remarks>
            /// To import large .pbix files, create a temporary upload location and upload
            /// the .pbix file using the shared access signature (SAS) url from the
            /// response, and then call [Post Import In
            /// Group](/rest/api/power-bi/imports/postimportingroup) and specify 'fileUrl'
            /// to be the SAS url in the [Request
            /// Body](/rest/api/power-bi/imports/postimportingroup#request-body).&lt;br/&gt;&lt;br/&gt;**Note**:
            /// Import large .pbix files is only available for workspaces on premium
            /// capacity and for .pbix files that is between 1 GB and 10 GB.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Dataset.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            public static TemporaryUploadLocation CreateTemporaryUploadLocationInGroup(this IImportsOperations operations, System.Guid groupId)
            {
                return operations.CreateTemporaryUploadLocationInGroupAsync(groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a temporary blob storage to be used to import large .pbix files
            /// larger than 1 GB and up to 10 GB.
            /// </summary>
            /// <remarks>
            /// To import large .pbix files, create a temporary upload location and upload
            /// the .pbix file using the shared access signature (SAS) url from the
            /// response, and then call [Post Import In
            /// Group](/rest/api/power-bi/imports/postimportingroup) and specify 'fileUrl'
            /// to be the SAS url in the [Request
            /// Body](/rest/api/power-bi/imports/postimportingroup#request-body).&lt;br/&gt;&lt;br/&gt;**Note**:
            /// Import large .pbix files is only available for workspaces on premium
            /// capacity and for .pbix files that is between 1 GB and 10 GB.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Dataset.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TemporaryUploadLocation> CreateTemporaryUploadLocationInGroupAsync(this IImportsOperations operations, System.Guid groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateTemporaryUploadLocationInGroupWithHttpMessagesAsync(groupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of imports for the organization.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see [Register
            /// an app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline
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
            public static Imports GetImportsAsAdmin(this IImportsOperations operations, string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?))
            {
                return operations.GetImportsAsAdminAsync(expand, filter, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of imports for the organization.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see [Register
            /// an app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Imports> GetImportsAsAdminAsync(this IImportsOperations operations, string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportsAsAdminWithHttpMessagesAsync(expand, filter, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
