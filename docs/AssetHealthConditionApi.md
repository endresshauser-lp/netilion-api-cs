# Netilion.Api.Api.AssetHealthConditionApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddHealthConditionsToAsset**](AssetHealthConditionApi.md#addhealthconditionstoasset) | **POST** /assets/{asset_id}/health_conditions | Add health conditions to an asset
[**CalculateAssetHealthConditions**](AssetHealthConditionApi.md#calculateassethealthconditions) | **GET** /assets/{asset_id}/health_conditions/calculate | Calculate health conditions of an asset
[**CalculateAssetHealthConditionsAndUpdateAsset**](AssetHealthConditionApi.md#calculateassethealthconditionsandupdateasset) | **PATCH** /assets/{asset_id}/health_conditions/calculate | Calculate health conditions of an asset and update asset with this health conditions
[**GetAssetHealthConditions**](AssetHealthConditionApi.md#getassethealthconditions) | **GET** /assets/{asset_id}/health_conditions | Get all health conditions assigned to an asset
[**GetHealthConditionsOfAssetTimemachine**](AssetHealthConditionApi.md#gethealthconditionsofassettimemachine) | **GET** /assets/{asset_id}/health_conditions/timemachine | Get all health_conditions historical evolution the given asset had assigned
[**ReaplaceHealthConditionsOfAsset**](AssetHealthConditionApi.md#reaplacehealthconditionsofasset) | **PATCH** /assets/{asset_id}/health_conditions | Replace health conditions of an asset
[**RemoveHealthConditionsOfAsset**](AssetHealthConditionApi.md#removehealthconditionsofasset) | **DELETE** /assets/{asset_id}/health_conditions | Remove health conditions of an asset

<a name="addhealthconditionstoasset"></a>
# **AddHealthConditionsToAsset**
> void AddHealthConditionsToAsset (AssetHealthConditionsRequest body, long? assetId)

Add health conditions to an asset

Add one or more health conditions to an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddHealthConditionsToAssetExample
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

            var apiInstance = new AssetHealthConditionApi();
            var body = new AssetHealthConditionsRequest(); // AssetHealthConditionsRequest | Resources that shall be added.
            var assetId = 789;  // long? | The resource defined in the URL

            try
            {
                // Add health conditions to an asset
                apiInstance.AddHealthConditionsToAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetHealthConditionApi.AddHealthConditionsToAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetHealthConditionsRequest**](AssetHealthConditionsRequest.md)| Resources that shall be added. | 
 **assetId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="calculateassethealthconditions"></a>
# **CalculateAssetHealthConditions**
> AssetHealthConditionsResponse CalculateAssetHealthConditions (long? assetId, string protocol, string diagnosisMessage, int? page = null, int? perPage = null, string include = null, string protocolVersion = null, string deviceIdent = null, string productIdentifier = null, string acceptLanguage = null)

Calculate health conditions of an asset

Calculates the health conditions of an asset defined by the given diagnosis message, protocol and device ident. Possible include values: ``asset_status,causes,causes.remedies``

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CalculateAssetHealthConditionsExample
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

            var apiInstance = new AssetHealthConditionApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var protocol = protocol_example;  // string | Filter accepts 'PROFIBUS', 'HART', 'ETHERNETIP' or 'MODBUS'
            var diagnosisMessage = diagnosisMessage_example;  // string | diagnosis message of an asset
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var protocolVersion = protocolVersion_example;  // string | definition of the protocol version. For example 5, 6 or 7 for HART (optional) 
            var deviceIdent = deviceIdent_example;  // string | device_ident of the asset (optional) 
            var productIdentifier = productIdentifier_example;  // string | product_identifier of the asset (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Calculate health conditions of an asset
                AssetHealthConditionsResponse result = apiInstance.CalculateAssetHealthConditions(assetId, protocol, diagnosisMessage, page, perPage, include, protocolVersion, deviceIdent, productIdentifier, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetHealthConditionApi.CalculateAssetHealthConditions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **protocol** | **string**| Filter accepts &#x27;PROFIBUS&#x27;, &#x27;HART&#x27;, &#x27;ETHERNETIP&#x27; or &#x27;MODBUS&#x27; | 
 **diagnosisMessage** | **string**| diagnosis message of an asset | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **protocolVersion** | **string**| definition of the protocol version. For example 5, 6 or 7 for HART | [optional] 
 **deviceIdent** | **string**| device_ident of the asset | [optional] 
 **productIdentifier** | **string**| product_identifier of the asset | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**AssetHealthConditionsResponse**](AssetHealthConditionsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="calculateassethealthconditionsandupdateasset"></a>
# **CalculateAssetHealthConditionsAndUpdateAsset**
> void CalculateAssetHealthConditionsAndUpdateAsset (AssetHealthConditionsCalculateRequest body, long? assetId)

Calculate health conditions of an asset and update asset with this health conditions

Calculates the health conditions of an asset defined by the given diagnosis message, protocol and device ident. The asset will be automatically updated with the result.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CalculateAssetHealthConditionsAndUpdateAssetExample
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

            var apiInstance = new AssetHealthConditionApi();
            var body = new AssetHealthConditionsCalculateRequest(); // AssetHealthConditionsCalculateRequest | Resources that shall be replaced.
            var assetId = 789;  // long? | The resource defined in the URL

            try
            {
                // Calculate health conditions of an asset and update asset with this health conditions
                apiInstance.CalculateAssetHealthConditionsAndUpdateAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetHealthConditionApi.CalculateAssetHealthConditionsAndUpdateAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetHealthConditionsCalculateRequest**](AssetHealthConditionsCalculateRequest.md)| Resources that shall be replaced. | 
 **assetId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassethealthconditions"></a>
# **GetAssetHealthConditions**
> AssetHealthConditionsResponse GetAssetHealthConditions (long? assetId, int? page = null, int? perPage = null, string include = null, string healthConditionId = null, string diagnosisCode = null, string assetStatusId = null, string acceptLanguage = null)

Get all health conditions assigned to an asset

Returns a list of health conditions of an asset.  Possible include value: ``asset_status, causes, causes.remedies``

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetHealthConditionsExample
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

            var apiInstance = new AssetHealthConditionApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var healthConditionId = healthConditionId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var diagnosisCode = diagnosisCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var assetStatusId = assetStatusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all health conditions assigned to an asset
                AssetHealthConditionsResponse result = apiInstance.GetAssetHealthConditions(assetId, page, perPage, include, healthConditionId, diagnosisCode, assetStatusId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetHealthConditionApi.GetAssetHealthConditions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **healthConditionId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **diagnosisCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **assetStatusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**AssetHealthConditionsResponse**](AssetHealthConditionsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gethealthconditionsofassettimemachine"></a>
# **GetHealthConditionsOfAssetTimemachine**
> AssetHealthConditionsTimemachineResponse GetHealthConditionsOfAssetTimemachine (long? assetId, int? page = null, int? perPage = null, DateTime? from = null, DateTime? to = null, string orderBy = null)

Get all health_conditions historical evolution the given asset had assigned

Returns a list of all health_conditions available in your scope of an asset. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetHealthConditionsOfAssetTimemachineExample
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

            var apiInstance = new AssetHealthConditionApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var from = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date filter for timemachine values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var to = 2013-10-20T19:20:30+01:00;  // DateTime? | End date for timemachine values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `created_datetime` or `deleted_datetime`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get all health_conditions historical evolution the given asset had assigned
                AssetHealthConditionsTimemachineResponse result = apiInstance.GetHealthConditionsOfAssetTimemachine(assetId, page, perPage, from, to, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetHealthConditionApi.GetHealthConditionsOfAssetTimemachine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **from** | **DateTime?**| Start date filter for timemachine values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **to** | **DateTime?**| End date for timemachine values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;created_datetime&#x60; or &#x60;deleted_datetime&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**AssetHealthConditionsTimemachineResponse**](AssetHealthConditionsTimemachineResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="reaplacehealthconditionsofasset"></a>
# **ReaplaceHealthConditionsOfAsset**
> void ReaplaceHealthConditionsOfAsset (AssetHealthConditionsRequest body, long? assetId)

Replace health conditions of an asset

Replaces all health conditions belonging to an asset. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReaplaceHealthConditionsOfAssetExample
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

            var apiInstance = new AssetHealthConditionApi();
            var body = new AssetHealthConditionsRequest(); // AssetHealthConditionsRequest | Resources that shall be replaced.
            var assetId = 789;  // long? | The resource defined in the URL

            try
            {
                // Replace health conditions of an asset
                apiInstance.ReaplaceHealthConditionsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetHealthConditionApi.ReaplaceHealthConditionsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetHealthConditionsRequest**](AssetHealthConditionsRequest.md)| Resources that shall be replaced. | 
 **assetId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removehealthconditionsofasset"></a>
# **RemoveHealthConditionsOfAsset**
> void RemoveHealthConditionsOfAsset (AssetHealthConditionsRequest body, long? assetId)

Remove health conditions of an asset

Remove one or more health conditions from an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveHealthConditionsOfAssetExample
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

            var apiInstance = new AssetHealthConditionApi();
            var body = new AssetHealthConditionsRequest(); // AssetHealthConditionsRequest | Resources that shall be removed.
            var assetId = 789;  // long? | The resource defined in the URL

            try
            {
                // Remove health conditions of an asset
                apiInstance.RemoveHealthConditionsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetHealthConditionApi.RemoveHealthConditionsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetHealthConditionsRequest**](AssetHealthConditionsRequest.md)| Resources that shall be removed. | 
 **assetId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
