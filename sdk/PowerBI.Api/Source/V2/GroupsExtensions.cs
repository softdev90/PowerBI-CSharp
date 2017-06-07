// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V2
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
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
            public static ODataResponseListGroup GetGroups(this IGroups operations)
            {
                return operations.GetGroupsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of groups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGroup> GetGroupsAsync(this IGroups operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
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
            public static ODataResponseListGroupUser GetGroupUsers(this IGroups operations, string groupId)
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
            public static async Task<ODataResponseListGroupUser> GetGroupUsersAsync(this IGroups operations, string groupId, CancellationToken cancellationToken = default(CancellationToken))
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
            public static object AddGroupUser(this IGroups operations, string groupId, UserAccessRight userDetails)
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
            public static async Task<object> AddGroupUserAsync(this IGroups operations, string groupId, UserAccessRight userDetails, CancellationToken cancellationToken = default(CancellationToken))
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

    }
}
