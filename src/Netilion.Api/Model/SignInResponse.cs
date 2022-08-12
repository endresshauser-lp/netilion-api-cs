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
    /// SignInResponse
    /// </summary>
    [DataContract]
        public partial class SignInResponse :  IEquatable<SignInResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignInResponse" /> class.
        /// </summary>
        /// <param name="time">time at which the user signed in (required).</param>
        /// <param name="application">name of the application the user signed in (required).</param>
        /// <param name="ip">remote ip used by the user (required).</param>
        /// <param name="browserName">name of the used browser.</param>
        /// <param name="browserVersion">version of the used browser.</param>
        /// <param name="deviceType">type of the used device (desktop, tablet or mobile).</param>
        /// <param name="platformName">name of the used platform.</param>
        /// <param name="platformVersion">version of the used platform.</param>
        /// <param name="clientApplication">clientApplication.</param>
        public SignInResponse(string time = default(string), string application = default(string), string ip = default(string), string browserName = default(string), string browserVersion = default(string), string deviceType = default(string), string platformName = default(string), string platformVersion = default(string), NestedIDHrefName clientApplication = default(NestedIDHrefName))
        {
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for SignInResponse and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            // to ensure "application" is required (not null)
            if (application == null)
            {
                throw new InvalidDataException("application is a required property for SignInResponse and cannot be null");
            }
            else
            {
                this.Application = application;
            }
            // to ensure "ip" is required (not null)
            if (ip == null)
            {
                throw new InvalidDataException("ip is a required property for SignInResponse and cannot be null");
            }
            else
            {
                this.Ip = ip;
            }
            this.BrowserName = browserName;
            this.BrowserVersion = browserVersion;
            this.DeviceType = deviceType;
            this.PlatformName = platformName;
            this.PlatformVersion = platformVersion;
            this.ClientApplication = clientApplication;
        }
        
        /// <summary>
        /// time at which the user signed in
        /// </summary>
        /// <value>time at which the user signed in</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// name of the application the user signed in
        /// </summary>
        /// <value>name of the application the user signed in</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public string Application { get; set; }

        /// <summary>
        /// remote ip used by the user
        /// </summary>
        /// <value>remote ip used by the user</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// name of the used browser
        /// </summary>
        /// <value>name of the used browser</value>
        [DataMember(Name="browser_name", EmitDefaultValue=false)]
        public string BrowserName { get; set; }

        /// <summary>
        /// version of the used browser
        /// </summary>
        /// <value>version of the used browser</value>
        [DataMember(Name="browser_version", EmitDefaultValue=false)]
        public string BrowserVersion { get; set; }

        /// <summary>
        /// type of the used device (desktop, tablet or mobile)
        /// </summary>
        /// <value>type of the used device (desktop, tablet or mobile)</value>
        [DataMember(Name="device_type", EmitDefaultValue=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// name of the used platform
        /// </summary>
        /// <value>name of the used platform</value>
        [DataMember(Name="platform_name", EmitDefaultValue=false)]
        public string PlatformName { get; set; }

        /// <summary>
        /// version of the used platform
        /// </summary>
        /// <value>version of the used platform</value>
        [DataMember(Name="platform_version", EmitDefaultValue=false)]
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Gets or Sets ClientApplication
        /// </summary>
        [DataMember(Name="client_application", EmitDefaultValue=false)]
        public NestedIDHrefName ClientApplication { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignInResponse {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  BrowserName: ").Append(BrowserName).Append("\n");
            sb.Append("  BrowserVersion: ").Append(BrowserVersion).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  PlatformName: ").Append(PlatformName).Append("\n");
            sb.Append("  PlatformVersion: ").Append(PlatformVersion).Append("\n");
            sb.Append("  ClientApplication: ").Append(ClientApplication).Append("\n");
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
            return this.Equals(input as SignInResponse);
        }

        /// <summary>
        /// Returns true if SignInResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SignInResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignInResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.BrowserName == input.BrowserName ||
                    (this.BrowserName != null &&
                    this.BrowserName.Equals(input.BrowserName))
                ) && 
                (
                    this.BrowserVersion == input.BrowserVersion ||
                    (this.BrowserVersion != null &&
                    this.BrowserVersion.Equals(input.BrowserVersion))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.PlatformName == input.PlatformName ||
                    (this.PlatformName != null &&
                    this.PlatformName.Equals(input.PlatformName))
                ) && 
                (
                    this.PlatformVersion == input.PlatformVersion ||
                    (this.PlatformVersion != null &&
                    this.PlatformVersion.Equals(input.PlatformVersion))
                ) && 
                (
                    this.ClientApplication == input.ClientApplication ||
                    (this.ClientApplication != null &&
                    this.ClientApplication.Equals(input.ClientApplication))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.BrowserName != null)
                    hashCode = hashCode * 59 + this.BrowserName.GetHashCode();
                if (this.BrowserVersion != null)
                    hashCode = hashCode * 59 + this.BrowserVersion.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.PlatformName != null)
                    hashCode = hashCode * 59 + this.PlatformName.GetHashCode();
                if (this.PlatformVersion != null)
                    hashCode = hashCode * 59 + this.PlatformVersion.GetHashCode();
                if (this.ClientApplication != null)
                    hashCode = hashCode * 59 + this.ClientApplication.GetHashCode();
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
