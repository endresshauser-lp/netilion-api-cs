# Netilion.Api.Api.RequestForQuotationApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBillOfMaterialsToRequestForQuotation**](RequestForQuotationApi.md#addbillofmaterialstorequestforquotation) | **POST** /request_for_quotations/{request_for_quotation_id}/bill_of_materials | Add bill of materials to a request for quotation
[**AddDocumentsToRequestForQuotation**](RequestForQuotationApi.md#adddocumentstorequestforquotation) | **POST** /request_for_quotations/{request_for_quotation_id}/documents | Add documents to a request for quotation
[**AddQuotationsToRequestForQuotation**](RequestForQuotationApi.md#addquotationstorequestforquotation) | **POST** /request_for_quotations/{request_for_quotation_id}/quotations | Add quotations to a request for quotation
[**CreateRequestForQuotation**](RequestForQuotationApi.md#createrequestforquotation) | **POST** /request_for_quotations | Create a new request for quotation
[**DeleteBillOfMaterialsFromRequestForQuotation**](RequestForQuotationApi.md#deletebillofmaterialsfromrequestforquotation) | **DELETE** /request_for_quotations/{request_for_quotation_id}/bill_of_materials | Remove bill of materials from a request for quotation
[**DeleteDocumentsOfRequestForQuotation**](RequestForQuotationApi.md#deletedocumentsofrequestforquotation) | **DELETE** /request_for_quotations/{request_for_quotation_id}/documents | Remove documents from a request for quotation
[**DeleteQuotationsFromRequestForQuotation**](RequestForQuotationApi.md#deletequotationsfromrequestforquotation) | **DELETE** /request_for_quotations/{request_for_quotation_id}/quotations | Remove quotations from a request for quotation
[**DeleteRequestForQuotation**](RequestForQuotationApi.md#deleterequestforquotation) | **DELETE** /request_for_quotations/{id} | Delete a request for quotation
[**GetBillOfMaterialsOfRequestForQuotation**](RequestForQuotationApi.md#getbillofmaterialsofrequestforquotation) | **GET** /request_for_quotations/{request_for_quotation_id}/bill_of_materials | Get all bill of materials of one request for quotation
[**GetDocumentsOfRequestForQuotation**](RequestForQuotationApi.md#getdocumentsofrequestforquotation) | **GET** /request_for_quotations/{request_for_quotation_id}/documents | Get all documents of one request for quotation
[**GetQuotationsOfRequestForQuotation**](RequestForQuotationApi.md#getquotationsofrequestforquotation) | **GET** /request_for_quotations/{request_for_quotation_id}/quotations | Get all quotations of one request for quotation
[**GetRequestForQuotationById**](RequestForQuotationApi.md#getrequestforquotationbyid) | **GET** /request_for_quotations/{id} | Get a single request for quotation
[**GetRequestForQuotationIdStatus**](RequestForQuotationApi.md#getrequestforquotationidstatus) | **GET** /request_for_quotations/{request_for_quotation_id}/status | Get the status of the specific request for quotation
[**GetRequestForQuotations**](RequestForQuotationApi.md#getrequestforquotations) | **GET** /request_for_quotations | Get a range of request for quotations
[**ReplaceBillOfMaterialsOfRequestForQuotation**](RequestForQuotationApi.md#replacebillofmaterialsofrequestforquotation) | **PATCH** /request_for_quotations/{request_for_quotation_id}/bill_of_materials | Replace the bill of materials of a request for quotation
[**ReplaceDocumentsOfRequestForQuotation**](RequestForQuotationApi.md#replacedocumentsofrequestforquotation) | **PATCH** /request_for_quotations/{request_for_quotation_id}/documents | Replace the documents of a request for quotation
[**ReplaceQuotationsOfRequestForQuotation**](RequestForQuotationApi.md#replacequotationsofrequestforquotation) | **PATCH** /request_for_quotations/{request_for_quotation_id}/quotations | Replace the quotations of a request for quotation
[**UpdateRequestForQuotation**](RequestForQuotationApi.md#updaterequestforquotation) | **PATCH** /request_for_quotations/{id} | Update a request for quotation

<a name="addbillofmaterialstorequestforquotation"></a>
# **AddBillOfMaterialsToRequestForQuotation**
> void AddBillOfMaterialsToRequestForQuotation (BillOfMaterialIDs body, long? requestForQuotationId)

Add bill of materials to a request for quotation

Add one or more bill of materials to a request for quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddBillOfMaterialsToRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new BillOfMaterialIDs(); // BillOfMaterialIDs | Resources that shall be added.
            var requestForQuotationId = 789;  // long? | Id of the request for quotation to which the bill of materials will be added

            try
            {
                // Add bill of materials to a request for quotation
                apiInstance.AddBillOfMaterialsToRequestForQuotation(body, requestForQuotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.AddBillOfMaterialsToRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfMaterialIDs**](BillOfMaterialIDs.md)| Resources that shall be added. | 
 **requestForQuotationId** | **long?**| Id of the request for quotation to which the bill of materials will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adddocumentstorequestforquotation"></a>
# **AddDocumentsToRequestForQuotation**
> void AddDocumentsToRequestForQuotation (DocumentIDs body, long? requestForQuotationId)

Add documents to a request for quotation

Add one or more documents to a request for quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDocumentsToRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be added.
            var requestForQuotationId = 789;  // long? | Id of the request for quotation to which the documents will be added

            try
            {
                // Add documents to a request for quotation
                apiInstance.AddDocumentsToRequestForQuotation(body, requestForQuotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.AddDocumentsToRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be added. | 
 **requestForQuotationId** | **long?**| Id of the request for quotation to which the documents will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addquotationstorequestforquotation"></a>
# **AddQuotationsToRequestForQuotation**
> void AddQuotationsToRequestForQuotation (QuotationIDs body, long? requestForQuotationId)

Add quotations to a request for quotation

Add one or more quotations to a request for quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddQuotationsToRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new QuotationIDs(); // QuotationIDs | Resources that shall be added.
            var requestForQuotationId = 789;  // long? | Id of the request for quotation to which the quotations will be added

            try
            {
                // Add quotations to a request for quotation
                apiInstance.AddQuotationsToRequestForQuotation(body, requestForQuotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.AddQuotationsToRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuotationIDs**](QuotationIDs.md)| Resources that shall be added. | 
 **requestForQuotationId** | **long?**| Id of the request for quotation to which the quotations will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createrequestforquotation"></a>
# **CreateRequestForQuotation**
> RequestForQuotationResponse CreateRequestForQuotation (RequestForQuotationRequest body)

Create a new request for quotation

Create a new request for quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new RequestForQuotationRequest(); // RequestForQuotationRequest | Object body that will be created

            try
            {
                // Create a new request for quotation
                RequestForQuotationResponse result = apiInstance.CreateRequestForQuotation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.CreateRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestForQuotationRequest**](RequestForQuotationRequest.md)| Object body that will be created | 

### Return type

[**RequestForQuotationResponse**](RequestForQuotationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebillofmaterialsfromrequestforquotation"></a>
# **DeleteBillOfMaterialsFromRequestForQuotation**
> void DeleteBillOfMaterialsFromRequestForQuotation (BillOfMaterialIDs body, long? requestForQuotationId)

Remove bill of materials from a request for quotation

Remove one or more bill of materials from a request for quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteBillOfMaterialsFromRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new BillOfMaterialIDs(); // BillOfMaterialIDs | Resources that shall be removed.
            var requestForQuotationId = 789;  // long? | Id of the request for quotation from which the bill of materials will be removed

            try
            {
                // Remove bill of materials from a request for quotation
                apiInstance.DeleteBillOfMaterialsFromRequestForQuotation(body, requestForQuotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.DeleteBillOfMaterialsFromRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfMaterialIDs**](BillOfMaterialIDs.md)| Resources that shall be removed. | 
 **requestForQuotationId** | **long?**| Id of the request for quotation from which the bill of materials will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletedocumentsofrequestforquotation"></a>
# **DeleteDocumentsOfRequestForQuotation**
> void DeleteDocumentsOfRequestForQuotation (DocumentIDs body, long? requestForQuotationId)

Remove documents from a request for quotation

Remove one or more documents from a request for quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteDocumentsOfRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be removed.
            var requestForQuotationId = 789;  // long? | Id of the request for quotation from which the documents will be removed

            try
            {
                // Remove documents from a request for quotation
                apiInstance.DeleteDocumentsOfRequestForQuotation(body, requestForQuotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.DeleteDocumentsOfRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be removed. | 
 **requestForQuotationId** | **long?**| Id of the request for quotation from which the documents will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletequotationsfromrequestforquotation"></a>
# **DeleteQuotationsFromRequestForQuotation**
> void DeleteQuotationsFromRequestForQuotation (QuotationIDs body, long? requestForQuotationId)

Remove quotations from a request for quotation

Remove one or more quotations from a request for quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteQuotationsFromRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new QuotationIDs(); // QuotationIDs | Resources that shall be removed.
            var requestForQuotationId = 789;  // long? | Id of the request for quotation from which the quotations will be removed

            try
            {
                // Remove quotations from a request for quotation
                apiInstance.DeleteQuotationsFromRequestForQuotation(body, requestForQuotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.DeleteQuotationsFromRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuotationIDs**](QuotationIDs.md)| Resources that shall be removed. | 
 **requestForQuotationId** | **long?**| Id of the request for quotation from which the quotations will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleterequestforquotation"></a>
# **DeleteRequestForQuotation**
> void DeleteRequestForQuotation (long? id)

Delete a request for quotation

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
    public class DeleteRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var id = 789;  // long? | Id of the request for quotation to delete

            try
            {
                // Delete a request for quotation
                apiInstance.DeleteRequestForQuotation(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.DeleteRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the request for quotation to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbillofmaterialsofrequestforquotation"></a>
# **GetBillOfMaterialsOfRequestForQuotation**
> BillOfMaterialsResponse GetBillOfMaterialsOfRequestForQuotation (long? requestForQuotationId, int? page = null, int? perPage = null, string name = null, string author = null, string date = null, string dateFrom = null, string dateTo = null, string orderBy = null)

Get all bill of materials of one request for quotation

Returns a list of all bill of materials that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetBillOfMaterialsOfRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var requestForQuotationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var author = author_example;  // string | Filter accepts `*` as wildcard (optional) 
            var date = date_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateFrom = dateFrom_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateTo = dateTo_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all bill of materials of one request for quotation
                BillOfMaterialsResponse result = apiInstance.GetBillOfMaterialsOfRequestForQuotation(requestForQuotationId, page, perPage, name, author, date, dateFrom, dateTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.GetBillOfMaterialsOfRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestForQuotationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **author** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **date** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateFrom** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateTo** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**BillOfMaterialsResponse**](BillOfMaterialsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdocumentsofrequestforquotation"></a>
# **GetDocumentsOfRequestForQuotation**
> DocumentsResponse GetDocumentsOfRequestForQuotation (long? requestForQuotationId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string orderBy = null, string acceptLanguage = null)

Get all documents of one request for quotation

Returns a list of documents. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, classification, categories, categories.parent, attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var requestForQuotationId = 789;  // long? | The resource defined in the URL
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
                // Get all documents of one request for quotation
                DocumentsResponse result = apiInstance.GetDocumentsOfRequestForQuotation(requestForQuotationId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.GetDocumentsOfRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestForQuotationId** | **long?**| The resource defined in the URL | 
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
<a name="getquotationsofrequestforquotation"></a>
# **GetQuotationsOfRequestForQuotation**
> QuotationsResponse GetQuotationsOfRequestForQuotation (long? requestForQuotationId, int? page = null, int? perPage = null, string name = null, string number = null, string statusId = null, string date = null, string dateFrom = null, string dateTo = null, string senderId = null, string receiverId = null, string orderBy = null)

Get all quotations of one request for quotation

Returns a list of all quotations that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetQuotationsOfRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var requestForQuotationId = 789;  // long? | The resource defined in the URL
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
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all quotations of one request for quotation
                QuotationsResponse result = apiInstance.GetQuotationsOfRequestForQuotation(requestForQuotationId, page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.GetQuotationsOfRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestForQuotationId** | **long?**| The resource defined in the URL | 
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
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**QuotationsResponse**](QuotationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrequestforquotationbyid"></a>
# **GetRequestForQuotationById**
> RequestForQuotationResponse GetRequestForQuotationById (long? id)

Get a single request for quotation

Get a specific request for quotation identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetRequestForQuotationByIdExample
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

            var apiInstance = new RequestForQuotationApi();
            var id = 789;  // long? | Id of the request for quotation to fetch

            try
            {
                // Get a single request for quotation
                RequestForQuotationResponse result = apiInstance.GetRequestForQuotationById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.GetRequestForQuotationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the request for quotation to fetch | 

### Return type

[**RequestForQuotationResponse**](RequestForQuotationResponse.md)

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

            var apiInstance = new RequestForQuotationApi();
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
                Debug.Print("Exception when calling RequestForQuotationApi.GetRequestForQuotationIdStatus: " + e.Message );
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
<a name="getrequestforquotations"></a>
# **GetRequestForQuotations**
> RequestForQuotationsResponse GetRequestForQuotations (int? page = null, int? perPage = null, string name = null, string number = null, string statusId = null, string date = null, string dateFrom = null, string dateTo = null, string senderId = null, string receiverId = null, string author = null, string orderBy = null)

Get a range of request for quotations

Returns a list of request for quotations. If the query has no matches, the response is an empty list.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetRequestForQuotationsExample
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

            var apiInstance = new RequestForQuotationApi();
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
            var author = author_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of request for quotations
                RequestForQuotationsResponse result = apiInstance.GetRequestForQuotations(page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, author, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.GetRequestForQuotations: " + e.Message );
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
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **date** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateFrom** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateTo** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **senderId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **receiverId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **author** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**RequestForQuotationsResponse**](RequestForQuotationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacebillofmaterialsofrequestforquotation"></a>
# **ReplaceBillOfMaterialsOfRequestForQuotation**
> void ReplaceBillOfMaterialsOfRequestForQuotation (BillOfMaterialIDs body, long? requestForQuotationId)

Replace the bill of materials of a request for quotation

Replaces all bill of materials belonging to a request for quotation. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceBillOfMaterialsOfRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new BillOfMaterialIDs(); // BillOfMaterialIDs | Resources that shall be replaced
            var requestForQuotationId = 789;  // long? | Id of the request for quotation of which the bill of materials will be replaced

            try
            {
                // Replace the bill of materials of a request for quotation
                apiInstance.ReplaceBillOfMaterialsOfRequestForQuotation(body, requestForQuotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.ReplaceBillOfMaterialsOfRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfMaterialIDs**](BillOfMaterialIDs.md)| Resources that shall be replaced | 
 **requestForQuotationId** | **long?**| Id of the request for quotation of which the bill of materials will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedocumentsofrequestforquotation"></a>
# **ReplaceDocumentsOfRequestForQuotation**
> void ReplaceDocumentsOfRequestForQuotation (DocumentIDs body, long? requestForQuotationId)

Replace the documents of a request for quotation

Replaces all documents belonging to a request for quotation. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDocumentsOfRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be replaced
            var requestForQuotationId = 789;  // long? | Id of the request for quotation of which the documents will be replaced

            try
            {
                // Replace the documents of a request for quotation
                apiInstance.ReplaceDocumentsOfRequestForQuotation(body, requestForQuotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.ReplaceDocumentsOfRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be replaced | 
 **requestForQuotationId** | **long?**| Id of the request for quotation of which the documents will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacequotationsofrequestforquotation"></a>
# **ReplaceQuotationsOfRequestForQuotation**
> void ReplaceQuotationsOfRequestForQuotation (QuotationIDs body, long? requestForQuotationId)

Replace the quotations of a request for quotation

Replaces all quotations belonging to a request for quotation. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceQuotationsOfRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new QuotationIDs(); // QuotationIDs | Resources that shall be replaced
            var requestForQuotationId = 789;  // long? | Id of the request for quotation of which the quotations will be replaced

            try
            {
                // Replace the quotations of a request for quotation
                apiInstance.ReplaceQuotationsOfRequestForQuotation(body, requestForQuotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.ReplaceQuotationsOfRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuotationIDs**](QuotationIDs.md)| Resources that shall be replaced | 
 **requestForQuotationId** | **long?**| Id of the request for quotation of which the quotations will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updaterequestforquotation"></a>
# **UpdateRequestForQuotation**
> void UpdateRequestForQuotation (RequestForQuotationRequest body, long? id)

Update a request for quotation

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
    public class UpdateRequestForQuotationExample
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

            var apiInstance = new RequestForQuotationApi();
            var body = new RequestForQuotationRequest(); // RequestForQuotationRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the request for quotation to update

            try
            {
                // Update a request for quotation
                apiInstance.UpdateRequestForQuotation(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestForQuotationApi.UpdateRequestForQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestForQuotationRequest**](RequestForQuotationRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the request for quotation to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
