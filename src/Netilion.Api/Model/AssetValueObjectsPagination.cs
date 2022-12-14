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
    /// AssetValueObjectsPagination
    /// </summary>
    [DataContract]
        public partial class AssetValueObjectsPagination :  IEquatable<AssetValueObjectsPagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetValueObjectsPagination" /> class.
        /// </summary>
        /// <param name="totalCount">data items in the result (required).</param>
        /// <param name="pageCount">number of pages (required).</param>
        /// <param name="perPage">items per page (required).</param>
        /// <param name="page">current page (required).</param>
        /// <param name="prev">The link for the immediate previous page for the data..</param>
        /// <param name="next">The link for the immediate next page for the data..</param>
        /// <param name="first">The link for the first page for the data..</param>
        /// <param name="last">The link for the last page for the data..</param>
        public AssetValueObjectsPagination(int? totalCount = default(int?), int? pageCount = default(int?), int? perPage = default(int?), int? page = default(int?), string prev = default(string), string next = default(string), string first = default(string), string last = default(string))
        {
            // to ensure "totalCount" is required (not null)
            if (totalCount == null)
            {
                throw new InvalidDataException("totalCount is a required property for AssetValueObjectsPagination and cannot be null");
            }
            else
            {
                this.TotalCount = totalCount;
            }
            // to ensure "pageCount" is required (not null)
            if (pageCount == null)
            {
                throw new InvalidDataException("pageCount is a required property for AssetValueObjectsPagination and cannot be null");
            }
            else
            {
                this.PageCount = pageCount;
            }
            // to ensure "perPage" is required (not null)
            if (perPage == null)
            {
                throw new InvalidDataException("perPage is a required property for AssetValueObjectsPagination and cannot be null");
            }
            else
            {
                this.PerPage = perPage;
            }
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for AssetValueObjectsPagination and cannot be null");
            }
            else
            {
                this.Page = page;
            }
            this.Prev = prev;
            this.Next = next;
            this.First = first;
            this.Last = last;
        }
        
        /// <summary>
        /// data items in the result
        /// </summary>
        /// <value>data items in the result</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// number of pages
        /// </summary>
        /// <value>number of pages</value>
        [DataMember(Name="page_count", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// items per page
        /// </summary>
        /// <value>items per page</value>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public int? PerPage { get; set; }

        /// <summary>
        /// current page
        /// </summary>
        /// <value>current page</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The link for the immediate previous page for the data.
        /// </summary>
        /// <value>The link for the immediate previous page for the data.</value>
        [DataMember(Name="prev", EmitDefaultValue=false)]
        public string Prev { get; set; }

        /// <summary>
        /// The link for the immediate next page for the data.
        /// </summary>
        /// <value>The link for the immediate next page for the data.</value>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// The link for the first page for the data.
        /// </summary>
        /// <value>The link for the first page for the data.</value>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public string First { get; set; }

        /// <summary>
        /// The link for the last page for the data.
        /// </summary>
        /// <value>The link for the last page for the data.</value>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public string Last { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetValueObjectsPagination {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
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
            return this.Equals(input as AssetValueObjectsPagination);
        }

        /// <summary>
        /// Returns true if AssetValueObjectsPagination instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetValueObjectsPagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetValueObjectsPagination input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Prev == input.Prev ||
                    (this.Prev != null &&
                    this.Prev.Equals(input.Prev))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Prev != null)
                    hashCode = hashCode * 59 + this.Prev.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
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
