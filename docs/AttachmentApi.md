# Netilion.Api.Api.AttachmentApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLinkAttachment**](AttachmentApi.md#createlinkattachment) | **POST** /attachments/links | Create a new link as attachment
[**DeleteAttachment**](AttachmentApi.md#deleteattachment) | **DELETE** /attachments/{id} | Delete an attachment and the file
[**DownloadAttachment**](AttachmentApi.md#downloadattachment) | **GET** /attachments/{id}/download | Download the attachments file
[**GetAttachmentById**](AttachmentApi.md#getattachmentbyid) | **GET** /attachments/{id} | Get a single attachment
[**GetAttachments**](AttachmentApi.md#getattachments) | **GET** /attachments | Get a range of attachments
[**UpdateAttachment**](AttachmentApi.md#updateattachment) | **PATCH** /attachments/{id} | Update an attachment and especially its file
[**UpdateLinkAttachment**](AttachmentApi.md#updatelinkattachment) | **PATCH** /attachments/links/{id} | Update an attachment with a link
[**UploadAttachment**](AttachmentApi.md#uploadattachment) | **POST** /attachments | Create and upload a new attachment

<a name="createlinkattachment"></a>
# **CreateLinkAttachment**
> AttachmentResponse CreateLinkAttachment (AttachmentLinkRequest body)

Create a new link as attachment

Create an attachments that links to an external resource

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateLinkAttachmentExample
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

            var apiInstance = new AttachmentApi();
            var body = new AttachmentLinkRequest(); // AttachmentLinkRequest | Attachment object that needs to be created

            try
            {
                // Create a new link as attachment
                AttachmentResponse result = apiInstance.CreateLinkAttachment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.CreateLinkAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AttachmentLinkRequest**](AttachmentLinkRequest.md)| Attachment object that needs to be created | 

### Return type

[**AttachmentResponse**](AttachmentResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteattachment"></a>
# **DeleteAttachment**
> void DeleteAttachment (long? id)

Delete an attachment and the file

Delete a specific attachment resource and file identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteAttachmentExample
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

            var apiInstance = new AttachmentApi();
            var id = 789;  // long? | Id of the attachment to fetch

            try
            {
                // Delete an attachment and the file
                apiInstance.DeleteAttachment(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.DeleteAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the attachment to fetch | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloadattachment"></a>
# **DownloadAttachment**
> void DownloadAttachment (long? id, string disposition = null)

Download the attachments file

Download the file of the attachment with the original filename. Content-Transfer-Encoding header is set to binary

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DownloadAttachmentExample
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

            var apiInstance = new AttachmentApi();
            var id = 789;  // long? | Id of the attachment to fetch
            var disposition = disposition_example;  // string | Disposition type the download should be returned with. Allowed values are \"inline\" and \"attachment\". Default is \"attachment\". (optional) 

            try
            {
                // Download the attachments file
                apiInstance.DownloadAttachment(id, disposition);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.DownloadAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the attachment to fetch | 
 **disposition** | **string**| Disposition type the download should be returned with. Allowed values are \&quot;inline\&quot; and \&quot;attachment\&quot;. Default is \&quot;attachment\&quot;. | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getattachmentbyid"></a>
# **GetAttachmentById**
> AttachmentResponse GetAttachmentById (long? id)

Get a single attachment

specific attachment in your accessible scope, identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAttachmentByIdExample
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

            var apiInstance = new AttachmentApi();
            var id = 789;  // long? | Id of the attachment to fetch

            try
            {
                // Get a single attachment
                AttachmentResponse result = apiInstance.GetAttachmentById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.GetAttachmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the attachment to fetch | 

### Return type

[**AttachmentResponse**](AttachmentResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getattachments"></a>
# **GetAttachments**
> AttachmentsResponse GetAttachments (int? page = null, int? perPage = null, string contentAuthor = null, string contentVersion = null, string remarks = null, DateTime? contentDate = null, DateTime? contentDateFrom = null, DateTime? contentDateTo = null, string fileName = null, string orderBy = null)

Get a range of attachments

Returns a list of all attachments that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.'

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAttachmentsExample
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

            var apiInstance = new AttachmentApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var contentAuthor = contentAuthor_example;  // string | Filter accepts `*` as wildcard (optional) 
            var contentVersion = contentVersion_example;  // string | Filter accepts `*` as wildcard (optional) 
            var remarks = remarks_example;  // string | Filter accepts `*` as wildcard (optional) 
            var contentDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD or YYYY-MM-DDThh:mm:ss (optional) 
            var contentDateFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD or YYYY-MM-DDThh:mm:ss (optional) 
            var contentDateTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD or YYYY-MM-DDThh:mm:ss (optional) 
            var fileName = fileName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of attachments
                AttachmentsResponse result = apiInstance.GetAttachments(page, perPage, contentAuthor, contentVersion, remarks, contentDate, contentDateFrom, contentDateTo, fileName, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.GetAttachments: " + e.Message );
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
 **contentAuthor** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **contentVersion** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **remarks** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **contentDate** | **DateTime?**| Expected date format is YYYY-MM-DD or YYYY-MM-DDThh:mm:ss | [optional] 
 **contentDateFrom** | **DateTime?**| Expected date format is YYYY-MM-DD or YYYY-MM-DDThh:mm:ss | [optional] 
 **contentDateTo** | **DateTime?**| Expected date format is YYYY-MM-DD or YYYY-MM-DDThh:mm:ss | [optional] 
 **fileName** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateattachment"></a>
# **UpdateAttachment**
> void UpdateAttachment (long? id, byte[] file = null, long? documentId = null, string contentAuthor = null, string contentDate = null, string remarks = null, string languages = null)

Update an attachment and especially its file

The attachment object and also the file can be changed with a patch call. Checks the file-storage quota

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateAttachmentExample
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

            var apiInstance = new AttachmentApi();
            var id = 789;  // long? | Id of the attachment to update
            var file = file_example;  // byte[] |  (optional) 
            var documentId = 789;  // long? |  (optional) 
            var contentAuthor = contentAuthor_example;  // string |  (optional) 
            var contentDate = contentDate_example;  // string |  (optional) 
            var remarks = remarks_example;  // string |  (optional) 
            var languages = languages_example;  // string |  (optional) 

            try
            {
                // Update an attachment and especially its file
                apiInstance.UpdateAttachment(id, file, documentId, contentAuthor, contentDate, remarks, languages);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.UpdateAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the attachment to update | 
 **file** | **byte[]****byte[]**|  | [optional] 
 **documentId** | **long?**|  | [optional] 
 **contentAuthor** | **string**|  | [optional] 
 **contentDate** | **string**|  | [optional] 
 **remarks** | **string**|  | [optional] 
 **languages** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatelinkattachment"></a>
# **UpdateLinkAttachment**
> AttachmentResponse UpdateLinkAttachment (AttachmentLinkRequest body, long? id)

Update an attachment with a link

update an attachment that has a link

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateLinkAttachmentExample
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

            var apiInstance = new AttachmentApi();
            var body = new AttachmentLinkRequest(); // AttachmentLinkRequest | Attachment object that needs to be created
            var id = 789;  // long? | Id of the attachment to update

            try
            {
                // Update an attachment with a link
                AttachmentResponse result = apiInstance.UpdateLinkAttachment(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.UpdateLinkAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AttachmentLinkRequest**](AttachmentLinkRequest.md)| Attachment object that needs to be created | 
 **id** | **long?**| Id of the attachment to update | 

### Return type

[**AttachmentResponse**](AttachmentResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadattachment"></a>
# **UploadAttachment**
> AttachmentResponse UploadAttachment (byte[] file, long? documentId, string contentAuthor, string contentVersion, string contentDate, string remarks, string languages)

Create and upload a new attachment

the creation of an attachment works through a multipart/form-data upload of the file, its filename, content-author, content-date and languages of the file. Special characters (&$+,/:;=?@<>[]{}|^~%#) and white spaces in the file name will be replaced with underscores. Checks for the file-storage quota.  Forbidden content-types are  - application/xhtml+xml - text/html - application/javascript - text/javascript - application/x-shockwave-flash - application/vnd.adobe.flash.movie - video/x-flv - text/php - application/php - application/x-php - application/x-httpd-php

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UploadAttachmentExample
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

            var apiInstance = new AttachmentApi();
            var file = file_example;  // byte[] | 
            var documentId = 789;  // long? | 
            var contentAuthor = contentAuthor_example;  // string | 
            var contentVersion = contentVersion_example;  // string | 
            var contentDate = contentDate_example;  // string | 
            var remarks = remarks_example;  // string | 
            var languages = languages_example;  // string | 

            try
            {
                // Create and upload a new attachment
                AttachmentResponse result = apiInstance.UploadAttachment(file, documentId, contentAuthor, contentVersion, contentDate, remarks, languages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentApi.UploadAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **byte[]****byte[]**|  | 
 **documentId** | **long?**|  | 
 **contentAuthor** | **string**|  | 
 **contentVersion** | **string**|  | 
 **contentDate** | **string**|  | 
 **remarks** | **string**|  | 
 **languages** | **string**|  | 

### Return type

[**AttachmentResponse**](AttachmentResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
