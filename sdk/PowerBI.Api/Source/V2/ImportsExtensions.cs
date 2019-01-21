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
    /// Extension methods for Imports.
    /// </summary>
    public static partial class ImportsExtensions
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
            public static ODataResponseListImport GetImports(this IImports operations)
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
            public static async Task<ODataResponseListImport> GetImportsAsync(this IImports operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates new content on **"My Workspace"** from .pbix, Excel or file path in
            /// OneDrive for Business.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All &lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// &lt;h3&gt;Notes&lt;/h3&gt;&lt;ul&gt;&lt;li&gt;To import a file, request
            /// Headers should include **Content-Type: multipart/form-data** with the file
            /// [encoded as form data](https://www.w3.org/TR/html401/interact/forms.html)
            /// in the request body. &lt;/li&gt;&lt;li&gt;To import from OneDrive for
            /// Business, request Headers should include **Content-Type: application/json**
            /// with [ImportInfo](/rest/api/power-bi/imports/postimport#importinfo) in the
            /// request body.&lt;/li&gt;&lt;li&gt;To import large .pbix files between 1 GB
            /// and 10 GB, see [Create Temporary Upload
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
            /// Default value is 'Ignore'. Possible values include: 'Ignore', 'Abort',
            /// 'Overwrite', 'CreateOrOverwrite'
            /// </param>
            public static Import PostImport(this IImports operations, string datasetDisplayName, ImportInfo importInfo, string nameConflict = default(string))
            {
                return operations.PostImportAsync(datasetDisplayName, importInfo, nameConflict).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates new content on **"My Workspace"** from .pbix, Excel or file path in
            /// OneDrive for Business.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All &lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// &lt;h3&gt;Notes&lt;/h3&gt;&lt;ul&gt;&lt;li&gt;To import a file, request
            /// Headers should include **Content-Type: multipart/form-data** with the file
            /// [encoded as form data](https://www.w3.org/TR/html401/interact/forms.html)
            /// in the request body. &lt;/li&gt;&lt;li&gt;To import from OneDrive for
            /// Business, request Headers should include **Content-Type: application/json**
            /// with [ImportInfo](/rest/api/power-bi/imports/postimport#importinfo) in the
            /// request body.&lt;/li&gt;&lt;li&gt;To import large .pbix files between 1 GB
            /// and 10 GB, see [Create Temporary Upload
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
            /// Default value is 'Ignore'. Possible values include: 'Ignore', 'Abort',
            /// 'Overwrite', 'CreateOrOverwrite'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Import> PostImportAsync(this IImports operations, string datasetDisplayName, ImportInfo importInfo, string nameConflict = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostImportWithHttpMessagesAsync(datasetDisplayName, importInfo, nameConflict, null, cancellationToken).ConfigureAwait(false))
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
            public static Import GetImportById(this IImports operations, string importId)
            {
                return operations.GetImportByIdAsync(importId).GetAwaiter().GetResult();
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
            public static async Task<Import> GetImportByIdAsync(this IImports operations, string importId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportByIdWithHttpMessagesAsync(importId, null, cancellationToken).ConfigureAwait(false))
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
            public static TemporaryUploadLocation CreateTemporaryUploadLocation(this IImports operations)
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
            public static async Task<TemporaryUploadLocation> CreateTemporaryUploadLocationAsync(this IImports operations, CancellationToken cancellationToken = default(CancellationToken))
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
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            public static ODataResponseListImport GetImportsInGroup(this IImports operations, string groupId)
            {
                return operations.GetImportsInGroupAsync(groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of imports from the specified workspace.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListImport> GetImportsInGroupAsync(this IImports operations, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportsInGroupWithHttpMessagesAsync(groupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates new content on the specified workspace from .pbix, .json, Excel, or
            /// file path in OneDrive for Business.
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
            /// supported only for workspaces on premium capacity.&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetDisplayName'>
            /// The display name of the dataset should include file extension. Not
            /// supported when importing from OneDrive for Business.
            /// </param>
            /// <param name='importInfo'>
            /// The import to post
            /// </param>
            /// <param name='nameConflict'>
            /// Determines what to do if a dataset with the same name already exists.
            /// Default value is 'Ignore'. Possible values include: 'Ignore', 'Abort',
            /// 'Overwrite', 'CreateOrOverwrite'
            /// </param>
            public static Import PostImportInGroup(this IImports operations, string groupId, string datasetDisplayName, ImportInfo importInfo, string nameConflict = default(string))
            {
                return operations.PostImportInGroupAsync(groupId, datasetDisplayName, importInfo, nameConflict).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates new content on the specified workspace from .pbix, .json, Excel, or
            /// file path in OneDrive for Business.
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
            /// supported only for workspaces on premium capacity.&lt;/li&gt;&lt;/ul&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='datasetDisplayName'>
            /// The display name of the dataset should include file extension. Not
            /// supported when importing from OneDrive for Business.
            /// </param>
            /// <param name='importInfo'>
            /// The import to post
            /// </param>
            /// <param name='nameConflict'>
            /// Determines what to do if a dataset with the same name already exists.
            /// Default value is 'Ignore'. Possible values include: 'Ignore', 'Abort',
            /// 'Overwrite', 'CreateOrOverwrite'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Import> PostImportInGroupAsync(this IImports operations, string groupId, string datasetDisplayName, ImportInfo importInfo, string nameConflict = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostImportInGroupWithHttpMessagesAsync(groupId, datasetDisplayName, importInfo, nameConflict, null, cancellationToken).ConfigureAwait(false))
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
            public static Import GetImportByIdInGroup(this IImports operations, string groupId, string importId)
            {
                return operations.GetImportByIdInGroupAsync(groupId, importId).GetAwaiter().GetResult();
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
            public static async Task<Import> GetImportByIdInGroupAsync(this IImports operations, string groupId, string importId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportByIdInGroupWithHttpMessagesAsync(groupId, importId, null, cancellationToken).ConfigureAwait(false))
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
            public static TemporaryUploadLocation CreateTemporaryUploadLocationInGroup(this IImports operations, string groupId)
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
            public static async Task<TemporaryUploadLocation> CreateTemporaryUploadLocationInGroupAsync(this IImports operations, string groupId, CancellationToken cancellationToken = default(CancellationToken))
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
            public static ODataResponseListImport GetImportsAsAdmin(this IImports operations, string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?))
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
            public static async Task<ODataResponseListImport> GetImportsAsAdminAsync(this IImports operations, string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportsAsAdminWithHttpMessagesAsync(expand, filter, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
