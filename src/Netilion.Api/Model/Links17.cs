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
    /// Links17
    /// </summary>
    [DataContract]
        public partial class Links17 :  IEquatable<Links17>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Links17" /> class.
        /// </summary>
        /// <param name="products">products.</param>
        /// <param name="purchaseOrders">purchaseOrders.</param>
        /// <param name="documents">documents.</param>
        public Links17(Link products = default(Link), Link purchaseOrders = default(Link), Link documents = default(Link))
        {
            this.Products = products;
            this.PurchaseOrders = purchaseOrders;
            this.Documents = documents;
        }
        
        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="products", EmitDefaultValue=false)]
        public Link Products { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrders
        /// </summary>
        [DataMember(Name="purchase_orders", EmitDefaultValue=false)]
        public Link PurchaseOrders { get; set; }

        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public Link Documents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Links17 {\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  PurchaseOrders: ").Append(PurchaseOrders).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
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
            return this.Equals(input as Links17);
        }

        /// <summary>
        /// Returns true if Links17 instances are equal
        /// </summary>
        /// <param name="input">Instance of Links17 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Links17 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Products == input.Products ||
                    (this.Products != null &&
                    this.Products.Equals(input.Products))
                ) && 
                (
                    this.PurchaseOrders == input.PurchaseOrders ||
                    (this.PurchaseOrders != null &&
                    this.PurchaseOrders.Equals(input.PurchaseOrders))
                ) && 
                (
                    this.Documents == input.Documents ||
                    (this.Documents != null &&
                    this.Documents.Equals(input.Documents))
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
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.PurchaseOrders != null)
                    hashCode = hashCode * 59 + this.PurchaseOrders.GetHashCode();
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
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
