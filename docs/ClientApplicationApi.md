# Netilion.Api.Api.ClientApplicationApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddClientApplicationsToEdgeApplication**](ClientApplicationApi.md#addclientapplicationstoedgeapplication) | **POST** /edge_device/applications/{edge_device_application_id}/client_applications | Add client applications to an edge device application
[**AddTechnicalUsersToClientApplication**](ClientApplicationApi.md#addtechnicaluserstoclientapplication) | **POST** /client_applications/{client_application_id}/technical_users | Add Technical Users of Client Application
[**AddUsersToClientApplicationUserRole**](ClientApplicationApi.md#adduserstoclientapplicationuserrole) | **POST** /client_applications/{client_application_id}/roles/{userrole_id}/users | Add users to a client application user role
[**CreateClientApplication**](ClientApplicationApi.md#createclientapplication) | **POST** /client_applications | Create a new client_application
[**CreateWebhookToClientApplication**](ClientApplicationApi.md#createwebhooktoclientapplication) | **POST** /client_applications/{client_application_id}/webhooks | Create a new webhook for the Client Application
[**DeleteClientApplication**](ClientApplicationApi.md#deleteclientapplication) | **DELETE** /client_applications/{id} | Delete an client_application
[**DeleteUsersFromClientApplicationUserRole**](ClientApplicationApi.md#deleteusersfromclientapplicationuserrole) | **DELETE** /client_applications/{client_application_id}/roles/{userrole_id}/users | Remove users from a client application user role
[**DeleteWebhook**](ClientApplicationApi.md#deletewebhook) | **DELETE** /client_applications/{client_application_id}/webhooks/{id} | Delete a webhook
[**GetAPIKeysOfClientApplication**](ClientApplicationApi.md#getapikeysofclientapplication) | **GET** /client_applications/{client_application_id}/api_keys | GetAPI Keys of Client Application
[**GetClientApplicationById**](ClientApplicationApi.md#getclientapplicationbyid) | **GET** /client_applications/{id} | Get a single client_application
[**GetClientApplications**](ClientApplicationApi.md#getclientapplications) | **GET** /client_applications | Get a range of client_applications
[**GetClientApplicationsOfEdgeDeviceApplication**](ClientApplicationApi.md#getclientapplicationsofedgedeviceapplication) | **GET** /edge_device/applications/{edge_device_application_id}/client_applications | Get all client applications of one edge device application
[**GetCurrentClientApplication**](ClientApplicationApi.md#getcurrentclientapplication) | **GET** /client_applications/current | Get current client_application
[**GetEdgeDeviceApplicationsOfClientApplication**](ClientApplicationApi.md#getedgedeviceapplicationsofclientapplication) | **GET** /client_applications/{client_application_id}/edge_device/applications | Get all edge devices applications for an client application
[**GetTechnicalUsersOfClientApplication**](ClientApplicationApi.md#gettechnicalusersofclientapplication) | **GET** /client_applications/{client_application_id}/technical_users | Get Technical Users of Client Application
[**GetUsersOfClientApplicationUserRole**](ClientApplicationApi.md#getusersofclientapplicationuserrole) | **GET** /client_applications/{client_application_id}/roles/{userrole_id}/users | Get all users of a user role assigned to a client application
[**GetWebhookById**](ClientApplicationApi.md#getwebhookbyid) | **GET** /client_applications/{client_application_id}/webhooks/{id} | Get a single webhook
[**GetWebhookEvents**](ClientApplicationApi.md#getwebhookevents) | **GET** /client_applications/{client_application_id}/webhooks/{id}/events | Get events of a webhook
[**GetWebhooksOfClientApplication**](ClientApplicationApi.md#getwebhooksofclientapplication) | **GET** /client_applications/{client_application_id}/webhooks | Get webhooks of Client Application
[**RemoveClientApplicationsOfEdgeDeviceApplication**](ClientApplicationApi.md#removeclientapplicationsofedgedeviceapplication) | **DELETE** /edge_device/applications/{edge_device_application_id}/client_applications | Remove client applications from an edge device application
[**ReplaceClientApplicationsOfEdgeDeviceApplication**](ClientApplicationApi.md#replaceclientapplicationsofedgedeviceapplication) | **PATCH** /edge_device/applications/{edge_device_application_id}/client_applications | Replace the client applications of an edge device application
[**ResendWebhookEvents**](ClientApplicationApi.md#resendwebhookevents) | **POST** /client_applications/{client_application_id}/webhooks/{id}/events | resend Webhook Events
[**ResetSecretWebhook**](ClientApplicationApi.md#resetsecretwebhook) | **POST** /client_applications/{client_application_id}/webhooks/{id}/reset_secret | Reset the secret property of the webhook
[**UpdateClientApplication**](ClientApplicationApi.md#updateclientapplication) | **PATCH** /client_applications/{id} | Update an client_application
[**UpdateWebhook**](ClientApplicationApi.md#updatewebhook) | **PATCH** /client_applications/{client_application_id}/webhooks/{id} | Update a webhook

<a name="addclientapplicationstoedgeapplication"></a>
# **AddClientApplicationsToEdgeApplication**
> void AddClientApplicationsToEdgeApplication (ClientApplicationIDs body, long? edgeDeviceApplicationId)

Add client applications to an edge device application

Add one or more client applications to an edge device application. This action requires the edge device admin role.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddClientApplicationsToEdgeApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new ClientApplicationIDs(); // ClientApplicationIDs | Resources that shall be added.
            var edgeDeviceApplicationId = 789;  // long? | Id of the edge device application to which the client applications will be added

            try
            {
                // Add client applications to an edge device application
                apiInstance.AddClientApplicationsToEdgeApplication(body, edgeDeviceApplicationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.AddClientApplicationsToEdgeApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClientApplicationIDs**](ClientApplicationIDs.md)| Resources that shall be added. | 
 **edgeDeviceApplicationId** | **long?**| Id of the edge device application to which the client applications will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addtechnicaluserstoclientapplication"></a>
# **AddTechnicalUsersToClientApplication**
> TechnicalUserCreateResponse AddTechnicalUsersToClientApplication (long? clientApplicationId)

Add Technical Users of Client Application

Creates a new technical user for a client application. Email (username) and password is automatically generated and can not be defined. The generated username and password are part of the response (password can not be later received again but can be changed via password_reset endpoint of technical user). 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddTechnicalUsersToClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | The resource defined in the URL

            try
            {
                // Add Technical Users of Client Application
                TechnicalUserCreateResponse result = apiInstance.AddTechnicalUsersToClientApplication(clientApplicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.AddTechnicalUsersToClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| The resource defined in the URL | 

### Return type

[**TechnicalUserCreateResponse**](TechnicalUserCreateResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adduserstoclientapplicationuserrole"></a>
# **AddUsersToClientApplicationUserRole**
> void AddUsersToClientApplicationUserRole (UserIDs body, long? clientApplicationId, long? userroleId)

Add users to a client application user role

Add one or more users to a user role.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddUsersToClientApplicationUserRoleExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be added.
            var clientApplicationId = 789;  // long? | The resource defined in the URL
            var userroleId = 789;  // long? | The resource defined in the URL

            try
            {
                // Add users to a client application user role
                apiInstance.AddUsersToClientApplicationUserRole(body, clientApplicationId, userroleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.AddUsersToClientApplicationUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be added. | 
 **clientApplicationId** | **long?**| The resource defined in the URL | 
 **userroleId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createclientapplication"></a>
# **CreateClientApplication**
> ClientApplicationResponse CreateClientApplication (ClientApplicationRequest body)

Create a new client_application

Create a new client_application.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new ClientApplicationRequest(); // ClientApplicationRequest | ClientApplication object that needs to be created. name and contact_person are required.

            try
            {
                // Create a new client_application
                ClientApplicationResponse result = apiInstance.CreateClientApplication(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.CreateClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClientApplicationRequest**](ClientApplicationRequest.md)| ClientApplication object that needs to be created. name and contact_person are required. | 

### Return type

[**ClientApplicationResponse**](ClientApplicationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createwebhooktoclientapplication"></a>
# **CreateWebhookToClientApplication**
> WebhookCreateResponse CreateWebhookToClientApplication (WebhookRequest body, long? clientApplicationId)

Create a new webhook for the Client Application

Create a new web hook to the client application.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateWebhookToClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new WebhookRequest(); // WebhookRequest | Webhook object that needs to be created. url and event_types are required.
            var clientApplicationId = 789;  // long? | Id of the client_application to update

            try
            {
                // Create a new webhook for the Client Application
                WebhookCreateResponse result = apiInstance.CreateWebhookToClientApplication(body, clientApplicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.CreateWebhookToClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookRequest**](WebhookRequest.md)| Webhook object that needs to be created. url and event_types are required. | 
 **clientApplicationId** | **long?**| Id of the client_application to update | 

### Return type

[**WebhookCreateResponse**](WebhookCreateResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteclientapplication"></a>
# **DeleteClientApplication**
> void DeleteClientApplication (long? id)

Delete an client_application

Delete a specific resource in your accessible scope, identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var id = 789;  // long? | Id of the client_application to delete

            try
            {
                // Delete an client_application
                apiInstance.DeleteClientApplication(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.DeleteClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the client_application to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteusersfromclientapplicationuserrole"></a>
# **DeleteUsersFromClientApplicationUserRole**
> void DeleteUsersFromClientApplicationUserRole (UserIDs body, long? clientApplicationId, long? userroleId)

Remove users from a client application user role

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
    public class DeleteUsersFromClientApplicationUserRoleExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be removed.
            var clientApplicationId = 789;  // long? | The resource defined in the URL
            var userroleId = 789;  // long? | The resource defined in the URL

            try
            {
                // Remove users from a client application user role
                apiInstance.DeleteUsersFromClientApplicationUserRole(body, clientApplicationId, userroleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.DeleteUsersFromClientApplicationUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be removed. | 
 **clientApplicationId** | **long?**| The resource defined in the URL | 
 **userroleId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (long? clientApplicationId, long? id)

Delete a webhook

Delete a specific resource identified by the id in the URL. Required Permissions: ```can_delete```.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteWebhookExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | Id of the client_application where webhook to update
            var id = 789;  // long? | Id of the webhook to delete

            try
            {
                // Delete a webhook
                apiInstance.DeleteWebhook(clientApplicationId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.DeleteWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| Id of the client_application where webhook to update | 
 **id** | **long?**| Id of the webhook to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapikeysofclientapplication"></a>
# **GetAPIKeysOfClientApplication**
> ClientApplicationResponse GetAPIKeysOfClientApplication (long? clientApplicationId, int? page = null, int? perPage = null, string apiKey = null, DateTime? validFrom = null, DateTime? validFromFrom = null, DateTime? validFromTo = null, DateTime? validUntil = null, DateTime? validUntilFrom = null, DateTime? validUntilTo = null, string orderBy = null)

GetAPI Keys of Client Application

Returns a list of api_keys of an client application. If the query has no matches, the response is an empty list. Only api_keys on which the user has the can_read permission are loaded.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAPIKeysOfClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var apiKey = apiKey_example;  // string | Filter accepts `*` as wildcard (optional) 
            var validFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validFromFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validFromTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntil = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntilFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntilTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // GetAPI Keys of Client Application
                ClientApplicationResponse result = apiInstance.GetAPIKeysOfClientApplication(clientApplicationId, page, perPage, apiKey, validFrom, validFromFrom, validFromTo, validUntil, validUntilFrom, validUntilTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetAPIKeysOfClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **apiKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **validFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validFromFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validFromTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntil** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntilFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntilTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ClientApplicationResponse**](ClientApplicationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getclientapplicationbyid"></a>
# **GetClientApplicationById**
> ClientApplicationResponse GetClientApplicationById (long? id, string include = null)

Get a single client_application

Get a specific client_application in your accessible scope, identified by the id in the URL. Possible include values: ```technical_users```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetClientApplicationByIdExample
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

            var apiInstance = new ClientApplicationApi();
            var id = 789;  // long? | Id of the client_application to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single client_application
                ClientApplicationResponse result = apiInstance.GetClientApplicationById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetClientApplicationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the client_application to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**ClientApplicationResponse**](ClientApplicationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getclientapplications"></a>
# **GetClientApplications**
> ClientApplicationsResponse GetClientApplications (int? page = null, int? perPage = null, string include = null, string name = null, string contactPersonId = null, string orderBy = null)

Get a range of client_applications

Returns a list of client_applications in your accessible scope. If the query has no matches, the response is an empty list. Only client_applications on which the user has the can_read permission are loaded. Possible include values: ```technical_users```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetClientApplicationsExample
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

            var apiInstance = new ClientApplicationApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var contactPersonId = contactPersonId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of client_applications
                ClientApplicationsResponse result = apiInstance.GetClientApplications(page, perPage, include, name, contactPersonId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetClientApplications: " + e.Message );
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
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **contactPersonId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ClientApplicationsResponse**](ClientApplicationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getclientapplicationsofedgedeviceapplication"></a>
# **GetClientApplicationsOfEdgeDeviceApplication**
> ClientApplicationsResponse GetClientApplicationsOfEdgeDeviceApplication (long? edgeDeviceApplicationId, int? page = null, int? perPage = null, string include = null, string name = null, string code = null, string orderBy = null, string acceptLanguage = null)

Get all client applications of one edge device application

Returns a list of all client applications associated with the selected edge device application. Possible include values: ```technical_user``` You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetClientApplicationsOfEdgeDeviceApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var edgeDeviceApplicationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all client applications of one edge device application
                ClientApplicationsResponse result = apiInstance.GetClientApplicationsOfEdgeDeviceApplication(edgeDeviceApplicationId, page, perPage, include, name, code, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetClientApplicationsOfEdgeDeviceApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **edgeDeviceApplicationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**ClientApplicationsResponse**](ClientApplicationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcurrentclientapplication"></a>
# **GetCurrentClientApplication**
> ClientApplicationPublicResponse GetCurrentClientApplication ()

Get current client_application

Returns current client application used to access the api.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCurrentClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();

            try
            {
                // Get current client_application
                ClientApplicationPublicResponse result = apiInstance.GetCurrentClientApplication();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetCurrentClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ClientApplicationPublicResponse**](ClientApplicationPublicResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getedgedeviceapplicationsofclientapplication"></a>
# **GetEdgeDeviceApplicationsOfClientApplication**
> EdgeDeviceApplicationsResponse GetEdgeDeviceApplicationsOfClientApplication (long? clientApplicationId, int? page = null, int? perPage = null, string name = null, string code = null, string edgeDeviceTypeId = null, string softwareVersionId = null, string orderBy = null, string acceptLanguage = null)

Get all edge devices applications for an client application

Returns a list of all edge devices applications of an client application. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetEdgeDeviceApplicationsOfClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | id of the client application to fetch
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var edgeDeviceTypeId = edgeDeviceTypeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var softwareVersionId = softwareVersionId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all edge devices applications for an client application
                EdgeDeviceApplicationsResponse result = apiInstance.GetEdgeDeviceApplicationsOfClientApplication(clientApplicationId, page, perPage, name, code, edgeDeviceTypeId, softwareVersionId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetEdgeDeviceApplicationsOfClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| id of the client application to fetch | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **edgeDeviceTypeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **softwareVersionId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**EdgeDeviceApplicationsResponse**](EdgeDeviceApplicationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettechnicalusersofclientapplication"></a>
# **GetTechnicalUsersOfClientApplication**
> TechnicalUsersResponse GetTechnicalUsersOfClientApplication (long? clientApplicationId, int? page = null, int? perPage = null, string email = null, string orderBy = null)

Get Technical Users of Client Application

Returns a list of technical of an client application. If the query has no matches, the response is an empty list

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetTechnicalUsersOfClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var email = email_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get Technical Users of Client Application
                TechnicalUsersResponse result = apiInstance.GetTechnicalUsersOfClientApplication(clientApplicationId, page, perPage, email, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetTechnicalUsersOfClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **email** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**TechnicalUsersResponse**](TechnicalUsersResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getusersofclientapplicationuserrole"></a>
# **GetUsersOfClientApplicationUserRole**
> UsersPublicResponse GetUsersOfClientApplicationUserRole (long? clientApplicationId, long? userroleId, int? page = null, int? perPage = null, string firstName = null, string lastName = null, string orderBy = null)

Get all users of a user role assigned to a client application

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
    public class GetUsersOfClientApplicationUserRoleExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | The resource defined in the URL
            var userroleId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var firstName = firstName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var lastName = lastName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all users of a user role assigned to a client application
                UsersPublicResponse result = apiInstance.GetUsersOfClientApplicationUserRole(clientApplicationId, userroleId, page, perPage, firstName, lastName, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetUsersOfClientApplicationUserRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| The resource defined in the URL | 
 **userroleId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **firstName** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **lastName** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**UsersPublicResponse**](UsersPublicResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhookbyid"></a>
# **GetWebhookById**
> WebhookResponse GetWebhookById (long? clientApplicationId, long? id)

Get a single webhook

Get a specific webhook identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetWebhookByIdExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | Id of the client_application where webhook to fetch
            var id = 789;  // long? | Id of the webhook to fetch

            try
            {
                // Get a single webhook
                WebhookResponse result = apiInstance.GetWebhookById(clientApplicationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetWebhookById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| Id of the client_application where webhook to fetch | 
 **id** | **long?**| Id of the webhook to fetch | 

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhookevents"></a>
# **GetWebhookEvents**
> WebhookEventResponses GetWebhookEvents (long? clientApplicationId, long? id, int? page = null, int? perPage = null, string status = null, string eventType = null, DateTime? occurredAt = null, string occurredAtFrom = null, string occurredAtTo = null, string orderBy = null)

Get events of a webhook

Get webhook events. Events are the messages that are send to the webhok URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetWebhookEventsExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | Id of the client_application where webhook is registered
            var id = 789;  // long? | Id of the webhook
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var status = status_example;  // string | Filter by status - no wildcard support (optional) 
            var eventType = eventType_example;  // string | Filter by event type - no wildcard support (optional) 
            var occurredAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var occurredAtFrom = occurredAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var occurredAtTo = occurredAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get events of a webhook
                WebhookEventResponses result = apiInstance.GetWebhookEvents(clientApplicationId, id, page, perPage, status, eventType, occurredAt, occurredAtFrom, occurredAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetWebhookEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| Id of the client_application where webhook is registered | 
 **id** | **long?**| Id of the webhook | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **status** | **string**| Filter by status - no wildcard support | [optional] 
 **eventType** | **string**| Filter by event type - no wildcard support | [optional] 
 **occurredAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **occurredAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **occurredAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**WebhookEventResponses**](WebhookEventResponses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhooksofclientapplication"></a>
# **GetWebhooksOfClientApplication**
> WebhookResponses GetWebhooksOfClientApplication (long? clientApplicationId, int? page = null, int? perPage = null, string orderBy = null)

Get webhooks of Client Application

Returns a list of webhooks of an client application. If the query has no matches, the response is an empty list. Only webhooks on which the user has the can_read permission are loaded.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetWebhooksOfClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | Id of the client_application to update
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get webhooks of Client Application
                WebhookResponses result = apiInstance.GetWebhooksOfClientApplication(clientApplicationId, page, perPage, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.GetWebhooksOfClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| Id of the client_application to update | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**WebhookResponses**](WebhookResponses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeclientapplicationsofedgedeviceapplication"></a>
# **RemoveClientApplicationsOfEdgeDeviceApplication**
> void RemoveClientApplicationsOfEdgeDeviceApplication (ClientApplicationIDs body, long? edgeDeviceApplicationId)

Remove client applications from an edge device application

Remove one or more client applications from an edge device application. This action requires the edge device admin role.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveClientApplicationsOfEdgeDeviceApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new ClientApplicationIDs(); // ClientApplicationIDs | Resources that shall be removed.
            var edgeDeviceApplicationId = 789;  // long? | Id of the edge device application from which the client applications will be removed

            try
            {
                // Remove client applications from an edge device application
                apiInstance.RemoveClientApplicationsOfEdgeDeviceApplication(body, edgeDeviceApplicationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.RemoveClientApplicationsOfEdgeDeviceApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClientApplicationIDs**](ClientApplicationIDs.md)| Resources that shall be removed. | 
 **edgeDeviceApplicationId** | **long?**| Id of the edge device application from which the client applications will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceclientapplicationsofedgedeviceapplication"></a>
# **ReplaceClientApplicationsOfEdgeDeviceApplication**
> void ReplaceClientApplicationsOfEdgeDeviceApplication (ClientApplicationIDs body, long? edgeDeviceApplicationId)

Replace the client applications of an edge device application

Replaces all client applications belonging to an edge device application. You can send a list of resources that will replace all previous values. This action requires the edge device admin role.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceClientApplicationsOfEdgeDeviceApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new ClientApplicationIDs(); // ClientApplicationIDs | Resources that shall be replaced
            var edgeDeviceApplicationId = 789;  // long? | Id of the edge device application of which the client applications will be replaced

            try
            {
                // Replace the client applications of an edge device application
                apiInstance.ReplaceClientApplicationsOfEdgeDeviceApplication(body, edgeDeviceApplicationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.ReplaceClientApplicationsOfEdgeDeviceApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClientApplicationIDs**](ClientApplicationIDs.md)| Resources that shall be replaced | 
 **edgeDeviceApplicationId** | **long?**| Id of the edge device application of which the client applications will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="resendwebhookevents"></a>
# **ResendWebhookEvents**
> void ResendWebhookEvents (WebhookEventIDs body, long? clientApplicationId, long? id)

resend Webhook Events

Trigger the resend of webhook events

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ResendWebhookEventsExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new WebhookEventIDs(); // WebhookEventIDs | ids of the events that should be resend. Events that are currently in state pending are ignored are required.
            var clientApplicationId = 789;  // long? | Id of the client_application where webhook is registered
            var id = 789;  // long? | Id of the webhook

            try
            {
                // resend Webhook Events
                apiInstance.ResendWebhookEvents(body, clientApplicationId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.ResendWebhookEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookEventIDs**](WebhookEventIDs.md)| ids of the events that should be resend. Events that are currently in state pending are ignored are required. | 
 **clientApplicationId** | **long?**| Id of the client_application where webhook is registered | 
 **id** | **long?**| Id of the webhook | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="resetsecretwebhook"></a>
# **ResetSecretWebhook**
> WebhookSecretResponse ResetSecretWebhook (long? clientApplicationId, long? id)

Reset the secret property of the webhook

Reset the secret property of the webhook

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ResetSecretWebhookExample
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

            var apiInstance = new ClientApplicationApi();
            var clientApplicationId = 789;  // long? | Id of the client_application to update
            var id = 789;  // long? | Id of the webhook to update

            try
            {
                // Reset the secret property of the webhook
                WebhookSecretResponse result = apiInstance.ResetSecretWebhook(clientApplicationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.ResetSecretWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientApplicationId** | **long?**| Id of the client_application to update | 
 **id** | **long?**| Id of the webhook to update | 

### Return type

[**WebhookSecretResponse**](WebhookSecretResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateclientapplication"></a>
# **UpdateClientApplication**
> void UpdateClientApplication (ClientApplicationRequest body, long? id)

Update an client_application

Update accessible parameters of the requested resource in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateClientApplicationExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new ClientApplicationRequest(); // ClientApplicationRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the client_application to update

            try
            {
                // Update an client_application
                apiInstance.UpdateClientApplication(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.UpdateClientApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClientApplicationRequest**](ClientApplicationRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the client_application to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatewebhook"></a>
# **UpdateWebhook**
> void UpdateWebhook (WebhookRequest body, long? clientApplicationId, long? id)

Update a webhook

Update accessible parameters of the requested resource in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateWebhookExample
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

            var apiInstance = new ClientApplicationApi();
            var body = new WebhookRequest(); // WebhookRequest | Parameters that shall be updated.
            var clientApplicationId = 789;  // long? | Id of the client_application to update
            var id = 789;  // long? | Id of the webhook to update

            try
            {
                // Update a webhook
                apiInstance.UpdateWebhook(body, clientApplicationId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApplicationApi.UpdateWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookRequest**](WebhookRequest.md)| Parameters that shall be updated. | 
 **clientApplicationId** | **long?**| Id of the client_application to update | 
 **id** | **long?**| Id of the webhook to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
