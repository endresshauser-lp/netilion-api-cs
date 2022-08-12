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
    /// AssetHealthConditionTimemachine
    /// </summary>
    [DataContract]
        public partial class AssetHealthConditionTimemachine :  IEquatable<AssetHealthConditionTimemachine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetHealthConditionTimemachine" /> class.
        /// </summary>
        /// <param name="healthCondition">healthCondition (required).</param>
        /// <param name="createdDatetime">Date of the Create Event (required).</param>
        /// <param name="deletedDatetime">Date of the Destroy Event (required).</param>
        public AssetHealthConditionTimemachine(AssetHealthConditionNested healthCondition = default(AssetHealthConditionNested), DateTime? createdDatetime = default(DateTime?), DateTime? deletedDatetime = default(DateTime?))
        {
            // to ensure "healthCondition" is required (not null)
            if (healthCondition == null)
            {
                throw new InvalidDataException("healthCondition is a required property for AssetHealthConditionTimemachine and cannot be null");
            }
            else
            {
                this.HealthCondition = healthCondition;
            }
            // to ensure "createdDatetime" is required (not null)
            if (createdDatetime == null)
            {
                throw new InvalidDataException("createdDatetime is a required property for AssetHealthConditionTimemachine and cannot be null");
            }
            else
            {
                this.CreatedDatetime = createdDatetime;
            }
            // to ensure "deletedDatetime" is required (not null)
            if (deletedDatetime == null)
            {
                throw new InvalidDataException("deletedDatetime is a required property for AssetHealthConditionTimemachine and cannot be null");
            }
            else
            {
                this.DeletedDatetime = deletedDatetime;
            }
        }
        
        /// <summary>
        /// Gets or Sets HealthCondition
        /// </summary>
        [DataMember(Name="health_condition", EmitDefaultValue=false)]
        public AssetHealthConditionNested HealthCondition { get; set; }

        /// <summary>
        /// Date of the Create Event
        /// </summary>
        /// <value>Date of the Create Event</value>
        [DataMember(Name="created_datetime", EmitDefaultValue=false)]
        public DateTime? CreatedDatetime { get; set; }

        /// <summary>
        /// Date of the Destroy Event
        /// </summary>
        /// <value>Date of the Destroy Event</value>
        [DataMember(Name="deleted_datetime", EmitDefaultValue=false)]
        public DateTime? DeletedDatetime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetHealthConditionTimemachine {\n");
            sb.Append("  HealthCondition: ").Append(HealthCondition).Append("\n");
            sb.Append("  CreatedDatetime: ").Append(CreatedDatetime).Append("\n");
            sb.Append("  DeletedDatetime: ").Append(DeletedDatetime).Append("\n");
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
            return this.Equals(input as AssetHealthConditionTimemachine);
        }

        /// <summary>
        /// Returns true if AssetHealthConditionTimemachine instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetHealthConditionTimemachine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetHealthConditionTimemachine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HealthCondition == input.HealthCondition ||
                    (this.HealthCondition != null &&
                    this.HealthCondition.Equals(input.HealthCondition))
                ) && 
                (
                    this.CreatedDatetime == input.CreatedDatetime ||
                    (this.CreatedDatetime != null &&
                    this.CreatedDatetime.Equals(input.CreatedDatetime))
                ) && 
                (
                    this.DeletedDatetime == input.DeletedDatetime ||
                    (this.DeletedDatetime != null &&
                    this.DeletedDatetime.Equals(input.DeletedDatetime))
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
                if (this.HealthCondition != null)
                    hashCode = hashCode * 59 + this.HealthCondition.GetHashCode();
                if (this.CreatedDatetime != null)
                    hashCode = hashCode * 59 + this.CreatedDatetime.GetHashCode();
                if (this.DeletedDatetime != null)
                    hashCode = hashCode * 59 + this.DeletedDatetime.GetHashCode();
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