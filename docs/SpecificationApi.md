# Netilion.Api.Api.SpecificationApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSpecificationsOfAsset**](SpecificationApi.md#deletespecificationsofasset) | **DELETE** /assets/{asset_id}/specifications | Delete specifications of an asset
[**GetSpecificationHistoryOfAsset**](SpecificationApi.md#getspecificationhistoryofasset) | **GET** /assets/{asset_id}/specifications/{key}/history | Get the history of one specification attribute of an asset.
[**GetSpecificationHistoryOfBatch**](SpecificationApi.md#getspecificationhistoryofbatch) | **GET** /batches/{batch_id}/specifications/{key}/history | Get the history of one specification attribute of a batch.
[**GetSpecificationHistoryOfInstrumentation**](SpecificationApi.md#getspecificationhistoryofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/specifications/{key}/history | Get the history of one specification attribute of an instrumentation.
[**GetSpecificationHistoryOfRecipe**](SpecificationApi.md#getspecificationhistoryofrecipe) | **GET** /recipes/{recipe_id}/specifications/{key}/history | Get the history of one specification attribute of an recipe.
[**GetSpecificationHistoryOfSystem**](SpecificationApi.md#getspecificationhistoryofsystem) | **GET** /systems/{system_id}/specifications/{key}/history | Get the history of one specification attribute of a system.
[**GetSpecificationKeysOfAssets**](SpecificationApi.md#getspecificationkeysofassets) | **GET** /asset/specification_keys | Get existing asset specification keys
[**GetSpecificationKeysOfInstrumentations**](SpecificationApi.md#getspecificationkeysofinstrumentations) | **GET** /instrumentation/specification_keys | Get existing instrumentation specification keys
[**GetSpecificationKeysOfNodes**](SpecificationApi.md#getspecificationkeysofnodes) | **GET** /node/specification_keys | Get existing asset specification keys
[**GetSpecificationsOfAPISubscription**](SpecificationApi.md#getspecificationsofapisubscription) | **GET** /api_subscriptions/{id}/specifications | Get specifications of an api subscription
[**GetSpecificationsOfAsset**](SpecificationApi.md#getspecificationsofasset) | **GET** /assets/{asset_id}/specifications | Get specifications of an asset
[**GetSpecificationsOfBatch**](SpecificationApi.md#getspecificationsofbatch) | **GET** /batches/{batch_id}/specifications | Get specifications of a batch
[**GetSpecificationsOfEvent**](SpecificationApi.md#getspecificationsofevent) | **GET** /events/{event_id}/specifications | Get specifications of an event
[**GetSpecificationsOfInstrumentation**](SpecificationApi.md#getspecificationsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/specifications | Get specifications of an instrumentation
[**GetSpecificationsOfNode**](SpecificationApi.md#getspecificationsofnode) | **GET** /nodes/{node_id}/specifications | Get specifications of a node
[**GetSpecificationsOfProduct**](SpecificationApi.md#getspecificationsofproduct) | **GET** /products/{product_id}/specifications | Get specifications of a product
[**GetSpecificationsOfRecipe**](SpecificationApi.md#getspecificationsofrecipe) | **GET** /recipes/{recipe_id}/specifications | Get specifications of an recipe
[**GetSpecificationsOfSubscription**](SpecificationApi.md#getspecificationsofsubscription) | **GET** /subscriptions/{subscription_id}/specifications | Get specifications of a subscription
[**GetSpecificationsOfSystem**](SpecificationApi.md#getspecificationsofsystem) | **GET** /systems/{system_id}/specifications | Get specifications of a system
[**GetSpecificationsOfUser**](SpecificationApi.md#getspecificationsofuser) | **GET** /users/{user_id}/specifications | Get specifications of a user
[**RemoveSpecificationsFromAPISubscriptions**](SpecificationApi.md#removespecificationsfromapisubscriptions) | **DELETE** /api_subscriptions/{id}/specifications | Delete specifications of an api subscription
[**RemoveSpecificationsFromBatch**](SpecificationApi.md#removespecificationsfrombatch) | **DELETE** /batches/{batch_id}/specifications | Delete specifications of a batch
[**RemoveSpecificationsFromEvent**](SpecificationApi.md#removespecificationsfromevent) | **DELETE** /events/{event_id}/specifications | Delete specifications of an event
[**RemoveSpecificationsFromInstrumentation**](SpecificationApi.md#removespecificationsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/specifications | Delete specifications of an instrumentation
[**RemoveSpecificationsFromNode**](SpecificationApi.md#removespecificationsfromnode) | **DELETE** /nodes/{node_id}/specifications | Delete specifications of a node
[**RemoveSpecificationsFromProduct**](SpecificationApi.md#removespecificationsfromproduct) | **DELETE** /products/{product_id}/specifications | Delete specifications of a product
[**RemoveSpecificationsFromRecipe**](SpecificationApi.md#removespecificationsfromrecipe) | **DELETE** /recipes/{recipe_id}/specifications | Delete specifications of an recipe
[**RemoveSpecificationsFromSubscriptions**](SpecificationApi.md#removespecificationsfromsubscriptions) | **DELETE** /subscriptions/{subscription_id}/specifications | Delete specifications of a subscription
[**RemoveSpecificationsFromSystem**](SpecificationApi.md#removespecificationsfromsystem) | **DELETE** /systems/{system_id}/specifications | Delete specifications of a system
[**RemoveSpecificationsFromUsers**](SpecificationApi.md#removespecificationsfromusers) | **DELETE** /users/{user_id}/specifications | Delete specifications of a user
[**RenameSpecificationsOfAPISubscriptions**](SpecificationApi.md#renamespecificationsofapisubscriptions) | **PATCH** /api_subscriptions/{id}/specifications/rename | Rename a specification key
[**RenameSpecificationsOfAsset**](SpecificationApi.md#renamespecificationsofasset) | **PATCH** /assets/{asset_id}/specifications/rename | Rename a specification key
[**RenameSpecificationsOfBatch**](SpecificationApi.md#renamespecificationsofbatch) | **PATCH** /batches/{batch_id}/specifications/rename | Rename a specification key
[**RenameSpecificationsOfEvent**](SpecificationApi.md#renamespecificationsofevent) | **PATCH** /events/{event_id}/specifications/rename | Rename a specification key
[**RenameSpecificationsOfInstrumentation**](SpecificationApi.md#renamespecificationsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/specifications/rename | Rename a specification key
[**RenameSpecificationsOfNode**](SpecificationApi.md#renamespecificationsofnode) | **PATCH** /nodes/{node_id}/specifications/rename | Rename a specification key
[**RenameSpecificationsOfProduct**](SpecificationApi.md#renamespecificationsofproduct) | **PATCH** /products/{product_id}/specifications/rename | rename a key in the specification.
[**RenameSpecificationsOfRecipe**](SpecificationApi.md#renamespecificationsofrecipe) | **PATCH** /recipes/{recipe_id}/specifications/rename | Rename a specification key
[**RenameSpecificationsOfSubscriptions**](SpecificationApi.md#renamespecificationsofsubscriptions) | **PATCH** /subscriptions/{subscription_id}/specifications/rename | Rename a specification key
[**RenameSpecificationsOfSystem**](SpecificationApi.md#renamespecificationsofsystem) | **PATCH** /systems/{system_id}/specifications/rename | Rename a specification key
[**RenameSpecificationsOfUsers**](SpecificationApi.md#renamespecificationsofusers) | **PATCH** /users/{user_id}/specifications/rename | Rename a specification key
[**UpdateSpecificationsOfAPISubscriptions**](SpecificationApi.md#updatespecificationsofapisubscriptions) | **PATCH** /api_subscriptions/{id}/specifications | Update specifications of an api subscription
[**UpdateSpecificationsOfAsset**](SpecificationApi.md#updatespecificationsofasset) | **PATCH** /assets/{asset_id}/specifications | Update specifications of an asset
[**UpdateSpecificationsOfBatch**](SpecificationApi.md#updatespecificationsofbatch) | **PATCH** /batches/{batch_id}/specifications | Update specifications of a batch
[**UpdateSpecificationsOfEvent**](SpecificationApi.md#updatespecificationsofevent) | **PATCH** /events/{event_id}/specifications | Update specifications of an event
[**UpdateSpecificationsOfInstrumentation**](SpecificationApi.md#updatespecificationsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/specifications | Update specifications of an instrumentation
[**UpdateSpecificationsOfNode**](SpecificationApi.md#updatespecificationsofnode) | **PATCH** /nodes/{node_id}/specifications | Update specifications of a node
[**UpdateSpecificationsOfProduct**](SpecificationApi.md#updatespecificationsofproduct) | **PATCH** /products/{product_id}/specifications | Update specifications of a product
[**UpdateSpecificationsOfRecipe**](SpecificationApi.md#updatespecificationsofrecipe) | **PATCH** /recipes/{recipe_id}/specifications | Update specifications of an recipe
[**UpdateSpecificationsOfSubscriptions**](SpecificationApi.md#updatespecificationsofsubscriptions) | **PATCH** /subscriptions/{subscription_id}/specifications | Update specifications of a subscription
[**UpdateSpecificationsOfSystem**](SpecificationApi.md#updatespecificationsofsystem) | **PATCH** /systems/{system_id}/specifications | Update specifications of a system
[**UpdateSpecificationsOfUsers**](SpecificationApi.md#updatespecificationsofusers) | **PATCH** /users/{user_id}/specifications | Update specifications of a user

<a name="deletespecificationsofasset"></a>
# **DeleteSpecificationsOfAsset**
> void DeleteSpecificationsOfAsset (List<string> body, long? assetId)

Delete specifications of an asset

The specification keys in the body will be removed of the object in your accessible scope. Multiple specification keys can be sent in the same request. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteSpecificationsOfAssetExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var assetId = 789;  // long? | Id of the specified asset

            try
            {
                // Delete specifications of an asset
                apiInstance.DeleteSpecificationsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.DeleteSpecificationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **assetId** | **long?**| Id of the specified asset | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationhistoryofasset"></a>
# **GetSpecificationHistoryOfAsset**
> SpecificationHistoryResponse GetSpecificationHistoryOfAsset (long? assetId, string key, int? page = null, int? perPage = null, DateTime? sourceTimestampFrom = null, DateTime? sourceTimestampTo = null, DateTime? updatedAtFrom = null, DateTime? updatedAtTo = null, string orderBy = null)

Get the history of one specification attribute of an asset.

This might be useful for history data. The response contains a collection of historic values and when they`ve been updated. Since this can be a lot of data the service uses pagination. The history can be filtered by using a date range of source_timestamp and/or updated_at. Please consider that source_timestamp is not required and update on the attribute without giving a source_timestamp wont be included in the resulting response

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationHistoryOfAssetExample
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

            var apiInstance = new SpecificationApi();
            var assetId = 789;  // long? | Id of the specified asset
            var key = key_example;  // string | the exact key
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var sourceTimestampFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var sourceTimestampTo = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `source_timestamp` or `updated_at`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get the history of one specification attribute of an asset.
                SpecificationHistoryResponse result = apiInstance.GetSpecificationHistoryOfAsset(assetId, key, page, perPage, sourceTimestampFrom, sourceTimestampTo, updatedAtFrom, updatedAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationHistoryOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the specified asset | 
 **key** | **string**| the exact key | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **sourceTimestampFrom** | **DateTime?**| source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **sourceTimestampTo** | **DateTime?**| source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtFrom** | **DateTime?**| updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **DateTime?**| updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;source_timestamp&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**SpecificationHistoryResponse**](SpecificationHistoryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationhistoryofbatch"></a>
# **GetSpecificationHistoryOfBatch**
> SpecificationHistoryResponse GetSpecificationHistoryOfBatch (long? batchId, string key, int? page = null, int? perPage = null, DateTime? sourceTimestampFrom = null, DateTime? sourceTimestampTo = null, DateTime? updatedAtFrom = null, DateTime? updatedAtTo = null, string orderBy = null)

Get the history of one specification attribute of a batch.

This might be useful for history data. The response contains a collection of historic values and when they`ve been updated. Since this can be a lot of data the service uses pagination. The history can be filtered by using a date range of source_timestamp and/or updated_at. Please consider that source_timestamp is not required and update on the attribute without giving a source_timestamp wont be included in the resulting response

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationHistoryOfBatchExample
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

            var apiInstance = new SpecificationApi();
            var batchId = 789;  // long? | Id of the specified batch
            var key = key_example;  // string | the exact key
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var sourceTimestampFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var sourceTimestampTo = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `source_timestamp` or `updated_at`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get the history of one specification attribute of a batch.
                SpecificationHistoryResponse result = apiInstance.GetSpecificationHistoryOfBatch(batchId, key, page, perPage, sourceTimestampFrom, sourceTimestampTo, updatedAtFrom, updatedAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationHistoryOfBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **long?**| Id of the specified batch | 
 **key** | **string**| the exact key | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **sourceTimestampFrom** | **DateTime?**| source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **sourceTimestampTo** | **DateTime?**| source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtFrom** | **DateTime?**| updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **DateTime?**| updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;source_timestamp&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**SpecificationHistoryResponse**](SpecificationHistoryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationhistoryofinstrumentation"></a>
# **GetSpecificationHistoryOfInstrumentation**
> SpecificationHistoryResponse GetSpecificationHistoryOfInstrumentation (long? instrumentationId, string key, int? page = null, int? perPage = null, DateTime? sourceTimestampFrom = null, DateTime? sourceTimestampTo = null, DateTime? updatedAtFrom = null, DateTime? updatedAtTo = null, string orderBy = null)

Get the history of one specification attribute of an instrumentation.

This might be useful for history data. The response contains a collection of historic values and when they`ve been updated. Since this can be a lot of data the service uses pagination. The history can be filtered by using a date range of source_timestamp and/or updated_at. Please consider that source_timestamp is not required and update on the attribute without giving a source_timestamp wont be included in the resulting response

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationHistoryOfInstrumentationExample
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

            var apiInstance = new SpecificationApi();
            var instrumentationId = 789;  // long? | Id of the specified instrumentation
            var key = key_example;  // string | the exact key
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var sourceTimestampFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var sourceTimestampTo = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `source_timestamp` or `updated_at`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get the history of one specification attribute of an instrumentation.
                SpecificationHistoryResponse result = apiInstance.GetSpecificationHistoryOfInstrumentation(instrumentationId, key, page, perPage, sourceTimestampFrom, sourceTimestampTo, updatedAtFrom, updatedAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationHistoryOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the specified instrumentation | 
 **key** | **string**| the exact key | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **sourceTimestampFrom** | **DateTime?**| source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **sourceTimestampTo** | **DateTime?**| source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtFrom** | **DateTime?**| updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **DateTime?**| updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;source_timestamp&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**SpecificationHistoryResponse**](SpecificationHistoryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationhistoryofrecipe"></a>
# **GetSpecificationHistoryOfRecipe**
> SpecificationHistoryResponse GetSpecificationHistoryOfRecipe (long? recipeId, string key, int? page = null, int? perPage = null, DateTime? sourceTimestampFrom = null, DateTime? sourceTimestampTo = null, DateTime? updatedAtFrom = null, DateTime? updatedAtTo = null, string orderBy = null)

Get the history of one specification attribute of an recipe.

This might be useful for history data. The response contains a collection of historic values and when they`ve been updated. Since this can be a lot of data the service uses pagination. The history can be filtered by using a date range of source_timestamp and/or updated_at. Please consider that source_timestamp is not required and update on the attribute without giving a source_timestamp wont be included in the resulting response

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationHistoryOfRecipeExample
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

            var apiInstance = new SpecificationApi();
            var recipeId = 789;  // long? | Id of the specified recipe
            var key = key_example;  // string | the exact key
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var sourceTimestampFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var sourceTimestampTo = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `source_timestamp` or `updated_at`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get the history of one specification attribute of an recipe.
                SpecificationHistoryResponse result = apiInstance.GetSpecificationHistoryOfRecipe(recipeId, key, page, perPage, sourceTimestampFrom, sourceTimestampTo, updatedAtFrom, updatedAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationHistoryOfRecipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **long?**| Id of the specified recipe | 
 **key** | **string**| the exact key | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **sourceTimestampFrom** | **DateTime?**| source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **sourceTimestampTo** | **DateTime?**| source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtFrom** | **DateTime?**| updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **DateTime?**| updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;source_timestamp&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**SpecificationHistoryResponse**](SpecificationHistoryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationhistoryofsystem"></a>
# **GetSpecificationHistoryOfSystem**
> SpecificationHistoryResponse GetSpecificationHistoryOfSystem (long? systemId, string key, int? page = null, int? perPage = null, DateTime? sourceTimestampFrom = null, DateTime? sourceTimestampTo = null, DateTime? updatedAtFrom = null, DateTime? updatedAtTo = null, string orderBy = null)

Get the history of one specification attribute of a system.

This might be useful for history data. The response contains a collection of historic values and when they`ve been updated. Since this can be a lot of data the service uses pagination. The history can be filtered by using a date range of source_timestamp and/or updated_at. Please consider that source_timestamp is not required and update on the attribute without giving a source_timestamp wont be included in the resulting response

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationHistoryOfSystemExample
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

            var apiInstance = new SpecificationApi();
            var systemId = 789;  // long? | Id of the specified system
            var key = key_example;  // string | the exact key
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var sourceTimestampFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var sourceTimestampTo = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `source_timestamp` or `updated_at`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get the history of one specification attribute of a system.
                SpecificationHistoryResponse result = apiInstance.GetSpecificationHistoryOfSystem(systemId, key, page, perPage, sourceTimestampFrom, sourceTimestampTo, updatedAtFrom, updatedAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationHistoryOfSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemId** | **long?**| Id of the specified system | 
 **key** | **string**| the exact key | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **sourceTimestampFrom** | **DateTime?**| source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **sourceTimestampTo** | **DateTime?**| source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtFrom** | **DateTime?**| updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **DateTime?**| updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;source_timestamp&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**SpecificationHistoryResponse**](SpecificationHistoryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationkeysofassets"></a>
# **GetSpecificationKeysOfAssets**
> SpecificationKeys GetSpecificationKeysOfAssets (string key = null, bool? uiVisible = null)

Get existing asset specification keys

Returns the existing specification keys in all readable assets.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationKeysOfAssetsExample
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

            var apiInstance = new SpecificationApi();
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get existing asset specification keys
                SpecificationKeys result = apiInstance.GetSpecificationKeysOfAssets(key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationKeysOfAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationKeys**](SpecificationKeys.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationkeysofinstrumentations"></a>
# **GetSpecificationKeysOfInstrumentations**
> SpecificationKeys GetSpecificationKeysOfInstrumentations (string key = null, bool? uiVisible = null)

Get existing instrumentation specification keys

Returns the existing specification keys in all readable instrumentations.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationKeysOfInstrumentationsExample
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

            var apiInstance = new SpecificationApi();
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get existing instrumentation specification keys
                SpecificationKeys result = apiInstance.GetSpecificationKeysOfInstrumentations(key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationKeysOfInstrumentations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationKeys**](SpecificationKeys.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationkeysofnodes"></a>
# **GetSpecificationKeysOfNodes**
> SpecificationKeys GetSpecificationKeysOfNodes (string key = null, bool? uiVisible = null)

Get existing asset specification keys

Returns the existing specification keys in all readable nodes.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationKeysOfNodesExample
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

            var apiInstance = new SpecificationApi();
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get existing asset specification keys
                SpecificationKeys result = apiInstance.GetSpecificationKeysOfNodes(key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationKeysOfNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationKeys**](SpecificationKeys.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofapisubscription"></a>
# **GetSpecificationsOfAPISubscription**
> SpecificationsResponse GetSpecificationsOfAPISubscription (long? id, string key = null)

Get specifications of an api subscription

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfAPISubscriptionExample
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

            var apiInstance = new SpecificationApi();
            var id = 789;  // long? | Id of the specified api subscription
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of an api subscription
                SpecificationsResponse result = apiInstance.GetSpecificationsOfAPISubscription(id, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfAPISubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the specified api subscription | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofasset"></a>
# **GetSpecificationsOfAsset**
> SpecificationsUIVisibleResponse GetSpecificationsOfAsset (long? assetId, string key = null, bool? uiVisible = null)

Get specifications of an asset

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfAssetExample
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

            var apiInstance = new SpecificationApi();
            var assetId = 789;  // long? | Id of the specified asset
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get specifications of an asset
                SpecificationsUIVisibleResponse result = apiInstance.GetSpecificationsOfAsset(assetId, key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the specified asset | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationsUIVisibleResponse**](SpecificationsUIVisibleResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofbatch"></a>
# **GetSpecificationsOfBatch**
> SpecificationsResponse GetSpecificationsOfBatch (long? batchId, string key = null)

Get specifications of a batch

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfBatchExample
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

            var apiInstance = new SpecificationApi();
            var batchId = 789;  // long? | Id of the specified batch
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of a batch
                SpecificationsResponse result = apiInstance.GetSpecificationsOfBatch(batchId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **long?**| Id of the specified batch | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofevent"></a>
# **GetSpecificationsOfEvent**
> SpecificationsResponse GetSpecificationsOfEvent (long? eventId, string key = null)

Get specifications of an event

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfEventExample
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

            var apiInstance = new SpecificationApi();
            var eventId = 789;  // long? | Id of the specified event
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of an event
                SpecificationsResponse result = apiInstance.GetSpecificationsOfEvent(eventId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **long?**| Id of the specified event | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofinstrumentation"></a>
# **GetSpecificationsOfInstrumentation**
> SpecificationsUIVisibleResponse GetSpecificationsOfInstrumentation (long? instrumentationId, string key = null, bool? uiVisible = null)

Get specifications of an instrumentation

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfInstrumentationExample
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

            var apiInstance = new SpecificationApi();
            var instrumentationId = 789;  // long? | Id of the specified instrumentation
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get specifications of an instrumentation
                SpecificationsUIVisibleResponse result = apiInstance.GetSpecificationsOfInstrumentation(instrumentationId, key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the specified instrumentation | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationsUIVisibleResponse**](SpecificationsUIVisibleResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofnode"></a>
# **GetSpecificationsOfNode**
> SpecificationsUIVisibleResponse GetSpecificationsOfNode (long? nodeId, string key = null, bool? uiVisible = null)

Get specifications of a node

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfNodeExample
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

            var apiInstance = new SpecificationApi();
            var nodeId = 789;  // long? | Id of the specified node
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get specifications of a node
                SpecificationsUIVisibleResponse result = apiInstance.GetSpecificationsOfNode(nodeId, key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| Id of the specified node | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationsUIVisibleResponse**](SpecificationsUIVisibleResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofproduct"></a>
# **GetSpecificationsOfProduct**
> SpecificationsResponse GetSpecificationsOfProduct (long? productId, string key = null)

Get specifications of a product

Returns the specification of an object. If no specifications are defined, this is just an empty object.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfProductExample
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

            var apiInstance = new SpecificationApi();
            var productId = 789;  // long? | Id of the specified product
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of a product
                SpecificationsResponse result = apiInstance.GetSpecificationsOfProduct(productId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| Id of the specified product | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofrecipe"></a>
# **GetSpecificationsOfRecipe**
> SpecificationsResponse GetSpecificationsOfRecipe (long? recipeId, string key = null)

Get specifications of an recipe

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfRecipeExample
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

            var apiInstance = new SpecificationApi();
            var recipeId = 789;  // long? | Id of the specified recipe
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of an recipe
                SpecificationsResponse result = apiInstance.GetSpecificationsOfRecipe(recipeId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfRecipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **long?**| Id of the specified recipe | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofsubscription"></a>
# **GetSpecificationsOfSubscription**
> SpecificationsResponse GetSpecificationsOfSubscription (long? subscriptionId, string key = null)

Get specifications of a subscription

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfSubscriptionExample
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

            var apiInstance = new SpecificationApi();
            var subscriptionId = 789;  // long? | Id of the specified subscription
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of a subscription
                SpecificationsResponse result = apiInstance.GetSpecificationsOfSubscription(subscriptionId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **long?**| Id of the specified subscription | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofsystem"></a>
# **GetSpecificationsOfSystem**
> SpecificationsResponse GetSpecificationsOfSystem (long? systemId, string key = null)

Get specifications of a system

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfSystemExample
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

            var apiInstance = new SpecificationApi();
            var systemId = 789;  // long? | Id of the specified system
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of a system
                SpecificationsResponse result = apiInstance.GetSpecificationsOfSystem(systemId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemId** | **long?**| Id of the specified system | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofuser"></a>
# **GetSpecificationsOfUser**
> SpecificationsResponse GetSpecificationsOfUser (long? userId, string key = null)

Get specifications of a user

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfUserExample
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

            var apiInstance = new SpecificationApi();
            var userId = 789;  // long? | Id of the specified user
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of a user
                SpecificationsResponse result = apiInstance.GetSpecificationsOfUser(userId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.GetSpecificationsOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| Id of the specified user | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromapisubscriptions"></a>
# **RemoveSpecificationsFromAPISubscriptions**
> void RemoveSpecificationsFromAPISubscriptions (List<string> body, long? id)

Delete specifications of an api subscription

The specification keys in the body will be removed of the object in your accessible scope. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromAPISubscriptionsExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var id = 789;  // long? | Id of the specified api subscription

            try
            {
                // Delete specifications of an api subscription
                apiInstance.RemoveSpecificationsFromAPISubscriptions(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromAPISubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **id** | **long?**| Id of the specified api subscription | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfrombatch"></a>
# **RemoveSpecificationsFromBatch**
> void RemoveSpecificationsFromBatch (List<string> body, long? batchId)

Delete specifications of a batch

The specification keys in the body will be removed of the object in your accessible scope. Multiple specification keys can be sent in the same request. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromBatchExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var batchId = 789;  // long? | Id of the specified batch

            try
            {
                // Delete specifications of a batch
                apiInstance.RemoveSpecificationsFromBatch(body, batchId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **batchId** | **long?**| Id of the specified batch | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromevent"></a>
# **RemoveSpecificationsFromEvent**
> void RemoveSpecificationsFromEvent (List<string> body, long? eventId)

Delete specifications of an event

The specification keys in the body will be removed of the object in your accessible scope. Multiple specification keys can be sent in the same request. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromEventExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var eventId = 789;  // long? | Id of the specified event

            try
            {
                // Delete specifications of an event
                apiInstance.RemoveSpecificationsFromEvent(body, eventId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **eventId** | **long?**| Id of the specified event | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfrominstrumentation"></a>
# **RemoveSpecificationsFromInstrumentation**
> void RemoveSpecificationsFromInstrumentation (List<string> body, long? instrumentationId)

Delete specifications of an instrumentation

The specification keys in the body will be removed of the object in your accessible scope. Multiple specification keys can be sent in the same request. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromInstrumentationExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var instrumentationId = 789;  // long? | Id of the specified instrumentation

            try
            {
                // Delete specifications of an instrumentation
                apiInstance.RemoveSpecificationsFromInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **instrumentationId** | **long?**| Id of the specified instrumentation | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromnode"></a>
# **RemoveSpecificationsFromNode**
> void RemoveSpecificationsFromNode (List<string> body, long? nodeId)

Delete specifications of a node

The specification keys in the body will be removed of the object in your accessible scope. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromNodeExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var nodeId = 789;  // long? | Id of the specified node

            try
            {
                // Delete specifications of a node
                apiInstance.RemoveSpecificationsFromNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **nodeId** | **long?**| Id of the specified node | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromproduct"></a>
# **RemoveSpecificationsFromProduct**
> void RemoveSpecificationsFromProduct (List<string> body, long? productId)

Delete specifications of a product

The specification keys in the body will be removed. Multiple specification keys can be sent in the same request. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromProductExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var productId = 789;  // long? | Id of the specified product

            try
            {
                // Delete specifications of a product
                apiInstance.RemoveSpecificationsFromProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **productId** | **long?**| Id of the specified product | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromrecipe"></a>
# **RemoveSpecificationsFromRecipe**
> void RemoveSpecificationsFromRecipe (List<string> body, long? recipeId)

Delete specifications of an recipe

The specification keys in the body will be removed of the object in your accessible scope. Multiple specification keys can be sent in the same request. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromRecipeExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var recipeId = 789;  // long? | Id of the specified recipe

            try
            {
                // Delete specifications of an recipe
                apiInstance.RemoveSpecificationsFromRecipe(body, recipeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromRecipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **recipeId** | **long?**| Id of the specified recipe | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromsubscriptions"></a>
# **RemoveSpecificationsFromSubscriptions**
> void RemoveSpecificationsFromSubscriptions (List<string> body, long? subscriptionId)

Delete specifications of a subscription

The specification keys in the body will be removed of the object in your accessible scope. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromSubscriptionsExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var subscriptionId = 789;  // long? | Id of the specified subscription

            try
            {
                // Delete specifications of a subscription
                apiInstance.RemoveSpecificationsFromSubscriptions(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **subscriptionId** | **long?**| Id of the specified subscription | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromsystem"></a>
# **RemoveSpecificationsFromSystem**
> void RemoveSpecificationsFromSystem (List<string> body, long? systemId)

Delete specifications of a system

The specification keys in the body will be removed of the object in your accessible scope. Multiple specification keys can be sent in the same request. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromSystemExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var systemId = 789;  // long? | Id of the specified system

            try
            {
                // Delete specifications of a system
                apiInstance.RemoveSpecificationsFromSystem(body, systemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **systemId** | **long?**| Id of the specified system | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromusers"></a>
# **RemoveSpecificationsFromUsers**
> void RemoveSpecificationsFromUsers (List<string> body, long? userId)

Delete specifications of a user

The specification keys in the body will be removed of the object in your accessible scope. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromUsersExample
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

            var apiInstance = new SpecificationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var userId = 789;  // long? | Id of the specified user

            try
            {
                // Delete specifications of a user
                apiInstance.RemoveSpecificationsFromUsers(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RemoveSpecificationsFromUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **userId** | **long?**| Id of the specified user | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofapisubscriptions"></a>
# **RenameSpecificationsOfAPISubscriptions**
> void RenameSpecificationsOfAPISubscriptions (SpecificationsRename body, long? id)

Rename a specification key

Rename one specification key of a subscription in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfAPISubscriptionsExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var id = 789;  // long? | Id of the specified subscription

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfAPISubscriptions(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfAPISubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **id** | **long?**| Id of the specified subscription | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofasset"></a>
# **RenameSpecificationsOfAsset**
> void RenameSpecificationsOfAsset (SpecificationsRename body, long? assetId)

Rename a specification key

Rename one specification key of an asset in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ]. All uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfAssetExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var assetId = 789;  // long? | Id of the specified asset

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **assetId** | **long?**| Id of the specified asset | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofbatch"></a>
# **RenameSpecificationsOfBatch**
> void RenameSpecificationsOfBatch (SpecificationsRename body, long? batchId)

Rename a specification key

Rename one specification key of a batch in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfBatchExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var batchId = 789;  // long? | Id of the specified batch

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfBatch(body, batchId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **batchId** | **long?**| Id of the specified batch | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofevent"></a>
# **RenameSpecificationsOfEvent**
> void RenameSpecificationsOfEvent (SpecificationsRename body, long? eventId)

Rename a specification key

Rename one specification key of an event in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfEventExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var eventId = 789;  // long? | Id of the specified node

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfEvent(body, eventId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **eventId** | **long?**| Id of the specified node | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofinstrumentation"></a>
# **RenameSpecificationsOfInstrumentation**
> void RenameSpecificationsOfInstrumentation (SpecificationsRename body, long? instrumentationId)

Rename a specification key

Rename one specification key of an instrumentation in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfInstrumentationExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var instrumentationId = 789;  // long? | Id of the specified instrumentation

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **instrumentationId** | **long?**| Id of the specified instrumentation | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofnode"></a>
# **RenameSpecificationsOfNode**
> void RenameSpecificationsOfNode (SpecificationsRename body, long? nodeId)

Rename a specification key

Rename one specification key of a node in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfNodeExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var nodeId = 789;  // long? | Id of the specified node

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **nodeId** | **long?**| Id of the specified node | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofproduct"></a>
# **RenameSpecificationsOfProduct**
> void RenameSpecificationsOfProduct (SpecificationsRename body, long? productId)

rename a key in the specification.

Rename a key of the specification object of a product. Instead of delete and recreate again, this is to preserve the key´s value history. Also the new keys can only consist of a-z A-Z 0-9 . - _ all uppercase A-Z are converted to lower-case a-z. Only one key can be changed per request

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfProductExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var productId = 789;  // long? | Id of the specified product

            try
            {
                // rename a key in the specification.
                apiInstance.RenameSpecificationsOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **productId** | **long?**| Id of the specified product | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofrecipe"></a>
# **RenameSpecificationsOfRecipe**
> void RenameSpecificationsOfRecipe (SpecificationsRename body, long? recipeId)

Rename a specification key

Rename one specification key of an recipe in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfRecipeExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var recipeId = 789;  // long? | Id of the specified recipe

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfRecipe(body, recipeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfRecipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **recipeId** | **long?**| Id of the specified recipe | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofsubscriptions"></a>
# **RenameSpecificationsOfSubscriptions**
> void RenameSpecificationsOfSubscriptions (SpecificationsRename body, long? subscriptionId)

Rename a specification key

Rename one specification key of a subscription in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfSubscriptionsExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var subscriptionId = 789;  // long? | Id of the specified subscription

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfSubscriptions(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **subscriptionId** | **long?**| Id of the specified subscription | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofsystem"></a>
# **RenameSpecificationsOfSystem**
> void RenameSpecificationsOfSystem (SpecificationsRename body, long? systemId)

Rename a specification key

Rename one specification key of a system in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfSystemExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var systemId = 789;  // long? | Id of the specified system

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfSystem(body, systemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **systemId** | **long?**| Id of the specified system | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofusers"></a>
# **RenameSpecificationsOfUsers**
> void RenameSpecificationsOfUsers (SpecificationsRename body, long? userId)

Rename a specification key

Rename one specification key of a user in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfUsersExample
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

            var apiInstance = new SpecificationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var userId = 789;  // long? | Id of the specified user

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfUsers(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.RenameSpecificationsOfUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **userId** | **long?**| Id of the specified user | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofapisubscriptions"></a>
# **UpdateSpecificationsOfAPISubscriptions**
> void UpdateSpecificationsOfAPISubscriptions (Dictionary<string, SpecificationRequest> body, long? id)

Update specifications of an api subscription

Update the specification object of an api subscription in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfAPISubscriptionsExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var id = 789;  // long? | Id of the specified api subscription

            try
            {
                // Update specifications of an api subscription
                apiInstance.UpdateSpecificationsOfAPISubscriptions(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfAPISubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **id** | **long?**| Id of the specified api subscription | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofasset"></a>
# **UpdateSpecificationsOfAsset**
> void UpdateSpecificationsOfAsset (Dictionary<string, SpecificationUIVisibleRequest> body, long? assetId)

Update specifications of an asset

Update the specification object of an asset in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.  It is possible to save complex objects in the value as vector. In this case the unit must be 'vector' and the value a valid object in the following format: ```       [           {             \"key\": {              \"value\": \"string\",              \"unit\": \"string\"            }           },           {             \"second_key\": {               \"value\": \"string\"             }           }        ]   ```  - key can only consist of [a-z A-Z 0-9 . - _ ]. - value is mandatory, max length 6000 chars - unit is optional, max length 50 chars - its impossible to filter for vector values

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfAssetExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationUIVisibleRequest>(); // Dictionary<string, SpecificationUIVisibleRequest> | The specifications objects to patch.
            var assetId = 789;  // long? | Id of the specified asset

            try
            {
                // Update specifications of an asset
                apiInstance.UpdateSpecificationsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationUIVisibleRequest&gt;**](Dictionary&lt;string, SpecificationUIVisibleRequest&gt;.md)| The specifications objects to patch. | 
 **assetId** | **long?**| Id of the specified asset | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofbatch"></a>
# **UpdateSpecificationsOfBatch**
> void UpdateSpecificationsOfBatch (Dictionary<string, SpecificationRequest> body, long? batchId)

Update specifications of a batch

Update the specification object of a batch in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfBatchExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var batchId = 789;  // long? | Id of the specified batch

            try
            {
                // Update specifications of a batch
                apiInstance.UpdateSpecificationsOfBatch(body, batchId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **batchId** | **long?**| Id of the specified batch | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofevent"></a>
# **UpdateSpecificationsOfEvent**
> void UpdateSpecificationsOfEvent (Dictionary<string, SpecificationRequest> body, long? eventId)

Update specifications of an event

Update the specification object of an event in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of a-z A-Z 0-9 . - _ all uppercase A-Z are converted to lower-case a-z. For a key that is send mutliple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfEventExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var eventId = 789;  // long? | Id of the specified event

            try
            {
                // Update specifications of an event
                apiInstance.UpdateSpecificationsOfEvent(body, eventId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **eventId** | **long?**| Id of the specified event | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofinstrumentation"></a>
# **UpdateSpecificationsOfInstrumentation**
> void UpdateSpecificationsOfInstrumentation (Dictionary<string, SpecificationUIVisibleRequest> body, long? instrumentationId)

Update specifications of an instrumentation

Update the specification object of an instrumentation in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfInstrumentationExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationUIVisibleRequest>(); // Dictionary<string, SpecificationUIVisibleRequest> | The specifications objects to patch.
            var instrumentationId = 789;  // long? | Id of the specified instrumentation

            try
            {
                // Update specifications of an instrumentation
                apiInstance.UpdateSpecificationsOfInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationUIVisibleRequest&gt;**](Dictionary&lt;string, SpecificationUIVisibleRequest&gt;.md)| The specifications objects to patch. | 
 **instrumentationId** | **long?**| Id of the specified instrumentation | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofnode"></a>
# **UpdateSpecificationsOfNode**
> void UpdateSpecificationsOfNode (Dictionary<string, SpecificationUIVisibleRequest> body, long? nodeId)

Update specifications of a node

Update the specification object of a node in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfNodeExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationUIVisibleRequest>(); // Dictionary<string, SpecificationUIVisibleRequest> | The specifications objects to patch.
            var nodeId = 789;  // long? | Id of the specified node

            try
            {
                // Update specifications of a node
                apiInstance.UpdateSpecificationsOfNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationUIVisibleRequest&gt;**](Dictionary&lt;string, SpecificationUIVisibleRequest&gt;.md)| The specifications objects to patch. | 
 **nodeId** | **long?**| Id of the specified node | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofproduct"></a>
# **UpdateSpecificationsOfProduct**
> void UpdateSpecificationsOfProduct (Dictionary<string, SpecificationRequest> body, long? productId)

Update specifications of a product

Update the specification object of a product. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. If a key occurs more than once in the request body, the last key-value will be saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfProductExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var productId = 789;  // long? | Id of the specified product

            try
            {
                // Update specifications of a product
                apiInstance.UpdateSpecificationsOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **productId** | **long?**| Id of the specified product | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofrecipe"></a>
# **UpdateSpecificationsOfRecipe**
> void UpdateSpecificationsOfRecipe (Dictionary<string, SpecificationRequest> body, long? recipeId)

Update specifications of an recipe

Update the specification object of an recipe in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfRecipeExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var recipeId = 789;  // long? | Id of the specified recipe

            try
            {
                // Update specifications of an recipe
                apiInstance.UpdateSpecificationsOfRecipe(body, recipeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfRecipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **recipeId** | **long?**| Id of the specified recipe | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofsubscriptions"></a>
# **UpdateSpecificationsOfSubscriptions**
> void UpdateSpecificationsOfSubscriptions (Dictionary<string, SpecificationRequest> body, long? subscriptionId)

Update specifications of a subscription

Update the specification object of a subscription in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfSubscriptionsExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var subscriptionId = 789;  // long? | Id of the specified subscription

            try
            {
                // Update specifications of a subscription
                apiInstance.UpdateSpecificationsOfSubscriptions(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **subscriptionId** | **long?**| Id of the specified subscription | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofsystem"></a>
# **UpdateSpecificationsOfSystem**
> void UpdateSpecificationsOfSystem (Dictionary<string, SpecificationRequest> body, long? systemId)

Update specifications of a system

Update the specification object of a system in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfSystemExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var systemId = 789;  // long? | Id of the specified system

            try
            {
                // Update specifications of a system
                apiInstance.UpdateSpecificationsOfSystem(body, systemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfSystem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **systemId** | **long?**| Id of the specified system | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofusers"></a>
# **UpdateSpecificationsOfUsers**
> void UpdateSpecificationsOfUsers (Dictionary<string, SpecificationRequest> body, long? userId)

Update specifications of a user

Update the specification object of a user in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfUsersExample
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

            var apiInstance = new SpecificationApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var userId = 789;  // long? | Id of the specified user

            try
            {
                // Update specifications of a user
                apiInstance.UpdateSpecificationsOfUsers(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecificationApi.UpdateSpecificationsOfUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **userId** | **long?**| Id of the specified user | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
