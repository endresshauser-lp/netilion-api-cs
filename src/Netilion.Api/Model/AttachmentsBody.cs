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
    /// AttachmentsBody
    /// </summary>
    [DataContract]
        public partial class AttachmentsBody :  IEquatable<AttachmentsBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsBody" /> class.
        /// </summary>
        /// <param name="file">the filedata to upload (required).</param>
        /// <param name="documentId">the document this attachment belongs to (required).</param>
        /// <param name="contentAuthor">the file authors name.</param>
        /// <param name="contentVersion">The version can be set as float.</param>
        /// <param name="contentDate">last edit date of the file. Datetime must be in format YYYY-MM-DD or YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="remarks">remarks on the attachment.</param>
        /// <param name="languages">the files content languages. Send as comma separated list with alpha2 language codes (eg. de,en,fr). Supported languages are defined in ISO639-1.</param>
        public AttachmentsBody(byte[] file = default(byte[]), long? documentId = default(long?), string contentAuthor = default(string), string contentVersion = default(string), string contentDate = default(string), string remarks = default(string), string languages = default(string))
        {
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new InvalidDataException("file is a required property for AttachmentsBody and cannot be null");
            }
            else
            {
                this.File = file;
            }
            // to ensure "documentId" is required (not null)
            if (documentId == null)
            {
                throw new InvalidDataException("documentId is a required property for AttachmentsBody and cannot be null");
            }
            else
            {
                this.DocumentId = documentId;
            }
            this.ContentAuthor = contentAuthor;
            this.ContentVersion = contentVersion;
            this.ContentDate = contentDate;
            this.Remarks = remarks;
            this.Languages = languages;
        }
        
        /// <summary>
        /// the filedata to upload
        /// </summary>
        /// <value>the filedata to upload</value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public byte[] File { get; set; }

        /// <summary>
        /// the document this attachment belongs to
        /// </summary>
        /// <value>the document this attachment belongs to</value>
        [DataMember(Name="document_id", EmitDefaultValue=false)]
        public long? DocumentId { get; set; }

        /// <summary>
        /// the file authors name
        /// </summary>
        /// <value>the file authors name</value>
        [DataMember(Name="content_author", EmitDefaultValue=false)]
        public string ContentAuthor { get; set; }

        /// <summary>
        /// The version can be set as float
        /// </summary>
        /// <value>The version can be set as float</value>
        [DataMember(Name="content_version", EmitDefaultValue=false)]
        public string ContentVersion { get; set; }

        /// <summary>
        /// last edit date of the file. Datetime must be in format YYYY-MM-DD or YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>last edit date of the file. Datetime must be in format YYYY-MM-DD or YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="content_date", EmitDefaultValue=false)]
        public string ContentDate { get; set; }

        /// <summary>
        /// remarks on the attachment
        /// </summary>
        /// <value>remarks on the attachment</value>
        [DataMember(Name="remarks", EmitDefaultValue=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// the files content languages. Send as comma separated list with alpha2 language codes (eg. de,en,fr). Supported languages are defined in ISO639-1
        /// </summary>
        /// <value>the files content languages. Send as comma separated list with alpha2 language codes (eg. de,en,fr). Supported languages are defined in ISO639-1</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public string Languages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentsBody {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  ContentAuthor: ").Append(ContentAuthor).Append("\n");
            sb.Append("  ContentVersion: ").Append(ContentVersion).Append("\n");
            sb.Append("  ContentDate: ").Append(ContentDate).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
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
            return this.Equals(input as AttachmentsBody);
        }

        /// <summary>
        /// Returns true if AttachmentsBody instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentsBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentsBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.ContentAuthor == input.ContentAuthor ||
                    (this.ContentAuthor != null &&
                    this.ContentAuthor.Equals(input.ContentAuthor))
                ) && 
                (
                    this.ContentVersion == input.ContentVersion ||
                    (this.ContentVersion != null &&
                    this.ContentVersion.Equals(input.ContentVersion))
                ) && 
                (
                    this.ContentDate == input.ContentDate ||
                    (this.ContentDate != null &&
                    this.ContentDate.Equals(input.ContentDate))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.Languages == input.Languages ||
                    (this.Languages != null &&
                    this.Languages.Equals(input.Languages))
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.DocumentId != null)
                    hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.ContentAuthor != null)
                    hashCode = hashCode * 59 + this.ContentAuthor.GetHashCode();
                if (this.ContentVersion != null)
                    hashCode = hashCode * 59 + this.ContentVersion.GetHashCode();
                if (this.ContentDate != null)
                    hashCode = hashCode * 59 + this.ContentDate.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
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
