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
    /// PermissionRequestCreateRequest
    /// </summary>
    [DataContract]
        public partial class PermissionRequestCreateRequest :  IEquatable<PermissionRequestCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionRequestCreateRequest" /> class.
        /// </summary>
        /// <param name="requestMessage">message to the owners.</param>
        /// <param name="asset">asset (required).</param>
        public PermissionRequestCreateRequest(string requestMessage = default(string), PermissionRequestCreateRequestAsset asset = default(PermissionRequestCreateRequestAsset))
        {
            // to ensure "asset" is required (not null)
            if (asset == null)
            {
                throw new InvalidDataException("asset is a required property for PermissionRequestCreateRequest and cannot be null");
            }
            else
            {
                this.Asset = asset;
            }
            this.RequestMessage = requestMessage;
        }
        
        /// <summary>
        /// message to the owners
        /// </summary>
        /// <value>message to the owners</value>
        [DataMember(Name="request_message", EmitDefaultValue=false)]
        public string RequestMessage { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name="asset", EmitDefaultValue=false)]
        public PermissionRequestCreateRequestAsset Asset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionRequestCreateRequest {\n");
            sb.Append("  RequestMessage: ").Append(RequestMessage).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
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
            return this.Equals(input as PermissionRequestCreateRequest);
        }

        /// <summary>
        /// Returns true if PermissionRequestCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionRequestCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionRequestCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestMessage == input.RequestMessage ||
                    (this.RequestMessage != null &&
                    this.RequestMessage.Equals(input.RequestMessage))
                ) && 
                (
                    this.Asset == input.Asset ||
                    (this.Asset != null &&
                    this.Asset.Equals(input.Asset))
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
                if (this.RequestMessage != null)
                    hashCode = hashCode * 59 + this.RequestMessage.GetHashCode();
                if (this.Asset != null)
                    hashCode = hashCode * 59 + this.Asset.GetHashCode();
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
