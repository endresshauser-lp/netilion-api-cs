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
    /// Companies1
    /// </summary>
    [DataContract]
        public partial class Companies1 :  IEquatable<Companies1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Companies1" /> class.
        /// </summary>
        /// <param name="companies">companies (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public Companies1(List<CompanyResponse> companies = default(List<CompanyResponse>), Pagination pagination = default(Pagination))
        {
            // to ensure "companies" is required (not null)
            if (companies == null)
            {
                throw new InvalidDataException("companies is a required property for Companies1 and cannot be null");
            }
            else
            {
                this.Companies = companies;
            }
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new InvalidDataException("pagination is a required property for Companies1 and cannot be null");
            }
            else
            {
                this.Pagination = pagination;
            }
        }
        
        /// <summary>
        /// Gets or Sets Companies
        /// </summary>
        [DataMember(Name="companies", EmitDefaultValue=false)]
        public List<CompanyResponse> Companies { get; set; }

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
            sb.Append("class Companies1 {\n");
            sb.Append("  Companies: ").Append(Companies).Append("\n");
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
            return this.Equals(input as Companies1);
        }

        /// <summary>
        /// Returns true if Companies1 instances are equal
        /// </summary>
        /// <param name="input">Instance of Companies1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Companies1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Companies == input.Companies ||
                    this.Companies != null &&
                    input.Companies != null &&
                    this.Companies.SequenceEqual(input.Companies)
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
                if (this.Companies != null)
                    hashCode = hashCode * 59 + this.Companies.GetHashCode();
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