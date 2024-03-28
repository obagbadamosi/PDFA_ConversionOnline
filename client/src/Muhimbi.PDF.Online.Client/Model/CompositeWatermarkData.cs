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
    /// Parameters for CompositeWatermark operation
    /// </summary>
    [DataContract(Name = "composite_watermark_data")]
    public partial class CompositeWatermarkData : IEquatable<CompositeWatermarkData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeWatermarkData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompositeWatermarkData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeWatermarkData" /> class.
        /// </summary>
        /// <param name="sourceFileName">Name of the source file including extension.</param>
        /// <param name="useAsyncPattern">Use async behaviour for API request (required) (default to false).</param>
        /// <param name="sourceFileContent">Content of the file to watermark (required).</param>
        /// <param name="sharepointFile">sharepointFile.</param>
        /// <param name="watermarkData">Watermark data in Muhimbi XML format (required).</param>
        /// <param name="failOnError">Fail on error (default to true).</param>
        public CompositeWatermarkData(string sourceFileName = default(string), bool useAsyncPattern = false, byte[] sourceFileContent = default(byte[]), SharepointFile sharepointFile = default(SharepointFile), string watermarkData = default(string), bool failOnError = true)
        {
            this.UseAsyncPattern = useAsyncPattern;
            // to ensure "sourceFileContent" is required (not null)
            if (sourceFileContent == null)
            {
                throw new ArgumentNullException("sourceFileContent is a required property for CompositeWatermarkData and cannot be null");
            }
            this.SourceFileContent = sourceFileContent;
            // to ensure "watermarkData" is required (not null)
            if (watermarkData == null)
            {
                throw new ArgumentNullException("watermarkData is a required property for CompositeWatermarkData and cannot be null");
            }
            this.WatermarkData = watermarkData;
            this.SourceFileName = sourceFileName;
            this.SharepointFile = sharepointFile;
            this.FailOnError = failOnError;
        }

        /// <summary>
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name = "source_file_name", EmitDefaultValue = false)]
        public string SourceFileName { get; set; }

        /// <summary>
        /// Use async behaviour for API request
        /// </summary>
        /// <value>Use async behaviour for API request</value>
        [DataMember(Name = "use_async_pattern", IsRequired = true, EmitDefaultValue = true)]
        public bool UseAsyncPattern { get; set; }

        /// <summary>
        /// Content of the file to watermark
        /// </summary>
        /// <value>Content of the file to watermark</value>
        [DataMember(Name = "source_file_content", IsRequired = true, EmitDefaultValue = false)]
        public byte[] SourceFileContent { get; set; }

        /// <summary>
        /// Gets or Sets SharepointFile
        /// </summary>
        [DataMember(Name = "sharepoint_file", EmitDefaultValue = false)]
        public SharepointFile SharepointFile { get; set; }

        /// <summary>
        /// Watermark data in Muhimbi XML format
        /// </summary>
        /// <value>Watermark data in Muhimbi XML format</value>
        [DataMember(Name = "watermark_data", IsRequired = true, EmitDefaultValue = false)]
        public string WatermarkData { get; set; }

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
            sb.Append("class CompositeWatermarkData {\n");
            sb.Append("  SourceFileName: ").Append(SourceFileName).Append("\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceFileContent: ").Append(SourceFileContent).Append("\n");
            sb.Append("  SharepointFile: ").Append(SharepointFile).Append("\n");
            sb.Append("  WatermarkData: ").Append(WatermarkData).Append("\n");
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
            return this.Equals(input as CompositeWatermarkData);
        }

        /// <summary>
        /// Returns true if CompositeWatermarkData instances are equal
        /// </summary>
        /// <param name="input">Instance of CompositeWatermarkData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompositeWatermarkData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceFileName == input.SourceFileName ||
                    (this.SourceFileName != null &&
                    this.SourceFileName.Equals(input.SourceFileName))
                ) && 
                (
                    this.UseAsyncPattern == input.UseAsyncPattern ||
                    this.UseAsyncPattern.Equals(input.UseAsyncPattern)
                ) && 
                (
                    this.SourceFileContent == input.SourceFileContent ||
                    (this.SourceFileContent != null &&
                    this.SourceFileContent.Equals(input.SourceFileContent))
                ) && 
                (
                    this.SharepointFile == input.SharepointFile ||
                    (this.SharepointFile != null &&
                    this.SharepointFile.Equals(input.SharepointFile))
                ) && 
                (
                    this.WatermarkData == input.WatermarkData ||
                    (this.WatermarkData != null &&
                    this.WatermarkData.Equals(input.WatermarkData))
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
                if (this.SourceFileName != null)
                {
                    hashCode = (hashCode * 59) + this.SourceFileName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseAsyncPattern.GetHashCode();
                if (this.SourceFileContent != null)
                {
                    hashCode = (hashCode * 59) + this.SourceFileContent.GetHashCode();
                }
                if (this.SharepointFile != null)
                {
                    hashCode = (hashCode * 59) + this.SharepointFile.GetHashCode();
                }
                if (this.WatermarkData != null)
                {
                    hashCode = (hashCode * 59) + this.WatermarkData.GetHashCode();
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