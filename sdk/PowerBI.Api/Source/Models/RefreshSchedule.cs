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
    /// A Power BI refresh schedule for cached model
    /// </summary>
    public partial class RefreshSchedule
    {
        /// <summary>
        /// Initializes a new instance of the RefreshSchedule class.
        /// </summary>
        public RefreshSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RefreshSchedule class.
        /// </summary>
        /// <param name="days">Days to execute the refresh</param>
        /// <param name="times">Times to execute the refresh within each
        /// day</param>
        /// <param name="enabled">Is the refresh enabled</param>
        /// <param name="localTimeZoneId">The ID of the time zone to use. See
        /// [Time Zone
        /// Info](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id)</param>
        /// <param name="notifyOption">Notification option at scheduled refresh
        /// termination. Possible values include: 'NoNotification',
        /// 'MailOnFailure'</param>
        public RefreshSchedule(IList<Days?> days = default(IList<Days?>), IList<string> times = default(IList<string>), bool? enabled = default(bool?), string localTimeZoneId = default(string), ScheduleNotifyOption? notifyOption = default(ScheduleNotifyOption?))
        {
            Days = days;
            Times = times;
            Enabled = enabled;
            LocalTimeZoneId = localTimeZoneId;
            NotifyOption = notifyOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets days to execute the refresh
        /// </summary>
        [JsonProperty(PropertyName = "days")]
        public IList<Days?> Days { get; set; }

        /// <summary>
        /// Gets or sets times to execute the refresh within each day
        /// </summary>
        [JsonProperty(PropertyName = "times")]
        public IList<string> Times { get; set; }

        /// <summary>
        /// Gets or sets is the refresh enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the ID of the time zone to use. See [Time Zone
        /// Info](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id)
        /// </summary>
        [JsonProperty(PropertyName = "localTimeZoneId")]
        public string LocalTimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets notification option at scheduled refresh termination.
        /// Possible values include: 'NoNotification', 'MailOnFailure'
        /// </summary>
        [JsonProperty(PropertyName = "NotifyOption")]
        public ScheduleNotifyOption? NotifyOption { get; set; }

    }
}
