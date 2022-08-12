# Netilion.Api.Api.AssetApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAddOnsToAsset**](AssetApi.md#addaddonstoasset) | **POST** /assets/{asset_id}/add_ons | Add add_ons to an asset
[**AddAssetPictureLink**](AssetApi.md#addassetpicturelink) | **POST** /assets/{id}/pictures/links | Add a link as asset picture
[**AddDeliveriesToAsset**](AssetApi.md#adddeliveriestoasset) | **POST** /assets/{asset_id}/deliveries | Add deliveries to an asset
[**AddDocumentsToAsset**](AssetApi.md#adddocumentstoasset) | **POST** /assets/{asset_id}/documents | Add documents to an asset
[**AddInstrumentationsToAsset**](AssetApi.md#addinstrumentationstoasset) | **POST** /assets/{asset_id}/instrumentations | Add instrumentations to an asset
[**AddNodesToAsset**](AssetApi.md#addnodestoasset) | **POST** /assets/{asset_id}/nodes | Add nodes to an asset
[**AddSoftwaresToAsset**](AssetApi.md#addsoftwarestoasset) | **POST** /assets/{asset_id}/softwares | Add software to an asset
[**CreateAsset**](AssetApi.md#createasset) | **POST** /assets | Create a new asset
[**CreateAssetContainer**](AssetApi.md#createassetcontainer) | **POST** /assets/{id}/containers | Create an export for a standard container
[**CreateAssetValueObjects**](AssetApi.md#createassetvalueobjects) | **POST** /assets/{asset_id}/value_objects | Create asset value objects
[**CreateAssetValues**](AssetApi.md#createassetvalues) | **POST** /assets/{asset_id}/values | Create asset values
[**CreateEventForAsset**](AssetApi.md#createeventforasset) | **POST** /assets/{asset_id}/events | Create a new event for an asset
[**DeleteAsset**](AssetApi.md#deleteasset) | **DELETE** /assets/{id} | Delete an asset
[**DeleteAssetPicture**](AssetApi.md#deleteassetpicture) | **DELETE** /assets/{asset_id}/pictures/{id} | Delete an asset picture
[**DeleteSpecificationsOfAsset**](AssetApi.md#deletespecificationsofasset) | **DELETE** /assets/{asset_id}/specifications | Delete specifications of an asset
[**DownloadAssetPicture**](AssetApi.md#downloadassetpicture) | **GET** /assets/{asset_id}/pictures/{id}/download | Download an asset picture
[**GetAddOnsOfAsset**](AssetApi.md#getaddonsofasset) | **GET** /assets/{asset_id}/add_ons | Get all add_ons of one asset
[**GetApiSubscriptionsOfAsset**](AssetApi.md#getapisubscriptionsofasset) | **GET** /assets/{asset_id}/api_subscriptions | Get all API subscriptions of the asset
[**GetAssetById**](AssetApi.md#getassetbyid) | **GET** /assets/{id} | Get a single asset
[**GetAssetCompanyOptions**](AssetApi.md#getassetcompanyoptions) | **GET** /assets/{asset_id}/company-options | Get all possible companies of the specified assets
[**GetAssetHistory**](AssetApi.md#getassethistory) | **GET** /assets/{asset_id}/history | Get the history of an asset
[**GetAssetIdStatus**](AssetApi.md#getassetidstatus) | **GET** /assets/{asset_id}/status | Get the status of the specific asset
[**GetAssetPicture**](AssetApi.md#getassetpicture) | **GET** /assets/{asset_id}/pictures/{id} | Get an asset picture
[**GetAssetPictures**](AssetApi.md#getassetpictures) | **GET** /assets/{id}/pictures | Get asset pictures
[**GetAssetProductOptions**](AssetApi.md#getassetproductoptions) | **GET** /assets/{asset_id}/product-options | Get all possible products of the specified assets
[**GetAssetStatusesOptions**](AssetApi.md#getassetstatusesoptions) | **GET** /assets/{asset_id}/status-options | Get all possible statuses of the specified assets
[**GetAssetTenantOptions**](AssetApi.md#getassettenantoptions) | **GET** /assets/{asset_id}/tenant-options | Get all possible tenants of the specified assets
[**GetAssetValueObjectsForKey**](AssetApi.md#getassetvalueobjectsforkey) | **GET** /assets/{asset_id}/value_objects/{key} | Get asset value objects for a specific key.
[**GetAssetValues**](AssetApi.md#getassetvalues) | **GET** /assets/{asset_id}/values | Get latest values for the asset.
[**GetAssetValuesForKey**](AssetApi.md#getassetvaluesforkey) | **GET** /assets/{asset_id}/values/{key} | Get asset values for a specific key.
[**GetAssets**](AssetApi.md#getassets) | **GET** /assets | Get a range of assets
[**GetDeliveriesOfAsset**](AssetApi.md#getdeliveriesofasset) | **GET** /assets/{asset_id}/deliveries | Get all deliveries of one asset
[**GetDocumentsOfAsset**](AssetApi.md#getdocumentsofasset) | **GET** /assets/{asset_id}/documents | Get all documents of an asset
[**GetEventsOfAsset**](AssetApi.md#geteventsofasset) | **GET** /assets/{asset_id}/events | Get all events of one asset
[**GetInstrumentationsOfAsset**](AssetApi.md#getinstrumentationsofasset) | **GET** /assets/{asset_id}/instrumentations | Get all instrumentations of one asset
[**GetInstrumentationsOfAssetHistory**](AssetApi.md#getinstrumentationsofassethistory) | **GET** /assets/{asset_id}/instrumentations/history | Get all instrumentations an asset was assigned to
[**GetNodesOfAsset**](AssetApi.md#getnodesofasset) | **GET** /assets/{asset_id}/nodes | Get all nodes of one asset
[**GetSoftwaresOfSoftware**](AssetApi.md#getsoftwaresofsoftware) | **GET** /assets/{asset_id}/softwares | Get a range of software of one asset
[**GetSpecificationHistoryOfAsset**](AssetApi.md#getspecificationhistoryofasset) | **GET** /assets/{asset_id}/specifications/{key}/history | Get the history of one specification attribute of an asset.
[**GetSpecificationKeysOfAssets**](AssetApi.md#getspecificationkeysofassets) | **GET** /asset/specification_keys | Get existing asset specification keys
[**GetSpecificationsOfAsset**](AssetApi.md#getspecificationsofasset) | **GET** /assets/{asset_id}/specifications | Get specifications of an asset
[**GetSubscriptionsOfAsset**](AssetApi.md#getsubscriptionsofasset) | **GET** /assets/{asset_id}/subscriptions | Get all subscriptions of asset
[**GetSystemsOfAsset**](AssetApi.md#getsystemsofasset) | **GET** /assets/{asset_id}/systems | Get all systems of one Asset
[**RemoveAddOnsFromAsset**](AssetApi.md#removeaddonsfromasset) | **DELETE** /assets/{asset_id}/add_ons | Remove add_ons from an asset
[**RemoveDeliveriesFromAsset**](AssetApi.md#removedeliveriesfromasset) | **DELETE** /assets/{asset_id}/deliveries | Remove deliveries from an asset
[**RemoveDocumentsFromAsset**](AssetApi.md#removedocumentsfromasset) | **DELETE** /assets/{asset_id}/documents | Remove documents from an asset
[**RemoveEventFromAsset**](AssetApi.md#removeeventfromasset) | **DELETE** /assets/{asset_id}/events | Remove events from an asset
[**RemoveInstrumentationsOfAsset**](AssetApi.md#removeinstrumentationsofasset) | **DELETE** /assets/{asset_id}/instrumentations | Remove instrumentations from an asset
[**RemoveNodesFromAsset**](AssetApi.md#removenodesfromasset) | **DELETE** /assets/{asset_id}/nodes | Remove nodes from an asset
[**RemoveSoftwaresOfAsset**](AssetApi.md#removesoftwaresofasset) | **DELETE** /assets/{asset_id}/softwares | Remove software from an asset
[**RenameSpecificationsOfAsset**](AssetApi.md#renamespecificationsofasset) | **PATCH** /assets/{asset_id}/specifications/rename | Rename a specification key
[**ReplaceAddOnsOfAsset**](AssetApi.md#replaceaddonsofasset) | **PATCH** /assets/{asset_id}/add_ons | Replace the add_ons of an asset
[**ReplaceDeliveriesOfAsset**](AssetApi.md#replacedeliveriesofasset) | **PATCH** /assets/{asset_id}/deliveries | Replace the deliveries of an asset
[**ReplaceDocumentsOfAsset**](AssetApi.md#replacedocumentsofasset) | **PATCH** /assets/{asset_id}/documents | Replace the documents of an asset
[**ReplaceInstrumentationsOfAsset**](AssetApi.md#replaceinstrumentationsofasset) | **PATCH** /assets/{asset_id}/instrumentations | Replace the instrumentations of an asset
[**ReplaceNodesOfAsset**](AssetApi.md#replacenodesofasset) | **PATCH** /assets/{asset_id}/nodes | Replace the nodes of an asset
[**ReplaceSoftwaresOfAsset**](AssetApi.md#replacesoftwaresofasset) | **PATCH** /assets/{asset_id}/softwares | Replace the software of an asset
[**UpdateAsset**](AssetApi.md#updateasset) | **PATCH** /assets/{id} | Update an asset
[**UpdateAssetPicture**](AssetApi.md#updateassetpicture) | **PATCH** /assets/{asset_id}/pictures/{id} | Update an asset picture
[**UpdateAssetPictureLink**](AssetApi.md#updateassetpicturelink) | **PATCH** /assets/{asset_id}/pictures/links/{id} | Update an asset picture link
[**UpdateSpecificationsOfAsset**](AssetApi.md#updatespecificationsofasset) | **PATCH** /assets/{asset_id}/specifications | Update specifications of an asset
[**UploadAssetPicture**](AssetApi.md#uploadassetpicture) | **POST** /assets/{id}/pictures | Upload an asset picture

<a name="addaddonstoasset"></a>
# **AddAddOnsToAsset**
> void AddAddOnsToAsset (AddOnIDs body, long? assetId)

Add add_ons to an asset

Add one or more add_ons to an asset. This action requires `can_permit` permission on the asset and on the add_on.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddAddOnsToAssetExample
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

            var apiInstance = new AssetApi();
            var body = new AddOnIDs(); // AddOnIDs | Resources that shall be added.
            var assetId = 789;  // long? | Id of the asset to which the add_ons will be added

            try
            {
                // Add add_ons to an asset
                apiInstance.AddAddOnsToAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AddAddOnsToAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddOnIDs**](AddOnIDs.md)| Resources that shall be added. | 
 **assetId** | **long?**| Id of the asset to which the add_ons will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addassetpicturelink"></a>
# **AddAssetPictureLink**
> PictureResponse AddAssetPictureLink (PictureLinkRequest body, long? id)

Add a link as asset picture

Add an external resource as asset picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddAssetPictureLinkExample
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

            var apiInstance = new AssetApi();
            var body = new PictureLinkRequest(); // PictureLinkRequest | Picture link object to be created
            var id = 789;  // long? | Id of the asset

            try
            {
                // Add a link as asset picture
                PictureResponse result = apiInstance.AddAssetPictureLink(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AddAssetPictureLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PictureLinkRequest**](PictureLinkRequest.md)| Picture link object to be created | 
 **id** | **long?**| Id of the asset | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adddeliveriestoasset"></a>
# **AddDeliveriesToAsset**
> void AddDeliveriesToAsset (DeliveryIDs body, long? assetId)

Add deliveries to an asset

Add one or more deliveries to an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDeliveriesToAssetExample
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

            var apiInstance = new AssetApi();
            var body = new DeliveryIDs(); // DeliveryIDs | Resources that shall be added.
            var assetId = 789;  // long? | Id of the asset to which the deliveries will be added

            try
            {
                // Add deliveries to an asset
                apiInstance.AddDeliveriesToAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AddDeliveriesToAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryIDs**](DeliveryIDs.md)| Resources that shall be added. | 
 **assetId** | **long?**| Id of the asset to which the deliveries will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adddocumentstoasset"></a>
# **AddDocumentsToAsset**
> void AddDocumentsToAsset (DocumentIDs body, long? assetId)

Add documents to an asset

Add one or more documents to an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDocumentsToAssetExample
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

            var apiInstance = new AssetApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be added.
            var assetId = 789;  // long? | Id of the asset to which the documents will be added

            try
            {
                // Add documents to an asset
                apiInstance.AddDocumentsToAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AddDocumentsToAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be added. | 
 **assetId** | **long?**| Id of the asset to which the documents will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addinstrumentationstoasset"></a>
# **AddInstrumentationsToAsset**
> void AddInstrumentationsToAsset (InstrumentationIDs body, long? assetId)

Add instrumentations to an asset

Add one or more instrumentations to an asset. This action requires `can_permit` permission on the asset and on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddInstrumentationsToAssetExample
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

            var apiInstance = new AssetApi();
            var body = new InstrumentationIDs(); // InstrumentationIDs | Resources that shall be added.
            var assetId = 789;  // long? | Id of the asset to which the instrumentations will be added

            try
            {
                // Add instrumentations to an asset
                apiInstance.AddInstrumentationsToAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AddInstrumentationsToAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationIDs**](InstrumentationIDs.md)| Resources that shall be added. | 
 **assetId** | **long?**| Id of the asset to which the instrumentations will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addnodestoasset"></a>
# **AddNodesToAsset**
> void AddNodesToAsset (NodeIDs body, long? assetId)

Add nodes to an asset

Add one or more nodes to an asset. This action requires `can_permit` permission on the asset and on the node.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddNodesToAssetExample
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

            var apiInstance = new AssetApi();
            var body = new NodeIDs(); // NodeIDs | Resources that shall be added.
            var assetId = 789;  // long? | Id of the asset to which the nodes will be added

            try
            {
                // Add nodes to an asset
                apiInstance.AddNodesToAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AddNodesToAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeIDs**](NodeIDs.md)| Resources that shall be added. | 
 **assetId** | **long?**| Id of the asset to which the nodes will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addsoftwarestoasset"></a>
# **AddSoftwaresToAsset**
> void AddSoftwaresToAsset (SoftwareIDs body, long? assetId)

Add software to an asset

Add one or more software to an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddSoftwaresToAssetExample
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

            var apiInstance = new AssetApi();
            var body = new SoftwareIDs(); // SoftwareIDs | Resources that shall be added.
            var assetId = 789;  // long? | Id of the asset to which the software will be added

            try
            {
                // Add software to an asset
                apiInstance.AddSoftwaresToAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AddSoftwaresToAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareIDs**](SoftwareIDs.md)| Resources that shall be added. | 
 **assetId** | **long?**| Id of the asset to which the software will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createasset"></a>
# **CreateAsset**
> AssetResponse CreateAsset (AssetRequest body)

Create a new asset

Create a new asset. An asset is an instance of a product and therefore needs to refer to one when creating it. The serialnumber of the given asset needs to be unique within the products manufacturer scope. The asset will not be created when this constraint is violated. The user gains `can_read`, `can_update`, `can_delete`, `can_permit` per default on the newly created asset. To assign a parent asset the user needs `can_permit` permission on the parent.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateAssetExample
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

            var apiInstance = new AssetApi();
            var body = new AssetRequest(); // AssetRequest | Asset object that needs to be created. serial_number, product are required

            try
            {
                // Create a new asset
                AssetResponse result = apiInstance.CreateAsset(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.CreateAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetRequest**](AssetRequest.md)| Asset object that needs to be created. serial_number, product are required | 

### Return type

[**AssetResponse**](AssetResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createassetcontainer"></a>
# **CreateAssetContainer**
> DataExportsResponse CreateAssetContainer (ContainerExportRequest body, long? id)

Create an export for a standard container

Creates a data export for asset container, currenty only the VDI 2770 standard is supported

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateAssetContainerExample
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

            var apiInstance = new AssetApi();
            var body = new ContainerExportRequest(); // ContainerExportRequest | Container that should be created.
            var id = 789;  // long? | Id of the asset

            try
            {
                // Create an export for a standard container
                DataExportsResponse result = apiInstance.CreateAssetContainer(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.CreateAssetContainer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContainerExportRequest**](ContainerExportRequest.md)| Container that should be created. | 
 **id** | **long?**| Id of the asset | 

### Return type

[**DataExportsResponse**](DataExportsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createassetvalueobjects"></a>
# **CreateAssetValueObjects**
> void CreateAssetValueObjects (AssetValueObjectsRequest body, long? assetId)

Create asset value objects

Store value objects measured by an asset. For performance reasons, this endpoint behaves somewhat differently than normal endpoints:  * The data passed to this endpoint is processed asynchronously. * This endpoint always returns an empty response with status 204 No Content. * The data will be validated during processing. Invalid data will be dropped silently. * The request size is limited to 500kb, requests larger then 500kb will get an \"413 Payload Too Large\" error.  Data validations and manipultation:    * Keys can only consist of the charaters [a-z A-Z 0-9 . - _ ].   * Keys will be converted to lower case strings.   * Keys must be between 1 and 128 characters long.   * The timestamp is not mandatory and will be set to the time the value was transmitted to the server (This only works if the value objects get transfered one at a time, if you send multiple value objects without timestamp at once, all value objects will get the same timestamp and there for only the last one will be stored)  Difference to path /assets/{asset_id}/values is that the values given here are json objects and not numeric values, the json objects can have any structure.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateAssetValueObjectsExample
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

            var apiInstance = new AssetApi();
            var body = new AssetValueObjectsRequest(); // AssetValueObjectsRequest | Values to store to an asset.
            var assetId = 789;  // long? | The resource defined in the URL

            try
            {
                // Create asset value objects
                apiInstance.CreateAssetValueObjects(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.CreateAssetValueObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetValueObjectsRequest**](AssetValueObjectsRequest.md)| Values to store to an asset. | 
 **assetId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createassetvalues"></a>
# **CreateAssetValues**
> void CreateAssetValues (AssetValuesRequest body, long? assetId)

Create asset values

Store values measured by an asset. For performance reasons, this endpoint behaves somewhat differently than normal endpoints:  * The data passed to this endpoint is processed asynchronously. * This endpoint always returns an empty response with status 204 No Content. * The data will be validated during processing. Invalid data will be dropped silently. * The request size is limited to 500kb, requests larger then 500kb will get an \"413 Payload Too Large\" error.  Data validations and manipultation:    * Keys and groups can only consist of the charaters [a-z A-Z 0-9 . - _ ].   * Keys and groups will be converted to lower case strings.   * Keys and groups must be between 1 and 128 characters long.   * Units can be passed as id or code. See the units endpoint for all available units.   * The timestamp is not mandatory and will be set to the time the value was transmitted to the server (This only works if the values get transfered one at a time, if you send multiple values without timestamp at once, all values will get the same timestamp and there for only the last one will be stored)

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateAssetValuesExample
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

            var apiInstance = new AssetApi();
            var body = new AssetValuesRequest(); // AssetValuesRequest | Values to store to an asset.
            var assetId = 789;  // long? | The resource defined in the URL

            try
            {
                // Create asset values
                apiInstance.CreateAssetValues(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.CreateAssetValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetValuesRequest**](AssetValuesRequest.md)| Values to store to an asset. | 
 **assetId** | **long?**| The resource defined in the URL | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createeventforasset"></a>
# **CreateEventForAsset**
> EventResponse CreateEventForAsset (EventRequestNoAssets body, long? assetId)

Create a new event for an asset

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
    public class CreateEventForAssetExample
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

            var apiInstance = new AssetApi();
            var body = new EventRequestNoAssets(); // EventRequestNoAssets | Object to be created.
            var assetId = 789;  // long? | Id of the asset

            try
            {
                // Create a new event for an asset
                EventResponse result = apiInstance.CreateEventForAsset(body, assetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.CreateEventForAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventRequestNoAssets**](EventRequestNoAssets.md)| Object to be created. | 
 **assetId** | **long?**| Id of the asset | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteasset"></a>
# **DeleteAsset**
> void DeleteAsset (long? id)

Delete an asset

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
    public class DeleteAssetExample
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

            var apiInstance = new AssetApi();
            var id = 789;  // long? | Id of the asset to delete

            try
            {
                // Delete an asset
                apiInstance.DeleteAsset(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.DeleteAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the asset to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteassetpicture"></a>
# **DeleteAssetPicture**
> void DeleteAssetPicture (long? assetId, long? id)

Delete an asset picture

Delete an asset picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteAssetPictureExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | Id of the asset
            var id = 789;  // long? | Id of the asset picture

            try
            {
                // Delete an asset picture
                apiInstance.DeleteAssetPicture(assetId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.DeleteAssetPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the asset | 
 **id** | **long?**| Id of the asset picture | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletespecificationsofasset"></a>
# **DeleteSpecificationsOfAsset**
> void DeleteSpecificationsOfAsset (List<string> body, long? assetId)

Delete specifications of an asset

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
    public class DeleteSpecificationsOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var assetId = 789;  // long? | Id of the specified asset

            try
            {
                // Delete specifications of an asset
                apiInstance.DeleteSpecificationsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.DeleteSpecificationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **assetId** | **long?**| Id of the specified asset | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloadassetpicture"></a>
# **DownloadAssetPicture**
> void DownloadAssetPicture (long? assetId, long? id)

Download an asset picture

Download an asset picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DownloadAssetPictureExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | Id of the asset
            var id = 789;  // long? | Id of the asset picture

            try
            {
                // Download an asset picture
                apiInstance.DownloadAssetPicture(assetId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.DownloadAssetPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the asset | 
 **id** | **long?**| Id of the asset picture | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getaddonsofasset"></a>
# **GetAddOnsOfAsset**
> AddOnsResponse GetAddOnsOfAsset (long? assetId, int? page = null, int? perPage = null, string name = null, string productCode = null, string materialNumber = null, string addOnType = null, string orderBy = null)

Get all add_ons of one asset

Returns a list of all add_ons that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAddOnsOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productCode = productCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var materialNumber = materialNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var addOnType = addOnType_example;  // string | Filter accepts addon or connectivity (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all add_ons of one asset
                AddOnsResponse result = apiInstance.GetAddOnsOfAsset(assetId, page, perPage, name, productCode, materialNumber, addOnType, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAddOnsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **materialNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **addOnType** | **string**| Filter accepts addon or connectivity | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**AddOnsResponse**](AddOnsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapisubscriptionsofasset"></a>
# **GetApiSubscriptionsOfAsset**
> APISubscriptionResponse GetApiSubscriptionsOfAsset (long? assetId, int? page = null, int? perPage = null, string include = null, long? userId = null, long? clientApplicationId = null, string externalReference = null, string status = null, string notificationStatus = null, string specificationsKey = null, string specificationsValue = null, DateTime? startDate = null, DateTime? endDate = null, string orderBy = null)

Get all API subscriptions of the asset

Returns a list of all API subscriptions that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```user, user.usage, specifications, specifications[key1,key2]``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetApiSubscriptionsOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var userId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var clientApplicationId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var externalReference = externalReference_example;  // string | Filter accepts `*` as wildcard (optional) 
            var status = status_example;  // string | Filter by status - no wildcard support (optional) 
            var notificationStatus = notificationStatus_example;  // string | Filter by notification status - no wildcard support (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var startDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var endDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all API subscriptions of the asset
                APISubscriptionResponse result = apiInstance.GetApiSubscriptionsOfAsset(assetId, page, perPage, include, userId, clientApplicationId, externalReference, status, notificationStatus, specificationsKey, specificationsValue, startDate, endDate, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetApiSubscriptionsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **userId** | **long?**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **clientApplicationId** | **long?**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **externalReference** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **status** | **string**| Filter by status - no wildcard support | [optional] 
 **notificationStatus** | **string**| Filter by notification status - no wildcard support | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **startDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **endDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**APISubscriptionResponse**](APISubscriptionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetbyid"></a>
# **GetAssetById**
> AssetResponse GetAssetById (long? id, string include = null)

Get a single asset

Get a specific asset identified by the id in the URL. Possible include values: ```status, tenant, parent, pictures, values, values.unit, values_in_preferred_units, values_in_preferred_units.unit, product, product.manufacturer, product.pictures, product.status, product.categories, product.categories.parent, product.tenant, product.manufacturer.tenant, status.tenant, instrumentations, systems, systems.recipe,  systems.specifications, systems.batches_in_execution, specifications, specifications[key1,key2], product.specifications, product.specifications[key1,key2], instrumentations.specifications, instrumentations.specifications[key1,key2] add_ons```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetByIdExample
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

            var apiInstance = new AssetApi();
            var id = 789;  // long? | Id of the asset to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single asset
                AssetResponse result = apiInstance.GetAssetById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the asset to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**AssetResponse**](AssetResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetcompanyoptions"></a>
# **GetAssetCompanyOptions**
> Companies GetAssetCompanyOptions (long? assetId, int? page = null, int? perPage = null, string include = null, string name = null, string tenantId = null, string orderBy = null)

Get all possible companies of the specified assets

Returns a list of all possible companies for the specified asset. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```tenant, parent```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetCompanyOptionsExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | Id of the specified asset
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all possible companies of the specified assets
                Companies result = apiInstance.GetAssetCompanyOptions(assetId, page, perPage, include, name, tenantId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetCompanyOptions: " + e.Message );
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
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**Companies**](Companies.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassethistory"></a>
# **GetAssetHistory**
> AssetHistoryResponse GetAssetHistory (long? assetId, string attribute = null, DateTime? from = null, DateTime? to = null, string orderBy = null)

Get the history of an asset

Returns a collection of historical values of the asset identified by the id in the URL. Specifications are not included.   With the filter parameters from and to, it is possible to receive the history of a defined time period   Define the from with a ```+``` in front of the date the previous values is part of the collection (+2018-06-21T14:45:23).   Define the to with a ```+``` at the end of the date the next values is part of the collection (2018-06-21T14:45:23+).

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetHistoryExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var attribute = attribute_example;  // string | limit history to changes of a specific attribute e.g status or serial_number (optional) 
            var from = 2013-10-20;  // DateTime? | Start date filter for history values. Starting with ```+``` will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var to = 2013-10-20;  // DateTime? | End date for history values. Ending with ```+``` will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `datetime`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get the history of an asset
                AssetHistoryResponse result = apiInstance.GetAssetHistory(assetId, attribute, from, to, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **attribute** | **string**| limit history to changes of a specific attribute e.g status or serial_number | [optional] 
 **from** | **DateTime?**| Start date filter for history values. Starting with &#x60;&#x60;&#x60;+&#x60;&#x60;&#x60; will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **to** | **DateTime?**| End date for history values. Ending with &#x60;&#x60;&#x60;+&#x60;&#x60;&#x60; will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;datetime&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**AssetHistoryResponse**](AssetHistoryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetidstatus"></a>
# **GetAssetIdStatus**
> AssetStatusResponse GetAssetIdStatus (long? assetId, string include = null, string acceptLanguage = null)

Get the status of the specific asset

Returns the status of the asset. Needed if only permission on asset but not on tenant. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetIdStatusExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | Id of the specified asset
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the status of the specific asset
                AssetStatusResponse result = apiInstance.GetAssetIdStatus(assetId, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetIdStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the specified asset | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**AssetStatusResponse**](AssetStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetpicture"></a>
# **GetAssetPicture**
> PictureResponse GetAssetPicture (long? assetId, long? id)

Get an asset picture

Get a single picture of an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetPictureExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | Id of the asset
            var id = 789;  // long? | Id of the asset picture

            try
            {
                // Get an asset picture
                PictureResponse result = apiInstance.GetAssetPicture(assetId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the asset | 
 **id** | **long?**| Id of the asset picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetpictures"></a>
# **GetAssetPictures**
> PicturesResponse GetAssetPictures (long? id, int? width = null, int? widthFrom = null, int? widthTo = null, int? height = null, int? heightFrom = null, int? heightTo = null, string orderBy = null)

Get asset pictures

Get all pictures of an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetPicturesExample
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

            var apiInstance = new AssetApi();
            var id = 789;  // long? | Id of the asset
            var width = 56;  // int? | filter by width (optional) 
            var widthFrom = 56;  // int? | filter by width_from (optional) 
            var widthTo = 56;  // int? | filter by width_to (optional) 
            var height = 56;  // int? | filter by height (optional) 
            var heightFrom = 56;  // int? | filter by height_from (optional) 
            var heightTo = 56;  // int? | filter by height_to (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get asset pictures
                PicturesResponse result = apiInstance.GetAssetPictures(id, width, widthFrom, widthTo, height, heightFrom, heightTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetPictures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the asset | 
 **width** | **int?**| filter by width | [optional] 
 **widthFrom** | **int?**| filter by width_from | [optional] 
 **widthTo** | **int?**| filter by width_to | [optional] 
 **height** | **int?**| filter by height | [optional] 
 **heightFrom** | **int?**| filter by height_from | [optional] 
 **heightTo** | **int?**| filter by height_to | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**PicturesResponse**](PicturesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetproductoptions"></a>
# **GetAssetProductOptions**
> Products GetAssetProductOptions (long? assetId, int? page = null, int? perPage = null, string include = null, string productCode = null, string name = null, string manufacturerId = null, string statusId = null, string categoryId = null, string parentId = null, string tenantId = null, string orderBy = null)

Get all possible products of the specified assets

Returns a list of all possible products for the specified asset. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, parent, manufacturer, pictures, categories, categories.parent```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetProductOptionsExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | Id of the specified asset
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var productCode = productCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all possible products of the specified assets
                Products result = apiInstance.GetAssetProductOptions(assetId, page, perPage, include, productCode, name, manufacturerId, statusId, categoryId, parentId, tenantId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetProductOptions: " + e.Message );
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
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **productCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**Products**](Products.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetstatusesoptions"></a>
# **GetAssetStatusesOptions**
> AssetStatuses GetAssetStatusesOptions (long? assetId, int? page = null, int? perPage = null, string include = null, string name = null, string tenantId = null, string code = null, string orderBy = null, string acceptLanguage = null)

Get all possible statuses of the specified assets

Returns a list of all possible asset statuses for the specified asset. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include value: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetStatusesOptionsExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | Id of the specified asset
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all possible statuses of the specified assets
                AssetStatuses result = apiInstance.GetAssetStatusesOptions(assetId, page, perPage, include, name, tenantId, code, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetStatusesOptions: " + e.Message );
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
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**AssetStatuses**](AssetStatuses.md)

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

            var apiInstance = new AssetApi();
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
                Debug.Print("Exception when calling AssetApi.GetAssetTenantOptions: " + e.Message );
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
<a name="getassetvalueobjectsforkey"></a>
# **GetAssetValueObjectsForKey**
> AssetKeyValueObjectsResponse GetAssetValueObjectsForKey (long? assetId, string key, int? page = null, int? perPage = null, string include = null, DateTime? from = null, DateTime? to = null, DateTime? datetime = null, string selector = null, string interval = null, string orderBy = null)

Get asset value objects for a specific key.

Returns a collection of the history value objects of the value objects for the specified key. For a selected result of the value objects the filter parameters selector and interval are mandatory. With the filter parameters from, to or datetime, it is possible to receive the history of a defined time period.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetValueObjectsForKeyExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var key = key_example;  // string | key for the asset values
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
                // Get asset value objects for a specific key.
                AssetKeyValueObjectsResponse result = apiInstance.GetAssetValueObjectsForKey(assetId, key, page, perPage, include, from, to, datetime, selector, interval, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetValueObjectsForKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **key** | **string**| key for the asset values | 
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
<a name="getassetvalues"></a>
# **GetAssetValues**
> AssetValuesResponse GetAssetValues (long? assetId, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, string key = null, string keyUnitId = null, string group = null)

Get latest values for the asset.

Returns a collection of the latest value for every key of the asset. Possible include values: ```unit, unit.base_unit```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetValuesExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not. These values have lower precedence than the parameter key_unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var key = key_example;  // string | only the values of the specified keys will be returned. If no key is specified all keys of the asset with its latest values will be received. Multiple values can be specified in a comma seperated list. (optional) 
            var keyUnitId = keyUnitId_example;  // string | value of the provided key will be returned in the specified unit. If no key_unit is defined the last written unit will be returned. Accepted format is `key[unit_id]`. Multiple values can be provided in a comma seperated list. (optional) 
            var group = group_example;  // string | Group of the asset value. (optional) 

            try
            {
                // Get latest values for the asset.
                AssetValuesResponse result = apiInstance.GetAssetValues(assetId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not. These values have lower precedence than the parameter key_unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
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
<a name="getassetvaluesforkey"></a>
# **GetAssetValuesForKey**
> AssetKeyValuesResponse GetAssetValuesForKey (long? assetId, string key, int? page = null, int? perPage = null, string include = null, bool? usePreferredUnits = null, DateTime? from = null, DateTime? to = null, int? unitId = null, string aggregation = null, string interval = null, string orderBy = null)

Get asset values for a specific key.

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
    public class GetAssetValuesForKeyExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var key = key_example;  // string | key for the asset values
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page, default value is 500, maximum is 1000 (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var usePreferredUnits = true;  // bool? | whether to return the values in the preferred units described in the asset specification 'preferred_units' or not. These values have lower precedence than the parameter unit_id. Example value of the specification is '{\"key_1\"\\:\"unit_code_1\", \"key_2\"\\:\"unit_code_2\"}' (optional) 
            var from = 2013-10-20;  // DateTime? | Start date filter for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var to = 2013-10-20;  // DateTime? | End date for history values. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var unitId = 56;  // int? | Id of the unit in which the values are to be returned. (optional) 
            var aggregation = aggregation_example;  // string | Supported aggregation methods are `mean, min, max, sum, stddev`. This value is mandatory if interval is defined. (optional) 
            var interval = interval_example;  // string | Interval which is used for the aggregation. The value is mandatory if aggregation is defined. Supported intervals are number of `s, m, h, d, w`. Example `3h`. (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `timestamp`, add `-` as a prefix for descending order. Default ordering is the order the values were entered in. (optional) 

            try
            {
                // Get asset values for a specific key.
                AssetKeyValuesResponse result = apiInstance.GetAssetValuesForKey(assetId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetValuesForKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **key** | **string**| key for the asset values | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page, default value is 500, maximum is 1000 | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **usePreferredUnits** | **bool?**| whether to return the values in the preferred units described in the asset specification &#x27;preferred_units&#x27; or not. These values have lower precedence than the parameter unit_id. Example value of the specification is &#x27;{\&quot;key_1\&quot;\\:\&quot;unit_code_1\&quot;, \&quot;key_2\&quot;\\:\&quot;unit_code_2\&quot;}&#x27; | [optional] 
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
<a name="getassets"></a>
# **GetAssets**
> AssetsResponse GetAssets (int? page = null, int? perPage = null, string include = null, string serialNumber = null, string productId = null, string productStatusId = null, string productCategoryId = null, string parentId = null, string manufacturerId = null, string statusId = null, string statusCode = null, string tenantId = null, string lastSeenAtFrom = null, string lastSeenAtTo = null, DateTime? productionDate = null, DateTime? productionDateFrom = null, DateTime? productionDateTo = null, string specificationsKey = null, string specificationsValue = null, string nodeId = null, string instrumentationId = null, string systemId = null, DateTime? createdAt = null, string createdAtFrom = null, string createdAtTo = null, DateTime? updatedAt = null, string updatedAtFrom = null, string updatedAtTo = null, bool? ownershipClaimed = null, string permission = null, string orderBy = null)

Get a range of assets

Returns a list of assets in your accessible scope. You can apply the query parameters listed below to get a filtered list. Possible include values: ```status, tenant, parent, pictures, values, values.unit, values_in_preferred_units, values_in_preferred_units.unit, product, product.manufacturer, product.pictures, product.status, product.categories, product.categories.parent, product.tenant, product.manufacturer.tenant, status.tenant, instrumentations, systems, systems.recipe,  systems.specifications, systems.batches_in_execution, specifications, specifications[key1,key2], product.specifications, product.specifications[key1,key2], instrumentations.status, instrumentations.type, instrumentations.worst_asset_status,  instrumentations.specifications, instrumentations.specifications[key1,key2] add_ons```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetsExample
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

            var apiInstance = new AssetApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var serialNumber = serialNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productId = productId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var productStatusId = productStatusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var productCategoryId = productCategoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusCode = statusCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var lastSeenAtFrom = lastSeenAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var lastSeenAtTo = lastSeenAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var productionDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var nodeId = nodeId_example;  // string | One or multiple ids (comma list). Filter acccepts \"null\" for all assets with no nodes assigned or \"!null\" for any assigned node.  By adding `+` after the id, the filter considers the given node and all its sub components (nodes, instrumentations and systems), but this is not usable in combination with a comma list. (optional) 
            var instrumentationId = instrumentationId_example;  // string | One or multiple ids (comma list). Filter accepts \"null\" for all objects with no instrumentations assigned or \"!null\" for any assigned instrumentation (optional) 
            var systemId = systemId_example;  // string | One or multiple ids (comma list). Filter accepts \"null\" for all objects with no systems assigned or \"!null\" for any assigned system (optional) 
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
                // Get a range of assets
                AssetsResponse result = apiInstance.GetAssets(page, perPage, include, serialNumber, productId, productStatusId, productCategoryId, parentId, manufacturerId, statusId, statusCode, tenantId, lastSeenAtFrom, lastSeenAtTo, productionDate, productionDateFrom, productionDateTo, specificationsKey, specificationsValue, nodeId, instrumentationId, systemId, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, ownershipClaimed, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssets: " + e.Message );
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
 **serialNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **productStatusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **productCategoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **lastSeenAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **lastSeenAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **productionDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **nodeId** | **string**| One or multiple ids (comma list). Filter acccepts \&quot;null\&quot; for all assets with no nodes assigned or \&quot;!null\&quot; for any assigned node.  By adding &#x60;+&#x60; after the id, the filter considers the given node and all its sub components (nodes, instrumentations and systems), but this is not usable in combination with a comma list. | [optional] 
 **instrumentationId** | **string**| One or multiple ids (comma list). Filter accepts \&quot;null\&quot; for all objects with no instrumentations assigned or \&quot;!null\&quot; for any assigned instrumentation | [optional] 
 **systemId** | **string**| One or multiple ids (comma list). Filter accepts \&quot;null\&quot; for all objects with no systems assigned or \&quot;!null\&quot; for any assigned system | [optional] 
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
<a name="getdeliveriesofasset"></a>
# **GetDeliveriesOfAsset**
> DeliveriesResponse GetDeliveriesOfAsset (long? assetId, int? page = null, int? perPage = null, string number = null, string name = null, string statusId = null, DateTime? dateOfShipment = null, DateTime? dateOfShipmentFrom = null, DateTime? dateOfShipmentTo = null, string senderId = null, string receiverId = null, string customerNumber = null, string orderBy = null)

Get all deliveries of one asset

Returns a list of all deliveries that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDeliveriesOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var dateOfShipment = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var dateOfShipmentFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var dateOfShipmentTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var senderId = senderId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var receiverId = receiverId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var customerNumber = customerNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all deliveries of one asset
                DeliveriesResponse result = apiInstance.GetDeliveriesOfAsset(assetId, page, perPage, number, name, statusId, dateOfShipment, dateOfShipmentFrom, dateOfShipmentTo, senderId, receiverId, customerNumber, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetDeliveriesOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **dateOfShipment** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **dateOfShipmentFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **dateOfShipmentTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **senderId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **receiverId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **customerNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**DeliveriesResponse**](DeliveriesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdocumentsofasset"></a>
# **GetDocumentsOfAsset**
> DocumentsResponse GetDocumentsOfAsset (long? assetId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string orderBy = null, string acceptLanguage = null)

Get all documents of an asset

Returns a list of all documents that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, classification, categories, categories.parent, attachments, categories.standards, eventdocuments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
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
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all documents of an asset
                DocumentsResponse result = apiInstance.GetDocumentsOfAsset(assetId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetDocumentsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
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
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**DocumentsResponse**](DocumentsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="geteventsofasset"></a>
# **GetEventsOfAsset**
> EventsResponse GetEventsOfAsset (long? assetId, int? page = null, int? perPage = null, string include = null, string name = null, string typeId = null, string statusId = null, string startDatetime = null, string startDatetimeFrom = null, string startDatetimeTo = null, string endDatetime = null, DateTime? endDatetimeFrom = null, string endDatetimeTo = null, string tenantId = null, string orderBy = null)

Get all events of one asset

Returns a list of all events belonging to an asset in your accessible scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ``assets, instrumentations, status, type``

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetEventsOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
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
                // Get all events of one asset
                EventsResponse result = apiInstance.GetEventsOfAsset(assetId, page, perPage, include, name, typeId, statusId, startDatetime, startDatetimeFrom, startDatetimeTo, endDatetime, endDatetimeFrom, endDatetimeTo, tenantId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetEventsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
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
<a name="getinstrumentationsofasset"></a>
# **GetInstrumentationsOfAsset**
> InstrumentationsResponse GetInstrumentationsOfAsset (long? assetId, int? page = null, int? perPage = null, string include = null, string tag = null, string statusId = null, string typeId = null, string parentId = null, string tenantId = null, string specificationsKey = null, string specificationsValue = null, string criticality = null, string accessibility = null, string nodeId = null, string permission = null, string orderBy = null)

Get all instrumentations of one asset

Returns a list of all instrumentations that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```specifications, specifications[key1,key2], pictures, tenant, parent, status, worst_asset_status, type```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationsOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
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
            var nodeId = nodeId_example;  // string | One or multiple ids (comma list). Filter acccepts \"null\" for all objects with no nodes assigned or \"!null\" for any assigned node (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `tag`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all instrumentations of one asset
                InstrumentationsResponse result = apiInstance.GetInstrumentationsOfAsset(assetId, page, perPage, include, tag, statusId, typeId, parentId, tenantId, specificationsKey, specificationsValue, criticality, accessibility, nodeId, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetInstrumentationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
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
 **nodeId** | **string**| One or multiple ids (comma list). Filter acccepts \&quot;null\&quot; for all objects with no nodes assigned or \&quot;!null\&quot; for any assigned node | [optional] 
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
<a name="getinstrumentationsofassethistory"></a>
# **GetInstrumentationsOfAssetHistory**
> AssetInstrumentationsHistoryResponse GetInstrumentationsOfAssetHistory (long? assetId, int? page = null, int? perPage = null, string instrumentationId = null, string _event = null, DateTime? eventDatetimeFrom = null, DateTime? eventDatetimeTo = null, string orderBy = null)

Get all instrumentations an asset was assigned to

Returns a list of all instrumentations history available in your scope which have been assigned to the specified asset. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationsOfAssetHistoryExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var instrumentationId = instrumentationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var _event = _event_example;  // string | Filter accepts `create` or `destroy` (optional) 
            var eventDatetimeFrom = 2013-10-20;  // DateTime? | Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var eventDatetimeTo = 2013-10-20;  // DateTime? | Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `event` or `event_datetime`, add `-` as a prefix for descending order. (optional) 

            try
            {
                // Get all instrumentations an asset was assigned to
                AssetInstrumentationsHistoryResponse result = apiInstance.GetInstrumentationsOfAssetHistory(assetId, page, perPage, instrumentationId, _event, eventDatetimeFrom, eventDatetimeTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetInstrumentationsOfAssetHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **instrumentationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **_event** | **string**| Filter accepts &#x60;create&#x60; or &#x60;destroy&#x60; | [optional] 
 **eventDatetimeFrom** | **DateTime?**| Starting with + will include the previous value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **eventDatetimeTo** | **DateTime?**| Ending with + will include the next value as well. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;event&#x60; or &#x60;event_datetime&#x60;, add &#x60;-&#x60; as a prefix for descending order. | [optional] 

### Return type

[**AssetInstrumentationsHistoryResponse**](AssetInstrumentationsHistoryResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnodesofasset"></a>
# **GetNodesOfAsset**
> NodesResponse GetNodesOfAsset (long? assetId, int? page = null, int? perPage = null, string include = null, string name = null, string typeId = null, string parentId = null, string tenantId = null, bool? hidden = null, string permission = null, string orderBy = null)

Get all nodes of one asset

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
    public class GetNodesOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
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
                // Get all nodes of one asset
                NodesResponse result = apiInstance.GetNodesOfAsset(assetId, page, perPage, include, name, typeId, parentId, tenantId, hidden, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetNodesOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
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
<a name="getsoftwaresofsoftware"></a>
# **GetSoftwaresOfSoftware**
> SoftwaresResponse GetSoftwaresOfSoftware (long? assetId, int? page = null, int? perPage = null, string include = null, string softwareTypeId = null, string orderBy = null, string acceptLanguage = null)

Get a range of software of one asset

Returns a list of software. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```software_attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSoftwaresOfSoftwareExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var softwareTypeId = softwareTypeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `version_number`, `name`, `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of software of one asset
                SoftwaresResponse result = apiInstance.GetSoftwaresOfSoftware(assetId, page, perPage, include, softwareTypeId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetSoftwaresOfSoftware: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **softwareTypeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;version_number&#x60;, &#x60;name&#x60;, &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**SoftwaresResponse**](SoftwaresResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationhistoryofasset"></a>
# **GetSpecificationHistoryOfAsset**
> SpecificationHistoryResponse GetSpecificationHistoryOfAsset (long? assetId, string key, int? page = null, int? perPage = null, DateTime? sourceTimestampFrom = null, DateTime? sourceTimestampTo = null, DateTime? updatedAtFrom = null, DateTime? updatedAtTo = null, string orderBy = null)

Get the history of one specification attribute of an asset.

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
    public class GetSpecificationHistoryOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | Id of the specified asset
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
                // Get the history of one specification attribute of an asset.
                SpecificationHistoryResponse result = apiInstance.GetSpecificationHistoryOfAsset(assetId, key, page, perPage, sourceTimestampFrom, sourceTimestampTo, updatedAtFrom, updatedAtTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetSpecificationHistoryOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the specified asset | 
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
<a name="getspecificationkeysofassets"></a>
# **GetSpecificationKeysOfAssets**
> SpecificationKeys GetSpecificationKeysOfAssets (string key = null, bool? uiVisible = null)

Get existing asset specification keys

Returns the existing specification keys in all readable assets.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationKeysOfAssetsExample
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

            var apiInstance = new AssetApi();
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get existing asset specification keys
                SpecificationKeys result = apiInstance.GetSpecificationKeysOfAssets(key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetSpecificationKeysOfAssets: " + e.Message );
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
<a name="getspecificationsofasset"></a>
# **GetSpecificationsOfAsset**
> SpecificationsUIVisibleResponse GetSpecificationsOfAsset (long? assetId, string key = null, bool? uiVisible = null)

Get specifications of an asset

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
    public class GetSpecificationsOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | Id of the specified asset
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get specifications of an asset
                SpecificationsUIVisibleResponse result = apiInstance.GetSpecificationsOfAsset(assetId, key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetSpecificationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the specified asset | 
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
<a name="getsubscriptionsofasset"></a>
# **GetSubscriptionsOfAsset**
> SubscriptionsResponse GetSubscriptionsOfAsset (long? assetId, int? page = null, int? perPage = null, string include = null, long? userId = null, long? clientApplicationId = null, string externalReference = null, string status = null, string notificationStatus = null, string specificationsKey = null, string specificationsValue = null, DateTime? startDate = null, DateTime? endDate = null, string orderBy = null)

Get all subscriptions of asset

Returns a list of all subscriptions that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```user, user.usage, specifications, specifications[key1,key2]``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSubscriptionsOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var userId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var clientApplicationId = 789;  // long? | One or multiple ids (comma list). Expected id format is integer (optional) 
            var externalReference = externalReference_example;  // string | Filter accepts `*` as wildcard (optional) 
            var status = status_example;  // string | Filter by status - no wildcard support (optional) 
            var notificationStatus = notificationStatus_example;  // string | Filter by notification status - no wildcard support (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var startDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var endDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all subscriptions of asset
                SubscriptionsResponse result = apiInstance.GetSubscriptionsOfAsset(assetId, page, perPage, include, userId, clientApplicationId, externalReference, status, notificationStatus, specificationsKey, specificationsValue, startDate, endDate, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetSubscriptionsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **userId** | **long?**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **clientApplicationId** | **long?**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **externalReference** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **status** | **string**| Filter by status - no wildcard support | [optional] 
 **notificationStatus** | **string**| Filter by notification status - no wildcard support | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **startDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **endDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**SubscriptionsResponse**](SubscriptionsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsystemsofasset"></a>
# **GetSystemsOfAsset**
> SystemsResponse GetSystemsOfAsset (long? assetId, int? page = null, int? perPage = null, string include = null, string name = null, string typeId = null, string parentId = null, string tenantId = null, string permission = null, string orderBy = null)

Get all systems of one Asset

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
    public class GetSystemsOfAssetExample
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

            var apiInstance = new AssetApi();
            var assetId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all systems of one Asset
                SystemsResponse result = apiInstance.GetSystemsOfAsset(assetId, page, perPage, include, name, typeId, parentId, tenantId, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.GetSystemsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
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
<a name="removeaddonsfromasset"></a>
# **RemoveAddOnsFromAsset**
> void RemoveAddOnsFromAsset (AddOnIDs body, long? assetId)

Remove add_ons from an asset

Remove one or more add_ons from an asset in your accessible scope. `This action` requires `can_permit` permission on the asset and on the add_on.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveAddOnsFromAssetExample
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

            var apiInstance = new AssetApi();
            var body = new AddOnIDs(); // AddOnIDs | Resources that shall be removed.
            var assetId = 789;  // long? | Id of the asset from which the add_ons will be removed

            try
            {
                // Remove add_ons from an asset
                apiInstance.RemoveAddOnsFromAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.RemoveAddOnsFromAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddOnIDs**](AddOnIDs.md)| Resources that shall be removed. | 
 **assetId** | **long?**| Id of the asset from which the add_ons will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removedeliveriesfromasset"></a>
# **RemoveDeliveriesFromAsset**
> void RemoveDeliveriesFromAsset (DeliveryIDs body, long? assetId)

Remove deliveries from an asset

Remove one or more deliveries from an asset in your accessible scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDeliveriesFromAssetExample
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

            var apiInstance = new AssetApi();
            var body = new DeliveryIDs(); // DeliveryIDs | Resources that shall be removed.
            var assetId = 789;  // long? | Id of the asset from which the deliveries will be removed

            try
            {
                // Remove deliveries from an asset
                apiInstance.RemoveDeliveriesFromAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.RemoveDeliveriesFromAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryIDs**](DeliveryIDs.md)| Resources that shall be removed. | 
 **assetId** | **long?**| Id of the asset from which the deliveries will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removedocumentsfromasset"></a>
# **RemoveDocumentsFromAsset**
> void RemoveDocumentsFromAsset (DocumentIDs body, long? assetId)

Remove documents from an asset

Remove one or more documents from an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDocumentsFromAssetExample
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

            var apiInstance = new AssetApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be removed.
            var assetId = 789;  // long? | Id of the asset from which the documents will be removed

            try
            {
                // Remove documents from an asset
                apiInstance.RemoveDocumentsFromAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.RemoveDocumentsFromAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be removed. | 
 **assetId** | **long?**| Id of the asset from which the documents will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeeventfromasset"></a>
# **RemoveEventFromAsset**
> void RemoveEventFromAsset (Events body, long? assetId)

Remove events from an asset

Remove one or more events from an asset in your accessible scope. If the event has no more related assets, the event will be deleted

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveEventFromAssetExample
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

            var apiInstance = new AssetApi();
            var body = new Events(); // Events | Resources that shall be removed.
            var assetId = 789;  // long? | Id of the asset from which the events will removed.

            try
            {
                // Remove events from an asset
                apiInstance.RemoveEventFromAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.RemoveEventFromAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Events**](Events.md)| Resources that shall be removed. | 
 **assetId** | **long?**| Id of the asset from which the events will removed. | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeinstrumentationsofasset"></a>
# **RemoveInstrumentationsOfAsset**
> void RemoveInstrumentationsOfAsset (InstrumentationIDs body, long? assetId)

Remove instrumentations from an asset

Remove one or more instrumentations from an asset in your accessible scope. This action requires `can_permit` permission on the asset and on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveInstrumentationsOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new InstrumentationIDs(); // InstrumentationIDs | Resources that shall be removed.
            var assetId = 789;  // long? | Id of the asset from which the instrumentations will be removed

            try
            {
                // Remove instrumentations from an asset
                apiInstance.RemoveInstrumentationsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.RemoveInstrumentationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationIDs**](InstrumentationIDs.md)| Resources that shall be removed. | 
 **assetId** | **long?**| Id of the asset from which the instrumentations will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removenodesfromasset"></a>
# **RemoveNodesFromAsset**
> void RemoveNodesFromAsset (NodeIDs body, long? assetId)

Remove nodes from an asset

Remove one or more nodes from an asset in your accessible scope. `This action` requires `can_permit` permission on the asset and on the node.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveNodesFromAssetExample
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

            var apiInstance = new AssetApi();
            var body = new NodeIDs(); // NodeIDs | Resources that shall be removed.
            var assetId = 789;  // long? | Id of the asset from which the nodes will be removed

            try
            {
                // Remove nodes from an asset
                apiInstance.RemoveNodesFromAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.RemoveNodesFromAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeIDs**](NodeIDs.md)| Resources that shall be removed. | 
 **assetId** | **long?**| Id of the asset from which the nodes will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removesoftwaresofasset"></a>
# **RemoveSoftwaresOfAsset**
> void RemoveSoftwaresOfAsset (SoftwareIDs body, long? assetId)

Remove software from an asset

Remove one or more software from an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSoftwaresOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new SoftwareIDs(); // SoftwareIDs | Resources that shall be removed.
            var assetId = 789;  // long? | Id of the product from which the software will be removed

            try
            {
                // Remove software from an asset
                apiInstance.RemoveSoftwaresOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.RemoveSoftwaresOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareIDs**](SoftwareIDs.md)| Resources that shall be removed. | 
 **assetId** | **long?**| Id of the product from which the software will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofasset"></a>
# **RenameSpecificationsOfAsset**
> void RenameSpecificationsOfAsset (SpecificationsRename body, long? assetId)

Rename a specification key

Rename one specification key of an asset in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ]. All uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var assetId = 789;  // long? | Id of the specified asset

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.RenameSpecificationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **assetId** | **long?**| Id of the specified asset | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceaddonsofasset"></a>
# **ReplaceAddOnsOfAsset**
> void ReplaceAddOnsOfAsset (AddOnIDs body, long? assetId)

Replace the add_ons of an asset

Replaces all add_ons belonging to an asset in your accessible scope. You can send a list of resources that will replace all previous values. This action requires `can_permit` permission on the asset and on the add_on.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceAddOnsOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new AddOnIDs(); // AddOnIDs | Resources that shall be replaced
            var assetId = 789;  // long? | Id of the asset of which the add_ons will be replaced

            try
            {
                // Replace the add_ons of an asset
                apiInstance.ReplaceAddOnsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.ReplaceAddOnsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddOnIDs**](AddOnIDs.md)| Resources that shall be replaced | 
 **assetId** | **long?**| Id of the asset of which the add_ons will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedeliveriesofasset"></a>
# **ReplaceDeliveriesOfAsset**
> void ReplaceDeliveriesOfAsset (DeliveryIDs body, long? assetId)

Replace the deliveries of an asset

Replaces all deliveries belonging to an asset in your accessible scope. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDeliveriesOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new DeliveryIDs(); // DeliveryIDs | Resources that shall be replaced
            var assetId = 789;  // long? | Id of the asset of which the deliveries will be replaced

            try
            {
                // Replace the deliveries of an asset
                apiInstance.ReplaceDeliveriesOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.ReplaceDeliveriesOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeliveryIDs**](DeliveryIDs.md)| Resources that shall be replaced | 
 **assetId** | **long?**| Id of the asset of which the deliveries will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedocumentsofasset"></a>
# **ReplaceDocumentsOfAsset**
> void ReplaceDocumentsOfAsset (DocumentIDs body, long? assetId)

Replace the documents of an asset

Replaces all documents belonging to an asset. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDocumentsOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be replaced
            var assetId = 789;  // long? | Id of the asset of which the documents will be replaced

            try
            {
                // Replace the documents of an asset
                apiInstance.ReplaceDocumentsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.ReplaceDocumentsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be replaced | 
 **assetId** | **long?**| Id of the asset of which the documents will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceinstrumentationsofasset"></a>
# **ReplaceInstrumentationsOfAsset**
> void ReplaceInstrumentationsOfAsset (InstrumentationIDs body, long? assetId)

Replace the instrumentations of an asset

Replaces all instrumentations belonging to an asset in your accessible scope. You can send a list of resources that will replace all previous values. This action requires `can_permit` permission on the asset and on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceInstrumentationsOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new InstrumentationIDs(); // InstrumentationIDs | Resources that shall be replaced
            var assetId = 789;  // long? | Id of the asset of which the instrumentations will be replaced

            try
            {
                // Replace the instrumentations of an asset
                apiInstance.ReplaceInstrumentationsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.ReplaceInstrumentationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationIDs**](InstrumentationIDs.md)| Resources that shall be replaced | 
 **assetId** | **long?**| Id of the asset of which the instrumentations will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacenodesofasset"></a>
# **ReplaceNodesOfAsset**
> void ReplaceNodesOfAsset (NodeIDs body, long? assetId)

Replace the nodes of an asset

Replaces all nodes belonging to an asset in your accessible scope. You can send a list of resources that will replace all previous values. This action requires `can_permit` permission on the asset and on the node.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceNodesOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new NodeIDs(); // NodeIDs | Resources that shall be replaced
            var assetId = 789;  // long? | Id of the asset of which the nodes will be replaced

            try
            {
                // Replace the nodes of an asset
                apiInstance.ReplaceNodesOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.ReplaceNodesOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeIDs**](NodeIDs.md)| Resources that shall be replaced | 
 **assetId** | **long?**| Id of the asset of which the nodes will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacesoftwaresofasset"></a>
# **ReplaceSoftwaresOfAsset**
> void ReplaceSoftwaresOfAsset (SoftwareIDs body, long? assetId)

Replace the software of an asset

Replaces all software belonging to an asset. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceSoftwaresOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new SoftwareIDs(); // SoftwareIDs | Resources that shall be replaced
            var assetId = 789;  // long? | Id of the asset of which the software will be replaced

            try
            {
                // Replace the software of an asset
                apiInstance.ReplaceSoftwaresOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.ReplaceSoftwaresOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareIDs**](SoftwareIDs.md)| Resources that shall be replaced | 
 **assetId** | **long?**| Id of the asset of which the software will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateasset"></a>
# **UpdateAsset**
> void UpdateAsset (AssetRequest body, long? id)

Update an asset

Update accessible parameters of the requested resource in your accessible scope.  To assign a parent asset the user needs `can_permit` permission on the parent and on the current asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateAssetExample
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

            var apiInstance = new AssetApi();
            var body = new AssetRequest(); // AssetRequest | Parameters that shall be updated. To remove an associative object use "object_name": null
            var id = 789;  // long? | Id of the asset to update

            try
            {
                // Update an asset
                apiInstance.UpdateAsset(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.UpdateAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetRequest**](AssetRequest.md)| Parameters that shall be updated. To remove an associative object use &quot;object_name&quot;: null | 
 **id** | **long?**| Id of the asset to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateassetpicture"></a>
# **UpdateAssetPicture**
> PictureResponse UpdateAssetPicture (byte[] image, long? assetId, long? id)

Update an asset picture

Upload a new asset picture. Check the file-storage quota. Allowed content-types are - image/gif - image/jpg - image/jpeg - image/png

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateAssetPictureExample
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

            var apiInstance = new AssetApi();
            var image = image_example;  // byte[] | 
            var assetId = 789;  // long? | Id of the asset
            var id = 789;  // long? | Id of the asset picture

            try
            {
                // Update an asset picture
                PictureResponse result = apiInstance.UpdateAssetPicture(image, assetId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.UpdateAssetPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **assetId** | **long?**| Id of the asset | 
 **id** | **long?**| Id of the asset picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateassetpicturelink"></a>
# **UpdateAssetPictureLink**
> PictureResponse UpdateAssetPictureLink (PictureLinkRequest body, long? assetId, long? id)

Update an asset picture link

Update an asset picture link.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateAssetPictureLinkExample
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

            var apiInstance = new AssetApi();
            var body = new PictureLinkRequest(); // PictureLinkRequest | Picture link object to be updated
            var assetId = 789;  // long? | Id of the asset
            var id = 789;  // long? | Id of the asset picture

            try
            {
                // Update an asset picture link
                PictureResponse result = apiInstance.UpdateAssetPictureLink(body, assetId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.UpdateAssetPictureLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PictureLinkRequest**](PictureLinkRequest.md)| Picture link object to be updated | 
 **assetId** | **long?**| Id of the asset | 
 **id** | **long?**| Id of the asset picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofasset"></a>
# **UpdateSpecificationsOfAsset**
> void UpdateSpecificationsOfAsset (Dictionary<string, SpecificationUIVisibleRequest> body, long? assetId)

Update specifications of an asset

Update the specification object of an asset in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.  It is possible to save complex objects in the value as vector. In this case the unit must be 'vector' and the value a valid object in the following format: ```       [           {             \"key\": {              \"value\": \"string\",              \"unit\": \"string\"            }           },           {             \"second_key\": {               \"value\": \"string\"             }           }        ]   ```  - key can only consist of [a-z A-Z 0-9 . - _ ]. - value is mandatory, max length 6000 chars - unit is optional, max length 50 chars - its impossible to filter for vector values

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfAssetExample
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

            var apiInstance = new AssetApi();
            var body = new Dictionary<string, SpecificationUIVisibleRequest>(); // Dictionary<string, SpecificationUIVisibleRequest> | The specifications objects to patch.
            var assetId = 789;  // long? | Id of the specified asset

            try
            {
                // Update specifications of an asset
                apiInstance.UpdateSpecificationsOfAsset(body, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.UpdateSpecificationsOfAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationUIVisibleRequest&gt;**](Dictionary&lt;string, SpecificationUIVisibleRequest&gt;.md)| The specifications objects to patch. | 
 **assetId** | **long?**| Id of the specified asset | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadassetpicture"></a>
# **UploadAssetPicture**
> PictureResponse UploadAssetPicture (byte[] image, long? id)

Upload an asset picture

Upload a new asset picture. Checks the file-storage quota. Allowed content-types are - image/gif - image/jpg - image/jpeg - image/png

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UploadAssetPictureExample
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

            var apiInstance = new AssetApi();
            var image = image_example;  // byte[] | 
            var id = 789;  // long? | Id of the asset

            try
            {
                // Upload an asset picture
                PictureResponse result = apiInstance.UploadAssetPicture(image, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.UploadAssetPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **id** | **long?**| Id of the asset | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
