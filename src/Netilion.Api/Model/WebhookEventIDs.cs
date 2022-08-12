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
    /// WebhookEventIDs
    /// </summary>
    [DataContract]
        public partial class WebhookEventIDs :  IEquatable<WebhookEventIDs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventIDs" /> class.
        /// </summary>
        /// <param name="webhookEvents">webhookEvents (required).</param>
        public WebhookEventIDs(List<NestedID> webhookEvents = default(List<NestedID>))
        {
            // to ensure "webhookEvents" is required (not null)
            if (webhookEvents == null)
            {
                throw new InvalidDataException("webhookEvents is a required property for WebhookEventIDs and cannot be null");
            }
            else
            {
                this.WebhookEvents = webhookEvents;
            }
        }
        
        /// <summary>
        /// Gets or Sets WebhookEvents
        /// </summary>
        [DataMember(Name="webhook_events", EmitDefaultValue=false)]
        public List<NestedID> WebhookEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEventIDs {\n");
            sb.Append("  WebhookEvents: ").Append(WebhookEvents).Append("\n");
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
            return this.Equals(input as WebhookEventIDs);
        }

        /// <summary>
        /// Returns true if WebhookEventIDs instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEventIDs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventIDs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebhookEvents == input.WebhookEvents ||
                    this.WebhookEvents != null &&
                    input.WebhookEvents != null &&
                    this.WebhookEvents.SequenceEqual(input.WebhookEvents)
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
                if (this.WebhookEvents != null)
                    hashCode = hashCode * 59 + this.WebhookEvents.GetHashCode();
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
