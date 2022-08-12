# Netilion.Api.Api.ValuesApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAssetValues**](ValuesApi.md#createassetvalues) | **POST** /assets/{asset_id}/values | Create asset values
[**GetAssetValues**](ValuesApi.md#getassetvalues) | **GET** /assets/{asset_id}/values | Get latest values for the asset.
[**GetAssetValuesForKey**](ValuesApi.md#getassetvaluesforkey) | **GET** /assets/{asset_id}/values/{key} | Get asset values for a specific key.
[**GetBatchValues**](ValuesApi.md#getbatchvalues) | **GET** /batches/{batch_id}/values | Get latest values for the batch.
[**GetBatchValuesForKey**](ValuesApi.md#getbatchvaluesforkey) | **GET** /batches/{batch_id}/values/{key} | Get batch values for a specific key.
[**GetInstrumentationValues**](ValuesApi.md#getinstrumentationvalues) | **GET** /instrumentations/{instrumentation_id}/values | Get latest values for the instrumentation.
[**GetInstrumentationValuesForKey**](ValuesApi.md#getinstrumentationvaluesforkey) | **GET** /instrumentations/{instrumentation_id}/values/{key} | Get instrumentation values for a specific key.
[**GetSystemValues**](ValuesApi.md#getsystemvalues) | **GET** /systems/{system_id}/values | Get latest values for the system.
[**GetSystemValuesForKey**](ValuesApi.md#getsystemvaluesforkey) | **GET** /systems/{system_id}/values/{key} | Get system values for a specific key.

<a name="createassetvalues"></a>
# **CreateAssetValues**
> void CreateAssetValues (AssetValuesRequest body, long? assetId)

Create asset values

Store values measured by an asset. For performance reasons, this endpoint behaves somewhat differently than normal endpoints:  * The data passed to this endpoint is processed asynchronously. * This endpoint always returns an empty response with status 204 No Content. * The data will be validated during processing. Invalid data will be dropped silently. * The request size is limited to 500kb, requests larger then 500kb will get an \"413 Payload Too Large\" error.  Data validations and manipultation:    * Keys and groups can only consist of the charaters [a-z A-Z 0-9 . - _ ].   * Keys and groups will be converted to lower case strings.   * Keys and groups must be between 1 and 128 characters long.   * Units can be passed as id or code. See the units endpoint for all available units.   * The timestamp is not mandatory and will be set to the time the value was transmitted to the server (This only works if the values get transfered one at a time, if you send multiple values without timestamp at once, all values will get the same timestamp and there for only the last one will be stored)

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateAssetValuesExample
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

            var apiInstance = new ValuesApi();
            var body = new AssetValuesRequest(); // AssetValuesRequest | Values to store to an asset.
            var assetId = 789;  // long? | The resource defined in the URL

            try
            {
                // Create asset values
                apiInstance.CreateAssetValues(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValuesApi.CreateAssetValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetValuesRequest**](AssetValuesRequest.md)| Values to store to an asset. | 
 **assetId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetvalues"></a>
# **GetAssetValues**
> AssetValuesResponse GetAssetValues (long? assetId, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, string key = null, string keyUnitId = null, string group = null)

Get latest values for the asset.

Returns a collection of the latest value for every key of the asset. Possible include values: ```unit, unit.base_unit```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetValuesExample
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

            var apiInstance = new ValuesApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not. These values have lower precedence than the parameter key_unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var key = key_example;  // string | only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. (optional) 
            var keyUnitId = keyUnitId_example;  // string | value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is `key[unit_id]`. Multiple values can be provided in a comma seperated list. (optional) 
            var group = group_example;  // string | Group of the asset value. (optional) 

            try
            {
                // Get latest values for the asset.
                AssetValuesResponse result = apiInstance.GetAssetValues(assetId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValuesApi.GetAssetValues: " + e.Message );
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
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not. These values have lower precedence than the parameter key_unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **key** | **string**| only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. | [optional] 
 **keyUnitId** | **string**| value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is &#x60;key[unit_id]&#x60;. Multiple values can be provided in a comma seperated list. | [optional] 
 **group** | **string**| Group of the asset value. | [optional] 

### Return type

[**AssetValuesResponse**](AssetValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetvaluesforkey"></a>
# **GetAssetValuesForKey**
> AssetKeyValuesResponse GetAssetValuesForKey (long? assetId, string key, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, DateTime? from = null, DateTime? to = null, int? unitId = null, string aggregation = null, string interval = null, string orderBy = null)

Get asset values for a specific key.

Returns a collection of the history values of an values for the specified key. For a aggregated result of the values the filter parameters aggregation and interval are mandatory. Receiving the result in a specific unit please use the filter parameter unit. The allowed units can be found in the intro section. With the filter parameters from to it is possible to receive the history of a defined time period. Possible include values: ```unit```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetValuesForKeyExample
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

            var apiInstance = new ValuesApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var key = key_example;  // string | key for the asset values
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page, default value is 500, maximum is 1000 (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not. These values have lower precedence than the parameter unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var from = 2013-10-20;  // DateTime? | Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var to = 2013-10-20;  // DateTime? | End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var unitId = 56;  // int? | Id of the unit in which the values are to be returned. (optional) 
            var aggregation = aggregation_example;  // string | Supported aggregation methods are `mean, min, max, sum, stddev`. This value is mandatory if interval is defined. (optional) 
            var interval = interval_example;  // string | Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of `s, m, h, d, w`. Example `3h`. (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `timestamp`, add `-` as a prefix for descending order. Default ordering is the order the values were entered in. (optional) 

            try
            {
                // Get asset values for a specific key.
                AssetKeyValuesResponse result = apiInstance.GetAssetValuesForKey(assetId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValuesApi.GetAssetValuesForKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **key** | **string**| key for the asset values | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page, default value is 500, maximum is 1000 | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not. These values have lower precedence than the parameter unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **from** | **DateTime?**| Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **to** | **DateTime?**| End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **unitId** | **int?**| Id of the unit in which the values are to be returned. | [optional] 
 **aggregation** | **string**| Supported aggregation methods are &#x60;mean, min, max, sum, stddev&#x60;. This value is mandatory if interval is defined. | [optional] 
 **interval** | **string**| Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of &#x60;s, m, h, d, w&#x60;. Example &#x60;3h&#x60;. | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;timestamp&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default ordering is the order the values were entered in. | [optional] 

### Return type

[**AssetKeyValuesResponse**](AssetKeyValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbatchvalues"></a>
# **GetBatchValues**
> AssetValuesResponse GetBatchValues (long? batchId, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, string key = null, string keyUnitId = null, string group = null)

Get latest values for the batch.

Returns a collection of the latest values for all keys of the batch. Possible include values: ```unit, asset, system```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetBatchValuesExample
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

            var apiInstance = new ValuesApi();
            var batchId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter key_unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var key = key_example;  // string | only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. (optional) 
            var keyUnitId = keyUnitId_example;  // string | value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is `key[unit_id]`. Multiple values can be provided in a comma seperated list. (optional) 
            var group = group_example;  // string | Group of the asset value. (optional) 

            try
            {
                // Get latest values for the batch.
                AssetValuesResponse result = apiInstance.GetBatchValues(batchId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValuesApi.GetBatchValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter key_unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **key** | **string**| only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. | [optional] 
 **keyUnitId** | **string**| value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is &#x60;key[unit_id]&#x60;. Multiple values can be provided in a comma seperated list. | [optional] 
 **group** | **string**| Group of the asset value. | [optional] 

### Return type

[**AssetValuesResponse**](AssetValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbatchvaluesforkey"></a>
# **GetBatchValuesForKey**
> AssetKeyValuesResponse GetBatchValuesForKey (long? batchId, string key, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, DateTime? from = null, DateTime? to = null, int? unitId = null, string aggregation = null, string interval = null, string orderBy = null)

Get batch values for a specific key.

Returns a collection of the history values of an values for the specified key. For a aggregated result of the values the filter parameters aggregation and interval are mandatory. Receiving the result in a specific unit please use the filter parameter unit. The allowed units can be found in the intro section. With the filter parameters from to it is possible to receive the history of a defined time period. Possible include values: ```unit```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetBatchValuesForKeyExample
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

            var apiInstance = new ValuesApi();
            var batchId = 789;  // long? | The resource defined in the URL
            var key = key_example;  // string | key for the batch values
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page, default value is 500, maximum is 1000 (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var from = 2013-10-20;  // DateTime? | Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var to = 2013-10-20;  // DateTime? | End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var unitId = 56;  // int? | Id of the unit in which the values are to be returned. (optional) 
            var aggregation = aggregation_example;  // string | Supported aggregation methods are `mean, min, max, sum, stddev`. This value is mandatory if interval is defined. (optional) 
            var interval = interval_example;  // string | Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of `s, m, h, d, w`. Example `3h`. (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `timestamp`, add `-` as a prefix for descending order. Default ordering is the order the values were entered in. (optional) 

            try
            {
                // Get batch values for a specific key.
                AssetKeyValuesResponse result = apiInstance.GetBatchValuesForKey(batchId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValuesApi.GetBatchValuesForKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **long?**| The resource defined in the URL | 
 **key** | **string**| key for the batch values | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page, default value is 500, maximum is 1000 | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **from** | **DateTime?**| Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **to** | **DateTime?**| End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **unitId** | **int?**| Id of the unit in which the values are to be returned. | [optional] 
 **aggregation** | **string**| Supported aggregation methods are &#x60;mean, min, max, sum, stddev&#x60;. This value is mandatory if interval is defined. | [optional] 
 **interval** | **string**| Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of &#x60;s, m, h, d, w&#x60;. Example &#x60;3h&#x60;. | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;timestamp&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default ordering is the order the values were entered in. | [optional] 

### Return type

[**AssetKeyValuesResponse**](AssetKeyValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationvalues"></a>
# **GetInstrumentationValues**
> AssetValuesResponse GetInstrumentationValues (long? instrumentationId, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, string key = null, string keyUnitId = null, string group = null)

Get latest values for the instrumentation.

Returns a collection of the latest values for all keys of the instrumentation. Possible include values: ```unit, asset```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationValuesExample
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

            var apiInstance = new ValuesApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter key_unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var key = key_example;  // string | only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. (optional) 
            var keyUnitId = keyUnitId_example;  // string | value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is `key[unit_id]`. Multiple values can be provided in a comma seperated list. (optional) 
            var group = group_example;  // string | Group of the asset value. (optional) 

            try
            {
                // Get latest values for the instrumentation.
                AssetValuesResponse result = apiInstance.GetInstrumentationValues(instrumentationId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValuesApi.GetInstrumentationValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter key_unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **key** | **string**| only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. | [optional] 
 **keyUnitId** | **string**| value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is &#x60;key[unit_id]&#x60;. Multiple values can be provided in a comma seperated list. | [optional] 
 **group** | **string**| Group of the asset value. | [optional] 

### Return type

[**AssetValuesResponse**](AssetValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationvaluesforkey"></a>
# **GetInstrumentationValuesForKey**
> AssetKeyValuesResponse GetInstrumentationValuesForKey (long? instrumentationId, string key, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, DateTime? from = null, DateTime? to = null, int? unitId = null, string aggregation = null, string interval = null, string orderBy = null)

Get instrumentation values for a specific key.

Returns a collection of the history values of an values for the specified key. For a aggregated result of the values the filter parameters aggregation and interval are mandatory. Receiving the result in a specific unit please use the filter parameter unit. The allowed units can be found in the intro section. With the filter parameters from to it is possible to receive the history of a defined time period. Possible include values: ```unit```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationValuesForKeyExample
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

            var apiInstance = new ValuesApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var key = key_example;  // string | key for the instrumentation values
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page, default value is 500, maximum is 1000 (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var from = 2013-10-20;  // DateTime? | Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var to = 2013-10-20;  // DateTime? | End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var unitId = 56;  // int? | Id of the unit in which the values are to be returned. (optional) 
            var aggregation = aggregation_example;  // string | Supported aggregation methods are `mean, min, max, sum, stddev`. This value is mandatory if interval is defined. (optional) 
            var interval = interval_example;  // string | Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of `s, m, h, d, w`. Example `3h`. (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `timestamp`, add `-` as a prefix for descending order. Default ordering is the order the values were entered in. (optional) 

            try
            {
                // Get instrumentation values for a specific key.
                AssetKeyValuesResponse result = apiInstance.GetInstrumentationValuesForKey(instrumentationId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValuesApi.GetInstrumentationValuesForKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **key** | **string**| key for the instrumentation values | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page, default value is 500, maximum is 1000 | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **from** | **DateTime?**| Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **to** | **DateTime?**| End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **unitId** | **int?**| Id of the unit in which the values are to be returned. | [optional] 
 **aggregation** | **string**| Supported aggregation methods are &#x60;mean, min, max, sum, stddev&#x60;. This value is mandatory if interval is defined. | [optional] 
 **interval** | **string**| Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of &#x60;s, m, h, d, w&#x60;. Example &#x60;3h&#x60;. | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;timestamp&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default ordering is the order the values were entered in. | [optional] 

### Return type

[**AssetKeyValuesResponse**](AssetKeyValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsystemvalues"></a>
# **GetSystemValues**
> AssetValuesResponse GetSystemValues (long? systemId, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, string key = null, string keyUnitId = null, string group = null)

Get latest values for the system.

Returns a collection of the latest values for all keys of the system. Possible include values: ```unit, asset```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSystemValuesExample
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

            var apiInstance = new ValuesApi();
            var systemId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter key_unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var key = key_example;  // string | only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. (optional) 
            var keyUnitId = keyUnitId_example;  // string | value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is `key[unit_id]`. Multiple values can be provided in a comma seperated list. (optional) 
            var group = group_example;  // string | Group of the asset value. (optional) 

            try
            {
                // Get latest values for the system.
                AssetValuesResponse result = apiInstance.GetSystemValues(systemId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValuesApi.GetSystemValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter key_unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **key** | **string**| only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. | [optional] 
 **keyUnitId** | **string**| value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is &#x60;key[unit_id]&#x60;. Multiple values can be provided in a comma seperated list. | [optional] 
 **group** | **string**| Group of the asset value. | [optional] 

### Return type

[**AssetValuesResponse**](AssetValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsystemvaluesforkey"></a>
# **GetSystemValuesForKey**
> AssetKeyValuesResponse GetSystemValuesForKey (long? systemId, string key, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, DateTime? from = null, DateTime? to = null, int? unitId = null, string aggregation = null, string interval = null, string orderBy = null)

Get system values for a specific key.

Returns a collection of the history values of an values for the specified key. For a aggregated result of the values the filter parameters aggregation and interval are mandatory. Receiving the result in a specific unit please use the filter parameter unit. The allowed units can be found in the intro section. With the filter parameters from to it is possible to receive the history of a defined time period. Possible include values: ```unit```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSystemValuesForKeyExample
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

            var apiInstance = new ValuesApi();
            var systemId = 789;  // long? | The resource defined in the URL
            var key = key_example;  // string | key for the system values
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page, default value is 500, maximum is 1000 (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var from = 2013-10-20;  // DateTime? | Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var to = 2013-10-20;  // DateTime? | End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var unitId = 56;  // int? | Id of the unit in which the values are to be returned. (optional) 
            var aggregation = aggregation_example;  // string | Supported aggregation methods are `mean, min, max, sum, stddev`. This value is mandatory if interval is defined. (optional) 
            var interval = interval_example;  // string | Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of `s, m, h, d, w`. Example `3h`. (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `timestamp`, add `-` as a prefix for descending order. Default ordering is the order the values were entered in. (optional) 

            try
            {
                // Get system values for a specific key.
                AssetKeyValuesResponse result = apiInstance.GetSystemValuesForKey(systemId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValuesApi.GetSystemValuesForKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemId** | **long?**| The resource defined in the URL | 
 **key** | **string**| key for the system values | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page, default value is 500, maximum is 1000 | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **from** | **DateTime?**| Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **to** | **DateTime?**| End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **unitId** | **int?**| Id of the unit in which the values are to be returned. | [optional] 
 **aggregation** | **string**| Supported aggregation methods are &#x60;mean, min, max, sum, stddev&#x60;. This value is mandatory if interval is defined. | [optional] 
 **interval** | **string**| Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of &#x60;s, m, h, d, w&#x60;. Example &#x60;3h&#x60;. | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;timestamp&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default ordering is the order the values were entered in. | [optional] 

### Return type

[**AssetKeyValuesResponse**](AssetKeyValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
