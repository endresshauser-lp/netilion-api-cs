# Netilion.Api.Api.InstrumentationApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAssetsToInstrumentation**](InstrumentationApi.md#addassetstoinstrumentation) | **POST** /instrumentations/{instrumentation_id}/assets | Add assets to an instrumentation
[**AddBillOfMaterialsToInstrumentation**](InstrumentationApi.md#addbillofmaterialstoinstrumentation) | **POST** /instrumentations/{instrumentation_id}/bill_of_materials | Add bill of materials to an instrumentation
[**AddDocumentsToInstrumentation**](InstrumentationApi.md#adddocumentstoinstrumentation) | **POST** /instrumentations/{instrumentation_id}/documents | Add documents to an instrumentation
[**AddInstrumentationPictureLink**](InstrumentationApi.md#addinstrumentationpicturelink) | **POST** /instrumentations/{id}/pictures/links | Add a link as instrumentation picture
[**AddNodesToInstrumentation**](InstrumentationApi.md#addnodestoinstrumentation) | **POST** /instrumentations/{instrumentation_id}/nodes | Add nodes to an instrumentation
[**CreateEventForInstrumentation**](InstrumentationApi.md#createeventforinstrumentation) | **POST** /instrumentations/{instrumentation_id}/events | Create a new event for an instrumentation
[**CreateInstrumentation**](InstrumentationApi.md#createinstrumentation) | **POST** /instrumentations | Create a new instrumentation
[**CreateInstrumentationThreshold**](InstrumentationApi.md#createinstrumentationthreshold) | **POST** /instrumentations/{instrumentation_id}/thresholds | Create an instrumentation threshold
[**DeleteInstrumentation**](InstrumentationApi.md#deleteinstrumentation) | **DELETE** /instrumentations/{id} | Delete an instrumentation
[**DeleteInstrumentationPicture**](InstrumentationApi.md#deleteinstrumentationpicture) | **DELETE** /instrumentations/{instrumentation_id}/pictures/{id} | Delete an instrumentation picture
[**DeleteInstrumentationThreshold**](InstrumentationApi.md#deleteinstrumentationthreshold) | **DELETE** /instrumentations/{instrumentation_id}/thresholds/{id} | Delete an instrumentation threshold.
[**DownloadInstrumentationPicture**](InstrumentationApi.md#downloadinstrumentationpicture) | **GET** /instrumentations/{instrumentation_id}/pictures/{id}/download | Download an instrumentation picture
[**GetAssetsOfInstrumentation**](InstrumentationApi.md#getassetsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/assets | Get all assets of one instrumentation
[**GetAssetsOfInstrumentationHistory**](InstrumentationApi.md#getassetsofinstrumentationhistory) | **GET** /instrumentations/{instrumentation_id}/assets/history | Get all assets an instrumentation was assigned to
[**GetBillOfMaterialsOfInstrumentation**](InstrumentationApi.md#getbillofmaterialsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/bill_of_materials | Get all bill of materials of an instrumentation
[**GetDocumentsOfInstrumentation**](InstrumentationApi.md#getdocumentsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/documents | Get all documents of an instrumentation
[**GetEventsOfInstrumentation**](InstrumentationApi.md#geteventsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/events | Get all events of one instrumentation
[**GetInstrumentationById**](InstrumentationApi.md#getinstrumentationbyid) | **GET** /instrumentations/{id} | Get a single instrumentation
[**GetInstrumentationIdStatus**](InstrumentationApi.md#getinstrumentationidstatus) | **GET** /instrumentations/{instrumentation_id}/status | Get the status of the specific instrumentation
[**GetInstrumentationIdType**](InstrumentationApi.md#getinstrumentationidtype) | **GET** /instrumentations/{instrumentation_id}/type | Get the type of the specific instrumentation
[**GetInstrumentationPicture**](InstrumentationApi.md#getinstrumentationpicture) | **GET** /instrumentations/{instrumentation_id}/pictures/{id} | Get an instrumentation picture
[**GetInstrumentationPictures**](InstrumentationApi.md#getinstrumentationpictures) | **GET** /instrumentations/{id}/pictures | Get instrumentation pictures
[**GetInstrumentationStatusesOptions**](InstrumentationApi.md#getinstrumentationstatusesoptions) | **GET** /instrumentations/{instrumentation_id}/status-options | Get all possible statuses of the specified instrumentation
[**GetInstrumentationThreshold**](InstrumentationApi.md#getinstrumentationthreshold) | **GET** /instrumentations/{instrumentation_id}/thresholds/{id} | Get an instrumentation threshold
[**GetInstrumentationThresholds**](InstrumentationApi.md#getinstrumentationthresholds) | **GET** /instrumentations/{instrumentation_id}/thresholds | Get instrumentation thresholds
[**GetInstrumentationTypesOptions**](InstrumentationApi.md#getinstrumentationtypesoptions) | **GET** /instrumentations/{instrumentation_id}/type-options | Get all possible types of the specified instrumentation
[**GetInstrumentationValueObjectsForKey**](InstrumentationApi.md#getinstrumentationvalueobjectsforkey) | **GET** /instrumentations/{instrumentation_id}/value_objects/{key} | Get instrumentation value objects for a specific key.
[**GetInstrumentationValues**](InstrumentationApi.md#getinstrumentationvalues) | **GET** /instrumentations/{instrumentation_id}/values | Get latest values for the instrumentation.
[**GetInstrumentationValuesForKey**](InstrumentationApi.md#getinstrumentationvaluesforkey) | **GET** /instrumentations/{instrumentation_id}/values/{key} | Get instrumentation values for a specific key.
[**GetInstrumentations**](InstrumentationApi.md#getinstrumentations) | **GET** /instrumentations | Get a range of instrumentations
[**GetNodesOfInstrumentation**](InstrumentationApi.md#getnodesofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/nodes | Get all nodes of one Instrumentation
[**GetSpecificationHistoryOfInstrumentation**](InstrumentationApi.md#getspecificationhistoryofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/specifications/{key}/history | Get the history of one specification attribute of an instrumentation.
[**GetSpecificationKeysOfInstrumentations**](InstrumentationApi.md#getspecificationkeysofinstrumentations) | **GET** /instrumentation/specification_keys | Get existing instrumentation specification keys
[**GetSpecificationsOfInstrumentation**](InstrumentationApi.md#getspecificationsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/specifications | Get specifications of an instrumentation
[**GetSystemsOfInstrumentation**](InstrumentationApi.md#getsystemsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/systems | Get all systems of one instrumentation
[**RemoveAssetsFromInstrumentation**](InstrumentationApi.md#removeassetsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/assets | Remove assets from an instrumentation
[**RemoveBillOfMaterialsFromInstrumentation**](InstrumentationApi.md#removebillofmaterialsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/bill_of_materials | Remove bill of materials from an instrumentation
[**RemoveDocumentsFromInstrumentation**](InstrumentationApi.md#removedocumentsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/documents | Remove documents from an instrumentation
[**RemoveEventFromInstrumentation**](InstrumentationApi.md#removeeventfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/events | Remove events from an instrumentation
[**RemoveNodesFromInstrumentation**](InstrumentationApi.md#removenodesfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/nodes | Remove nodes from an instrumentation
[**RemoveSpecificationsFromInstrumentation**](InstrumentationApi.md#removespecificationsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/specifications | Delete specifications of an instrumentation
[**RenameSpecificationsOfInstrumentation**](InstrumentationApi.md#renamespecificationsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/specifications/rename | Rename a specification key
[**ReplaceAssetsOfInstrumentation**](InstrumentationApi.md#replaceassetsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/assets | Replace the assets of an instrumentation
[**ReplaceBillOfMaterialsOfInstrumentation**](InstrumentationApi.md#replacebillofmaterialsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/bill_of_materials | Replace the bill of materials of an instrumentation
[**ReplaceDocumentsOfInstrumentation**](InstrumentationApi.md#replacedocumentsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/documents | Replace the documents of an instrumentation
[**ReplaceNodesOfInstrumentation**](InstrumentationApi.md#replacenodesofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/nodes | Replace the nodes of an instrumentation
[**UpdateInstrumentation**](InstrumentationApi.md#updateinstrumentation) | **PATCH** /instrumentations/{id} | Update an instrumentation
[**UpdateInstrumentationPicture**](InstrumentationApi.md#updateinstrumentationpicture) | **PATCH** /instrumentations/{instrumentation_id}/pictures/{id} | Update an instrumentation picture
[**UpdateInstrumentationPictureLink**](InstrumentationApi.md#updateinstrumentationpicturelink) | **PATCH** /instrumentations/{instrumentation_id}/pictures/links/{id} | Update an instrumentation picture link
[**UpdateInstrumentationThreshold**](InstrumentationApi.md#updateinstrumentationthreshold) | **PATCH** /instrumentations/{instrumentation_id}/thresholds/{id} | Update an instrumentation threshold
[**UpdateSpecificationsOfInstrumentation**](InstrumentationApi.md#updatespecificationsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/specifications | Update specifications of an instrumentation
[**UploadInstrumentationPicture**](InstrumentationApi.md#uploadinstrumentationpicture) | **POST** /instrumentations/{id}/pictures | Upload an instrumentation picture

<a name="addassetstoinstrumentation"></a>
# **AddAssetsToInstrumentation**
> void AddAssetsToInstrumentation (AssetIDs body, long? instrumentationId)

Add assets to an instrumentation

Add one or more assets to an instrumentation. This action requires `can_permit` permission on the instrumentation and on the asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddAssetsToInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be added.
            var instrumentationId = 789;  // long? | Id of the instrumentation to which the assets will be added

            try
            {
                // Add assets to an instrumentation
                apiInstance.AddAssetsToInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.AddAssetsToInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be added. | 
 **instrumentationId** | **long?**| Id of the instrumentation to which the assets will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addbillofmaterialstoinstrumentation"></a>
# **AddBillOfMaterialsToInstrumentation**
> void AddBillOfMaterialsToInstrumentation (BillOfMaterialIDs body, long? instrumentationId)

Add bill of materials to an instrumentation

Add one or more bill of materials to an instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddBillOfMaterialsToInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new BillOfMaterialIDs(); // BillOfMaterialIDs | Resources that shall be added.
            var instrumentationId = 789;  // long? | Id of the instrumentation to which the bill of materials will be added

            try
            {
                // Add bill of materials to an instrumentation
                apiInstance.AddBillOfMaterialsToInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.AddBillOfMaterialsToInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfMaterialIDs**](BillOfMaterialIDs.md)| Resources that shall be added. | 
 **instrumentationId** | **long?**| Id of the instrumentation to which the bill of materials will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adddocumentstoinstrumentation"></a>
# **AddDocumentsToInstrumentation**
> void AddDocumentsToInstrumentation (DocumentIDs body, long? instrumentationId)

Add documents to an instrumentation

Add one or more documents to an instrumentation. This action requires `can_update` permission on the instrumentation and `can_read` permission on the document.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDocumentsToInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be added.
            var instrumentationId = 789;  // long? | Id of the instrumentation to which the documents will be added

            try
            {
                // Add documents to an instrumentation
                apiInstance.AddDocumentsToInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.AddDocumentsToInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be added. | 
 **instrumentationId** | **long?**| Id of the instrumentation to which the documents will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addinstrumentationpicturelink"></a>
# **AddInstrumentationPictureLink**
> PictureResponse AddInstrumentationPictureLink (PictureLinkRequest body, long? id)

Add a link as instrumentation picture

Add an external resource as instrumentation picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddInstrumentationPictureLinkExample
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

            var apiInstance = new InstrumentationApi();
            var body = new PictureLinkRequest(); // PictureLinkRequest | Picture link object to be created
            var id = 789;  // long? | Id of the instrumentation

            try
            {
                // Add a link as instrumentation picture
                PictureResponse result = apiInstance.AddInstrumentationPictureLink(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.AddInstrumentationPictureLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PictureLinkRequest**](PictureLinkRequest.md)| Picture link object to be created | 
 **id** | **long?**| Id of the instrumentation | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addnodestoinstrumentation"></a>
# **AddNodesToInstrumentation**
> void AddNodesToInstrumentation (NodeIDs body, long? instrumentationId)

Add nodes to an instrumentation

Add one or more nodes to an instrumentation in your accessible scope. This action requires `can_permit` permission on the instrumentation and on the node.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddNodesToInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new NodeIDs(); // NodeIDs | Resources that shall be added.
            var instrumentationId = 789;  // long? | Id of the instrumentation to which the nodes will be added

            try
            {
                // Add nodes to an instrumentation
                apiInstance.AddNodesToInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.AddNodesToInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeIDs**](NodeIDs.md)| Resources that shall be added. | 
 **instrumentationId** | **long?**| Id of the instrumentation to which the nodes will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createeventforinstrumentation"></a>
# **CreateEventForInstrumentation**
> EventResponse CreateEventForInstrumentation (EventRequestNoInstrumentations body, long? instrumentationId)

Create a new event for an instrumentation

Events must have a name, and can have a start_datetime (if not provided, the date of creation will be used as default value), end_datetime, event_type, event_status, description and responsible

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateEventForInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new EventRequestNoInstrumentations(); // EventRequestNoInstrumentations | Object to be created.
            var instrumentationId = 789;  // long? | Id of the instrumentation

            try
            {
                // Create a new event for an instrumentation
                EventResponse result = apiInstance.CreateEventForInstrumentation(body, instrumentationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.CreateEventForInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventRequestNoInstrumentations**](EventRequestNoInstrumentations.md)| Object to be created. | 
 **instrumentationId** | **long?**| Id of the instrumentation | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createinstrumentation"></a>
# **CreateInstrumentation**
> InstrumentationResponse CreateInstrumentation (InstrumentationRequest body)

Create a new instrumentation

Create a new instrumentation. The tag of the given instrumentation needs to be unique within its parent. The instrumentation will not be created when this constraint is violated.  To assign a parent instrumentation the user needs `can_permit` permission on the parent.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new InstrumentationRequest(); // InstrumentationRequest | Instrumentation object that needs to be created. tag, instrumentation status and instrumentation type are required

            try
            {
                // Create a new instrumentation
                InstrumentationResponse result = apiInstance.CreateInstrumentation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.CreateInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationRequest**](InstrumentationRequest.md)| Instrumentation object that needs to be created. tag, instrumentation status and instrumentation type are required | 

### Return type

[**InstrumentationResponse**](InstrumentationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createinstrumentationthreshold"></a>
# **CreateInstrumentationThreshold**
> ThresholdResponse CreateInstrumentationThreshold (ThresholdRequest body, long? instrumentationId)

Create an instrumentation threshold

Create a new instrumentation threshold. This action requires ```can_udpate``` permission on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateInstrumentationThresholdExample
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

            var apiInstance = new InstrumentationApi();
            var body = new ThresholdRequest(); // ThresholdRequest | Object body that will be created.
            var instrumentationId = 789;  // long? | Id of the specified instrumentation

            try
            {
                // Create an instrumentation threshold
                ThresholdResponse result = apiInstance.CreateInstrumentationThreshold(body, instrumentationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.CreateInstrumentationThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThresholdRequest**](ThresholdRequest.md)| Object body that will be created. | 
 **instrumentationId** | **long?**| Id of the specified instrumentation | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteinstrumentation"></a>
# **DeleteInstrumentation**
> void DeleteInstrumentation (long? id)

Delete an instrumentation

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
    public class DeleteInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var id = 789;  // long? | Id of the instrumentation to delete

            try
            {
                // Delete an instrumentation
                apiInstance.DeleteInstrumentation(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.DeleteInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the instrumentation to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteinstrumentationpicture"></a>
# **DeleteInstrumentationPicture**
> void DeleteInstrumentationPicture (long? instrumentationId, long? id)

Delete an instrumentation picture

Delete an instrumentation picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteInstrumentationPictureExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation picture

            try
            {
                // Delete an instrumentation picture
                apiInstance.DeleteInstrumentationPicture(instrumentationId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.DeleteInstrumentationPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation picture | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteinstrumentationthreshold"></a>
# **DeleteInstrumentationThreshold**
> void DeleteInstrumentationThreshold (long? instrumentationId, long? id)

Delete an instrumentation threshold.

Delete an instrumentation threshold.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteInstrumentationThresholdExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation threshold

            try
            {
                // Delete an instrumentation threshold.
                apiInstance.DeleteInstrumentationThreshold(instrumentationId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.DeleteInstrumentationThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation threshold | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloadinstrumentationpicture"></a>
# **DownloadInstrumentationPicture**
> void DownloadInstrumentationPicture (long? instrumentationId, long? id)

Download an instrumentation picture

Download an instrumentation picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DownloadInstrumentationPictureExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation picture

            try
            {
                // Download an instrumentation picture
                apiInstance.DownloadInstrumentationPicture(instrumentationId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.DownloadInstrumentationPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation picture | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetsofinstrumentation"></a>
# **GetAssetsOfInstrumentation**
> AssetsResponse GetAssetsOfInstrumentation (long? instrumentationId, int? page = null, int? perPage = null, string include = null, string serialNumber = null, string productId = null, string productCategoryId = null, string parentId = null, string manufacturerId = null, string statusId = null, string statusCode = null, string tenantId = null, DateTime? productionDate = null, DateTime? productionDateFrom = null, DateTime? productionDateTo = null, string specificationsKey = null, string specificationsValue = null, string nodeId = null, DateTime? createdAt = null, string createdAtFrom = null, string createdAtTo = null, DateTime? updatedAt = null, string updatedAtFrom = null, string updatedAtTo = null, bool? ownershipClaimed = null, string permission = null, string orderBy = null)

Get all assets of one instrumentation

Returns a list of all assets that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```status, tenant, parent, pictures, product, product.manufacturer, product.pictures, product.status, product.categories, product.categories.parent, specifications, specifications[key1,key2], product.tenant,                             product.manufacturer.tenant, status.tenant, instrumentations ```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var serialNumber = serialNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productId = productId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var productCategoryId = productCategoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusCode = statusCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var productionDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var nodeId = nodeId_example;  // string | One or multiple ids (comma list). Filter acccepts \"null\" for all objects with no nodes assigned or \"!null\" for any assigned node (optional) 
            var createdAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var createdAtTo = createdAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var updatedAtFrom = updatedAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = updatedAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var ownershipClaimed = true;  // bool? | Filter accepts true or false (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `serial_number`, `created_at` or `updated_at`, `last_seen_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all assets of one instrumentation
                AssetsResponse result = apiInstance.GetAssetsOfInstrumentation(instrumentationId, page, perPage, include, serialNumber, productId, productCategoryId, parentId, manufacturerId, statusId, statusCode, tenantId, productionDate, productionDateFrom, productionDateTo, specificationsKey, specificationsValue, nodeId, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, ownershipClaimed, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetAssetsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **serialNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **productCategoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **productionDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **nodeId** | **string**| One or multiple ids (comma list). Filter acccepts \&quot;null\&quot; for all objects with no nodes assigned or \&quot;!null\&quot; for any assigned node | [optional] 
 **createdAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **createdAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **createdAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **updatedAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **ownershipClaimed** | **bool?**| Filter accepts true or false | [optional] 
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;serial_number&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, &#x60;last_seen_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**AssetsResponse**](AssetsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetsofinstrumentationhistory"></a>
# **GetAssetsOfInstrumentationHistory**
> InstrumentationAssetsHistoryResponse GetAssetsOfInstrumentationHistory (long? instrumentationId, int? page = null, int? perPage = null, string assetId = null, string _event = null, DateTime? eventDatetimeFrom = null, DateTime? eventDatetimeTo = null, string orderBy = null)

Get all assets an instrumentation was assigned to

Returns a list of all assets history available in your scope which have been assigned to the specified instrumentation. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetsOfInstrumentationHistoryExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var assetId = assetId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var _event = _event_example;  // string | Filter accepts `create` or `destroy` (optional) 
            var eventDatetimeFrom = 2013-10-20;  // DateTime? | Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var eventDatetimeTo = 2013-10-20;  // DateTime? | Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `event` or `event_datetime`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get all assets an instrumentation was assigned to
                InstrumentationAssetsHistoryResponse result = apiInstance.GetAssetsOfInstrumentationHistory(instrumentationId, page, perPage, assetId, _event, eventDatetimeFrom, eventDatetimeTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetAssetsOfInstrumentationHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **assetId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **_event** | **string**| Filter accepts &#x60;create&#x60; or &#x60;destroy&#x60; | [optional] 
 **eventDatetimeFrom** | **DateTime?**| Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **eventDatetimeTo** | **DateTime?**| Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;event&#x60; or &#x60;event_datetime&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**InstrumentationAssetsHistoryResponse**](InstrumentationAssetsHistoryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbillofmaterialsofinstrumentation"></a>
# **GetBillOfMaterialsOfInstrumentation**
> BillOfMaterialsResponse GetBillOfMaterialsOfInstrumentation (long? instrumentationId, int? page = null, int? perPage = null, string name = null, string author = null, string date = null, string dateFrom = null, string dateTo = null)

Get all bill of materials of an instrumentation

Returns a list of all bill of materials that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetBillOfMaterialsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var author = author_example;  // string | Filter accepts `*` as wildcard (optional) 
            var date = date_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateFrom = dateFrom_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateTo = dateTo_example;  // string | Expected date format is YYYY-MM-DD (optional) 

            try
            {
                // Get all bill of materials of an instrumentation
                BillOfMaterialsResponse result = apiInstance.GetBillOfMaterialsOfInstrumentation(instrumentationId, page, perPage, name, author, date, dateFrom, dateTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetBillOfMaterialsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **author** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **date** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateFrom** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateTo** | **string**| Expected date format is YYYY-MM-DD | [optional] 

### Return type

[**BillOfMaterialsResponse**](BillOfMaterialsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdocumentsofinstrumentation"></a>
# **GetDocumentsOfInstrumentation**
> DocumentsResponse GetDocumentsOfInstrumentation (long? instrumentationId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string acceptLanguage = null)

Get all documents of an instrumentation

Returns a list of documents. If the query has no matches, the response is an empty list.  Possible include values: ```status, tenant, classification, categories, categories.parent, categories.standards, attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var documentVersion = documentVersion_example;  // string | Filter accepts `*` as wildcard (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var classificationId = classificationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var validFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntil = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD or YYYY-MM or YYYY (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all documents of an instrumentation
                DocumentsResponse result = apiInstance.GetDocumentsOfInstrumentation(instrumentationId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetDocumentsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **documentVersion** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **classificationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **validFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntil** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validAt** | **DateTime?**| Expected date format is YYYY-MM-DD or YYYY-MM or YYYY | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**DocumentsResponse**](DocumentsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="geteventsofinstrumentation"></a>
# **GetEventsOfInstrumentation**
> EventsResponse GetEventsOfInstrumentation (long? instrumentationId, int? page = null, int? perPage = null, string include = null, string name = null, string typeId = null, string statusId = null, string startDatetime = null, string startDatetimeFrom = null, string startDatetimeTo = null, string endDatetime = null, DateTime? endDatetimeFrom = null, string endDatetimeTo = null, string tenantId = null, string orderBy = null)

Get all events of one instrumentation

Returns a list of all events belonging to an instrumentation in your accessible scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ``assets, instrumentations, status, type``

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetEventsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var startDatetime = startDatetime_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var startDatetimeFrom = startDatetimeFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var startDatetimeTo = startDatetimeTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var endDatetime = endDatetime_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var endDatetimeFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var endDatetimeTo = endDatetimeTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `start_datetime`, `end_datetime`, `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all events of one instrumentation
                EventsResponse result = apiInstance.GetEventsOfInstrumentation(instrumentationId, page, perPage, include, name, typeId, statusId, startDatetime, startDatetimeFrom, startDatetimeTo, endDatetime, endDatetimeFrom, endDatetimeTo, tenantId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetEventsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **startDatetime** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **startDatetimeFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **startDatetimeTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **endDatetime** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **endDatetimeFrom** | **DateTime?**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **endDatetimeTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;start_datetime&#x60;, &#x60;end_datetime&#x60;, &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**EventsResponse**](EventsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationbyid"></a>
# **GetInstrumentationById**
> InstrumentationResponse GetInstrumentationById (long? id, string include = null)

Get a single instrumentation

Get a specific instrumentation in your accessible scope, identified by the id in the URL.  Possible include values: ```specifications, specifications[key1,key2], pictures, tenant, parent, status, worst_asset_status, type, type.parent, type.tenant, values, values.unit, values.asset, values_in_preferred_units, values_in_preferred_units.unit, values_in_preferred_units.asset ``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationByIdExample
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

            var apiInstance = new InstrumentationApi();
            var id = 789;  // long? | Id of the instrumentation to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single instrumentation
                InstrumentationResponse result = apiInstance.GetInstrumentationById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the instrumentation to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**InstrumentationResponse**](InstrumentationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationidstatus"></a>
# **GetInstrumentationIdStatus**
> InstrumentationStatusResponse GetInstrumentationIdStatus (long? instrumentationId, string acceptLanguage = null)

Get the status of the specific instrumentation

Returns the status of the instrumentation. Needed if only permission on instrumentation but not on tenant. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationIdStatusExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the status of the specific instrumentation
                InstrumentationStatusResponse result = apiInstance.GetInstrumentationIdStatus(instrumentationId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationIdStatus: " + e.Message );
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

[**InstrumentationStatusResponse**](InstrumentationStatusResponse.md)

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

            var apiInstance = new InstrumentationApi();
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
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationIdType: " + e.Message );
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
<a name="getinstrumentationpicture"></a>
# **GetInstrumentationPicture**
> PictureResponse GetInstrumentationPicture (long? instrumentationId, long? id)

Get an instrumentation picture

Get a single picture of an instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationPictureExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation picture

            try
            {
                // Get an instrumentation picture
                PictureResponse result = apiInstance.GetInstrumentationPicture(instrumentationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationpictures"></a>
# **GetInstrumentationPictures**
> PicturesResponse GetInstrumentationPictures (long? id, int? width = null, int? widthFrom = null, int? widthTo = null, int? height = null, int? heightFrom = null, int? heightTo = null)

Get instrumentation pictures

Get all pictures of an instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationPicturesExample
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

            var apiInstance = new InstrumentationApi();
            var id = 789;  // long? | Id of the instrumentation
            var width = 56;  // int? | filter by width (optional) 
            var widthFrom = 56;  // int? | filter by width_from (optional) 
            var widthTo = 56;  // int? | filter by width_to (optional) 
            var height = 56;  // int? | filter by height (optional) 
            var heightFrom = 56;  // int? | filter by height_from (optional) 
            var heightTo = 56;  // int? | filter by height_to (optional) 

            try
            {
                // Get instrumentation pictures
                PicturesResponse result = apiInstance.GetInstrumentationPictures(id, width, widthFrom, widthTo, height, heightFrom, heightTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationPictures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the instrumentation | 
 **width** | **int?**| filter by width | [optional] 
 **widthFrom** | **int?**| filter by width_from | [optional] 
 **widthTo** | **int?**| filter by width_to | [optional] 
 **height** | **int?**| filter by height | [optional] 
 **heightFrom** | **int?**| filter by height_from | [optional] 
 **heightTo** | **int?**| filter by height_to | [optional] 

### Return type

[**PicturesResponse**](PicturesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationstatusesoptions"></a>
# **GetInstrumentationStatusesOptions**
> InstrumentationStatuses GetInstrumentationStatusesOptions (long? instrumentationId, int? page = null, int? perPage = null, string tenantId = null, string name = null, string code = null, string acceptLanguage = null)

Get all possible statuses of the specified instrumentation

Returns a list of all possible instrumentation statuses for the specified instrument. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationStatusesOptionsExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all possible statuses of the specified instrumentation
                InstrumentationStatuses result = apiInstance.GetInstrumentationStatusesOptions(instrumentationId, page, perPage, tenantId, name, code, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationStatusesOptions: " + e.Message );
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

[**InstrumentationStatuses**](InstrumentationStatuses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationthreshold"></a>
# **GetInstrumentationThreshold**
> ThresholdResponse GetInstrumentationThreshold (long? instrumentationId, long? id)

Get an instrumentation threshold

Get a single threshold of an instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationThresholdExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation threshold

            try
            {
                // Get an instrumentation threshold
                ThresholdResponse result = apiInstance.GetInstrumentationThreshold(instrumentationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation threshold | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationthresholds"></a>
# **GetInstrumentationThresholds**
> ThresholdsResponse GetInstrumentationThresholds (long? instrumentationId, string key = null, string thresholdType = null, string orderBy = null)

Get instrumentation thresholds

Get all thresholds of an instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationThresholdsExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var key = key_example;  // string | filter by key (optional) 
            var thresholdType = thresholdType_example;  // string | filter by type (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `name`, `key`, `threshold_type`, `notification`, `created_at`, `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get instrumentation thresholds
                ThresholdsResponse result = apiInstance.GetInstrumentationThresholds(instrumentationId, key, thresholdType, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationThresholds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **key** | **string**| filter by key | [optional] 
 **thresholdType** | **string**| filter by type | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;name&#x60;, &#x60;key&#x60;, &#x60;threshold_type&#x60;, &#x60;notification&#x60;, &#x60;created_at&#x60;, &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ThresholdsResponse**](ThresholdsResponse.md)

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

            var apiInstance = new InstrumentationApi();
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
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationTypesOptions: " + e.Message );
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
<a name="getinstrumentationvalueobjectsforkey"></a>
# **GetInstrumentationValueObjectsForKey**
> AssetKeyValueObjectsResponse GetInstrumentationValueObjectsForKey (long? instrumentationId, string key, int? page = null, int? perPage = null, string include = null, DateTime? from = null, DateTime? to = null, DateTime? datetime = null, string selector = null, string interval = null, string orderBy = null)

Get instrumentation value objects for a specific key.

Returns a collection of the history value objects of the value objects for the specified key. For a selected result of the value objects the filter parameters selector and interval are mandatory. With the filter parameters from, to or datetime, it is possible to receive the history of a defined time period. Possible include values: ```asset```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationValueObjectsForKeyExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var key = key_example;  // string | key for the instrumentation values
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var from = 2013-10-20;  // DateTime? | Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var to = 2013-10-20;  // DateTime? | End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var datetime = 2013-10-20;  // DateTime? | exact date for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var selector = selector_example;  // string | Supported selector methods are `first, last`. This value is mandatory if interval is defined. (optional) 
            var interval = interval_example;  // string | Interval which is used for the selector. The value is mandatory if selector is defined. Supported intervals are number of `s, m, h, d, w`. Example `3h`. (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `timestamp`, add `-` as a prefix for descending order. Default ordering is the order the values were entered in. (optional) 

            try
            {
                // Get instrumentation value objects for a specific key.
                AssetKeyValueObjectsResponse result = apiInstance.GetInstrumentationValueObjectsForKey(instrumentationId, key, page, perPage, include, from, to, datetime, selector, interval, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationValueObjectsForKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **key** | **string**| key for the instrumentation values | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **from** | **DateTime?**| Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **to** | **DateTime?**| End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **datetime** | **DateTime?**| exact date for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **selector** | **string**| Supported selector methods are &#x60;first, last&#x60;. This value is mandatory if interval is defined. | [optional] 
 **interval** | **string**| Interval which is used for the selector. The value is mandatory if selector is defined. Supported intervals are number of &#x60;s, m, h, d, w&#x60;. Example &#x60;3h&#x60;. | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;timestamp&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default ordering is the order the values were entered in. | [optional] 

### Return type

[**AssetKeyValueObjectsResponse**](AssetKeyValueObjectsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationvalues"></a>
# **GetInstrumentationValues**
> AssetValuesResponse GetInstrumentationValues (long? instrumentationId, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, string key = null, string keyUnitId = null, string group = null)

Get latest values for the instrumentation.

Returns a collection of the latest values for all keys of the instrumentation. Possible include values: ```unit, asset```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationValuesExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter key_unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var key = key_example;  // string | only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. (optional) 
            var keyUnitId = keyUnitId_example;  // string | value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is `key[unit_id]`. Multiple values can be provided in a comma seperated list. (optional) 
            var group = group_example;  // string | Group of the asset value. (optional) 

            try
            {
                // Get latest values for the instrumentation.
                AssetValuesResponse result = apiInstance.GetInstrumentationValues(instrumentationId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter key_unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **key** | **string**| only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. | [optional] 
 **keyUnitId** | **string**| value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is &#x60;key[unit_id]&#x60;. Multiple values can be provided in a comma seperated list. | [optional] 
 **group** | **string**| Group of the asset value. | [optional] 

### Return type

[**AssetValuesResponse**](AssetValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationvaluesforkey"></a>
# **GetInstrumentationValuesForKey**
> AssetKeyValuesResponse GetInstrumentationValuesForKey (long? instrumentationId, string key, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, DateTime? from = null, DateTime? to = null, int? unitId = null, string aggregation = null, string interval = null, string orderBy = null)

Get instrumentation values for a specific key.

Returns a collection of the history values of an values for the specified key. For a aggregated result of the values the filter parameters aggregation and interval are mandatory. Receiving the result in a specific unit please use the filter parameter unit. The allowed units can be found in the intro section. With the filter parameters from to it is possible to receive the history of a defined time period. Possible include values: ```unit```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationValuesForKeyExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var key = key_example;  // string | key for the instrumentation values
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page, default value is 500, maximum is 1000 (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var from = 2013-10-20;  // DateTime? | Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var to = 2013-10-20;  // DateTime? | End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var unitId = 56;  // int? | Id of the unit in which the values are to be returned. (optional) 
            var aggregation = aggregation_example;  // string | Supported aggregation methods are `mean, min, max, sum, stddev`. This value is mandatory if interval is defined. (optional) 
            var interval = interval_example;  // string | Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of `s, m, h, d, w`. Example `3h`. (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `timestamp`, add `-` as a prefix for descending order. Default ordering is the order the values were entered in. (optional) 

            try
            {
                // Get instrumentation values for a specific key.
                AssetKeyValuesResponse result = apiInstance.GetInstrumentationValuesForKey(instrumentationId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentationValuesForKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **key** | **string**| key for the instrumentation values | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page, default value is 500, maximum is 1000 | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not, for the instrumentation the mapping will result from the merge of all its assets mappings. These values have lower precedence than the parameter unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
 **from** | **DateTime?**| Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **to** | **DateTime?**| End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **unitId** | **int?**| Id of the unit in which the values are to be returned. | [optional] 
 **aggregation** | **string**| Supported aggregation methods are &#x60;mean, min, max, sum, stddev&#x60;. This value is mandatory if interval is defined. | [optional] 
 **interval** | **string**| Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of &#x60;s, m, h, d, w&#x60;. Example &#x60;3h&#x60;. | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;timestamp&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default ordering is the order the values were entered in. | [optional] 

### Return type

[**AssetKeyValuesResponse**](AssetKeyValuesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentations"></a>
# **GetInstrumentations**
> InstrumentationsResponse GetInstrumentations (int? page = null, int? perPage = null, string include = null, string tag = null, string statusId = null, string typeId = null, string parentId = null, string tenantId = null, string specificationsKey = null, string specificationsValue = null, string criticality = null, string accessibility = null, string nodeId = null, string assetId = null, string systemId = null, string assetStatusId = null, string permission = null, string orderBy = null)

Get a range of instrumentations

Returns a list of instrumentations in your accessible scope. If the query has no matches, the response is an empty list.  Possible include values: ```specifications, specifications[key1,key2], pictures, tenant, parent, status, worst_asset_status, type, type.tenant, type.parent, values, values.unit, values_in_preferred_units, values_in_preferred_units.unit``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationsExample
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

            var apiInstance = new InstrumentationApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var tag = tag_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var criticality = criticality_example;  // string | Filter accepts undefined, low, medium or high (optional) 
            var accessibility = accessibility_example;  // string | Filter accepts undefined, easy, moderate or difficult (optional) 
            var nodeId = nodeId_example;  // string | One or multiple ids (comma list). Filter acccepts \"null\" for all objects with no nodes assigned or \"!null\" for any assigned node.  By adding `+` after the id, the filter considers the given node and all its sub components but this is not usable in combination with a comma list. (optional) 
            var assetId = assetId_example;  // string | One or multiple ids (comma list). Filter acccepts \"null\" for all objects with no assets assigned or \"!null\" for any assigned asset (optional) 
            var systemId = systemId_example;  // string | One or multiple ids (comma list). Filter accepts \"null\" for all objects with no systems assigned or \"!null\" for any assigned system (optional) 
            var assetStatusId = assetStatusId_example;  // string | One or multiple ids (comma list). Expected id format is integer. This retrieves all Instrumentations where at least one of its assets has one of the given statuses. (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `tag`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of instrumentations
                InstrumentationsResponse result = apiInstance.GetInstrumentations(page, perPage, include, tag, statusId, typeId, parentId, tenantId, specificationsKey, specificationsValue, criticality, accessibility, nodeId, assetId, systemId, assetStatusId, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetInstrumentations: " + e.Message );
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
 **tag** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **criticality** | **string**| Filter accepts undefined, low, medium or high | [optional] 
 **accessibility** | **string**| Filter accepts undefined, easy, moderate or difficult | [optional] 
 **nodeId** | **string**| One or multiple ids (comma list). Filter acccepts \&quot;null\&quot; for all objects with no nodes assigned or \&quot;!null\&quot; for any assigned node.  By adding &#x60;+&#x60; after the id, the filter considers the given node and all its sub components but this is not usable in combination with a comma list. | [optional] 
 **assetId** | **string**| One or multiple ids (comma list). Filter acccepts \&quot;null\&quot; for all objects with no assets assigned or \&quot;!null\&quot; for any assigned asset | [optional] 
 **systemId** | **string**| One or multiple ids (comma list). Filter accepts \&quot;null\&quot; for all objects with no systems assigned or \&quot;!null\&quot; for any assigned system | [optional] 
 **assetStatusId** | **string**| One or multiple ids (comma list). Expected id format is integer. This retrieves all Instrumentations where at least one of its assets has one of the given statuses. | [optional] 
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;tag&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**InstrumentationsResponse**](InstrumentationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnodesofinstrumentation"></a>
# **GetNodesOfInstrumentation**
> NodesResponse GetNodesOfInstrumentation (long? instrumentationId, int? page = null, int? perPage = null, string include = null, string name = null, string typeId = null, string parentId = null, string tenantId = null, bool? hidden = null, string permission = null, string orderBy = null)

Get all nodes of one Instrumentation

Returns a list of all nodes that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetNodesOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var hidden = true;  // bool? | Filter accepts true or false (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all nodes of one Instrumentation
                NodesResponse result = apiInstance.GetNodesOfInstrumentation(instrumentationId, page, perPage, include, name, typeId, parentId, tenantId, hidden, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetNodesOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **hidden** | **bool?**| Filter accepts true or false | [optional] 
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**NodesResponse**](NodesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationhistoryofinstrumentation"></a>
# **GetSpecificationHistoryOfInstrumentation**
> SpecificationHistoryResponse GetSpecificationHistoryOfInstrumentation (long? instrumentationId, string key, int? page = null, int? perPage = null, DateTime? sourceTimestampFrom = null, DateTime? sourceTimestampTo = null, DateTime? updatedAtFrom = null, DateTime? updatedAtTo = null, string orderBy = null)

Get the history of one specification attribute of an instrumentation.

This might be useful for history data. The response contains a collection of historic values and when they`ve been updated. Since this can be a lot of data the service uses pagination. The history can be filtered by using a date range of source_timestamp and/or updated_at. Please consider that source_timestamp is not required and update on the attribute without giving a source_timestamp wont be included in the resulting response

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationHistoryOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the specified instrumentation
            var key = key_example;  // string | the exact key
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var sourceTimestampFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var sourceTimestampTo = 2013-10-20T19:20:30+01:00;  // DateTime? | source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = 2013-10-20T19:20:30+01:00;  // DateTime? | updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `source_timestamp` or `updated_at`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get the history of one specification attribute of an instrumentation.
                SpecificationHistoryResponse result = apiInstance.GetSpecificationHistoryOfInstrumentation(instrumentationId, key, page, perPage, sourceTimestampFrom, sourceTimestampTo, updatedAtFrom, updatedAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetSpecificationHistoryOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the specified instrumentation | 
 **key** | **string**| the exact key | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **sourceTimestampFrom** | **DateTime?**| source_timestamp filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **sourceTimestampTo** | **DateTime?**| source_timestamp filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtFrom** | **DateTime?**| updated_at filter from. Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **DateTime?**| updated_at filter to. Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;source_timestamp&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**SpecificationHistoryResponse**](SpecificationHistoryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationkeysofinstrumentations"></a>
# **GetSpecificationKeysOfInstrumentations**
> SpecificationKeys GetSpecificationKeysOfInstrumentations (string key = null, bool? uiVisible = null)

Get existing instrumentation specification keys

Returns the existing specification keys in all readable instrumentations.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationKeysOfInstrumentationsExample
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

            var apiInstance = new InstrumentationApi();
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get existing instrumentation specification keys
                SpecificationKeys result = apiInstance.GetSpecificationKeysOfInstrumentations(key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetSpecificationKeysOfInstrumentations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationKeys**](SpecificationKeys.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofinstrumentation"></a>
# **GetSpecificationsOfInstrumentation**
> SpecificationsUIVisibleResponse GetSpecificationsOfInstrumentation (long? instrumentationId, string key = null, bool? uiVisible = null)

Get specifications of an instrumentation

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
    public class GetSpecificationsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | Id of the specified instrumentation
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get specifications of an instrumentation
                SpecificationsUIVisibleResponse result = apiInstance.GetSpecificationsOfInstrumentation(instrumentationId, key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetSpecificationsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| Id of the specified instrumentation | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationsUIVisibleResponse**](SpecificationsUIVisibleResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsystemsofinstrumentation"></a>
# **GetSystemsOfInstrumentation**
> SystemsResponse GetSystemsOfInstrumentation (long? instrumentationId, int? page = null, int? perPage = null, string include = null, string name = null, string statusId = null, string typeId = null, string tenantId = null, string specificationsKey = null, string specificationsValue = null, string permission = null, string orderBy = null)

Get all systems of one instrumentation

Returns a list of all systems that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```pictures, specifications, specifications[key1,key2], tenant, parent, status, type, type.tenant, type.parent ```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSystemsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var instrumentationId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all systems of one instrumentation
                SystemsResponse result = apiInstance.GetSystemsOfInstrumentation(instrumentationId, page, perPage, include, name, statusId, typeId, tenantId, specificationsKey, specificationsValue, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.GetSystemsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentationId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**SystemsResponse**](SystemsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeassetsfrominstrumentation"></a>
# **RemoveAssetsFromInstrumentation**
> void RemoveAssetsFromInstrumentation (AssetIDs body, long? instrumentationId)

Remove assets from an instrumentation

Remove one or more assets from an instrumentation in your accessible scope. This action requires `can_permit` permission on the instrumentation and on the asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveAssetsFromInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be removed.
            var instrumentationId = 789;  // long? | Id of the instrumentation from which the assets will be removed

            try
            {
                // Remove assets from an instrumentation
                apiInstance.RemoveAssetsFromInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.RemoveAssetsFromInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be removed. | 
 **instrumentationId** | **long?**| Id of the instrumentation from which the assets will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removebillofmaterialsfrominstrumentation"></a>
# **RemoveBillOfMaterialsFromInstrumentation**
> void RemoveBillOfMaterialsFromInstrumentation (BillOfMaterialIDs body, long? instrumentationId)

Remove bill of materials from an instrumentation

Remove one or more bill of materials from an instrumentation in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveBillOfMaterialsFromInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new BillOfMaterialIDs(); // BillOfMaterialIDs | Resources that shall be removed.
            var instrumentationId = 789;  // long? | Id of the instrumentation from which the bill of materials will be removed

            try
            {
                // Remove bill of materials from an instrumentation
                apiInstance.RemoveBillOfMaterialsFromInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.RemoveBillOfMaterialsFromInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfMaterialIDs**](BillOfMaterialIDs.md)| Resources that shall be removed. | 
 **instrumentationId** | **long?**| Id of the instrumentation from which the bill of materials will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removedocumentsfrominstrumentation"></a>
# **RemoveDocumentsFromInstrumentation**
> void RemoveDocumentsFromInstrumentation (DocumentIDs body, long? instrumentationId)

Remove documents from an instrumentation

Remove one or more documents from an instrumentation. This action requires `can_update` permission on the instrumentation and `can_read` permission on the document.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDocumentsFromInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be removed.
            var instrumentationId = 789;  // long? | Id of the instrumentation from which the documents will be removed

            try
            {
                // Remove documents from an instrumentation
                apiInstance.RemoveDocumentsFromInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.RemoveDocumentsFromInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be removed. | 
 **instrumentationId** | **long?**| Id of the instrumentation from which the documents will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeeventfrominstrumentation"></a>
# **RemoveEventFromInstrumentation**
> void RemoveEventFromInstrumentation (Events1 body, long? instrumentationId)

Remove events from an instrumentation

Remove one or more events from an instrumentation in your accessible scope. If the event has no more related instrumentations, the event will be deleted

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveEventFromInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new Events1(); // Events1 | Resources that shall be removed.
            var instrumentationId = 789;  // long? | Id of the instrumentation from which the events will removed.

            try
            {
                // Remove events from an instrumentation
                apiInstance.RemoveEventFromInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.RemoveEventFromInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Events1**](Events1.md)| Resources that shall be removed. | 
 **instrumentationId** | **long?**| Id of the instrumentation from which the events will removed. | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removenodesfrominstrumentation"></a>
# **RemoveNodesFromInstrumentation**
> void RemoveNodesFromInstrumentation (NodeIDs body, long? instrumentationId)

Remove nodes from an instrumentation

Remove one or more nodes from an instrumentation in your accessible scope. This action requires `can_permit` permission on the instrumentation and on the node.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveNodesFromInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new NodeIDs(); // NodeIDs | Resources that shall be removed.
            var instrumentationId = 789;  // long? | Id of the instrumentation from which the nodes will be removed

            try
            {
                // Remove nodes from an instrumentation
                apiInstance.RemoveNodesFromInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.RemoveNodesFromInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeIDs**](NodeIDs.md)| Resources that shall be removed. | 
 **instrumentationId** | **long?**| Id of the instrumentation from which the nodes will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfrominstrumentation"></a>
# **RemoveSpecificationsFromInstrumentation**
> void RemoveSpecificationsFromInstrumentation (List<string> body, long? instrumentationId)

Delete specifications of an instrumentation

The specification keys in the body will be removed of the object in your accessible scope. Multiple specification keys can be sent in the same request. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var instrumentationId = 789;  // long? | Id of the specified instrumentation

            try
            {
                // Delete specifications of an instrumentation
                apiInstance.RemoveSpecificationsFromInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.RemoveSpecificationsFromInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **instrumentationId** | **long?**| Id of the specified instrumentation | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofinstrumentation"></a>
# **RenameSpecificationsOfInstrumentation**
> void RenameSpecificationsOfInstrumentation (SpecificationsRename body, long? instrumentationId)

Rename a specification key

Rename one specification key of an instrumentation in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var instrumentationId = 789;  // long? | Id of the specified instrumentation

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.RenameSpecificationsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **instrumentationId** | **long?**| Id of the specified instrumentation | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceassetsofinstrumentation"></a>
# **ReplaceAssetsOfInstrumentation**
> void ReplaceAssetsOfInstrumentation (AssetIDs body, long? instrumentationId)

Replace the assets of an instrumentation

Replaces all assets belonging to an instrumentation. You can send a list of resources that will replace all previous values. This action requires `can_permit` permission on the instrumentation and on the asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceAssetsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be replaced
            var instrumentationId = 789;  // long? | Id of the instrumentation of which the assets will be replaced

            try
            {
                // Replace the assets of an instrumentation
                apiInstance.ReplaceAssetsOfInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.ReplaceAssetsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be replaced | 
 **instrumentationId** | **long?**| Id of the instrumentation of which the assets will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacebillofmaterialsofinstrumentation"></a>
# **ReplaceBillOfMaterialsOfInstrumentation**
> void ReplaceBillOfMaterialsOfInstrumentation (BillOfMaterialIDs body, long? instrumentationId)

Replace the bill of materials of an instrumentation

Replaces all bill of materials belonging to an instrumentation. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceBillOfMaterialsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new BillOfMaterialIDs(); // BillOfMaterialIDs | Resources that shall be replaced
            var instrumentationId = 789;  // long? | Id of the instrumentation of which the bill of materials will be replaced

            try
            {
                // Replace the bill of materials of an instrumentation
                apiInstance.ReplaceBillOfMaterialsOfInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.ReplaceBillOfMaterialsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfMaterialIDs**](BillOfMaterialIDs.md)| Resources that shall be replaced | 
 **instrumentationId** | **long?**| Id of the instrumentation of which the bill of materials will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedocumentsofinstrumentation"></a>
# **ReplaceDocumentsOfInstrumentation**
> void ReplaceDocumentsOfInstrumentation (DocumentIDs body, long? instrumentationId)

Replace the documents of an instrumentation

Replaces all documents belonging to an instrumentation. You can send a list of resources that will replace all previous values. This action requires `can_udpate` permission on the instrumentation and `can_read` permission on the document.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDocumentsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be replaced
            var instrumentationId = 789;  // long? | Id of the instrumentation of which the documents will be replaced

            try
            {
                // Replace the documents of an instrumentation
                apiInstance.ReplaceDocumentsOfInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.ReplaceDocumentsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be replaced | 
 **instrumentationId** | **long?**| Id of the instrumentation of which the documents will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacenodesofinstrumentation"></a>
# **ReplaceNodesOfInstrumentation**
> void ReplaceNodesOfInstrumentation (NodeIDs body, long? instrumentationId)

Replace the nodes of an instrumentation

Replaces all nodes belonging to an instrumentation in your accessible scope. You can send a list of resources that will replace all previous values. This action requires `can_permit` permission on the instrumentation and on the node.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceNodesOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new NodeIDs(); // NodeIDs | Resources that shall be replaced
            var instrumentationId = 789;  // long? | Id of the instrumentation of which the nodes will be replaced

            try
            {
                // Replace the nodes of an instrumentation
                apiInstance.ReplaceNodesOfInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.ReplaceNodesOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeIDs**](NodeIDs.md)| Resources that shall be replaced | 
 **instrumentationId** | **long?**| Id of the instrumentation of which the nodes will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateinstrumentation"></a>
# **UpdateInstrumentation**
> void UpdateInstrumentation (InstrumentationRequest body, long? id)

Update an instrumentation

Update accessible parameters of the requested resource in your accessible scope. To assign a parent instrumentation the user needs `can_permit` permission on the parent and on the current instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new InstrumentationRequest(); // InstrumentationRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the instrumentation to update

            try
            {
                // Update an instrumentation
                apiInstance.UpdateInstrumentation(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.UpdateInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationRequest**](InstrumentationRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the instrumentation to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateinstrumentationpicture"></a>
# **UpdateInstrumentationPicture**
> PictureResponse UpdateInstrumentationPicture (byte[] image, long? instrumentationId, long? id)

Update an instrumentation picture

Upload a new instrumentation picture. Check the file-storage quota. Allowed content-types are - image/gif - image/jpg - image/jpeg - image/png

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateInstrumentationPictureExample
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

            var apiInstance = new InstrumentationApi();
            var image = image_example;  // byte[] | 
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation picture

            try
            {
                // Update an instrumentation picture
                PictureResponse result = apiInstance.UpdateInstrumentationPicture(image, instrumentationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.UpdateInstrumentationPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateinstrumentationpicturelink"></a>
# **UpdateInstrumentationPictureLink**
> PictureResponse UpdateInstrumentationPictureLink (PictureLinkRequest body, long? instrumentationId, long? id)

Update an instrumentation picture link

Update an instrumentation picture link.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateInstrumentationPictureLinkExample
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

            var apiInstance = new InstrumentationApi();
            var body = new PictureLinkRequest(); // PictureLinkRequest | Picture link object to be updated
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation picture

            try
            {
                // Update an instrumentation picture link
                PictureResponse result = apiInstance.UpdateInstrumentationPictureLink(body, instrumentationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.UpdateInstrumentationPictureLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PictureLinkRequest**](PictureLinkRequest.md)| Picture link object to be updated | 
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateinstrumentationthreshold"></a>
# **UpdateInstrumentationThreshold**
> ThresholdResponse UpdateInstrumentationThreshold (ThresholdRequest body, long? instrumentationId, long? id)

Update an instrumentation threshold

Replaces the threshold belonging to an instrumentation. This action requires `can_update` permission on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateInstrumentationThresholdExample
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

            var apiInstance = new InstrumentationApi();
            var body = new ThresholdRequest(); // ThresholdRequest | Object body that will be updated.
            var instrumentationId = 789;  // long? | Id of the instrumentation
            var id = 789;  // long? | Id of the instrumentation threshold

            try
            {
                // Update an instrumentation threshold
                ThresholdResponse result = apiInstance.UpdateInstrumentationThreshold(body, instrumentationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.UpdateInstrumentationThreshold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThresholdRequest**](ThresholdRequest.md)| Object body that will be updated. | 
 **instrumentationId** | **long?**| Id of the instrumentation | 
 **id** | **long?**| Id of the instrumentation threshold | 

### Return type

[**ThresholdResponse**](ThresholdResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofinstrumentation"></a>
# **UpdateSpecificationsOfInstrumentation**
> void UpdateSpecificationsOfInstrumentation (Dictionary<string, SpecificationUIVisibleRequest> body, long? instrumentationId)

Update specifications of an instrumentation

Update the specification object of an instrumentation in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfInstrumentationExample
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

            var apiInstance = new InstrumentationApi();
            var body = new Dictionary<string, SpecificationUIVisibleRequest>(); // Dictionary<string, SpecificationUIVisibleRequest> | The specifications objects to patch.
            var instrumentationId = 789;  // long? | Id of the specified instrumentation

            try
            {
                // Update specifications of an instrumentation
                apiInstance.UpdateSpecificationsOfInstrumentation(body, instrumentationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.UpdateSpecificationsOfInstrumentation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationUIVisibleRequest&gt;**](Dictionary&lt;string, SpecificationUIVisibleRequest&gt;.md)| The specifications objects to patch. | 
 **instrumentationId** | **long?**| Id of the specified instrumentation | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadinstrumentationpicture"></a>
# **UploadInstrumentationPicture**
> PictureResponse UploadInstrumentationPicture (byte[] image, long? id)

Upload an instrumentation picture

Upload a new instrumentation picture. Checks the file-storage quota. Allowed content-types are - image/gif - image/jpg - image/jpeg - image/png

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UploadInstrumentationPictureExample
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

            var apiInstance = new InstrumentationApi();
            var image = image_example;  // byte[] | 
            var id = 789;  // long? | Id of the instrumentation

            try
            {
                // Upload an instrumentation picture
                PictureResponse result = apiInstance.UploadInstrumentationPicture(image, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentationApi.UploadInstrumentationPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **id** | **long?**| Id of the instrumentation | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
