# Netilion.Api.Api.ProductHealthConditionApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddHealthConditionsToProduct**](ProductHealthConditionApi.md#addhealthconditionstoproduct) | **POST** /products/{product_id}/health_conditions | Add health conditions to an product
[**GetProductHealthConditions**](ProductHealthConditionApi.md#getproducthealthconditions) | **GET** /products/{product_id}/health_conditions | Get all health conditions assigned to an product
[**ReaplaceHealthConditionsOfProduct**](ProductHealthConditionApi.md#reaplacehealthconditionsofproduct) | **PATCH** /products/{product_id}/health_conditions | Replace health conditions of an product
[**RemoveHealthConditionsOfProduct**](ProductHealthConditionApi.md#removehealthconditionsofproduct) | **DELETE** /products/{product_id}/health_conditions | Remove health conditions of an product

<a name="addhealthconditionstoproduct"></a>
# **AddHealthConditionsToProduct**
> void AddHealthConditionsToProduct (HealthConditionsRequest body, long? productId)

Add health conditions to an product

Add one or more health conditions to an product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddHealthConditionsToProductExample
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

            var apiInstance = new ProductHealthConditionApi();
            var body = new HealthConditionsRequest(); // HealthConditionsRequest | Resources that shall be added.
            var productId = 789;  // long? | The resource defined in the URL

            try
            {
                // Add health conditions to an product
                apiInstance.AddHealthConditionsToProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductHealthConditionApi.AddHealthConditionsToProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HealthConditionsRequest**](HealthConditionsRequest.md)| Resources that shall be added. | 
 **productId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproducthealthconditions"></a>
# **GetProductHealthConditions**
> HealthConditionsResponse GetProductHealthConditions (long? productId, int? page = null, int? perPage = null, string include = null, string healthConditionId = null, string diagnosisCode = null, string deviceIdent = null, string productIdentifier = null, string protocol = null, string orderBy = null, string acceptLanguage = null)

Get all health conditions assigned to an product

Returns a list of health conditions of an product.  Possible include value: ``asset_status, causes, causes.remedies``

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductHealthConditionsExample
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

            var apiInstance = new ProductHealthConditionApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var healthConditionId = healthConditionId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var diagnosisCode = diagnosisCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var deviceIdent = deviceIdent_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productIdentifier = productIdentifier_example;  // string | Filter accepts * as wildcard (optional) 
            var protocol = protocol_example;  // string | Filter accepts `PROFIBUS`, `HART`, `ETHERNETIP` and `MODBUS` (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `diagnosis_code`, `device_ident`, `product_identifier`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all health conditions assigned to an product
                HealthConditionsResponse result = apiInstance.GetProductHealthConditions(productId, page, perPage, include, healthConditionId, diagnosisCode, deviceIdent, productIdentifier, protocol, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductHealthConditionApi.GetProductHealthConditions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **healthConditionId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **diagnosisCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **deviceIdent** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productIdentifier** | **string**| Filter accepts * as wildcard | [optional] 
 **protocol** | **string**| Filter accepts &#x60;PROFIBUS&#x60;, &#x60;HART&#x60;, &#x60;ETHERNETIP&#x60; and &#x60;MODBUS&#x60; | [optional] 
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
<a name="reaplacehealthconditionsofproduct"></a>
# **ReaplaceHealthConditionsOfProduct**
> void ReaplaceHealthConditionsOfProduct (HealthConditionsRequest body, long? productId)

Replace health conditions of an product

Replaces all health conditions belonging to an product. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReaplaceHealthConditionsOfProductExample
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

            var apiInstance = new ProductHealthConditionApi();
            var body = new HealthConditionsRequest(); // HealthConditionsRequest | Resources that shall be replaced.
            var productId = 789;  // long? | The resource defined in the URL

            try
            {
                // Replace health conditions of an product
                apiInstance.ReaplaceHealthConditionsOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductHealthConditionApi.ReaplaceHealthConditionsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HealthConditionsRequest**](HealthConditionsRequest.md)| Resources that shall be replaced. | 
 **productId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removehealthconditionsofproduct"></a>
# **RemoveHealthConditionsOfProduct**
> void RemoveHealthConditionsOfProduct (HealthConditionCauseIDs body, long? productId)

Remove health conditions of an product

Remove one or more health conditions from an product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveHealthConditionsOfProductExample
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

            var apiInstance = new ProductHealthConditionApi();
            var body = new HealthConditionCauseIDs(); // HealthConditionCauseIDs | Resources that shall be removed.
            var productId = 789;  // long? | The resource defined in the URL

            try
            {
                // Remove health conditions of an product
                apiInstance.RemoveHealthConditionsOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductHealthConditionApi.RemoveHealthConditionsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HealthConditionCauseIDs**](HealthConditionCauseIDs.md)| Resources that shall be removed. | 
 **productId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
