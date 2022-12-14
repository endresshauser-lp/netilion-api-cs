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
    /// APISubscriptionRequest
    /// </summary>
    [DataContract]
        public partial class APISubscriptionRequest : APISubscriptionBase,  IEquatable<APISubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISubscriptionRequest" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="clientApplication">clientApplication.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        public APISubscriptionRequest(NestedID user = default(NestedID), NestedID clientApplication = default(NestedID), BillingAddressRequest billingAddress = default(BillingAddressRequest), ShippingAddressRequest shippingAddress = default(ShippingAddressRequest), string displayName = default(string), string description = default(string), string externalReference = default(string), string status = default(string), string notificationStatus = default(string), string subscriptionType = default(string), string customerPurchaseOrder = default(string), string startDate = default(string), string endDate = default(string), string billedUntil = default(string), string externalUserReference = default(string), string externalPlanVariantReference = default(string), int? apiCallQuota = default(int?), int? storageQuota = default(int?), int? numberAssignedAssets = default(int?), int? connectedAssetsUsed = default(int?), int? uploadDownloadQuota = default(int?), int? connectedAssetQuota = default(int?), int? apiCallsUsed = default(int?), int? storageUsed = default(int?), int? uploadDownloadUsed = default(int?)) : base(displayName, description, externalReference, status, notificationStatus, subscriptionType, customerPurchaseOrder, startDate, endDate, billedUntil, externalUserReference, externalPlanVariantReference, apiCallQuota, storageQuota, numberAssignedAssets, connectedAssetsUsed, uploadDownloadQuota, connectedAssetQuota, apiCallsUsed, storageUsed, uploadDownloadUsed)
        {
            this.User = user;
            this.ClientApplication = clientApplication;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
        }
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public NestedID User { get; set; }

        /// <summary>
        /// Gets or Sets ClientApplication
        /// </summary>
        [DataMember(Name="client_application", EmitDefaultValue=false)]
        public NestedID ClientApplication { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public BillingAddressRequest BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shipping_address", EmitDefaultValue=false)]
        public ShippingAddressRequest ShippingAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APISubscriptionRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ClientApplication: ").Append(ClientApplication).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
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
            return this.Equals(input as APISubscriptionRequest);
        }

        /// <summary>
        /// Returns true if APISubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of APISubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APISubscriptionRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && base.Equals(input) && 
                (
                    this.ClientApplication == input.ClientApplication ||
                    (this.ClientApplication != null &&
                    this.ClientApplication.Equals(input.ClientApplication))
                ) && base.Equals(input) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && base.Equals(input) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.ClientApplication != null)
                    hashCode = hashCode * 59 + this.ClientApplication.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
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
