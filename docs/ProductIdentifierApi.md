# Netilion.Api.Api.ProductIdentifierApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddProductsToProductIdentifier**](ProductIdentifierApi.md#addproductstoproductidentifier) | **POST** /product/identifiers/{product_identifier_id}/products | Add products to a product identifier
[**CreateProductIdentifier**](ProductIdentifierApi.md#createproductidentifier) | **POST** /product/identifiers | Create a new product identifier
[**CreateProductIdentifierForProduct**](ProductIdentifierApi.md#createproductidentifierforproduct) | **POST** /products/{product_id}/identifiers | Create a new product identifier for a product
[**DeleteProductIdentifier**](ProductIdentifierApi.md#deleteproductidentifier) | **DELETE** /product/identifiers/{id} | Delete a product identifier
[**GetProductIdentifierById**](ProductIdentifierApi.md#getproductidentifierbyid) | **GET** /product/identifiers/{id} | Get a single product identifier
[**GetProductIdentifiers**](ProductIdentifierApi.md#getproductidentifiers) | **GET** /product/identifiers | Get a range of product identifiers
[**GetProductIdentifiersOfProduct**](ProductIdentifierApi.md#getproductidentifiersofproduct) | **GET** /products/{product_id}/identifiers | Get all product identifiers of one product
[**GetProductsOfProductIdentifier**](ProductIdentifierApi.md#getproductsofproductidentifier) | **GET** /product/identifiers/{product_identifier_id}/products | Get all products of one product identifier
[**RemoveProductIdentifierFromProduct**](ProductIdentifierApi.md#removeproductidentifierfromproduct) | **DELETE** /products/{product_id}/identifiers | Remove product identifiers from a product
[**RemoveProductsFromProductIdentifier**](ProductIdentifierApi.md#removeproductsfromproductidentifier) | **DELETE** /product/identifiers/{product_identifier_id}/products | Remove products from a product identifier
[**UpdateProductIdentifier**](ProductIdentifierApi.md#updateproductidentifier) | **PATCH** /product/identifiers/{id} | Update a product identifier

<a name="addproductstoproductidentifier"></a>
# **AddProductsToProductIdentifier**
> void AddProductsToProductIdentifier (ProductIDs body, long? productIdentifierId)

Add products to a product identifier

Adds one or more products to a product identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddProductsToProductIdentifierExample
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

            var apiInstance = new ProductIdentifierApi();
            var body = new ProductIDs(); // ProductIDs | Resources that shall be added.
            var productIdentifierId = 789;  // long? | Id of the product identifier to which the products will get added

            try
            {
                // Add products to a product identifier
                apiInstance.AddProductsToProductIdentifier(body, productIdentifierId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.AddProductsToProductIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIDs**](ProductIDs.md)| Resources that shall be added. | 
 **productIdentifierId** | **long?**| Id of the product identifier to which the products will get added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createproductidentifier"></a>
# **CreateProductIdentifier**
> ProductIdentifierResponse CreateProductIdentifier (ProductIdentifierRequest body)

Create a new product identifier

Product identifiers must have a product identifier that is unique under the tenant and protocols scope. They need to be assigned to at least one product. To create a product identifier for a product you need the tenant admin role on the products tenant.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateProductIdentifierExample
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

            var apiInstance = new ProductIdentifierApi();
            var body = new ProductIdentifierRequest(); // ProductIdentifierRequest | Product identifier object that needs to be created.

            try
            {
                // Create a new product identifier
                ProductIdentifierResponse result = apiInstance.CreateProductIdentifier(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.CreateProductIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIdentifierRequest**](ProductIdentifierRequest.md)| Product identifier object that needs to be created. | 

### Return type

[**ProductIdentifierResponse**](ProductIdentifierResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createproductidentifierforproduct"></a>
# **CreateProductIdentifierForProduct**
> ProductIdentifierResponse CreateProductIdentifierForProduct (ProductIdentifierRequestNoProducts body, long? productId)

Create a new product identifier for a product

Product identifiers must have a product identifier that is unique under the tenant and protocols scope. To create a product identifier for a product you need the tenant admin role on the products tenant.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateProductIdentifierForProductExample
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

            var apiInstance = new ProductIdentifierApi();
            var body = new ProductIdentifierRequestNoProducts(); // ProductIdentifierRequestNoProducts | Object to be created.
            var productId = 789;  // long? | Id of the product

            try
            {
                // Create a new product identifier for a product
                ProductIdentifierResponse result = apiInstance.CreateProductIdentifierForProduct(body, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.CreateProductIdentifierForProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIdentifierRequestNoProducts**](ProductIdentifierRequestNoProducts.md)| Object to be created. | 
 **productId** | **long?**| Id of the product | 

### Return type

[**ProductIdentifierResponse**](ProductIdentifierResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproductidentifier"></a>
# **DeleteProductIdentifier**
> void DeleteProductIdentifier (long? id)

Delete a product identifier

Delete a specific resource product identifier identified by the id in the URL. To delete a product identifier of a product you need the tenant admin role on the products tenant.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteProductIdentifierExample
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

            var apiInstance = new ProductIdentifierApi();
            var id = 789;  // long? | Id of the product identifier to delete

            try
            {
                // Delete a product identifier
                apiInstance.DeleteProductIdentifier(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.DeleteProductIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product identifier to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductidentifierbyid"></a>
# **GetProductIdentifierById**
> ProductIdentifierResponse GetProductIdentifierById (long? id, string include = null)

Get a single product identifier

Get a specific product identifier identified by the id in the URL.  Possible include values: ```products```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductIdentifierByIdExample
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

            var apiInstance = new ProductIdentifierApi();
            var id = 789;  // long? | Id of the product identifier to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single product identifier
                ProductIdentifierResponse result = apiInstance.GetProductIdentifierById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.GetProductIdentifierById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product identifier to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**ProductIdentifierResponse**](ProductIdentifierResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductidentifiers"></a>
# **GetProductIdentifiers**
> ProductIdentifiersResponse GetProductIdentifiers (int? page = null, int? perPage = null, string include = null, string organizationName = null, string protocol = null, string protocolVersion = null, string productIdentifier = null, string tenantId = null)

Get a range of product identifiers

Returns a list of product identifiers. If the query has no matches, the response is an empty list.  Possible include values: ```products```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductIdentifiersExample
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

            var apiInstance = new ProductIdentifierApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var organizationName = organizationName_example;  // string | Filter accepts `FIELDCOMM_GROUP`, `PROFIBUS_PROFINET`, `ODVA`, `MODBUS_ORGANIZATION`, `OTHER_ORGANIZATION` (optional) 
            var protocol = protocol_example;  // string | Filter accepts `PROFIBUS`, `HART`, `ETHERNETIP`, `MODBUS`, `OTHERS (optional) 
            var protocolVersion = protocolVersion_example;  // string | Filter accepts * as wildcard (optional) 
            var productIdentifier = productIdentifier_example;  // string | Filter accepts * as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 

            try
            {
                // Get a range of product identifiers
                ProductIdentifiersResponse result = apiInstance.GetProductIdentifiers(page, perPage, include, organizationName, protocol, protocolVersion, productIdentifier, tenantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.GetProductIdentifiers: " + e.Message );
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
 **organizationName** | **string**| Filter accepts &#x60;FIELDCOMM_GROUP&#x60;, &#x60;PROFIBUS_PROFINET&#x60;, &#x60;ODVA&#x60;, &#x60;MODBUS_ORGANIZATION&#x60;, &#x60;OTHER_ORGANIZATION&#x60; | [optional] 
 **protocol** | **string**| Filter accepts &#x60;PROFIBUS&#x60;, &#x60;HART&#x60;, &#x60;ETHERNETIP&#x60;, &#x60;MODBUS&#x60;, &#x60;OTHERS | [optional] 
 **protocolVersion** | **string**| Filter accepts * as wildcard | [optional] 
 **productIdentifier** | **string**| Filter accepts * as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 

### Return type

[**ProductIdentifiersResponse**](ProductIdentifiersResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductidentifiersofproduct"></a>
# **GetProductIdentifiersOfProduct**
> ProductIdentifiersResponse GetProductIdentifiersOfProduct (long? productId, int? page = null, int? perPage = null, string include = null)

Get all product identifiers of one product

Returns a list of all product identifiers belonging to a product. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ``tenant``

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductIdentifiersOfProductExample
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

            var apiInstance = new ProductIdentifierApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get all product identifiers of one product
                ProductIdentifiersResponse result = apiInstance.GetProductIdentifiersOfProduct(productId, page, perPage, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.GetProductIdentifiersOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**ProductIdentifiersResponse**](ProductIdentifiersResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductsofproductidentifier"></a>
# **GetProductsOfProductIdentifier**
> ProductsResponse GetProductsOfProductIdentifier (long? productIdentifierId, int? page = null, int? perPage = null, string include = null, string productCode = null, string name = null, string manufacturerId = null, string statusId = null, string categoryId = null, string parentId = null, string tenantId = null, string specificationsKey = null, string specificationsValue = null, string orderBy = null, string acceptLanguage = null)

Get all products of one product identifier

Returns a list of all products of a product identifier that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array. Parameters supporting translation: ```name, description```. To get a translation set the ```Accept-Language``` header. Possible include values: ```status, tenant, parent, manufacturer, pictures, specifications, specifications[key1,key2], categories, categories.parent```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductsOfProductIdentifierExample
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

            var apiInstance = new ProductIdentifierApi();
            var productIdentifierId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var productCode = productCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all products of one product identifier
                ProductsResponse result = apiInstance.GetProductsOfProductIdentifier(productIdentifierId, page, perPage, include, productCode, name, manufacturerId, statusId, categoryId, parentId, tenantId, specificationsKey, specificationsValue, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.GetProductsOfProductIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productIdentifierId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **productCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
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
<a name="removeproductidentifierfromproduct"></a>
# **RemoveProductIdentifierFromProduct**
> void RemoveProductIdentifierFromProduct (ProductIdentifiers body, long? productId)

Remove product identifiers from a product

Remove one or more product identifiers from an product. If the product identifier has no more related products, the product identifier will be deleted. To delete a product identifier of a product you need the tenant admin role on the products tenant.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveProductIdentifierFromProductExample
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

            var apiInstance = new ProductIdentifierApi();
            var body = new ProductIdentifiers(); // ProductIdentifiers | Resources that shall be removed.
            var productId = 789;  // long? | Id of the product from which the product identifiers will removed.

            try
            {
                // Remove product identifiers from a product
                apiInstance.RemoveProductIdentifierFromProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.RemoveProductIdentifierFromProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIdentifiers**](ProductIdentifiers.md)| Resources that shall be removed. | 
 **productId** | **long?**| Id of the product from which the product identifiers will removed. | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeproductsfromproductidentifier"></a>
# **RemoveProductsFromProductIdentifier**
> void RemoveProductsFromProductIdentifier (ProductIDs body, long? productIdentifierId)

Remove products from a product identifier

Remove one or more products from a product identifier. If the product identifier has no more related products, the product identifier will be deleted

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveProductsFromProductIdentifierExample
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

            var apiInstance = new ProductIdentifierApi();
            var body = new ProductIDs(); // ProductIDs | Resources that shall be removed.
            var productIdentifierId = 789;  // long? | Id of the product identifier from which the products will be removed

            try
            {
                // Remove products from a product identifier
                apiInstance.RemoveProductsFromProductIdentifier(body, productIdentifierId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.RemoveProductsFromProductIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIDs**](ProductIDs.md)| Resources that shall be removed. | 
 **productIdentifierId** | **long?**| Id of the product identifier from which the products will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductidentifier"></a>
# **UpdateProductIdentifier**
> void UpdateProductIdentifier (ProductIdentifierRequest body, long? id)

Update a product identifier

Update accessible parameters of the requested resource. To update a product identifier for a product you need the tenant admin role on the products tenant.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateProductIdentifierExample
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

            var apiInstance = new ProductIdentifierApi();
            var body = new ProductIdentifierRequest(); // ProductIdentifierRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the product identifier to update

            try
            {
                // Update a product identifier
                apiInstance.UpdateProductIdentifier(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductIdentifierApi.UpdateProductIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductIdentifierRequest**](ProductIdentifierRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the product identifier to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
