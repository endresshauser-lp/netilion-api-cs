# Netilion.Api.Api.UserRoleApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUsersToUserRole**](UserRoleApi.md#adduserstouserrole) | **POST** /userroles/{userrole_id}/users | Add users to a user role
[**CreateUserRole**](UserRoleApi.md#createuserrole) | **POST** /userroles | Create a new user role
[**DeleteUserRole**](UserRoleApi.md#deleteuserrole) | **DELETE** /userroles/{id} | Delete a user role
[**DeleteUsersFromUserRole**](UserRoleApi.md#deleteusersfromuserrole) | **DELETE** /userroles/{userrole_id}/users | Remove users from a user role
[**GetUserRoleById**](UserRoleApi.md#getuserrolebyid) | **GET** /userroles/{id} | Get a single user role
[**GetUserRoles**](UserRoleApi.md#getuserroles) | **GET** /userroles | Get a range of user roles
[**GetUsersOfUserRole**](UserRoleApi.md#getusersofuserrole) | **GET** /userroles/{userrole_id}/users | Get all users of one user role. To work with roles, admin role is required.
[**ReplaceUsersOfUserRole**](UserRoleApi.md#replaceusersofuserrole) | **PATCH** /userroles/{userrole_id}/users | Replace the users of a user role
[**UpdateUserRole**](UserRoleApi.md#updateuserrole) | **PATCH** /userroles/{id} | Update a user role

<a name="adduserstouserrole"></a>
# **AddUsersToUserRole**
> void AddUsersToUserRole (UserIDs body, long? userroleId)

Add users to a user role

Add one or more users to a user role. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddUsersToUserRoleExample
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

            var apiInstance = new UserRoleApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be added.
            var userroleId = 789;  // long? | Id of the user role to which the users will be added

            try
            {
                // Add users to a user role
                apiInstance.AddUsersToUserRole(body, userroleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRoleApi.AddUsersToUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be added. | 
 **userroleId** | **long?**| Id of the user role to which the users will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createuserrole"></a>
# **CreateUserRole**
> UserRoleResponse CreateUserRole (UserRoleRequest body)

Create a new user role

A user role can have many users and users can belong to several roles. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateUserRoleExample
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

            var apiInstance = new UserRoleApi();
            var body = new UserRoleRequest(); // UserRoleRequest | User role to create

            try
            {
                // Create a new user role
                UserRoleResponse result = apiInstance.CreateUserRole(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRoleApi.CreateUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRoleRequest**](UserRoleRequest.md)| User role to create | 

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteuserrole"></a>
# **DeleteUserRole**
> void DeleteUserRole (long? id)

Delete a user role

Delete a specific resource identified by the id in the URL. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteUserRoleExample
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

            var apiInstance = new UserRoleApi();
            var id = 789;  // long? | Id of the user role to delete

            try
            {
                // Delete a user role
                apiInstance.DeleteUserRole(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRoleApi.DeleteUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the user role to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteusersfromuserrole"></a>
# **DeleteUsersFromUserRole**
> void DeleteUsersFromUserRole (UserIDs body, long? userroleId)

Remove users from a user role

Remove one or more users from an user role. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteUsersFromUserRoleExample
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

            var apiInstance = new UserRoleApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be removed.
            var userroleId = 789;  // long? | Id of the user role from which the users will be removed

            try
            {
                // Remove users from a user role
                apiInstance.DeleteUsersFromUserRole(body, userroleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRoleApi.DeleteUsersFromUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be removed. | 
 **userroleId** | **long?**| Id of the user role from which the users will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuserrolebyid"></a>
# **GetUserRoleById**
> UserRoleResponse GetUserRoleById (long? id)

Get a single user role

Get a specific user role identified by the id in the URL. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUserRoleByIdExample
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

            var apiInstance = new UserRoleApi();
            var id = 789;  // long? | Id of the user role to fetch

            try
            {
                // Get a single user role
                UserRoleResponse result = apiInstance.GetUserRoleById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRoleApi.GetUserRoleById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the user role to fetch | 

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuserroles"></a>
# **GetUserRoles**
> UserRolesResponse GetUserRoles (int? page = null, int? perPage = null, string name = null, string tenantId = null, string orderBy = null)

Get a range of user roles

Returns a list of all user roles that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.' To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUserRolesExample
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

            var apiInstance = new UserRoleApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of user roles
                UserRolesResponse result = apiInstance.GetUserRoles(page, perPage, name, tenantId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRoleApi.GetUserRoles: " + e.Message );
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
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**UserRolesResponse**](UserRolesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getusersofuserrole"></a>
# **GetUsersOfUserRole**
> UsersPublicResponse GetUsersOfUserRole (long? userroleId, int? page = null, int? perPage = null, string firstName = null, string lastName = null, string orderBy = null)

Get all users of one user role. To work with roles, admin role is required.

Returns a list of all users that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUsersOfUserRoleExample
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

            var apiInstance = new UserRoleApi();
            var userroleId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var firstName = firstName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var lastName = lastName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `email`, `first_name`, `last_name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all users of one user role. To work with roles, admin role is required.
                UsersPublicResponse result = apiInstance.GetUsersOfUserRole(userroleId, page, perPage, firstName, lastName, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRoleApi.GetUsersOfUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userroleId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **firstName** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **lastName** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;email&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**UsersPublicResponse**](UsersPublicResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceusersofuserrole"></a>
# **ReplaceUsersOfUserRole**
> void ReplaceUsersOfUserRole (UserIDs body, long? userroleId)

Replace the users of a user role

Replaces all users belonging to an user role. You can send a list of resources that will replace all previous values. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceUsersOfUserRoleExample
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

            var apiInstance = new UserRoleApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be replaced
            var userroleId = 789;  // long? | Id of the user role of which the users will be replaced

            try
            {
                // Replace the users of a user role
                apiInstance.ReplaceUsersOfUserRole(body, userroleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRoleApi.ReplaceUsersOfUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be replaced | 
 **userroleId** | **long?**| Id of the user role of which the users will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateuserrole"></a>
# **UpdateUserRole**
> void UpdateUserRole (UserRoleRequest body, long? id)

Update a user role

Update accessible parameters of the requested resource. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateUserRoleExample
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

            var apiInstance = new UserRoleApi();
            var body = new UserRoleRequest(); // UserRoleRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the user role to update

            try
            {
                // Update a user role
                apiInstance.UpdateUserRole(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRoleApi.UpdateUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRoleRequest**](UserRoleRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the user role to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
