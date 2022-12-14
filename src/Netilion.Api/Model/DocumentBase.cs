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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Netilion.Api.Client.SwaggerDateConverter;

namespace Netilion.Api.Model
{
    /// <summary>
    /// DocumentBase
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "documentBaseType")]
    [JsonSubtypes.KnownSubType(typeof(DocumentResponse), "DocumentResponse")]
    [JsonSubtypes.KnownSubType(typeof(DocumentRequest), "DocumentRequest")]
        public partial class DocumentBase :  IEquatable<DocumentBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBase" /> class.
        /// </summary>
        /// <param name="name">Supports translations. (required).</param>
        /// <param name="description">Supports translations..</param>
        /// <param name="number">This attribute can be used as an additional identifier for documents.</param>
        /// <param name="documentVersion">documentVersion.</param>
        /// <param name="validFrom">Date must be in format &#x27;YYYY-MM-DD&#x27;.</param>
        /// <param name="validUntil">Date must be in format &#x27;YYYY-MM-DD&#x27;.</param>
        public DocumentBase(string name = default(string), string description = default(string), string number = default(string), string documentVersion = default(string), string validFrom = default(string), string validUntil = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DocumentBase and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Description = description;
            this.Number = number;
            this.DocumentVersion = documentVersion;
            this.ValidFrom = validFrom;
            this.ValidUntil = validUntil;
        }
        
        /// <summary>
        /// Supports translations.
        /// </summary>
        /// <value>Supports translations.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Supports translations.
        /// </summary>
        /// <value>Supports translations.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// This attribute can be used as an additional identifier for documents
        /// </summary>
        /// <value>This attribute can be used as an additional identifier for documents</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets DocumentVersion
        /// </summary>
        [DataMember(Name="document_version", EmitDefaultValue=false)]
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Date must be in format &#x27;YYYY-MM-DD&#x27;
        /// </summary>
        /// <value>Date must be in format &#x27;YYYY-MM-DD&#x27;</value>
        [DataMember(Name="valid_from", EmitDefaultValue=false)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// Date must be in format &#x27;YYYY-MM-DD&#x27;
        /// </summary>
        /// <value>Date must be in format &#x27;YYYY-MM-DD&#x27;</value>
        [DataMember(Name="valid_until", EmitDefaultValue=false)]
        public string ValidUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBase {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
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
            return this.Equals(input as DocumentBase);
        }

        /// <summary>
        /// Returns true if DocumentBase instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.DocumentVersion == input.DocumentVersion ||
                    (this.DocumentVersion != null &&
                    this.DocumentVersion.Equals(input.DocumentVersion))
                ) && 
                (
                    this.ValidFrom == input.ValidFrom ||
                    (this.ValidFrom != null &&
                    this.ValidFrom.Equals(input.ValidFrom))
                ) && 
                (
                    this.ValidUntil == input.ValidUntil ||
                    (this.ValidUntil != null &&
                    this.ValidUntil.Equals(input.ValidUntil))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.DocumentVersion != null)
                    hashCode = hashCode * 59 + this.DocumentVersion.GetHashCode();
                if (this.ValidFrom != null)
                    hashCode = hashCode * 59 + this.ValidFrom.GetHashCode();
                if (this.ValidUntil != null)
                    hashCode = hashCode * 59 + this.ValidUntil.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
