# Netilion.Api.Api.APIKeyApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAPIKey**](APIKeyApi.md#createapikey) | **POST** /api_keys | Create a new APIKey
[**DeleteAPIKey**](APIKeyApi.md#deleteapikey) | **DELETE** /api_keys/{id} | Delete an APIKey
[**GetAPIKeyById**](APIKeyApi.md#getapikeybyid) | **GET** /api_keys/{id} | Get a single APIKey
[**GetAPIKeys**](APIKeyApi.md#getapikeys) | **GET** /api_keys | Get a range of APIKeys
[**UpdateAPIKey**](APIKeyApi.md#updateapikey) | **PATCH** /api_keys/{id} | Update an APIKey

<a name="createapikey"></a>
# **CreateAPIKey**
> APIKeyResponse CreateAPIKey (APIKeyRequest body)

Create a new APIKey

Create a new APIKey. The values of the api_key and the api_secret can't be set and will be generated. To create an APIKey, the client_application must have an API Subscription assigned. valid_from and valid_until will be adopted from the API Subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateAPIKeyExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");
            // Configure HTTP basic authorization: Authentication
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new APIKeyApi();
            var body = new APIKeyRequest(); // APIKeyRequest | APIKey object that needs to be created. client_application

            try
            {
                // Create a new APIKey
                APIKeyResponse result = apiInstance.CreateAPIKey(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIKeyApi.CreateAPIKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**APIKeyRequest**](APIKeyRequest.md)| APIKey object that needs to be created. client_application | 

### Return type

[**APIKeyResponse**](APIKeyResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteapikey"></a>
# **DeleteAPIKey**
> void DeleteAPIKey (long? id)

Delete an APIKey

Delete a specific resource in your accessible scope, identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteAPIKeyExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");
            // Configure HTTP basic authorization: Authentication
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new APIKeyApi();
            var id = 789;  // long? | Id of the APIKey to delete

            try
            {
                // Delete an APIKey
                apiInstance.DeleteAPIKey(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIKeyApi.DeleteAPIKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the APIKey to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapikeybyid"></a>
# **GetAPIKeyById**
> APIKeyResponse GetAPIKeyById (long? id)

Get a single APIKey

Get a specific APIKey in your accessible scope, identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAPIKeyByIdExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");
            // Configure HTTP basic authorization: Authentication
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new APIKeyApi();
            var id = 789;  // long? | Id of the APIKey to fetch

            try
            {
                // Get a single APIKey
                APIKeyResponse result = apiInstance.GetAPIKeyById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIKeyApi.GetAPIKeyById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the APIKey to fetch | 

### Return type

[**APIKeyResponse**](APIKeyResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapikeys"></a>
# **GetAPIKeys**
> APIKeysResponse GetAPIKeys (int? page = null, int? perPage = null, string apiKey = null, DateTime? validFrom = null, DateTime? validFromFrom = null, DateTime? validFromTo = null, DateTime? validUntil = null, DateTime? validUntilFrom = null, DateTime? validUntilTo = null, string orderBy = null)

Get a range of APIKeys

Returns a list of APIKeys in your accessible scope. If the query has no matches, the response is an empty list.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAPIKeysExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");
            // Configure HTTP basic authorization: Authentication
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new APIKeyApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var apiKey = apiKey_example;  // string | Filter accepts `*` as wildcard (optional) 
            var validFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validFromFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validFromTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntil = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntilFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntilTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of APIKeys
                APIKeysResponse result = apiInstance.GetAPIKeys(page, perPage, apiKey, validFrom, validFromFrom, validFromTo, validUntil, validUntilFrom, validUntilTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIKeyApi.GetAPIKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **apiKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **validFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validFromFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validFromTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntil** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntilFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntilTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**APIKeysResponse**](APIKeysResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateapikey"></a>
# **UpdateAPIKey**
> void UpdateAPIKey (APIKeyRequest body, long? id)

Update an APIKey

Update accessible parameters of the requested resource in your accessible scope. The value of the api_key and api_secret can't be changed.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateAPIKeyExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");
            // Configure HTTP basic authorization: Authentication
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new APIKeyApi();
            var body = new APIKeyRequest(); // APIKeyRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the APIKey to update

            try
            {
                // Update an APIKey
                apiInstance.UpdateAPIKey(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIKeyApi.UpdateAPIKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**APIKeyRequest**](APIKeyRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the APIKey to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
