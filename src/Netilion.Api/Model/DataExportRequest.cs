/* 
 * Netilion API Documentation
 *
 * Welcome to the Netilion API Documentation, which provides interactive access and documentation to our REST API. Please visit our developer portal for further instructions and information: https://developer.netilion.endress.com/ 
 *
 * OpenAPI spec version: 01.00.00
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Netilion.Api.Client.SwaggerDateConverter;

namespace Netilion.Api.Model
{
    /// <summary>
    /// DataExportRequest
    /// </summary>
    [DataContract]
        public partial class DataExportRequest :  IEquatable<DataExportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExportRequest" /> class.
        /// </summary>
        /// <param name="type">can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container (required).</param>
        /// <param name="startDate">start of export date range.</param>
        /// <param name="endDate">end of export date range, if not provided, current date will be used.</param>
        /// <param name="language">language in which the export should be made (currently only applicable to vdi 2770 containers).</param>
        /// <param name="asset">asset.</param>
        /// <param name="instrumentation">instrumentation.</param>
        /// <param name="system">system.</param>
        /// <param name="batch">batch.</param>
        /// <param name="keys">value keys to export (in case of type instrumentation_values).</param>
        public DataExportRequest(string type = default(string), string startDate = default(string), string endDate = default(string), string language = default(string), NestedID asset = default(NestedID), NestedID instrumentation = default(NestedID), NestedID system = default(NestedID), NestedID batch = default(NestedID), List<string> keys = default(List<string>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DataExportRequest and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Language = language;
            this.Asset = asset;
            this.Instrumentation = instrumentation;
            this.System = system;
            this.Batch = batch;
            this.Keys = keys;
        }
        
        /// <summary>
        /// can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container
        /// </summary>
        /// <value>can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// start of export date range
        /// </summary>
        /// <value>start of export date range</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// end of export date range, if not provided, current date will be used
        /// </summary>
        /// <value>end of export date range, if not provided, current date will be used</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// language in which the export should be made (currently only applicable to vdi 2770 containers)
        /// </summary>
        /// <value>language in which the export should be made (currently only applicable to vdi 2770 containers)</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name="asset", EmitDefaultValue=false)]
        public NestedID Asset { get; set; }

        /// <summary>
        /// Gets or Sets Instrumentation
        /// </summary>
        [DataMember(Name="instrumentation", EmitDefaultValue=false)]
        public NestedID Instrumentation { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="system", EmitDefaultValue=false)]
        public NestedID System { get; set; }

        /// <summary>
        /// Gets or Sets Batch
        /// </summary>
        [DataMember(Name="batch", EmitDefaultValue=false)]
        public NestedID Batch { get; set; }

        /// <summary>
        /// value keys to export (in case of type instrumentation_values)
        /// </summary>
        /// <value>value keys to export (in case of type instrumentation_values)</value>
        [DataMember(Name="keys", EmitDefaultValue=false)]
        public List<string> Keys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataExportRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Instrumentation: ").Append(Instrumentation).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Batch: ").Append(Batch).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataExportRequest);
        }

        /// <summary>
        /// Returns true if DataExportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DataExportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataExportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Asset == input.Asset ||
                    (this.Asset != null &&
                    this.Asset.Equals(input.Asset))
                ) && 
                (
                    this.Instrumentation == input.Instrumentation ||
                    (this.Instrumentation != null &&
                    this.Instrumentation.Equals(input.Instrumentation))
                ) && 
                (
                    this.System == input.System ||
                    (this.System != null &&
                    this.System.Equals(input.System))
                ) && 
                (
                    this.Batch == input.Batch ||
                    (this.Batch != null &&
                    this.Batch.Equals(input.Batch))
                ) && 
                (
                    this.Keys == input.Keys ||
                    this.Keys != null &&
                    input.Keys != null &&
                    this.Keys.SequenceEqual(input.Keys)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Asset != null)
                    hashCode = hashCode * 59 + this.Asset.GetHashCode();
                if (this.Instrumentation != null)
                    hashCode = hashCode * 59 + this.Instrumentation.GetHashCode();
                if (this.System != null)
                    hashCode = hashCode * 59 + this.System.GetHashCode();
                if (this.Batch != null)
                    hashCode = hashCode * 59 + this.Batch.GetHashCode();
                if (this.Keys != null)
                    hashCode = hashCode * 59 + this.Keys.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
