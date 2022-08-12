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
    /// CompanyAddressResponse
    /// </summary>
    [DataContract]
        public partial class CompanyAddressResponse : AddressBase,  IEquatable<CompanyAddressResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyAddressResponse" /> class.
        /// </summary>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="email">email.</param>
        /// <param name="countryName">name of the country.</param>
        public CompanyAddressResponse(string firstName = default(string), string lastName = default(string), string email = default(string), string countryName = default(string), string street = default(string), string streetNumber = default(string), string zipCode = default(string), string city = default(string), string regionCode = default(string), string countryCode = default(string), string phone = default(string), string companyName = default(string)) : base(street, streetNumber, zipCode, city, regionCode, countryCode, phone, companyName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.CountryName = countryName;
        }
        
        /// <summary>
        /// first_name
        /// </summary>
        /// <value>first_name</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// last_name
        /// </summary>
        /// <value>last_name</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// email
        /// </summary>
        /// <value>email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// name of the country
        /// </summary>
        /// <value>name of the country</value>
        [DataMember(Name="country_name", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyAddressResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
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
            return this.Equals(input as CompanyAddressResponse);
        }

        /// <summary>
        /// Returns true if CompanyAddressResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyAddressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyAddressResponse input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && base.Equals(input) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
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
