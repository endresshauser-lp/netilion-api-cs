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
    /// UserRoleIDs
    /// </summary>
    [DataContract]
        public partial class UserRoleIDs :  IEquatable<UserRoleIDs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleIDs" /> class.
        /// </summary>
        /// <param name="userroles">userroles (required).</param>
        public UserRoleIDs(List<NestedID> userroles = default(List<NestedID>))
        {
            // to ensure "userroles" is required (not null)
            if (userroles == null)
            {
                throw new InvalidDataException("userroles is a required property for UserRoleIDs and cannot be null");
            }
            else
            {
                this.Userroles = userroles;
            }
        }
        
        /// <summary>
        /// Gets or Sets Userroles
        /// </summary>
        [DataMember(Name="userroles", EmitDefaultValue=false)]
        public List<NestedID> Userroles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRoleIDs {\n");
            sb.Append("  Userroles: ").Append(Userroles).Append("\n");
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
            return this.Equals(input as UserRoleIDs);
        }

        /// <summary>
        /// Returns true if UserRoleIDs instances are equal
        /// </summary>
        /// <param name="input">Instance of UserRoleIDs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRoleIDs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Userroles == input.Userroles ||
                    this.Userroles != null &&
                    input.Userroles != null &&
                    this.Userroles.SequenceEqual(input.Userroles)
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
                if (this.Userroles != null)
                    hashCode = hashCode * 59 + this.Userroles.GetHashCode();
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
