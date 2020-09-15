// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for FileFormat.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileFormat
    {
        /// <summary>
        /// Requested file format is PPTX
        /// </summary>
        [EnumMember(Value = "PPTX")]
        PPTX,
        /// <summary>
        /// Requested file format is PDF
        /// </summary>
        [EnumMember(Value = "PDF")]
        PDF,
        /// <summary>
        /// Requested file format is PNG (only supported for Power BI reports)
        /// </summary>
        [EnumMember(Value = "PNG")]
        PNG,
        /// <summary>
        /// Requested file format is
        /// [IMAGE](https://docs.microsoft.com/sql/reporting-services/image-device-information-settings)
        /// (only supported for paginated reports)
        /// </summary>
        [EnumMember(Value = "IMAGE")]
        IMAGE,
        /// <summary>
        /// Requested file format is XLSX (only supported for paginated
        /// reports)
        /// </summary>
        [EnumMember(Value = "XLSX")]
        XLSX,
        /// <summary>
        /// Requested file format is DOCX (only supported for paginated
        /// reports)
        /// </summary>
        [EnumMember(Value = "DOCX")]
        DOCX,
        /// <summary>
        /// Requested file format is CSV (only supported for paginated reports)
        /// </summary>
        [EnumMember(Value = "CSV")]
        CSV,
        /// <summary>
        /// Requested file format is XML (only supported for paginated reports)
        /// </summary>
        [EnumMember(Value = "XML")]
        XML,
        /// <summary>
        /// Requested file format is MHTML (only supported for paginated
        /// reports)
        /// </summary>
        [EnumMember(Value = "MHTML")]
        MHTML,
        /// <summary>
        /// Requested file format is Accessible PDF (only supported for paginated reports)
        /// </summary>
        [EnumMember(Value = "ACCESSIBLEPDF")]
        ACCESSIBLEPDF
    }
    internal static class FileFormatEnumExtension
    {
        internal static string ToSerializedValue(this FileFormat? value)
        {
            return value == null ? null : ((FileFormat)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FileFormat value)
        {
            switch (value)
            {
                case FileFormat.PPTX:
                    return "PPTX";
                case FileFormat.PDF:
                    return "PDF";
                case FileFormat.PNG:
                    return "PNG";
                case FileFormat.IMAGE:
                    return "IMAGE";
                case FileFormat.XLSX:
                    return "XLSX";
                case FileFormat.DOCX:
                    return "DOCX";
                case FileFormat.CSV:
                    return "CSV";
                case FileFormat.XML:
                    return "XML";
                case FileFormat.MHTML:
                    return "MHTML";
                case FileFormat.ACCESSIBLEPDF:
                    return "ACCESSIBLEPDF";
            }
            return null;
        }

        internal static FileFormat? ParseFileFormat(this string value)
        {
            switch (value)
            {
                case "PPTX":
                    return FileFormat.PPTX;
                case "PDF":
                    return FileFormat.PDF;
                case "PNG":
                    return FileFormat.PNG;
                case "IMAGE":
                    return FileFormat.IMAGE;
                case "XLSX":
                    return FileFormat.XLSX;
                case "DOCX":
                    return FileFormat.DOCX;
                case "CSV":
                    return FileFormat.CSV;
                case "XML":
                    return FileFormat.XML;
                case "MHTML":
                    return FileFormat.MHTML;
                case "ACCESSIBLEPDF":
                    return FileFormat.ACCESSIBLEPDF;
            }
            return null;
        }
    }
}
