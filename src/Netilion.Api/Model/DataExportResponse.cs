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
    /// DataExportResponse
    /// </summary>
    [DataContract]
        public partial class DataExportResponse :  IEquatable<DataExportResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExportResponse" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="type">can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container (required).</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="finishedAt">finishedAt.</param>
        /// <param name="language">language in which the export should be made (currently only applicable to vdi 2770 containers).</param>
        /// <param name="exportFileName">exportFileName.</param>
        /// <param name="exportContentType">exportContentType.</param>
        /// <param name="exportFileSize">exportFileSize.</param>
        /// <param name="exportUpdatedAt">exportUpdatedAt.</param>
        /// <param name="exportFingerprint">exportFingerprint.</param>
        /// <param name="user">user (required).</param>
        /// <param name="asset">asset.</param>
        /// <param name="instrumentation">instrumentation.</param>
        /// <param name="system">system.</param>
        /// <param name="batch">batch.</param>
        /// <param name="downloadHref">download link.</param>
        /// <param name="availableUntil">date until the download is available, after that the download will automatically removed.</param>
        /// <param name="keys">value keys to export (in case of type instrumentation_values).</param>
        public DataExportResponse(int? status = default(int?), string type = default(string), string startDate = default(string), string endDate = default(string), string createdAt = default(string), string finishedAt = default(string), string language = default(string), string exportFileName = default(string), string exportContentType = default(string), string exportFileSize = default(string), string exportUpdatedAt = default(string), string exportFingerprint = default(string), NestedIDHref user = default(NestedIDHref), NestedIDHrefSerialnumber asset = default(NestedIDHrefSerialnumber), NestedIDHrefTag instrumentation = default(NestedIDHrefTag), NestedIDHrefName system = default(NestedIDHrefName), NestedIDHrefName batch = default(NestedIDHrefName), string downloadHref = default(string), string availableUntil = default(string), List<string> keys = default(List<string>))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for DataExportResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DataExportResponse and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for DataExportResponse and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for DataExportResponse and cannot be null");
            }
            else
            {
                this.User = user;
            }
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.FinishedAt = finishedAt;
            this.Language = language;
            this.ExportFileName = exportFileName;
            this.ExportContentType = exportContentType;
            this.ExportFileSize = exportFileSize;
            this.ExportUpdatedAt = exportUpdatedAt;
            this.ExportFingerprint = exportFingerprint;
            this.Asset = asset;
            this.Instrumentation = instrumentation;
            this.System = system;
            this.Batch = batch;
            this.DownloadHref = downloadHref;
            this.AvailableUntil = availableUntil;
            this.Keys = keys;
        }
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container
        /// </summary>
        /// <value>can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FinishedAt
        /// </summary>
        [DataMember(Name="finished_at", EmitDefaultValue=false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// language in which the export should be made (currently only applicable to vdi 2770 containers)
        /// </summary>
        /// <value>language in which the export should be made (currently only applicable to vdi 2770 containers)</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets ExportFileName
        /// </summary>
        [DataMember(Name="export_file_name", EmitDefaultValue=false)]
        public string ExportFileName { get; set; }

        /// <summary>
        /// Gets or Sets ExportContentType
        /// </summary>
        [DataMember(Name="export_content_type", EmitDefaultValue=false)]
        public string ExportContentType { get; set; }

        /// <summary>
        /// Gets or Sets ExportFileSize
        /// </summary>
        [DataMember(Name="export_file_size", EmitDefaultValue=false)]
        public string ExportFileSize { get; set; }

        /// <summary>
        /// Gets or Sets ExportUpdatedAt
        /// </summary>
        [DataMember(Name="export_updated_at", EmitDefaultValue=false)]
        public string ExportUpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExportFingerprint
        /// </summary>
        [DataMember(Name="export_fingerprint", EmitDefaultValue=false)]
        public string ExportFingerprint { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public NestedIDHref User { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name="asset", EmitDefaultValue=false)]
        public NestedIDHrefSerialnumber Asset { get; set; }

        /// <summary>
        /// Gets or Sets Instrumentation
        /// </summary>
        [DataMember(Name="instrumentation", EmitDefaultValue=false)]
        public NestedIDHrefTag Instrumentation { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="system", EmitDefaultValue=false)]
        public NestedIDHrefName System { get; set; }

        /// <summary>
        /// Gets or Sets Batch
        /// </summary>
        [DataMember(Name="batch", EmitDefaultValue=false)]
        public NestedIDHrefName Batch { get; set; }

        /// <summary>
        /// download link
        /// </summary>
        /// <value>download link</value>
        [DataMember(Name="download_href", EmitDefaultValue=false)]
        public string DownloadHref { get; set; }

        /// <summary>
        /// date until the download is available, after that the download will automatically removed
        /// </summary>
        /// <value>date until the download is available, after that the download will automatically removed</value>
        [DataMember(Name="available_until", EmitDefaultValue=false)]
        public string AvailableUntil { get; set; }

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
            sb.Append("class DataExportResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ExportFileName: ").Append(ExportFileName).Append("\n");
            sb.Append("  ExportContentType: ").Append(ExportContentType).Append("\n");
            sb.Append("  ExportFileSize: ").Append(ExportFileSize).Append("\n");
            sb.Append("  ExportUpdatedAt: ").Append(ExportUpdatedAt).Append("\n");
            sb.Append("  ExportFingerprint: ").Append(ExportFingerprint).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Instrumentation: ").Append(Instrumentation).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Batch: ").Append(Batch).Append("\n");
            sb.Append("  DownloadHref: ").Append(DownloadHref).Append("\n");
            sb.Append("  AvailableUntil: ").Append(AvailableUntil).Append("\n");
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
            return this.Equals(input as DataExportResponse);
        }

        /// <summary>
        /// Returns true if DataExportResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DataExportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataExportResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ExportFileName == input.ExportFileName ||
                    (this.ExportFileName != null &&
                    this.ExportFileName.Equals(input.ExportFileName))
                ) && 
                (
                    this.ExportContentType == input.ExportContentType ||
                    (this.ExportContentType != null &&
                    this.ExportContentType.Equals(input.ExportContentType))
                ) && 
                (
                    this.ExportFileSize == input.ExportFileSize ||
                    (this.ExportFileSize != null &&
                    this.ExportFileSize.Equals(input.ExportFileSize))
                ) && 
                (
                    this.ExportUpdatedAt == input.ExportUpdatedAt ||
                    (this.ExportUpdatedAt != null &&
                    this.ExportUpdatedAt.Equals(input.ExportUpdatedAt))
                ) && 
                (
                    this.ExportFingerprint == input.ExportFingerprint ||
                    (this.ExportFingerprint != null &&
                    this.ExportFingerprint.Equals(input.ExportFingerprint))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                    this.DownloadHref == input.DownloadHref ||
                    (this.DownloadHref != null &&
                    this.DownloadHref.Equals(input.DownloadHref))
                ) && 
                (
                    this.AvailableUntil == input.AvailableUntil ||
                    (this.AvailableUntil != null &&
                    this.AvailableUntil.Equals(input.AvailableUntil))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ExportFileName != null)
                    hashCode = hashCode * 59 + this.ExportFileName.GetHashCode();
                if (this.ExportContentType != null)
                    hashCode = hashCode * 59 + this.ExportContentType.GetHashCode();
                if (this.ExportFileSize != null)
                    hashCode = hashCode * 59 + this.ExportFileSize.GetHashCode();
                if (this.ExportUpdatedAt != null)
                    hashCode = hashCode * 59 + this.ExportUpdatedAt.GetHashCode();
                if (this.ExportFingerprint != null)
                    hashCode = hashCode * 59 + this.ExportFingerprint.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Asset != null)
                    hashCode = hashCode * 59 + this.Asset.GetHashCode();
                if (this.Instrumentation != null)
                    hashCode = hashCode * 59 + this.Instrumentation.GetHashCode();
                if (this.System != null)
                    hashCode = hashCode * 59 + this.System.GetHashCode();
                if (this.Batch != null)
                    hashCode = hashCode * 59 + this.Batch.GetHashCode();
                if (this.DownloadHref != null)
                    hashCode = hashCode * 59 + this.DownloadHref.GetHashCode();
                if (this.AvailableUntil != null)
                    hashCode = hashCode * 59 + this.AvailableUntil.GetHashCode();
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
