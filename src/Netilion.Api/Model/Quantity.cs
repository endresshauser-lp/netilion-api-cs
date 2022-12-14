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
    /// Quantity
    /// </summary>
    [DataContract]
        public partial class Quantity :  IEquatable<Quantity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity" /> class.
        /// </summary>
        /// <param name="id">Id of the nested resource (required).</param>
        /// <param name="quantity">Quantity of the nested resource (required).</param>
        public Quantity(long? id = default(long?), long? quantity = default(long?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Quantity and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for Quantity and cannot be null");
            }
            else
            {
                this._Quantity = quantity;
            }
        }
        
        /// <summary>
        /// Id of the nested resource
        /// </summary>
        /// <value>Id of the nested resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Quantity of the nested resource
        /// </summary>
        /// <value>Quantity of the nested resource</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public long? _Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quantity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Quantity: ").Append(_Quantity).Append("\n");
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
            return this.Equals(input as Quantity);
        }

        /// <summary>
        /// Returns true if Quantity instances are equal
        /// </summary>
        /// <param name="input">Instance of Quantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quantity input)
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
                    this._Quantity == input._Quantity ||
                    (this._Quantity != null &&
                    this._Quantity.Equals(input._Quantity))
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
                if (this._Quantity != null)
                    hashCode = hashCode * 59 + this._Quantity.GetHashCode();
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
