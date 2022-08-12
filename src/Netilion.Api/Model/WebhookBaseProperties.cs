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
    /// Event types which user needs to subscribe with attributes of each event type as an array
    /// </summary>
    [DataContract]
        public partial class WebhookBaseProperties :  IEquatable<WebhookBaseProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBaseProperties" /> class.
        /// </summary>
        /// <param name="eventType">event type to configure (required).</param>
        public WebhookBaseProperties(List<string> eventType = default(List<string>))
        {
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new InvalidDataException("eventType is a required property for WebhookBaseProperties and cannot be null");
            }
            else
            {
                this.EventType = eventType;
            }
        }
        
        /// <summary>
        /// event type to configure
        /// </summary>
        /// <value>event type to configure</value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public List<string> EventType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookBaseProperties {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
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
            return this.Equals(input as WebhookBaseProperties);
        }

        /// <summary>
        /// Returns true if WebhookBaseProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookBaseProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookBaseProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    this.EventType != null &&
                    input.EventType != null &&
                    this.EventType.SequenceEqual(input.EventType)
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
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
