# Netilion.Api.Api.UserGroupApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUsersToUserGroup**](UserGroupApi.md#adduserstousergroup) | **POST** /usergroups/{usergroup_id}/users | Add users to a user group
[**CreateUserGroup**](UserGroupApi.md#createusergroup) | **POST** /usergroups | Create a new user group
[**DeleteUserGroup**](UserGroupApi.md#deleteusergroup) | **DELETE** /usergroups/{id} | Delete a user group
[**GetUserGroupById**](UserGroupApi.md#getusergroupbyid) | **GET** /usergroups/{id} | Get a single user group
[**GetUserGroups**](UserGroupApi.md#getusergroups) | **GET** /usergroups | Get a range of user groups
[**GetUsersOfUserGroup**](UserGroupApi.md#getusersofusergroup) | **GET** /usergroups/{usergroup_id}/users | Get the users of a user group
[**RemoveUsersFromUserGroup**](UserGroupApi.md#removeusersfromusergroup) | **DELETE** /usergroups/{usergroup_id}/users | Remove users from a user group
[**ReplaceUsersOfUserGroup**](UserGroupApi.md#replaceusersofusergroup) | **PATCH** /usergroups/{usergroup_id}/users | Replace the users of a user group
[**UpdateUserGroup**](UserGroupApi.md#updateusergroup) | **PATCH** /usergroups/{id} | Update a user group

<a name="adduserstousergroup"></a>
# **AddUsersToUserGroup**
> void AddUsersToUserGroup (UserIDs body, long? usergroupId)

Add users to a user group

Add one or more users to a user group.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddUsersToUserGroupExample
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

            var apiInstance = new UserGroupApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be added.
            var usergroupId = 789;  // long? | Id of the user group to which the users will be added

            try
            {
                // Add users to a user group
                apiInstance.AddUsersToUserGroup(body, usergroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.AddUsersToUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be added. | 
 **usergroupId** | **long?**| Id of the user group to which the users will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createusergroup"></a>
# **CreateUserGroup**
> UserGroupResponse CreateUserGroup (UserGroupRequest body)

Create a new user group

A user group can have many users and users can belong to several groups.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateUserGroupExample
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

            var apiInstance = new UserGroupApi();
            var body = new UserGroupRequest(); // UserGroupRequest | User group to create

            try
            {
                // Create a new user group
                UserGroupResponse result = apiInstance.CreateUserGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.CreateUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserGroupRequest**](UserGroupRequest.md)| User group to create | 

### Return type

[**UserGroupResponse**](UserGroupResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteusergroup"></a>
# **DeleteUserGroup**
> void DeleteUserGroup (long? id)

Delete a user group

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
    public class DeleteUserGroupExample
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

            var apiInstance = new UserGroupApi();
            var id = 789;  // long? | Id of the user group to delete

            try
            {
                // Delete a user group
                apiInstance.DeleteUserGroup(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.DeleteUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the user group to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getusergroupbyid"></a>
# **GetUserGroupById**
> UserGroupResponse GetUserGroupById (long? id)

Get a single user group

Get a specific user group identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUserGroupByIdExample
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

            var apiInstance = new UserGroupApi();
            var id = 789;  // long? | Id of the user group to fetch

            try
            {
                // Get a single user group
                UserGroupResponse result = apiInstance.GetUserGroupById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.GetUserGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the user group to fetch | 

### Return type

[**UserGroupResponse**](UserGroupResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getusergroups"></a>
# **GetUserGroups**
> UserGroupsWithUsers GetUserGroups (int? page = null, int? perPage = null, string name = null, string orderBy = null)

Get a range of user groups

Returns a list of all user group that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.'

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUserGroupsExample
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

            var apiInstance = new UserGroupApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of user groups
                UserGroupsWithUsers result = apiInstance.GetUserGroups(page, perPage, name, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.GetUserGroups: " + e.Message );
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
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**UserGroupsWithUsers**](UserGroupsWithUsers.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getusersofusergroup"></a>
# **GetUsersOfUserGroup**
> UsersPublicResponse GetUsersOfUserGroup (long? usergroupId, int? page = null, int? perPage = null, string firstName = null, string lastName = null, string orderBy = null)

Get the users of a user group

Returns a list of all users of a specific user group identified by id in the url. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUsersOfUserGroupExample
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

            var apiInstance = new UserGroupApi();
            var usergroupId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var firstName = firstName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var lastName = lastName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `email`, `first_name`, `last_name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get the users of a user group
                UsersPublicResponse result = apiInstance.GetUsersOfUserGroup(usergroupId, page, perPage, firstName, lastName, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.GetUsersOfUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usergroupId** | **long?**| The resource defined in the URL | 
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
<a name="removeusersfromusergroup"></a>
# **RemoveUsersFromUserGroup**
> void RemoveUsersFromUserGroup (UserIDs body, long? usergroupId)

Remove users from a user group

Remove one or more users from a user group.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveUsersFromUserGroupExample
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

            var apiInstance = new UserGroupApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be removed.
            var usergroupId = 789;  // long? | Id of the user group from which the users will be removed

            try
            {
                // Remove users from a user group
                apiInstance.RemoveUsersFromUserGroup(body, usergroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.RemoveUsersFromUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be removed. | 
 **usergroupId** | **long?**| Id of the user group from which the users will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceusersofusergroup"></a>
# **ReplaceUsersOfUserGroup**
> void ReplaceUsersOfUserGroup (UserIDs body, long? usergroupId)

Replace the users of a user group

Replaces all users belonging to a user group. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceUsersOfUserGroupExample
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

            var apiInstance = new UserGroupApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be replaced
            var usergroupId = 789;  // long? | Id of the user group of which the users will be replaced

            try
            {
                // Replace the users of a user group
                apiInstance.ReplaceUsersOfUserGroup(body, usergroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.ReplaceUsersOfUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be replaced | 
 **usergroupId** | **long?**| Id of the user group of which the users will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateusergroup"></a>
# **UpdateUserGroup**
> void UpdateUserGroup (UserGroupRequest body, long? id)

Update a user group

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
    public class UpdateUserGroupExample
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

            var apiInstance = new UserGroupApi();
            var body = new UserGroupRequest(); // UserGroupRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the user group to update

            try
            {
                // Update a user group
                apiInstance.UpdateUserGroup(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserGroupApi.UpdateUserGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserGroupRequest**](UserGroupRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the user group to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
