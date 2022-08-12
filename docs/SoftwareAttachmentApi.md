# Netilion.Api.Api.SoftwareAttachmentApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLinkSoftwareAttachment**](SoftwareAttachmentApi.md#createlinksoftwareattachment) | **POST** /software/attachments/links | Create a new link as software attachment
[**DeleteSoftwareAttachment**](SoftwareAttachmentApi.md#deletesoftwareattachment) | **DELETE** /software/attachments/{id} | Delete a software attachment and the file
[**DownloadSoftwareAttachment**](SoftwareAttachmentApi.md#downloadsoftwareattachment) | **GET** /software/attachments/{id}/download | Download the software attachments file
[**GetSoftwareAttachmentById**](SoftwareAttachmentApi.md#getsoftwareattachmentbyid) | **GET** /software/attachments/{id} | Get a single software attachment
[**GetSoftwareAttachments**](SoftwareAttachmentApi.md#getsoftwareattachments) | **GET** /software/attachments | Get a range of software attachments
[**UpdateLinkSoftwareAttachment**](SoftwareAttachmentApi.md#updatelinksoftwareattachment) | **PATCH** /software/attachments/links/{id} | Update a software attachment with a link
[**UpdateSoftwareAttachment**](SoftwareAttachmentApi.md#updatesoftwareattachment) | **PATCH** /software/attachments/{id} | Update an software attachment and especially its file
[**UploadSoftwareAttachment**](SoftwareAttachmentApi.md#uploadsoftwareattachment) | **POST** /software/attachments | Create and upload a new software attachment

<a name="createlinksoftwareattachment"></a>
# **CreateLinkSoftwareAttachment**
> SoftwareAttachmentResponse CreateLinkSoftwareAttachment (SoftwareAttachmentLinkRequestPost body)

Create a new link as software attachment

Create a software attachments that links to an external resource

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateLinkSoftwareAttachmentExample
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

            var apiInstance = new SoftwareAttachmentApi();
            var body = new SoftwareAttachmentLinkRequestPost(); // SoftwareAttachmentLinkRequestPost | Software attachment object that needs to be created

            try
            {
                // Create a new link as software attachment
                SoftwareAttachmentResponse result = apiInstance.CreateLinkSoftwareAttachment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareAttachmentApi.CreateLinkSoftwareAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareAttachmentLinkRequestPost**](SoftwareAttachmentLinkRequestPost.md)| Software attachment object that needs to be created | 

### Return type

[**SoftwareAttachmentResponse**](SoftwareAttachmentResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesoftwareattachment"></a>
# **DeleteSoftwareAttachment**
> void DeleteSoftwareAttachment (int? id)

Delete a software attachment and the file

Delete a specific software attachment resource and file identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteSoftwareAttachmentExample
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

            var apiInstance = new SoftwareAttachmentApi();
            var id = 56;  // int? | Id of the software attachment to delete

            try
            {
                // Delete a software attachment and the file
                apiInstance.DeleteSoftwareAttachment(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareAttachmentApi.DeleteSoftwareAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the software attachment to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloadsoftwareattachment"></a>
# **DownloadSoftwareAttachment**
> void DownloadSoftwareAttachment (long? id, string disposition = null)

Download the software attachments file

Download the file of the software attachment with the original filename. Content-Transfer-Encoding header is set to binary

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DownloadSoftwareAttachmentExample
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

            var apiInstance = new SoftwareAttachmentApi();
            var id = 789;  // long? | Id of the software attachment to fetch
            var disposition = disposition_example;  // string | Disposition type the download should be returned with. Allowed values are \"inline\" and \"attachment\". Default is \"attachment\". (optional) 

            try
            {
                // Download the software attachments file
                apiInstance.DownloadSoftwareAttachment(id, disposition);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareAttachmentApi.DownloadSoftwareAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the software attachment to fetch | 
 **disposition** | **string**| Disposition type the download should be returned with. Allowed values are \&quot;inline\&quot; and \&quot;attachment\&quot;. Default is \&quot;attachment\&quot;. | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsoftwareattachmentbyid"></a>
# **GetSoftwareAttachmentById**
> SoftwareAttachmentResponse GetSoftwareAttachmentById (long? id)

Get a single software attachment

specific software attachment in your accessible scope, identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSoftwareAttachmentByIdExample
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

            var apiInstance = new SoftwareAttachmentApi();
            var id = 789;  // long? | Id of the software attachment to fetch

            try
            {
                // Get a single software attachment
                SoftwareAttachmentResponse result = apiInstance.GetSoftwareAttachmentById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareAttachmentApi.GetSoftwareAttachmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the software attachment to fetch | 

### Return type

[**SoftwareAttachmentResponse**](SoftwareAttachmentResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsoftwareattachments"></a>
# **GetSoftwareAttachments**
> SoftwareAttachmentsResponse GetSoftwareAttachments (int? page = null, int? perPage = null, DateTime? contentDate = null, string remarks = null, string fileName = null, string orderBy = null)

Get a range of software attachments

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
    public class GetSoftwareAttachmentsExample
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

            var apiInstance = new SoftwareAttachmentApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var contentDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD or YYYY-MM-DDThh:mm:ss (optional) 
            var remarks = remarks_example;  // string | Filter accepts `*` as wildcard (optional) 
            var fileName = fileName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of software attachments
                SoftwareAttachmentsResponse result = apiInstance.GetSoftwareAttachments(page, perPage, contentDate, remarks, fileName, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareAttachmentApi.GetSoftwareAttachments: " + e.Message );
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
 **contentDate** | **DateTime?**| Expected date format is YYYY-MM-DD or YYYY-MM-DDThh:mm:ss | [optional] 
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
<a name="updatelinksoftwareattachment"></a>
# **UpdateLinkSoftwareAttachment**
> SoftwareAttachmentResponse UpdateLinkSoftwareAttachment (SoftwareAttachmentLinkRequestPatch body, long? id)

Update a software attachment with a link

update an software attachment that has a link

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateLinkSoftwareAttachmentExample
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

            var apiInstance = new SoftwareAttachmentApi();
            var body = new SoftwareAttachmentLinkRequestPatch(); // SoftwareAttachmentLinkRequestPatch | Software attachment object that needs to be updated
            var id = 789;  // long? | Id of the software attachment to update

            try
            {
                // Update a software attachment with a link
                SoftwareAttachmentResponse result = apiInstance.UpdateLinkSoftwareAttachment(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareAttachmentApi.UpdateLinkSoftwareAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareAttachmentLinkRequestPatch**](SoftwareAttachmentLinkRequestPatch.md)| Software attachment object that needs to be updated | 
 **id** | **long?**| Id of the software attachment to update | 

### Return type

[**SoftwareAttachmentResponse**](SoftwareAttachmentResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesoftwareattachment"></a>
# **UpdateSoftwareAttachment**
> void UpdateSoftwareAttachment (long? id, byte[] file = null, long? softwareId = null, string contentDate = null, string remarks = null)

Update an software attachment and especially its file

The software attachment object and also the file can be changed with a patch call.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSoftwareAttachmentExample
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

            var apiInstance = new SoftwareAttachmentApi();
            var id = 789;  // long? | Id of the software attachment to update
            var file = file_example;  // byte[] |  (optional) 
            var softwareId = 789;  // long? |  (optional) 
            var contentDate = contentDate_example;  // string |  (optional) 
            var remarks = remarks_example;  // string |  (optional) 

            try
            {
                // Update an software attachment and especially its file
                apiInstance.UpdateSoftwareAttachment(id, file, softwareId, contentDate, remarks);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareAttachmentApi.UpdateSoftwareAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the software attachment to update | 
 **file** | **byte[]****byte[]**|  | [optional] 
 **softwareId** | **long?**|  | [optional] 
 **contentDate** | **string**|  | [optional] 
 **remarks** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadsoftwareattachment"></a>
# **UploadSoftwareAttachment**
> SoftwareAttachmentResponse UploadSoftwareAttachment (byte[] file, long? softwareId, string contentDate, string remarks)

Create and upload a new software attachment

the creation of an software attachment works through a multipart/form-data upload of the file and its filename.  Forbidden content-types are  - application/xhtml+xml - text/html - application/javascript - text/javascript - application/x-shockwave-flash - application/vnd.adobe.flash.movie - video/x-flv - text/php - application/php - application/x-php - application/x-httpd-php

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UploadSoftwareAttachmentExample
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

            var apiInstance = new SoftwareAttachmentApi();
            var file = file_example;  // byte[] | 
            var softwareId = 789;  // long? | 
            var contentDate = contentDate_example;  // string | 
            var remarks = remarks_example;  // string | 

            try
            {
                // Create and upload a new software attachment
                SoftwareAttachmentResponse result = apiInstance.UploadSoftwareAttachment(file, softwareId, contentDate, remarks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SoftwareAttachmentApi.UploadSoftwareAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **byte[]****byte[]**|  | 
 **softwareId** | **long?**|  | 
 **contentDate** | **string**|  | 
 **remarks** | **string**|  | 

### Return type

[**SoftwareAttachmentResponse**](SoftwareAttachmentResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
