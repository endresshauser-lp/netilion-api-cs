# Netilion.Api.Api.AssetStatusApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAssetStatus**](AssetStatusApi.md#createassetstatus) | **POST** /asset/statuses | Create a new asset status
[**DeleteAssetStatus**](AssetStatusApi.md#deleteassetstatus) | **DELETE** /asset/statuses/{id} | Delete an asset status
[**GetAssetIdStatus**](AssetStatusApi.md#getassetidstatus) | **GET** /assets/{asset_id}/status | Get the status of the specific asset
[**GetAssetStatusById**](AssetStatusApi.md#getassetstatusbyid) | **GET** /asset/statuses/{id} | Get a single asset status
[**GetAssetStatuses**](AssetStatusApi.md#getassetstatuses) | **GET** /asset/statuses | Get a range of asset statuses
[**GetAssetStatusesOptions**](AssetStatusApi.md#getassetstatusesoptions) | **GET** /assets/{asset_id}/status-options | Get all possible statuses of the specified assets
[**UpdateAssetStatus**](AssetStatusApi.md#updateassetstatus) | **PATCH** /asset/statuses/{id} | Update an asset status

<a name="createassetstatus"></a>
# **CreateAssetStatus**
> AssetStatusResponse CreateAssetStatus (AssetStatusRequest body)

Create a new asset status

Code must be unique. Parameters supporting translation: ```name, description```. POST sets values in default language: en.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateAssetStatusExample
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

            var apiInstance = new AssetStatusApi();
            var body = new AssetStatusRequest(); // AssetStatusRequest | AssetStatus object to create.

            try
            {
                // Create a new asset status
                AssetStatusResponse result = apiInstance.CreateAssetStatus(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetStatusApi.CreateAssetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetStatusRequest**](AssetStatusRequest.md)| AssetStatus object to create. | 

### Return type

[**AssetStatusResponse**](AssetStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteassetstatus"></a>
# **DeleteAssetStatus**
> void DeleteAssetStatus (long? id)

Delete an asset status

Delete a specific resource identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteAssetStatusExample
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

            var apiInstance = new AssetStatusApi();
            var id = 789;  // long? | Id of the asset status to delete

            try
            {
                // Delete an asset status
                apiInstance.DeleteAssetStatus(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetStatusApi.DeleteAssetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the asset status to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetidstatus"></a>
# **GetAssetIdStatus**
> AssetStatusResponse GetAssetIdStatus (long? assetId, string include = null, string acceptLanguage = null)

Get the status of the specific asset

Returns the status of the asset. Needed if only permission on asset but not on tenant. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetIdStatusExample
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

            var apiInstance = new AssetStatusApi();
            var assetId = 789;  // long? | Id of the specified asset
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the status of the specific asset
                AssetStatusResponse result = apiInstance.GetAssetIdStatus(assetId, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetStatusApi.GetAssetIdStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the specified asset | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**AssetStatusResponse**](AssetStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetstatusbyid"></a>
# **GetAssetStatusById**
> AssetStatusResponse GetAssetStatusById (long? id, string include = null, string acceptLanguage = null)

Get a single asset status

Get a specific asset status identified by the id in the URL. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetStatusByIdExample
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

            var apiInstance = new AssetStatusApi();
            var id = 789;  // long? | Id of asset status to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single asset status
                AssetStatusResponse result = apiInstance.GetAssetStatusById(id, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetStatusApi.GetAssetStatusById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of asset status to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**AssetStatusResponse**](AssetStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetstatuses"></a>
# **GetAssetStatuses**
> AssetStatuses GetAssetStatuses (int? page = null, int? perPage = null, string include = null, string name = null, string tenantId = null, string code = null, string orderBy = null, string acceptLanguage = null)

Get a range of asset statuses

Returns a list of all asset statuses that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.  Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetStatusesExample
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

            var apiInstance = new AssetStatusApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of asset statuses
                AssetStatuses result = apiInstance.GetAssetStatuses(page, perPage, include, name, tenantId, code, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetStatusApi.GetAssetStatuses: " + e.Message );
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
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**AssetStatuses**](AssetStatuses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetstatusesoptions"></a>
# **GetAssetStatusesOptions**
> AssetStatuses GetAssetStatusesOptions (long? assetId, int? page = null, int? perPage = null, string include = null, string name = null, string tenantId = null, string code = null, string orderBy = null, string acceptLanguage = null)

Get all possible statuses of the specified assets

Returns a list of all possible asset statuses for the specified asset. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetStatusesOptionsExample
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

            var apiInstance = new AssetStatusApi();
            var assetId = 789;  // long? | Id of the specified asset
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all possible statuses of the specified assets
                AssetStatuses result = apiInstance.GetAssetStatusesOptions(assetId, page, perPage, include, name, tenantId, code, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetStatusApi.GetAssetStatusesOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the specified asset | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**AssetStatuses**](AssetStatuses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateassetstatus"></a>
# **UpdateAssetStatus**
> void UpdateAssetStatus (AssetStatusRequest body, long? id, string contentLanguage = null)

Update an asset status

Update accessible parameters of the requested resource. Parameters supporting translation: ```name, description```. To add a translation set Content-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateAssetStatusExample
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

            var apiInstance = new AssetStatusApi();
            var body = new AssetStatusRequest(); // AssetStatusRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the asset to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update an asset status
                apiInstance.UpdateAssetStatus(body, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetStatusApi.UpdateAssetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetStatusRequest**](AssetStatusRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the asset to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
