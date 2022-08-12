# Netilion.Api.Api.TenantApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTenantAdmins**](TenantApi.md#addtenantadmins) | **POST** /tenants/{tenant_id}/admins | Add admins to a tenant
[**AddTenantUsers**](TenantApi.md#addtenantusers) | **POST** /tenants/{tenant_id}/users | Add users to a tenant
[**CreateTenants**](TenantApi.md#createtenants) | **POST** /tenants | Create a new tenant
[**DeleteTenant**](TenantApi.md#deletetenant) | **DELETE** /tenants/{id} | Delete a tenant
[**GetAssetTenantOptions**](TenantApi.md#getassettenantoptions) | **GET** /assets/{asset_id}/tenant-options | Get all possible tenants of the specified assets
[**GetTenantAdmins**](TenantApi.md#gettenantadmins) | **GET** /tenants/{tenant_id}/admins | Get all admins of a tenant
[**GetTenantUsers**](TenantApi.md#gettenantusers) | **GET** /tenants/{tenant_id}/users | Get all users of a tenant
[**GetTenants**](TenantApi.md#gettenants) | **GET** /tenants | Get a range of tenants
[**GetTenantsById**](TenantApi.md#gettenantsbyid) | **GET** /tenants/{id} | Get a single tenant
[**RemoveTenantAdmins**](TenantApi.md#removetenantadmins) | **DELETE** /tenants/{tenant_id}/admins | Remove admins from a tenant
[**RemoveTenantUsers**](TenantApi.md#removetenantusers) | **DELETE** /tenants/{tenant_id}/users | Remove users from a tenant
[**ReplaceTenantAdmins**](TenantApi.md#replacetenantadmins) | **PATCH** /tenants/{tenant_id}/admins | Replace the admins of a tenant
[**ReplaceTenantUsers**](TenantApi.md#replacetenantusers) | **PATCH** /tenants/{tenant_id}/users | Replace the users of a tenant
[**UpdateTenant**](TenantApi.md#updatetenant) | **PATCH** /tenants/{id} | Update a tenant

<a name="addtenantadmins"></a>
# **AddTenantAdmins**
> void AddTenantAdmins (AdminIDs body, long? tenantId)

Add admins to a tenant

Add admins to a tenant. Only an admin of a tenant can add additional admins.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddTenantAdminsExample
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

            var apiInstance = new TenantApi();
            var body = new AdminIDs(); // AdminIDs | Object body that will be created. Tenant name is required
            var tenantId = 789;  // long? | Id of the tenant to which the users will be added as admins

            try
            {
                // Add admins to a tenant
                apiInstance.AddTenantAdmins(body, tenantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.AddTenantAdmins: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdminIDs**](AdminIDs.md)| Object body that will be created. Tenant name is required | 
 **tenantId** | **long?**| Id of the tenant to which the users will be added as admins | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addtenantusers"></a>
# **AddTenantUsers**
> void AddTenantUsers (UserIDs body, long? tenantId)

Add users to a tenant

Add users to a tenant. Only an admin of a tenant can add additional users.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddTenantUsersExample
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

            var apiInstance = new TenantApi();
            var body = new UserIDs(); // UserIDs | Object body that will be created. Tenant name is required
            var tenantId = 789;  // long? | Id of the tenant to which the users will be added

            try
            {
                // Add users to a tenant
                apiInstance.AddTenantUsers(body, tenantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.AddTenantUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Object body that will be created. Tenant name is required | 
 **tenantId** | **long?**| Id of the tenant to which the users will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createtenants"></a>
# **CreateTenants**
> TenantResponse CreateTenants (TenantRequest body)

Create a new tenant

Create a new tenant. The name of the given tenant needs to be unique. The tenant will not be created when this constraint is violated.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateTenantsExample
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

            var apiInstance = new TenantApi();
            var body = new TenantRequest(); // TenantRequest | Object body that will be created. Tenant name is required

            try
            {
                // Create a new tenant
                TenantResponse result = apiInstance.CreateTenants(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.CreateTenants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantRequest**](TenantRequest.md)| Object body that will be created. Tenant name is required | 

### Return type

[**TenantResponse**](TenantResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetenant"></a>
# **DeleteTenant**
> void DeleteTenant (long? id)

Delete a tenant

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
    public class DeleteTenantExample
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

            var apiInstance = new TenantApi();
            var id = 789;  // long? | Id of the tenant to delete

            try
            {
                // Delete a tenant
                apiInstance.DeleteTenant(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.DeleteTenant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the tenant to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassettenantoptions"></a>
# **GetAssetTenantOptions**
> Tenants GetAssetTenantOptions (long? assetId, int? page = null, int? perPage = null, string name = null, string orderBy = null)

Get all possible tenants of the specified assets

Returns a list of all possible tenants for the specified asset. That is all public tenants and the assets tenant. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetTenantOptionsExample
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

            var apiInstance = new TenantApi();
            var assetId = 789;  // long? | Id of the specified asset
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all possible tenants of the specified assets
                Tenants result = apiInstance.GetAssetTenantOptions(assetId, page, perPage, name, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.GetAssetTenantOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the specified asset | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**Tenants**](Tenants.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettenantadmins"></a>
# **GetTenantAdmins**
> UsersPublicResponse GetTenantAdmins (long? tenantId, int? page = null, int? perPage = null, string include = null, string firstName = null, string lastName = null, string orderBy = null)

Get all admins of a tenant

Returns a list of all admins that are available for the tenant. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetTenantAdminsExample
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

            var apiInstance = new TenantApi();
            var tenantId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var firstName = firstName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var lastName = lastName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `email`, `first_name`, `last_name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all admins of a tenant
                UsersPublicResponse result = apiInstance.GetTenantAdmins(tenantId, page, perPage, include, firstName, lastName, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.GetTenantAdmins: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenantId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
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
<a name="gettenantusers"></a>
# **GetTenantUsers**
> UsersPublicResponse GetTenantUsers (long? tenantId, int? page = null, int? perPage = null, string firstName = null, string lastName = null, string orderBy = null)

Get all users of a tenant

Returns a list of all users that are available for the tenant. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetTenantUsersExample
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

            var apiInstance = new TenantApi();
            var tenantId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var firstName = firstName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var lastName = lastName_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `email`, `first_name`, `last_name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all users of a tenant
                UsersPublicResponse result = apiInstance.GetTenantUsers(tenantId, page, perPage, firstName, lastName, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.GetTenantUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenantId** | **long?**| The resource defined in the URL | 
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
<a name="gettenants"></a>
# **GetTenants**
> TenantsResponse GetTenants (int? page = null, int? perPage = null, string name = null, string adminUserId = null, string adminOrUserId = null, bool? _public = null, string orderBy = null)

Get a range of tenants

Returns a list of tenants in your accessible scope. If the query has no matches, the response is an empty list.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetTenantsExample
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

            var apiInstance = new TenantApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var adminUserId = adminUserId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var adminOrUserId = adminOrUserId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var _public = true;  // bool? | Valid values are true and false (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of tenants
                TenantsResponse result = apiInstance.GetTenants(page, perPage, name, adminUserId, adminOrUserId, _public, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.GetTenants: " + e.Message );
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
 **adminUserId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **adminOrUserId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **_public** | **bool?**| Valid values are true and false | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**TenantsResponse**](TenantsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettenantsbyid"></a>
# **GetTenantsById**
> TenantResponse GetTenantsById (long? id)

Get a single tenant

Get a specific tenant in your accessible scope, identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetTenantsByIdExample
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

            var apiInstance = new TenantApi();
            var id = 789;  // long? | Id of the tenant to fetch

            try
            {
                // Get a single tenant
                TenantResponse result = apiInstance.GetTenantsById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.GetTenantsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the tenant to fetch | 

### Return type

[**TenantResponse**](TenantResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removetenantadmins"></a>
# **RemoveTenantAdmins**
> void RemoveTenantAdmins (AdminIDs body, long? tenantId)

Remove admins from a tenant

Remove one or more admins from a tenant identified by id in the url.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveTenantAdminsExample
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

            var apiInstance = new TenantApi();
            var body = new AdminIDs(); // AdminIDs | Resources that shall be removed.
            var tenantId = 789;  // long? | Id of the tenant from which the admins will be removed

            try
            {
                // Remove admins from a tenant
                apiInstance.RemoveTenantAdmins(body, tenantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.RemoveTenantAdmins: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdminIDs**](AdminIDs.md)| Resources that shall be removed. | 
 **tenantId** | **long?**| Id of the tenant from which the admins will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removetenantusers"></a>
# **RemoveTenantUsers**
> void RemoveTenantUsers (UserIDs body, long? tenantId)

Remove users from a tenant

Remove one or more users from a tenant identified by id in the url.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveTenantUsersExample
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

            var apiInstance = new TenantApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be removed.
            var tenantId = 789;  // long? | Id of the tenant from which the admins will be removed

            try
            {
                // Remove users from a tenant
                apiInstance.RemoveTenantUsers(body, tenantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.RemoveTenantUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be removed. | 
 **tenantId** | **long?**| Id of the tenant from which the admins will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacetenantadmins"></a>
# **ReplaceTenantAdmins**
> void ReplaceTenantAdmins (AdminIDs body, long? tenantId)

Replace the admins of a tenant

Replaces all admins of the tenant. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceTenantAdminsExample
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

            var apiInstance = new TenantApi();
            var body = new AdminIDs(); // AdminIDs | Resources that shall be replaced
            var tenantId = 789;  // long? | Id of the tenant of which the admins will be replaced

            try
            {
                // Replace the admins of a tenant
                apiInstance.ReplaceTenantAdmins(body, tenantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.ReplaceTenantAdmins: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdminIDs**](AdminIDs.md)| Resources that shall be replaced | 
 **tenantId** | **long?**| Id of the tenant of which the admins will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacetenantusers"></a>
# **ReplaceTenantUsers**
> void ReplaceTenantUsers (UserIDs body, long? tenantId)

Replace the users of a tenant

Replaces all users of the tenant. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceTenantUsersExample
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

            var apiInstance = new TenantApi();
            var body = new UserIDs(); // UserIDs | Resources that shall be replaced
            var tenantId = 789;  // long? | Id of the tenant of which the users will be replaced

            try
            {
                // Replace the users of a tenant
                apiInstance.ReplaceTenantUsers(body, tenantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.ReplaceTenantUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIDs**](UserIDs.md)| Resources that shall be replaced | 
 **tenantId** | **long?**| Id of the tenant of which the users will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetenant"></a>
# **UpdateTenant**
> void UpdateTenant (TenantRequest body, long? id)

Update a tenant

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
    public class UpdateTenantExample
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

            var apiInstance = new TenantApi();
            var body = new TenantRequest(); // TenantRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the tenant to update

            try
            {
                // Update a tenant
                apiInstance.UpdateTenant(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.UpdateTenant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantRequest**](TenantRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the tenant to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
