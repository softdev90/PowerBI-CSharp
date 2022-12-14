// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GoalValuesOperations.
    /// </summary>
    public static partial class GoalValuesOperationsExtensions
    {
            /// <summary>
            /// Reads goal value check-ins.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `notes`.
            /// </param>
            public static GoalValues Get(this IGoalValuesOperations operations, string expand = default(string))
            {
                return operations.GetAsync(expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reads goal value check-ins.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `notes`.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GoalValues> GetAsync(this IGoalValuesOperations operations, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new goal value check-in.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='goalValue'>
            /// Goal value content.
            /// </param>
            public static GoalValue Post(this IGoalValuesOperations operations, GoalValueCreateRequest goalValue)
            {
                return operations.PostAsync(goalValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new goal value check-in.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='goalValue'>
            /// Goal value content.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GoalValue> PostAsync(this IGoalValuesOperations operations, GoalValueCreateRequest goalValue, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(goalValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Reads a goal value check-in by a UTC date timestamp.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `notes`.
            /// </param>
            public static GoalValue GetByID(this IGoalValuesOperations operations, string expand = default(string))
            {
                return operations.GetByIDAsync(expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reads a goal value check-in by a UTC date timestamp.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `notes`.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GoalValue> GetByIDAsync(this IGoalValuesOperations operations, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIDWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a goal value check-in by a UTC date timestamp.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='goalValue'>
            /// The updated content of goal value check-in.
            /// </param>
            public static GoalValue PatchByID(this IGoalValuesOperations operations, GoalValue goalValue)
            {
                return operations.PatchByIDAsync(goalValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a goal value check-in by a UTC date timestamp.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='goalValue'>
            /// The updated content of goal value check-in.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GoalValue> PatchByIDAsync(this IGoalValuesOperations operations, GoalValue goalValue, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchByIDWithHttpMessagesAsync(goalValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a goal value check-in by a UTC day timestamp.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void DeleteByID(this IGoalValuesOperations operations)
            {
                operations.DeleteByIDAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a goal value check-in by a UTC day timestamp.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIDAsync(this IGoalValuesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIDWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
