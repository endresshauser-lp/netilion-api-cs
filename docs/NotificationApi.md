# Netilion.Api.Api.NotificationApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddClientApplicationsToNotification**](NotificationApi.md#addclientapplicationstonotification) | **POST** /notifications/{notification_id}/client_applications | add client_applications to a notification
[**CreateNotification**](NotificationApi.md#createnotification) | **POST** /notifications | Create a new notification
[**DeleteNotification**](NotificationApi.md#deletenotification) | **DELETE** /notifications/{id} | Delete a notification
[**GetClientApplicationsOfNotification**](NotificationApi.md#getclientapplicationsofnotification) | **GET** /notifications/{notification_id}/client_applications | Get all client_applications assigned to a notification
[**GetNotificationById**](NotificationApi.md#getnotificationbyid) | **GET** /notifications/{id} | Get a single notification
[**GetNotifications**](NotificationApi.md#getnotifications) | **GET** /notifications | Get a range of notifications
[**RemoteClientApplicationsFromNotification**](NotificationApi.md#remoteclientapplicationsfromnotification) | **DELETE** /notifications/{notification_id}/client_applications | Remove client_application form a notification
[**ReplaceClientApplicationsOfNotification**](NotificationApi.md#replaceclientapplicationsofnotification) | **PATCH** /notifications/{notification_id}/client_applications | Replace the client_applications of a notification
[**UpdateNotification**](NotificationApi.md#updatenotification) | **PATCH** /notifications/{id} | Update a notification

<a name="addclientapplicationstonotification"></a>
# **AddClientApplicationsToNotification**
> void AddClientApplicationsToNotification (ClientApplicationIDs body, long? notificationId)

add client_applications to a notification

Add one or more client_applications to a notification.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddClientApplicationsToNotificationExample
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

            var apiInstance = new NotificationApi();
            var body = new ClientApplicationIDs(); // ClientApplicationIDs | Resources that shall be added.
            var notificationId = 789;  // long? | Id of the notification to which the client_applications will be added

            try
            {
                // add client_applications to a notification
                apiInstance.AddClientApplicationsToNotification(body, notificationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.AddClientApplicationsToNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClientApplicationIDs**](ClientApplicationIDs.md)| Resources that shall be added. | 
 **notificationId** | **long?**| Id of the notification to which the client_applications will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createnotification"></a>
# **CreateNotification**
> NotificationResponse CreateNotification (NotificationRequest body)

Create a new notification

The notification content can be formatted with markdown. The only html tag allowed is ```a```, all other tags will be silently removed. Parameters supporting translation: ```content```. POST sets values in default language: en.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateNotificationExample
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

            var apiInstance = new NotificationApi();
            var body = new NotificationRequest(); // NotificationRequest | Notification object to create.

            try
            {
                // Create a new notification
                NotificationResponse result = apiInstance.CreateNotification(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.CreateNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NotificationRequest**](NotificationRequest.md)| Notification object to create. | 

### Return type

[**NotificationResponse**](NotificationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletenotification"></a>
# **DeleteNotification**
> void DeleteNotification (long? id)

Delete a notification

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
    public class DeleteNotificationExample
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

            var apiInstance = new NotificationApi();
            var id = 789;  // long? | Id of the notification to delete

            try
            {
                // Delete a notification
                apiInstance.DeleteNotification(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.DeleteNotification: " + e.Message );
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
<a name="getclientapplicationsofnotification"></a>
# **GetClientApplicationsOfNotification**
> ClientApplicationsResponse GetClientApplicationsOfNotification (long? notificationId, int? page = null, int? perPage = null, string name = null, string contactPersonId = null, string orderBy = null)

Get all client_applications assigned to a notification

Returns a list of client_applications in your accessible scope. If the query has no matches, the response is an empty list. Only client_applications on which the user has the can_read permission are loaded.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetClientApplicationsOfNotificationExample
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

            var apiInstance = new NotificationApi();
            var notificationId = 789;  // long? | Id of the notification to update
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var contactPersonId = contactPersonId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all client_applications assigned to a notification
                ClientApplicationsResponse result = apiInstance.GetClientApplicationsOfNotification(notificationId, page, perPage, name, contactPersonId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.GetClientApplicationsOfNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationId** | **long?**| Id of the notification to update | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
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
<a name="getnotificationbyid"></a>
# **GetNotificationById**
> NotificationResponse GetNotificationById (long? id, string acceptLanguage = null)

Get a single notification

Get a specific notification identified by the id in the URL. Parameters supporting translation: ```content```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetNotificationByIdExample
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

            var apiInstance = new NotificationApi();
            var id = 789;  // long? | Id of notification to fetch
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single notification
                NotificationResponse result = apiInstance.GetNotificationById(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.GetNotificationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of notification to fetch | 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**NotificationResponse**](NotificationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnotifications"></a>
# **GetNotifications**
> Notifications GetNotifications (int? page = null, int? perPage = null, long? clientApplicationId = null, string startDatetime = null, string startDatetimeFrom = null, string startDatetimeTo = null, string endDatetime = null, DateTime? endDatetimeFrom = null, string endDatetimeTo = null, string name = null, string orderBy = null, string acceptLanguage = null)

Get a range of notifications

Returns a list of all notifications available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```content```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetNotificationsExample
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

            var apiInstance = new NotificationApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var clientApplicationId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var startDatetime = startDatetime_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var startDatetimeFrom = startDatetimeFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var startDatetimeTo = startDatetimeTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var endDatetime = endDatetime_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var endDatetimeFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var endDatetimeTo = endDatetimeTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var name = name_example;  // string | searches notifications with given name (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of notifications
                Notifications result = apiInstance.GetNotifications(page, perPage, clientApplicationId, startDatetime, startDatetimeFrom, startDatetimeTo, endDatetime, endDatetimeFrom, endDatetimeTo, name, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.GetNotifications: " + e.Message );
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
 **clientApplicationId** | **long?**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **startDatetime** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **startDatetimeFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **startDatetimeTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **endDatetime** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **endDatetimeFrom** | **DateTime?**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **endDatetimeTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **name** | **string**| searches notifications with given name | [optional] 
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
<a name="remoteclientapplicationsfromnotification"></a>
# **RemoteClientApplicationsFromNotification**
> void RemoteClientApplicationsFromNotification (ClientApplicationIDs body, long? notificationId)

Remove client_application form a notification

Remove one or more client_applications from a notification

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoteClientApplicationsFromNotificationExample
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

            var apiInstance = new NotificationApi();
            var body = new ClientApplicationIDs(); // ClientApplicationIDs | Resources that shall be removed.
            var notificationId = 789;  // long? | Id of the notification from which the client_applications will be removed

            try
            {
                // Remove client_application form a notification
                apiInstance.RemoteClientApplicationsFromNotification(body, notificationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.RemoteClientApplicationsFromNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClientApplicationIDs**](ClientApplicationIDs.md)| Resources that shall be removed. | 
 **notificationId** | **long?**| Id of the notification from which the client_applications will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceclientapplicationsofnotification"></a>
# **ReplaceClientApplicationsOfNotification**
> void ReplaceClientApplicationsOfNotification (ClientApplicationIDs body, long? notificationId)

Replace the client_applications of a notification

Replaces all client_applications belonging to a notificatoin. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceClientApplicationsOfNotificationExample
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

            var apiInstance = new NotificationApi();
            var body = new ClientApplicationIDs(); // ClientApplicationIDs | Resources that shall be replaced
            var notificationId = 789;  // long? | Id of the notification of which the client_applications will be replaced

            try
            {
                // Replace the client_applications of a notification
                apiInstance.ReplaceClientApplicationsOfNotification(body, notificationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.ReplaceClientApplicationsOfNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClientApplicationIDs**](ClientApplicationIDs.md)| Resources that shall be replaced | 
 **notificationId** | **long?**| Id of the notification of which the client_applications will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatenotification"></a>
# **UpdateNotification**
> void UpdateNotification (NotificationRequest body, long? id, string contentLanguage = null)

Update a notification

Update accessible parameters of the requested resource. The notification content can be formatted with markdown. The only html tag allowed is ```a```, all other tags will be silently removed. Parameters supporting translation: ```name, description```. To add a translation set Content-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateNotificationExample
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

            var apiInstance = new NotificationApi();
            var body = new NotificationRequest(); // NotificationRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the notification to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update a notification
                apiInstance.UpdateNotification(body, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.UpdateNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NotificationRequest**](NotificationRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the notification to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
