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
    /// AssetHealthConditionsCalculateRequest
    /// </summary>
    [DataContract]
        public partial class AssetHealthConditionsCalculateRequest :  IEquatable<AssetHealthConditionsCalculateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetHealthConditionsCalculateRequest" /> class.
        /// </summary>
        /// <param name="protocol">possible values: HART, PROFIBUS, ETHERNETIP, MODBUS, OTHERS (required).</param>
        /// <param name="protocolVersion">definition of the protocol version. For example 5, 6 or 7 for HART.</param>
        /// <param name="diagnosisMessage">diagnosis message to use for the calculation (required).</param>
        /// <param name="deviceIdent">the protocol dependent device identifier, mandatory for HART and PROFIBUS protocol.</param>
        /// <param name="productIdentifier">the protocol dependent product identifier, mandatory for HART and PROFIBUS protocol.</param>
        public AssetHealthConditionsCalculateRequest(string protocol = default(string), string protocolVersion = default(string), string diagnosisMessage = default(string), string deviceIdent = default(string), string productIdentifier = default(string))
        {
            // to ensure "protocol" is required (not null)
            if (protocol == null)
            {
                throw new InvalidDataException("protocol is a required property for AssetHealthConditionsCalculateRequest and cannot be null");
            }
            else
            {
                this.Protocol = protocol;
            }
            // to ensure "diagnosisMessage" is required (not null)
            if (diagnosisMessage == null)
            {
                throw new InvalidDataException("diagnosisMessage is a required property for AssetHealthConditionsCalculateRequest and cannot be null");
            }
            else
            {
                this.DiagnosisMessage = diagnosisMessage;
            }
            this.ProtocolVersion = protocolVersion;
            this.DeviceIdent = deviceIdent;
            this.ProductIdentifier = productIdentifier;
        }
        
        /// <summary>
        /// possible values: HART, PROFIBUS, ETHERNETIP, MODBUS, OTHERS
        /// </summary>
        /// <value>possible values: HART, PROFIBUS, ETHERNETIP, MODBUS, OTHERS</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// definition of the protocol version. For example 5, 6 or 7 for HART
        /// </summary>
        /// <value>definition of the protocol version. For example 5, 6 or 7 for HART</value>
        [DataMember(Name="protocol_version", EmitDefaultValue=false)]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// diagnosis message to use for the calculation
        /// </summary>
        /// <value>diagnosis message to use for the calculation</value>
        [DataMember(Name="diagnosis_message", EmitDefaultValue=false)]
        public string DiagnosisMessage { get; set; }

        /// <summary>
        /// the protocol dependent device identifier, mandatory for HART and PROFIBUS protocol
        /// </summary>
        /// <value>the protocol dependent device identifier, mandatory for HART and PROFIBUS protocol</value>
        [DataMember(Name="device_ident", EmitDefaultValue=false)]
        public string DeviceIdent { get; set; }

        /// <summary>
        /// the protocol dependent product identifier, mandatory for HART and PROFIBUS protocol
        /// </summary>
        /// <value>the protocol dependent product identifier, mandatory for HART and PROFIBUS protocol</value>
        [DataMember(Name="product_identifier", EmitDefaultValue=false)]
        public string ProductIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetHealthConditionsCalculateRequest {\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  ProtocolVersion: ").Append(ProtocolVersion).Append("\n");
            sb.Append("  DiagnosisMessage: ").Append(DiagnosisMessage).Append("\n");
            sb.Append("  DeviceIdent: ").Append(DeviceIdent).Append("\n");
            sb.Append("  ProductIdentifier: ").Append(ProductIdentifier).Append("\n");
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
            return this.Equals(input as AssetHealthConditionsCalculateRequest);
        }

        /// <summary>
        /// Returns true if AssetHealthConditionsCalculateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetHealthConditionsCalculateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetHealthConditionsCalculateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.ProtocolVersion == input.ProtocolVersion ||
                    (this.ProtocolVersion != null &&
                    this.ProtocolVersion.Equals(input.ProtocolVersion))
                ) && 
                (
                    this.DiagnosisMessage == input.DiagnosisMessage ||
                    (this.DiagnosisMessage != null &&
                    this.DiagnosisMessage.Equals(input.DiagnosisMessage))
                ) && 
                (
                    this.DeviceIdent == input.DeviceIdent ||
                    (this.DeviceIdent != null &&
                    this.DeviceIdent.Equals(input.DeviceIdent))
                ) && 
                (
                    this.ProductIdentifier == input.ProductIdentifier ||
                    (this.ProductIdentifier != null &&
                    this.ProductIdentifier.Equals(input.ProductIdentifier))
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
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.ProtocolVersion != null)
                    hashCode = hashCode * 59 + this.ProtocolVersion.GetHashCode();
                if (this.DiagnosisMessage != null)
                    hashCode = hashCode * 59 + this.DiagnosisMessage.GetHashCode();
                if (this.DeviceIdent != null)
                    hashCode = hashCode * 59 + this.DeviceIdent.GetHashCode();
                if (this.ProductIdentifier != null)
                    hashCode = hashCode * 59 + this.ProductIdentifier.GetHashCode();
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
