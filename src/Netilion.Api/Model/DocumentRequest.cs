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
    /// DocumentRequest
    /// </summary>
    [DataContract]
        public partial class DocumentRequest : DocumentBase,  IEquatable<DocumentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentRequest" /> class.
        /// </summary>
        /// <param name="classification">classification.</param>
        /// <param name="status">status.</param>
        /// <param name="tenant">tenant.</param>
        public DocumentRequest(NestedID classification = default(NestedID), NestedID status = default(NestedID), NestedID tenant = default(NestedID), string name = default(string), string description = default(string), string number = default(string), string documentVersion = default(string), string validFrom = default(string), string validUntil = default(string)) : base(name, description, number, documentVersion, validFrom, validUntil)
        {
            this.Classification = classification;
            this.Status = status;
            this.Tenant = tenant;
        }
        
        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public NestedID Classification { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public NestedID Status { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name="tenant", EmitDefaultValue=false)]
        public NestedID Tenant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DocumentRequest);
        }

        /// <summary>
        /// Returns true if DocumentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
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
                int hashCode = base.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
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
