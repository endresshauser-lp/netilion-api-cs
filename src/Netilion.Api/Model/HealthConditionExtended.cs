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
    /// HealthConditionExtended
    /// </summary>
    [DataContract]
        public partial class HealthConditionExtended : HealthConditionBase,  IEquatable<HealthConditionExtended>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthConditionExtended" /> class.
        /// </summary>
        /// <param name="protocol">Possible values are: &#x27;PROFIBUS&#x27;, &#x27;HART&#x27; and &#x27;MODBUS&#x27;..</param>
        /// <param name="protocolVersion">version number of the protocol.</param>
        /// <param name="deviceIdent">protocol specific device_ident.</param>
        /// <param name="productIdentifier">protocol specific product_identifier.</param>
        /// <param name="hidden">should be hidden in frontend (default to false).</param>
        /// <param name="rules">Health condition rules..</param>
        public HealthConditionExtended(string protocol = default(string), string protocolVersion = default(string), string deviceIdent = default(string), string productIdentifier = default(string), bool? hidden = false, List<HealthConditionExtendedRules> rules = default(List<HealthConditionExtendedRules>), string diagnosisCode = default(string)) : base(diagnosisCode)
        {
            this.Protocol = protocol;
            this.ProtocolVersion = protocolVersion;
            this.DeviceIdent = deviceIdent;
            this.ProductIdentifier = productIdentifier;
            // use default value if no "hidden" provided
            if (hidden == null)
            {
                this.Hidden = false;
            }
            else
            {
                this.Hidden = hidden;
            }
            this.Rules = rules;
        }
        
        /// <summary>
        /// Possible values are: &#x27;PROFIBUS&#x27;, &#x27;HART&#x27; and &#x27;MODBUS&#x27;.
        /// </summary>
        /// <value>Possible values are: &#x27;PROFIBUS&#x27;, &#x27;HART&#x27; and &#x27;MODBUS&#x27;.</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// version number of the protocol
        /// </summary>
        /// <value>version number of the protocol</value>
        [DataMember(Name="protocol_version", EmitDefaultValue=false)]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// protocol specific device_ident
        /// </summary>
        /// <value>protocol specific device_ident</value>
        [DataMember(Name="device_ident", EmitDefaultValue=false)]
        public string DeviceIdent { get; set; }

        /// <summary>
        /// protocol specific product_identifier
        /// </summary>
        /// <value>protocol specific product_identifier</value>
        [DataMember(Name="product_identifier", EmitDefaultValue=false)]
        public string ProductIdentifier { get; set; }

        /// <summary>
        /// should be hidden in frontend
        /// </summary>
        /// <value>should be hidden in frontend</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Health condition rules.
        /// </summary>
        /// <value>Health condition rules.</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<HealthConditionExtendedRules> Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HealthConditionExtended {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  ProtocolVersion: ").Append(ProtocolVersion).Append("\n");
            sb.Append("  DeviceIdent: ").Append(DeviceIdent).Append("\n");
            sb.Append("  ProductIdentifier: ").Append(ProductIdentifier).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return this.Equals(input as HealthConditionExtended);
        }

        /// <summary>
        /// Returns true if HealthConditionExtended instances are equal
        /// </summary>
        /// <param name="input">Instance of HealthConditionExtended to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthConditionExtended input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && base.Equals(input) && 
                (
                    this.ProtocolVersion == input.ProtocolVersion ||
                    (this.ProtocolVersion != null &&
                    this.ProtocolVersion.Equals(input.ProtocolVersion))
                ) && base.Equals(input) && 
                (
                    this.DeviceIdent == input.DeviceIdent ||
                    (this.DeviceIdent != null &&
                    this.DeviceIdent.Equals(input.DeviceIdent))
                ) && base.Equals(input) && 
                (
                    this.ProductIdentifier == input.ProductIdentifier ||
                    (this.ProductIdentifier != null &&
                    this.ProductIdentifier.Equals(input.ProductIdentifier))
                ) && base.Equals(input) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && base.Equals(input) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
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
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.ProtocolVersion != null)
                    hashCode = hashCode * 59 + this.ProtocolVersion.GetHashCode();
                if (this.DeviceIdent != null)
                    hashCode = hashCode * 59 + this.DeviceIdent.GetHashCode();
                if (this.ProductIdentifier != null)
                    hashCode = hashCode * 59 + this.ProductIdentifier.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
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
