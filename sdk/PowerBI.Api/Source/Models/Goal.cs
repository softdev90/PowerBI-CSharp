// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Power BI goal
    /// </summary>
    public partial class Goal
    {
        /// <summary>
        /// Initializes a new instance of the Goal class.
        /// </summary>
        public Goal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Goal class.
        /// </summary>
        /// <param name="id">The goal ID</param>
        /// <param name="name">The goal name</param>
        /// <param name="scorecardId">The scorecard ID</param>
        /// <param name="createdTime">The UTC time at creation</param>
        /// <param name="lastModifiedTime">The UTC time at last
        /// modification</param>
        /// <param name="startDate">The UTC timestamp for the start date of the
        /// goal. The time portion of the timestamp is zero.</param>
        /// <param name="completionDate">The UTC timestamp for the completion
        /// date of the goal. The time portion of the timestamp is
        /// zero.</param>
        /// <param name="parentId">The ID of the parent goal, if
        /// defined.</param>
        /// <param name="notesCount">notesCount</param>
        /// <param name="valuesFormatString">valuesFormatString</param>
        /// <param name="datesFormatString">datesFormatString</param>
        /// <param name="description">The goal description</param>
        /// <param name="hasStatusRules">Whether the goal has status rules
        /// defined</param>
        /// <param name="statusRules">The goal status rules</param>
        /// <param name="permissions">The goal permissions. Possible values
        /// include: 'None', 'View', 'UpdateCurrentValue', 'UpdateTargetValue',
        /// 'UpdateNotes', 'UpdateStatus', 'UpdateValues', 'All',
        /// 'UpdateCurrentValueAndNotes', 'UpdateTargetValueAndNotes',
        /// 'UpdateCurrentValueAndTargetValueAndNotes',
        /// 'UpdateCurrentValueAndStatus', 'UpdateTargetValueAndStatus',
        /// 'UpdateCurrentValueAndTargetValueAndStatus',
        /// 'UpdateNotesAndStatus', 'UpdateCurrentValueAndNotesAndStatus',
        /// 'UpdateTargetValueAndNotesAndStatus'</param>
        /// <param name="level">The nested level of the goal in the
        /// parent-child hierarchy of scorecard goals</param>
        /// <param name="rank">The rank of the goal within the ordered set of
        /// sibling goals</param>
        /// <param name="goalValues">The list of goal value check-ins</param>
        /// <param name="aggregations">The list of aggregated properties of the
        /// goal</param>
        public Goal(System.Guid? id = default(System.Guid?), string name = default(string), System.Guid? scorecardId = default(System.Guid?), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), System.DateTime? startDate = default(System.DateTime?), System.DateTime? completionDate = default(System.DateTime?), System.Guid? parentId = default(System.Guid?), int? notesCount = default(int?), string valuesFormatString = default(string), string datesFormatString = default(string), string description = default(string), bool? hasStatusRules = default(bool?), GoalsRulesGoalRulesContainer statusRules = default(GoalsRulesGoalRulesContainer), GoalPermissions? permissions = default(GoalPermissions?), int? level = default(int?), long? rank = default(long?), IList<GoalValue> goalValues = default(IList<GoalValue>), IList<GoalAggregation> aggregations = default(IList<GoalAggregation>))
        {
            Id = id;
            Name = name;
            ScorecardId = scorecardId;
            CreatedTime = createdTime;
            LastModifiedTime = lastModifiedTime;
            StartDate = startDate;
            CompletionDate = completionDate;
            ParentId = parentId;
            NotesCount = notesCount;
            ValuesFormatString = valuesFormatString;
            DatesFormatString = datesFormatString;
            Description = description;
            HasStatusRules = hasStatusRules;
            StatusRules = statusRules;
            Permissions = permissions;
            Level = level;
            Rank = rank;
            GoalValues = goalValues;
            Aggregations = aggregations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the goal ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets the goal name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the scorecard ID
        /// </summary>
        [JsonProperty(PropertyName = "scorecardId")]
        public System.Guid? ScorecardId { get; set; }

        /// <summary>
        /// Gets or sets the UTC time at creation
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the UTC time at last modification
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the UTC timestamp for the start date of the goal. The
        /// time portion of the timestamp is zero.
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the UTC timestamp for the completion date of the goal.
        /// The time portion of the timestamp is zero.
        /// </summary>
        [JsonProperty(PropertyName = "completionDate")]
        public System.DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Gets or sets the ID of the parent goal, if defined.
        /// </summary>
        [JsonProperty(PropertyName = "parentId")]
        public System.Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or sets notesCount
        /// </summary>
        [JsonProperty(PropertyName = "notesCount")]
        public int? NotesCount { get; set; }

        /// <summary>
        /// Gets or sets valuesFormatString
        /// </summary>
        [JsonProperty(PropertyName = "valuesFormatString")]
        public string ValuesFormatString { get; set; }

        /// <summary>
        /// Gets or sets datesFormatString
        /// </summary>
        [JsonProperty(PropertyName = "datesFormatString")]
        public string DatesFormatString { get; set; }

        /// <summary>
        /// Gets or sets the goal description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether the goal has status rules defined
        /// </summary>
        [JsonProperty(PropertyName = "hasStatusRules")]
        public bool? HasStatusRules { get; set; }

        /// <summary>
        /// Gets or sets the goal status rules
        /// </summary>
        [JsonProperty(PropertyName = "statusRules")]
        public GoalsRulesGoalRulesContainer StatusRules { get; set; }

        /// <summary>
        /// Gets or sets the goal permissions. Possible values include: 'None',
        /// 'View', 'UpdateCurrentValue', 'UpdateTargetValue', 'UpdateNotes',
        /// 'UpdateStatus', 'UpdateValues', 'All',
        /// 'UpdateCurrentValueAndNotes', 'UpdateTargetValueAndNotes',
        /// 'UpdateCurrentValueAndTargetValueAndNotes',
        /// 'UpdateCurrentValueAndStatus', 'UpdateTargetValueAndStatus',
        /// 'UpdateCurrentValueAndTargetValueAndStatus',
        /// 'UpdateNotesAndStatus', 'UpdateCurrentValueAndNotesAndStatus',
        /// 'UpdateTargetValueAndNotesAndStatus'
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public GoalPermissions? Permissions { get; set; }

        /// <summary>
        /// Gets or sets the nested level of the goal in the parent-child
        /// hierarchy of scorecard goals
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public int? Level { get; set; }

        /// <summary>
        /// Gets or sets the rank of the goal within the ordered set of sibling
        /// goals
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public long? Rank { get; set; }

        /// <summary>
        /// Gets or sets the list of goal value check-ins
        /// </summary>
        [JsonProperty(PropertyName = "goalValues")]
        public IList<GoalValue> GoalValues { get; set; }

        /// <summary>
        /// Gets or sets the list of aggregated properties of the goal
        /// </summary>
        [JsonProperty(PropertyName = "aggregations")]
        public IList<GoalAggregation> Aggregations { get; set; }

    }
}
