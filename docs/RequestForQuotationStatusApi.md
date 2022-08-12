# Netilion.Api.Api.RequestForQuotationStatusApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRequestForQuotationStatus**](RequestForQuotationStatusApi.md#createrequestforquotationstatus) | **POST** /request_for_quotation/statuses | Create a new request for quotation status
[**DeleteRequestForQuotationStatus**](RequestForQuotationStatusApi.md#deleterequestforquotationstatus) | **DELETE** /request_for_quotation/statuses/{id} | Delete an request for quotation status
[**GetRequestForQuotationIdStatus**](RequestForQuotationStatusApi.md#getrequestforquotationidstatus) | **GET** /request_for_quotations/{request_for_quotation_id}/status | Get the status of the specific request for quotation
[**GetRequestForQuotationStatusById**](RequestForQuotationStatusApi.md#getrequestforquotationstatusbyid) | **GET** /request_for_quotation/statuses/{id} | Get a single request for quotation status
[**GetRequestForQuotationStatuses**](RequestForQuotationStatusApi.md#getrequestforquotationstatuses) | **GET** /request_for_quotation/statuses | Get a range of request for quotation statuses
[**UpdateRequestForQuotationStatus**](RequestForQuotationStatusApi.md#updaterequestforquotationstatus) | **PATCH** /request_for_quotation/statuses/{id} | Update an request for quotation status

<a name="createrequestforquotationstatus"></a>
# **CreateRequestForQuotationStatus**
> RequestForQuotationStatusResponse CreateRequestForQuotationStatus (RequestForQuotationStatusRequest body)

Create a new request for quotation status

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
    public class CreateRequestForQuotationStatusExample
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

            var apiInstance = new RequestForQuotationStatusApi();
            var body = new RequestForQuotationStatusRequest(); // RequestForQuotationStatusRequest | RequestForQuotationStatus object to create.

            try
            {
                // Create a new request for quotation status
                RequestForQuotationStatusResponse result = apiInstance.CreateRequestForQuotationStatus(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationStatusApi.CreateRequestForQuotationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestForQuotationStatusRequest**](RequestForQuotationStatusRequest.md)| RequestForQuotationStatus object to create. | 

### Return type

[**RequestForQuotationStatusResponse**](RequestForQuotationStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleterequestforquotationstatus"></a>
# **DeleteRequestForQuotationStatus**
> void DeleteRequestForQuotationStatus (long? id)

Delete an request for quotation status

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
    public class DeleteRequestForQuotationStatusExample
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

            var apiInstance = new RequestForQuotationStatusApi();
            var id = 789;  // long? | Id of the request for quotation status to delete

            try
            {
                // Delete an request for quotation status
                apiInstance.DeleteRequestForQuotationStatus(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationStatusApi.DeleteRequestForQuotationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the request for quotation status to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrequestforquotationidstatus"></a>
# **GetRequestForQuotationIdStatus**
> RequestForQuotationStatusResponse GetRequestForQuotationIdStatus (long? requestForQuotationId, string include = null, string acceptLanguage = null)

Get the status of the specific request for quotation

Returns the status of the request for quotation. Needed if only permission on request for quotation but not on tenant. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetRequestForQuotationIdStatusExample
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

            var apiInstance = new RequestForQuotationStatusApi();
            var requestForQuotationId = 789;  // long? | Id of the specified request for quotation
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the status of the specific request for quotation
                RequestForQuotationStatusResponse result = apiInstance.GetRequestForQuotationIdStatus(requestForQuotationId, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationStatusApi.GetRequestForQuotationIdStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestForQuotationId** | **long?**| Id of the specified request for quotation | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**RequestForQuotationStatusResponse**](RequestForQuotationStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrequestforquotationstatusbyid"></a>
# **GetRequestForQuotationStatusById**
> RequestForQuotationStatusResponse GetRequestForQuotationStatusById (long? id, string acceptLanguage = null)

Get a single request for quotation status

Get a specific request for quotation status identified by the id in the URL. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetRequestForQuotationStatusByIdExample
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

            var apiInstance = new RequestForQuotationStatusApi();
            var id = 789;  // long? | Id of request for quotation status to fetch
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single request for quotation status
                RequestForQuotationStatusResponse result = apiInstance.GetRequestForQuotationStatusById(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationStatusApi.GetRequestForQuotationStatusById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of request for quotation status to fetch | 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**RequestForQuotationStatusResponse**](RequestForQuotationStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrequestforquotationstatuses"></a>
# **GetRequestForQuotationStatuses**
> RequestForQuotationStatuses GetRequestForQuotationStatuses (int? page = null, int? perPage = null, string name = null, string tenantId = null, string code = null, string orderBy = null, string acceptLanguage = null)

Get a range of request for quotation statuses

Returns a list of all request for quotation statuses that are available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.  Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetRequestForQuotationStatusesExample
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

            var apiInstance = new RequestForQuotationStatusApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of request for quotation statuses
                RequestForQuotationStatuses result = apiInstance.GetRequestForQuotationStatuses(page, perPage, name, tenantId, code, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationStatusApi.GetRequestForQuotationStatuses: " + e.Message );
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

[**RequestForQuotationStatuses**](RequestForQuotationStatuses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updaterequestforquotationstatus"></a>
# **UpdateRequestForQuotationStatus**
> void UpdateRequestForQuotationStatus (RequestForQuotationStatusRequest body, long? id, string contentLanguage = null)

Update an request for quotation status

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
    public class UpdateRequestForQuotationStatusExample
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

            var apiInstance = new RequestForQuotationStatusApi();
            var body = new RequestForQuotationStatusRequest(); // RequestForQuotationStatusRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the request for quotation to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update an request for quotation status
                apiInstance.UpdateRequestForQuotationStatus(body, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationStatusApi.UpdateRequestForQuotationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestForQuotationStatusRequest**](RequestForQuotationStatusRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the request for quotation to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
