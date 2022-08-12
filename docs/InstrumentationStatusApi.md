# Netilion.Api.Api.InstrumentationStatusApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInstrumentationStatus**](InstrumentationStatusApi.md#createinstrumentationstatus) | **POST** /instrumentation/statuses | Create a new instrumentation status
[**DeleteInstrumentationStatus**](InstrumentationStatusApi.md#deleteinstrumentationstatus) | **DELETE** /instrumentation/statuses/{id} | Delete an instrumentation status
[**GetInstrumentationIdStatus**](InstrumentationStatusApi.md#getinstrumentationidstatus) | **GET** /instrumentations/{instrumentation_id}/status | Get the status of the specific instrumentation
[**GetInstrumentationStatusById**](InstrumentationStatusApi.md#getinstrumentationstatusbyid) | **GET** /instrumentation/statuses/{id} | Get a single instrumentation status
[**GetInstrumentationStatuses**](InstrumentationStatusApi.md#getinstrumentationstatuses) | **GET** /instrumentation/statuses | Get a range of instrumentation statuses
[**GetInstrumentationStatusesOptions**](InstrumentationStatusApi.md#getinstrumentationstatusesoptions) | **GET** /instrumentations/{instrumentation_id}/status-options | Get all possible statuses of the specified instrumentation
[**UpdateInstrumentationStatus**](InstrumentationStatusApi.md#updateinstrumentationstatus) | **PATCH** /instrumentation/statuses/{id} | Update an instrumentation status

<a name="createinstrumentationstatus"></a>
# **CreateInstrumentationStatus**
> InstrumentationStatusResponse CreateInstrumentationStatus (InstrumentationStatusRequest body)

Create a new instrumentation status

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
    public class CreateInstrumentationStatusExample
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

            var apiInstance = new InstrumentationStatusApi();
            var body = new InstrumentationStatusRequest(); // InstrumentationStatusRequest | InstrumentationStatus object to create.

            try
            {
                // Create a new instrumentation status
                InstrumentationStatusResponse result = apiInstance.CreateInstrumentationStatus(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationStatusApi.CreateInstrumentationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationStatusRequest**](InstrumentationStatusRequest.md)| InstrumentationStatus object to create. | 

### Return type

[**InstrumentationStatusResponse**](InstrumentationStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteinstrumentationstatus"></a>
# **DeleteInstrumentationStatus**
> void DeleteInstrumentationStatus (long? id)

Delete an instrumentation status

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
    public class DeleteInstrumentationStatusExample
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

            var apiInstance = new InstrumentationStatusApi();
            var id = 789;  // long? | Id of the instrumentation status to delete

            try
            {
                // Delete an instrumentation status
                apiInstance.DeleteInstrumentationStatus(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationStatusApi.DeleteInstrumentationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the instrumentation status to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationidstatus"></a>
# **GetInstrumentationIdStatus**
> InstrumentationStatusResponse GetInstrumentationIdStatus (long? instrumentationId, string acceptLanguage = null)

Get the status of the specific instrumentation

Returns the status of the instrumentation. Needed if only permission on instrumentation but not on tenant. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationIdStatusExample
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

            var apiInstance = new InstrumentationStatusApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the status of the specific instrumentation
                InstrumentationStatusResponse result = apiInstance.GetInstrumentationIdStatus(instrumentationId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationStatusApi.GetInstrumentationIdStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**InstrumentationStatusResponse**](InstrumentationStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationstatusbyid"></a>
# **GetInstrumentationStatusById**
> InstrumentationStatusResponse GetInstrumentationStatusById (long? id, string acceptLanguage = null)

Get a single instrumentation status

Get a specific instrumentation status identified by the id in the URL. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationStatusByIdExample
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

            var apiInstance = new InstrumentationStatusApi();
            var id = 789;  // long? | Id of instrumentation status to fetch
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single instrumentation status
                InstrumentationStatusResponse result = apiInstance.GetInstrumentationStatusById(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationStatusApi.GetInstrumentationStatusById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of instrumentation status to fetch | 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**InstrumentationStatusResponse**](InstrumentationStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationstatuses"></a>
# **GetInstrumentationStatuses**
> InstrumentationStatuses1 GetInstrumentationStatuses (int? page = null, int? perPage = null, string name = null, string tenantId = null, string code = null, string orderBy = null, string acceptLanguage = null)

Get a range of instrumentation statuses

Returns a list of all event statuses that are available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.  Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationStatusesExample
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

            var apiInstance = new InstrumentationStatusApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | searches instrumentation statuses with given name (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of instrumentation statuses
                InstrumentationStatuses1 result = apiInstance.GetInstrumentationStatuses(page, perPage, name, tenantId, code, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationStatusApi.GetInstrumentationStatuses: " + e.Message );
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
 **name** | **string**| searches instrumentation statuses with given name | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**InstrumentationStatuses1**](InstrumentationStatuses1.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationstatusesoptions"></a>
# **GetInstrumentationStatusesOptions**
> InstrumentationStatuses GetInstrumentationStatusesOptions (long? instrumentationId, int? page = null, int? perPage = null, string tenantId = null, string name = null, string code = null, string acceptLanguage = null)

Get all possible statuses of the specified instrumentation

Returns a list of all possible instrumentation statuses for the specified instrument. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationStatusesOptionsExample
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

            var apiInstance = new InstrumentationStatusApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all possible statuses of the specified instrumentation
                InstrumentationStatuses result = apiInstance.GetInstrumentationStatusesOptions(instrumentationId, page, perPage, tenantId, name, code, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationStatusApi.GetInstrumentationStatusesOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**InstrumentationStatuses**](InstrumentationStatuses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateinstrumentationstatus"></a>
# **UpdateInstrumentationStatus**
> void UpdateInstrumentationStatus (InstrumentationStatusRequest body, long? id, string contentLanguage = null)

Update an instrumentation status

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
    public class UpdateInstrumentationStatusExample
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

            var apiInstance = new InstrumentationStatusApi();
            var body = new InstrumentationStatusRequest(); // InstrumentationStatusRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the instrumentation status to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update an instrumentation status
                apiInstance.UpdateInstrumentationStatus(body, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationStatusApi.UpdateInstrumentationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationStatusRequest**](InstrumentationStatusRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the instrumentation status to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
