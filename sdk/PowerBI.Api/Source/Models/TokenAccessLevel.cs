// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for TokenAccessLevel.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(TokenAccessLevelConverter))]
    public struct TokenAccessLevel : System.IEquatable<TokenAccessLevel>
    {
        private TokenAccessLevel(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Indicates that the generated embed token grants view-only
        /// permission
        /// </summary>
        public static readonly TokenAccessLevel View = "View";

        /// <summary>
        /// Indicates that the generated embed token grants view and edit
        /// permissions. Only applies when you generate an embed token for
        /// report embedding.
        /// </summary>
        public static readonly TokenAccessLevel Edit = "Edit";

        /// <summary>
        /// Indicates that the generated embed token grants create permission.
        /// Only applies when you generate an embed token for report creation.
        /// </summary>
        public static readonly TokenAccessLevel Create = "Create";


        /// <summary>
        /// Underlying value of enum TokenAccessLevel
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for TokenAccessLevel
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type TokenAccessLevel
        /// </summary>
        public bool Equals(TokenAccessLevel e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to TokenAccessLevel
        /// </summary>
        public static implicit operator TokenAccessLevel(string value)
        {
            return new TokenAccessLevel(value);
        }

        /// <summary>
        /// Implicit operator to convert TokenAccessLevel to string
        /// </summary>
        public static implicit operator string(TokenAccessLevel e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum TokenAccessLevel
        /// </summary>
        public static bool operator == (TokenAccessLevel e1, TokenAccessLevel e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum TokenAccessLevel
        /// </summary>
        public static bool operator != (TokenAccessLevel e1, TokenAccessLevel e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for TokenAccessLevel
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is TokenAccessLevel && Equals((TokenAccessLevel)obj);
        }

        /// <summary>
        /// Returns for hashCode TokenAccessLevel
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
