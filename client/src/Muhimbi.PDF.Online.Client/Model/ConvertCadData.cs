/*
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * The version of the OpenAPI document: 9.16
 * Contact: support@muhimbi.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Muhimbi.PDF.Online.Client.Client.OpenAPIDateConverter;

namespace Muhimbi.PDF.Online.Client.Model
{
    /// <summary>
    /// Parameters for Convert CAD operation
    /// </summary>
    [DataContract(Name = "convert_cad_data")]
    public partial class ConvertCadData : IEquatable<ConvertCadData>, IValidatableObject
    {
        /// <summary>
        /// Paper size for the output
        /// </summary>
        /// <value>Paper size for the output</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaperSizeEnum
        {
            /// <summary>
            /// Enum A3 for value: A3
            /// </summary>
            [EnumMember(Value = "A3")]
            A3 = 1,

            /// <summary>
            /// Enum A4 for value: A4
            /// </summary>
            [EnumMember(Value = "A4")]
            A4 = 2,

            /// <summary>
            /// Enum A5 for value: A5
            /// </summary>
            [EnumMember(Value = "A5")]
            A5 = 3,

            /// <summary>
            /// Enum Legal for value: Legal
            /// </summary>
            [EnumMember(Value = "Legal")]
            Legal = 4,

            /// <summary>
            /// Enum Letter for value: Letter
            /// </summary>
            [EnumMember(Value = "Letter")]
            Letter = 5,

            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 6

        }


        /// <summary>
        /// Paper size for the output
        /// </summary>
        /// <value>Paper size for the output</value>
        [DataMember(Name = "paper_size", EmitDefaultValue = false)]
        public PaperSizeEnum? PaperSize { get; set; }
        /// <summary>
        /// The foreground effect or color
        /// </summary>
        /// <value>The foreground effect or color</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ForegroundColorEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,

            /// <summary>
            /// Enum CorrectForBackground for value: CorrectForBackground
            /// </summary>
            [EnumMember(Value = "CorrectForBackground")]
            CorrectForBackground = 2,

            /// <summary>
            /// Enum Greyscale for value: Greyscale
            /// </summary>
            [EnumMember(Value = "Greyscale")]
            Greyscale = 3,

            /// <summary>
            /// Enum GreyscaleDarken for value: GreyscaleDarken
            /// </summary>
            [EnumMember(Value = "GreyscaleDarken")]
            GreyscaleDarken = 4,

            /// <summary>
            /// Enum GreyscaleLighten for value: GreyscaleLighten
            /// </summary>
            [EnumMember(Value = "GreyscaleLighten")]
            GreyscaleLighten = 5,

            /// <summary>
            /// Enum Darken for value: Darken
            /// </summary>
            [EnumMember(Value = "Darken")]
            Darken = 6,

            /// <summary>
            /// Enum Lighten for value: Lighten
            /// </summary>
            [EnumMember(Value = "Lighten")]
            Lighten = 7,

            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 8

        }


        /// <summary>
        /// The foreground effect or color
        /// </summary>
        /// <value>The foreground effect or color</value>
        [DataMember(Name = "foreground_color", EmitDefaultValue = false)]
        public ForegroundColorEnum? ForegroundColor { get; set; }
        /// <summary>
        /// Select which layouts should be skipped
        /// </summary>
        /// <value>Select which layouts should be skipped</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmptyLayoutDetectionModeEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,

            /// <summary>
            /// Enum SkipNone for value: SkipNone
            /// </summary>
            [EnumMember(Value = "SkipNone")]
            SkipNone = 2,

            /// <summary>
            /// Enum SkipEmptyLayouts for value: SkipEmptyLayouts
            /// </summary>
            [EnumMember(Value = "SkipEmptyLayouts")]
            SkipEmptyLayouts = 3,

            /// <summary>
            /// Enum SkipLayoutsWithoutViewports for value: SkipLayoutsWithoutViewports
            /// </summary>
            [EnumMember(Value = "SkipLayoutsWithoutViewports")]
            SkipLayoutsWithoutViewports = 4

        }


        /// <summary>
        /// Select which layouts should be skipped
        /// </summary>
        /// <value>Select which layouts should be skipped</value>
        [DataMember(Name = "empty_layout_detection_mode", EmitDefaultValue = false)]
        public EmptyLayoutDetectionModeEnum? EmptyLayoutDetectionMode { get; set; }
        /// <summary>
        /// Specify the sort order in which the layouts are converted
        /// </summary>
        /// <value>Specify the sort order in which the layouts are converted</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayoutSortOrderEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,

            /// <summary>
            /// Enum Ascending for value: Ascending
            /// </summary>
            [EnumMember(Value = "Ascending")]
            Ascending = 2,

            /// <summary>
            /// Enum Descending for value: Descending
            /// </summary>
            [EnumMember(Value = "Descending")]
            Descending = 3,

            /// <summary>
            /// Enum TabOrder for value: TabOrder
            /// </summary>
            [EnumMember(Value = "TabOrder")]
            TabOrder = 4

        }


        /// <summary>
        /// Specify the sort order in which the layouts are converted
        /// </summary>
        /// <value>Specify the sort order in which the layouts are converted</value>
        [DataMember(Name = "layout_sort_order", EmitDefaultValue = false)]
        public LayoutSortOrderEnum? LayoutSortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertCadData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConvertCadData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertCadData" /> class.
        /// </summary>
        /// <param name="useAsyncPattern">Use async behaviour for API request (required) (default to false).</param>
        /// <param name="sourceFileName">Name of the source file including extension (required).</param>
        /// <param name="sharepointFile">sharepointFile.</param>
        /// <param name="sourceFileContent">Content of the file to convert (required).</param>
        /// <param name="copyMetadata">Copy metadata (Only for SharePoint operations) (required) (default to false).</param>
        /// <param name="paperSize">Paper size for the output (default to PaperSizeEnum.Letter).</param>
        /// <param name="paperSizeCustom">Applicable if &#39;Paper size&#39; is set to &#39;Custom&#39;.</param>
        /// <param name="pageMargins">E.g. &#39;1.5cm&#39; (for uniform) or &#39;0.5in, 0.25in, 0.5in, 0.25in&#39; (for non-uniform) margins (default to &quot;0.25&quot;).</param>
        /// <param name="backgroundColor">.Net color name or hex color (#aarrggbb or #rrggbb) (default to &quot;White&quot;).</param>
        /// <param name="foregroundColor">The foreground effect or color (default to ForegroundColorEnum.GreyscaleDarken).</param>
        /// <param name="foregroundColorCustom">.Net color name or hex color (#aarrggbb or #rrggbb). Applicable if &#39;Foreground color&#39; is set to &#39;Custom&#39;.</param>
        /// <param name="emptyLayoutDetectionMode">Select which layouts should be skipped (default to EmptyLayoutDetectionModeEnum.SkipEmptyLayouts).</param>
        /// <param name="layoutSortOrder">Specify the sort order in which the layouts are converted (default to LayoutSortOrderEnum.Ascending).</param>
        /// <param name="startPage">The first page to include.</param>
        /// <param name="endPage">The last page to include.</param>
        /// <param name="overrideSettings">Optional settings using Muhimbi&#39;s XML syntax.</param>
        /// <param name="failOnError">Fail on error (default to true).</param>
        public ConvertCadData(bool useAsyncPattern = false, string sourceFileName = default(string), SharepointFile sharepointFile = default(SharepointFile), byte[] sourceFileContent = default(byte[]), bool copyMetadata = false, PaperSizeEnum? paperSize = PaperSizeEnum.Letter, string paperSizeCustom = default(string), string pageMargins = "0.25", string backgroundColor = "White", ForegroundColorEnum? foregroundColor = ForegroundColorEnum.GreyscaleDarken, string foregroundColorCustom = default(string), EmptyLayoutDetectionModeEnum? emptyLayoutDetectionMode = EmptyLayoutDetectionModeEnum.SkipEmptyLayouts, LayoutSortOrderEnum? layoutSortOrder = LayoutSortOrderEnum.Ascending, int startPage = default(int), int endPage = default(int), string overrideSettings = default(string), bool failOnError = true)
        {
            this.UseAsyncPattern = useAsyncPattern;
            // to ensure "sourceFileName" is required (not null)
            if (sourceFileName == null)
            {
                throw new ArgumentNullException("sourceFileName is a required property for ConvertCadData and cannot be null");
            }
            this.SourceFileName = sourceFileName;
            // to ensure "sourceFileContent" is required (not null)
            if (sourceFileContent == null)
            {
                throw new ArgumentNullException("sourceFileContent is a required property for ConvertCadData and cannot be null");
            }
            this.SourceFileContent = sourceFileContent;
            this.CopyMetadata = copyMetadata;
            this.SharepointFile = sharepointFile;
            this.PaperSize = paperSize;
            this.PaperSizeCustom = paperSizeCustom;
            // use default value if no "pageMargins" provided
            this.PageMargins = pageMargins ?? "0.25";
            // use default value if no "backgroundColor" provided
            this.BackgroundColor = backgroundColor ?? "White";
            this.ForegroundColor = foregroundColor;
            this.ForegroundColorCustom = foregroundColorCustom;
            this.EmptyLayoutDetectionMode = emptyLayoutDetectionMode;
            this.LayoutSortOrder = layoutSortOrder;
            this.StartPage = startPage;
            this.EndPage = endPage;
            this.OverrideSettings = overrideSettings;
            this.FailOnError = failOnError;
        }

        /// <summary>
        /// Use async behaviour for API request
        /// </summary>
        /// <value>Use async behaviour for API request</value>
        [DataMember(Name = "use_async_pattern", IsRequired = true, EmitDefaultValue = true)]
        public bool UseAsyncPattern { get; set; }

        /// <summary>
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name = "source_file_name", IsRequired = true, EmitDefaultValue = false)]
        public string SourceFileName { get; set; }

        /// <summary>
        /// Gets or Sets SharepointFile
        /// </summary>
        [DataMember(Name = "sharepoint_file", EmitDefaultValue = false)]
        public SharepointFile SharepointFile { get; set; }

        /// <summary>
        /// Content of the file to convert
        /// </summary>
        /// <value>Content of the file to convert</value>
        [DataMember(Name = "source_file_content", IsRequired = true, EmitDefaultValue = false)]
        public byte[] SourceFileContent { get; set; }

        /// <summary>
        /// Copy metadata (Only for SharePoint operations)
        /// </summary>
        /// <value>Copy metadata (Only for SharePoint operations)</value>
        [DataMember(Name = "copy_metadata", IsRequired = true, EmitDefaultValue = true)]
        public bool CopyMetadata { get; set; }

        /// <summary>
        /// Applicable if &#39;Paper size&#39; is set to &#39;Custom&#39;
        /// </summary>
        /// <value>Applicable if &#39;Paper size&#39; is set to &#39;Custom&#39;</value>
        [DataMember(Name = "paper_size_custom", EmitDefaultValue = false)]
        public string PaperSizeCustom { get; set; }

        /// <summary>
        /// E.g. &#39;1.5cm&#39; (for uniform) or &#39;0.5in, 0.25in, 0.5in, 0.25in&#39; (for non-uniform) margins
        /// </summary>
        /// <value>E.g. &#39;1.5cm&#39; (for uniform) or &#39;0.5in, 0.25in, 0.5in, 0.25in&#39; (for non-uniform) margins</value>
        [DataMember(Name = "page_margins", EmitDefaultValue = false)]
        public string PageMargins { get; set; }

        /// <summary>
        /// .Net color name or hex color (#aarrggbb or #rrggbb)
        /// </summary>
        /// <value>.Net color name or hex color (#aarrggbb or #rrggbb)</value>
        [DataMember(Name = "background_color", EmitDefaultValue = false)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// .Net color name or hex color (#aarrggbb or #rrggbb). Applicable if &#39;Foreground color&#39; is set to &#39;Custom&#39;
        /// </summary>
        /// <value>.Net color name or hex color (#aarrggbb or #rrggbb). Applicable if &#39;Foreground color&#39; is set to &#39;Custom&#39;</value>
        [DataMember(Name = "foreground_color_custom", EmitDefaultValue = false)]
        public string ForegroundColorCustom { get; set; }

        /// <summary>
        /// The first page to include
        /// </summary>
        /// <value>The first page to include</value>
        [DataMember(Name = "start_page", EmitDefaultValue = false)]
        public int StartPage { get; set; }

        /// <summary>
        /// The last page to include
        /// </summary>
        /// <value>The last page to include</value>
        [DataMember(Name = "end_page", EmitDefaultValue = false)]
        public int EndPage { get; set; }

        /// <summary>
        /// Optional settings using Muhimbi&#39;s XML syntax
        /// </summary>
        /// <value>Optional settings using Muhimbi&#39;s XML syntax</value>
        [DataMember(Name = "override_settings", EmitDefaultValue = false)]
        public string OverrideSettings { get; set; }

        /// <summary>
        /// Fail on error
        /// </summary>
        /// <value>Fail on error</value>
        [DataMember(Name = "fail_on_error", EmitDefaultValue = true)]
        public bool FailOnError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConvertCadData {\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceFileName: ").Append(SourceFileName).Append("\n");
            sb.Append("  SharepointFile: ").Append(SharepointFile).Append("\n");
            sb.Append("  SourceFileContent: ").Append(SourceFileContent).Append("\n");
            sb.Append("  CopyMetadata: ").Append(CopyMetadata).Append("\n");
            sb.Append("  PaperSize: ").Append(PaperSize).Append("\n");
            sb.Append("  PaperSizeCustom: ").Append(PaperSizeCustom).Append("\n");
            sb.Append("  PageMargins: ").Append(PageMargins).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  ForegroundColor: ").Append(ForegroundColor).Append("\n");
            sb.Append("  ForegroundColorCustom: ").Append(ForegroundColorCustom).Append("\n");
            sb.Append("  EmptyLayoutDetectionMode: ").Append(EmptyLayoutDetectionMode).Append("\n");
            sb.Append("  LayoutSortOrder: ").Append(LayoutSortOrder).Append("\n");
            sb.Append("  StartPage: ").Append(StartPage).Append("\n");
            sb.Append("  EndPage: ").Append(EndPage).Append("\n");
            sb.Append("  OverrideSettings: ").Append(OverrideSettings).Append("\n");
            sb.Append("  FailOnError: ").Append(FailOnError).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConvertCadData);
        }

        /// <summary>
        /// Returns true if ConvertCadData instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvertCadData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertCadData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UseAsyncPattern == input.UseAsyncPattern ||
                    this.UseAsyncPattern.Equals(input.UseAsyncPattern)
                ) && 
                (
                    this.SourceFileName == input.SourceFileName ||
                    (this.SourceFileName != null &&
                    this.SourceFileName.Equals(input.SourceFileName))
                ) && 
                (
                    this.SharepointFile == input.SharepointFile ||
                    (this.SharepointFile != null &&
                    this.SharepointFile.Equals(input.SharepointFile))
                ) && 
                (
                    this.SourceFileContent == input.SourceFileContent ||
                    (this.SourceFileContent != null &&
                    this.SourceFileContent.Equals(input.SourceFileContent))
                ) && 
                (
                    this.CopyMetadata == input.CopyMetadata ||
                    this.CopyMetadata.Equals(input.CopyMetadata)
                ) && 
                (
                    this.PaperSize == input.PaperSize ||
                    this.PaperSize.Equals(input.PaperSize)
                ) && 
                (
                    this.PaperSizeCustom == input.PaperSizeCustom ||
                    (this.PaperSizeCustom != null &&
                    this.PaperSizeCustom.Equals(input.PaperSizeCustom))
                ) && 
                (
                    this.PageMargins == input.PageMargins ||
                    (this.PageMargins != null &&
                    this.PageMargins.Equals(input.PageMargins))
                ) && 
                (
                    this.BackgroundColor == input.BackgroundColor ||
                    (this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(input.BackgroundColor))
                ) && 
                (
                    this.ForegroundColor == input.ForegroundColor ||
                    this.ForegroundColor.Equals(input.ForegroundColor)
                ) && 
                (
                    this.ForegroundColorCustom == input.ForegroundColorCustom ||
                    (this.ForegroundColorCustom != null &&
                    this.ForegroundColorCustom.Equals(input.ForegroundColorCustom))
                ) && 
                (
                    this.EmptyLayoutDetectionMode == input.EmptyLayoutDetectionMode ||
                    this.EmptyLayoutDetectionMode.Equals(input.EmptyLayoutDetectionMode)
                ) && 
                (
                    this.LayoutSortOrder == input.LayoutSortOrder ||
                    this.LayoutSortOrder.Equals(input.LayoutSortOrder)
                ) && 
                (
                    this.StartPage == input.StartPage ||
                    this.StartPage.Equals(input.StartPage)
                ) && 
                (
                    this.EndPage == input.EndPage ||
                    this.EndPage.Equals(input.EndPage)
                ) && 
                (
                    this.OverrideSettings == input.OverrideSettings ||
                    (this.OverrideSettings != null &&
                    this.OverrideSettings.Equals(input.OverrideSettings))
                ) && 
                (
                    this.FailOnError == input.FailOnError ||
                    this.FailOnError.Equals(input.FailOnError)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.UseAsyncPattern.GetHashCode();
                if (this.SourceFileName != null)
                {
                    hashCode = (hashCode * 59) + this.SourceFileName.GetHashCode();
                }
                if (this.SharepointFile != null)
                {
                    hashCode = (hashCode * 59) + this.SharepointFile.GetHashCode();
                }
                if (this.SourceFileContent != null)
                {
                    hashCode = (hashCode * 59) + this.SourceFileContent.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CopyMetadata.GetHashCode();
                hashCode = (hashCode * 59) + this.PaperSize.GetHashCode();
                if (this.PaperSizeCustom != null)
                {
                    hashCode = (hashCode * 59) + this.PaperSizeCustom.GetHashCode();
                }
                if (this.PageMargins != null)
                {
                    hashCode = (hashCode * 59) + this.PageMargins.GetHashCode();
                }
                if (this.BackgroundColor != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundColor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ForegroundColor.GetHashCode();
                if (this.ForegroundColorCustom != null)
                {
                    hashCode = (hashCode * 59) + this.ForegroundColorCustom.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EmptyLayoutDetectionMode.GetHashCode();
                hashCode = (hashCode * 59) + this.LayoutSortOrder.GetHashCode();
                hashCode = (hashCode * 59) + this.StartPage.GetHashCode();
                hashCode = (hashCode * 59) + this.EndPage.GetHashCode();
                if (this.OverrideSettings != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FailOnError.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
