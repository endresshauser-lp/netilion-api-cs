# Netilion.Api.Api.HealthConditionRemedyApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateHealthConditionRemedy**](HealthConditionRemedyApi.md#createhealthconditionremedy) | **POST** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies | Create a remedy
[**DeleteHealthConditionRemedy**](HealthConditionRemedyApi.md#deletehealthconditionremedy) | **DELETE** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies/{id} | Delete a remedy
[**GetHealthConditionRemedies**](HealthConditionRemedyApi.md#gethealthconditionremedies) | **GET** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies | Get all remedies of a cause
[**GetHealthConditionRemedyById**](HealthConditionRemedyApi.md#gethealthconditionremedybyid) | **GET** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies/{id} | Get a single remedy
[**UpdateHealthConditionRemedy**](HealthConditionRemedyApi.md#updatehealthconditionremedy) | **PATCH** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies/{id} | Update a remedy

<a name="createhealthconditionremedy"></a>
# **CreateHealthConditionRemedy**
> HealthConditionRemedyResponse CreateHealthConditionRemedy (HealthConditionRemedyRequest body, long? healthConditionId, long? causeId)

Create a remedy

Remedy must have a code and a description scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateHealthConditionRemedyExample
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

            var apiInstance = new HealthConditionRemedyApi();
            var body = new HealthConditionRemedyRequest(); // HealthConditionRemedyRequest | Parameters that shall be updated
            var healthConditionId = 789;  // long? | The resource defined in the URL
            var causeId = 789;  // long? | The resource defined in the URL

            try
            {
                // Create a remedy
                HealthConditionRemedyResponse result = apiInstance.CreateHealthConditionRemedy(body, healthConditionId, causeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionRemedyApi.CreateHealthConditionRemedy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HealthConditionRemedyRequest**](HealthConditionRemedyRequest.md)| Parameters that shall be updated | 
 **healthConditionId** | **long?**| The resource defined in the URL | 
 **causeId** | **long?**| The resource defined in the URL | 

### Return type

[**HealthConditionRemedyResponse**](HealthConditionRemedyResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletehealthconditionremedy"></a>
# **DeleteHealthConditionRemedy**
> void DeleteHealthConditionRemedy (long? healthConditionId, long? causeId, long? id)

Delete a remedy

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
    public class DeleteHealthConditionRemedyExample
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

            var apiInstance = new HealthConditionRemedyApi();
            var healthConditionId = 789;  // long? | The resource defined in the URL
            var causeId = 789;  // long? | The resource defined in the URL
            var id = 789;  // long? | Id of the remedy to delete

            try
            {
                // Delete a remedy
                apiInstance.DeleteHealthConditionRemedy(healthConditionId, causeId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionRemedyApi.DeleteHealthConditionRemedy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthConditionId** | **long?**| The resource defined in the URL | 
 **causeId** | **long?**| The resource defined in the URL | 
 **id** | **long?**| Id of the remedy to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethealthconditionremedies"></a>
# **GetHealthConditionRemedies**
> Remedies GetHealthConditionRemedies (long? healthConditionId, long? causeId, int? page = null, int? perPage = null, string code = null, string description = null, string orderBy = null, string acceptLanguage = null)

Get all remedies of a cause

Returns a list of remedies for a specific cause. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetHealthConditionRemediesExample
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

            var apiInstance = new HealthConditionRemedyApi();
            var healthConditionId = 789;  // long? | The resource defined in the URL
            var causeId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var description = description_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `code`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all remedies of a cause
                Remedies result = apiInstance.GetHealthConditionRemedies(healthConditionId, causeId, page, perPage, code, description, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionRemedyApi.GetHealthConditionRemedies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthConditionId** | **long?**| The resource defined in the URL | 
 **causeId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **description** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;code&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**Remedies**](Remedies.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethealthconditionremedybyid"></a>
# **GetHealthConditionRemedyById**
> HealthConditionRemedyResponse GetHealthConditionRemedyById (long? healthConditionId, long? causeId, long? id, string acceptLanguage = null)

Get a single remedy

Get a specific remedy identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetHealthConditionRemedyByIdExample
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

            var apiInstance = new HealthConditionRemedyApi();
            var healthConditionId = 789;  // long? | The resource defined in the URL
            var causeId = 789;  // long? | The resource defined in the URL
            var id = 789;  // long? | Id of the remedy to fetch
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single remedy
                HealthConditionRemedyResponse result = apiInstance.GetHealthConditionRemedyById(healthConditionId, causeId, id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionRemedyApi.GetHealthConditionRemedyById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthConditionId** | **long?**| The resource defined in the URL | 
 **causeId** | **long?**| The resource defined in the URL | 
 **id** | **long?**| Id of the remedy to fetch | 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**HealthConditionRemedyResponse**](HealthConditionRemedyResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatehealthconditionremedy"></a>
# **UpdateHealthConditionRemedy**
> void UpdateHealthConditionRemedy (HealthConditionRemedyRequest body, long? healthConditionId, long? causeId, long? id, string contentLanguage = null)

Update a remedy

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
    public class UpdateHealthConditionRemedyExample
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

            var apiInstance = new HealthConditionRemedyApi();
            var body = new HealthConditionRemedyRequest(); // HealthConditionRemedyRequest | Parameters that shall be updated
            var healthConditionId = 789;  // long? | The resource defined in the URL
            var causeId = 789;  // long? | The resource defined in the URL
            var id = 789;  // long? | Id of the remedy to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update a remedy
                apiInstance.UpdateHealthConditionRemedy(body, healthConditionId, causeId, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionRemedyApi.UpdateHealthConditionRemedy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HealthConditionRemedyRequest**](HealthConditionRemedyRequest.md)| Parameters that shall be updated | 
 **healthConditionId** | **long?**| The resource defined in the URL | 
 **causeId** | **long?**| The resource defined in the URL | 
 **id** | **long?**| Id of the remedy to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
