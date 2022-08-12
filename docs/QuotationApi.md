# Netilion.Api.Api.QuotationApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDocumentsToQuotation**](QuotationApi.md#adddocumentstoquotation) | **POST** /quotations/{quotation_id}/documents | Add documents to a quotation
[**AddProductsToQuotation**](QuotationApi.md#addproductstoquotation) | **POST** /quotations/{quotation_id}/products | Add products to a quotation
[**AddPurchaseOrdersToQuotation**](QuotationApi.md#addpurchaseorderstoquotation) | **POST** /quotations/{quotation_id}/purchase_orders | Add purchase orders to a quotation
[**CreateQuotation**](QuotationApi.md#createquotation) | **POST** /quotations | Create a new quotation
[**DeleteQuotation**](QuotationApi.md#deletequotation) | **DELETE** /quotations/{id} | Delete a quotation
[**GetDocumentsOfQuotation**](QuotationApi.md#getdocumentsofquotation) | **GET** /quotations/{quotation_id}/documents | Get all documents of one quotation
[**GetProductsOfQuotation**](QuotationApi.md#getproductsofquotation) | **GET** /quotations/{quotation_id}/products | Get all products of one quotation
[**GetPurchaseOrdersOfQuotation**](QuotationApi.md#getpurchaseordersofquotation) | **GET** /quotations/{quotation_id}/purchase_orders | Get all purchase orders of one quotation
[**GetQuotationById**](QuotationApi.md#getquotationbyid) | **GET** /quotations/{id} | Get a single quotation
[**GetQuotationIdStatus**](QuotationApi.md#getquotationidstatus) | **GET** /quotations/{quotation_id}/status | Get the status of the specific quotation
[**GetQuotations**](QuotationApi.md#getquotations) | **GET** /quotations | Get a range of quotations
[**RemoveDocumentsFromQuotation**](QuotationApi.md#removedocumentsfromquotation) | **DELETE** /quotations/{quotation_id}/documents | Remove documents from a quotation
[**RemoveProductsFromQuotation**](QuotationApi.md#removeproductsfromquotation) | **DELETE** /quotations/{quotation_id}/products | Remove products from a quotation
[**RemovePurchaseOrdersFromQuotation**](QuotationApi.md#removepurchaseordersfromquotation) | **DELETE** /quotations/{quotation_id}/purchase_orders | Remove purchase orders from a quotation
[**ReplaceDocumentsOfQuotation**](QuotationApi.md#replacedocumentsofquotation) | **PATCH** /quotations/{quotation_id}/documents | Replace the documents of a quotation
[**ReplaceProductsOfQuotation**](QuotationApi.md#replaceproductsofquotation) | **PATCH** /quotations/{quotation_id}/products | Replace the products of a quotation
[**ReplacePurchaseOrdersOfQuotation**](QuotationApi.md#replacepurchaseordersofquotation) | **PATCH** /quotations/{quotation_id}/purchase_orders | Replace the purchase orders of a quotation
[**UpdateProductQuantitiesOfQuotation**](QuotationApi.md#updateproductquantitiesofquotation) | **PATCH** /quotations/{quotation_id}/products/quantity | Change the product quantity in a quotation
[**UpdateQuotation**](QuotationApi.md#updatequotation) | **PATCH** /quotations/{id} | Update a quotation

<a name="adddocumentstoquotation"></a>
# **AddDocumentsToQuotation**
> void AddDocumentsToQuotation (DocumentIDs body, long? quotationId)

Add documents to a quotation

Add one or more documents to a quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDocumentsToQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be added.
            var quotationId = 789;  // long? | Id of the quotation to which the documents will be added

            try
            {
                // Add documents to a quotation
                apiInstance.AddDocumentsToQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.AddDocumentsToQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be added. | 
 **quotationId** | **long?**| Id of the quotation to which the documents will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addproductstoquotation"></a>
# **AddProductsToQuotation**
> void AddProductsToQuotation (ProductIDs body, long? quotationId)

Add products to a quotation

Add one or more products to a quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddProductsToQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new ProductIDs(); // ProductIDs | Resources that shall be added.
            var quotationId = 789;  // long? | Id of the quotation to which the products will be added

            try
            {
                // Add products to a quotation
                apiInstance.AddProductsToQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.AddProductsToQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIDs**](ProductIDs.md)| Resources that shall be added. | 
 **quotationId** | **long?**| Id of the quotation to which the products will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addpurchaseorderstoquotation"></a>
# **AddPurchaseOrdersToQuotation**
> void AddPurchaseOrdersToQuotation (PurchaseOrderIDs body, long? quotationId)

Add purchase orders to a quotation

Add one or more purchase orders to a quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddPurchaseOrdersToQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new PurchaseOrderIDs(); // PurchaseOrderIDs | Resources that shall be added.
            var quotationId = 789;  // long? | Id of the quotation to which the purchase orders will be added

            try
            {
                // Add purchase orders to a quotation
                apiInstance.AddPurchaseOrdersToQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.AddPurchaseOrdersToQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderIDs**](PurchaseOrderIDs.md)| Resources that shall be added. | 
 **quotationId** | **long?**| Id of the quotation to which the purchase orders will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createquotation"></a>
# **CreateQuotation**
> QuotationResponse CreateQuotation (QuotationRequest body)

Create a new quotation

Create a new quotation with a sender and a receiver.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new QuotationRequest(); // QuotationRequest | Object body that will be created.

            try
            {
                // Create a new quotation
                QuotationResponse result = apiInstance.CreateQuotation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.CreateQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuotationRequest**](QuotationRequest.md)| Object body that will be created. | 

### Return type

[**QuotationResponse**](QuotationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletequotation"></a>
# **DeleteQuotation**
> void DeleteQuotation (long? id)

Delete a quotation

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
    public class DeleteQuotationExample
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

            var apiInstance = new QuotationApi();
            var id = 789;  // long? | Id of the quotation to delete

            try
            {
                // Delete a quotation
                apiInstance.DeleteQuotation(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.DeleteQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the quotation to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdocumentsofquotation"></a>
# **GetDocumentsOfQuotation**
> DocumentsResponse GetDocumentsOfQuotation (long? quotationId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string orderBy = null, string acceptLanguage = null)

Get all documents of one quotation

Returns a list of documents. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, classification, categories, categories.parent, categories.standards, attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfQuotationExample
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

            var apiInstance = new QuotationApi();
            var quotationId = 789;  // long? | The resource defined in the URL
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
                // Get all documents of one quotation
                DocumentsResponse result = apiInstance.GetDocumentsOfQuotation(quotationId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.GetDocumentsOfQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quotationId** | **long?**| The resource defined in the URL | 
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
<a name="getproductsofquotation"></a>
# **GetProductsOfQuotation**
> ProductsResponse GetProductsOfQuotation (long? quotationId, int? page = null, int? perPage = null, string productCode = null, string name = null, string manufacturerId = null, string statusId = null, string parentId = null, string orderBy = null, string acceptLanguage = null)

Get all products of one quotation

Returns a list of all products that are available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductsOfQuotationExample
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

            var apiInstance = new QuotationApi();
            var quotationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var productCode = productCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all products of one quotation
                ProductsResponse result = apiInstance.GetProductsOfQuotation(quotationId, page, perPage, productCode, name, manufacturerId, statusId, parentId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.GetProductsOfQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quotationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **productCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
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
<a name="getpurchaseordersofquotation"></a>
# **GetPurchaseOrdersOfQuotation**
> PurchaseOrdersResponse GetPurchaseOrdersOfQuotation (string quotationId = null, int? page = null, int? perPage = null, string name = null, string number = null, string date = null, string dateFrom = null, string dateTo = null, string statusId = null, string senderId = null, string receiverId = null, string customerNumber = null, string orderBy = null)

Get all purchase orders of one quotation

Returns a list of all purchase orders that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPurchaseOrdersOfQuotationExample
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

            var apiInstance = new QuotationApi();
            var quotationId = quotationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var date = date_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateFrom = dateFrom_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateTo = dateTo_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var senderId = senderId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var receiverId = receiverId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var customerNumber = customerNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all purchase orders of one quotation
                PurchaseOrdersResponse result = apiInstance.GetPurchaseOrdersOfQuotation(quotationId, page, perPage, name, number, date, dateFrom, dateTo, statusId, senderId, receiverId, customerNumber, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.GetPurchaseOrdersOfQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quotationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **date** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateFrom** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateTo** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **senderId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **receiverId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
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
<a name="getquotationbyid"></a>
# **GetQuotationById**
> QuotationResponse GetQuotationById (long? id)

Get a single quotation

Get a specific quotation identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetQuotationByIdExample
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

            var apiInstance = new QuotationApi();
            var id = 789;  // long? | Id of the quotation to fetch

            try
            {
                // Get a single quotation
                QuotationResponse result = apiInstance.GetQuotationById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.GetQuotationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the quotation to fetch | 

### Return type

[**QuotationResponse**](QuotationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getquotationidstatus"></a>
# **GetQuotationIdStatus**
> QuotationStatusResponse GetQuotationIdStatus (long? quotationId, string include = null, string acceptLanguage = null)

Get the status of the specific quotation

Returns the status of the quotation. Needed if only permission on quotation but not on tenant. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetQuotationIdStatusExample
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

            var apiInstance = new QuotationApi();
            var quotationId = 789;  // long? | Id of the specified quotation
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the status of the specific quotation
                QuotationStatusResponse result = apiInstance.GetQuotationIdStatus(quotationId, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.GetQuotationIdStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quotationId** | **long?**| Id of the specified quotation | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**QuotationStatusResponse**](QuotationStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getquotations"></a>
# **GetQuotations**
> QuotationsResponse GetQuotations (int? page = null, int? perPage = null, string name = null, string number = null, string statusId = null, string date = null, string dateFrom = null, string dateTo = null, string senderId = null, string receiverId = null, string requestForQuotationId = null, string orderBy = null)

Get a range of quotations

Returns a list of quotations. If the query has no matches, the response is an empty list.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetQuotationsExample
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

            var apiInstance = new QuotationApi();
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
            var requestForQuotationId = requestForQuotationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of quotations
                QuotationsResponse result = apiInstance.GetQuotations(page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, requestForQuotationId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.GetQuotations: " + e.Message );
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
 **requestForQuotationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**QuotationsResponse**](QuotationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removedocumentsfromquotation"></a>
# **RemoveDocumentsFromQuotation**
> void RemoveDocumentsFromQuotation (DocumentIDs body, long? quotationId)

Remove documents from a quotation

Remove one or more documents from a quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDocumentsFromQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be removed.
            var quotationId = 789;  // long? | Id of the quotation from which the documents will be removed

            try
            {
                // Remove documents from a quotation
                apiInstance.RemoveDocumentsFromQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.RemoveDocumentsFromQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be removed. | 
 **quotationId** | **long?**| Id of the quotation from which the documents will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeproductsfromquotation"></a>
# **RemoveProductsFromQuotation**
> void RemoveProductsFromQuotation (ProductIDs body, long? quotationId)

Remove products from a quotation

Remove one or more products from a quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveProductsFromQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new ProductIDs(); // ProductIDs | Resources that shall be removed.
            var quotationId = 789;  // long? | Id of the quotation from which the products will be removed

            try
            {
                // Remove products from a quotation
                apiInstance.RemoveProductsFromQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.RemoveProductsFromQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIDs**](ProductIDs.md)| Resources that shall be removed. | 
 **quotationId** | **long?**| Id of the quotation from which the products will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removepurchaseordersfromquotation"></a>
# **RemovePurchaseOrdersFromQuotation**
> void RemovePurchaseOrdersFromQuotation (PurchaseOrderIDs body, long? quotationId)

Remove purchase orders from a quotation

Remove one or more purchase orders from a quotation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemovePurchaseOrdersFromQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new PurchaseOrderIDs(); // PurchaseOrderIDs | Resources that shall be removed.
            var quotationId = 789;  // long? | Id of the quotation from which the purchase orders will be removed

            try
            {
                // Remove purchase orders from a quotation
                apiInstance.RemovePurchaseOrdersFromQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.RemovePurchaseOrdersFromQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderIDs**](PurchaseOrderIDs.md)| Resources that shall be removed. | 
 **quotationId** | **long?**| Id of the quotation from which the purchase orders will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedocumentsofquotation"></a>
# **ReplaceDocumentsOfQuotation**
> void ReplaceDocumentsOfQuotation (DocumentIDs body, long? quotationId)

Replace the documents of a quotation

Replaces all documents belonging to a quotation. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDocumentsOfQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be replaced
            var quotationId = 789;  // long? | Id of the quotation of which the documents will be replaced

            try
            {
                // Replace the documents of a quotation
                apiInstance.ReplaceDocumentsOfQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.ReplaceDocumentsOfQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be replaced | 
 **quotationId** | **long?**| Id of the quotation of which the documents will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceproductsofquotation"></a>
# **ReplaceProductsOfQuotation**
> void ReplaceProductsOfQuotation (ProductIDs body, long? quotationId)

Replace the products of a quotation

Replaces all products belonging to a quotation. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceProductsOfQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new ProductIDs(); // ProductIDs | Resources that shall be replaced
            var quotationId = 789;  // long? | Id of the quotation of which the products will be replaced

            try
            {
                // Replace the products of a quotation
                apiInstance.ReplaceProductsOfQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.ReplaceProductsOfQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIDs**](ProductIDs.md)| Resources that shall be replaced | 
 **quotationId** | **long?**| Id of the quotation of which the products will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacepurchaseordersofquotation"></a>
# **ReplacePurchaseOrdersOfQuotation**
> void ReplacePurchaseOrdersOfQuotation (PurchaseOrderIDs body, long? quotationId)

Replace the purchase orders of a quotation

Replaces all purchase orders belonging to a quotation. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplacePurchaseOrdersOfQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new PurchaseOrderIDs(); // PurchaseOrderIDs | Resources that shall be replaced
            var quotationId = 789;  // long? | Id of the quotation of which the purchase orders will be replaced

            try
            {
                // Replace the purchase orders of a quotation
                apiInstance.ReplacePurchaseOrdersOfQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.ReplacePurchaseOrdersOfQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderIDs**](PurchaseOrderIDs.md)| Resources that shall be replaced | 
 **quotationId** | **long?**| Id of the quotation of which the purchase orders will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductquantitiesofquotation"></a>
# **UpdateProductQuantitiesOfQuotation**
> void UpdateProductQuantitiesOfQuotation (ProductQuantity body, long? quotationId)

Change the product quantity in a quotation

Sets a new quantity of a product in a quotation or deletes the line in case quantity is zero.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateProductQuantitiesOfQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new ProductQuantity(); // ProductQuantity | Resources that shall be changed or removed
            var quotationId = 789;  // long? | Id of the quotation of which the change will be done

            try
            {
                // Change the product quantity in a quotation
                apiInstance.UpdateProductQuantitiesOfQuotation(body, quotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.UpdateProductQuantitiesOfQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductQuantity**](ProductQuantity.md)| Resources that shall be changed or removed | 
 **quotationId** | **long?**| Id of the quotation of which the change will be done | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatequotation"></a>
# **UpdateQuotation**
> void UpdateQuotation (QuotationRequest body, long? id)

Update a quotation

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
    public class UpdateQuotationExample
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

            var apiInstance = new QuotationApi();
            var body = new QuotationRequest(); // QuotationRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the quotation to update

            try
            {
                // Update a quotation
                apiInstance.UpdateQuotation(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotationApi.UpdateQuotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuotationRequest**](QuotationRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the quotation to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
