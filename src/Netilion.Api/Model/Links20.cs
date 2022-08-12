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
    /// Links20
    /// </summary>
    [DataContract]
        public partial class Links20 :  IEquatable<Links20>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Links20" /> class.
        /// </summary>
        /// <param name="softwareAttachments">softwareAttachments.</param>
        public Links20(Link softwareAttachments = default(Link))
        {
            this.SoftwareAttachments = softwareAttachments;
        }
        
        /// <summary>
        /// Gets or Sets SoftwareAttachments
        /// </summary>
        [DataMember(Name="software_attachments", EmitDefaultValue=false)]
        public Link SoftwareAttachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Links20 {\n");
            sb.Append("  SoftwareAttachments: ").Append(SoftwareAttachments).Append("\n");
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
            return this.Equals(input as Links20);
        }

        /// <summary>
        /// Returns true if Links20 instances are equal
        /// </summary>
        /// <param name="input">Instance of Links20 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Links20 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SoftwareAttachments == input.SoftwareAttachments ||
                    (this.SoftwareAttachments != null &&
                    this.SoftwareAttachments.Equals(input.SoftwareAttachments))
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
                if (this.SoftwareAttachments != null)
                    hashCode = hashCode * 59 + this.SoftwareAttachments.GetHashCode();
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