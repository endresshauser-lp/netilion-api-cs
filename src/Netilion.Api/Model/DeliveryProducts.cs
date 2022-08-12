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
    /// DeliveryProducts
    /// </summary>
    [DataContract]
        public partial class DeliveryProducts :  IEquatable<DeliveryProducts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryProducts" /> class.
        /// </summary>
        /// <param name="productId">Id of the object (required).</param>
        /// <param name="productCode">product code (required).</param>
        /// <param name="quantity">quantity of the product with this delivery (required).</param>
        /// <param name="assets">assets.</param>
        public DeliveryProducts(long? productId = default(long?), string productCode = default(string), long? quantity = default(long?), List<DeliveryProductsAssets> assets = default(List<DeliveryProductsAssets>))
        {
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for DeliveryProducts and cannot be null");
            }
            else
            {
                this.ProductId = productId;
            }
            // to ensure "productCode" is required (not null)
            if (productCode == null)
            {
                throw new InvalidDataException("productCode is a required property for DeliveryProducts and cannot be null");
            }
            else
            {
                this.ProductCode = productCode;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for DeliveryProducts and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            this.Assets = assets;
        }
        
        /// <summary>
        /// Id of the object
        /// </summary>
        /// <value>Id of the object</value>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// product code
        /// </summary>
        /// <value>product code</value>
        [DataMember(Name="product_code", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// quantity of the product with this delivery
        /// </summary>
        /// <value>quantity of the product with this delivery</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// Link to get collection of related objects
        /// </summary>
        /// <value>Link to get collection of related objects</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; private set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name="assets", EmitDefaultValue=false)]
        public List<DeliveryProductsAssets> Assets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryProducts {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
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
            return this.Equals(input as DeliveryProducts);
        }

        /// <summary>
        /// Returns true if DeliveryProducts instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryProducts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryProducts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Assets == input.Assets ||
                    this.Assets != null &&
                    input.Assets != null &&
                    this.Assets.SequenceEqual(input.Assets)
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Assets != null)
                    hashCode = hashCode * 59 + this.Assets.GetHashCode();
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
