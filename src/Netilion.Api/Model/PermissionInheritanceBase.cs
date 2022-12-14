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
    /// PermissionInheritanceBase
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "permissionInheritanceBaseType")]
    [JsonSubtypes.KnownSubType(typeof(PermissionInheritanceResponse), "PermissionInheritanceResponse")]
    [JsonSubtypes.KnownSubType(typeof(PermissionInheritanceRequest), "PermissionInheritanceRequest")]
        public partial class PermissionInheritanceBase :  IEquatable<PermissionInheritanceBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionInheritanceBase" /> class.
        /// </summary>
        /// <param name="permissionType">possible values are: &#x27;can_read&#x27;, &#x27;can_update&#x27;, &#x27;can_delete&#x27; and &#x27;can_permit&#x27;.</param>
        /// <param name="inheritance">define if permission should be inheritated or not.</param>
        /// <param name="permissionInheritable">permissionInheritable.</param>
        public PermissionInheritanceBase(string permissionType = default(string), bool? inheritance = default(bool?), PermissionInheritable permissionInheritable = default(PermissionInheritable))
        {
            this.PermissionType = permissionType;
            this.Inheritance = inheritance;
            this.PermissionInheritable = permissionInheritable;
        }
        
        /// <summary>
        /// possible values are: &#x27;can_read&#x27;, &#x27;can_update&#x27;, &#x27;can_delete&#x27; and &#x27;can_permit&#x27;
        /// </summary>
        /// <value>possible values are: &#x27;can_read&#x27;, &#x27;can_update&#x27;, &#x27;can_delete&#x27; and &#x27;can_permit&#x27;</value>
        [DataMember(Name="permission_type", EmitDefaultValue=false)]
        public string PermissionType { get; set; }

        /// <summary>
        /// define if permission should be inheritated or not
        /// </summary>
        /// <value>define if permission should be inheritated or not</value>
        [DataMember(Name="inheritance", EmitDefaultValue=false)]
        public bool? Inheritance { get; set; }

        /// <summary>
        /// Gets or Sets PermissionInheritable
        /// </summary>
        [DataMember(Name="permission_inheritable", EmitDefaultValue=false)]
        public PermissionInheritable PermissionInheritable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionInheritanceBase {\n");
            sb.Append("  PermissionType: ").Append(PermissionType).Append("\n");
            sb.Append("  Inheritance: ").Append(Inheritance).Append("\n");
            sb.Append("  PermissionInheritable: ").Append(PermissionInheritable).Append("\n");
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
            return this.Equals(input as PermissionInheritanceBase);
        }

        /// <summary>
        /// Returns true if PermissionInheritanceBase instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionInheritanceBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionInheritanceBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PermissionType == input.PermissionType ||
                    (this.PermissionType != null &&
                    this.PermissionType.Equals(input.PermissionType))
                ) && 
                (
                    this.Inheritance == input.Inheritance ||
                    (this.Inheritance != null &&
                    this.Inheritance.Equals(input.Inheritance))
                ) && 
                (
                    this.PermissionInheritable == input.PermissionInheritable ||
                    (this.PermissionInheritable != null &&
                    this.PermissionInheritable.Equals(input.PermissionInheritable))
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
                if (this.PermissionType != null)
                    hashCode = hashCode * 59 + this.PermissionType.GetHashCode();
                if (this.Inheritance != null)
                    hashCode = hashCode * 59 + this.Inheritance.GetHashCode();
                if (this.PermissionInheritable != null)
                    hashCode = hashCode * 59 + this.PermissionInheritable.GetHashCode();
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
