# Netilion.Api.Api.PurchaseOrderStatusApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePurchaseOrderStatus**](PurchaseOrderStatusApi.md#createpurchaseorderstatus) | **POST** /purchase_order/statuses | Create a new purchase order status
[**DeletePurchaseOrderStatus**](PurchaseOrderStatusApi.md#deletepurchaseorderstatus) | **DELETE** /purchase_order/statuses/{id} | Delete an purchase order status
[**GetPurchaseOrderIdStatus**](PurchaseOrderStatusApi.md#getpurchaseorderidstatus) | **GET** /purchase_orders/{purchase_order_id}/status | Get the status of the specific purchase order
[**GetPurchaseOrderStatusById**](PurchaseOrderStatusApi.md#getpurchaseorderstatusbyid) | **GET** /purchase_order/statuses/{id} | Get a single purchase order status
[**GetPurchaseOrderStatuses**](PurchaseOrderStatusApi.md#getpurchaseorderstatuses) | **GET** /purchase_order/statuses | Get a range of purchase order statuses
[**UpdatePurchaseOrderStatus**](PurchaseOrderStatusApi.md#updatepurchaseorderstatus) | **PATCH** /purchase_order/statuses/{id} | Update an purchase order status

<a name="createpurchaseorderstatus"></a>
# **CreatePurchaseOrderStatus**
> PurchaseOrderStatusResponse CreatePurchaseOrderStatus (PurchaseOrderStatusRequest body)

Create a new purchase order status

Code must be unique. Parameters supporting translation: ```name, description```. POST sets values in default language: en.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreatePurchaseOrderStatusExample
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

            var apiInstance = new PurchaseOrderStatusApi();
            var body = new PurchaseOrderStatusRequest(); // PurchaseOrderStatusRequest | PurchaseOrderStatus object to create.

            try
            {
                // Create a new purchase order status
                PurchaseOrderStatusResponse result = apiInstance.CreatePurchaseOrderStatus(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderStatusApi.CreatePurchaseOrderStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderStatusRequest**](PurchaseOrderStatusRequest.md)| PurchaseOrderStatus object to create. | 

### Return type

[**PurchaseOrderStatusResponse**](PurchaseOrderStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepurchaseorderstatus"></a>
# **DeletePurchaseOrderStatus**
> void DeletePurchaseOrderStatus (long? id)

Delete an purchase order status

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
    public class DeletePurchaseOrderStatusExample
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

            var apiInstance = new PurchaseOrderStatusApi();
            var id = 789;  // long? | Id of the purchase order status to delete

            try
            {
                // Delete an purchase order status
                apiInstance.DeletePurchaseOrderStatus(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderStatusApi.DeletePurchaseOrderStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the purchase order status to delete | 

### Return type

void (empty response body)

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

            var apiInstance = new PurchaseOrderStatusApi();
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
                Debug.Print("Exception when calling PurchaseOrderStatusApi.GetPurchaseOrderIdStatus: " + e.Message );
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
<a name="getpurchaseorderstatusbyid"></a>
# **GetPurchaseOrderStatusById**
> PurchaseOrderStatusResponse GetPurchaseOrderStatusById (long? id, string acceptLanguage = null)

Get a single purchase order status

Get a specific purchase order status identified by the id in the URL. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPurchaseOrderStatusByIdExample
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

            var apiInstance = new PurchaseOrderStatusApi();
            var id = 789;  // long? | Id of purchase order status to fetch
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single purchase order status
                PurchaseOrderStatusResponse result = apiInstance.GetPurchaseOrderStatusById(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderStatusApi.GetPurchaseOrderStatusById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of purchase order status to fetch | 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**PurchaseOrderStatusResponse**](PurchaseOrderStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpurchaseorderstatuses"></a>
# **GetPurchaseOrderStatuses**
> PurchaseOrderStatuses GetPurchaseOrderStatuses (int? page = null, int? perPage = null, string name = null, string tenantId = null, string code = null, string orderBy = null, string acceptLanguage = null)

Get a range of purchase order statuses

Returns a list of all purchase order statuses that are available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.  Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPurchaseOrderStatusesExample
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

            var apiInstance = new PurchaseOrderStatusApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of purchase order statuses
                PurchaseOrderStatuses result = apiInstance.GetPurchaseOrderStatuses(page, perPage, name, tenantId, code, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderStatusApi.GetPurchaseOrderStatuses: " + e.Message );
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
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**PurchaseOrderStatuses**](PurchaseOrderStatuses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepurchaseorderstatus"></a>
# **UpdatePurchaseOrderStatus**
> void UpdatePurchaseOrderStatus (PurchaseOrderStatusRequest body, long? id, string contentLanguage = null)

Update an purchase order status

Update accessible parameters of the requested resource. Parameters supporting translation: ```name, description```. To add a translation set Content-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdatePurchaseOrderStatusExample
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

            var apiInstance = new PurchaseOrderStatusApi();
            var body = new PurchaseOrderStatusRequest(); // PurchaseOrderStatusRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the purchase order to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update an purchase order status
                apiInstance.UpdatePurchaseOrderStatus(body, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderStatusApi.UpdatePurchaseOrderStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderStatusRequest**](PurchaseOrderStatusRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the purchase order to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
