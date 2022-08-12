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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Netilion.Api.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ISearchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// search assets, batches, instrumentations, nodes, recipes, systems .
        /// </summary>
        /// <remarks>
        /// search assets, instrumentations and nodes based on a defined set of fields.   asset - serial_number product_code product_name product_manufacturer_name   specification keys and values (of assets, nodes and instrumentation) when ui_visible is set to true   batches - batch_name      instrumentation - tag   nodes - name   recipes - recipe_name      systems - system_name    These fields may be extended in the  future.
        /// </remarks>
        /// <exception cref="Netilion.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">search query</param>
        /// <param name="page">Page number to load (optional)</param>
        /// <param name="perPage">Number of items to load per page (optional)</param>
        /// <param name="manufacturerId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="productCategoryId">One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). (optional)</param>
        /// <param name="productStatusId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="subscriptionId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="scope">One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. (optional)</param>
        /// <param name="acceptLanguage">The client&#x27;s accepted languages. One or several (e.g. fr,de,en) (optional)</param>
        /// <returns>SearchItemsResponse</returns>
        SearchItemsResponse Search (string q, int? page = null, int? perPage = null, string manufacturerId = null, string productCategoryId = null, string productStatusId = null, string subscriptionId = null, string scope = null, string acceptLanguage = null);

        /// <summary>
        /// search assets, batches, instrumentations, nodes, recipes, systems .
        /// </summary>
        /// <remarks>
        /// search assets, instrumentations and nodes based on a defined set of fields.   asset - serial_number product_code product_name product_manufacturer_name   specification keys and values (of assets, nodes and instrumentation) when ui_visible is set to true   batches - batch_name      instrumentation - tag   nodes - name   recipes - recipe_name      systems - system_name    These fields may be extended in the  future.
        /// </remarks>
        /// <exception cref="Netilion.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">search query</param>
        /// <param name="page">Page number to load (optional)</param>
        /// <param name="perPage">Number of items to load per page (optional)</param>
        /// <param name="manufacturerId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="productCategoryId">One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). (optional)</param>
        /// <param name="productStatusId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="subscriptionId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="scope">One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. (optional)</param>
        /// <param name="acceptLanguage">The client&#x27;s accepted languages. One or several (e.g. fr,de,en) (optional)</param>
        /// <returns>ApiResponse of SearchItemsResponse</returns>
        ApiResponse<SearchItemsResponse> SearchWithHttpInfo (string q, int? page = null, int? perPage = null, string manufacturerId = null, string productCategoryId = null, string productStatusId = null, string subscriptionId = null, string scope = null, string acceptLanguage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// search assets, batches, instrumentations, nodes, recipes, systems .
        /// </summary>
        /// <remarks>
        /// search assets, instrumentations and nodes based on a defined set of fields.   asset - serial_number product_code product_name product_manufacturer_name   specification keys and values (of assets, nodes and instrumentation) when ui_visible is set to true   batches - batch_name      instrumentation - tag   nodes - name   recipes - recipe_name      systems - system_name    These fields may be extended in the  future.
        /// </remarks>
        /// <exception cref="Netilion.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">search query</param>
        /// <param name="page">Page number to load (optional)</param>
        /// <param name="perPage">Number of items to load per page (optional)</param>
        /// <param name="manufacturerId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="productCategoryId">One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). (optional)</param>
        /// <param name="productStatusId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="subscriptionId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="scope">One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. (optional)</param>
        /// <param name="acceptLanguage">The client&#x27;s accepted languages. One or several (e.g. fr,de,en) (optional)</param>
        /// <returns>Task of SearchItemsResponse</returns>
        System.Threading.Tasks.Task<SearchItemsResponse> SearchAsync (string q, int? page = null, int? perPage = null, string manufacturerId = null, string productCategoryId = null, string productStatusId = null, string subscriptionId = null, string scope = null, string acceptLanguage = null);

        /// <summary>
        /// search assets, batches, instrumentations, nodes, recipes, systems .
        /// </summary>
        /// <remarks>
        /// search assets, instrumentations and nodes based on a defined set of fields.   asset - serial_number product_code product_name product_manufacturer_name   specification keys and values (of assets, nodes and instrumentation) when ui_visible is set to true   batches - batch_name      instrumentation - tag   nodes - name   recipes - recipe_name      systems - system_name    These fields may be extended in the  future.
        /// </remarks>
        /// <exception cref="Netilion.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">search query</param>
        /// <param name="page">Page number to load (optional)</param>
        /// <param name="perPage">Number of items to load per page (optional)</param>
        /// <param name="manufacturerId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="productCategoryId">One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). (optional)</param>
        /// <param name="productStatusId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="subscriptionId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="scope">One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. (optional)</param>
        /// <param name="acceptLanguage">The client&#x27;s accepted languages. One or several (e.g. fr,de,en) (optional)</param>
        /// <returns>Task of ApiResponse (SearchItemsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SearchItemsResponse>> SearchAsyncWithHttpInfo (string q, int? page = null, int? perPage = null, string manufacturerId = null, string productCategoryId = null, string productStatusId = null, string subscriptionId = null, string scope = null, string acceptLanguage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class SearchApi : ISearchApi
    {
        private Netilion.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
        {
            this.Configuration = new Netilion.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Netilion.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// </summary>
        /// <returns></returns>
        public SearchApi()
        {
            this.Configuration = Netilion.Api.Client.Configuration.Default;

            ExceptionFactory = Netilion.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchApi(Netilion.Api.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Netilion.Api.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Netilion.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Netilion.Api.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Netilion.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// search assets, batches, instrumentations, nodes, recipes, systems . search assets, instrumentations and nodes based on a defined set of fields.   asset - serial_number product_code product_name product_manufacturer_name   specification keys and values (of assets, nodes and instrumentation) when ui_visible is set to true   batches - batch_name      instrumentation - tag   nodes - name   recipes - recipe_name      systems - system_name    These fields may be extended in the  future.
        /// </summary>
        /// <exception cref="Netilion.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">search query</param>
        /// <param name="page">Page number to load (optional)</param>
        /// <param name="perPage">Number of items to load per page (optional)</param>
        /// <param name="manufacturerId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="productCategoryId">One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). (optional)</param>
        /// <param name="productStatusId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="subscriptionId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="scope">One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. (optional)</param>
        /// <param name="acceptLanguage">The client&#x27;s accepted languages. One or several (e.g. fr,de,en) (optional)</param>
        /// <returns>SearchItemsResponse</returns>
        public SearchItemsResponse Search (string q, int? page = null, int? perPage = null, string manufacturerId = null, string productCategoryId = null, string productStatusId = null, string subscriptionId = null, string scope = null, string acceptLanguage = null)
        {
             ApiResponse<SearchItemsResponse> localVarResponse = SearchWithHttpInfo(q, page, perPage, manufacturerId, productCategoryId, productStatusId, subscriptionId, scope, acceptLanguage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// search assets, batches, instrumentations, nodes, recipes, systems . search assets, instrumentations and nodes based on a defined set of fields.   asset - serial_number product_code product_name product_manufacturer_name   specification keys and values (of assets, nodes and instrumentation) when ui_visible is set to true   batches - batch_name      instrumentation - tag   nodes - name   recipes - recipe_name      systems - system_name    These fields may be extended in the  future.
        /// </summary>
        /// <exception cref="Netilion.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">search query</param>
        /// <param name="page">Page number to load (optional)</param>
        /// <param name="perPage">Number of items to load per page (optional)</param>
        /// <param name="manufacturerId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="productCategoryId">One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). (optional)</param>
        /// <param name="productStatusId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="subscriptionId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="scope">One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. (optional)</param>
        /// <param name="acceptLanguage">The client&#x27;s accepted languages. One or several (e.g. fr,de,en) (optional)</param>
        /// <returns>ApiResponse of SearchItemsResponse</returns>
        public ApiResponse< SearchItemsResponse > SearchWithHttpInfo (string q, int? page = null, int? perPage = null, string manufacturerId = null, string productCategoryId = null, string productStatusId = null, string subscriptionId = null, string scope = null, string acceptLanguage = null)
        {
            // verify the required parameter 'q' is set
            if (q == null)
                throw new ApiException(400, "Missing required parameter 'q' when calling SearchApi->Search");

            var localVarPath = "/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (q != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "q", q)); // query parameter
            if (manufacturerId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "manufacturer_id", manufacturerId)); // query parameter
            if (productCategoryId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_category_id", productCategoryId)); // query parameter
            if (productStatusId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_status_id", productStatusId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscription_id", subscriptionId)); // query parameter
            if (scope != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "scope", scope)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
            // authentication (API-Key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = this.Configuration.GetApiKeyWithPrefix("API-Key");
            }
            // authentication (Authentication) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchItemsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemsResponse)));
        }

        /// <summary>
        /// search assets, batches, instrumentations, nodes, recipes, systems . search assets, instrumentations and nodes based on a defined set of fields.   asset - serial_number product_code product_name product_manufacturer_name   specification keys and values (of assets, nodes and instrumentation) when ui_visible is set to true   batches - batch_name      instrumentation - tag   nodes - name   recipes - recipe_name      systems - system_name    These fields may be extended in the  future.
        /// </summary>
        /// <exception cref="Netilion.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">search query</param>
        /// <param name="page">Page number to load (optional)</param>
        /// <param name="perPage">Number of items to load per page (optional)</param>
        /// <param name="manufacturerId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="productCategoryId">One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). (optional)</param>
        /// <param name="productStatusId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="subscriptionId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="scope">One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. (optional)</param>
        /// <param name="acceptLanguage">The client&#x27;s accepted languages. One or several (e.g. fr,de,en) (optional)</param>
        /// <returns>Task of SearchItemsResponse</returns>
        public async System.Threading.Tasks.Task<SearchItemsResponse> SearchAsync (string q, int? page = null, int? perPage = null, string manufacturerId = null, string productCategoryId = null, string productStatusId = null, string subscriptionId = null, string scope = null, string acceptLanguage = null)
        {
             ApiResponse<SearchItemsResponse> localVarResponse = await SearchAsyncWithHttpInfo(q, page, perPage, manufacturerId, productCategoryId, productStatusId, subscriptionId, scope, acceptLanguage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// search assets, batches, instrumentations, nodes, recipes, systems . search assets, instrumentations and nodes based on a defined set of fields.   asset - serial_number product_code product_name product_manufacturer_name   specification keys and values (of assets, nodes and instrumentation) when ui_visible is set to true   batches - batch_name      instrumentation - tag   nodes - name   recipes - recipe_name      systems - system_name    These fields may be extended in the  future.
        /// </summary>
        /// <exception cref="Netilion.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">search query</param>
        /// <param name="page">Page number to load (optional)</param>
        /// <param name="perPage">Number of items to load per page (optional)</param>
        /// <param name="manufacturerId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="productCategoryId">One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). (optional)</param>
        /// <param name="productStatusId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="subscriptionId">One or multiple ids (comma list). Expected id format is integer (optional)</param>
        /// <param name="scope">One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. (optional)</param>
        /// <param name="acceptLanguage">The client&#x27;s accepted languages. One or several (e.g. fr,de,en) (optional)</param>
        /// <returns>Task of ApiResponse (SearchItemsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchItemsResponse>> SearchAsyncWithHttpInfo (string q, int? page = null, int? perPage = null, string manufacturerId = null, string productCategoryId = null, string productStatusId = null, string subscriptionId = null, string scope = null, string acceptLanguage = null)
        {
            // verify the required parameter 'q' is set
            if (q == null)
                throw new ApiException(400, "Missing required parameter 'q' when calling SearchApi->Search");

            var localVarPath = "/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (q != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "q", q)); // query parameter
            if (manufacturerId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "manufacturer_id", manufacturerId)); // query parameter
            if (productCategoryId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_category_id", productCategoryId)); // query parameter
            if (productStatusId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_status_id", productStatusId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscription_id", subscriptionId)); // query parameter
            if (scope != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "scope", scope)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
            // authentication (API-Key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = this.Configuration.GetApiKeyWithPrefix("API-Key");
            }
            // authentication (Authentication) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchItemsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemsResponse)));
        }

    }
}