# Netilion.Api.Api.SubscriptionApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAssetsToSubscription**](SubscriptionApi.md#addassetstosubscription) | **POST** /subscriptions/{subscription_id}/assets | Add assets to a subscription
[**AddSeatUsersToSubscription**](SubscriptionApi.md#addseatuserstosubscription) | **POST** /subscriptions/{subscription_id}/seats | Add users (existing users) or emails (new users) to a seat in subscription
[**AssignAssetSetToSubscription**](SubscriptionApi.md#assignassetsettosubscription) | **POST** /subscriptions/{subscription_id}/asset_assignment | Assign assets to a subscription based on a filter
[**CreateSubscription**](SubscriptionApi.md#createsubscription) | **POST** /subscriptions | Create a new subscription
[**DeleteSubscription**](SubscriptionApi.md#deletesubscription) | **DELETE** /subscriptions/{id} | Delete a subscription
[**DeleteSubscriptionSeat**](SubscriptionApi.md#deletesubscriptionseat) | **DELETE** /subscription/seats/{id} | Delete a subscription seat
[**GetAssetsOfSubscription**](SubscriptionApi.md#getassetsofsubscription) | **GET** /subscriptions/{subscription_id}/assets | Get all assets of one subscription
[**GetSeatUsersOfSubscription**](SubscriptionApi.md#getseatusersofsubscription) | **GET** /subscriptions/{subscription_id}/seats | Get all users or invited emails having a seat in subscription
[**GetSpecificationsOfSubscription**](SubscriptionApi.md#getspecificationsofsubscription) | **GET** /subscriptions/{subscription_id}/specifications | Get specifications of a subscription
[**GetSubscriptionById**](SubscriptionApi.md#getsubscriptionbyid) | **GET** /subscriptions/{id} | Get a single subscription
[**GetSubscriptionSeats**](SubscriptionApi.md#getsubscriptionseats) | **GET** /subscription/seats | Get a range of subscription seats
[**GetSubscriptions**](SubscriptionApi.md#getsubscriptions) | **GET** /subscriptions | Get a range of subscriptions
[**RemoveAssetsFromSubscription**](SubscriptionApi.md#removeassetsfromsubscription) | **DELETE** /subscriptions/{subscription_id}/assets | Remove assets from a subscription
[**RemoveSeatUsersFromSubscription**](SubscriptionApi.md#removeseatusersfromsubscription) | **DELETE** /subscriptions/{subscription_id}/seats | Remove users (existing users) or emails (new users) from a seat in subscription
[**RemoveSpecificationsFromSubscriptions**](SubscriptionApi.md#removespecificationsfromsubscriptions) | **DELETE** /subscriptions/{subscription_id}/specifications | Delete specifications of a subscription
[**RenameSpecificationsOfSubscriptions**](SubscriptionApi.md#renamespecificationsofsubscriptions) | **PATCH** /subscriptions/{subscription_id}/specifications/rename | Rename a specification key
[**ReplaceAssetsOfSubscription**](SubscriptionApi.md#replaceassetsofsubscription) | **PATCH** /subscriptions/{subscription_id}/assets | Replace the assets of a subscription
[**UnassignAssetSetToSubscription**](SubscriptionApi.md#unassignassetsettosubscription) | **DELETE** /subscriptions/{subscription_id}/asset_assignment | Unassign assets to a subscription based on a filter
[**UpdateSpecificationsOfSubscriptions**](SubscriptionApi.md#updatespecificationsofsubscriptions) | **PATCH** /subscriptions/{subscription_id}/specifications | Update specifications of a subscription
[**UpdateSubscription**](SubscriptionApi.md#updatesubscription) | **PATCH** /subscriptions/{id} | Update a subscription
[**UpdateSubscriptionSeat**](SubscriptionApi.md#updatesubscriptionseat) | **PATCH** /subscription/seats/{id} | Update a subscription seat

<a name="addassetstosubscription"></a>
# **AddAssetsToSubscription**
> void AddAssetsToSubscription (AssetIDs body, long? subscriptionId)

Add assets to a subscription

Add one or more assets to a subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddAssetsToSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be added.
            var subscriptionId = 789;  // long? | Id of the subscription to which the assets will be added

            try
            {
                // Add assets to a subscription
                apiInstance.AddAssetsToSubscription(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.AddAssetsToSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be added. | 
 **subscriptionId** | **long?**| Id of the subscription to which the assets will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addseatuserstosubscription"></a>
# **AddSeatUsersToSubscription**
> void AddSeatUsersToSubscription (UserIDorEmails body, long? subscriptionId)

Add users (existing users) or emails (new users) to a seat in subscription

Add one or more users to a seat in subscription. User can only have one subscription per service (as seat user or as owner), the amount of available seats is defined in seat_quota of subscription. One or more emails can also be sent for users that do not yet exist in Netilion, the users emails will then be invited to join Netilion. ```Either id or email pro entry should be provided (not both).``` If an email is provided for existing user, then given user will be used.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddSeatUsersToSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var body = new UserIDorEmails(); // UserIDorEmails | Resources that shall be added.
            var subscriptionId = 789;  // long? | Id of the subscription to which the user will be added

            try
            {
                // Add users (existing users) or emails (new users) to a seat in subscription
                apiInstance.AddSeatUsersToSubscription(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.AddSeatUsersToSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDorEmails**](UserIDorEmails.md)| Resources that shall be added. | 
 **subscriptionId** | **long?**| Id of the subscription to which the user will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assignassetsettosubscription"></a>
# **AssignAssetSetToSubscription**
> void AssignAssetSetToSubscription (SubscriptionAssetAssignmentRequest body, long? subscriptionId)

Assign assets to a subscription based on a filter

Assign one or more assets to a subscription based on a filter. Body may contain an object id and type which then will return all assets assigned to that object directly or indirectly (through other objects). Body may contain an index search query to search assets based on a set of fields (like in the /search endpoint), only assets matching that search will be returned. Body may combine these conditions or even may contain none of them (in the latter case all readable assets is used). The assets returned from the filter are then assigned to the subscription. An error is raised if the filter given, does not contain any asset. If an asset is already assigned, it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AssignAssetSetToSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var body = new SubscriptionAssetAssignmentRequest(); // SubscriptionAssetAssignmentRequest | Resources that shall be added.
            var subscriptionId = 789;  // long? | Id of the subscription to which the assets will be added

            try
            {
                // Assign assets to a subscription based on a filter
                apiInstance.AssignAssetSetToSubscription(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.AssignAssetSetToSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscriptionAssetAssignmentRequest**](SubscriptionAssetAssignmentRequest.md)| Resources that shall be added. | 
 **subscriptionId** | **long?**| Id of the subscription to which the assets will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createsubscription"></a>
# **CreateSubscription**
> SubscriptionResponse CreateSubscription (SubscriptionRequest body)

Create a new subscription

Creates a new subscription. Only available for technical_users of the client_application and admins. Setting a successor or predecessor is possible. The client_application and user of the given Subscription and the reference Subscription have to match to do so.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var body = new SubscriptionRequest(); // SubscriptionRequest | subscription body

            try
            {
                // Create a new subscription
                SubscriptionResponse result = apiInstance.CreateSubscription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.CreateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscriptionRequest**](SubscriptionRequest.md)| subscription body | 

### Return type

[**SubscriptionResponse**](SubscriptionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (long? id)

Delete a subscription

Delete a specific subscription identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var id = 789;  // long? | Id of the subscription

            try
            {
                // Delete a subscription
                apiInstance.DeleteSubscription(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.DeleteSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the subscription | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesubscriptionseat"></a>
# **DeleteSubscriptionSeat**
> void DeleteSubscriptionSeat (long? id)

Delete a subscription seat

Delete a specific subscription seat identified by the id in the URL. This operation does send notification emails to the subscription owner, so it should be used by the invited user.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteSubscriptionSeatExample
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

            var apiInstance = new SubscriptionApi();
            var id = 789;  // long? | Id of the subscription seat

            try
            {
                // Delete a subscription seat
                apiInstance.DeleteSubscriptionSeat(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.DeleteSubscriptionSeat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the subscription seat | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetsofsubscription"></a>
# **GetAssetsOfSubscription**
> AssetsResponse GetAssetsOfSubscription (long? subscriptionId, int? page = null, int? perPage = null, string include = null, string serialNumber = null, string productId = null, string productCategoryId = null, string parentId = null, string manufacturerId = null, string statusId = null, string statusCode = null, DateTime? productionDate = null, DateTime? productionDateFrom = null, DateTime? productionDateTo = null, string specificationsKey = null, string specificationsValue = null, string nodeId = null, DateTime? createdAt = null, string createdAtFrom = null, string createdAtTo = null, DateTime? updatedAt = null, string updatedAtFrom = null, string updatedAtTo = null, bool? ownershipClaimed = null, string permission = null, string orderBy = null)

Get all assets of one subscription

Returns a list of all assets that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```status, tenant, parent, pictures, product, product.manufacturer, product.pictures, product.status, product.categories, product.categories.parent, specifications, specifications[key1,key2], product.tenant,                             product.manufacturer.tenant, status.tenant, instrumentations ```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetsOfSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var subscriptionId = 789;  // long? | The resource defined in the URL
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
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `serial_number`, `created_at` or `updated_at`, `last_seen_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all assets of one subscription
                AssetsResponse result = apiInstance.GetAssetsOfSubscription(subscriptionId, page, perPage, include, serialNumber, productId, productCategoryId, parentId, manufacturerId, statusId, statusCode, productionDate, productionDateFrom, productionDateTo, specificationsKey, specificationsValue, nodeId, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, ownershipClaimed, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetAssetsOfSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **long?**| The resource defined in the URL | 
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
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;serial_number&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, &#x60;last_seen_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**AssetsResponse**](AssetsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getseatusersofsubscription"></a>
# **GetSeatUsersOfSubscription**
> SubscriptionSeatsResponse GetSeatUsersOfSubscription (long? subscriptionId, int? page = null, int? perPage = null, string include = null, string email = null, long? userId = null, string status = null, string orderBy = null)

Get all users or invited emails having a seat in subscription

Returns a list of all users or emails.  Possible include values: ```subscription```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSeatUsersOfSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var subscriptionId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var email = email_example;  // string | Filter accepts `*` as wildcard (optional) 
            var userId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var status = status_example;  // string | one or multiple statuses (comma list). Allowed values are `pending`, `invited`, `accepted` (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all users or invited emails having a seat in subscription
                SubscriptionSeatsResponse result = apiInstance.GetSeatUsersOfSubscription(subscriptionId, page, perPage, include, email, userId, status, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSeatUsersOfSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **email** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **userId** | **long?**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **status** | **string**| one or multiple statuses (comma list). Allowed values are &#x60;pending&#x60;, &#x60;invited&#x60;, &#x60;accepted&#x60; | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**SubscriptionSeatsResponse**](SubscriptionSeatsResponse.md)

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

            var apiInstance = new SubscriptionApi();
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
                Debug.Print("Exception when calling SubscriptionApi.GetSpecificationsOfSubscription: " + e.Message );
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
<a name="getsubscriptionbyid"></a>
# **GetSubscriptionById**
> SubscriptionResponse GetSubscriptionById (long? id, string include = null)

Get a single subscription

Get a specific subscription identified by the id in the URL.  Possible include values: ```user, user.usage, specifications, specifications[key1,key2], customer``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSubscriptionByIdExample
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

            var apiInstance = new SubscriptionApi();
            var id = 789;  // long? | Id of the subscription to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single subscription
                SubscriptionResponse result = apiInstance.GetSubscriptionById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscriptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the subscription to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**SubscriptionResponse**](SubscriptionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubscriptionseats"></a>
# **GetSubscriptionSeats**
> SubscriptionSeatsResponse GetSubscriptionSeats (int? page = null, int? perPage = null, string include = null, string email = null, long? userId = null, string status = null, long? clientApplicationId = null, string orderBy = null)

Get a range of subscription seats

Returns a list of subscriptions seats.  Possible include values: ```subscription, subscription.user``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSubscriptionSeatsExample
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

            var apiInstance = new SubscriptionApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var email = email_example;  // string | Filter accepts `*` as wildcard (optional) 
            var userId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var status = status_example;  // string | one or multiple statuses (comma list). Allowed values are `pending`, `invited`, `accepted` (optional) 
            var clientApplicationId = 789;  // long? | Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of subscription seats
                SubscriptionSeatsResponse result = apiInstance.GetSubscriptionSeats(page, perPage, include, email, userId, status, clientApplicationId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscriptionSeats: " + e.Message );
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
 **email** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **userId** | **long?**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **status** | **string**| one or multiple statuses (comma list). Allowed values are &#x60;pending&#x60;, &#x60;invited&#x60;, &#x60;accepted&#x60; | [optional] 
 **clientApplicationId** | **long?**| Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**SubscriptionSeatsResponse**](SubscriptionSeatsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubscriptions"></a>
# **GetSubscriptions**
> SubscriptionsResponse GetSubscriptions (int? page = null, int? perPage = null, string include = null, long? userId = null, long? clientApplicationId = null, string externalReference = null, string status = null, string notificationStatus = null, string specificationsKey = null, string specificationsValue = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? createdAt = null, string createdAtFrom = null, string createdAtTo = null, DateTime? updatedAt = null, string updatedAtFrom = null, string updatedAtTo = null, string scope = null, string resellerLabel = null, string customerId = null, string orderBy = null)

Get a range of subscriptions

Returns a list of subscriptions.  Possible include values: ```user, user.usage, specifications, specifications[key1,key2], customer``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSubscriptionsExample
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

            var apiInstance = new SubscriptionApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var userId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var clientApplicationId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var externalReference = externalReference_example;  // string | Filter accepts `*` as wildcard (optional) 
            var status = status_example;  // string | one or multiple statuses (comma list). Allowed values are `open`, `payment_required`, `confirmed`, `scheduled_update`, `non_renewing` and `cancelled` (optional) 
            var notificationStatus = notificationStatus_example;  // string | Filter by notification status - no wildcard support (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var startDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var endDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var createdAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var createdAtTo = createdAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var updatedAtFrom = updatedAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = updatedAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var scope = scope_example;  // string | Filter accepts `RESELLER`, `USER` or `USABLE`.`RESELLER` can be used for reseller users to get subscriptions that they sold to other users. `USER` returns all subscriptions where the user is the owner, is a seat user or has can_read permissions to access the subscription, for a reseller the subscriptions returned from `RESELLER` filter are excluded from the `USER` result. The result of `USER` can include usable and not usable subscriptions. Subscription is marked as usable if it can be used in the applications to access data. `USABLE` filter retruns a subset of the `USER` result which excludes subscriptions that are only visible because of the can_read permission (not usable). (optional) 
            var resellerLabel = resellerLabel_example;  // string | Filter accepts `*` as wildcard. Filter acccepts \"null\" for all objects with no reseller label or \"!null\" for all with any reseller label (optional) 
            var customerId = customerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of subscriptions
                SubscriptionsResponse result = apiInstance.GetSubscriptions(page, perPage, include, userId, clientApplicationId, externalReference, status, notificationStatus, specificationsKey, specificationsValue, startDate, endDate, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, scope, resellerLabel, customerId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscriptions: " + e.Message );
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
 **notificationStatus** | **string**| Filter by notification status - no wildcard support | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **startDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **endDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **createdAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **createdAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **createdAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **updatedAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **scope** | **string**| Filter accepts &#x60;RESELLER&#x60;, &#x60;USER&#x60; or &#x60;USABLE&#x60;.&#x60;RESELLER&#x60; can be used for reseller users to get subscriptions that they sold to other users. &#x60;USER&#x60; returns all subscriptions where the user is the owner, is a seat user or has can_read permissions to access the subscription, for a reseller the subscriptions returned from &#x60;RESELLER&#x60; filter are excluded from the &#x60;USER&#x60; result. The result of &#x60;USER&#x60; can include usable and not usable subscriptions. Subscription is marked as usable if it can be used in the applications to access data. &#x60;USABLE&#x60; filter retruns a subset of the &#x60;USER&#x60; result which excludes subscriptions that are only visible because of the can_read permission (not usable). | [optional] 
 **resellerLabel** | **string**| Filter accepts &#x60;*&#x60; as wildcard. Filter acccepts \&quot;null\&quot; for all objects with no reseller label or \&quot;!null\&quot; for all with any reseller label | [optional] 
 **customerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**SubscriptionsResponse**](SubscriptionsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeassetsfromsubscription"></a>
# **RemoveAssetsFromSubscription**
> void RemoveAssetsFromSubscription (AssetIDs body, long? subscriptionId)

Remove assets from a subscription

Remove one or more assets from a subscription in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveAssetsFromSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be removed.
            var subscriptionId = 789;  // long? | Id of the subscription from which the assets will be removed

            try
            {
                // Remove assets from a subscription
                apiInstance.RemoveAssetsFromSubscription(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.RemoveAssetsFromSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be removed. | 
 **subscriptionId** | **long?**| Id of the subscription from which the assets will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeseatusersfromsubscription"></a>
# **RemoveSeatUsersFromSubscription**
> void RemoveSeatUsersFromSubscription (UserIDorEmails body, long? subscriptionId)

Remove users (existing users) or emails (new users) from a seat in subscription

Remove one or more users or emails from a seat in subscription. **Either id or email pro entry should be provided (not both).** If an email is provided for existing user, then given user will be used. This operation does send notification emails to the seat user, so it should be used by the owner to remove seats.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSeatUsersFromSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var body = new UserIDorEmails(); // UserIDorEmails | Resources that shall be removed.
            var subscriptionId = 789;  // long? | Id of the subscription from which the user will be removed

            try
            {
                // Remove users (existing users) or emails (new users) from a seat in subscription
                apiInstance.RemoveSeatUsersFromSubscription(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.RemoveSeatUsersFromSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDorEmails**](UserIDorEmails.md)| Resources that shall be removed. | 
 **subscriptionId** | **long?**| Id of the subscription from which the user will be removed | 

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

            var apiInstance = new SubscriptionApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var subscriptionId = 789;  // long? | Id of the specified subscription

            try
            {
                // Delete specifications of a subscription
                apiInstance.RemoveSpecificationsFromSubscriptions(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.RemoveSpecificationsFromSubscriptions: " + e.Message );
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

            var apiInstance = new SubscriptionApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var subscriptionId = 789;  // long? | Id of the specified subscription

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfSubscriptions(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.RenameSpecificationsOfSubscriptions: " + e.Message );
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
<a name="replaceassetsofsubscription"></a>
# **ReplaceAssetsOfSubscription**
> void ReplaceAssetsOfSubscription (AssetIDs body, long? subscriptionId)

Replace the assets of a subscription

Replaces all assets belonging to a subscription in your accessible scope. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceAssetsOfSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be replaced
            var subscriptionId = 789;  // long? | Id of the subscription of which the assets will be replaced

            try
            {
                // Replace the assets of a subscription
                apiInstance.ReplaceAssetsOfSubscription(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ReplaceAssetsOfSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be replaced | 
 **subscriptionId** | **long?**| Id of the subscription of which the assets will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="unassignassetsettosubscription"></a>
# **UnassignAssetSetToSubscription**
> void UnassignAssetSetToSubscription (SubscriptionAssetAssignmentRequest body, long? subscriptionId)

Unassign assets to a subscription based on a filter

Unassign one or more assets to a subscription based on a filter. Body may contain an object id and type which then will return all assets assigned to that object directly or indirectly (through other objects). Body may contain an index search query to search assets based on a set of fields (like in the /search endpoint), only assets matching that search will be returned. Body may combine these conditions or even may contain none of them (in the latter case all readable assets is used). The assets returned from the filter are then unassigned to the subscription. An error is raised if the filter given, does not contain any asset. If an asset is already unassigned, it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UnassignAssetSetToSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var body = new SubscriptionAssetAssignmentRequest(); // SubscriptionAssetAssignmentRequest | Resources that shall be added.
            var subscriptionId = 789;  // long? | Id of the subscription to which the assets will be added

            try
            {
                // Unassign assets to a subscription based on a filter
                apiInstance.UnassignAssetSetToSubscription(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.UnassignAssetSetToSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscriptionAssetAssignmentRequest**](SubscriptionAssetAssignmentRequest.md)| Resources that shall be added. | 
 **subscriptionId** | **long?**| Id of the subscription to which the assets will be added | 

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

            var apiInstance = new SubscriptionApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var subscriptionId = 789;  // long? | Id of the specified subscription

            try
            {
                // Update specifications of a subscription
                apiInstance.UpdateSpecificationsOfSubscriptions(body, subscriptionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.UpdateSpecificationsOfSubscriptions: " + e.Message );
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
<a name="updatesubscription"></a>
# **UpdateSubscription**
> void UpdateSubscription (SubscriptionRequest body, long? id)

Update a subscription

Update accessible parameters of the requested resource. Setting a successor or predecessor is possible. The client_application and user of the given Subscription and the reference Subscription have to match to do so. The successor/predecessor of a subscription cant be itself

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSubscriptionExample
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

            var apiInstance = new SubscriptionApi();
            var body = new SubscriptionRequest(); // SubscriptionRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the subscription to update

            try
            {
                // Update a subscription
                apiInstance.UpdateSubscription(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.UpdateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscriptionRequest**](SubscriptionRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the subscription to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesubscriptionseat"></a>
# **UpdateSubscriptionSeat**
> void UpdateSubscriptionSeat (SubscriptionSeatPatch body, long? id)

Update a subscription seat

Update the status of a subscription seat

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSubscriptionSeatExample
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

            var apiInstance = new SubscriptionApi();
            var body = new SubscriptionSeatPatch(); // SubscriptionSeatPatch | Parameters that shall be updated.
            var id = 789;  // long? | Id of the subscription seat to update

            try
            {
                // Update a subscription seat
                apiInstance.UpdateSubscriptionSeat(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.UpdateSubscriptionSeat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscriptionSeatPatch**](SubscriptionSeatPatch.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the subscription seat to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
