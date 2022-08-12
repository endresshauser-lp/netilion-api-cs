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
    /// PurchaseOrderBase
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "purchaseOrderBaseType")]
    [JsonSubtypes.KnownSubType(typeof(PurchaseOrderResponse), "PurchaseOrderResponse")]
    [JsonSubtypes.KnownSubType(typeof(PurchaseOrderRequest), "PurchaseOrderRequest")]
        public partial class PurchaseOrderBase :  IEquatable<PurchaseOrderBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderBase" /> class.
        /// </summary>
        /// <param name="number">number (required).</param>
        /// <param name="customerNumber">customer number the purchase order was sold to.</param>
        /// <param name="customerPurchaseOrderNumber">customerPurchaseOrderNumber.</param>
        /// <param name="name">name.</param>
        /// <param name="date">Date must be in format &#x27;2016-01-01&#x27;.</param>
        /// <param name="description">description.</param>
        /// <param name="status">status.</param>
        /// <param name="sender">sender.</param>
        /// <param name="receiver">receiver.</param>
        /// <param name="quotation">quotation.</param>
        public PurchaseOrderBase(string number = default(string), string customerNumber = default(string), string customerPurchaseOrderNumber = default(string), string name = default(string), string date = default(string), string description = default(string), NestedID status = default(NestedID), NestedID sender = default(NestedID), NestedID receiver = default(NestedID), NestedID quotation = default(NestedID))
        {
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for PurchaseOrderBase and cannot be null");
            }
            else
            {
                this.Number = number;
            }
            this.CustomerNumber = customerNumber;
            this.CustomerPurchaseOrderNumber = customerPurchaseOrderNumber;
            this.Name = name;
            this.Date = date;
            this.Description = description;
            this.Status = status;
            this.Sender = sender;
            this.Receiver = receiver;
            this.Quotation = quotation;
        }
        
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// customer number the purchase order was sold to
        /// </summary>
        /// <value>customer number the purchase order was sold to</value>
        [DataMember(Name="customer_number", EmitDefaultValue=false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Gets or Sets CustomerPurchaseOrderNumber
        /// </summary>
        [DataMember(Name="customer_purchase_order_number", EmitDefaultValue=false)]
        public string CustomerPurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Date must be in format &#x27;2016-01-01&#x27;
        /// </summary>
        /// <value>Date must be in format &#x27;2016-01-01&#x27;</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public NestedID Status { get; set; }

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
        /// Gets or Sets Quotation
        /// </summary>
        [DataMember(Name="quotation", EmitDefaultValue=false)]
        public NestedID Quotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseOrderBase {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
            sb.Append("  CustomerPurchaseOrderNumber: ").Append(CustomerPurchaseOrderNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Quotation: ").Append(Quotation).Append("\n");
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
            return this.Equals(input as PurchaseOrderBase);
        }

        /// <summary>
        /// Returns true if PurchaseOrderBase instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseOrderBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrderBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.CustomerNumber == input.CustomerNumber ||
                    (this.CustomerNumber != null &&
                    this.CustomerNumber.Equals(input.CustomerNumber))
                ) && 
                (
                    this.CustomerPurchaseOrderNumber == input.CustomerPurchaseOrderNumber ||
                    (this.CustomerPurchaseOrderNumber != null &&
                    this.CustomerPurchaseOrderNumber.Equals(input.CustomerPurchaseOrderNumber))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && 
                (
                    this.Quotation == input.Quotation ||
                    (this.Quotation != null &&
                    this.Quotation.Equals(input.Quotation))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.CustomerNumber != null)
                    hashCode = hashCode * 59 + this.CustomerNumber.GetHashCode();
                if (this.CustomerPurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.CustomerPurchaseOrderNumber.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Receiver != null)
                    hashCode = hashCode * 59 + this.Receiver.GetHashCode();
                if (this.Quotation != null)
                    hashCode = hashCode * 59 + this.Quotation.GetHashCode();
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