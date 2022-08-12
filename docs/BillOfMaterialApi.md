# Netilion.Api.Api.BillOfMaterialApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDocumentsToBillOfMaterial**](BillOfMaterialApi.md#adddocumentstobillofmaterial) | **POST** /bill_of_materials/{bill_of_material_id}/documents | Add documents to a bill of material
[**AddInstrumentationsToBillOfMaterial**](BillOfMaterialApi.md#addinstrumentationstobillofmaterial) | **POST** /bill_of_materials/{bill_of_material_id}/instrumentations | Add instrumentations to a bill of material
[**AddRequestForQuotationsToBillOfMaterial**](BillOfMaterialApi.md#addrequestforquotationstobillofmaterial) | **POST** /bill_of_materials/{bill_of_material_id}/request_for_quotations | Add request for quotations to a bill of material
[**CreateBillOfMaterial**](BillOfMaterialApi.md#createbillofmaterial) | **POST** /bill_of_materials | Create a new bill of material
[**DeleteBillOfMaterial**](BillOfMaterialApi.md#deletebillofmaterial) | **DELETE** /bill_of_materials/{id} | Delete a bill of material
[**GetBillOfMaterialById**](BillOfMaterialApi.md#getbillofmaterialbyid) | **GET** /bill_of_materials/{id} | Get a single bill of material
[**GetBillOfMaterials**](BillOfMaterialApi.md#getbillofmaterials) | **GET** /bill_of_materials | Get a range of bill of materials
[**GetDocumentsOfBillOfMaterial**](BillOfMaterialApi.md#getdocumentsofbillofmaterial) | **GET** /bill_of_materials/{bill_of_material_id}/documents | Get all documents of a bill of material
[**GetInstrumentationsOfBillOfMaterial**](BillOfMaterialApi.md#getinstrumentationsofbillofmaterial) | **GET** /bill_of_materials/{bill_of_material_id}/instrumentations | Get all instrumentations of a bill of material
[**GetRequestForQuotationsOfBillOfMaterial**](BillOfMaterialApi.md#getrequestforquotationsofbillofmaterial) | **GET** /bill_of_materials/{bill_of_material_id}/request_for_quotations | Get all request for quotations of a bill of material
[**RemoveDocumentsFromBillOfMaterial**](BillOfMaterialApi.md#removedocumentsfrombillofmaterial) | **DELETE** /bill_of_materials/{bill_of_material_id}/documents | Remove documents from a bill of material
[**RemoveInstrumentationsFromBillOfMaterial**](BillOfMaterialApi.md#removeinstrumentationsfrombillofmaterial) | **DELETE** /bill_of_materials/{bill_of_material_id}/instrumentations | Remove instrumentations from a bill of material
[**RemoveRequestForQuotationsOfBillOfMaterial**](BillOfMaterialApi.md#removerequestforquotationsofbillofmaterial) | **DELETE** /bill_of_materials/{bill_of_material_id}/request_for_quotations | Remove request for quotations from a bill of material
[**ReplaceDocumentsOfBillOfMaterial**](BillOfMaterialApi.md#replacedocumentsofbillofmaterial) | **PATCH** /bill_of_materials/{bill_of_material_id}/documents | Replace the documents of a bill of material
[**ReplaceInstrumentationsOfBillOfMaterial**](BillOfMaterialApi.md#replaceinstrumentationsofbillofmaterial) | **PATCH** /bill_of_materials/{bill_of_material_id}/instrumentations | Replace the instrumentations of a bill of material
[**ReplaceRequestForQuotationsOfBillOfMaterial**](BillOfMaterialApi.md#replacerequestforquotationsofbillofmaterial) | **PATCH** /bill_of_materials/{bill_of_material_id}/request_for_quotations | Replace the request for quotations of a bill of material
[**UpdateBillOfMaterial**](BillOfMaterialApi.md#updatebillofmaterial) | **PATCH** /bill_of_materials/{id} | Update a bill of material

<a name="adddocumentstobillofmaterial"></a>
# **AddDocumentsToBillOfMaterial**
> void AddDocumentsToBillOfMaterial (DocumentIDs body, long? billOfMaterialId)

Add documents to a bill of material

Add one or more documents to a bill of material.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDocumentsToBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be added.
            var billOfMaterialId = 789;  // long? | Id of the bill of material to which the documents will be added

            try
            {
                // Add documents to a bill of material
                apiInstance.AddDocumentsToBillOfMaterial(body, billOfMaterialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.AddDocumentsToBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be added. | 
 **billOfMaterialId** | **long?**| Id of the bill of material to which the documents will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addinstrumentationstobillofmaterial"></a>
# **AddInstrumentationsToBillOfMaterial**
> void AddInstrumentationsToBillOfMaterial (InstrumentationIDs body, long? billOfMaterialId)

Add instrumentations to a bill of material

Add one or more instrumentations to a bill of material.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddInstrumentationsToBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new InstrumentationIDs(); // InstrumentationIDs | Resources that shall be added.
            var billOfMaterialId = 789;  // long? | Id of the bill of material to which the instrumentations will be added

            try
            {
                // Add instrumentations to a bill of material
                apiInstance.AddInstrumentationsToBillOfMaterial(body, billOfMaterialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.AddInstrumentationsToBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationIDs**](InstrumentationIDs.md)| Resources that shall be added. | 
 **billOfMaterialId** | **long?**| Id of the bill of material to which the instrumentations will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addrequestforquotationstobillofmaterial"></a>
# **AddRequestForQuotationsToBillOfMaterial**
> void AddRequestForQuotationsToBillOfMaterial (RequestForQuotationIDs body, long? billOfMaterialId)

Add request for quotations to a bill of material

Add one or more request for quotations to a bill of material.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddRequestForQuotationsToBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new RequestForQuotationIDs(); // RequestForQuotationIDs | Resources that shall be added.
            var billOfMaterialId = 789;  // long? | Id of the bill of material to which the request for quotations will be added

            try
            {
                // Add request for quotations to a bill of material
                apiInstance.AddRequestForQuotationsToBillOfMaterial(body, billOfMaterialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.AddRequestForQuotationsToBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestForQuotationIDs**](RequestForQuotationIDs.md)| Resources that shall be added. | 
 **billOfMaterialId** | **long?**| Id of the bill of material to which the request for quotations will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createbillofmaterial"></a>
# **CreateBillOfMaterial**
> BillOfMaterialResponse CreateBillOfMaterial (BillOfMaterialRequest body)

Create a new bill of material

Create a new bill of material

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new BillOfMaterialRequest(); // BillOfMaterialRequest | Object body that will be created.

            try
            {
                // Create a new bill of material
                BillOfMaterialResponse result = apiInstance.CreateBillOfMaterial(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.CreateBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfMaterialRequest**](BillOfMaterialRequest.md)| Object body that will be created. | 

### Return type

[**BillOfMaterialResponse**](BillOfMaterialResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebillofmaterial"></a>
# **DeleteBillOfMaterial**
> void DeleteBillOfMaterial (long? id)

Delete a bill of material

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
    public class DeleteBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var id = 789;  // long? | Id of the bill of material to delete

            try
            {
                // Delete a bill of material
                apiInstance.DeleteBillOfMaterial(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.DeleteBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the bill of material to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbillofmaterialbyid"></a>
# **GetBillOfMaterialById**
> BillOfMaterialResponse GetBillOfMaterialById (long? id)

Get a single bill of material

Get a specific bill of material identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetBillOfMaterialByIdExample
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

            var apiInstance = new BillOfMaterialApi();
            var id = 789;  // long? | Id of the bill of material to fetch

            try
            {
                // Get a single bill of material
                BillOfMaterialResponse result = apiInstance.GetBillOfMaterialById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.GetBillOfMaterialById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the bill of material to fetch | 

### Return type

[**BillOfMaterialResponse**](BillOfMaterialResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbillofmaterials"></a>
# **GetBillOfMaterials**
> BillOfMaterialsResponse GetBillOfMaterials (int? page = null, int? perPage = null, string name = null, string author = null, string date = null, string dateFrom = null, string dateTo = null, string orderBy = null)

Get a range of bill of materials

Returns a list of bill of materials. If the query has no matches, the response is an empty list.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetBillOfMaterialsExample
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

            var apiInstance = new BillOfMaterialApi();
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
                // Get a range of bill of materials
                BillOfMaterialsResponse result = apiInstance.GetBillOfMaterials(page, perPage, name, author, date, dateFrom, dateTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.GetBillOfMaterials: " + e.Message );
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
<a name="getdocumentsofbillofmaterial"></a>
# **GetDocumentsOfBillOfMaterial**
> DocumentsResponse GetDocumentsOfBillOfMaterial (long? billOfMaterialId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string orderBy = null, string acceptLanguage = null)

Get all documents of a bill of material

Returns a list of documents. If the query has no matches, the response is an empty list.  Possible include values: ```status, tenant, classification, categories, categories.parent, attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var billOfMaterialId = 789;  // long? | The resource defined in the URL
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
                // Get all documents of a bill of material
                DocumentsResponse result = apiInstance.GetDocumentsOfBillOfMaterial(billOfMaterialId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.GetDocumentsOfBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfMaterialId** | **long?**| The resource defined in the URL | 
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
<a name="getinstrumentationsofbillofmaterial"></a>
# **GetInstrumentationsOfBillOfMaterial**
> InstrumentationsResponse GetInstrumentationsOfBillOfMaterial (long? billOfMaterialId, int? page = null, int? perPage = null, string include = null, string tag = null, string statusId = null, string typeId = null, string parentId = null, string tenantId = null, string specificationsKey = null, string specificationsValue = null, string criticality = null, string accessibility = null, string assetStatusId = null, string permission = null, string orderBy = null)

Get all instrumentations of a bill of material

Returns a list of all instrumentations that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```specifications, specifications[key1,key2], pictures, tenant, parent, status, type```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationsOfBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var billOfMaterialId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var tag = tag_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var criticality = criticality_example;  // string | Filter accepts undefined, low, medium or high (optional) 
            var accessibility = accessibility_example;  // string | Filter accepts undefined, easy, moderate or difficult (optional) 
            var assetStatusId = assetStatusId_example;  // string | One or multiple ids (comma list). Expected id format is integer. This retrieves all Instrumentations where at least one of its assets has one of the given statuses. (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `tag`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all instrumentations of a bill of material
                InstrumentationsResponse result = apiInstance.GetInstrumentationsOfBillOfMaterial(billOfMaterialId, page, perPage, include, tag, statusId, typeId, parentId, tenantId, specificationsKey, specificationsValue, criticality, accessibility, assetStatusId, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.GetInstrumentationsOfBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfMaterialId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **tag** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **criticality** | **string**| Filter accepts undefined, low, medium or high | [optional] 
 **accessibility** | **string**| Filter accepts undefined, easy, moderate or difficult | [optional] 
 **assetStatusId** | **string**| One or multiple ids (comma list). Expected id format is integer. This retrieves all Instrumentations where at least one of its assets has one of the given statuses. | [optional] 
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;tag&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**InstrumentationsResponse**](InstrumentationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrequestforquotationsofbillofmaterial"></a>
# **GetRequestForQuotationsOfBillOfMaterial**
> RequestForQuotationsResponse GetRequestForQuotationsOfBillOfMaterial (long? billOfMaterialId, int? page = null, int? perPage = null, string name = null, string number = null, string statusId = null, string date = null, string dateFrom = null, string dateTo = null, string senderId = null, string receiverId = null, string author = null, string orderBy = null)

Get all request for quotations of a bill of material

Returns a list of all request for quotations that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetRequestForQuotationsOfBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var billOfMaterialId = 789;  // long? | The resource defined in the URL
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
                // Get all request for quotations of a bill of material
                RequestForQuotationsResponse result = apiInstance.GetRequestForQuotationsOfBillOfMaterial(billOfMaterialId, page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, author, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.GetRequestForQuotationsOfBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfMaterialId** | **long?**| The resource defined in the URL | 
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
<a name="removedocumentsfrombillofmaterial"></a>
# **RemoveDocumentsFromBillOfMaterial**
> void RemoveDocumentsFromBillOfMaterial (DocumentIDs body, long? billOfMaterialId)

Remove documents from a bill of material

Remove one or more documents from a bill of material.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDocumentsFromBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be removed.
            var billOfMaterialId = 789;  // long? | Id of the bill of material from which the documents will be removed

            try
            {
                // Remove documents from a bill of material
                apiInstance.RemoveDocumentsFromBillOfMaterial(body, billOfMaterialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.RemoveDocumentsFromBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be removed. | 
 **billOfMaterialId** | **long?**| Id of the bill of material from which the documents will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeinstrumentationsfrombillofmaterial"></a>
# **RemoveInstrumentationsFromBillOfMaterial**
> void RemoveInstrumentationsFromBillOfMaterial (InstrumentationIDs body, long? billOfMaterialId)

Remove instrumentations from a bill of material

Remove one or more instrumentations from a bill of material.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveInstrumentationsFromBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new InstrumentationIDs(); // InstrumentationIDs | Resources that shall be removed.
            var billOfMaterialId = 789;  // long? | Id of the bill of material from which the instrumentations will be removed

            try
            {
                // Remove instrumentations from a bill of material
                apiInstance.RemoveInstrumentationsFromBillOfMaterial(body, billOfMaterialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.RemoveInstrumentationsFromBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationIDs**](InstrumentationIDs.md)| Resources that shall be removed. | 
 **billOfMaterialId** | **long?**| Id of the bill of material from which the instrumentations will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removerequestforquotationsofbillofmaterial"></a>
# **RemoveRequestForQuotationsOfBillOfMaterial**
> void RemoveRequestForQuotationsOfBillOfMaterial (RequestForQuotationIDs body, long? billOfMaterialId)

Remove request for quotations from a bill of material

Remove one or more request for quotations from a bill of material.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveRequestForQuotationsOfBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new RequestForQuotationIDs(); // RequestForQuotationIDs | Resources that shall be removed.
            var billOfMaterialId = 789;  // long? | Id of the bill of material from which the request for quotations will be removed

            try
            {
                // Remove request for quotations from a bill of material
                apiInstance.RemoveRequestForQuotationsOfBillOfMaterial(body, billOfMaterialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.RemoveRequestForQuotationsOfBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestForQuotationIDs**](RequestForQuotationIDs.md)| Resources that shall be removed. | 
 **billOfMaterialId** | **long?**| Id of the bill of material from which the request for quotations will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedocumentsofbillofmaterial"></a>
# **ReplaceDocumentsOfBillOfMaterial**
> void ReplaceDocumentsOfBillOfMaterial (DocumentIDs body, long? billOfMaterialId)

Replace the documents of a bill of material

Replaces all documents belonging to a bill of material. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDocumentsOfBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be replaced
            var billOfMaterialId = 789;  // long? | Id of the bill of material of which the documents will be replaced

            try
            {
                // Replace the documents of a bill of material
                apiInstance.ReplaceDocumentsOfBillOfMaterial(body, billOfMaterialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.ReplaceDocumentsOfBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be replaced | 
 **billOfMaterialId** | **long?**| Id of the bill of material of which the documents will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceinstrumentationsofbillofmaterial"></a>
# **ReplaceInstrumentationsOfBillOfMaterial**
> void ReplaceInstrumentationsOfBillOfMaterial (InstrumentationIDs body, long? billOfMaterialId)

Replace the instrumentations of a bill of material

Replaces all instrumentations belonging to a bill of material. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceInstrumentationsOfBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new InstrumentationIDs(); // InstrumentationIDs | Resources that shall be replaced
            var billOfMaterialId = 789;  // long? | Id of the bill of material of which the instrumentations will be replaced

            try
            {
                // Replace the instrumentations of a bill of material
                apiInstance.ReplaceInstrumentationsOfBillOfMaterial(body, billOfMaterialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.ReplaceInstrumentationsOfBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationIDs**](InstrumentationIDs.md)| Resources that shall be replaced | 
 **billOfMaterialId** | **long?**| Id of the bill of material of which the instrumentations will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacerequestforquotationsofbillofmaterial"></a>
# **ReplaceRequestForQuotationsOfBillOfMaterial**
> void ReplaceRequestForQuotationsOfBillOfMaterial (RequestForQuotationIDs body, long? billOfMaterialId)

Replace the request for quotations of a bill of material

Replaces all request for quotations belonging to a bill of material. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceRequestForQuotationsOfBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new RequestForQuotationIDs(); // RequestForQuotationIDs | Resources that shall be replaced
            var billOfMaterialId = 789;  // long? | Id of the bill of material of which the request for quotations will be replaced

            try
            {
                // Replace the request for quotations of a bill of material
                apiInstance.ReplaceRequestForQuotationsOfBillOfMaterial(body, billOfMaterialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.ReplaceRequestForQuotationsOfBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestForQuotationIDs**](RequestForQuotationIDs.md)| Resources that shall be replaced | 
 **billOfMaterialId** | **long?**| Id of the bill of material of which the request for quotations will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatebillofmaterial"></a>
# **UpdateBillOfMaterial**
> void UpdateBillOfMaterial (BillOfMaterialRequest body, long? id)

Update a bill of material

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
    public class UpdateBillOfMaterialExample
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

            var apiInstance = new BillOfMaterialApi();
            var body = new BillOfMaterialRequest(); // BillOfMaterialRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the bill of material to update

            try
            {
                // Update a bill of material
                apiInstance.UpdateBillOfMaterial(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfMaterialApi.UpdateBillOfMaterial: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfMaterialRequest**](BillOfMaterialRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the bill of material to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
