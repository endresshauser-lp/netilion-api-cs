# Netilion.Api.Api.HealthConditionApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateHealthCondition**](HealthConditionApi.md#createhealthcondition) | **POST** /health_conditions | Create a new health condition
[**DeleteHealthCondition**](HealthConditionApi.md#deletehealthcondition) | **DELETE** /health_conditions/{id} | Delete a health condition
[**GetHealthConditionById**](HealthConditionApi.md#gethealthconditionbyid) | **GET** /health_conditions/{id} | Get a single health condition
[**GetHealthConditions**](HealthConditionApi.md#gethealthconditions) | **GET** /health_conditions | Get a range of health conditions
[**UpdateHealthCondition**](HealthConditionApi.md#updatehealthcondition) | **PATCH** /health_conditions/{id} | Update a health condition

<a name="createhealthcondition"></a>
# **CreateHealthCondition**
> HealthConditionResponse CreateHealthCondition (HealthConditionRequest body)

Create a new health condition

Health condition must have a diagnosis_code, a protocol and a device ident

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateHealthConditionExample
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

            var apiInstance = new HealthConditionApi();
            var body = new HealthConditionRequest(); // HealthConditionRequest | Health Condition to create.

            try
            {
                // Create a new health condition
                HealthConditionResponse result = apiInstance.CreateHealthCondition(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionApi.CreateHealthCondition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HealthConditionRequest**](HealthConditionRequest.md)| Health Condition to create. | 

### Return type

[**HealthConditionResponse**](HealthConditionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletehealthcondition"></a>
# **DeleteHealthCondition**
> void DeleteHealthCondition (long? id)

Delete a health condition

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
    public class DeleteHealthConditionExample
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

            var apiInstance = new HealthConditionApi();
            var id = 789;  // long? | Id of the health condition to delete

            try
            {
                // Delete a health condition
                apiInstance.DeleteHealthCondition(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionApi.DeleteHealthCondition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the health condition to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethealthconditionbyid"></a>
# **GetHealthConditionById**
> HealthConditionResponse GetHealthConditionById (long? id, string include = null, string acceptLanguage = null)

Get a single health condition

Get a specific health condition identified by the id in the URL. Possible include value: ``asset_status,tenant,causes,causes.remedies``

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetHealthConditionByIdExample
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

            var apiInstance = new HealthConditionApi();
            var id = 789;  // long? | Id of health condition to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single health condition
                HealthConditionResponse result = apiInstance.GetHealthConditionById(id, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionApi.GetHealthConditionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of health condition to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**HealthConditionResponse**](HealthConditionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethealthconditions"></a>
# **GetHealthConditions**
> HealthConditionsResponse GetHealthConditions (int? page = null, int? perPage = null, string include = null, string assetStatusId = null, string tenantId = null, string diagnosisCode = null, string deviceIdent = null, string productIdentifier = null, string protocol = null, string protocolVersion = null, bool? hidden = null, string orderBy = null, string acceptLanguage = null)

Get a range of health conditions

Returns a list of all health conditions. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include value: ``asset_status,tenant,causes,causes.remedies``

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetHealthConditionsExample
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

            var apiInstance = new HealthConditionApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var assetStatusId = assetStatusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var diagnosisCode = diagnosisCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var deviceIdent = deviceIdent_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productIdentifier = productIdentifier_example;  // string | Filter accepts * as wildcard (optional) 
            var protocol = protocol_example;  // string | Filter accepts `PROFIBUS`, `HART`, `ETHERNETIP` and `MODBUS` (optional) 
            var protocolVersion = protocolVersion_example;  // string | Filter accepts `*` as wildcard (optional) 
            var hidden = true;  // bool? | Filter accepts true or false (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `diagnosis_code`, `device_ident`, `product_identifier`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of health conditions
                HealthConditionsResponse result = apiInstance.GetHealthConditions(page, perPage, include, assetStatusId, tenantId, diagnosisCode, deviceIdent, productIdentifier, protocol, protocolVersion, hidden, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionApi.GetHealthConditions: " + e.Message );
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
 **assetStatusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **diagnosisCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **deviceIdent** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productIdentifier** | **string**| Filter accepts * as wildcard | [optional] 
 **protocol** | **string**| Filter accepts &#x60;PROFIBUS&#x60;, &#x60;HART&#x60;, &#x60;ETHERNETIP&#x60; and &#x60;MODBUS&#x60; | [optional] 
 **protocolVersion** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **hidden** | **bool?**| Filter accepts true or false | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;diagnosis_code&#x60;, &#x60;device_ident&#x60;, &#x60;product_identifier&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**HealthConditionsResponse**](HealthConditionsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatehealthcondition"></a>
# **UpdateHealthCondition**
> void UpdateHealthCondition (HealthConditionRequest body, long? id)

Update a health condition

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
    public class UpdateHealthConditionExample
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

            var apiInstance = new HealthConditionApi();
            var body = new HealthConditionRequest(); // HealthConditionRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the health condition to update

            try
            {
                // Update a health condition
                apiInstance.UpdateHealthCondition(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthConditionApi.UpdateHealthCondition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HealthConditionRequest**](HealthConditionRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the health condition to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
