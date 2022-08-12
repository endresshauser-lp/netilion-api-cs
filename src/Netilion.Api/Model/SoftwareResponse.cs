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
    /// SoftwareResponse
    /// </summary>
    [DataContract]
        public partial class SoftwareResponse :  IEquatable<SoftwareResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareResponse" /> class.
        /// </summary>
        /// <param name="id">Id of object (required).</param>
        /// <param name="versionNumber">versionNumber (required).</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="tenant">tenant (required).</param>
        /// <param name="softwareType">softwareType (required).</param>
        /// <param name="links">links (required).</param>
        public SoftwareResponse(long? id = default(long?), string versionNumber = default(string), string name = default(string), string description = default(string), NestedIDHref tenant = default(NestedIDHref), SoftwareResponseSoftwareType softwareType = default(SoftwareResponseSoftwareType), Links20 links = default(Links20))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SoftwareResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "versionNumber" is required (not null)
            if (versionNumber == null)
            {
                throw new InvalidDataException("versionNumber is a required property for SoftwareResponse and cannot be null");
            }
            else
            {
                this.VersionNumber = versionNumber;
            }
            // to ensure "tenant" is required (not null)
            if (tenant == null)
            {
                throw new InvalidDataException("tenant is a required property for SoftwareResponse and cannot be null");
            }
            else
            {
                this.Tenant = tenant;
            }
            // to ensure "softwareType" is required (not null)
            if (softwareType == null)
            {
                throw new InvalidDataException("softwareType is a required property for SoftwareResponse and cannot be null");
            }
            else
            {
                this.SoftwareType = softwareType;
            }
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new InvalidDataException("links is a required property for SoftwareResponse and cannot be null");
            }
            else
            {
                this.Links = links;
            }
            this.Name = name;
            this.Description = description;
        }
        
        /// <summary>
        /// Id of object
        /// </summary>
        /// <value>Id of object</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name="version_number", EmitDefaultValue=false)]
        public string VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name="tenant", EmitDefaultValue=false)]
        public NestedIDHref Tenant { get; set; }

        /// <summary>
        /// Gets or Sets SoftwareType
        /// </summary>
        [DataMember(Name="software_type", EmitDefaultValue=false)]
        public SoftwareResponseSoftwareType SoftwareType { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Links20 Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SoftwareResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  SoftwareType: ").Append(SoftwareType).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as SoftwareResponse);
        }

        /// <summary>
        /// Returns true if SoftwareResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SoftwareResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SoftwareResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    (this.VersionNumber != null &&
                    this.VersionNumber.Equals(input.VersionNumber))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.SoftwareType == input.SoftwareType ||
                    (this.SoftwareType != null &&
                    this.SoftwareType.Equals(input.SoftwareType))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VersionNumber != null)
                    hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.SoftwareType != null)
                    hashCode = hashCode * 59 + this.SoftwareType.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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
