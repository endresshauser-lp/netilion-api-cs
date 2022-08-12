# Netilion.Api.Api.UnitApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUnitById**](UnitApi.md#getunitbyid) | **GET** /units/{id} | Get a single Unit
[**GetUnits**](UnitApi.md#getunits) | **GET** /units | Get a range of units.

<a name="getunitbyid"></a>
# **GetUnitById**
> UnitResponse GetUnitById (long? id, string include = null)

Get a single Unit

Get a specific unit identified by the id in the URL. Possible include values: `base_unit`

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUnitByIdExample
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

            var apiInstance = new UnitApi();
            var id = 789;  // long? | Id of the unit to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single Unit
                UnitResponse result = apiInstance.GetUnitById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UnitApi.GetUnitById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the unit to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**UnitResponse**](UnitResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getunits"></a>
# **GetUnits**
> UnitsResponse GetUnits (int? page = null, int? perPage = null, string include = null, string code = null, string symbol = null, string name = null, string baseUnitId = null, string orderBy = null, string acceptLanguage = null)

Get a range of units.

Returns a list of all units that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array. Possible include values: `base_unit`

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUnitsExample
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

            var apiInstance = new UnitApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var symbol = symbol_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var baseUnitId = baseUnitId_example;  // string | One or multiple ids (comma list). (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `code`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of units.
                UnitsResponse result = apiInstance.GetUnits(page, perPage, include, code, symbol, name, baseUnitId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UnitApi.GetUnits: " + e.Message );
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
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **symbol** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **baseUnitId** | **string**| One or multiple ids (comma list). | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;code&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**UnitsResponse**](UnitsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
