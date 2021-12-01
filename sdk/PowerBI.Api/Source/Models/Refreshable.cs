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
    /// A Power BI refreshable
    /// </summary>
    public partial class Refreshable
    {
        /// <summary>
        /// Initializes a new instance of the Refreshable class.
        /// </summary>
        public Refreshable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Refreshable class.
        /// </summary>
        /// <param name="id">The object ID of the refreshable</param>
        /// <param name="name">Display name of refreshable</param>
        /// <param name="kind">The refreshable kind. Possible values include:
        /// 'Dataset'</param>
        /// <param name="startTime">The start time of the window for which
        /// summary data exists</param>
        /// <param name="endTime">The end time of the window for which summary
        /// data exists</param>
        /// <param name="refreshCount">The number of refreshes within the
        /// summary time window</param>
        /// <param name="refreshFailures">The number of refresh failures within
        /// the summary time window</param>
        /// <param name="averageDuration">The average duration in seconds of a
        /// refresh within the summary time window</param>
        /// <param name="medianDuration">The median duration in seconds of a
        /// refresh within the summary time window</param>
        /// <param name="refreshesPerDay">The number of refreshes per day
        /// (scheduled and on-demand) within the time window for which refresh
        /// data exists</param>
        /// <param name="lastRefresh">The last Power BI refresh history entry
        /// for the refreshable item</param>
        /// <param name="refreshSchedule">The refresh schedule for the
        /// refreshable item</param>
        /// <param name="configuredBy">Refreshable owners</param>
        /// <param name="capacity">The capacity for the refreshable
        /// item</param>
        /// <param name="group">The associated group for the refreshable
        /// item</param>
        public Refreshable(string id = default(string), string name = default(string), RefreshableKind? kind = default(RefreshableKind?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), int? refreshCount = default(int?), int? refreshFailures = default(int?), double? averageDuration = default(double?), double? medianDuration = default(double?), int? refreshesPerDay = default(int?), Refresh lastRefresh = default(Refresh), RefreshSchedule refreshSchedule = default(RefreshSchedule), IList<string> configuredBy = default(IList<string>), Capacity capacity = default(Capacity), RefreshableGroup group = default(RefreshableGroup))
        {
            Id = id;
            Name = name;
            Kind = kind;
            StartTime = startTime;
            EndTime = endTime;
            RefreshCount = refreshCount;
            RefreshFailures = refreshFailures;
            AverageDuration = averageDuration;
            MedianDuration = medianDuration;
            RefreshesPerDay = refreshesPerDay;
            LastRefresh = lastRefresh;
            RefreshSchedule = refreshSchedule;
            ConfiguredBy = configuredBy;
            Capacity = capacity;
            Group = group;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the object ID of the refreshable
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets display name of refreshable
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the refreshable kind. Possible values include:
        /// 'Dataset'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public RefreshableKind? Kind { get; set; }

        /// <summary>
        /// Gets or sets the start time of the window for which summary data
        /// exists
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the window for which summary data
        /// exists
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the number of refreshes within the summary time window
        /// </summary>
        [JsonProperty(PropertyName = "refreshCount")]
        public int? RefreshCount { get; set; }

        /// <summary>
        /// Gets or sets the number of refresh failures within the summary time
        /// window
        /// </summary>
        [JsonProperty(PropertyName = "refreshFailures")]
        public int? RefreshFailures { get; set; }

        /// <summary>
        /// Gets or sets the average duration in seconds of a refresh within
        /// the summary time window
        /// </summary>
        [JsonProperty(PropertyName = "averageDuration")]
        public double? AverageDuration { get; set; }

        /// <summary>
        /// Gets or sets the median duration in seconds of a refresh within the
        /// summary time window
        /// </summary>
        [JsonProperty(PropertyName = "medianDuration")]
        public double? MedianDuration { get; set; }

        /// <summary>
        /// Gets or sets the number of refreshes per day (scheduled and
        /// on-demand) within the time window for which refresh data exists
        /// </summary>
        [JsonProperty(PropertyName = "refreshesPerDay")]
        public int? RefreshesPerDay { get; set; }

        /// <summary>
        /// Gets or sets the last Power BI refresh history entry for the
        /// refreshable item
        /// </summary>
        [JsonProperty(PropertyName = "lastRefresh")]
        public Refresh LastRefresh { get; set; }

        /// <summary>
        /// Gets or sets the refresh schedule for the refreshable item
        /// </summary>
        [JsonProperty(PropertyName = "refreshSchedule")]
        public RefreshSchedule RefreshSchedule { get; set; }

        /// <summary>
        /// Gets or sets refreshable owners
        /// </summary>
        [JsonProperty(PropertyName = "configuredBy")]
        public IList<string> ConfiguredBy { get; set; }

        /// <summary>
        /// Gets or sets the capacity for the refreshable item
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public Capacity Capacity { get; set; }

        /// <summary>
        /// Gets or sets the associated group for the refreshable item
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public RefreshableGroup Group { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Capacity != null)
            {
                Capacity.Validate();
            }
            if (Group != null)
            {
                Group.Validate();
            }
        }
    }
}
