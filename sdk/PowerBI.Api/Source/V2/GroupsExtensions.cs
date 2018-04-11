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
    /// Extension methods for Groups.
    /// </summary>
    public static partial class GroupsExtensions
    {
            /// <summary>
            /// Returns a list of groups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            public static ODataResponseListGroup GetGroups(this IGroups operations, string filter = default(string), int? top = default(int?), int? skip = default(int?))
            {
                return operations.GetGroupsAsync(filter, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of groups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGroup> GetGroupsAsync(this IGroups operations, string filter = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupsWithHttpMessagesAsync(filter, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Create group request parameters
            /// </param>
            public static Group CreateGroup(this IGroups operations, GroupCreationRequest requestParameters)
            {
                return operations.CreateGroupAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create new group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Create group request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Group> CreateGroupAsync(this IGroups operations, GroupCreationRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateGroupWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id to delete
            /// </param>
            public static object DeleteGroup(this IGroups operations, string groupId)
            {
                return operations.DeleteGroupAsync(groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteGroupAsync(this IGroups operations, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteGroupWithHttpMessagesAsync(groupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a group users list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            public static ODataResponseListGroupUserAccessRight GetGroupUsers(this IGroups operations, string groupId)
            {
                return operations.GetGroupUsersAsync(groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a group users list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGroupUserAccessRight> GetGroupUsersAsync(this IGroups operations, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupUsersWithHttpMessagesAsync(groupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add a group user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='userDetails'>
            /// user access right details
            /// </param>
            public static object AddGroupUser(this IGroups operations, string groupId, GroupUserAccessRight userDetails)
            {
                return operations.AddGroupUserAsync(groupId, userDetails).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add a group user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='userDetails'>
            /// user access right details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AddGroupUserAsync(this IGroups operations, string groupId, GroupUserAccessRight userDetails, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddGroupUserWithHttpMessagesAsync(groupId, userDetails, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='user'>
            /// The user email to delete
            /// </param>
            public static object DeleteUserInGroup(this IGroups operations, string groupId, string user)
            {
                return operations.DeleteUserInGroupAsync(groupId, user).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='user'>
            /// The user email to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteUserInGroupAsync(this IGroups operations, string groupId, string user, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteUserInGroupWithHttpMessagesAsync(groupId, user, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Assign a group to a capacity
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='requestParameters'>
            /// Assign to capacity parameters
            /// </param>
            public static object AssignToCapacity(this IGroups operations, string groupId, AssignToCapacityRequest requestParameters)
            {
                return operations.AssignToCapacityAsync(groupId, requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Assign a group to a capacity
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='requestParameters'>
            /// Assign to capacity parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AssignToCapacityAsync(this IGroups operations, string groupId, AssignToCapacityRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AssignToCapacityWithHttpMessagesAsync(groupId, requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Assign My Workspace to a capacity
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Assign to capacity parameters
            /// </param>
            public static object AssignMyWorkspaceToCapacity(this IGroups operations, AssignToCapacityRequest requestParameters)
            {
                return operations.AssignMyWorkspaceToCapacityAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Assign My Workspace to a capacity
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Assign to capacity parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AssignMyWorkspaceToCapacityAsync(this IGroups operations, AssignToCapacityRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AssignMyWorkspaceToCapacityWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// With an adminstrative scope, returns a list of groups for an organization
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            public static ODataResponseListGroup GetGroupsAsAdmin(this IGroups operations, string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?))
            {
                return operations.GetGroupsAsAdminAsync(expand, filter, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// With an adminstrative scope, returns a list of groups for an organization
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGroup> GetGroupsAsAdminAsync(this IGroups operations, string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupsAsAdminWithHttpMessagesAsync(expand, filter, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// With administrative scope, updates the specified group properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='groupProperties'>
            /// The properties to update
            /// </param>
            public static object UpdateGroupAsAdmin(this IGroups operations, string groupId, Group groupProperties)
            {
                return operations.UpdateGroupAsAdminAsync(groupId, groupProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// With administrative scope, updates the specified group properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='groupProperties'>
            /// The properties to update
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpdateGroupAsAdminAsync(this IGroups operations, string groupId, Group groupProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateGroupAsAdminWithHttpMessagesAsync(groupId, groupProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// With an administrative scope, grant user permissions to the given group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='userDetails'>
            /// User access right details
            /// </param>
            public static object AddUserAsAdmin(this IGroups operations, string groupId, GroupUserAccessRight userDetails)
            {
                return operations.AddUserAsAdminAsync(groupId, userDetails).GetAwaiter().GetResult();
            }

            /// <summary>
            /// With an administrative scope, grant user permissions to the given group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='userDetails'>
            /// User access right details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AddUserAsAdminAsync(this IGroups operations, string groupId, GroupUserAccessRight userDetails, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddUserAsAdminWithHttpMessagesAsync(groupId, userDetails, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// With an administrative scope, remove user permissions to the given group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='user'>
            /// The user principal name (UPN) of the user to remove (usually the user's
            /// email)
            /// </param>
            public static object DeleteUserAsAdmin(this IGroups operations, string groupId, string user)
            {
                return operations.DeleteUserAsAdminAsync(groupId, user).GetAwaiter().GetResult();
            }

            /// <summary>
            /// With an administrative scope, remove user permissions to the given group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='user'>
            /// The user principal name (UPN) of the user to remove (usually the user's
            /// email)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteUserAsAdminAsync(this IGroups operations, string groupId, string user, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteUserAsAdminWithHttpMessagesAsync(groupId, user, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// With an administrative scope, restore a deleted group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='groupRestoreRequest'>
            /// Group restore request details
            /// </param>
            public static object RestoreDeletedGroupAsAdmin(this IGroups operations, string groupId, GroupRestoreRequest groupRestoreRequest)
            {
                return operations.RestoreDeletedGroupAsAdminAsync(groupId, groupRestoreRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// With an administrative scope, restore a deleted group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The group id
            /// </param>
            /// <param name='groupRestoreRequest'>
            /// Group restore request details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> RestoreDeletedGroupAsAdminAsync(this IGroups operations, string groupId, GroupRestoreRequest groupRestoreRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RestoreDeletedGroupAsAdminWithHttpMessagesAsync(groupId, groupRestoreRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
