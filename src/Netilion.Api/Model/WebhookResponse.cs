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
    /// WebhookResponse
    /// </summary>
    [DataContract]
        public partial class WebhookResponse :  IEquatable<WebhookResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResponse" /> class.
        /// </summary>
        /// <param name="url">url of the webhook (required).</param>
        /// <param name="eventTypes">Array of event types to be subscribed. (required).</param>
        /// <param name="properties">properties.</param>
        /// <param name="disabled">Disables the webhook. (default to false).</param>
        public WebhookResponse(string url = default(string), List<string> eventTypes = default(List<string>), WebhookBaseProperties properties = default(WebhookBaseProperties), bool? disabled = false)
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "eventTypes" is required (not null)
            if (eventTypes == null)
            {
                throw new InvalidDataException("eventTypes is a required property for WebhookResponse and cannot be null");
            }
            else
            {
                this.EventTypes = eventTypes;
            }
            this.Properties = properties;
            // use default value if no "disabled" provided
            if (disabled == null)
            {
                this.Disabled = false;
            }
            else
            {
                this.Disabled = disabled;
            }
        }
        
        /// <summary>
        /// url of the webhook
        /// </summary>
        /// <value>url of the webhook</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Array of event types to be subscribed.
        /// </summary>
        /// <value>Array of event types to be subscribed.</value>
        [DataMember(Name="event_types", EmitDefaultValue=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public WebhookBaseProperties Properties { get; set; }

        /// <summary>
        /// Disables the webhook.
        /// </summary>
        /// <value>Disables the webhook.</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookResponse {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
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
            return this.Equals(input as WebhookResponse);
        }

        /// <summary>
        /// Returns true if WebhookResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.EventTypes == input.EventTypes ||
                    this.EventTypes != null &&
                    input.EventTypes != null &&
                    this.EventTypes.SequenceEqual(input.EventTypes)
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.EventTypes != null)
                    hashCode = hashCode * 59 + this.EventTypes.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
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
