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
    /// DeliveryRequest
    /// </summary>
    [DataContract]
        public partial class DeliveryRequest : DeliveryBase,  IEquatable<DeliveryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryRequest" /> class.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="receiver">receiver.</param>
        /// <param name="status">status.</param>
        public DeliveryRequest(NestedID sender = default(NestedID), NestedID receiver = default(NestedID), NestedID status = default(NestedID), string number = default(string), string name = default(string), string customerNumber = default(string), string description = default(string), string dateOfShipment = default(string)) : base(number, name, customerNumber, description, dateOfShipment)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public NestedID Sender { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name="receiver", EmitDefaultValue=false)]
        public NestedID Receiver { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public NestedID Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as DeliveryRequest);
        }

        /// <summary>
        /// Returns true if DeliveryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && base.Equals(input) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Receiver != null)
                    hashCode = hashCode * 59 + this.Receiver.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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