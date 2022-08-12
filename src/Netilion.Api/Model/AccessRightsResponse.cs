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
    /// AccessRightsResponse
    /// </summary>
    [DataContract]
        public partial class AccessRightsResponse :  IEquatable<AccessRightsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRightsResponse" /> class.
        /// </summary>
        /// <param name="canRead">canRead.</param>
        /// <param name="canUpdate">canUpdate.</param>
        /// <param name="canDelete">canDelete.</param>
        /// <param name="canPermit">canPermit.</param>
        public AccessRightsResponse(bool? canRead = default(bool?), bool? canUpdate = default(bool?), bool? canDelete = default(bool?), bool? canPermit = default(bool?))
        {
            this.CanRead = canRead;
            this.CanUpdate = canUpdate;
            this.CanDelete = canDelete;
            this.CanPermit = canPermit;
        }
        
        /// <summary>
        /// Gets or Sets CanRead
        /// </summary>
        [DataMember(Name="can_read", EmitDefaultValue=false)]
        public bool? CanRead { get; set; }

        /// <summary>
        /// Gets or Sets CanUpdate
        /// </summary>
        [DataMember(Name="can_update", EmitDefaultValue=false)]
        public bool? CanUpdate { get; set; }

        /// <summary>
        /// Gets or Sets CanDelete
        /// </summary>
        [DataMember(Name="can_delete", EmitDefaultValue=false)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// Gets or Sets CanPermit
        /// </summary>
        [DataMember(Name="can_permit", EmitDefaultValue=false)]
        public bool? CanPermit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRightsResponse {\n");
            sb.Append("  CanRead: ").Append(CanRead).Append("\n");
            sb.Append("  CanUpdate: ").Append(CanUpdate).Append("\n");
            sb.Append("  CanDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  CanPermit: ").Append(CanPermit).Append("\n");
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
            return this.Equals(input as AccessRightsResponse);
        }

        /// <summary>
        /// Returns true if AccessRightsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRightsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRightsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanRead == input.CanRead ||
                    (this.CanRead != null &&
                    this.CanRead.Equals(input.CanRead))
                ) && 
                (
                    this.CanUpdate == input.CanUpdate ||
                    (this.CanUpdate != null &&
                    this.CanUpdate.Equals(input.CanUpdate))
                ) && 
                (
                    this.CanDelete == input.CanDelete ||
                    (this.CanDelete != null &&
                    this.CanDelete.Equals(input.CanDelete))
                ) && 
                (
                    this.CanPermit == input.CanPermit ||
                    (this.CanPermit != null &&
                    this.CanPermit.Equals(input.CanPermit))
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
                if (this.CanRead != null)
                    hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                if (this.CanUpdate != null)
                    hashCode = hashCode * 59 + this.CanUpdate.GetHashCode();
                if (this.CanDelete != null)
                    hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanPermit != null)
                    hashCode = hashCode * 59 + this.CanPermit.GetHashCode();
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
