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
    /// Links7
    /// </summary>
    [DataContract]
        public partial class Links7 :  IEquatable<Links7>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Links7" /> class.
        /// </summary>
        /// <param name="features">features.</param>
        /// <param name="edgeDeviceApplicationTypes">edgeDeviceApplicationTypes.</param>
        public Links7(Link features = default(Link), Link edgeDeviceApplicationTypes = default(Link))
        {
            this.Features = features;
            this.EdgeDeviceApplicationTypes = edgeDeviceApplicationTypes;
        }
        
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public Link Features { get; set; }

        /// <summary>
        /// Gets or Sets EdgeDeviceApplicationTypes
        /// </summary>
        [DataMember(Name="edge_device_application_types", EmitDefaultValue=false)]
        public Link EdgeDeviceApplicationTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Links7 {\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  EdgeDeviceApplicationTypes: ").Append(EdgeDeviceApplicationTypes).Append("\n");
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
            return this.Equals(input as Links7);
        }

        /// <summary>
        /// Returns true if Links7 instances are equal
        /// </summary>
        /// <param name="input">Instance of Links7 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Links7 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Features == input.Features ||
                    (this.Features != null &&
                    this.Features.Equals(input.Features))
                ) && 
                (
                    this.EdgeDeviceApplicationTypes == input.EdgeDeviceApplicationTypes ||
                    (this.EdgeDeviceApplicationTypes != null &&
                    this.EdgeDeviceApplicationTypes.Equals(input.EdgeDeviceApplicationTypes))
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
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.EdgeDeviceApplicationTypes != null)
                    hashCode = hashCode * 59 + this.EdgeDeviceApplicationTypes.GetHashCode();
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
