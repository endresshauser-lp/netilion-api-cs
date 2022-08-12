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
    /// PictureResponse
    /// </summary>
    [DataContract]
        public partial class PictureResponse :  IEquatable<PictureResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureResponse" /> class.
        /// </summary>
        /// <param name="id">Id of object (required).</param>
        /// <param name="type">type of attachment, can be &#x27;file&#x27; or &#x27;link&#x27; (required).</param>
        /// <param name="fileName">the original filename of the attachment.</param>
        /// <param name="fingerprint">SHA256 checksum of the file.</param>
        /// <param name="width">width of picture.</param>
        /// <param name="height">height of picture.</param>
        /// <param name="downloadHref">the download link to the file of the attachment (required).</param>
        public PictureResponse(long? id = default(long?), string type = default(string), string fileName = default(string), string fingerprint = default(string), int? width = default(int?), int? height = default(int?), string downloadHref = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for PictureResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for PictureResponse and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "downloadHref" is required (not null)
            if (downloadHref == null)
            {
                throw new InvalidDataException("downloadHref is a required property for PictureResponse and cannot be null");
            }
            else
            {
                this.DownloadHref = downloadHref;
            }
            this.FileName = fileName;
            this.Fingerprint = fingerprint;
            this.Width = width;
            this.Height = height;
        }
        
        /// <summary>
        /// Id of object
        /// </summary>
        /// <value>Id of object</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// type of attachment, can be &#x27;file&#x27; or &#x27;link&#x27;
        /// </summary>
        /// <value>type of attachment, can be &#x27;file&#x27; or &#x27;link&#x27;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// the original filename of the attachment
        /// </summary>
        /// <value>the original filename of the attachment</value>
        [DataMember(Name="file_name", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// SHA256 checksum of the file
        /// </summary>
        /// <value>SHA256 checksum of the file</value>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// width of picture
        /// </summary>
        /// <value>width of picture</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// height of picture
        /// </summary>
        /// <value>height of picture</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// the download link to the file of the attachment
        /// </summary>
        /// <value>the download link to the file of the attachment</value>
        [DataMember(Name="download_href", EmitDefaultValue=false)]
        public string DownloadHref { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PictureResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  DownloadHref: ").Append(DownloadHref).Append("\n");
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
            return this.Equals(input as PictureResponse);
        }

        /// <summary>
        /// Returns true if PictureResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PictureResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PictureResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.DownloadHref == input.DownloadHref ||
                    (this.DownloadHref != null &&
                    this.DownloadHref.Equals(input.DownloadHref))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.DownloadHref != null)
                    hashCode = hashCode * 59 + this.DownloadHref.GetHashCode();
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