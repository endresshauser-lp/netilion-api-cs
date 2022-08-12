# Netilion.Api.Api.UserApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserGroupsToUser**](UserApi.md#addusergroupstouser) | **POST** /users/{user_id}/usergroups | Add user groups to a user
[**AddUserRolesToUser**](UserApi.md#adduserrolestouser) | **POST** /users/{user_id}/userroles | Add user roles to a user
[**CreateCurrentUserDataExport**](UserApi.md#createcurrentuserdataexport) | **POST** /users/current/data_exports | create users data export for current user
[**CreateTechnicalUser**](UserApi.md#createtechnicaluser) | **POST** /technical_users | Create a new technical user
[**DeleteCurrentUserDatasExport**](UserApi.md#deletecurrentuserdatasexport) | **DELETE** /users/current/data_exports/{id} | delete users data export for current user
[**DeleteCurrentUserDemoData**](UserApi.md#deletecurrentuserdemodata) | **DELETE** /users/current/demo_data | Deactivate demo data for user
[**DeleteCurrentUserNotifications**](UserApi.md#deletecurrentusernotifications) | **DELETE** /users/current/notifications/{id} | Delete the given notification for the current user
[**DeleteTechnicalUser**](UserApi.md#deletetechnicaluser) | **DELETE** /technical_users/{id} | Delete a technical user
[**DeleteUser**](UserApi.md#deleteuser) | **DELETE** /users/{id} | Delete a user
[**GetCurrentUser**](UserApi.md#getcurrentuser) | **GET** /users/current | Get current user
[**GetCurrentUserAccessRights**](UserApi.md#getcurrentuseraccessrights) | **GET** /users/current/access_rights | Get current users access rights for a permitable
[**GetCurrentUserDataExportbyId**](UserApi.md#getcurrentuserdataexportbyid) | **GET** /users/current/data_exports/{id} | Get a single user data export
[**GetCurrentUserDataExports**](UserApi.md#getcurrentuserdataexports) | **GET** /users/current/data_exports | Get current users data exports
[**GetCurrentUserDataExportsFile**](UserApi.md#getcurrentuserdataexportsfile) | **GET** /users/current/data_exports/{id}/download | Get current users data export zip file
[**GetCurrentUserDemoData**](UserApi.md#getcurrentuserdemodata) | **GET** /users/current/demo_data | Get information if demo data is available for user
[**GetCurrentUserNotifications**](UserApi.md#getcurrentusernotifications) | **GET** /users/current/notifications | Get relevant notifications for the current authenticated user
[**GetSignInsOfAllUser**](UserApi.md#getsigninsofalluser) | **GET** /sign_ins | Get sign_ins of all users
[**GetSignInsOfUser**](UserApi.md#getsigninsofuser) | **GET** /users/{user_id}/sign_ins | Get sign_ins of a user
[**GetSpecificationsOfUser**](UserApi.md#getspecificationsofuser) | **GET** /users/{user_id}/specifications | Get specifications of a user
[**GetTechnicalUsers**](UserApi.md#gettechnicalusers) | **GET** /technical_users | Get a range of technical users
[**GetUsageOfUser**](UserApi.md#getusageofuser) | **GET** /users/{user_id}/usage | Get the use of storage and the number of assets registred of a user
[**GetUserById**](UserApi.md#getuserbyid) | **GET** /users/{id} | Get a single user
[**GetUserGroupsOfUser**](UserApi.md#getusergroupsofuser) | **GET** /users/{user_id}/usergroups | Get the user groups of one user
[**GetUserRolesOfUser**](UserApi.md#getuserrolesofuser) | **GET** /users/{user_id}/userroles | Get all user roles of one user
[**GetUsers**](UserApi.md#getusers) | **GET** /users | Get a range of users
[**LookupUser**](UserApi.md#lookupuser) | **GET** /users/lookup | Lookup user by email
[**RemoveSpecificationsFromUsers**](UserApi.md#removespecificationsfromusers) | **DELETE** /users/{user_id}/specifications | Delete specifications of a user
[**RemoveUserGroupFromUser**](UserApi.md#removeusergroupfromuser) | **DELETE** /users/{user_id}/usergroups | Remove user groups from a user
[**RemoveUserRolesFromUser**](UserApi.md#removeuserrolesfromuser) | **DELETE** /users/{user_id}/userroles | Remove user roles from a user
[**RenameSpecificationsOfUsers**](UserApi.md#renamespecificationsofusers) | **PATCH** /users/{user_id}/specifications/rename | Rename a specification key
[**ReplaceUserGroupsOfUser**](UserApi.md#replaceusergroupsofuser) | **PATCH** /users/{user_id}/usergroups | Replace the user groups of a user
[**ReplaceUserRolesOfUser**](UserApi.md#replaceuserrolesofuser) | **PATCH** /users/{user_id}/userroles | Replace the user roles of a user
[**ResetPasswordTechnicalUser**](UserApi.md#resetpasswordtechnicaluser) | **POST** /technical_users/{id}/password_reset | create a new password for a technical user
[**SetCurrentUserDemoData**](UserApi.md#setcurrentuserdemodata) | **POST** /users/current/demo_data | Activate demo data for user
[**UpdateSpecificationsOfUsers**](UserApi.md#updatespecificationsofusers) | **PATCH** /users/{user_id}/specifications | Update specifications of a user
[**UpdateUser**](UserApi.md#updateuser) | **PATCH** /users/{id} | Update a user

<a name="addusergroupstouser"></a>
# **AddUserGroupsToUser**
> void AddUserGroupsToUser (UserGroupIDs body, long? userId)

Add user groups to a user

Add one or more user groups to a user identified by id in the url.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddUserGroupsToUserExample
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

            var apiInstance = new UserApi();
            var body = new UserGroupIDs(); // UserGroupIDs | Resources that shall be added.
            var userId = 789;  // long? | Id of the user to whom the user groups will be added

            try
            {
                // Add user groups to a user
                apiInstance.AddUserGroupsToUser(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.AddUserGroupsToUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserGroupIDs**](UserGroupIDs.md)| Resources that shall be added. | 
 **userId** | **long?**| Id of the user to whom the user groups will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adduserrolestouser"></a>
# **AddUserRolesToUser**
> void AddUserRolesToUser (UserRoleIDs body, long? userId)

Add user roles to a user

Add one or more user roles to a user. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddUserRolesToUserExample
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

            var apiInstance = new UserApi();
            var body = new UserRoleIDs(); // UserRoleIDs | Resources that shall be added.
            var userId = 789;  // long? | Id of the user to which the user roles will be added

            try
            {
                // Add user roles to a user
                apiInstance.AddUserRolesToUser(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.AddUserRolesToUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRoleIDs**](UserRoleIDs.md)| Resources that shall be added. | 
 **userId** | **long?**| Id of the user to which the user roles will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createcurrentuserdataexport"></a>
# **CreateCurrentUserDataExport**
> DataExportResponse CreateCurrentUserDataExport (DataExportRequest body)

create users data export for current user

create the data export of the authenticated user in the current context.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateCurrentUserDataExportExample
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

            var apiInstance = new UserApi();
            var body = new DataExportRequest(); // DataExportRequest | Resources that shall be added.

            try
            {
                // create users data export for current user
                DataExportResponse result = apiInstance.CreateCurrentUserDataExport(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateCurrentUserDataExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DataExportRequest**](DataExportRequest.md)| Resources that shall be added. | 

### Return type

[**DataExportResponse**](DataExportResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createtechnicaluser"></a>
# **CreateTechnicalUser**
> TechnicalUserCreateResponse CreateTechnicalUser (TechnicalUserRequest body)

Create a new technical user

Creates a new technical user. Password is automatically generated an can not be defined. The generated password is part of the response (but cannot be later received again) Technical users must not be confirmed via eMail link. 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateTechnicalUserExample
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

            var apiInstance = new UserApi();
            var body = new TechnicalUserRequest(); // TechnicalUserRequest | Technical User object that needs to be registered

            try
            {
                // Create a new technical user
                TechnicalUserCreateResponse result = apiInstance.CreateTechnicalUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateTechnicalUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TechnicalUserRequest**](TechnicalUserRequest.md)| Technical User object that needs to be registered | 

### Return type

[**TechnicalUserCreateResponse**](TechnicalUserCreateResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecurrentuserdatasexport"></a>
# **DeleteCurrentUserDatasExport**
> void DeleteCurrentUserDatasExport (long? id)

delete users data export for current user

delete the data export of the authenticated user in the current context.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteCurrentUserDatasExportExample
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

            var apiInstance = new UserApi();
            var id = 789;  // long? | Id of the data_export to delete

            try
            {
                // delete users data export for current user
                apiInstance.DeleteCurrentUserDatasExport(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteCurrentUserDatasExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the data_export to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecurrentuserdemodata"></a>
# **DeleteCurrentUserDemoData**
> void DeleteCurrentUserDemoData ()

Deactivate demo data for user

remove access rights to the demo data of the netilion services for the user, no parameters are required

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteCurrentUserDemoDataExample
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

            var apiInstance = new UserApi();

            try
            {
                // Deactivate demo data for user
                apiInstance.DeleteCurrentUserDemoData();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteCurrentUserDemoData: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecurrentusernotifications"></a>
# **DeleteCurrentUserNotifications**
> void DeleteCurrentUserNotifications (long? id)

Delete the given notification for the current user

Delete the given notification for the currently authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteCurrentUserNotificationsExample
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

            var apiInstance = new UserApi();
            var id = 789;  // long? | Id of the notification to delete

            try
            {
                // Delete the given notification for the current user
                apiInstance.DeleteCurrentUserNotifications(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteCurrentUserNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the notification to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetechnicaluser"></a>
# **DeleteTechnicalUser**
> void DeleteTechnicalUser (long? id)

Delete a technical user

Delete a technical user identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteTechnicalUserExample
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

            var apiInstance = new UserApi();
            var id = 789;  // long? | Id of the technical user to delete

            try
            {
                // Delete a technical user
                apiInstance.DeleteTechnicalUser(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteTechnicalUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the technical user to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (long? id)

Delete a user

Delete a specific resource in your permission scope identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteUserExample
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

            var apiInstance = new UserApi();
            var id = 789;  // long? | Id of the user to delete

            try
            {
                // Delete a user
                apiInstance.DeleteUser(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the user to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentuser"></a>
# **GetCurrentUser**
> CurrentUserResponse GetCurrentUser (string include = null)

Get current user

Get the user authenticated in the current context. Possible include values: ```userroles, usergroups, usage, demo_data, specifications, specifications[key1,key2]```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCurrentUserExample
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

            var apiInstance = new UserApi();
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get current user
                CurrentUserResponse result = apiInstance.GetCurrentUser(include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetCurrentUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**CurrentUserResponse**](CurrentUserResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentuseraccessrights"></a>
# **GetCurrentUserAccessRights**
> AccessRightsResponse GetCurrentUserAccessRights (long? permitableId, string permitableType)

Get current users access rights for a permitable

Get the access rights for a permitable of the authenticated user in the current context.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCurrentUserAccessRightsExample
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

            var apiInstance = new UserApi();
            var permitableId = 789;  // long? | id of the permitable.
            var permitableType = permitableType_example;  // string | permitable type eg. Asset, Node, EDM::EdgeDevice.

            try
            {
                // Get current users access rights for a permitable
                AccessRightsResponse result = apiInstance.GetCurrentUserAccessRights(permitableId, permitableType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetCurrentUserAccessRights: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **permitableId** | **long?**| id of the permitable. | 
 **permitableType** | **string**| permitable type eg. Asset, Node, EDM::EdgeDevice. | 

### Return type

[**AccessRightsResponse**](AccessRightsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentuserdataexportbyid"></a>
# **GetCurrentUserDataExportbyId**
> DataExportResponse GetCurrentUserDataExportbyId (long? id)

Get a single user data export

Get the data exports of the authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCurrentUserDataExportbyIdExample
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

            var apiInstance = new UserApi();
            var id = 789;  // long? | Id of the data_export to fetch

            try
            {
                // Get a single user data export
                DataExportResponse result = apiInstance.GetCurrentUserDataExportbyId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetCurrentUserDataExportbyId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the data_export to fetch | 

### Return type

[**DataExportResponse**](DataExportResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentuserdataexports"></a>
# **GetCurrentUserDataExports**
> DataExportsResponse GetCurrentUserDataExports (string type = null, long? instrumentationId = null, long? assetId = null, long? systemId = null, long? batchId = null, string language = null)

Get current users data exports

Get the data exports of the authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCurrentUserDataExportsExample
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

            var apiInstance = new UserApi();
            var type = type_example;  // string | type of data export, can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container. (optional) 
            var instrumentationId = 789;  // long? | ID of the instrumentation to export data from. (optional) 
            var assetId = 789;  // long? | ID of the asset to export data from. (optional) 
            var systemId = 789;  // long? | ID of the system to export data from. (optional) 
            var batchId = 789;  // long? | ID of the batch to export data from. (optional) 
            var language = language_example;  // string | filter for requested export language (optional) 

            try
            {
                // Get current users data exports
                DataExportsResponse result = apiInstance.GetCurrentUserDataExports(type, instrumentationId, assetId, systemId, batchId, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetCurrentUserDataExports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| type of data export, can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container. | [optional] 
 **instrumentationId** | **long?**| ID of the instrumentation to export data from. | [optional] 
 **assetId** | **long?**| ID of the asset to export data from. | [optional] 
 **systemId** | **long?**| ID of the system to export data from. | [optional] 
 **batchId** | **long?**| ID of the batch to export data from. | [optional] 
 **language** | **string**| filter for requested export language | [optional] 

### Return type

[**DataExportsResponse**](DataExportsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentuserdataexportsfile"></a>
# **GetCurrentUserDataExportsFile**
> void GetCurrentUserDataExportsFile (long? id)

Get current users data export zip file

Get the data export file of the authenticated user in the current context. Content-Transfer-Encoding header is set to binary.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCurrentUserDataExportsFileExample
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

            var apiInstance = new UserApi();
            var id = 789;  // long? | Id of the data_export to download

            try
            {
                // Get current users data export zip file
                apiInstance.GetCurrentUserDataExportsFile(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetCurrentUserDataExportsFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the data_export to download | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentuserdemodata"></a>
# **GetCurrentUserDemoData**
> CurrentUserDemoDataResponse GetCurrentUserDemoData ()

Get information if demo data is available for user

Get information if the user has activated the demo data of the netilion services

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCurrentUserDemoDataExample
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

            var apiInstance = new UserApi();

            try
            {
                // Get information if demo data is available for user
                CurrentUserDemoDataResponse result = apiInstance.GetCurrentUserDemoData();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetCurrentUserDemoData: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrentUserDemoDataResponse**](CurrentUserDemoDataResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentusernotifications"></a>
# **GetCurrentUserNotifications**
> Notifications GetCurrentUserNotifications (int? page = null, int? perPage = null, string startDatetime = null, string startDatetimeFrom = null, string startDatetimeTo = null, string endDatetime = null, DateTime? endDatetimeFrom = null, string endDatetimeTo = null, string orderBy = null, string acceptLanguage = null)

Get relevant notifications for the current authenticated user

Returns a list of all notifications available for the authenticated user on the current client application. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```content```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCurrentUserNotificationsExample
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

            var apiInstance = new UserApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var startDatetime = startDatetime_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var startDatetimeFrom = startDatetimeFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var startDatetimeTo = startDatetimeTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var endDatetime = endDatetime_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var endDatetimeFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var endDatetimeTo = endDatetimeTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get relevant notifications for the current authenticated user
                Notifications result = apiInstance.GetCurrentUserNotifications(page, perPage, startDatetime, startDatetimeFrom, startDatetimeTo, endDatetime, endDatetimeFrom, endDatetimeTo, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetCurrentUserNotifications: " + e.Message );
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
 **startDatetime** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **startDatetimeFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **startDatetimeTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **endDatetime** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **endDatetimeFrom** | **DateTime?**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **endDatetimeTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**Notifications**](Notifications.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsigninsofalluser"></a>
# **GetSignInsOfAllUser**
> SignInsResponse GetSignInsOfAllUser (int? page = null, int? perPage = null, DateTime? time = null, string timeFrom = null, string timeTo = null)

Get sign_ins of all users

Returns a list of all sign ins of all users. This needs special roles, otherwise only sign_ins of current user are returned

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSignInsOfAllUserExample
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

            var apiInstance = new UserApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var time = 2013-10-20;  // DateTime? | Expected format is YYYY-MM-DD (optional) 
            var timeFrom = timeFrom_example;  // string | Expected format is YYYY-MM-DDThh:mm:ss (optional) 
            var timeTo = timeTo_example;  // string | Expected format is YYYY-MM-DDThh:mm:ss (optional) 

            try
            {
                // Get sign_ins of all users
                SignInsResponse result = apiInstance.GetSignInsOfAllUser(page, perPage, time, timeFrom, timeTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetSignInsOfAllUser: " + e.Message );
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
 **time** | **DateTime?**| Expected format is YYYY-MM-DD | [optional] 
 **timeFrom** | **string**| Expected format is YYYY-MM-DDThh:mm:ss | [optional] 
 **timeTo** | **string**| Expected format is YYYY-MM-DDThh:mm:ss | [optional] 

### Return type

[**SignInsResponse**](SignInsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsigninsofuser"></a>
# **GetSignInsOfUser**
> SignInsResponse GetSignInsOfUser (long? userId, int? page = null, int? perPage = null, DateTime? time = null, string timeFrom = null, string timeTo = null)

Get sign_ins of a user

Returns a list of all sign ins of a specific user identified by id in the url. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.'

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSignInsOfUserExample
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

            var apiInstance = new UserApi();
            var userId = 789;  // long? | Id of the user to fetch
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var time = 2013-10-20;  // DateTime? | Expected format is YYYY-MM-DD (optional) 
            var timeFrom = timeFrom_example;  // string | Expected format is YYYY-MM-DDThh:mm:ss (optional) 
            var timeTo = timeTo_example;  // string | Expected format is YYYY-MM-DDThh:mm:ss (optional) 

            try
            {
                // Get sign_ins of a user
                SignInsResponse result = apiInstance.GetSignInsOfUser(userId, page, perPage, time, timeFrom, timeTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetSignInsOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| Id of the user to fetch | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **time** | **DateTime?**| Expected format is YYYY-MM-DD | [optional] 
 **timeFrom** | **string**| Expected format is YYYY-MM-DDThh:mm:ss | [optional] 
 **timeTo** | **string**| Expected format is YYYY-MM-DDThh:mm:ss | [optional] 

### Return type

[**SignInsResponse**](SignInsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofuser"></a>
# **GetSpecificationsOfUser**
> SpecificationsResponse GetSpecificationsOfUser (long? userId, string key = null)

Get specifications of a user

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfUserExample
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

            var apiInstance = new UserApi();
            var userId = 789;  // long? | Id of the specified user
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of a user
                SpecificationsResponse result = apiInstance.GetSpecificationsOfUser(userId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetSpecificationsOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| Id of the specified user | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettechnicalusers"></a>
# **GetTechnicalUsers**
> TechnicalUsersResponse GetTechnicalUsers (int? page = null, int? perPage = null, string include = null, string email = null, string orderBy = null)

Get a range of technical users

Returns a list of technical users. If the query has no matches, the response is an empty list. Possible include values: ```userroles, usergroups```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetTechnicalUsersExample
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

            var apiInstance = new UserApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var email = email_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `email`, `first_name`, `last_name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of technical users
                TechnicalUsersResponse result = apiInstance.GetTechnicalUsers(page, perPage, include, email, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetTechnicalUsers: " + e.Message );
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
 **email** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;email&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**TechnicalUsersResponse**](TechnicalUsersResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getusageofuser"></a>
# **GetUsageOfUser**
> UsageResponse GetUsageOfUser (long? userId)

Get the use of storage and the number of assets registred of a user

Returns the storage and number of assets of a specific user identified by id in the url.'

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUsageOfUserExample
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

            var apiInstance = new UserApi();
            var userId = 789;  // long? | Id of the user to fetch

            try
            {
                // Get the use of storage and the number of assets registred of a user
                UsageResponse result = apiInstance.GetUsageOfUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUsageOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| Id of the user to fetch | 

### Return type

[**UsageResponse**](UsageResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuserbyid"></a>
# **GetUserById**
> UserResponse GetUserById (long? id, string include = null)

Get a single user

Get a specific user in your permission scope, identified by the id in the URL. Possible include values: ```userroles, usergroups, specifications, specifications[key1,key2]```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUserByIdExample
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

            var apiInstance = new UserApi();
            var id = 789;  // long? | Id of the user to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single user
                UserResponse result = apiInstance.GetUserById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the user to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getusergroupsofuser"></a>
# **GetUserGroupsOfUser**
> UserGroupsWithUsers GetUserGroupsOfUser (long? userId, int? page = null, int? perPage = null, string name = null, string orderBy = null)

Get the user groups of one user

Returns a list of all usergroups of a specific user identified by id in the url. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.'

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUserGroupsOfUserExample
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

            var apiInstance = new UserApi();
            var userId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get the user groups of one user
                UserGroupsWithUsers result = apiInstance.GetUserGroupsOfUser(userId, page, perPage, name, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserGroupsOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| The resource defined in the URL | 
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
<a name="getuserrolesofuser"></a>
# **GetUserRolesOfUser**
> UserRolesResponse GetUserRolesOfUser (long? userId, int? page = null, int? perPage = null, string name = null, string orderBy = null)

Get all user roles of one user

Returns a list of all user roles that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUserRolesOfUserExample
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

            var apiInstance = new UserApi();
            var userId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all user roles of one user
                UserRolesResponse result = apiInstance.GetUserRolesOfUser(userId, page, perPage, name, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserRolesOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**UserRolesResponse**](UserRolesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getusers"></a>
# **GetUsers**
> UsersResponse GetUsers (int? page = null, int? perPage = null, string include = null, string email = null, string firstName = null, string lastName = null, string specificationsKey = null, string specificationsValue = null, DateTime? createdAt = null, string createdAtFrom = null, string createdAtTo = null, DateTime? updatedAt = null, string updatedAtFrom = null, string updatedAtTo = null, string orderBy = null)

Get a range of users

Returns a list of users in your permission scope. If the query has no matches, the response is an empty list. Possible include values: ```userroles, usergroups, specifications, specifications[key1,key2]```. Specification filters and includes are only available for admin users

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetUsersExample
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

            var apiInstance = new UserApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var email = email_example;  // string | Filter accepts `*` as wildcard (optional) 
            var firstName = firstName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var lastName = lastName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var createdAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var createdAtTo = createdAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var updatedAtFrom = updatedAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = updatedAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `email`, `first_name`, `last_name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of users
                UsersResponse result = apiInstance.GetUsers(page, perPage, include, email, firstName, lastName, specificationsKey, specificationsValue, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUsers: " + e.Message );
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
 **email** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **firstName** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **lastName** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **createdAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **createdAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **createdAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **updatedAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;email&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**UsersResponse**](UsersResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="lookupuser"></a>
# **LookupUser**
> UserPublicResponse LookupUser (string email)

Lookup user by email

Get a user for a given email adress.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class LookupUserExample
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

            var apiInstance = new UserApi();
            var email = email_example;  // string | email of the user to lookup.

            try
            {
                // Lookup user by email
                UserPublicResponse result = apiInstance.LookupUser(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.LookupUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| email of the user to lookup. | 

### Return type

[**UserPublicResponse**](UserPublicResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromusers"></a>
# **RemoveSpecificationsFromUsers**
> void RemoveSpecificationsFromUsers (List<string> body, long? userId)

Delete specifications of a user

The specification keys in the body will be removed of the object in your accessible scope. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromUsersExample
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

            var apiInstance = new UserApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var userId = 789;  // long? | Id of the specified user

            try
            {
                // Delete specifications of a user
                apiInstance.RemoveSpecificationsFromUsers(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.RemoveSpecificationsFromUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **userId** | **long?**| Id of the specified user | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeusergroupfromuser"></a>
# **RemoveUserGroupFromUser**
> void RemoveUserGroupFromUser (UserGroupIDs body, long? userId)

Remove user groups from a user

Remove one or more user groups from a user identified by id in the url.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveUserGroupFromUserExample
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

            var apiInstance = new UserApi();
            var body = new UserGroupIDs(); // UserGroupIDs | Resources that shall be removed.
            var userId = 789;  // long? | Id of the user from which the user groups will be removed

            try
            {
                // Remove user groups from a user
                apiInstance.RemoveUserGroupFromUser(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.RemoveUserGroupFromUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserGroupIDs**](UserGroupIDs.md)| Resources that shall be removed. | 
 **userId** | **long?**| Id of the user from which the user groups will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeuserrolesfromuser"></a>
# **RemoveUserRolesFromUser**
> void RemoveUserRolesFromUser (UserRoleIDs body, long? userId)

Remove user roles from a user

Remove one or more user roles from a user. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveUserRolesFromUserExample
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

            var apiInstance = new UserApi();
            var body = new UserRoleIDs(); // UserRoleIDs | Resources that shall be removed.
            var userId = 789;  // long? | Id of the user from which the user roles will be removed

            try
            {
                // Remove user roles from a user
                apiInstance.RemoveUserRolesFromUser(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.RemoveUserRolesFromUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRoleIDs**](UserRoleIDs.md)| Resources that shall be removed. | 
 **userId** | **long?**| Id of the user from which the user roles will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofusers"></a>
# **RenameSpecificationsOfUsers**
> void RenameSpecificationsOfUsers (SpecificationsRename body, long? userId)

Rename a specification key

Rename one specification key of a user in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfUsersExample
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

            var apiInstance = new UserApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var userId = 789;  // long? | Id of the specified user

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfUsers(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.RenameSpecificationsOfUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **userId** | **long?**| Id of the specified user | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceusergroupsofuser"></a>
# **ReplaceUserGroupsOfUser**
> void ReplaceUserGroupsOfUser (UserGroupIDs body, long? userId)

Replace the user groups of a user

Replaces all user groups belonging to a user. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceUserGroupsOfUserExample
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

            var apiInstance = new UserApi();
            var body = new UserGroupIDs(); // UserGroupIDs | Resources that shall be replaced.
            var userId = 789;  // long? | Id of the user of which the user groups will be replaced

            try
            {
                // Replace the user groups of a user
                apiInstance.ReplaceUserGroupsOfUser(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ReplaceUserGroupsOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserGroupIDs**](UserGroupIDs.md)| Resources that shall be replaced. | 
 **userId** | **long?**| Id of the user of which the user groups will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceuserrolesofuser"></a>
# **ReplaceUserRolesOfUser**
> void ReplaceUserRolesOfUser (UserRoleIDs body, long? userId)

Replace the user roles of a user

Replaces all user roles belonging to a user. You can send a list of resources that will replace all previous values. To work with roles, admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceUserRolesOfUserExample
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

            var apiInstance = new UserApi();
            var body = new UserRoleIDs(); // UserRoleIDs | Resources that shall be replaced
            var userId = 789;  // long? | Id of the user of which the user roles will be replaced

            try
            {
                // Replace the user roles of a user
                apiInstance.ReplaceUserRolesOfUser(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ReplaceUserRolesOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRoleIDs**](UserRoleIDs.md)| Resources that shall be replaced | 
 **userId** | **long?**| Id of the user of which the user roles will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="resetpasswordtechnicaluser"></a>
# **ResetPasswordTechnicalUser**
> TechnicalUserPasswordResponse ResetPasswordTechnicalUser (long? id)

create a new password for a technical user

 Password is automatically generated an can not be defined. The generated password is part of the response (but cannot be later received again). 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ResetPasswordTechnicalUserExample
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

            var apiInstance = new UserApi();
            var id = 789;  // long? | Id of the technical user

            try
            {
                // create a new password for a technical user
                TechnicalUserPasswordResponse result = apiInstance.ResetPasswordTechnicalUser(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ResetPasswordTechnicalUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the technical user | 

### Return type

[**TechnicalUserPasswordResponse**](TechnicalUserPasswordResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setcurrentuserdemodata"></a>
# **SetCurrentUserDemoData**
> void SetCurrentUserDemoData ()

Activate demo data for user

give user access to the demo data of the netilion services, no body parameters are required

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class SetCurrentUserDemoDataExample
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

            var apiInstance = new UserApi();

            try
            {
                // Activate demo data for user
                apiInstance.SetCurrentUserDemoData();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.SetCurrentUserDemoData: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofusers"></a>
# **UpdateSpecificationsOfUsers**
> void UpdateSpecificationsOfUsers (Dictionary<string, SpecificationRequest> body, long? userId)

Update specifications of a user

Update the specification object of a user in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfUsersExample
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

            var apiInstance = new UserApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var userId = 789;  // long? | Id of the specified user

            try
            {
                // Update specifications of a user
                apiInstance.UpdateSpecificationsOfUsers(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateSpecificationsOfUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **userId** | **long?**| Id of the specified user | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateuser"></a>
# **UpdateUser**
> void UpdateUser (UserChangeRequest body, long? id)

Update a user

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
    public class UpdateUserExample
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

            var apiInstance = new UserApi();
            var body = new UserChangeRequest(); // UserChangeRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the user to update

            try
            {
                // Update a user
                apiInstance.UpdateUser(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserChangeRequest**](UserChangeRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the user to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
