# Netilion.Api.Api.HealthConditionCauseApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateHealthConditionCause**](HealthConditionCauseApi.md#createhealthconditioncause) | **POST** /health_conditions/{health_condition_id}/causes | Create a health condition cause
[**DeleteCause**](HealthConditionCauseApi.md#deletecause) | **DELETE** /health_conditions/{health_condition_id}/causes/{id} | Delete a health condition cause
[**GetHealthConditionCauseById**](HealthConditionCauseApi.md#gethealthconditioncausebyid) | **GET** /health_conditions/{health_condition_id}/causes/{id} | Get a single health condition cause
[**GetHealthConditionCauses**](HealthConditionCauseApi.md#gethealthconditioncauses) | **GET** /health_conditions/{health_condition_id}/causes | Get all causes of a health condition
[**UpdateHealthConditionCause**](HealthConditionCauseApi.md#updatehealthconditioncause) | **PATCH** /health_conditions/{health_condition_id}/causes/{id} | Update a health condition cause

<a name="createhealthconditioncause"></a>
# **CreateHealthConditionCause**
> HealthConditionCauseResponse CreateHealthConditionCause (HealthConditionCauseRequest body, long? healthConditionId)

Create a health condition cause

Cause must have a code and at least one health condition

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateHealthConditionCauseExample
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

            var apiInstance = new HealthConditionCauseApi();
            var body = new HealthConditionCauseRequest(); // HealthConditionCauseRequest | Parameters that shall be updated.
            var healthConditionId = 789;  // long? | The resource defined in the URL

            try
            {
                // Create a health condition cause
                HealthConditionCauseResponse result = apiInstance.CreateHealthConditionCause(body, healthConditionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionCauseApi.CreateHealthConditionCause: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HealthConditionCauseRequest**](HealthConditionCauseRequest.md)| Parameters that shall be updated. | 
 **healthConditionId** | **long?**| The resource defined in the URL | 

### Return type

[**HealthConditionCauseResponse**](HealthConditionCauseResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecause"></a>
# **DeleteCause**
> void DeleteCause (long? healthConditionId, long? id)

Delete a health condition cause

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
    public class DeleteCauseExample
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

            var apiInstance = new HealthConditionCauseApi();
            var healthConditionId = 789;  // long? | The resource defined in the URL
            var id = 789;  // long? | Id of the cause to delete

            try
            {
                // Delete a health condition cause
                apiInstance.DeleteCause(healthConditionId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionCauseApi.DeleteCause: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthConditionId** | **long?**| The resource defined in the URL | 
 **id** | **long?**| Id of the cause to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethealthconditioncausebyid"></a>
# **GetHealthConditionCauseById**
> HealthConditionCauseResponse GetHealthConditionCauseById (long? healthConditionId, long? id, string include = null, string acceptLanguage = null)

Get a single health condition cause

Get a specific cause identified by the id in the URL. Possible include value: ``remedies``

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetHealthConditionCauseByIdExample
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

            var apiInstance = new HealthConditionCauseApi();
            var healthConditionId = 789;  // long? | The resource defined in the URL
            var id = 789;  // long? | Id of the cause to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single health condition cause
                HealthConditionCauseResponse result = apiInstance.GetHealthConditionCauseById(healthConditionId, id, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionCauseApi.GetHealthConditionCauseById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthConditionId** | **long?**| The resource defined in the URL | 
 **id** | **long?**| Id of the cause to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**HealthConditionCauseResponse**](HealthConditionCauseResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethealthconditioncauses"></a>
# **GetHealthConditionCauses**
> Causes GetHealthConditionCauses (long? healthConditionId, int? page = null, int? perPage = null, string code = null, string description = null, string orderBy = null, string acceptLanguage = null)

Get all causes of a health condition

Returns a list of causes of a health condition. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetHealthConditionCausesExample
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

            var apiInstance = new HealthConditionCauseApi();
            var healthConditionId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var description = description_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `code`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all causes of a health condition
                Causes result = apiInstance.GetHealthConditionCauses(healthConditionId, page, perPage, code, description, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionCauseApi.GetHealthConditionCauses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthConditionId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **description** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;code&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**Causes**](Causes.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatehealthconditioncause"></a>
# **UpdateHealthConditionCause**
> void UpdateHealthConditionCause (HealthConditionCauseRequest body, long? healthConditionId, long? id, string contentLanguage = null)

Update a health condition cause

Update accessible parameters of the requested resource.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateHealthConditionCauseExample
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

            var apiInstance = new HealthConditionCauseApi();
            var body = new HealthConditionCauseRequest(); // HealthConditionCauseRequest | Parameters that shall be updated.
            var healthConditionId = 789;  // long? | The resource defined in the URL
            var id = 789;  // long? | Id of the cause to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update a health condition cause
                apiInstance.UpdateHealthConditionCause(body, healthConditionId, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionCauseApi.UpdateHealthConditionCause: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HealthConditionCauseRequest**](HealthConditionCauseRequest.md)| Parameters that shall be updated. | 
 **healthConditionId** | **long?**| The resource defined in the URL | 
 **id** | **long?**| Id of the cause to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
