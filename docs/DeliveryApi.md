# Netilion.Api.Api.DeliveryApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAssetsToDelivery**](DeliveryApi.md#addassetstodelivery) | **POST** /deliveries/{delivery_id}/assets | Add assets to a delivery
[**AddDocumentsToDelivery**](DeliveryApi.md#adddocumentstodelivery) | **POST** /deliveries/{delivery_id}/documents | Add documents to a delivery
[**AddPurchaseOrdersToDelivery**](DeliveryApi.md#addpurchaseorderstodelivery) | **POST** /deliveries/{delivery_id}/purchase_orders | Add all purchase oders to a delivery
[**CreateDelivery**](DeliveryApi.md#createdelivery) | **POST** /deliveries | Create a new delivery
[**DeleteDelivery**](DeliveryApi.md#deletedelivery) | **DELETE** /deliveries/{id} | Delete a delivery
[**GetAssetsOfDelivery**](DeliveryApi.md#getassetsofdelivery) | **GET** /deliveries/{delivery_id}/assets | Get all assets of one delivery
[**GetDeliveries**](DeliveryApi.md#getdeliveries) | **GET** /deliveries | Get a range of deliveries
[**GetDeliveryById**](DeliveryApi.md#getdeliverybyid) | **GET** /deliveries/{id} | Get a single delivery
[**GetDeliveryIdStatus**](DeliveryApi.md#getdeliveryidstatus) | **GET** /deliveries/{delivery_id}/status | Get the status of the specific delivery
[**GetDocumentsOfDelivery**](DeliveryApi.md#getdocumentsofdelivery) | **GET** /deliveries/{delivery_id}/documents | Get all documents of one delivery
[**GetPurchaseOrdersOfDelivery**](DeliveryApi.md#getpurchaseordersofdelivery) | **GET** /deliveries/{delivery_id}/purchase_orders | Get all purchase orders of one delivery
[**RemoveAssetsFromDelivery**](DeliveryApi.md#removeassetsfromdelivery) | **DELETE** /deliveries/{delivery_id}/assets | Remove assets from a delivery
[**RemoveDocumentsFromDelivery**](DeliveryApi.md#removedocumentsfromdelivery) | **DELETE** /deliveries/{delivery_id}/documents | Remove documents from a delivery
[**RemovePurchaseOrdersFromDelivery**](DeliveryApi.md#removepurchaseordersfromdelivery) | **DELETE** /deliveries/{delivery_id}/purchase_orders | Remove purchase orders from a delivery
[**ReplaceAssetsOfDelivery**](DeliveryApi.md#replaceassetsofdelivery) | **PATCH** /deliveries/{delivery_id}/assets | Replace the assets of a delivery
[**ReplaceDocumentsOfDelivery**](DeliveryApi.md#replacedocumentsofdelivery) | **PATCH** /deliveries/{delivery_id}/documents | Replace the documents of a delivery
[**ReplacePurchaseOrdersOfDelivery**](DeliveryApi.md#replacepurchaseordersofdelivery) | **PATCH** /deliveries/{delivery_id}/purchase_orders | Replace the purchase orders of a delivery
[**UpdateDelivery**](DeliveryApi.md#updatedelivery) | **PATCH** /deliveries/{id} | Update a delivery

<a name="addassetstodelivery"></a>
# **AddAssetsToDelivery**
> void AddAssetsToDelivery (AssetIDs body, long? deliveryId)

Add assets to a delivery

Add one or more assets to a delivery.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddAssetsToDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be added.
            var deliveryId = 789;  // long? | Id of the delivery to which the assets will be added

            try
            {
                // Add assets to a delivery
                apiInstance.AddAssetsToDelivery(body, deliveryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.AddAssetsToDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be added. | 
 **deliveryId** | **long?**| Id of the delivery to which the assets will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adddocumentstodelivery"></a>
# **AddDocumentsToDelivery**
> void AddDocumentsToDelivery (DocumentIDs body, long? deliveryId)

Add documents to a delivery

Add one or more documents to a delivery.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDocumentsToDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be added.
            var deliveryId = 789;  // long? | Id of the delivery to which the documents will be added

            try
            {
                // Add documents to a delivery
                apiInstance.AddDocumentsToDelivery(body, deliveryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.AddDocumentsToDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be added. | 
 **deliveryId** | **long?**| Id of the delivery to which the documents will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addpurchaseorderstodelivery"></a>
# **AddPurchaseOrdersToDelivery**
> void AddPurchaseOrdersToDelivery (PurchaseOrderIDs body, long? deliveryId)

Add all purchase oders to a delivery

Add one or more all purchase oders to a delivery.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddPurchaseOrdersToDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new PurchaseOrderIDs(); // PurchaseOrderIDs | Resources that shall be added.
            var deliveryId = 789;  // long? | Id of the delivery to which the all purchase oders will be added

            try
            {
                // Add all purchase oders to a delivery
                apiInstance.AddPurchaseOrdersToDelivery(body, deliveryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.AddPurchaseOrdersToDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderIDs**](PurchaseOrderIDs.md)| Resources that shall be added. | 
 **deliveryId** | **long?**| Id of the delivery to which the all purchase oders will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createdelivery"></a>
# **CreateDelivery**
> DeliveryResponse CreateDelivery (DeliveryRequest body)

Create a new delivery

Delivery must have a name, number, sender, receiver and a status.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new DeliveryRequest(); // DeliveryRequest | Delivery to create

            try
            {
                // Create a new delivery
                DeliveryResponse result = apiInstance.CreateDelivery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.CreateDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryRequest**](DeliveryRequest.md)| Delivery to create | 

### Return type

[**DeliveryResponse**](DeliveryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletedelivery"></a>
# **DeleteDelivery**
> void DeleteDelivery (long? id)

Delete a delivery

Delete a specific resource in your accessible scope, identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var id = 789;  // long? | Id of the delivery to delete

            try
            {
                // Delete a delivery
                apiInstance.DeleteDelivery(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.DeleteDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the delivery to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetsofdelivery"></a>
# **GetAssetsOfDelivery**
> AssetsResponse GetAssetsOfDelivery (long? deliveryId, int? page = null, int? perPage = null, string include = null, string serialNumber = null, string productId = null, string categoryId = null, string parentId = null, string manufacturerId = null, string statusId = null, string statusCode = null, DateTime? productionDate = null, DateTime? productionDateFrom = null, DateTime? productionDateTo = null, string specificationsKey = null, string specificationsValue = null, DateTime? createdAt = null, string createdAtFrom = null, string createdAtTo = null, DateTime? updatedAt = null, string updatedAtFrom = null, string updatedAtTo = null, bool? ownershipClaimed = null, string permission = null, string orderBy = null)

Get all assets of one delivery

Returns a list of all assets that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```status, tenant, parent, pictures, product, product.manufacturer, product.pictures, product.status, product.categories, product.categories.parent, specifications, specifications[key1,key2], product.tenant, product.manufacturer.tenant, status.tenant, instrumentations ```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetsOfDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var deliveryId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var serialNumber = serialNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productId = productId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusCode = statusCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productionDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
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
                // Get all assets of one delivery
                AssetsResponse result = apiInstance.GetAssetsOfDelivery(deliveryId, page, perPage, include, serialNumber, productId, categoryId, parentId, manufacturerId, statusId, statusCode, productionDate, productionDateFrom, productionDateTo, specificationsKey, specificationsValue, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, ownershipClaimed, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetAssetsOfDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **serialNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productionDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
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
<a name="getdeliveries"></a>
# **GetDeliveries**
> DeliveriesResponse GetDeliveries (int? page = null, int? perPage = null, string number = null, string name = null, string statusId = null, DateTime? dateOfShipment = null, DateTime? dateOfShipmentFrom = null, DateTime? dateOfShipmentTo = null, string senderId = null, string receiverId = null, string customerNumber = null, string orderBy = null)

Get a range of deliveries

Returns a list of deliveries in your accessible scope. If the query has no matches, the response is an empty list. Only deliveries on which the user has the can_read permission are loaded

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDeliveriesExample
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

            var apiInstance = new DeliveryApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var dateOfShipment = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var dateOfShipmentFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var dateOfShipmentTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var senderId = senderId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var receiverId = receiverId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var customerNumber = customerNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of deliveries
                DeliveriesResponse result = apiInstance.GetDeliveries(page, perPage, number, name, statusId, dateOfShipment, dateOfShipmentFrom, dateOfShipmentTo, senderId, receiverId, customerNumber, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetDeliveries: " + e.Message );
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
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **dateOfShipment** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **dateOfShipmentFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **dateOfShipmentTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **senderId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **receiverId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **customerNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**DeliveriesResponse**](DeliveriesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdeliverybyid"></a>
# **GetDeliveryById**
> DeliveryResponse GetDeliveryById (long? id)

Get a single delivery

Get a specific delivery in your accessible scope, identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDeliveryByIdExample
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

            var apiInstance = new DeliveryApi();
            var id = 789;  // long? | Id of the delivery to fetch

            try
            {
                // Get a single delivery
                DeliveryResponse result = apiInstance.GetDeliveryById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetDeliveryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the delivery to fetch | 

### Return type

[**DeliveryResponse**](DeliveryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdeliveryidstatus"></a>
# **GetDeliveryIdStatus**
> DeliveryStatusResponse GetDeliveryIdStatus (long? deliveryId, string include = null, string acceptLanguage = null)

Get the status of the specific delivery

Returns the status of the delivery. You can apply the query parameters listed below to get a filtered list. Required Permissions: ```can_read``` Parameters supporting translation: ```name, description```. To add a translation set Content-Language. Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDeliveryIdStatusExample
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

            var apiInstance = new DeliveryApi();
            var deliveryId = 789;  // long? | Id of the specified delivery
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the status of the specific delivery
                DeliveryStatusResponse result = apiInstance.GetDeliveryIdStatus(deliveryId, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetDeliveryIdStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryId** | **long?**| Id of the specified delivery | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**DeliveryStatusResponse**](DeliveryStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdocumentsofdelivery"></a>
# **GetDocumentsOfDelivery**
> DocumentsResponse GetDocumentsOfDelivery (long? deliveryId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string orderBy = null, string acceptLanguage = null)

Get all documents of one delivery

Returns a list of documents. If the query has no matches, the response is an empty list.  Possible include values: ```status, tenant, classification, categories, categories.parent, categories.standards, attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var deliveryId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var documentVersion = documentVersion_example;  // string | Filter accepts `*` as wildcard (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var classificationId = classificationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var validFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntil = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD or YYYY-MM or YYYY (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all documents of one delivery
                DocumentsResponse result = apiInstance.GetDocumentsOfDelivery(deliveryId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetDocumentsOfDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **documentVersion** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **classificationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **validFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntil** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validAt** | **DateTime?**| Expected date format is YYYY-MM-DD or YYYY-MM or YYYY | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**DocumentsResponse**](DocumentsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpurchaseordersofdelivery"></a>
# **GetPurchaseOrdersOfDelivery**
> PurchaseOrdersResponse GetPurchaseOrdersOfDelivery (long? deliveryId, int? page = null, int? perPage = null, string name = null, string number = null, string statusId = null, string date = null, string dateFrom = null, string dateTo = null, string senderId = null, string receiverId = null, string quotationId = null, string customerNumber = null, string orderBy = null)

Get all purchase orders of one delivery

Returns a list of all all purchase oder that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPurchaseOrdersOfDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var deliveryId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var date = date_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateFrom = dateFrom_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateTo = dateTo_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var senderId = senderId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var receiverId = receiverId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var quotationId = quotationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var customerNumber = customerNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all purchase orders of one delivery
                PurchaseOrdersResponse result = apiInstance.GetPurchaseOrdersOfDelivery(deliveryId, page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, quotationId, customerNumber, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetPurchaseOrdersOfDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **date** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateFrom** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateTo** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **senderId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **receiverId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **quotationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **customerNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**PurchaseOrdersResponse**](PurchaseOrdersResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeassetsfromdelivery"></a>
# **RemoveAssetsFromDelivery**
> void RemoveAssetsFromDelivery (AssetIDs body, long? deliveryId)

Remove assets from a delivery

Remove one or more assets from a delivery in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveAssetsFromDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be removed.
            var deliveryId = 789;  // long? | Id of the delivery from which the assets will be removed

            try
            {
                // Remove assets from a delivery
                apiInstance.RemoveAssetsFromDelivery(body, deliveryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.RemoveAssetsFromDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be removed. | 
 **deliveryId** | **long?**| Id of the delivery from which the assets will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removedocumentsfromdelivery"></a>
# **RemoveDocumentsFromDelivery**
> void RemoveDocumentsFromDelivery (DocumentIDs body, long? deliveryId)

Remove documents from a delivery

Remove one or more documents from a delivery in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDocumentsFromDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be removed.
            var deliveryId = 789;  // long? | Id of the delivery from which the documents will be removed

            try
            {
                // Remove documents from a delivery
                apiInstance.RemoveDocumentsFromDelivery(body, deliveryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.RemoveDocumentsFromDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be removed. | 
 **deliveryId** | **long?**| Id of the delivery from which the documents will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removepurchaseordersfromdelivery"></a>
# **RemovePurchaseOrdersFromDelivery**
> void RemovePurchaseOrdersFromDelivery (PurchaseOrderIDs body, long? deliveryId)

Remove purchase orders from a delivery

Remove one or more purchase orders from a delivery in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemovePurchaseOrdersFromDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new PurchaseOrderIDs(); // PurchaseOrderIDs | Resources that shall be removed.
            var deliveryId = 789;  // long? | Id of the delivery from which the purchase orders will be removed

            try
            {
                // Remove purchase orders from a delivery
                apiInstance.RemovePurchaseOrdersFromDelivery(body, deliveryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.RemovePurchaseOrdersFromDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderIDs**](PurchaseOrderIDs.md)| Resources that shall be removed. | 
 **deliveryId** | **long?**| Id of the delivery from which the purchase orders will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceassetsofdelivery"></a>
# **ReplaceAssetsOfDelivery**
> void ReplaceAssetsOfDelivery (AssetIDs body, long? deliveryId)

Replace the assets of a delivery

Replaces all assets belonging to a delivery. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceAssetsOfDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be replaced
            var deliveryId = 789;  // long? | Id of the delivery of which the assets will be replaced

            try
            {
                // Replace the assets of a delivery
                apiInstance.ReplaceAssetsOfDelivery(body, deliveryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.ReplaceAssetsOfDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be replaced | 
 **deliveryId** | **long?**| Id of the delivery of which the assets will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedocumentsofdelivery"></a>
# **ReplaceDocumentsOfDelivery**
> void ReplaceDocumentsOfDelivery (DocumentIDs body, long? deliveryId)

Replace the documents of a delivery

Replaces all documents belonging to a delivery. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDocumentsOfDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be replaced
            var deliveryId = 789;  // long? | Id of the delivery of which the documents will be replaced

            try
            {
                // Replace the documents of a delivery
                apiInstance.ReplaceDocumentsOfDelivery(body, deliveryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.ReplaceDocumentsOfDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be replaced | 
 **deliveryId** | **long?**| Id of the delivery of which the documents will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacepurchaseordersofdelivery"></a>
# **ReplacePurchaseOrdersOfDelivery**
> void ReplacePurchaseOrdersOfDelivery (PurchaseOrderIDs body, long? deliveryId)

Replace the purchase orders of a delivery

Replaces all purchase orders belonging to a delivery. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplacePurchaseOrdersOfDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new PurchaseOrderIDs(); // PurchaseOrderIDs | Resources that shall be replaced
            var deliveryId = 789;  // long? | Id of the delivery of which the purchase orders will be replaced

            try
            {
                // Replace the purchase orders of a delivery
                apiInstance.ReplacePurchaseOrdersOfDelivery(body, deliveryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.ReplacePurchaseOrdersOfDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderIDs**](PurchaseOrderIDs.md)| Resources that shall be replaced | 
 **deliveryId** | **long?**| Id of the delivery of which the purchase orders will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatedelivery"></a>
# **UpdateDelivery**
> void UpdateDelivery (DeliveryRequest body, long? id)

Update a delivery

Update accessible parameters of the requested resource in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateDeliveryExample
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

            var apiInstance = new DeliveryApi();
            var body = new DeliveryRequest(); // DeliveryRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the delivery to update

            try
            {
                // Update a delivery
                apiInstance.UpdateDelivery(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryApi.UpdateDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryRequest**](DeliveryRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the delivery to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
