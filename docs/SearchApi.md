# Netilion.Api.Api.SearchApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Search**](SearchApi.md#search) | **GET** /search | search assets, batches, instrumentations, nodes, recipes, systems .

<a name="search"></a>
# **Search**
> SearchItemsResponse Search (string q, int? page = null, int? perPage = null, string manufacturerId = null, string productCategoryId = null, string productStatusId = null, string subscriptionId = null, string scope = null, string acceptLanguage = null)

search assets, batches, instrumentations, nodes, recipes, systems .

search assets, instrumentations and nodes based on a defined set of fields.   asset - serial_number product_code product_name product_manufacturer_name   specification keys and values (of assets, nodes and instrumentation) when ui_visible is set to true   batches - batch_name      instrumentation - tag   nodes - name   recipes - recipe_name      systems - system_name    These fields may be extended in the  future.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class SearchExample
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

            var apiInstance = new SearchApi();
            var q = q_example;  // string | search query
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var productCategoryId = productCategoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var productStatusId = productStatusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var subscriptionId = subscriptionId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var scope = scope_example;  // string | One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // search assets, batches, instrumentations, nodes, recipes, systems .
                SearchItemsResponse result = apiInstance.Search(q, page, perPage, manufacturerId, productCategoryId, productStatusId, subscriptionId, scope, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| search query | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **productCategoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **productStatusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **subscriptionId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **scope** | **string**| One or multiple scopes (comma list). Possible values are assets, instrumentations, nodes. | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**SearchItemsResponse**](SearchItemsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
