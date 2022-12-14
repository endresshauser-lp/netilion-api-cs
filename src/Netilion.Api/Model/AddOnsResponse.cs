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
    /// AddOnsResponse
    /// </summary>
    [DataContract]
        public partial class AddOnsResponse :  IEquatable<AddOnsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnsResponse" /> class.
        /// </summary>
        /// <param name="addOns">addOns (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public AddOnsResponse(List<AddOnResponse> addOns = default(List<AddOnResponse>), Pagination pagination = default(Pagination))
        {
            // to ensure "addOns" is required (not null)
            if (addOns == null)
            {
                throw new InvalidDataException("addOns is a required property for AddOnsResponse and cannot be null");
            }
            else
            {
                this.AddOns = addOns;
            }
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new InvalidDataException("pagination is a required property for AddOnsResponse and cannot be null");
            }
            else
            {
                this.Pagination = pagination;
            }
        }
        
        /// <summary>
        /// Gets or Sets AddOns
        /// </summary>
        [DataMember(Name="add_ons", EmitDefaultValue=false)]
        public List<AddOnResponse> AddOns { get; set; }

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
            sb.Append("class AddOnsResponse {\n");
            sb.Append("  AddOns: ").Append(AddOns).Append("\n");
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
            return this.Equals(input as AddOnsResponse);
        }

        /// <summary>
        /// Returns true if AddOnsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AddOnsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddOnsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddOns == input.AddOns ||
                    this.AddOns != null &&
                    input.AddOns != null &&
                    this.AddOns.SequenceEqual(input.AddOns)
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
                if (this.AddOns != null)
                    hashCode = hashCode * 59 + this.AddOns.GetHashCode();
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
