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
    /// SparePartIDs
    /// </summary>
    [DataContract]
        public partial class SparePartIDs :  IEquatable<SparePartIDs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SparePartIDs" /> class.
        /// </summary>
        /// <param name="spareParts">spareParts (required).</param>
        public SparePartIDs(List<NestedID> spareParts = default(List<NestedID>))
        {
            // to ensure "spareParts" is required (not null)
            if (spareParts == null)
            {
                throw new InvalidDataException("spareParts is a required property for SparePartIDs and cannot be null");
            }
            else
            {
                this.SpareParts = spareParts;
            }
        }
        
        /// <summary>
        /// Gets or Sets SpareParts
        /// </summary>
        [DataMember(Name="spare_parts", EmitDefaultValue=false)]
        public List<NestedID> SpareParts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SparePartIDs {\n");
            sb.Append("  SpareParts: ").Append(SpareParts).Append("\n");
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
            return this.Equals(input as SparePartIDs);
        }

        /// <summary>
        /// Returns true if SparePartIDs instances are equal
        /// </summary>
        /// <param name="input">Instance of SparePartIDs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SparePartIDs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpareParts == input.SpareParts ||
                    this.SpareParts != null &&
                    input.SpareParts != null &&
                    this.SpareParts.SequenceEqual(input.SpareParts)
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
                if (this.SpareParts != null)
                    hashCode = hashCode * 59 + this.SpareParts.GetHashCode();
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
