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
    /// DocumentClassifications
    /// </summary>
    [DataContract]
        public partial class DocumentClassifications :  IEquatable<DocumentClassifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentClassifications" /> class.
        /// </summary>
        /// <param name="documentClassifications">documentClassifications.</param>
        /// <param name="pagination">pagination.</param>
        public DocumentClassifications(List<DocumentClassificationResponse> documentClassifications = default(List<DocumentClassificationResponse>), Pagination pagination = default(Pagination))
        {
            this.DocumentClassifications = documentClassifications;
            this.Pagination = pagination;
        }
        
        /// <summary>
        /// Gets or Sets DocumentClassifications
        /// </summary>
        [DataMember(Name="document_classifications", EmitDefaultValue=false)]
        public List<DocumentClassificationResponse> DocumentClassifications { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentClassifications {\n");
            sb.Append("  DocumentClassifications: ").Append(DocumentClassifications).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as DocumentClassifications);
        }

        /// <summary>
        /// Returns true if DocumentClassifications instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentClassifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentClassifications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentClassifications == input.DocumentClassifications ||
                    this.DocumentClassifications != null &&
                    input.DocumentClassifications != null &&
                    this.DocumentClassifications.SequenceEqual(input.DocumentClassifications)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.DocumentClassifications != null)
                    hashCode = hashCode * 59 + this.DocumentClassifications.GetHashCode();
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
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
