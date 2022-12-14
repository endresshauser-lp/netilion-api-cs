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
    /// Links2
    /// </summary>
    [DataContract]
        public partial class Links2 :  IEquatable<Links2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Links2" /> class.
        /// </summary>
        /// <param name="documents">documents.</param>
        /// <param name="events">events.</param>
        /// <param name="nodes">nodes.</param>
        /// <param name="instrumentations">instrumentations.</param>
        /// <param name="systems">systems.</param>
        /// <param name="pictures">pictures.</param>
        /// <param name="specifications">specifications.</param>
        /// <param name="subscriptions">subscriptions.</param>
        /// <param name="apiSubscriptions">apiSubscriptions.</param>
        /// <param name="healthConditions">healthConditions.</param>
        public Links2(Link documents = default(Link), Link events = default(Link), Link nodes = default(Link), Link instrumentations = default(Link), Link systems = default(Link), Link pictures = default(Link), Link specifications = default(Link), Link subscriptions = default(Link), Link apiSubscriptions = default(Link), Link healthConditions = default(Link))
        {
            this.Documents = documents;
            this.Events = events;
            this.Nodes = nodes;
            this.Instrumentations = instrumentations;
            this.Systems = systems;
            this.Pictures = pictures;
            this.Specifications = specifications;
            this.Subscriptions = subscriptions;
            this.ApiSubscriptions = apiSubscriptions;
            this.HealthConditions = healthConditions;
        }
        
        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public Link Documents { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public Link Events { get; set; }

        /// <summary>
        /// Gets or Sets Nodes
        /// </summary>
        [DataMember(Name="nodes", EmitDefaultValue=false)]
        public Link Nodes { get; set; }

        /// <summary>
        /// Gets or Sets Instrumentations
        /// </summary>
        [DataMember(Name="instrumentations", EmitDefaultValue=false)]
        public Link Instrumentations { get; set; }

        /// <summary>
        /// Gets or Sets Systems
        /// </summary>
        [DataMember(Name="systems", EmitDefaultValue=false)]
        public Link Systems { get; set; }

        /// <summary>
        /// Gets or Sets Pictures
        /// </summary>
        [DataMember(Name="pictures", EmitDefaultValue=false)]
        public Link Pictures { get; set; }

        /// <summary>
        /// Gets or Sets Specifications
        /// </summary>
        [DataMember(Name="specifications", EmitDefaultValue=false)]
        public Link Specifications { get; set; }

        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name="subscriptions", EmitDefaultValue=false)]
        public Link Subscriptions { get; set; }

        /// <summary>
        /// Gets or Sets ApiSubscriptions
        /// </summary>
        [DataMember(Name="api_subscriptions", EmitDefaultValue=false)]
        public Link ApiSubscriptions { get; set; }

        /// <summary>
        /// Gets or Sets HealthConditions
        /// </summary>
        [DataMember(Name="health_conditions", EmitDefaultValue=false)]
        public Link HealthConditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Links2 {\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  Instrumentations: ").Append(Instrumentations).Append("\n");
            sb.Append("  Systems: ").Append(Systems).Append("\n");
            sb.Append("  Pictures: ").Append(Pictures).Append("\n");
            sb.Append("  Specifications: ").Append(Specifications).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  ApiSubscriptions: ").Append(ApiSubscriptions).Append("\n");
            sb.Append("  HealthConditions: ").Append(HealthConditions).Append("\n");
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
            return this.Equals(input as Links2);
        }

        /// <summary>
        /// Returns true if Links2 instances are equal
        /// </summary>
        /// <param name="input">Instance of Links2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Links2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Documents == input.Documents ||
                    (this.Documents != null &&
                    this.Documents.Equals(input.Documents))
                ) && 
                (
                    this.Events == input.Events ||
                    (this.Events != null &&
                    this.Events.Equals(input.Events))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    (this.Nodes != null &&
                    this.Nodes.Equals(input.Nodes))
                ) && 
                (
                    this.Instrumentations == input.Instrumentations ||
                    (this.Instrumentations != null &&
                    this.Instrumentations.Equals(input.Instrumentations))
                ) && 
                (
                    this.Systems == input.Systems ||
                    (this.Systems != null &&
                    this.Systems.Equals(input.Systems))
                ) && 
                (
                    this.Pictures == input.Pictures ||
                    (this.Pictures != null &&
                    this.Pictures.Equals(input.Pictures))
                ) && 
                (
                    this.Specifications == input.Specifications ||
                    (this.Specifications != null &&
                    this.Specifications.Equals(input.Specifications))
                ) && 
                (
                    this.Subscriptions == input.Subscriptions ||
                    (this.Subscriptions != null &&
                    this.Subscriptions.Equals(input.Subscriptions))
                ) && 
                (
                    this.ApiSubscriptions == input.ApiSubscriptions ||
                    (this.ApiSubscriptions != null &&
                    this.ApiSubscriptions.Equals(input.ApiSubscriptions))
                ) && 
                (
                    this.HealthConditions == input.HealthConditions ||
                    (this.HealthConditions != null &&
                    this.HealthConditions.Equals(input.HealthConditions))
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
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Instrumentations != null)
                    hashCode = hashCode * 59 + this.Instrumentations.GetHashCode();
                if (this.Systems != null)
                    hashCode = hashCode * 59 + this.Systems.GetHashCode();
                if (this.Pictures != null)
                    hashCode = hashCode * 59 + this.Pictures.GetHashCode();
                if (this.Specifications != null)
                    hashCode = hashCode * 59 + this.Specifications.GetHashCode();
                if (this.Subscriptions != null)
                    hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                if (this.ApiSubscriptions != null)
                    hashCode = hashCode * 59 + this.ApiSubscriptions.GetHashCode();
                if (this.HealthConditions != null)
                    hashCode = hashCode * 59 + this.HealthConditions.GetHashCode();
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
