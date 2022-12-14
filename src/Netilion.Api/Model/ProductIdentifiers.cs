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
    /// ProductIdentifiers
    /// </summary>
    [DataContract]
        public partial class ProductIdentifiers :  IEquatable<ProductIdentifiers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="_ProductIdentifiers" /> class.
        /// </summary>
        /// <param name="productIdentifiers">productIdentifiers (required).</param>
        public ProductIdentifiers(List<NestedID> productIdentifiers = default(List<NestedID>))
        {
            // to ensure "productIdentifiers" is required (not null)
            if (productIdentifiers == null)
            {
                throw new InvalidDataException("productIdentifiers is a required property for ProductIdentifiers and cannot be null");
            }
            else
            {
                this._ProductIdentifiers = productIdentifiers;
            }
        }
        
        /// <summary>
        /// Gets or Sets ProductIdentifiers
        /// </summary>
        [DataMember(Name="product_identifiers", EmitDefaultValue=false)]
        public List<NestedID> _ProductIdentifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductIdentifiers {\n");
            sb.Append("  ProductIdentifiers: ").Append(_ProductIdentifiers).Append("\n");
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
            return this.Equals(input as ProductIdentifiers);
        }

        /// <summary>
        /// Returns true if ProductIdentifiers instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductIdentifiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductIdentifiers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._ProductIdentifiers == input._ProductIdentifiers ||
                    this._ProductIdentifiers != null &&
                    input._ProductIdentifiers != null &&
                    this._ProductIdentifiers.SequenceEqual(input._ProductIdentifiers)
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
                if (this._ProductIdentifiers != null)
                    hashCode = hashCode * 59 + this._ProductIdentifiers.GetHashCode();
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
