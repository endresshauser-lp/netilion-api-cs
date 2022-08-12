# Netilion.Api.Api.PurchaseOrderApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDeliviersToPurchaseOrder**](PurchaseOrderApi.md#adddelivierstopurchaseorder) | **POST** /purchase_orders/{purchase_order_id}/deliveries | Add deliveries to a purchase order
[**AddDocumentsToPurchaseOrder**](PurchaseOrderApi.md#adddocumentstopurchaseorder) | **POST** /purchase_orders/{purchase_order_id}/documents | Add documents to a purchase order
[**AddProductsToPurchaseOrder**](PurchaseOrderApi.md#addproductstopurchaseorder) | **POST** /purchase_orders/{purchase_order_id}/products | Add products to a purchase order
[**CreatePurchaseOrder**](PurchaseOrderApi.md#createpurchaseorder) | **POST** /purchase_orders | Create a new purchase order
[**DeletePurchaseOrder**](PurchaseOrderApi.md#deletepurchaseorder) | **DELETE** /purchase_orders/{id} | Delete a purchase order
[**GetDeliviersOfPurchaseOrder**](PurchaseOrderApi.md#getdeliviersofpurchaseorder) | **GET** /purchase_orders/{purchase_order_id}/deliveries | Get all deliveries of one purchase order
[**GetDocumentsOfPurchaseOrder**](PurchaseOrderApi.md#getdocumentsofpurchaseorder) | **GET** /purchase_orders/{purchase_order_id}/documents | Get all documents of one purchase order
[**GetProductsOfPurchaseOrder**](PurchaseOrderApi.md#getproductsofpurchaseorder) | **GET** /purchase_orders/{purchase_order_id}/products | Get all products of one purchase
[**GetPurchaseOrderById**](PurchaseOrderApi.md#getpurchaseorderbyid) | **GET** /purchase_orders/{id} | Get a single purchase order
[**GetPurchaseOrderIdStatus**](PurchaseOrderApi.md#getpurchaseorderidstatus) | **GET** /purchase_orders/{purchase_order_id}/status | Get the status of the specific purchase order
[**GetPurchaseOrders**](PurchaseOrderApi.md#getpurchaseorders) | **GET** /purchase_orders | Get a range of purchase orders
[**RemoveDeliviersFromPurchaseOrder**](PurchaseOrderApi.md#removedeliviersfrompurchaseorder) | **DELETE** /purchase_orders/{purchase_order_id}/deliveries | Remove deliveries from a purchase order
[**RemoveDocumentsFromPurchaseOrder**](PurchaseOrderApi.md#removedocumentsfrompurchaseorder) | **DELETE** /purchase_orders/{purchase_order_id}/documents | Remove documents from a purchase order
[**RemoveProductsFromPurchaseOrder**](PurchaseOrderApi.md#removeproductsfrompurchaseorder) | **DELETE** /purchase_orders/{purchase_order_id}/products | Remove products from a purchase order
[**ReplaceDeliviersOfPurchaseOrder**](PurchaseOrderApi.md#replacedeliviersofpurchaseorder) | **PATCH** /purchase_orders/{purchase_order_id}/deliveries | Replace the deliveries of a purchase order
[**ReplaceDocumentsOfPurchaseOrder**](PurchaseOrderApi.md#replacedocumentsofpurchaseorder) | **PATCH** /purchase_orders/{purchase_order_id}/documents | Replace the documents of a purchase order
[**ReplaceProductsOfPurchaseOrder**](PurchaseOrderApi.md#replaceproductsofpurchaseorder) | **PATCH** /purchase_orders/{purchase_order_id}/products | Replace the products of a purchase order
[**UpdateProductQuantitiesOfPurchaseOrder**](PurchaseOrderApi.md#updateproductquantitiesofpurchaseorder) | **PATCH** /purchase_orders/{purchase_order_id}/products/quantity | Change the product quantity in a purchase order
[**UpdatePurchaseOrder**](PurchaseOrderApi.md#updatepurchaseorder) | **PATCH** /purchase_orders/{id} | Update a purchase order

<a name="adddelivierstopurchaseorder"></a>
# **AddDeliviersToPurchaseOrder**
> void AddDeliviersToPurchaseOrder (DeliveryIDs body, long? purchaseOrderId)

Add deliveries to a purchase order

Add one or more deliveries to a purchase order.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDeliviersToPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new DeliveryIDs(); // DeliveryIDs | Resources that shall be added.
            var purchaseOrderId = 789;  // long? | Id of the purchase order to which the deliveries will be added

            try
            {
                // Add deliveries to a purchase order
                apiInstance.AddDeliviersToPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.AddDeliviersToPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryIDs**](DeliveryIDs.md)| Resources that shall be added. | 
 **purchaseOrderId** | **long?**| Id of the purchase order to which the deliveries will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adddocumentstopurchaseorder"></a>
# **AddDocumentsToPurchaseOrder**
> void AddDocumentsToPurchaseOrder (DocumentIDs body, long? purchaseOrderId)

Add documents to a purchase order

Add one or more documents to a purchase order.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDocumentsToPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be added.
            var purchaseOrderId = 789;  // long? | Id of the purchase order to which the documents will be added

            try
            {
                // Add documents to a purchase order
                apiInstance.AddDocumentsToPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.AddDocumentsToPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be added. | 
 **purchaseOrderId** | **long?**| Id of the purchase order to which the documents will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addproductstopurchaseorder"></a>
# **AddProductsToPurchaseOrder**
> void AddProductsToPurchaseOrder (ProductIDs body, long? purchaseOrderId)

Add products to a purchase order

Add one or more products to a purchase order.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddProductsToPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new ProductIDs(); // ProductIDs | Resources that shall be added.
            var purchaseOrderId = 789;  // long? | Id of the purchase order to which the products will be added

            try
            {
                // Add products to a purchase order
                apiInstance.AddProductsToPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.AddProductsToPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIDs**](ProductIDs.md)| Resources that shall be added. | 
 **purchaseOrderId** | **long?**| Id of the purchase order to which the products will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createpurchaseorder"></a>
# **CreatePurchaseOrder**
> PurchaseOrderResponse CreatePurchaseOrder (PurchaseOrderRequest body)

Create a new purchase order

Create a new purchase order with a sender and a receiver.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreatePurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new PurchaseOrderRequest(); // PurchaseOrderRequest | Object body that will be created.

            try
            {
                // Create a new purchase order
                PurchaseOrderResponse result = apiInstance.CreatePurchaseOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.CreatePurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderRequest**](PurchaseOrderRequest.md)| Object body that will be created. | 

### Return type

[**PurchaseOrderResponse**](PurchaseOrderResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepurchaseorder"></a>
# **DeletePurchaseOrder**
> void DeletePurchaseOrder (long? id)

Delete a purchase order

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
    public class DeletePurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var id = 789;  // long? | Id of the purchase order to delete

            try
            {
                // Delete a purchase order
                apiInstance.DeletePurchaseOrder(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.DeletePurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the purchase order to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdeliviersofpurchaseorder"></a>
# **GetDeliviersOfPurchaseOrder**
> DeliveriesResponse GetDeliviersOfPurchaseOrder (long? purchaseOrderId, int? page = null, int? perPage = null, string number = null, string name = null, DateTime? dateOfShipment = null, DateTime? dateOfShipmentFrom = null, DateTime? dateOfShipmentTo = null, string statusId = null, string senderId = null, string receiverId = null, string customerNumber = null, string orderBy = null)

Get all deliveries of one purchase order

Returns a list of all deliveries that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDeliviersOfPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var purchaseOrderId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var dateOfShipment = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var dateOfShipmentFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var dateOfShipmentTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var senderId = senderId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var receiverId = receiverId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var customerNumber = customerNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all deliveries of one purchase order
                DeliveriesResponse result = apiInstance.GetDeliviersOfPurchaseOrder(purchaseOrderId, page, perPage, number, name, dateOfShipment, dateOfShipmentFrom, dateOfShipmentTo, statusId, senderId, receiverId, customerNumber, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.GetDeliviersOfPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **dateOfShipment** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **dateOfShipmentFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **dateOfShipmentTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
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
<a name="getdocumentsofpurchaseorder"></a>
# **GetDocumentsOfPurchaseOrder**
> DocumentsResponse GetDocumentsOfPurchaseOrder (long? purchaseOrderId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string orderBy = null, string acceptLanguage = null)

Get all documents of one purchase order

Returns a list of documents. If the query has no matches, the response is an empty list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, classification, categories, categories.parent, categories.standards, attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var purchaseOrderId = 789;  // long? | The resource defined in the URL
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
                // Get all documents of one purchase order
                DocumentsResponse result = apiInstance.GetDocumentsOfPurchaseOrder(purchaseOrderId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.GetDocumentsOfPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderId** | **long?**| The resource defined in the URL | 
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
<a name="getproductsofpurchaseorder"></a>
# **GetProductsOfPurchaseOrder**
> ProductsResponse GetProductsOfPurchaseOrder (long? purchaseOrderId, int? page = null, int? perPage = null, string include = null, string productCode = null, string name = null, string manufacturerId = null, string statusId = null, string parentId = null, string tenantId = null, string categoryId = null, string orderBy = null, string acceptLanguage = null)

Get all products of one purchase

Returns a list of all products that are available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, parent, manufacturer, pictures, categories, categories.parent```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductsOfPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var purchaseOrderId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var productCode = productCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all products of one purchase
                ProductsResponse result = apiInstance.GetProductsOfPurchaseOrder(purchaseOrderId, page, perPage, include, productCode, name, manufacturerId, statusId, parentId, tenantId, categoryId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.GetProductsOfPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **productCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**ProductsResponse**](ProductsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpurchaseorderbyid"></a>
# **GetPurchaseOrderById**
> PurchaseOrderResponse GetPurchaseOrderById (long? id)

Get a single purchase order

Get a specific purchase order identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPurchaseOrderByIdExample
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

            var apiInstance = new PurchaseOrderApi();
            var id = 789;  // long? | Id of the purchase order to fetch

            try
            {
                // Get a single purchase order
                PurchaseOrderResponse result = apiInstance.GetPurchaseOrderById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.GetPurchaseOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the purchase order to fetch | 

### Return type

[**PurchaseOrderResponse**](PurchaseOrderResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpurchaseorderidstatus"></a>
# **GetPurchaseOrderIdStatus**
> PurchaseOrderStatusResponse GetPurchaseOrderIdStatus (long? purchaseOrderId, string include = null, string acceptLanguage = null)

Get the status of the specific purchase order

Returns the status of the purchase order. Needed if only permission on purchase order but not on tenant. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPurchaseOrderIdStatusExample
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

            var apiInstance = new PurchaseOrderApi();
            var purchaseOrderId = 789;  // long? | Id of the specified purchase order
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the status of the specific purchase order
                PurchaseOrderStatusResponse result = apiInstance.GetPurchaseOrderIdStatus(purchaseOrderId, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.GetPurchaseOrderIdStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderId** | **long?**| Id of the specified purchase order | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**PurchaseOrderStatusResponse**](PurchaseOrderStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpurchaseorders"></a>
# **GetPurchaseOrders**
> PurchaseOrdersResponse GetPurchaseOrders (int? page = null, int? perPage = null, string name = null, string number = null, string customerPurchaseOrderNumber = null, string statusId = null, string date = null, string dateFrom = null, string dateTo = null, string senderId = null, string receiverId = null, string quotationId = null, string customerNumber = null, string orderBy = null)

Get a range of purchase orders

Returns a list of purchase orders. If the query has no matches, the response is an empty list.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPurchaseOrdersExample
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

            var apiInstance = new PurchaseOrderApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var customerPurchaseOrderNumber = customerPurchaseOrderNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
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
                // Get a range of purchase orders
                PurchaseOrdersResponse result = apiInstance.GetPurchaseOrders(page, perPage, name, number, customerPurchaseOrderNumber, statusId, date, dateFrom, dateTo, senderId, receiverId, quotationId, customerNumber, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.GetPurchaseOrders: " + e.Message );
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
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **customerPurchaseOrderNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
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
<a name="removedeliviersfrompurchaseorder"></a>
# **RemoveDeliviersFromPurchaseOrder**
> void RemoveDeliviersFromPurchaseOrder (DeliveryIDs body, long? purchaseOrderId)

Remove deliveries from a purchase order

Remove one or more deliveries from a purchase order.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDeliviersFromPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new DeliveryIDs(); // DeliveryIDs | Resources that shall be removed.
            var purchaseOrderId = 789;  // long? | Id of the purchase order from which the deliveries will be removed

            try
            {
                // Remove deliveries from a purchase order
                apiInstance.RemoveDeliviersFromPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.RemoveDeliviersFromPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryIDs**](DeliveryIDs.md)| Resources that shall be removed. | 
 **purchaseOrderId** | **long?**| Id of the purchase order from which the deliveries will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removedocumentsfrompurchaseorder"></a>
# **RemoveDocumentsFromPurchaseOrder**
> void RemoveDocumentsFromPurchaseOrder (DocumentIDs body, long? purchaseOrderId)

Remove documents from a purchase order

Remove one or more documents from a purchase order.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDocumentsFromPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be removed.
            var purchaseOrderId = 789;  // long? | Id of the purchase order from which the documents will be removed

            try
            {
                // Remove documents from a purchase order
                apiInstance.RemoveDocumentsFromPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.RemoveDocumentsFromPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be removed. | 
 **purchaseOrderId** | **long?**| Id of the purchase order from which the documents will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeproductsfrompurchaseorder"></a>
# **RemoveProductsFromPurchaseOrder**
> void RemoveProductsFromPurchaseOrder (ProductIDs body, long? purchaseOrderId)

Remove products from a purchase order

Remove one or more products from a purchase order.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveProductsFromPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new ProductIDs(); // ProductIDs | Resources that shall be removed.
            var purchaseOrderId = 789;  // long? | Id of the purchase order from which the products will be removed

            try
            {
                // Remove products from a purchase order
                apiInstance.RemoveProductsFromPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.RemoveProductsFromPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIDs**](ProductIDs.md)| Resources that shall be removed. | 
 **purchaseOrderId** | **long?**| Id of the purchase order from which the products will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedeliviersofpurchaseorder"></a>
# **ReplaceDeliviersOfPurchaseOrder**
> void ReplaceDeliviersOfPurchaseOrder (DeliveryIDs body, long? purchaseOrderId)

Replace the deliveries of a purchase order

Replaces all deliveries belonging to a purchase order. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDeliviersOfPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new DeliveryIDs(); // DeliveryIDs | Resources that shall be replaced
            var purchaseOrderId = 789;  // long? | Id of the purchase order of which the deliveries will be replaced

            try
            {
                // Replace the deliveries of a purchase order
                apiInstance.ReplaceDeliviersOfPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.ReplaceDeliviersOfPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryIDs**](DeliveryIDs.md)| Resources that shall be replaced | 
 **purchaseOrderId** | **long?**| Id of the purchase order of which the deliveries will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedocumentsofpurchaseorder"></a>
# **ReplaceDocumentsOfPurchaseOrder**
> void ReplaceDocumentsOfPurchaseOrder (DocumentIDs body, long? purchaseOrderId)

Replace the documents of a purchase order

Replaces all documents belonging to a purchase order. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDocumentsOfPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be replaced
            var purchaseOrderId = 789;  // long? | Id of the purchase order of which the documents will be replaced

            try
            {
                // Replace the documents of a purchase order
                apiInstance.ReplaceDocumentsOfPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.ReplaceDocumentsOfPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be replaced | 
 **purchaseOrderId** | **long?**| Id of the purchase order of which the documents will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceproductsofpurchaseorder"></a>
# **ReplaceProductsOfPurchaseOrder**
> void ReplaceProductsOfPurchaseOrder (ProductIDs body, long? purchaseOrderId)

Replace the products of a purchase order

Replaces all products belonging to a purchase order. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceProductsOfPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new ProductIDs(); // ProductIDs | Resources that shall be replaced
            var purchaseOrderId = 789;  // long? | Id of the purchase order of which the products will be replaced

            try
            {
                // Replace the products of a purchase order
                apiInstance.ReplaceProductsOfPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.ReplaceProductsOfPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIDs**](ProductIDs.md)| Resources that shall be replaced | 
 **purchaseOrderId** | **long?**| Id of the purchase order of which the products will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductquantitiesofpurchaseorder"></a>
# **UpdateProductQuantitiesOfPurchaseOrder**
> void UpdateProductQuantitiesOfPurchaseOrder (ProductQuantity body, long? purchaseOrderId)

Change the product quantity in a purchase order

Sets a new quantity of a product in a purchase order or deletes the line in case quantity is zero.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateProductQuantitiesOfPurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new ProductQuantity(); // ProductQuantity | Resources that shall be changed or removed
            var purchaseOrderId = 789;  // long? | Id of the purchase order of which the change will be done

            try
            {
                // Change the product quantity in a purchase order
                apiInstance.UpdateProductQuantitiesOfPurchaseOrder(body, purchaseOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.UpdateProductQuantitiesOfPurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductQuantity**](ProductQuantity.md)| Resources that shall be changed or removed | 
 **purchaseOrderId** | **long?**| Id of the purchase order of which the change will be done | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepurchaseorder"></a>
# **UpdatePurchaseOrder**
> void UpdatePurchaseOrder (PurchaseOrderRequest body, long? id)

Update a purchase order

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
    public class UpdatePurchaseOrderExample
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

            var apiInstance = new PurchaseOrderApi();
            var body = new PurchaseOrderRequest(); // PurchaseOrderRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the purchase order to update

            try
            {
                // Update a purchase order
                apiInstance.UpdatePurchaseOrder(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderApi.UpdatePurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderRequest**](PurchaseOrderRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the purchase order to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
