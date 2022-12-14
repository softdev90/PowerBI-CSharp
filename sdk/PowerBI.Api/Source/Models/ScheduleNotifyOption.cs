// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for ScheduleNotifyOption.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ScheduleNotifyOptionConverter))]
    public struct ScheduleNotifyOption : System.IEquatable<ScheduleNotifyOption>
    {
        private ScheduleNotifyOption(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// No notification will be sent
        /// </summary>
        public static readonly ScheduleNotifyOption NoNotification = "NoNotification";

        /// <summary>
        /// A mail notification will be sent on refresh failure
        /// </summary>
        public static readonly ScheduleNotifyOption MailOnFailure = "MailOnFailure";


        /// <summary>
        /// Underlying value of enum ScheduleNotifyOption
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ScheduleNotifyOption
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ScheduleNotifyOption
        /// </summary>
        public bool Equals(ScheduleNotifyOption e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ScheduleNotifyOption
        /// </summary>
        public static implicit operator ScheduleNotifyOption(string value)
        {
            return new ScheduleNotifyOption(value);
        }

        /// <summary>
        /// Implicit operator to convert ScheduleNotifyOption to string
        /// </summary>
        public static implicit operator string(ScheduleNotifyOption e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ScheduleNotifyOption
        /// </summary>
        public static bool operator == (ScheduleNotifyOption e1, ScheduleNotifyOption e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ScheduleNotifyOption
        /// </summary>
        public static bool operator != (ScheduleNotifyOption e1, ScheduleNotifyOption e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ScheduleNotifyOption
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ScheduleNotifyOption && Equals((ScheduleNotifyOption)obj);
        }

        /// <summary>
        /// Returns for hashCode ScheduleNotifyOption
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
