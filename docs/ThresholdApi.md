# Netilion.Api.Api.ThresholdApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInstrumentationThreshold**](ThresholdApi.md#createinstrumentationthreshold) | **POST** /instrumentations/{instrumentation_id}/thresholds | Create an instrumentation threshold
[**CreateRecipeThreshold**](ThresholdApi.md#createrecipethreshold) | **POST** /recipes/{recipe_id}/thresholds | Create an recipe threshold
[**CreateSystemThreshold**](ThresholdApi.md#createsystemthreshold) | **POST** /systems/{system_id}/thresholds | Create an system threshold
[**DeleteInstrumentationThreshold**](ThresholdApi.md#deleteinstrumentationthreshold) | **DELETE** /instrumentations/{instrumentation_id}/thresholds/{id} | Delete an instrumentation threshold.
[**DeleteRecipeThreshold**](ThresholdApi.md#deleterecipethreshold) | **DELETE** /recipes/{recipe_id}/thresholds/{id} | Delete an recipe threshold.
[**DeleteSystemThreshold**](ThresholdApi.md#deletesystemthreshold) | **DELETE** /systems/{system_id}/thresholds/{id} | Delete an system threshold.
[**GetInstrumentationThreshold**](ThresholdApi.md#getinstrumentationthreshold) | **GET** /instrumentations/{instrumentation_id}/thresholds/{id} | Get an instrumentation threshold
[**GetInstrumentationThresholds**](ThresholdApi.md#getinstrumentationthresholds) | **GET** /instrumentations/{instrumentation_id}/thresholds | Get instrumentation thresholds
[**GetRecipeThreshold**](ThresholdApi.md#getrecipethreshold) | **GET** /recipes/{recipe_id}/thresholds/{id} | Get an recipe threshold
[**GetRecipeThresholds**](ThresholdApi.md#getrecipethresholds) | **GET** /recipes/{recipe_id}/thresholds | Get recipe thresholds
[**GetSystemThreshold**](ThresholdApi.md#getsystemthreshold) | **GET** /systems/{system_id}/thresholds/{id} | Get an system threshold
[**GetSystemThresholds**](ThresholdApi.md#getsystemthresholds) | **GET** /systems/{system_id}/thresholds | Get system thresholds
[**UpdateInstrumentationThreshold**](ThresholdApi.md#updateinstrumentationthreshold) | **PATCH** /instrumentations/{instrumentation_id}/thresholds/{id} | Update an instrumentation threshold
[**UpdateRecipeThreshold**](ThresholdApi.md#updaterecipethreshold) | **PATCH** /recipes/{recipe_id}/thresholds/{id} | Update an recipe threshold
[**UpdateSystemThreshold**](ThresholdApi.md#updatesystemthreshold) | **PATCH** /systems/{system_id}/thresholds/{id} | Update an system threshold

<a name="createinstrumentationthreshold"></a>
# **CreateInstrumentationThreshold**
> ThresholdResponse CreateInstrumentationThreshold (ThresholdRequest body, long? instrumentationId)

Create an instrumentation threshold

Create a new instrumentation threshold. This action requires ```can_udpate``` permission on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateInstrumentationThresholdExample
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

            var apiInstance = new ThresholdApi();
            var body = new ThresholdRequest(); // ThresholdRequest | Object body that will be created.
            var instrumentationId = 789;  // long? | Id of the specified instrumentation

            try
            {
                // Create an instrumentation threshold
                ThresholdResponse result = apiInstance.CreateInstrumentationThreshold(body, instrumentationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.CreateInstrumentationThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThresholdRequest**](ThresholdRequest.md)| Object body that will be created. | 
 **instrumentationId** | **long?**| Id of the specified instrumentation | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createrecipethreshold"></a>
# **CreateRecipeThreshold**
> ThresholdResponse CreateRecipeThreshold (ThresholdRequest body, long? recipeId)

Create an recipe threshold

Create a new recipe threshold. This action requires ```can_udpate``` permission on the recipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateRecipeThresholdExample
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

            var apiInstance = new ThresholdApi();
            var body = new ThresholdRequest(); // ThresholdRequest | Object body that will be created.
            var recipeId = 789;  // long? | Id of the specified recipe

            try
            {
                // Create an recipe threshold
                ThresholdResponse result = apiInstance.CreateRecipeThreshold(body, recipeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.CreateRecipeThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThresholdRequest**](ThresholdRequest.md)| Object body that will be created. | 
 **recipeId** | **long?**| Id of the specified recipe | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createsystemthreshold"></a>
# **CreateSystemThreshold**
> ThresholdResponse CreateSystemThreshold (ThresholdRequest body, long? systemId)

Create an system threshold

Create a new system threshold. This action requires ```can_udpate``` permission on the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateSystemThresholdExample
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

            var apiInstance = new ThresholdApi();
            var body = new ThresholdRequest(); // ThresholdRequest | Object body that will be created.
            var systemId = 789;  // long? | Id of the specified system

            try
            {
                // Create an system threshold
                ThresholdResponse result = apiInstance.CreateSystemThreshold(body, systemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.CreateSystemThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThresholdRequest**](ThresholdRequest.md)| Object body that will be created. | 
 **systemId** | **long?**| Id of the specified system | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteinstrumentationthreshold"></a>
# **DeleteInstrumentationThreshold**
> void DeleteInstrumentationThreshold (long? instrumentationId, long? id)

Delete an instrumentation threshold.

Delete an instrumentation threshold.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteInstrumentationThresholdExample
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

            var apiInstance = new ThresholdApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation threshold

            try
            {
                // Delete an instrumentation threshold.
                apiInstance.DeleteInstrumentationThreshold(instrumentationId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.DeleteInstrumentationThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation threshold | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleterecipethreshold"></a>
# **DeleteRecipeThreshold**
> void DeleteRecipeThreshold (long? recipeId, long? id)

Delete an recipe threshold.

Delete an recipe threshold.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteRecipeThresholdExample
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

            var apiInstance = new ThresholdApi();
            var recipeId = 789;  // long? | Id of the recipe
            var id = 789;  // long? | Id of the recipe threshold

            try
            {
                // Delete an recipe threshold.
                apiInstance.DeleteRecipeThreshold(recipeId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.DeleteRecipeThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **long?**| Id of the recipe | 
 **id** | **long?**| Id of the recipe threshold | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesystemthreshold"></a>
# **DeleteSystemThreshold**
> void DeleteSystemThreshold (long? systemId, long? id)

Delete an system threshold.

Delete an system threshold.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteSystemThresholdExample
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

            var apiInstance = new ThresholdApi();
            var systemId = 789;  // long? | Id of the system
            var id = 789;  // long? | Id of the system threshold

            try
            {
                // Delete an system threshold.
                apiInstance.DeleteSystemThreshold(systemId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.DeleteSystemThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemId** | **long?**| Id of the system | 
 **id** | **long?**| Id of the system threshold | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationthreshold"></a>
# **GetInstrumentationThreshold**
> ThresholdResponse GetInstrumentationThreshold (long? instrumentationId, long? id)

Get an instrumentation threshold

Get a single threshold of an instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationThresholdExample
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

            var apiInstance = new ThresholdApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation threshold

            try
            {
                // Get an instrumentation threshold
                ThresholdResponse result = apiInstance.GetInstrumentationThreshold(instrumentationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.GetInstrumentationThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation threshold | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationthresholds"></a>
# **GetInstrumentationThresholds**
> ThresholdsResponse GetInstrumentationThresholds (long? instrumentationId, string key = null, string thresholdType = null, string orderBy = null)

Get instrumentation thresholds

Get all thresholds of an instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationThresholdsExample
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

            var apiInstance = new ThresholdApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var key = key_example;  // string | filter by key (optional) 
            var thresholdType = thresholdType_example;  // string | filter by type (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `name`, `key`, `threshold_type`, `notification`, `created_at`, `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get instrumentation thresholds
                ThresholdsResponse result = apiInstance.GetInstrumentationThresholds(instrumentationId, key, thresholdType, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.GetInstrumentationThresholds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **key** | **string**| filter by key | [optional] 
 **thresholdType** | **string**| filter by type | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;name&#x60;, &#x60;key&#x60;, &#x60;threshold_type&#x60;, &#x60;notification&#x60;, &#x60;created_at&#x60;, &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ThresholdsResponse**](ThresholdsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrecipethreshold"></a>
# **GetRecipeThreshold**
> ThresholdResponse GetRecipeThreshold (long? recipeId, long? id)

Get an recipe threshold

Get a single threshold of an recipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetRecipeThresholdExample
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

            var apiInstance = new ThresholdApi();
            var recipeId = 789;  // long? | Id of the recipe
            var id = 789;  // long? | Id of the recipe threshold

            try
            {
                // Get an recipe threshold
                ThresholdResponse result = apiInstance.GetRecipeThreshold(recipeId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.GetRecipeThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **long?**| Id of the recipe | 
 **id** | **long?**| Id of the recipe threshold | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrecipethresholds"></a>
# **GetRecipeThresholds**
> ThresholdsResponse GetRecipeThresholds (long? recipeId, string key = null, string thresholdType = null, string orderBy = null)

Get recipe thresholds

Get all thresholds of an recipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetRecipeThresholdsExample
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

            var apiInstance = new ThresholdApi();
            var recipeId = 789;  // long? | Id of the recipe
            var key = key_example;  // string | filter by key (optional) 
            var thresholdType = thresholdType_example;  // string | filter by type (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `name`, `key`, `threshold_type`, `notification`, `created_at`, `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get recipe thresholds
                ThresholdsResponse result = apiInstance.GetRecipeThresholds(recipeId, key, thresholdType, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.GetRecipeThresholds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **long?**| Id of the recipe | 
 **key** | **string**| filter by key | [optional] 
 **thresholdType** | **string**| filter by type | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;name&#x60;, &#x60;key&#x60;, &#x60;threshold_type&#x60;, &#x60;notification&#x60;, &#x60;created_at&#x60;, &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ThresholdsResponse**](ThresholdsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsystemthreshold"></a>
# **GetSystemThreshold**
> ThresholdResponse GetSystemThreshold (long? systemId, long? id)

Get an system threshold

Get a single threshold of an system.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSystemThresholdExample
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

            var apiInstance = new ThresholdApi();
            var systemId = 789;  // long? | Id of the system
            var id = 789;  // long? | Id of the system threshold

            try
            {
                // Get an system threshold
                ThresholdResponse result = apiInstance.GetSystemThreshold(systemId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.GetSystemThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemId** | **long?**| Id of the system | 
 **id** | **long?**| Id of the system threshold | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsystemthresholds"></a>
# **GetSystemThresholds**
> ThresholdsResponse GetSystemThresholds (long? systemId, string key = null, string thresholdType = null, string orderBy = null)

Get system thresholds

Get all thresholds of an system.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSystemThresholdsExample
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

            var apiInstance = new ThresholdApi();
            var systemId = 789;  // long? | Id of the system
            var key = key_example;  // string | filter by key (optional) 
            var thresholdType = thresholdType_example;  // string | filter by type (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `name`, `key`, `threshold_type`, `notification`, `created_at`, `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get system thresholds
                ThresholdsResponse result = apiInstance.GetSystemThresholds(systemId, key, thresholdType, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.GetSystemThresholds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemId** | **long?**| Id of the system | 
 **key** | **string**| filter by key | [optional] 
 **thresholdType** | **string**| filter by type | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;name&#x60;, &#x60;key&#x60;, &#x60;threshold_type&#x60;, &#x60;notification&#x60;, &#x60;created_at&#x60;, &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ThresholdsResponse**](ThresholdsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateinstrumentationthreshold"></a>
# **UpdateInstrumentationThreshold**
> ThresholdResponse UpdateInstrumentationThreshold (ThresholdRequest body, long? instrumentationId, long? id)

Update an instrumentation threshold

Replaces the threshold belonging to an instrumentation. This action requires `can_update` permission on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateInstrumentationThresholdExample
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

            var apiInstance = new ThresholdApi();
            var body = new ThresholdRequest(); // ThresholdRequest | Object body that will be updated.
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation threshold

            try
            {
                // Update an instrumentation threshold
                ThresholdResponse result = apiInstance.UpdateInstrumentationThreshold(body, instrumentationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.UpdateInstrumentationThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThresholdRequest**](ThresholdRequest.md)| Object body that will be updated. | 
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation threshold | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updaterecipethreshold"></a>
# **UpdateRecipeThreshold**
> ThresholdResponse UpdateRecipeThreshold (ThresholdRequest body, long? recipeId, long? id)

Update an recipe threshold

Replaces the threshold belonging to an recipe. This action requires `can_update` permission on the recipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateRecipeThresholdExample
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

            var apiInstance = new ThresholdApi();
            var body = new ThresholdRequest(); // ThresholdRequest | Object body that will be updated.
            var recipeId = 789;  // long? | Id of the recipe
            var id = 789;  // long? | Id of the recipe threshold

            try
            {
                // Update an recipe threshold
                ThresholdResponse result = apiInstance.UpdateRecipeThreshold(body, recipeId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.UpdateRecipeThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThresholdRequest**](ThresholdRequest.md)| Object body that will be updated. | 
 **recipeId** | **long?**| Id of the recipe | 
 **id** | **long?**| Id of the recipe threshold | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesystemthreshold"></a>
# **UpdateSystemThreshold**
> ThresholdResponse UpdateSystemThreshold (ThresholdRequest body, long? systemId, long? id)

Update an system threshold

Replaces the threshold belonging to an system. This action requires `can_update` permission on the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSystemThresholdExample
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

            var apiInstance = new ThresholdApi();
            var body = new ThresholdRequest(); // ThresholdRequest | Object body that will be updated.
            var systemId = 789;  // long? | Id of the system
            var id = 789;  // long? | Id of the system threshold

            try
            {
                // Update an system threshold
                ThresholdResponse result = apiInstance.UpdateSystemThreshold(body, systemId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThresholdApi.UpdateSystemThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThresholdRequest**](ThresholdRequest.md)| Object body that will be updated. | 
 **systemId** | **long?**| Id of the system | 
 **id** | **long?**| Id of the system threshold | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
