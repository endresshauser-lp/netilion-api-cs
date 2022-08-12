# Netilion.Api.Api.PermissionRequestApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePermissionRequest**](PermissionRequestApi.md#createpermissionrequest) | **POST** /permission_requests | Create a new permission request
[**DeletePermissionRequest**](PermissionRequestApi.md#deletepermissionrequest) | **DELETE** /permission_requests/{id} | Delete a permission request
[**GetPermissionRequestById**](PermissionRequestApi.md#getpermissionrequestbyid) | **GET** /permission_requests/{id} | Get a single permissionRequest
[**UpdatePermissionRequest**](PermissionRequestApi.md#updatepermissionrequest) | **PATCH** /permission_requests/{id} | Update a permission request

<a name="createpermissionrequest"></a>
# **CreatePermissionRequest**
> PermissionRequestResponse CreatePermissionRequest (PermissionRequestCreateRequest body)

Create a new permission request

Permissions must have a permission_type, assignable and permitable.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreatePermissionRequestExample
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

            var apiInstance = new PermissionRequestApi();
            var body = new PermissionRequestCreateRequest(); // PermissionRequestCreateRequest | Permission object that needs to be created.

            try
            {
                // Create a new permission request
                PermissionRequestResponse result = apiInstance.CreatePermissionRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionRequestApi.CreatePermissionRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PermissionRequestCreateRequest**](PermissionRequestCreateRequest.md)| Permission object that needs to be created. | 

### Return type

[**PermissionRequestResponse**](PermissionRequestResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepermissionrequest"></a>
# **DeletePermissionRequest**
> void DeletePermissionRequest (long? id)

Delete a permission request

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
    public class DeletePermissionRequestExample
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

            var apiInstance = new PermissionRequestApi();
            var id = 789;  // long? | Id of the permission request to delete

            try
            {
                // Delete a permission request
                apiInstance.DeletePermissionRequest(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionRequestApi.DeletePermissionRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the permission request to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpermissionrequestbyid"></a>
# **GetPermissionRequestById**
> PermissionRequestResponse GetPermissionRequestById (long? id)

Get a single permissionRequest

Get a specific permission request identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPermissionRequestByIdExample
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

            var apiInstance = new PermissionRequestApi();
            var id = 789;  // long? | Id of the permission request to fetch

            try
            {
                // Get a single permissionRequest
                PermissionRequestResponse result = apiInstance.GetPermissionRequestById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionRequestApi.GetPermissionRequestById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the permission request to fetch | 

### Return type

[**PermissionRequestResponse**](PermissionRequestResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepermissionrequest"></a>
# **UpdatePermissionRequest**
> void UpdatePermissionRequest (PermissionRequestUpdateRequest body, long? id)

Update a permission request

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
    public class UpdatePermissionRequestExample
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

            var apiInstance = new PermissionRequestApi();
            var body = new PermissionRequestUpdateRequest(); // PermissionRequestUpdateRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the permission request to update

            try
            {
                // Update a permission request
                apiInstance.UpdatePermissionRequest(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionRequestApi.UpdatePermissionRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PermissionRequestUpdateRequest**](PermissionRequestUpdateRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the permission request to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
