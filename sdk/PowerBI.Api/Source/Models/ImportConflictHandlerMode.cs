// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for ImportConflictHandlerMode.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ImportConflictHandlerModeConverter))]
    public struct ImportConflictHandlerMode : System.IEquatable<ImportConflictHandlerMode>
    {
        private ImportConflictHandlerMode(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// If a dataset with the same name already exists, the import
        /// operation will create a new dataset with the same name.
        /// </summary>
        public static readonly ImportConflictHandlerMode Ignore = "Ignore";

        /// <summary>
        /// If a dataset with the same name already exists, the import
        /// operation will be cancelled.
        /// </summary>
        public static readonly ImportConflictHandlerMode Abort = "Abort";

        /// <summary>
        /// If a dataset with the same name already exists, the import
        /// operation will replace the existing dataset with the new one. The
        /// import operation will fail if there's no conflict or if there's
        /// more than one existing dataset with the same name.
        /// </summary>
        public static readonly ImportConflictHandlerMode Overwrite = "Overwrite";

        /// <summary>
        /// If a dataset with the same name already exists, the import
        /// operation will replace the existing dataset with the new one. The
        /// import operation will fail if there's more than one existing
        /// dataset with the same name.
        /// </summary>
        public static readonly ImportConflictHandlerMode CreateOrOverwrite = "CreateOrOverwrite";

        /// <summary>
        /// If a dataflow with the same name already exists, the import
        /// operation will generate a new unique name for the new dataflow.
        /// </summary>
        public static readonly ImportConflictHandlerMode GenerateUniqueName = "GenerateUniqueName";


        /// <summary>
        /// Underlying value of enum ImportConflictHandlerMode
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ImportConflictHandlerMode
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ImportConflictHandlerMode
        /// </summary>
        public bool Equals(ImportConflictHandlerMode e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ImportConflictHandlerMode
        /// </summary>
        public static implicit operator ImportConflictHandlerMode(string value)
        {
            return new ImportConflictHandlerMode(value);
        }

        /// <summary>
        /// Implicit operator to convert ImportConflictHandlerMode to string
        /// </summary>
        public static implicit operator string(ImportConflictHandlerMode e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ImportConflictHandlerMode
        /// </summary>
        public static bool operator == (ImportConflictHandlerMode e1, ImportConflictHandlerMode e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ImportConflictHandlerMode
        /// </summary>
        public static bool operator != (ImportConflictHandlerMode e1, ImportConflictHandlerMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ImportConflictHandlerMode
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ImportConflictHandlerMode && Equals((ImportConflictHandlerMode)obj);
        }

        /// <summary>
        /// Returns for hashCode ImportConflictHandlerMode
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
