# Netilion.Api.Api.InstrumentationTypeApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInstrumentationType**](InstrumentationTypeApi.md#createinstrumentationtype) | **POST** /instrumentation/types | Create a new instrumentation type
[**DeleteInstrumentationType**](InstrumentationTypeApi.md#deleteinstrumentationtype) | **DELETE** /instrumentation/types/{id} | Delete an instrumentation type
[**GetInstrumentationIdType**](InstrumentationTypeApi.md#getinstrumentationidtype) | **GET** /instrumentations/{instrumentation_id}/type | Get the type of the specific instrumentation
[**GetInstrumentationTypeById**](InstrumentationTypeApi.md#getinstrumentationtypebyid) | **GET** /instrumentation/types/{id} | Get a single instrumentation type
[**GetInstrumentationTypes**](InstrumentationTypeApi.md#getinstrumentationtypes) | **GET** /instrumentation/types | Get a range of instrumentation types
[**GetInstrumentationTypesOptions**](InstrumentationTypeApi.md#getinstrumentationtypesoptions) | **GET** /instrumentations/{instrumentation_id}/type-options | Get all possible types of the specified instrumentation
[**UpdateInstrumentationType**](InstrumentationTypeApi.md#updateinstrumentationtype) | **PATCH** /instrumentation/types/{id} | Update an instrumentation type

<a name="createinstrumentationtype"></a>
# **CreateInstrumentationType**
> InstrumentationTypeResponse CreateInstrumentationType (InstrumentationTypeRequest body)

Create a new instrumentation type

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
    public class CreateInstrumentationTypeExample
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

            var apiInstance = new InstrumentationTypeApi();
            var body = new InstrumentationTypeRequest(); // InstrumentationTypeRequest | InstrumentationType object to create.

            try
            {
                // Create a new instrumentation type
                InstrumentationTypeResponse result = apiInstance.CreateInstrumentationType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationTypeApi.CreateInstrumentationType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationTypeRequest**](InstrumentationTypeRequest.md)| InstrumentationType object to create. | 

### Return type

[**InstrumentationTypeResponse**](InstrumentationTypeResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteinstrumentationtype"></a>
# **DeleteInstrumentationType**
> void DeleteInstrumentationType (long? id)

Delete an instrumentation type

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
    public class DeleteInstrumentationTypeExample
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

            var apiInstance = new InstrumentationTypeApi();
            var id = 789;  // long? | Id of the instrumentation type to delete

            try
            {
                // Delete an instrumentation type
                apiInstance.DeleteInstrumentationType(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationTypeApi.DeleteInstrumentationType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the instrumentation type to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationidtype"></a>
# **GetInstrumentationIdType**
> InstrumentationTypeResponse GetInstrumentationIdType (long? instrumentationId, string acceptLanguage = null)

Get the type of the specific instrumentation

Returns the type of the instrumentation. Needed if only permission on instrumentation but not on tenant. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```parent```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationIdTypeExample
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

            var apiInstance = new InstrumentationTypeApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the type of the specific instrumentation
                InstrumentationTypeResponse result = apiInstance.GetInstrumentationIdType(instrumentationId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationTypeApi.GetInstrumentationIdType: " + e.Message );
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

[**InstrumentationTypeResponse**](InstrumentationTypeResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationtypebyid"></a>
# **GetInstrumentationTypeById**
> InstrumentationTypeResponse GetInstrumentationTypeById (long? id, string include = null, string acceptLanguage = null)

Get a single instrumentation type

Get a specific instrumentation type identified by the id in the URL. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```parent, tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationTypeByIdExample
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

            var apiInstance = new InstrumentationTypeApi();
            var id = 789;  // long? | Id of instrumentation type to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single instrumentation type
                InstrumentationTypeResponse result = apiInstance.GetInstrumentationTypeById(id, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationTypeApi.GetInstrumentationTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of instrumentation type to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**InstrumentationTypeResponse**](InstrumentationTypeResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationtypes"></a>
# **GetInstrumentationTypes**
> InstrumentationTypes GetInstrumentationTypes (int? page = null, int? perPage = null, string include = null, string name = null, string code = null, string tenantId = null, string parentId = null, string orderBy = null, string acceptLanguage = null)

Get a range of instrumentation types

Returns a list of all event types that are available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```parent, tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationTypesExample
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

            var apiInstance = new InstrumentationTypeApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | searches instrumentation types with given name (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of instrumentation types
                InstrumentationTypes result = apiInstance.GetInstrumentationTypes(page, perPage, include, name, code, tenantId, parentId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationTypeApi.GetInstrumentationTypes: " + e.Message );
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
 **name** | **string**| searches instrumentation types with given name | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**InstrumentationTypes**](InstrumentationTypes.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationtypesoptions"></a>
# **GetInstrumentationTypesOptions**
> InstrumentationTypes GetInstrumentationTypesOptions (long? instrumentationId, int? page = null, int? perPage = null, string tenantId = null, string name = null, string code = null, string acceptLanguage = null)

Get all possible types of the specified instrumentation

Returns a list of all possible instrumentation types for the specified instrument. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationTypesOptionsExample
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

            var apiInstance = new InstrumentationTypeApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all possible types of the specified instrumentation
                InstrumentationTypes result = apiInstance.GetInstrumentationTypesOptions(instrumentationId, page, perPage, tenantId, name, code, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationTypeApi.GetInstrumentationTypesOptions: " + e.Message );
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

[**InstrumentationTypes**](InstrumentationTypes.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateinstrumentationtype"></a>
# **UpdateInstrumentationType**
> void UpdateInstrumentationType (InstrumentationTypeRequest body, long? id, string contentLanguage = null)

Update an instrumentation type

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
    public class UpdateInstrumentationTypeExample
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

            var apiInstance = new InstrumentationTypeApi();
            var body = new InstrumentationTypeRequest(); // InstrumentationTypeRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the instrumentation type to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update an instrumentation type
                apiInstance.UpdateInstrumentationType(body, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationTypeApi.UpdateInstrumentationType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationTypeRequest**](InstrumentationTypeRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the instrumentation type to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
