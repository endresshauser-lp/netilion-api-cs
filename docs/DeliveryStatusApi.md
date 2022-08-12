# Netilion.Api.Api.DeliveryStatusApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDeliveryStatus**](DeliveryStatusApi.md#createdeliverystatus) | **POST** /delivery/statuses | Create a new delivery status
[**DeleteDeliveryStatus**](DeliveryStatusApi.md#deletedeliverystatus) | **DELETE** /delivery/statuses/{id} | Delete a delivery status
[**GetDeliveryIdStatus**](DeliveryStatusApi.md#getdeliveryidstatus) | **GET** /deliveries/{delivery_id}/status | Get the status of the specific delivery
[**GetDeliveryStatusById**](DeliveryStatusApi.md#getdeliverystatusbyid) | **GET** /delivery/statuses/{id} | Get a single delivery status
[**GetDeliveryStatuses**](DeliveryStatusApi.md#getdeliverystatuses) | **GET** /delivery/statuses | Get a range of delivery statuses
[**UpdateDeliveryStatuses**](DeliveryStatusApi.md#updatedeliverystatuses) | **PATCH** /delivery/statuses/{id} | Update an delivery status

<a name="createdeliverystatus"></a>
# **CreateDeliveryStatus**
> DeliveryStatusRequest CreateDeliveryStatus (DeliveryStatusRequest body)

Create a new delivery status

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
    public class CreateDeliveryStatusExample
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

            var apiInstance = new DeliveryStatusApi();
            var body = new DeliveryStatusRequest(); // DeliveryStatusRequest | DeliveryStatus object to create.

            try
            {
                // Create a new delivery status
                DeliveryStatusRequest result = apiInstance.CreateDeliveryStatus(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryStatusApi.CreateDeliveryStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryStatusRequest**](DeliveryStatusRequest.md)| DeliveryStatus object to create. | 

### Return type

[**DeliveryStatusRequest**](DeliveryStatusRequest.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletedeliverystatus"></a>
# **DeleteDeliveryStatus**
> void DeleteDeliveryStatus (long? id)

Delete a delivery status

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
    public class DeleteDeliveryStatusExample
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

            var apiInstance = new DeliveryStatusApi();
            var id = 789;  // long? | Id of the delivery status to delete

            try
            {
                // Delete a delivery status
                apiInstance.DeleteDeliveryStatus(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryStatusApi.DeleteDeliveryStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the delivery status to delete | 

### Return type

void (empty response body)

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

            var apiInstance = new DeliveryStatusApi();
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
                Debug.Print("Exception when calling DeliveryStatusApi.GetDeliveryIdStatus: " + e.Message );
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
<a name="getdeliverystatusbyid"></a>
# **GetDeliveryStatusById**
> DeliveryStatusResponse GetDeliveryStatusById (long? id, string acceptLanguage = null)

Get a single delivery status

Get a specific delivery status identified by the id in the URL. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDeliveryStatusByIdExample
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

            var apiInstance = new DeliveryStatusApi();
            var id = 789;  // long? | Id of delivery status to fetch
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single delivery status
                DeliveryStatusResponse result = apiInstance.GetDeliveryStatusById(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryStatusApi.GetDeliveryStatusById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of delivery status to fetch | 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**DeliveryStatusResponse**](DeliveryStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdeliverystatuses"></a>
# **GetDeliveryStatuses**
> DeliveryStatuses GetDeliveryStatuses (int? page = null, int? perPage = null, string code = null, string name = null, string tenantId = null, string orderBy = null, string acceptLanguage = null)

Get a range of delivery statuses

Returns a list of all delivery statuses that are available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.  Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDeliveryStatusesExample
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

            var apiInstance = new DeliveryStatusApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of delivery statuses
                DeliveryStatuses result = apiInstance.GetDeliveryStatuses(page, perPage, code, name, tenantId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryStatusApi.GetDeliveryStatuses: " + e.Message );
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
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**DeliveryStatuses**](DeliveryStatuses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatedeliverystatuses"></a>
# **UpdateDeliveryStatuses**
> void UpdateDeliveryStatuses (DeliveryStatusRequest body, long? id, string contentLanguage = null)

Update an delivery status

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
    public class UpdateDeliveryStatusesExample
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

            var apiInstance = new DeliveryStatusApi();
            var body = new DeliveryStatusRequest(); // DeliveryStatusRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the delivery to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update an delivery status
                apiInstance.UpdateDeliveryStatuses(body, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryStatusApi.UpdateDeliveryStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryStatusRequest**](DeliveryStatusRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the delivery to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
