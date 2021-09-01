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
    /// InformationProtection operations.
    /// </summary>
    public partial interface IInformationProtection
    {
        /// <summary>
        /// Remove sensitivity labels from artifacts by artifact ID.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt; The admin user must have sufficient [usage
        /// rights](https://go.microsoft.com/fwlink/?linkid=2157685) to delete
        /// labels.&lt;br/&gt;This API allows a maximum of 25 requests per
        /// hour. Each request can update up to 2000 artifacts.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.ReadWrite.All
        /// &lt;br/&gt;&lt;br/&gt;**Usage sample**: [Set or remove sensitivity
        /// labels using Power BI REST admin
        /// APIs](https://docs.microsoft.com/power-bi/admin/service-security-sensitivity-label-inheritance-set-remove-api)
        /// </remarks>
        /// <param name='artifacts'>
        /// A composite of artifact ID lists for each type
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
        Task<HttpOperationResponse<InformationProtectionChangeLabelResponse>> RemoveLabelsAsAdminWithHttpMessagesAsync(InformationProtectionArtifactsChangeLabel artifacts, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Set sensitivity labels on content in Power BI by artifact ID.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt; To set a sensitivity label using this API,
        /// the admin user (or the delegated user, if provided) must have the
        /// label included in their [label
        /// policy](https://docs.microsoft.com/en-us/microsoft-365/compliance/create-sensitivity-labels?view=o365-worldwide).
        /// &lt;br/&gt; The admin user (and the delegated user, if provided)
        /// must have sufficient [usage
        /// rights](https://go.microsoft.com/fwlink/?linkid=2157685) to set
        /// labels.&lt;br/&gt;This API allows a maximum of 25 requests per
        /// hour. Each request can update up to 2000 artifacts.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.ReadWrite.All
        /// &lt;br/&gt;&lt;br/&gt;**Usage sample**: [Set or remove sensitivity
        /// labels using Power BI REST admin
        /// APIs](https://docs.microsoft.com/power-bi/admin/service-security-sensitivity-label-inheritance-set-remove-api)
        /// </remarks>
        /// <param name='informationProtectionChangeLabelDetails'>
        /// Set label details.
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
        Task<HttpOperationResponse<InformationProtectionChangeLabelResponse>> SetLabelsAsAdminWithHttpMessagesAsync(InformationProtectionChangeLabelDetails informationProtectionChangeLabelDetails, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
