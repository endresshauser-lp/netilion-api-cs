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
    /// EdgeDevicesIds
    /// </summary>
    [DataContract]
        public partial class EdgeDevicesIds :  IEquatable<EdgeDevicesIds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeDevicesIds" /> class.
        /// </summary>
        /// <param name="edgeDevices">edgeDevices (required).</param>
        public EdgeDevicesIds(List<NestedID> edgeDevices = default(List<NestedID>))
        {
            // to ensure "edgeDevices" is required (not null)
            if (edgeDevices == null)
            {
                throw new InvalidDataException("edgeDevices is a required property for EdgeDevicesIds and cannot be null");
            }
            else
            {
                this.EdgeDevices = edgeDevices;
            }
        }
        
        /// <summary>
        /// Gets or Sets EdgeDevices
        /// </summary>
        [DataMember(Name="edge_devices", EmitDefaultValue=false)]
        public List<NestedID> EdgeDevices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeDevicesIds {\n");
            sb.Append("  EdgeDevices: ").Append(EdgeDevices).Append("\n");
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
            return this.Equals(input as EdgeDevicesIds);
        }

        /// <summary>
        /// Returns true if EdgeDevicesIds instances are equal
        /// </summary>
        /// <param name="input">Instance of EdgeDevicesIds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeDevicesIds input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EdgeDevices == input.EdgeDevices ||
                    this.EdgeDevices != null &&
                    input.EdgeDevices != null &&
                    this.EdgeDevices.SequenceEqual(input.EdgeDevices)
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
                if (this.EdgeDevices != null)
                    hashCode = hashCode * 59 + this.EdgeDevices.GetHashCode();
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
