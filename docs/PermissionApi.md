# Netilion.Api.Api.PermissionApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePermissionInheritance**](PermissionApi.md#createpermissioninheritance) | **POST** /permission_inheritances | Create a new permission inheritance
[**CreatePermissions**](PermissionApi.md#createpermissions) | **POST** /permissions | Create a new permission
[**DeletePermission**](PermissionApi.md#deletepermission) | **DELETE** /permissions/{id} | Delete a permission
[**DeletePermissionInheritance**](PermissionApi.md#deletepermissioninheritance) | **DELETE** /permission_inheritances/{id} | Delete a permission inheritance
[**GetPermissionById**](PermissionApi.md#getpermissionbyid) | **GET** /permissions/{id} | Get a single permission
[**GetPermissionInheritanceById**](PermissionApi.md#getpermissioninheritancebyid) | **GET** /permission_inheritances/{id} | Get a single permission inheritance
[**GetPermissionInheritances**](PermissionApi.md#getpermissioninheritances) | **GET** /permission_inheritances | Get a range of permission inheritances
[**GetPermissions**](PermissionApi.md#getpermissions) | **GET** /permissions | Get a range of permissions

<a name="createpermissioninheritance"></a>
# **CreatePermissionInheritance**
> PermissionInheritanceResponse CreatePermissionInheritance (PermissionInheritanceRequest body)

Create a new permission inheritance

Create a new permission inheritance, only needed if default permission inheritance should be overwritten.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreatePermissionInheritanceExample
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

            var apiInstance = new PermissionApi();
            var body = new PermissionInheritanceRequest(); // PermissionInheritanceRequest | Permission object that needs to be created.

            try
            {
                // Create a new permission inheritance
                PermissionInheritanceResponse result = apiInstance.CreatePermissionInheritance(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionApi.CreatePermissionInheritance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PermissionInheritanceRequest**](PermissionInheritanceRequest.md)| Permission object that needs to be created. | 

### Return type

[**PermissionInheritanceResponse**](PermissionInheritanceResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createpermissions"></a>
# **CreatePermissions**
> PermissionResponse CreatePermissions (PermissionRequest body)

Create a new permission

Permissions must have a permission_type, assignable and permitable. To create multiple permissions at ones, multiple permission_types can be passed as array. In this case the API will return an array of the created permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreatePermissionsExample
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

            var apiInstance = new PermissionApi();
            var body = new PermissionRequest(); // PermissionRequest | Permission object that needs to be created.

            try
            {
                // Create a new permission
                PermissionResponse result = apiInstance.CreatePermissions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionApi.CreatePermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PermissionRequest**](PermissionRequest.md)| Permission object that needs to be created. | 

### Return type

[**PermissionResponse**](PermissionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepermission"></a>
# **DeletePermission**
> void DeletePermission (long? id)

Delete a permission

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
    public class DeletePermissionExample
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

            var apiInstance = new PermissionApi();
            var id = 789;  // long? | Id of the permission to delete

            try
            {
                // Delete a permission
                apiInstance.DeletePermission(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionApi.DeletePermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the permission to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepermissioninheritance"></a>
# **DeletePermissionInheritance**
> void DeletePermissionInheritance (long? id)

Delete a permission inheritance

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
    public class DeletePermissionInheritanceExample
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

            var apiInstance = new PermissionApi();
            var id = 789;  // long? | Id of the permission inheritance to delete

            try
            {
                // Delete a permission inheritance
                apiInstance.DeletePermissionInheritance(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionApi.DeletePermissionInheritance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the permission inheritance to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpermissionbyid"></a>
# **GetPermissionById**
> PermissionResponse GetPermissionById (long? id, string include = null)

Get a single permission

Get a specific permission identified by the id in the URL.  Possible include values: ```assignable, permitable, technical_connect_users```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPermissionByIdExample
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

            var apiInstance = new PermissionApi();
            var id = 789;  // long? | Id of the permission to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single permission
                PermissionResponse result = apiInstance.GetPermissionById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionApi.GetPermissionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the permission to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**PermissionResponse**](PermissionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpermissioninheritancebyid"></a>
# **GetPermissionInheritanceById**
> PermissionInheritanceResponse GetPermissionInheritanceById (long? id)

Get a single permission inheritance

Get a specific permission inheritance identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPermissionInheritanceByIdExample
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

            var apiInstance = new PermissionApi();
            var id = 789;  // long? | Id of the permission inheritance to fetch

            try
            {
                // Get a single permission inheritance
                PermissionInheritanceResponse result = apiInstance.GetPermissionInheritanceById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionApi.GetPermissionInheritanceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the permission inheritance to fetch | 

### Return type

[**PermissionInheritanceResponse**](PermissionInheritanceResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpermissioninheritances"></a>
# **GetPermissionInheritances**
> PermissionInheritances GetPermissionInheritances (int? page = null, int? perPage = null, string permissionType = null, long? permissionInheritableId = null, string permissionInheritableType = null, string orderBy = null)

Get a range of permission inheritances

Returns a list of all permission inheritances that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPermissionInheritancesExample
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

            var apiInstance = new PermissionApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var permissionType = permissionType_example;  // string | filter by one of the permission_types (`can_read`, `can_update`, `can_delete`, `can_permit`) (optional) 
            var permissionInheritableId = 789;  // long? | filter by id of permitable (optional) 
            var permissionInheritableType = permissionInheritableType_example;  // string | filter by a specific type of permitables eg. `Event` (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of permission inheritances
                PermissionInheritances result = apiInstance.GetPermissionInheritances(page, perPage, permissionType, permissionInheritableId, permissionInheritableType, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionApi.GetPermissionInheritances: " + e.Message );
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
 **permissionType** | **string**| filter by one of the permission_types (&#x60;can_read&#x60;, &#x60;can_update&#x60;, &#x60;can_delete&#x60;, &#x60;can_permit&#x60;) | [optional] 
 **permissionInheritableId** | **long?**| filter by id of permitable | [optional] 
 **permissionInheritableType** | **string**| filter by a specific type of permitables eg. &#x60;Event&#x60; | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**PermissionInheritances**](PermissionInheritances.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpermissions"></a>
# **GetPermissions**
> Permissions GetPermissions (int? page = null, int? perPage = null, string include = null, string permissionType = null, long? assignableId = null, string assignableType = null, long? permitableId = null, string permitableType = null, string orderBy = null)

Get a range of permissions

Returns a list of all permissions that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```assignable, permitable, technical_connect_users```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPermissionsExample
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

            var apiInstance = new PermissionApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var permissionType = permissionType_example;  // string | one or multiple permission_types (comma list). Allowed values are `can_read`, `can_update`, `can_delete` and `can_permit` (optional) 
            var assignableId = 789;  // long? | filter by an assignable id (optional) 
            var assignableType = assignableType_example;  // string | filter by a specific type of assignables eg. `User` or `Usergroup`. (optional) 
            var permitableId = 789;  // long? | filter by a permitable id (optional) 
            var permitableType = permitableType_example;  // string | filter by a specific type of permitables eg. `Asset` or `Node` (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of permissions
                Permissions result = apiInstance.GetPermissions(page, perPage, include, permissionType, assignableId, assignableType, permitableId, permitableType, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionApi.GetPermissions: " + e.Message );
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
 **permissionType** | **string**| one or multiple permission_types (comma list). Allowed values are &#x60;can_read&#x60;, &#x60;can_update&#x60;, &#x60;can_delete&#x60; and &#x60;can_permit&#x60; | [optional] 
 **assignableId** | **long?**| filter by an assignable id | [optional] 
 **assignableType** | **string**| filter by a specific type of assignables eg. &#x60;User&#x60; or &#x60;Usergroup&#x60;. | [optional] 
 **permitableId** | **long?**| filter by a permitable id | [optional] 
 **permitableType** | **string**| filter by a specific type of permitables eg. &#x60;Asset&#x60; or &#x60;Node&#x60; | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**Permissions**](Permissions.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
