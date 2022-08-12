# Netilion.Api.Api.APISubscriptionApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAssetsToAPISubscription**](APISubscriptionApi.md#addassetstoapisubscription) | **POST** /api_subscriptions/{id}/assets | Add assets to an api subscription
[**AddEdgeDevicesToApiSubscription**](APISubscriptionApi.md#addedgedevicestoapisubscription) | **POST** /api_subscriptions/{id}/edge_devices | Add edge devices to an api subscription
[**CreateAPISubscription**](APISubscriptionApi.md#createapisubscription) | **POST** /api_subscriptions | Create a new api subscription
[**DeleteAPISubscription**](APISubscriptionApi.md#deleteapisubscription) | **DELETE** /api_subscriptions/{id} | Delete an api subscription
[**GetAPISubscriptionById**](APISubscriptionApi.md#getapisubscriptionbyid) | **GET** /api_subscriptions/{id} | Get a single api subscription
[**GetAPISubscriptions**](APISubscriptionApi.md#getapisubscriptions) | **GET** /api_subscriptions | Get a range of api subscriptions
[**GetAssetsOfAPISubscription**](APISubscriptionApi.md#getassetsofapisubscription) | **GET** /api_subscriptions/{id}/assets | Get all assets of an api subscription
[**GetEdgeDevicesOfAPISubscription**](APISubscriptionApi.md#getedgedevicesofapisubscription) | **GET** /api_subscriptions/{id}/edge_devices | Get all edge devices of an api subscription
[**GetSpecificationsOfAPISubscription**](APISubscriptionApi.md#getspecificationsofapisubscription) | **GET** /api_subscriptions/{id}/specifications | Get specifications of an api subscription
[**RemoveAssetsFromAPISubscription**](APISubscriptionApi.md#removeassetsfromapisubscription) | **DELETE** /api_subscriptions/{id}/assets | Remove assets from an api subscription
[**RemoveEdgeDevicesFromApiSubscription**](APISubscriptionApi.md#removeedgedevicesfromapisubscription) | **DELETE** /api_subscriptions/{id}/edge_devices | Remove edge devices from an api subscription
[**RemoveSpecificationsFromAPISubscriptions**](APISubscriptionApi.md#removespecificationsfromapisubscriptions) | **DELETE** /api_subscriptions/{id}/specifications | Delete specifications of an api subscription
[**RenameSpecificationsOfAPISubscriptions**](APISubscriptionApi.md#renamespecificationsofapisubscriptions) | **PATCH** /api_subscriptions/{id}/specifications/rename | Rename a specification key
[**ReplaceAssetsOfAPISubscription**](APISubscriptionApi.md#replaceassetsofapisubscription) | **PATCH** /api_subscriptions/{id}/assets | Replace the assets of an api subscription
[**ReplaceEdgeDevicesOfApiSubscription**](APISubscriptionApi.md#replaceedgedevicesofapisubscription) | **PATCH** /api_subscriptions/{id}/edge_devices | Replace the edge devices of an api subscription
[**UpdateAPISubscription**](APISubscriptionApi.md#updateapisubscription) | **PATCH** /api_subscriptions/{id} | Update an api subscription
[**UpdateSpecificationsOfAPISubscriptions**](APISubscriptionApi.md#updatespecificationsofapisubscriptions) | **PATCH** /api_subscriptions/{id}/specifications | Update specifications of an api subscription

<a name="addassetstoapisubscription"></a>
# **AddAssetsToAPISubscription**
> void AddAssetsToAPISubscription (AssetIDs body, long? id)

Add assets to an api subscription

Add one or more assets to an API subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddAssetsToAPISubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be added.
            var id = 789;  // long? | Id of the api subscription to fetch

            try
            {
                // Add assets to an api subscription
                apiInstance.AddAssetsToAPISubscription(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.AddAssetsToAPISubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be added. | 
 **id** | **long?**| Id of the api subscription to fetch | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addedgedevicestoapisubscription"></a>
# **AddEdgeDevicesToApiSubscription**
> void AddEdgeDevicesToApiSubscription (EdgeDevicesIds body, long? id)

Add edge devices to an api subscription

Add one or more edge devices to an api subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddEdgeDevicesToApiSubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var body = new EdgeDevicesIds(); // EdgeDevicesIds | Resources that shall be added.
            var id = 789;  // long? | Id of the api subscription to which the edge devices will be added

            try
            {
                // Add edge devices to an api subscription
                apiInstance.AddEdgeDevicesToApiSubscription(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.AddEdgeDevicesToApiSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EdgeDevicesIds**](EdgeDevicesIds.md)| Resources that shall be added. | 
 **id** | **long?**| Id of the api subscription to which the edge devices will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createapisubscription"></a>
# **CreateAPISubscription**
> APISubscriptionResponse CreateAPISubscription (APISubscriptionRequest body)

Create a new api subscription

Creates a new api subscription. Only available for technical_users of the ID application and admins. Setting a successor or predecessor is not possible.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateAPISubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var body = new APISubscriptionRequest(); // APISubscriptionRequest | api subscription body

            try
            {
                // Create a new api subscription
                APISubscriptionResponse result = apiInstance.CreateAPISubscription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.CreateAPISubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**APISubscriptionRequest**](APISubscriptionRequest.md)| api subscription body | 

### Return type

[**APISubscriptionResponse**](APISubscriptionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteapisubscription"></a>
# **DeleteAPISubscription**
> void DeleteAPISubscription (long? id)

Delete an api subscription

Delete a specific api subscription identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteAPISubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var id = 789;  // long? | Id of the api subscription

            try
            {
                // Delete an api subscription
                apiInstance.DeleteAPISubscription(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.DeleteAPISubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the api subscription | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapisubscriptionbyid"></a>
# **GetAPISubscriptionById**
> APISubscriptionResponse GetAPISubscriptionById (long? id, string include = null)

Get a single api subscription

Get a specific api subscription identified by the id in the URL.  Possible include values: ```user, specifications, specifications[key1,key2]``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAPISubscriptionByIdExample
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

            var apiInstance = new APISubscriptionApi();
            var id = 789;  // long? | Id of the api subscription to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single api subscription
                APISubscriptionResponse result = apiInstance.GetAPISubscriptionById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.GetAPISubscriptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the api subscription to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**APISubscriptionResponse**](APISubscriptionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapisubscriptions"></a>
# **GetAPISubscriptions**
> APISubscriptionsResponse GetAPISubscriptions (int? page = null, int? perPage = null, string include = null, long? userId = null, long? clientApplicationId = null, string externalReference = null, string status = null, string subscriptionType = null, string notificationStatus = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? createdAt = null, string createdAtFrom = null, string createdAtTo = null, DateTime? updatedAt = null, string updatedAtFrom = null, string updatedAtTo = null, string orderBy = null)

Get a range of api subscriptions

Returns a list of api subscriptions.  Possible include values: ```user, specifications, specifications[key1,key2]``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAPISubscriptionsExample
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

            var apiInstance = new APISubscriptionApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var userId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var clientApplicationId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var externalReference = externalReference_example;  // string | Filter accepts `*` as wildcard (optional) 
            var status = status_example;  // string | one or multiple statuses (comma list). Allowed values are `open`, `payment_required`, `confirmed`, `scheduled_update`, `non_renewing` and `cancelled` (optional) 
            var subscriptionType = subscriptionType_example;  // string | Filter by subscription type - no wildcard support (optional) 
            var notificationStatus = notificationStatus_example;  // string | Filter by notification status - no wildcard support (optional) 
            var startDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var endDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var createdAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var createdAtTo = createdAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var updatedAtFrom = updatedAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = updatedAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of api subscriptions
                APISubscriptionsResponse result = apiInstance.GetAPISubscriptions(page, perPage, include, userId, clientApplicationId, externalReference, status, subscriptionType, notificationStatus, startDate, endDate, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.GetAPISubscriptions: " + e.Message );
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
 **userId** | **long?**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **clientApplicationId** | **long?**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **externalReference** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **status** | **string**| one or multiple statuses (comma list). Allowed values are &#x60;open&#x60;, &#x60;payment_required&#x60;, &#x60;confirmed&#x60;, &#x60;scheduled_update&#x60;, &#x60;non_renewing&#x60; and &#x60;cancelled&#x60; | [optional] 
 **subscriptionType** | **string**| Filter by subscription type - no wildcard support | [optional] 
 **notificationStatus** | **string**| Filter by notification status - no wildcard support | [optional] 
 **startDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **endDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **createdAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **createdAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **createdAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **updatedAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**APISubscriptionsResponse**](APISubscriptionsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetsofapisubscription"></a>
# **GetAssetsOfAPISubscription**
> AssetsResponse GetAssetsOfAPISubscription (long? id, int? page = null, int? perPage = null, string include = null, string serialNumber = null, string productId = null, string productCategoryId = null, string parentId = null, string manufacturerId = null, string statusId = null, string statusCode = null, DateTime? productionDate = null, DateTime? productionDateFrom = null, DateTime? productionDateTo = null, string specificationsKey = null, string specificationsValue = null, string nodeId = null, DateTime? createdAt = null, string createdAtFrom = null, string createdAtTo = null, DateTime? updatedAt = null, string updatedAtFrom = null, string updatedAtTo = null, bool? ownershipClaimed = null, string orderBy = null)

Get all assets of an api subscription

Returns a list of all assets that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```status, tenant, parent, pictures, product, product.manufacturer, product.pictures, product.status, product.categories, product.categories.parent, specifications, specifications[key1,key2], product.tenant,                             product.specifications, product.specifications[key1,key2], product.manufacturer.tenant, status.tenant, instrumentations ```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetsOfAPISubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var id = 789;  // long? | Id of the api subscription to fetch
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var serialNumber = serialNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productId = productId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var productCategoryId = productCategoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusCode = statusCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productionDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var nodeId = nodeId_example;  // string | One or multiple ids (comma list). Filter acccepts \"null\" for all assets with no nodes assigned or \"!null\" for any assigned node.  By adding `+` after the id, the filter considers the given node and all its sub components (nodes, instrumentations and systems), but this is not usable in combination with a comma list. (optional) 
            var createdAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var createdAtTo = createdAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var updatedAtFrom = updatedAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = updatedAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var ownershipClaimed = true;  // bool? | Filter accepts true or false (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `serial_number`, `created_at` or `updated_at`, `last_seen_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all assets of an api subscription
                AssetsResponse result = apiInstance.GetAssetsOfAPISubscription(id, page, perPage, include, serialNumber, productId, productCategoryId, parentId, manufacturerId, statusId, statusCode, productionDate, productionDateFrom, productionDateTo, specificationsKey, specificationsValue, nodeId, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, ownershipClaimed, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.GetAssetsOfAPISubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the api subscription to fetch | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **serialNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **productCategoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productionDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **nodeId** | **string**| One or multiple ids (comma list). Filter acccepts \&quot;null\&quot; for all assets with no nodes assigned or \&quot;!null\&quot; for any assigned node.  By adding &#x60;+&#x60; after the id, the filter considers the given node and all its sub components (nodes, instrumentations and systems), but this is not usable in combination with a comma list. | [optional] 
 **createdAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **createdAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **createdAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **updatedAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **ownershipClaimed** | **bool?**| Filter accepts true or false | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;serial_number&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, &#x60;last_seen_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**AssetsResponse**](AssetsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getedgedevicesofapisubscription"></a>
# **GetEdgeDevicesOfAPISubscription**
> EdgeDeviceResponse GetEdgeDevicesOfAPISubscription (long? id, int? page = null, int? perPage = null, string include = null, string serialNumber = null, string name = null, string typeId = null, string statusId = null, string softwareVersionId = null, string tenantId = null, string technicalUserId = null, string orderUserId = null, string logLevel = null, string specificationsKey = null, string specificationsValue = null, string orderBy = null)

Get all edge devices of an api subscription

Returns a list of all edge devices that are assigned to an api subscription. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```status type tenant technical_user order_user software_version usergroup specifications api_subscription api_subscription.user```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetEdgeDevicesOfAPISubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var id = 789;  // long? | Get a list of edge devices assigned to the api subscription identified by this id.
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var serialNumber = serialNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var softwareVersionId = softwareVersionId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var technicalUserId = technicalUserId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderUserId = orderUserId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var logLevel = logLevel_example;  // string | Filter accepts trace, debug, info, warning, error, critical, off (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `serial_number`, `created_at` or `updated_at`, `last_seen_at`, `name`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all edge devices of an api subscription
                EdgeDeviceResponse result = apiInstance.GetEdgeDevicesOfAPISubscription(id, page, perPage, include, serialNumber, name, typeId, statusId, softwareVersionId, tenantId, technicalUserId, orderUserId, logLevel, specificationsKey, specificationsValue, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.GetEdgeDevicesOfAPISubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Get a list of edge devices assigned to the api subscription identified by this id. | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **serialNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **softwareVersionId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **technicalUserId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderUserId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **logLevel** | **string**| Filter accepts trace, debug, info, warning, error, critical, off | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;serial_number&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, &#x60;last_seen_at&#x60;, &#x60;name&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**EdgeDeviceResponse**](EdgeDeviceResponse.md)

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

            var apiInstance = new APISubscriptionApi();
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
                Debug.Print("Exception when calling APISubscriptionApi.GetSpecificationsOfAPISubscription: " + e.Message );
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
<a name="removeassetsfromapisubscription"></a>
# **RemoveAssetsFromAPISubscription**
> void RemoveAssetsFromAPISubscription (AssetIDs body, long? id)

Remove assets from an api subscription

Remove one or more assets from an API subscription in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveAssetsFromAPISubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be removed.
            var id = 789;  // long? | Id of the api subscription to fetch

            try
            {
                // Remove assets from an api subscription
                apiInstance.RemoveAssetsFromAPISubscription(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.RemoveAssetsFromAPISubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be removed. | 
 **id** | **long?**| Id of the api subscription to fetch | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeedgedevicesfromapisubscription"></a>
# **RemoveEdgeDevicesFromApiSubscription**
> void RemoveEdgeDevicesFromApiSubscription (EdgeDevicesIds body, long? id)

Remove edge devices from an api subscription

Remove one or more edge devices from an api subscription in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveEdgeDevicesFromApiSubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var body = new EdgeDevicesIds(); // EdgeDevicesIds | Resources that shall be removed.
            var id = 789;  // long? | Id of the api subscription from which the edge devices will be removed

            try
            {
                // Remove edge devices from an api subscription
                apiInstance.RemoveEdgeDevicesFromApiSubscription(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.RemoveEdgeDevicesFromApiSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EdgeDevicesIds**](EdgeDevicesIds.md)| Resources that shall be removed. | 
 **id** | **long?**| Id of the api subscription from which the edge devices will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
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

            var apiInstance = new APISubscriptionApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var id = 789;  // long? | Id of the specified api subscription

            try
            {
                // Delete specifications of an api subscription
                apiInstance.RemoveSpecificationsFromAPISubscriptions(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.RemoveSpecificationsFromAPISubscriptions: " + e.Message );
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

            var apiInstance = new APISubscriptionApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var id = 789;  // long? | Id of the specified subscription

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfAPISubscriptions(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.RenameSpecificationsOfAPISubscriptions: " + e.Message );
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
<a name="replaceassetsofapisubscription"></a>
# **ReplaceAssetsOfAPISubscription**
> void ReplaceAssetsOfAPISubscription (AssetIDs body, long? id)

Replace the assets of an api subscription

Replaces all assets belonging to an API subscription in your accessible scope. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceAssetsOfAPISubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be replaced
            var id = 789;  // long? | Id of the api subscription to fetch

            try
            {
                // Replace the assets of an api subscription
                apiInstance.ReplaceAssetsOfAPISubscription(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.ReplaceAssetsOfAPISubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be replaced | 
 **id** | **long?**| Id of the api subscription to fetch | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceedgedevicesofapisubscription"></a>
# **ReplaceEdgeDevicesOfApiSubscription**
> void ReplaceEdgeDevicesOfApiSubscription (EdgeDevicesIds body, long? id)

Replace the edge devices of an api subscription

Replaces all edge devices belonging to an api subscription in your accessible scope. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceEdgeDevicesOfApiSubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var body = new EdgeDevicesIds(); // EdgeDevicesIds | Resources that shall be replaced
            var id = 789;  // long? | Id of the api subscription of which the edge devices will be replaced

            try
            {
                // Replace the edge devices of an api subscription
                apiInstance.ReplaceEdgeDevicesOfApiSubscription(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.ReplaceEdgeDevicesOfApiSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EdgeDevicesIds**](EdgeDevicesIds.md)| Resources that shall be replaced | 
 **id** | **long?**| Id of the api subscription of which the edge devices will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateapisubscription"></a>
# **UpdateAPISubscription**
> void UpdateAPISubscription (APISubscriptionRequest body, long? id)

Update an api subscription

Update accessible parameters of the requested resource. Setting a successor or predecessor is not possible.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateAPISubscriptionExample
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

            var apiInstance = new APISubscriptionApi();
            var body = new APISubscriptionRequest(); // APISubscriptionRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the api subscription to update

            try
            {
                // Update an api subscription
                apiInstance.UpdateAPISubscription(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.UpdateAPISubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**APISubscriptionRequest**](APISubscriptionRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the api subscription to update | 

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

            var apiInstance = new APISubscriptionApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var id = 789;  // long? | Id of the specified api subscription

            try
            {
                // Update specifications of an api subscription
                apiInstance.UpdateSpecificationsOfAPISubscriptions(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APISubscriptionApi.UpdateSpecificationsOfAPISubscriptions: " + e.Message );
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
