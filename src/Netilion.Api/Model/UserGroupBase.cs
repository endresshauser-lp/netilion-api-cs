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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Netilion.Api.Client.SwaggerDateConverter;

namespace Netilion.Api.Model
{
    /// <summary>
    /// UserGroupBase
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "userGroupBaseType")]
    [JsonSubtypes.KnownSubType(typeof(UserGroupWithUsers), "UserGroupWithUsers")]
    [JsonSubtypes.KnownSubType(typeof(UserGroupRequest), "UserGroupRequest")]
    [JsonSubtypes.KnownSubType(typeof(UserGroupResponse), "UserGroupResponse")]
        public partial class UserGroupBase :  IEquatable<UserGroupBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupBase" /> class.
        /// </summary>
        /// <param name="name">Name must be unique. Max length is 60 characters. Whitespaces are trimmed. (required).</param>
        /// <param name="description">Details about the user group..</param>
        public UserGroupBase(string name = default(string), string description = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UserGroupBase and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Description = description;
        }
        
        /// <summary>
        /// Name must be unique. Max length is 60 characters. Whitespaces are trimmed.
        /// </summary>
        /// <value>Name must be unique. Max length is 60 characters. Whitespaces are trimmed.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Details about the user group.
        /// </summary>
        /// <value>Details about the user group.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserGroupBase {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as UserGroupBase);
        }

        /// <summary>
        /// Returns true if UserGroupBase instances are equal
        /// </summary>
        /// <param name="input">Instance of UserGroupBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserGroupBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
