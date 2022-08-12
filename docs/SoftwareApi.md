# Netilion.Api.Api.SoftwareApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSoftware**](SoftwareApi.md#createsoftware) | **POST** /softwares | Create a new software
[**DeleteSoftware**](SoftwareApi.md#deletesoftware) | **DELETE** /softwares/{id} | Delete a software
[**GetSoftwareAttachmentsOfSoftware**](SoftwareApi.md#getsoftwareattachmentsofsoftware) | **GET** /softwares/{software_id}/attachments | Get all software attachments of one software
[**GetSoftwareById**](SoftwareApi.md#getsoftwarebyid) | **GET** /softwares/{id} | Get a single software
[**GetSoftwares**](SoftwareApi.md#getsoftwares) | **GET** /softwares | Get a range of softwares
[**UpdateSoftware**](SoftwareApi.md#updatesoftware) | **PATCH** /softwares/{id} | Update a software

<a name="createsoftware"></a>
# **CreateSoftware**
> SoftwareResponse CreateSoftware (SoftwareRequestPost body)

Create a new software

Create a new software. Parameters supporting translation: ```name, description```. POST sets values in default language: en.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateSoftwareExample
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

            var apiInstance = new SoftwareApi();
            var body = new SoftwareRequestPost(); // SoftwareRequestPost | Object body that will be created.

            try
            {
                // Create a new software
                SoftwareResponse result = apiInstance.CreateSoftware(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareApi.CreateSoftware: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareRequestPost**](SoftwareRequestPost.md)| Object body that will be created. | 

### Return type

[**SoftwareResponse**](SoftwareResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesoftware"></a>
# **DeleteSoftware**
> void DeleteSoftware (long? id)

Delete a software

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
    public class DeleteSoftwareExample
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

            var apiInstance = new SoftwareApi();
            var id = 789;  // long? | Id of the software to delete

            try
            {
                // Delete a software
                apiInstance.DeleteSoftware(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareApi.DeleteSoftware: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the software to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsoftwareattachmentsofsoftware"></a>
# **GetSoftwareAttachmentsOfSoftware**
> SoftwareAttachmentsResponse GetSoftwareAttachmentsOfSoftware (long? softwareId, int? page = null, int? perPage = null, string remarks = null, string fileName = null, string orderBy = null)

Get all software attachments of one software

Returns a list of all software attachments that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.'

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSoftwareAttachmentsOfSoftwareExample
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

            var apiInstance = new SoftwareApi();
            var softwareId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var remarks = remarks_example;  // string | Filter accepts `*` as wildcard (optional) 
            var fileName = fileName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all software attachments of one software
                SoftwareAttachmentsResponse result = apiInstance.GetSoftwareAttachmentsOfSoftware(softwareId, page, perPage, remarks, fileName, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareApi.GetSoftwareAttachmentsOfSoftware: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **softwareId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **remarks** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **fileName** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**SoftwareAttachmentsResponse**](SoftwareAttachmentsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsoftwarebyid"></a>
# **GetSoftwareById**
> SoftwareResponse GetSoftwareById (long? id, string include = null, string acceptLanguage = null)

Get a single software

Get a specific software identified by the id in the URL. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```software_attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSoftwareByIdExample
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

            var apiInstance = new SoftwareApi();
            var id = 789;  // long? | Id of the software to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single software
                SoftwareResponse result = apiInstance.GetSoftwareById(id, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareApi.GetSoftwareById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the software to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**SoftwareResponse**](SoftwareResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsoftwares"></a>
# **GetSoftwares**
> SoftwaresResponse GetSoftwares (int? page = null, int? perPage = null, string include = null, string softwareTypeId = null, string orderBy = null, string acceptLanguage = null)

Get a range of softwares

Returns a list of softwares. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```software_attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSoftwaresExample
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

            var apiInstance = new SoftwareApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var softwareTypeId = softwareTypeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `version_number`, `name`, `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of softwares
                SoftwaresResponse result = apiInstance.GetSoftwares(page, perPage, include, softwareTypeId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareApi.GetSoftwares: " + e.Message );
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
 **softwareTypeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;version_number&#x60;, &#x60;name&#x60;, &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**SoftwaresResponse**](SoftwaresResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesoftware"></a>
# **UpdateSoftware**
> void UpdateSoftware (SoftwareRequestPatch body, long? id, string contentLanguage = null)

Update a software

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
    public class UpdateSoftwareExample
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

            var apiInstance = new SoftwareApi();
            var body = new SoftwareRequestPatch(); // SoftwareRequestPatch | Parameters that shall be updated.
            var id = 789;  // long? | Id of the software to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update a software
                apiInstance.UpdateSoftware(body, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareApi.UpdateSoftware: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareRequestPatch**](SoftwareRequestPatch.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the software to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
