// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for EncryptedConnection.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(EncryptedConnectionConverter))]
    public struct EncryptedConnection : System.IEquatable<EncryptedConnection>
    {
        private EncryptedConnection(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly EncryptedConnection Encrypted = "Encrypted";

        public static readonly EncryptedConnection NotEncrypted = "NotEncrypted";


        /// <summary>
        /// Underlying value of enum EncryptedConnection
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for EncryptedConnection
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type EncryptedConnection
        /// </summary>
        public bool Equals(EncryptedConnection e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to EncryptedConnection
        /// </summary>
        public static implicit operator EncryptedConnection(string value)
        {
            return new EncryptedConnection(value);
        }

        /// <summary>
        /// Implicit operator to convert EncryptedConnection to string
        /// </summary>
        public static implicit operator string(EncryptedConnection e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum EncryptedConnection
        /// </summary>
        public static bool operator == (EncryptedConnection e1, EncryptedConnection e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum EncryptedConnection
        /// </summary>
        public static bool operator != (EncryptedConnection e1, EncryptedConnection e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for EncryptedConnection
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is EncryptedConnection && Equals((EncryptedConnection)obj);
        }

        /// <summary>
        /// Returns for hashCode EncryptedConnection
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
