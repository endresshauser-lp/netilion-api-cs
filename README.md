# Netilion.Api - the C# library for the Netilion API

This is a C# client to acccess [Netilion](https://netilion.endress.com/) REST API.

Swagger UI can be found at [Staging API](https://api.staging-env.netilion.endress.com/doc/v1/)
or [Production API](https://api.netilion.endress.com/doc/v1/)

Please visit our developer portal for further instructions and information: https://developer.netilion.endress.com/ 

## Frameworks supported
- .NET 4.5 or later


## Usage example

```csharp
using System;
using System.Diagnostics;
using System.Net;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace TestNetilion
{
    public class TestNetilion
    {
        static public void Main()
        {
            // "https://api.iiot.endress.com/v1" for productive access
            Configuration.Default.BasePath = "https://api.staging-env.iiot.endress.com/v1";
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_BASIC_API_KEY");
            Configuration.Default.Username = "YOUR_EMAIL";
            Configuration.Default.Password = "YOUR_PASSWORD";

            // Ensure TLS works
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;

            // Create object to access Endpoint
            var apiInstance = new AssetApi(Configuration.Default);

            try
            {
                // Get assets owned by the user, see https://api.staging-env.netilion.endress.com/doc/v1#/Asset/getAssets
                AssetsResponse result = apiInstance.GetAssets();
                Console.WriteLine(result);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*APIKeyApi* | [**CreateAPIKey**](docs/APIKeyApi.md#createapikey) | **POST** /api_keys | Create a new APIKey
*APIKeyApi* | [**DeleteAPIKey**](docs/APIKeyApi.md#deleteapikey) | **DELETE** /api_keys/{id} | Delete an APIKey
*APIKeyApi* | [**GetAPIKeyById**](docs/APIKeyApi.md#getapikeybyid) | **GET** /api_keys/{id} | Get a single APIKey
*APIKeyApi* | [**GetAPIKeys**](docs/APIKeyApi.md#getapikeys) | **GET** /api_keys | Get a range of APIKeys
*APIKeyApi* | [**UpdateAPIKey**](docs/APIKeyApi.md#updateapikey) | **PATCH** /api_keys/{id} | Update an APIKey
*APISubscriptionApi* | [**AddAssetsToAPISubscription**](docs/APISubscriptionApi.md#addassetstoapisubscription) | **POST** /api_subscriptions/{id}/assets | Add assets to an api subscription
*APISubscriptionApi* | [**AddEdgeDevicesToApiSubscription**](docs/APISubscriptionApi.md#addedgedevicestoapisubscription) | **POST** /api_subscriptions/{id}/edge_devices | Add edge devices to an api subscription
*APISubscriptionApi* | [**CreateAPISubscription**](docs/APISubscriptionApi.md#createapisubscription) | **POST** /api_subscriptions | Create a new api subscription
*APISubscriptionApi* | [**DeleteAPISubscription**](docs/APISubscriptionApi.md#deleteapisubscription) | **DELETE** /api_subscriptions/{id} | Delete an api subscription
*APISubscriptionApi* | [**GetAPISubscriptionById**](docs/APISubscriptionApi.md#getapisubscriptionbyid) | **GET** /api_subscriptions/{id} | Get a single api subscription
*APISubscriptionApi* | [**GetAPISubscriptions**](docs/APISubscriptionApi.md#getapisubscriptions) | **GET** /api_subscriptions | Get a range of api subscriptions
*APISubscriptionApi* | [**GetAssetsOfAPISubscription**](docs/APISubscriptionApi.md#getassetsofapisubscription) | **GET** /api_subscriptions/{id}/assets | Get all assets of an api subscription
*APISubscriptionApi* | [**GetEdgeDevicesOfAPISubscription**](docs/APISubscriptionApi.md#getedgedevicesofapisubscription) | **GET** /api_subscriptions/{id}/edge_devices | Get all edge devices of an api subscription
*APISubscriptionApi* | [**GetSpecificationsOfAPISubscription**](docs/APISubscriptionApi.md#getspecificationsofapisubscription) | **GET** /api_subscriptions/{id}/specifications | Get specifications of an api subscription
*APISubscriptionApi* | [**RemoveAssetsFromAPISubscription**](docs/APISubscriptionApi.md#removeassetsfromapisubscription) | **DELETE** /api_subscriptions/{id}/assets | Remove assets from an api subscription
*APISubscriptionApi* | [**RemoveEdgeDevicesFromApiSubscription**](docs/APISubscriptionApi.md#removeedgedevicesfromapisubscription) | **DELETE** /api_subscriptions/{id}/edge_devices | Remove edge devices from an api subscription
*APISubscriptionApi* | [**RemoveSpecificationsFromAPISubscriptions**](docs/APISubscriptionApi.md#removespecificationsfromapisubscriptions) | **DELETE** /api_subscriptions/{id}/specifications | Delete specifications of an api subscription
*APISubscriptionApi* | [**RenameSpecificationsOfAPISubscriptions**](docs/APISubscriptionApi.md#renamespecificationsofapisubscriptions) | **PATCH** /api_subscriptions/{id}/specifications/rename | Rename a specification key
*APISubscriptionApi* | [**ReplaceAssetsOfAPISubscription**](docs/APISubscriptionApi.md#replaceassetsofapisubscription) | **PATCH** /api_subscriptions/{id}/assets | Replace the assets of an api subscription
*APISubscriptionApi* | [**ReplaceEdgeDevicesOfApiSubscription**](docs/APISubscriptionApi.md#replaceedgedevicesofapisubscription) | **PATCH** /api_subscriptions/{id}/edge_devices | Replace the edge devices of an api subscription
*APISubscriptionApi* | [**UpdateAPISubscription**](docs/APISubscriptionApi.md#updateapisubscription) | **PATCH** /api_subscriptions/{id} | Update an api subscription
*APISubscriptionApi* | [**UpdateSpecificationsOfAPISubscriptions**](docs/APISubscriptionApi.md#updatespecificationsofapisubscriptions) | **PATCH** /api_subscriptions/{id}/specifications | Update specifications of an api subscription
*AssetApi* | [**AddAddOnsToAsset**](docs/AssetApi.md#addaddonstoasset) | **POST** /assets/{asset_id}/add_ons | Add add_ons to an asset
*AssetApi* | [**AddAssetPictureLink**](docs/AssetApi.md#addassetpicturelink) | **POST** /assets/{id}/pictures/links | Add a link as asset picture
*AssetApi* | [**AddDeliveriesToAsset**](docs/AssetApi.md#adddeliveriestoasset) | **POST** /assets/{asset_id}/deliveries | Add deliveries to an asset
*AssetApi* | [**AddDocumentsToAsset**](docs/AssetApi.md#adddocumentstoasset) | **POST** /assets/{asset_id}/documents | Add documents to an asset
*AssetApi* | [**AddInstrumentationsToAsset**](docs/AssetApi.md#addinstrumentationstoasset) | **POST** /assets/{asset_id}/instrumentations | Add instrumentations to an asset
*AssetApi* | [**AddNodesToAsset**](docs/AssetApi.md#addnodestoasset) | **POST** /assets/{asset_id}/nodes | Add nodes to an asset
*AssetApi* | [**AddSoftwaresToAsset**](docs/AssetApi.md#addsoftwarestoasset) | **POST** /assets/{asset_id}/softwares | Add software to an asset
*AssetApi* | [**CreateAsset**](docs/AssetApi.md#createasset) | **POST** /assets | Create a new asset
*AssetApi* | [**CreateAssetContainer**](docs/AssetApi.md#createassetcontainer) | **POST** /assets/{id}/containers | Create an export for a standard container
*AssetApi* | [**CreateAssetValueObjects**](docs/AssetApi.md#createassetvalueobjects) | **POST** /assets/{asset_id}/value_objects | Create asset value objects
*AssetApi* | [**CreateAssetValues**](docs/AssetApi.md#createassetvalues) | **POST** /assets/{asset_id}/values | Create asset values
*AssetApi* | [**CreateEventForAsset**](docs/AssetApi.md#createeventforasset) | **POST** /assets/{asset_id}/events | Create a new event for an asset
*AssetApi* | [**DeleteAsset**](docs/AssetApi.md#deleteasset) | **DELETE** /assets/{id} | Delete an asset
*AssetApi* | [**DeleteAssetPicture**](docs/AssetApi.md#deleteassetpicture) | **DELETE** /assets/{asset_id}/pictures/{id} | Delete an asset picture
*AssetApi* | [**DeleteSpecificationsOfAsset**](docs/AssetApi.md#deletespecificationsofasset) | **DELETE** /assets/{asset_id}/specifications | Delete specifications of an asset
*AssetApi* | [**DownloadAssetPicture**](docs/AssetApi.md#downloadassetpicture) | **GET** /assets/{asset_id}/pictures/{id}/download | Download an asset picture
*AssetApi* | [**GetAddOnsOfAsset**](docs/AssetApi.md#getaddonsofasset) | **GET** /assets/{asset_id}/add_ons | Get all add_ons of one asset
*AssetApi* | [**GetApiSubscriptionsOfAsset**](docs/AssetApi.md#getapisubscriptionsofasset) | **GET** /assets/{asset_id}/api_subscriptions | Get all API subscriptions of the asset
*AssetApi* | [**GetAssetById**](docs/AssetApi.md#getassetbyid) | **GET** /assets/{id} | Get a single asset
*AssetApi* | [**GetAssetCompanyOptions**](docs/AssetApi.md#getassetcompanyoptions) | **GET** /assets/{asset_id}/company-options | Get all possible companies of the specified assets
*AssetApi* | [**GetAssetHistory**](docs/AssetApi.md#getassethistory) | **GET** /assets/{asset_id}/history | Get the history of an asset
*AssetApi* | [**GetAssetIdStatus**](docs/AssetApi.md#getassetidstatus) | **GET** /assets/{asset_id}/status | Get the status of the specific asset
*AssetApi* | [**GetAssetPicture**](docs/AssetApi.md#getassetpicture) | **GET** /assets/{asset_id}/pictures/{id} | Get an asset picture
*AssetApi* | [**GetAssetPictures**](docs/AssetApi.md#getassetpictures) | **GET** /assets/{id}/pictures | Get asset pictures
*AssetApi* | [**GetAssetProductOptions**](docs/AssetApi.md#getassetproductoptions) | **GET** /assets/{asset_id}/product-options | Get all possible products of the specified assets
*AssetApi* | [**GetAssetStatusesOptions**](docs/AssetApi.md#getassetstatusesoptions) | **GET** /assets/{asset_id}/status-options | Get all possible statuses of the specified assets
*AssetApi* | [**GetAssetTenantOptions**](docs/AssetApi.md#getassettenantoptions) | **GET** /assets/{asset_id}/tenant-options | Get all possible tenants of the specified assets
*AssetApi* | [**GetAssetValueObjectsForKey**](docs/AssetApi.md#getassetvalueobjectsforkey) | **GET** /assets/{asset_id}/value_objects/{key} | Get asset value objects for a specific key.
*AssetApi* | [**GetAssetValues**](docs/AssetApi.md#getassetvalues) | **GET** /assets/{asset_id}/values | Get latest values for the asset.
*AssetApi* | [**GetAssetValuesForKey**](docs/AssetApi.md#getassetvaluesforkey) | **GET** /assets/{asset_id}/values/{key} | Get asset values for a specific key.
*AssetApi* | [**GetAssets**](docs/AssetApi.md#getassets) | **GET** /assets | Get a range of assets
*AssetApi* | [**GetDeliveriesOfAsset**](docs/AssetApi.md#getdeliveriesofasset) | **GET** /assets/{asset_id}/deliveries | Get all deliveries of one asset
*AssetApi* | [**GetDocumentsOfAsset**](docs/AssetApi.md#getdocumentsofasset) | **GET** /assets/{asset_id}/documents | Get all documents of an asset
*AssetApi* | [**GetEventsOfAsset**](docs/AssetApi.md#geteventsofasset) | **GET** /assets/{asset_id}/events | Get all events of one asset
*AssetApi* | [**GetInstrumentationsOfAsset**](docs/AssetApi.md#getinstrumentationsofasset) | **GET** /assets/{asset_id}/instrumentations | Get all instrumentations of one asset
*AssetApi* | [**GetInstrumentationsOfAssetHistory**](docs/AssetApi.md#getinstrumentationsofassethistory) | **GET** /assets/{asset_id}/instrumentations/history | Get all instrumentations an asset was assigned to
*AssetApi* | [**GetNodesOfAsset**](docs/AssetApi.md#getnodesofasset) | **GET** /assets/{asset_id}/nodes | Get all nodes of one asset
*AssetApi* | [**GetSoftwaresOfSoftware**](docs/AssetApi.md#getsoftwaresofsoftware) | **GET** /assets/{asset_id}/softwares | Get a range of software of one asset
*AssetApi* | [**GetSpecificationHistoryOfAsset**](docs/AssetApi.md#getspecificationhistoryofasset) | **GET** /assets/{asset_id}/specifications/{key}/history | Get the history of one specification attribute of an asset.
*AssetApi* | [**GetSpecificationKeysOfAssets**](docs/AssetApi.md#getspecificationkeysofassets) | **GET** /asset/specification_keys | Get existing asset specification keys
*AssetApi* | [**GetSpecificationsOfAsset**](docs/AssetApi.md#getspecificationsofasset) | **GET** /assets/{asset_id}/specifications | Get specifications of an asset
*AssetApi* | [**GetSubscriptionsOfAsset**](docs/AssetApi.md#getsubscriptionsofasset) | **GET** /assets/{asset_id}/subscriptions | Get all subscriptions of asset
*AssetApi* | [**GetSystemsOfAsset**](docs/AssetApi.md#getsystemsofasset) | **GET** /assets/{asset_id}/systems | Get all systems of one Asset
*AssetApi* | [**RemoveAddOnsFromAsset**](docs/AssetApi.md#removeaddonsfromasset) | **DELETE** /assets/{asset_id}/add_ons | Remove add_ons from an asset
*AssetApi* | [**RemoveDeliveriesFromAsset**](docs/AssetApi.md#removedeliveriesfromasset) | **DELETE** /assets/{asset_id}/deliveries | Remove deliveries from an asset
*AssetApi* | [**RemoveDocumentsFromAsset**](docs/AssetApi.md#removedocumentsfromasset) | **DELETE** /assets/{asset_id}/documents | Remove documents from an asset
*AssetApi* | [**RemoveEventFromAsset**](docs/AssetApi.md#removeeventfromasset) | **DELETE** /assets/{asset_id}/events | Remove events from an asset
*AssetApi* | [**RemoveInstrumentationsOfAsset**](docs/AssetApi.md#removeinstrumentationsofasset) | **DELETE** /assets/{asset_id}/instrumentations | Remove instrumentations from an asset
*AssetApi* | [**RemoveNodesFromAsset**](docs/AssetApi.md#removenodesfromasset) | **DELETE** /assets/{asset_id}/nodes | Remove nodes from an asset
*AssetApi* | [**RemoveSoftwaresOfAsset**](docs/AssetApi.md#removesoftwaresofasset) | **DELETE** /assets/{asset_id}/softwares | Remove software from an asset
*AssetApi* | [**RenameSpecificationsOfAsset**](docs/AssetApi.md#renamespecificationsofasset) | **PATCH** /assets/{asset_id}/specifications/rename | Rename a specification key
*AssetApi* | [**ReplaceAddOnsOfAsset**](docs/AssetApi.md#replaceaddonsofasset) | **PATCH** /assets/{asset_id}/add_ons | Replace the add_ons of an asset
*AssetApi* | [**ReplaceDeliveriesOfAsset**](docs/AssetApi.md#replacedeliveriesofasset) | **PATCH** /assets/{asset_id}/deliveries | Replace the deliveries of an asset
*AssetApi* | [**ReplaceDocumentsOfAsset**](docs/AssetApi.md#replacedocumentsofasset) | **PATCH** /assets/{asset_id}/documents | Replace the documents of an asset
*AssetApi* | [**ReplaceInstrumentationsOfAsset**](docs/AssetApi.md#replaceinstrumentationsofasset) | **PATCH** /assets/{asset_id}/instrumentations | Replace the instrumentations of an asset
*AssetApi* | [**ReplaceNodesOfAsset**](docs/AssetApi.md#replacenodesofasset) | **PATCH** /assets/{asset_id}/nodes | Replace the nodes of an asset
*AssetApi* | [**ReplaceSoftwaresOfAsset**](docs/AssetApi.md#replacesoftwaresofasset) | **PATCH** /assets/{asset_id}/softwares | Replace the software of an asset
*AssetApi* | [**UpdateAsset**](docs/AssetApi.md#updateasset) | **PATCH** /assets/{id} | Update an asset
*AssetApi* | [**UpdateAssetPicture**](docs/AssetApi.md#updateassetpicture) | **PATCH** /assets/{asset_id}/pictures/{id} | Update an asset picture
*AssetApi* | [**UpdateAssetPictureLink**](docs/AssetApi.md#updateassetpicturelink) | **PATCH** /assets/{asset_id}/pictures/links/{id} | Update an asset picture link
*AssetApi* | [**UpdateSpecificationsOfAsset**](docs/AssetApi.md#updatespecificationsofasset) | **PATCH** /assets/{asset_id}/specifications | Update specifications of an asset
*AssetApi* | [**UploadAssetPicture**](docs/AssetApi.md#uploadassetpicture) | **POST** /assets/{id}/pictures | Upload an asset picture
*AssetHealthConditionApi* | [**AddHealthConditionsToAsset**](docs/AssetHealthConditionApi.md#addhealthconditionstoasset) | **POST** /assets/{asset_id}/health_conditions | Add health conditions to an asset
*AssetHealthConditionApi* | [**CalculateAssetHealthConditions**](docs/AssetHealthConditionApi.md#calculateassethealthconditions) | **GET** /assets/{asset_id}/health_conditions/calculate | Calculate health conditions of an asset
*AssetHealthConditionApi* | [**CalculateAssetHealthConditionsAndUpdateAsset**](docs/AssetHealthConditionApi.md#calculateassethealthconditionsandupdateasset) | **PATCH** /assets/{asset_id}/health_conditions/calculate | Calculate health conditions of an asset and update asset with this health conditions
*AssetHealthConditionApi* | [**GetAssetHealthConditions**](docs/AssetHealthConditionApi.md#getassethealthconditions) | **GET** /assets/{asset_id}/health_conditions | Get all health conditions assigned to an asset
*AssetHealthConditionApi* | [**GetHealthConditionsOfAssetTimemachine**](docs/AssetHealthConditionApi.md#gethealthconditionsofassettimemachine) | **GET** /assets/{asset_id}/health_conditions/timemachine | Get all health_conditions historical evolution the given asset had assigned
*AssetHealthConditionApi* | [**ReaplaceHealthConditionsOfAsset**](docs/AssetHealthConditionApi.md#reaplacehealthconditionsofasset) | **PATCH** /assets/{asset_id}/health_conditions | Replace health conditions of an asset
*AssetHealthConditionApi* | [**RemoveHealthConditionsOfAsset**](docs/AssetHealthConditionApi.md#removehealthconditionsofasset) | **DELETE** /assets/{asset_id}/health_conditions | Remove health conditions of an asset
*AssetStatusApi* | [**CreateAssetStatus**](docs/AssetStatusApi.md#createassetstatus) | **POST** /asset/statuses | Create a new asset status
*AssetStatusApi* | [**DeleteAssetStatus**](docs/AssetStatusApi.md#deleteassetstatus) | **DELETE** /asset/statuses/{id} | Delete an asset status
*AssetStatusApi* | [**GetAssetIdStatus**](docs/AssetStatusApi.md#getassetidstatus) | **GET** /assets/{asset_id}/status | Get the status of the specific asset
*AssetStatusApi* | [**GetAssetStatusById**](docs/AssetStatusApi.md#getassetstatusbyid) | **GET** /asset/statuses/{id} | Get a single asset status
*AssetStatusApi* | [**GetAssetStatuses**](docs/AssetStatusApi.md#getassetstatuses) | **GET** /asset/statuses | Get a range of asset statuses
*AssetStatusApi* | [**GetAssetStatusesOptions**](docs/AssetStatusApi.md#getassetstatusesoptions) | **GET** /assets/{asset_id}/status-options | Get all possible statuses of the specified assets
*AssetStatusApi* | [**UpdateAssetStatus**](docs/AssetStatusApi.md#updateassetstatus) | **PATCH** /asset/statuses/{id} | Update an asset status
*AttachmentApi* | [**CreateLinkAttachment**](docs/AttachmentApi.md#createlinkattachment) | **POST** /attachments/links | Create a new link as attachment
*AttachmentApi* | [**DeleteAttachment**](docs/AttachmentApi.md#deleteattachment) | **DELETE** /attachments/{id} | Delete an attachment and the file
*AttachmentApi* | [**DownloadAttachment**](docs/AttachmentApi.md#downloadattachment) | **GET** /attachments/{id}/download | Download the attachments file
*AttachmentApi* | [**GetAttachmentById**](docs/AttachmentApi.md#getattachmentbyid) | **GET** /attachments/{id} | Get a single attachment
*AttachmentApi* | [**GetAttachments**](docs/AttachmentApi.md#getattachments) | **GET** /attachments | Get a range of attachments
*AttachmentApi* | [**UpdateAttachment**](docs/AttachmentApi.md#updateattachment) | **PATCH** /attachments/{id} | Update an attachment and especially its file
*AttachmentApi* | [**UpdateLinkAttachment**](docs/AttachmentApi.md#updatelinkattachment) | **PATCH** /attachments/links/{id} | Update an attachment with a link
*AttachmentApi* | [**UploadAttachment**](docs/AttachmentApi.md#uploadattachment) | **POST** /attachments | Create and upload a new attachment
*BillOfMaterialApi* | [**AddDocumentsToBillOfMaterial**](docs/BillOfMaterialApi.md#adddocumentstobillofmaterial) | **POST** /bill_of_materials/{bill_of_material_id}/documents | Add documents to a bill of material
*BillOfMaterialApi* | [**AddInstrumentationsToBillOfMaterial**](docs/BillOfMaterialApi.md#addinstrumentationstobillofmaterial) | **POST** /bill_of_materials/{bill_of_material_id}/instrumentations | Add instrumentations to a bill of material
*BillOfMaterialApi* | [**AddRequestForQuotationsToBillOfMaterial**](docs/BillOfMaterialApi.md#addrequestforquotationstobillofmaterial) | **POST** /bill_of_materials/{bill_of_material_id}/request_for_quotations | Add request for quotations to a bill of material
*BillOfMaterialApi* | [**CreateBillOfMaterial**](docs/BillOfMaterialApi.md#createbillofmaterial) | **POST** /bill_of_materials | Create a new bill of material
*BillOfMaterialApi* | [**DeleteBillOfMaterial**](docs/BillOfMaterialApi.md#deletebillofmaterial) | **DELETE** /bill_of_materials/{id} | Delete a bill of material
*BillOfMaterialApi* | [**GetBillOfMaterialById**](docs/BillOfMaterialApi.md#getbillofmaterialbyid) | **GET** /bill_of_materials/{id} | Get a single bill of material
*BillOfMaterialApi* | [**GetBillOfMaterials**](docs/BillOfMaterialApi.md#getbillofmaterials) | **GET** /bill_of_materials | Get a range of bill of materials
*BillOfMaterialApi* | [**GetDocumentsOfBillOfMaterial**](docs/BillOfMaterialApi.md#getdocumentsofbillofmaterial) | **GET** /bill_of_materials/{bill_of_material_id}/documents | Get all documents of a bill of material
*BillOfMaterialApi* | [**GetInstrumentationsOfBillOfMaterial**](docs/BillOfMaterialApi.md#getinstrumentationsofbillofmaterial) | **GET** /bill_of_materials/{bill_of_material_id}/instrumentations | Get all instrumentations of a bill of material
*BillOfMaterialApi* | [**GetRequestForQuotationsOfBillOfMaterial**](docs/BillOfMaterialApi.md#getrequestforquotationsofbillofmaterial) | **GET** /bill_of_materials/{bill_of_material_id}/request_for_quotations | Get all request for quotations of a bill of material
*BillOfMaterialApi* | [**RemoveDocumentsFromBillOfMaterial**](docs/BillOfMaterialApi.md#removedocumentsfrombillofmaterial) | **DELETE** /bill_of_materials/{bill_of_material_id}/documents | Remove documents from a bill of material
*BillOfMaterialApi* | [**RemoveInstrumentationsFromBillOfMaterial**](docs/BillOfMaterialApi.md#removeinstrumentationsfrombillofmaterial) | **DELETE** /bill_of_materials/{bill_of_material_id}/instrumentations | Remove instrumentations from a bill of material
*BillOfMaterialApi* | [**RemoveRequestForQuotationsOfBillOfMaterial**](docs/BillOfMaterialApi.md#removerequestforquotationsofbillofmaterial) | **DELETE** /bill_of_materials/{bill_of_material_id}/request_for_quotations | Remove request for quotations from a bill of material
*BillOfMaterialApi* | [**ReplaceDocumentsOfBillOfMaterial**](docs/BillOfMaterialApi.md#replacedocumentsofbillofmaterial) | **PATCH** /bill_of_materials/{bill_of_material_id}/documents | Replace the documents of a bill of material
*BillOfMaterialApi* | [**ReplaceInstrumentationsOfBillOfMaterial**](docs/BillOfMaterialApi.md#replaceinstrumentationsofbillofmaterial) | **PATCH** /bill_of_materials/{bill_of_material_id}/instrumentations | Replace the instrumentations of a bill of material
*BillOfMaterialApi* | [**ReplaceRequestForQuotationsOfBillOfMaterial**](docs/BillOfMaterialApi.md#replacerequestforquotationsofbillofmaterial) | **PATCH** /bill_of_materials/{bill_of_material_id}/request_for_quotations | Replace the request for quotations of a bill of material
*BillOfMaterialApi* | [**UpdateBillOfMaterial**](docs/BillOfMaterialApi.md#updatebillofmaterial) | **PATCH** /bill_of_materials/{id} | Update a bill of material
*ClientApplicationApi* | [**AddClientApplicationsToEdgeApplication**](docs/ClientApplicationApi.md#addclientapplicationstoedgeapplication) | **POST** /edge_device/applications/{edge_device_application_id}/client_applications | Add client applications to an edge device application
*ClientApplicationApi* | [**AddTechnicalUsersToClientApplication**](docs/ClientApplicationApi.md#addtechnicaluserstoclientapplication) | **POST** /client_applications/{client_application_id}/technical_users | Add Technical Users of Client Application
*ClientApplicationApi* | [**AddUsersToClientApplicationUserRole**](docs/ClientApplicationApi.md#adduserstoclientapplicationuserrole) | **POST** /client_applications/{client_application_id}/roles/{userrole_id}/users | Add users to a client application user role
*ClientApplicationApi* | [**CreateClientApplication**](docs/ClientApplicationApi.md#createclientapplication) | **POST** /client_applications | Create a new client_application
*ClientApplicationApi* | [**CreateWebhookToClientApplication**](docs/ClientApplicationApi.md#createwebhooktoclientapplication) | **POST** /client_applications/{client_application_id}/webhooks | Create a new webhook for the Client Application
*ClientApplicationApi* | [**DeleteClientApplication**](docs/ClientApplicationApi.md#deleteclientapplication) | **DELETE** /client_applications/{id} | Delete an client_application
*ClientApplicationApi* | [**DeleteUsersFromClientApplicationUserRole**](docs/ClientApplicationApi.md#deleteusersfromclientapplicationuserrole) | **DELETE** /client_applications/{client_application_id}/roles/{userrole_id}/users | Remove users from a client application user role
*ClientApplicationApi* | [**DeleteWebhook**](docs/ClientApplicationApi.md#deletewebhook) | **DELETE** /client_applications/{client_application_id}/webhooks/{id} | Delete a webhook
*ClientApplicationApi* | [**GetAPIKeysOfClientApplication**](docs/ClientApplicationApi.md#getapikeysofclientapplication) | **GET** /client_applications/{client_application_id}/api_keys | GetAPI Keys of Client Application
*ClientApplicationApi* | [**GetClientApplicationById**](docs/ClientApplicationApi.md#getclientapplicationbyid) | **GET** /client_applications/{id} | Get a single client_application
*ClientApplicationApi* | [**GetClientApplications**](docs/ClientApplicationApi.md#getclientapplications) | **GET** /client_applications | Get a range of client_applications
*ClientApplicationApi* | [**GetClientApplicationsOfEdgeDeviceApplication**](docs/ClientApplicationApi.md#getclientapplicationsofedgedeviceapplication) | **GET** /edge_device/applications/{edge_device_application_id}/client_applications | Get all client applications of one edge device application
*ClientApplicationApi* | [**GetCurrentClientApplication**](docs/ClientApplicationApi.md#getcurrentclientapplication) | **GET** /client_applications/current | Get current client_application
*ClientApplicationApi* | [**GetEdgeDeviceApplicationsOfClientApplication**](docs/ClientApplicationApi.md#getedgedeviceapplicationsofclientapplication) | **GET** /client_applications/{client_application_id}/edge_device/applications | Get all edge devices applications for an client application
*ClientApplicationApi* | [**GetTechnicalUsersOfClientApplication**](docs/ClientApplicationApi.md#gettechnicalusersofclientapplication) | **GET** /client_applications/{client_application_id}/technical_users | Get Technical Users of Client Application
*ClientApplicationApi* | [**GetUsersOfClientApplicationUserRole**](docs/ClientApplicationApi.md#getusersofclientapplicationuserrole) | **GET** /client_applications/{client_application_id}/roles/{userrole_id}/users | Get all users of a user role assigned to a client application
*ClientApplicationApi* | [**GetWebhookById**](docs/ClientApplicationApi.md#getwebhookbyid) | **GET** /client_applications/{client_application_id}/webhooks/{id} | Get a single webhook
*ClientApplicationApi* | [**GetWebhookEvents**](docs/ClientApplicationApi.md#getwebhookevents) | **GET** /client_applications/{client_application_id}/webhooks/{id}/events | Get events of a webhook
*ClientApplicationApi* | [**GetWebhooksOfClientApplication**](docs/ClientApplicationApi.md#getwebhooksofclientapplication) | **GET** /client_applications/{client_application_id}/webhooks | Get webhooks of Client Application
*ClientApplicationApi* | [**RemoveClientApplicationsOfEdgeDeviceApplication**](docs/ClientApplicationApi.md#removeclientapplicationsofedgedeviceapplication) | **DELETE** /edge_device/applications/{edge_device_application_id}/client_applications | Remove client applications from an edge device application
*ClientApplicationApi* | [**ReplaceClientApplicationsOfEdgeDeviceApplication**](docs/ClientApplicationApi.md#replaceclientapplicationsofedgedeviceapplication) | **PATCH** /edge_device/applications/{edge_device_application_id}/client_applications | Replace the client applications of an edge device application
*ClientApplicationApi* | [**ResendWebhookEvents**](docs/ClientApplicationApi.md#resendwebhookevents) | **POST** /client_applications/{client_application_id}/webhooks/{id}/events | resend Webhook Events
*ClientApplicationApi* | [**ResetSecretWebhook**](docs/ClientApplicationApi.md#resetsecretwebhook) | **POST** /client_applications/{client_application_id}/webhooks/{id}/reset_secret | Reset the secret property of the webhook
*ClientApplicationApi* | [**UpdateClientApplication**](docs/ClientApplicationApi.md#updateclientapplication) | **PATCH** /client_applications/{id} | Update an client_application
*ClientApplicationApi* | [**UpdateWebhook**](docs/ClientApplicationApi.md#updatewebhook) | **PATCH** /client_applications/{client_application_id}/webhooks/{id} | Update a webhook
*CompanyApi* | [**CreateCompany**](docs/CompanyApi.md#createcompany) | **POST** /companies | Create a new company
*CompanyApi* | [**DeleteCompany**](docs/CompanyApi.md#deletecompany) | **DELETE** /companies/{id} | Delete a company
*CompanyApi* | [**GetAssetCompanyOptions**](docs/CompanyApi.md#getassetcompanyoptions) | **GET** /assets/{asset_id}/company-options | Get all possible companies of the specified assets
*CompanyApi* | [**GetCompanies**](docs/CompanyApi.md#getcompanies) | **GET** /companies | Get a range of companies
*CompanyApi* | [**GetCompanyById**](docs/CompanyApi.md#getcompanybyid) | **GET** /companies/{id} | Get a single company
*CompanyApi* | [**GetDeliveriesReceivedOfCompany**](docs/CompanyApi.md#getdeliveriesreceivedofcompany) | **GET** /companies/{company_id}/deliveries_received | Get all deliveries received of one company
*CompanyApi* | [**GetDeliveriesSentOfCompany**](docs/CompanyApi.md#getdeliveriessentofcompany) | **GET** /companies/{company_id}/deliveries_sent | Get all deliveries sent of one company
*CompanyApi* | [**GetProductsOfCompany**](docs/CompanyApi.md#getproductsofcompany) | **GET** /companies/{company_id}/products | Get all products of a company
*CompanyApi* | [**UpdateCompany**](docs/CompanyApi.md#updatecompany) | **PATCH** /companies/{id} | Update a company
*CustomerApi* | [**CreateCustomer**](docs/CustomerApi.md#createcustomer) | **POST** /customers | Create a new customer
*CustomerApi* | [**DeleteCustomer**](docs/CustomerApi.md#deletecustomer) | **DELETE** /customers/{id} | Delete a customer
*CustomerApi* | [**GetCustomerById**](docs/CustomerApi.md#getcustomerbyid) | **GET** /customers/{id} | Get a single customer
*CustomerApi* | [**GetCustomers**](docs/CustomerApi.md#getcustomers) | **GET** /customers | Get a range of customers
*CustomerApi* | [**UpdateCustomer**](docs/CustomerApi.md#updatecustomer) | **PATCH** /customers/{id} | Update a customer
*DeliveryApi* | [**AddAssetsToDelivery**](docs/DeliveryApi.md#addassetstodelivery) | **POST** /deliveries/{delivery_id}/assets | Add assets to a delivery
*DeliveryApi* | [**AddDocumentsToDelivery**](docs/DeliveryApi.md#adddocumentstodelivery) | **POST** /deliveries/{delivery_id}/documents | Add documents to a delivery
*DeliveryApi* | [**AddPurchaseOrdersToDelivery**](docs/DeliveryApi.md#addpurchaseorderstodelivery) | **POST** /deliveries/{delivery_id}/purchase_orders | Add all purchase oders to a delivery
*DeliveryApi* | [**CreateDelivery**](docs/DeliveryApi.md#createdelivery) | **POST** /deliveries | Create a new delivery
*DeliveryApi* | [**DeleteDelivery**](docs/DeliveryApi.md#deletedelivery) | **DELETE** /deliveries/{id} | Delete a delivery
*DeliveryApi* | [**GetAssetsOfDelivery**](docs/DeliveryApi.md#getassetsofdelivery) | **GET** /deliveries/{delivery_id}/assets | Get all assets of one delivery
*DeliveryApi* | [**GetDeliveries**](docs/DeliveryApi.md#getdeliveries) | **GET** /deliveries | Get a range of deliveries
*DeliveryApi* | [**GetDeliveryById**](docs/DeliveryApi.md#getdeliverybyid) | **GET** /deliveries/{id} | Get a single delivery
*DeliveryApi* | [**GetDeliveryIdStatus**](docs/DeliveryApi.md#getdeliveryidstatus) | **GET** /deliveries/{delivery_id}/status | Get the status of the specific delivery
*DeliveryApi* | [**GetDocumentsOfDelivery**](docs/DeliveryApi.md#getdocumentsofdelivery) | **GET** /deliveries/{delivery_id}/documents | Get all documents of one delivery
*DeliveryApi* | [**GetPurchaseOrdersOfDelivery**](docs/DeliveryApi.md#getpurchaseordersofdelivery) | **GET** /deliveries/{delivery_id}/purchase_orders | Get all purchase orders of one delivery
*DeliveryApi* | [**RemoveAssetsFromDelivery**](docs/DeliveryApi.md#removeassetsfromdelivery) | **DELETE** /deliveries/{delivery_id}/assets | Remove assets from a delivery
*DeliveryApi* | [**RemoveDocumentsFromDelivery**](docs/DeliveryApi.md#removedocumentsfromdelivery) | **DELETE** /deliveries/{delivery_id}/documents | Remove documents from a delivery
*DeliveryApi* | [**RemovePurchaseOrdersFromDelivery**](docs/DeliveryApi.md#removepurchaseordersfromdelivery) | **DELETE** /deliveries/{delivery_id}/purchase_orders | Remove purchase orders from a delivery
*DeliveryApi* | [**ReplaceAssetsOfDelivery**](docs/DeliveryApi.md#replaceassetsofdelivery) | **PATCH** /deliveries/{delivery_id}/assets | Replace the assets of a delivery
*DeliveryApi* | [**ReplaceDocumentsOfDelivery**](docs/DeliveryApi.md#replacedocumentsofdelivery) | **PATCH** /deliveries/{delivery_id}/documents | Replace the documents of a delivery
*DeliveryApi* | [**ReplacePurchaseOrdersOfDelivery**](docs/DeliveryApi.md#replacepurchaseordersofdelivery) | **PATCH** /deliveries/{delivery_id}/purchase_orders | Replace the purchase orders of a delivery
*DeliveryApi* | [**UpdateDelivery**](docs/DeliveryApi.md#updatedelivery) | **PATCH** /deliveries/{id} | Update a delivery
*DeliveryStatusApi* | [**CreateDeliveryStatus**](docs/DeliveryStatusApi.md#createdeliverystatus) | **POST** /delivery/statuses | Create a new delivery status
*DeliveryStatusApi* | [**DeleteDeliveryStatus**](docs/DeliveryStatusApi.md#deletedeliverystatus) | **DELETE** /delivery/statuses/{id} | Delete a delivery status
*DeliveryStatusApi* | [**GetDeliveryIdStatus**](docs/DeliveryStatusApi.md#getdeliveryidstatus) | **GET** /deliveries/{delivery_id}/status | Get the status of the specific delivery
*DeliveryStatusApi* | [**GetDeliveryStatusById**](docs/DeliveryStatusApi.md#getdeliverystatusbyid) | **GET** /delivery/statuses/{id} | Get a single delivery status
*DeliveryStatusApi* | [**GetDeliveryStatuses**](docs/DeliveryStatusApi.md#getdeliverystatuses) | **GET** /delivery/statuses | Get a range of delivery statuses
*DeliveryStatusApi* | [**UpdateDeliveryStatuses**](docs/DeliveryStatusApi.md#updatedeliverystatuses) | **PATCH** /delivery/statuses/{id} | Update an delivery status
*DocumentApi* | [**AddCategoriesToDocument**](docs/DocumentApi.md#addcategoriestodocument) | **POST** /documents/{document_id}/categories | Add categories to a document
*DocumentApi* | [**CreateDocument**](docs/DocumentApi.md#createdocument) | **POST** /documents | Create a new document
*DocumentApi* | [**DeleteDocument**](docs/DocumentApi.md#deletedocument) | **DELETE** /documents/{id} | Delete a document
*DocumentApi* | [**DownloadDocument**](docs/DocumentApi.md#downloaddocument) | **GET** /documents/{id}/download | Download multiple attachments of a document
*DocumentApi* | [**GetAssetsOfDocument**](docs/DocumentApi.md#getassetsofdocument) | **GET** /documents/{document_id}/assets | Get all assets of one document
*DocumentApi* | [**GetAttachmentsOfDocument**](docs/DocumentApi.md#getattachmentsofdocument) | **GET** /documents/{document_id}/attachments | Get all attachments of one document
*DocumentApi* | [**GetBillOfMaterialsOfDocument**](docs/DocumentApi.md#getbillofmaterialsofdocument) | **GET** /documents/{document_id}/bill_of_materials | Get all bill of materials of one document
*DocumentApi* | [**GetCategoriesOfDocument**](docs/DocumentApi.md#getcategoriesofdocument) | **GET** /documents/{document_id}/categories | Get all categories of one document
*DocumentApi* | [**GetCategoriesOptionsOfDocument**](docs/DocumentApi.md#getcategoriesoptionsofdocument) | **GET** /documents/{document_id}/categories-options | Get all possible categories for the specified document
*DocumentApi* | [**GetDeliveriesOfDocument**](docs/DocumentApi.md#getdeliveriesofdocument) | **GET** /documents/{document_id}/deliveries | Get all deliveries of one document
*DocumentApi* | [**GetDocumentById**](docs/DocumentApi.md#getdocumentbyid) | **GET** /documents/{id} | Get a single document
*DocumentApi* | [**GetDocumentClassificationsOptions**](docs/DocumentApi.md#getdocumentclassificationsoptions) | **GET** /documents/{document_id}/classification-options | Get all possible classifications for the specified document
*DocumentApi* | [**GetDocumentIdClassification**](docs/DocumentApi.md#getdocumentidclassification) | **GET** /documents/{document_id}/classification | Get the classification of a specific document
*DocumentApi* | [**GetDocumentIdStatus**](docs/DocumentApi.md#getdocumentidstatus) | **GET** /documents/{document_id}/status | Get the status of a specific document
*DocumentApi* | [**GetDocumentStatusesOptions**](docs/DocumentApi.md#getdocumentstatusesoptions) | **GET** /documents/{document_id}/status-options | Get all possible statuses for the specified document
*DocumentApi* | [**GetDocuments**](docs/DocumentApi.md#getdocuments) | **GET** /documents | Get a range of documents
*DocumentApi* | [**GetEventsOfDocument**](docs/DocumentApi.md#geteventsofdocument) | **GET** /documents/{document_id}/events | Get all events of one document
*DocumentApi* | [**GetInstrumentationsOfDocument**](docs/DocumentApi.md#getinstrumentationsofdocument) | **GET** /documents/{document_id}/instrumentations | Get all instrumentations of one document
*DocumentApi* | [**GetNodesOfDocument**](docs/DocumentApi.md#getnodesofdocument) | **GET** /documents/{document_id}/nodes | Get all nodes of one document
*DocumentApi* | [**GetProductsOfDocument**](docs/DocumentApi.md#getproductsofdocument) | **GET** /documents/{document_id}/products | Get all products of one document
*DocumentApi* | [**GetPurchaseOrdersOfDocument**](docs/DocumentApi.md#getpurchaseordersofdocument) | **GET** /documents/{document_id}/purchase_orders | Get all purchase orders of one document
*DocumentApi* | [**GetQuotationsOfDocument**](docs/DocumentApi.md#getquotationsofdocument) | **GET** /documents/{document_id}/quotations | Get all quotations of one document
*DocumentApi* | [**GetRequestForQuotationsOfDocument**](docs/DocumentApi.md#getrequestforquotationsofdocument) | **GET** /documents/{document_id}/request_for_quotations | Get all request for quotations of one document
*DocumentApi* | [**RemoveCategoriesFromDocument**](docs/DocumentApi.md#removecategoriesfromdocument) | **DELETE** /documents/{document_id}/categories | Remove categories from a document
*DocumentApi* | [**ReplaceCategoriesOfDocument**](docs/DocumentApi.md#replacecategoriesofdocument) | **PATCH** /documents/{document_id}/categories | Replace the categories of a document
*DocumentApi* | [**UpdateDocument**](docs/DocumentApi.md#updatedocument) | **PATCH** /documents/{id} | Update a document
*DocumentCategoryApi* | [**AddDocumentsToDocumentCategory**](docs/DocumentCategoryApi.md#adddocumentstodocumentcategory) | **POST** /document/categories/{category_id}/documents | Add documents to a category
*DocumentCategoryApi* | [**CreateDocumentCategory**](docs/DocumentCategoryApi.md#createdocumentcategory) | **POST** /document/categories | Create a new document category
*DocumentCategoryApi* | [**DeleteDocumentCategory**](docs/DocumentCategoryApi.md#deletedocumentcategory) | **DELETE** /document/categories/{id} | Delete a document category
*DocumentCategoryApi* | [**GetCategoriesOfDocument**](docs/DocumentCategoryApi.md#getcategoriesofdocument) | **GET** /documents/{document_id}/categories | Get all categories of one document
*DocumentCategoryApi* | [**GetCategoriesOptionsOfDocument**](docs/DocumentCategoryApi.md#getcategoriesoptionsofdocument) | **GET** /documents/{document_id}/categories-options | Get all possible categories for the specified document
*DocumentCategoryApi* | [**GetDocumentCategories**](docs/DocumentCategoryApi.md#getdocumentcategories) | **GET** /document/categories | Get a range of document categories
*DocumentCategoryApi* | [**GetDocumentCategoryById**](docs/DocumentCategoryApi.md#getdocumentcategorybyid) | **GET** /document/categories/{id} | Get a single document category
*DocumentCategoryApi* | [**GetDocumentsOfDocumentCategory**](docs/DocumentCategoryApi.md#getdocumentsofdocumentcategory) | **GET** /document/categories/{category_id}/documents | Get all documents of one category
*DocumentCategoryApi* | [**RemoveDocumentsFromDocumentCategory**](docs/DocumentCategoryApi.md#removedocumentsfromdocumentcategory) | **DELETE** /document/categories/{category_id}/documents | Remove documents from a category
*DocumentCategoryApi* | [**ReplaceDocumentsOfDocumentCategory**](docs/DocumentCategoryApi.md#replacedocumentsofdocumentcategory) | **PATCH** /document/categories/{category_id}/documents | Replace documents of a category
*DocumentCategoryApi* | [**UpdateDocumentCategory**](docs/DocumentCategoryApi.md#updatedocumentcategory) | **PATCH** /document/categories/{id} | Update a document category
*DocumentClassificationApi* | [**CreateDocumentClassification**](docs/DocumentClassificationApi.md#createdocumentclassification) | **POST** /document/classifications | Create a new document classification
*DocumentClassificationApi* | [**DeleteDocumentClassification**](docs/DocumentClassificationApi.md#deletedocumentclassification) | **DELETE** /document/classifications/{id} | Delete a document classification
*DocumentClassificationApi* | [**GetDocumentClassificationById**](docs/DocumentClassificationApi.md#getdocumentclassificationbyid) | **GET** /document/classifications/{id} | Get a single document classification
*DocumentClassificationApi* | [**GetDocumentClassifications**](docs/DocumentClassificationApi.md#getdocumentclassifications) | **GET** /document/classifications | Get a range of document classifications
*DocumentClassificationApi* | [**GetDocumentClassificationsOptions**](docs/DocumentClassificationApi.md#getdocumentclassificationsoptions) | **GET** /documents/{document_id}/classification-options | Get all possible classifications for the specified document
*DocumentClassificationApi* | [**GetDocumentIdClassification**](docs/DocumentClassificationApi.md#getdocumentidclassification) | **GET** /documents/{document_id}/classification | Get the classification of a specific document
*DocumentClassificationApi* | [**UpdateDocumentClassification**](docs/DocumentClassificationApi.md#updatedocumentclassification) | **PATCH** /document/classifications/{id} | Update a document classification
*DocumentStatusApi* | [**CreateDocumentStatus**](docs/DocumentStatusApi.md#createdocumentstatus) | **POST** /document/statuses | Create a new document status
*DocumentStatusApi* | [**DeleteDocumentStatus**](docs/DocumentStatusApi.md#deletedocumentstatus) | **DELETE** /document/statuses/{id} | Delete a document status
*DocumentStatusApi* | [**GetDocumentIdStatus**](docs/DocumentStatusApi.md#getdocumentidstatus) | **GET** /documents/{document_id}/status | Get the status of a specific document
*DocumentStatusApi* | [**GetDocumentStatusById**](docs/DocumentStatusApi.md#getdocumentstatusbyid) | **GET** /document/statuses/{id} | Get a single document status
*DocumentStatusApi* | [**GetDocumentStatuses**](docs/DocumentStatusApi.md#getdocumentstatuses) | **GET** /document/statuses | Get a range of document statuses
*DocumentStatusApi* | [**GetDocumentStatusesOptions**](docs/DocumentStatusApi.md#getdocumentstatusesoptions) | **GET** /documents/{document_id}/status-options | Get all possible statuses for the specified document
*DocumentStatusApi* | [**UpdateDocumentStatus**](docs/DocumentStatusApi.md#updatedocumentstatus) | **PATCH** /document/statuses/{id} | Update a document status
*EventApi* | [**AddDocumentsToEvent**](docs/EventApi.md#adddocumentstoevent) | **POST** /events/{event_id}/documents | Add documents to an event
*EventApi* | [**CreateEvent**](docs/EventApi.md#createevent) | **POST** /events | Create a new event
*EventApi* | [**CreateEventForAsset**](docs/EventApi.md#createeventforasset) | **POST** /assets/{asset_id}/events | Create a new event for an asset
*EventApi* | [**CreateEventForInstrumentation**](docs/EventApi.md#createeventforinstrumentation) | **POST** /instrumentations/{instrumentation_id}/events | Create a new event for an instrumentation
*EventApi* | [**DeleteEvent**](docs/EventApi.md#deleteevent) | **DELETE** /events/{id} | Delete an event
*EventApi* | [**GetAssetsOfEvent**](docs/EventApi.md#getassetsofevent) | **GET** /events/{event_id}/assets | Get all assets of one event
*EventApi* | [**GetDocumentsOfEvent**](docs/EventApi.md#getdocumentsofevent) | **GET** /events/{event_id}/documents | Get all documents of an event
*EventApi* | [**GetEventById**](docs/EventApi.md#geteventbyid) | **GET** /events/{id} | Get a single event
*EventApi* | [**GetEventIdStatus**](docs/EventApi.md#geteventidstatus) | **GET** /events/{event_id}/status | Get the status of a specific event
*EventApi* | [**GetEventIdType**](docs/EventApi.md#geteventidtype) | **GET** /events/{event_id}/type | Get the type of a specific event
*EventApi* | [**GetEventStatusesOptions**](docs/EventApi.md#geteventstatusesoptions) | **GET** /events/{event_id}/status-options | Get all possible statuses for the specified event
*EventApi* | [**GetEventTypeesOptions**](docs/EventApi.md#geteventtypeesoptions) | **GET** /events/{event_id}/type-options | Get all possible types for the specified event
*EventApi* | [**GetEvents**](docs/EventApi.md#getevents) | **GET** /events | Get a range of events
*EventApi* | [**GetEventsOfAsset**](docs/EventApi.md#geteventsofasset) | **GET** /assets/{asset_id}/events | Get all events of one asset
*EventApi* | [**GetEventsOfInstrumentation**](docs/EventApi.md#geteventsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/events | Get all events of one instrumentation
*EventApi* | [**GetInstrumentationsOfEvent**](docs/EventApi.md#getinstrumentationsofevent) | **GET** /events/{event_id}/instrumentations | Get all instrumentations of one event
*EventApi* | [**GetSpecificationsOfEvent**](docs/EventApi.md#getspecificationsofevent) | **GET** /events/{event_id}/specifications | Get specifications of an event
*EventApi* | [**RemoveAssetsFromEvent**](docs/EventApi.md#removeassetsfromevent) | **DELETE** /events/{event_id}/assets | Remove assets from an event
*EventApi* | [**RemoveDocumentsFromEvent**](docs/EventApi.md#removedocumentsfromevent) | **DELETE** /events/{event_id}/documents | Remove documents from an event
*EventApi* | [**RemoveEventFromAsset**](docs/EventApi.md#removeeventfromasset) | **DELETE** /assets/{asset_id}/events | Remove events from an asset
*EventApi* | [**RemoveEventFromInstrumentation**](docs/EventApi.md#removeeventfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/events | Remove events from an instrumentation
*EventApi* | [**RemoveInstrumentationsFromEvent**](docs/EventApi.md#removeinstrumentationsfromevent) | **DELETE** /events/{event_id}/instrumentations | Remove instrumentations from an event
*EventApi* | [**RemoveSpecificationsFromEvent**](docs/EventApi.md#removespecificationsfromevent) | **DELETE** /events/{event_id}/specifications | Delete specifications of an event
*EventApi* | [**RenameSpecificationsOfEvent**](docs/EventApi.md#renamespecificationsofevent) | **PATCH** /events/{event_id}/specifications/rename | Rename a specification key
*EventApi* | [**ReplaceDocumentsOfEvent**](docs/EventApi.md#replacedocumentsofevent) | **PATCH** /events/{event_id}/documents | Replace the documents of an event
*EventApi* | [**UpdateEvent**](docs/EventApi.md#updateevent) | **PATCH** /events/{id} | Update an event
*EventApi* | [**UpdateSpecificationsOfEvent**](docs/EventApi.md#updatespecificationsofevent) | **PATCH** /events/{event_id}/specifications | Update specifications of an event
*EventStatusApi* | [**CreateEventStatus**](docs/EventStatusApi.md#createeventstatus) | **POST** /event/statuses | Create a new event status
*EventStatusApi* | [**DeleteEventStatus**](docs/EventStatusApi.md#deleteeventstatus) | **DELETE** /event/statuses/{id} | Delete an event status
*EventStatusApi* | [**GetEventIdStatus**](docs/EventStatusApi.md#geteventidstatus) | **GET** /events/{event_id}/status | Get the status of a specific event
*EventStatusApi* | [**GetEventStatusById**](docs/EventStatusApi.md#geteventstatusbyid) | **GET** /event/statuses/{id} | Get a single event status
*EventStatusApi* | [**GetEventStatuses**](docs/EventStatusApi.md#geteventstatuses) | **GET** /event/statuses | Get a range of event statuses
*EventStatusApi* | [**GetEventStatusesOptions**](docs/EventStatusApi.md#geteventstatusesoptions) | **GET** /events/{event_id}/status-options | Get all possible statuses for the specified event
*EventStatusApi* | [**UpdateEventStatus**](docs/EventStatusApi.md#updateeventstatus) | **PATCH** /event/statuses/{id} | Update an event status
*EventTypeApi* | [**CreateEventType**](docs/EventTypeApi.md#createeventtype) | **POST** /event/types | Create a new event type
*EventTypeApi* | [**DeleteEventType**](docs/EventTypeApi.md#deleteeventtype) | **DELETE** /event/types/{id} | Delete an event type
*EventTypeApi* | [**GetEventIdType**](docs/EventTypeApi.md#geteventidtype) | **GET** /events/{event_id}/type | Get the type of a specific event
*EventTypeApi* | [**GetEventTypeById**](docs/EventTypeApi.md#geteventtypebyid) | **GET** /event/types/{id} | Get a single event type
*EventTypeApi* | [**GetEventTypeesOptions**](docs/EventTypeApi.md#geteventtypeesoptions) | **GET** /events/{event_id}/type-options | Get all possible types for the specified event
*EventTypeApi* | [**GetEventTypes**](docs/EventTypeApi.md#geteventtypes) | **GET** /event/types | Get a range of event types
*EventTypeApi* | [**UpdateEventType**](docs/EventTypeApi.md#updateeventtype) | **PATCH** /event/types/{id} | Update an event type
*HealthConditionApi* | [**CreateHealthCondition**](docs/HealthConditionApi.md#createhealthcondition) | **POST** /health_conditions | Create a new health condition
*HealthConditionApi* | [**DeleteHealthCondition**](docs/HealthConditionApi.md#deletehealthcondition) | **DELETE** /health_conditions/{id} | Delete a health condition
*HealthConditionApi* | [**GetHealthConditionById**](docs/HealthConditionApi.md#gethealthconditionbyid) | **GET** /health_conditions/{id} | Get a single health condition
*HealthConditionApi* | [**GetHealthConditions**](docs/HealthConditionApi.md#gethealthconditions) | **GET** /health_conditions | Get a range of health conditions
*HealthConditionApi* | [**UpdateHealthCondition**](docs/HealthConditionApi.md#updatehealthcondition) | **PATCH** /health_conditions/{id} | Update a health condition
*HealthConditionCauseApi* | [**CreateHealthConditionCause**](docs/HealthConditionCauseApi.md#createhealthconditioncause) | **POST** /health_conditions/{health_condition_id}/causes | Create a health condition cause
*HealthConditionCauseApi* | [**DeleteCause**](docs/HealthConditionCauseApi.md#deletecause) | **DELETE** /health_conditions/{health_condition_id}/causes/{id} | Delete a health condition cause
*HealthConditionCauseApi* | [**GetHealthConditionCauseById**](docs/HealthConditionCauseApi.md#gethealthconditioncausebyid) | **GET** /health_conditions/{health_condition_id}/causes/{id} | Get a single health condition cause
*HealthConditionCauseApi* | [**GetHealthConditionCauses**](docs/HealthConditionCauseApi.md#gethealthconditioncauses) | **GET** /health_conditions/{health_condition_id}/causes | Get all causes of a health condition
*HealthConditionCauseApi* | [**UpdateHealthConditionCause**](docs/HealthConditionCauseApi.md#updatehealthconditioncause) | **PATCH** /health_conditions/{health_condition_id}/causes/{id} | Update a health condition cause
*HealthConditionRemedyApi* | [**CreateHealthConditionRemedy**](docs/HealthConditionRemedyApi.md#createhealthconditionremedy) | **POST** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies | Create a remedy
*HealthConditionRemedyApi* | [**DeleteHealthConditionRemedy**](docs/HealthConditionRemedyApi.md#deletehealthconditionremedy) | **DELETE** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies/{id} | Delete a remedy
*HealthConditionRemedyApi* | [**GetHealthConditionRemedies**](docs/HealthConditionRemedyApi.md#gethealthconditionremedies) | **GET** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies | Get all remedies of a cause
*HealthConditionRemedyApi* | [**GetHealthConditionRemedyById**](docs/HealthConditionRemedyApi.md#gethealthconditionremedybyid) | **GET** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies/{id} | Get a single remedy
*HealthConditionRemedyApi* | [**UpdateHealthConditionRemedy**](docs/HealthConditionRemedyApi.md#updatehealthconditionremedy) | **PATCH** /health_conditions/{health_condition_id}/causes/{cause_id}/remedies/{id} | Update a remedy
*InstrumentationApi* | [**AddAssetsToInstrumentation**](docs/InstrumentationApi.md#addassetstoinstrumentation) | **POST** /instrumentations/{instrumentation_id}/assets | Add assets to an instrumentation
*InstrumentationApi* | [**AddBillOfMaterialsToInstrumentation**](docs/InstrumentationApi.md#addbillofmaterialstoinstrumentation) | **POST** /instrumentations/{instrumentation_id}/bill_of_materials | Add bill of materials to an instrumentation
*InstrumentationApi* | [**AddDocumentsToInstrumentation**](docs/InstrumentationApi.md#adddocumentstoinstrumentation) | **POST** /instrumentations/{instrumentation_id}/documents | Add documents to an instrumentation
*InstrumentationApi* | [**AddInstrumentationPictureLink**](docs/InstrumentationApi.md#addinstrumentationpicturelink) | **POST** /instrumentations/{id}/pictures/links | Add a link as instrumentation picture
*InstrumentationApi* | [**AddNodesToInstrumentation**](docs/InstrumentationApi.md#addnodestoinstrumentation) | **POST** /instrumentations/{instrumentation_id}/nodes | Add nodes to an instrumentation
*InstrumentationApi* | [**CreateEventForInstrumentation**](docs/InstrumentationApi.md#createeventforinstrumentation) | **POST** /instrumentations/{instrumentation_id}/events | Create a new event for an instrumentation
*InstrumentationApi* | [**CreateInstrumentation**](docs/InstrumentationApi.md#createinstrumentation) | **POST** /instrumentations | Create a new instrumentation
*InstrumentationApi* | [**CreateInstrumentationThreshold**](docs/InstrumentationApi.md#createinstrumentationthreshold) | **POST** /instrumentations/{instrumentation_id}/thresholds | Create an instrumentation threshold
*InstrumentationApi* | [**DeleteInstrumentation**](docs/InstrumentationApi.md#deleteinstrumentation) | **DELETE** /instrumentations/{id} | Delete an instrumentation
*InstrumentationApi* | [**DeleteInstrumentationPicture**](docs/InstrumentationApi.md#deleteinstrumentationpicture) | **DELETE** /instrumentations/{instrumentation_id}/pictures/{id} | Delete an instrumentation picture
*InstrumentationApi* | [**DeleteInstrumentationThreshold**](docs/InstrumentationApi.md#deleteinstrumentationthreshold) | **DELETE** /instrumentations/{instrumentation_id}/thresholds/{id} | Delete an instrumentation threshold.
*InstrumentationApi* | [**DownloadInstrumentationPicture**](docs/InstrumentationApi.md#downloadinstrumentationpicture) | **GET** /instrumentations/{instrumentation_id}/pictures/{id}/download | Download an instrumentation picture
*InstrumentationApi* | [**GetAssetsOfInstrumentation**](docs/InstrumentationApi.md#getassetsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/assets | Get all assets of one instrumentation
*InstrumentationApi* | [**GetAssetsOfInstrumentationHistory**](docs/InstrumentationApi.md#getassetsofinstrumentationhistory) | **GET** /instrumentations/{instrumentation_id}/assets/history | Get all assets an instrumentation was assigned to
*InstrumentationApi* | [**GetBillOfMaterialsOfInstrumentation**](docs/InstrumentationApi.md#getbillofmaterialsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/bill_of_materials | Get all bill of materials of an instrumentation
*InstrumentationApi* | [**GetDocumentsOfInstrumentation**](docs/InstrumentationApi.md#getdocumentsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/documents | Get all documents of an instrumentation
*InstrumentationApi* | [**GetEventsOfInstrumentation**](docs/InstrumentationApi.md#geteventsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/events | Get all events of one instrumentation
*InstrumentationApi* | [**GetInstrumentationById**](docs/InstrumentationApi.md#getinstrumentationbyid) | **GET** /instrumentations/{id} | Get a single instrumentation
*InstrumentationApi* | [**GetInstrumentationIdStatus**](docs/InstrumentationApi.md#getinstrumentationidstatus) | **GET** /instrumentations/{instrumentation_id}/status | Get the status of the specific instrumentation
*InstrumentationApi* | [**GetInstrumentationIdType**](docs/InstrumentationApi.md#getinstrumentationidtype) | **GET** /instrumentations/{instrumentation_id}/type | Get the type of the specific instrumentation
*InstrumentationApi* | [**GetInstrumentationPicture**](docs/InstrumentationApi.md#getinstrumentationpicture) | **GET** /instrumentations/{instrumentation_id}/pictures/{id} | Get an instrumentation picture
*InstrumentationApi* | [**GetInstrumentationPictures**](docs/InstrumentationApi.md#getinstrumentationpictures) | **GET** /instrumentations/{id}/pictures | Get instrumentation pictures
*InstrumentationApi* | [**GetInstrumentationStatusesOptions**](docs/InstrumentationApi.md#getinstrumentationstatusesoptions) | **GET** /instrumentations/{instrumentation_id}/status-options | Get all possible statuses of the specified instrumentation
*InstrumentationApi* | [**GetInstrumentationThreshold**](docs/InstrumentationApi.md#getinstrumentationthreshold) | **GET** /instrumentations/{instrumentation_id}/thresholds/{id} | Get an instrumentation threshold
*InstrumentationApi* | [**GetInstrumentationThresholds**](docs/InstrumentationApi.md#getinstrumentationthresholds) | **GET** /instrumentations/{instrumentation_id}/thresholds | Get instrumentation thresholds
*InstrumentationApi* | [**GetInstrumentationTypesOptions**](docs/InstrumentationApi.md#getinstrumentationtypesoptions) | **GET** /instrumentations/{instrumentation_id}/type-options | Get all possible types of the specified instrumentation
*InstrumentationApi* | [**GetInstrumentationValueObjectsForKey**](docs/InstrumentationApi.md#getinstrumentationvalueobjectsforkey) | **GET** /instrumentations/{instrumentation_id}/value_objects/{key} | Get instrumentation value objects for a specific key.
*InstrumentationApi* | [**GetInstrumentationValues**](docs/InstrumentationApi.md#getinstrumentationvalues) | **GET** /instrumentations/{instrumentation_id}/values | Get latest values for the instrumentation.
*InstrumentationApi* | [**GetInstrumentationValuesForKey**](docs/InstrumentationApi.md#getinstrumentationvaluesforkey) | **GET** /instrumentations/{instrumentation_id}/values/{key} | Get instrumentation values for a specific key.
*InstrumentationApi* | [**GetInstrumentations**](docs/InstrumentationApi.md#getinstrumentations) | **GET** /instrumentations | Get a range of instrumentations
*InstrumentationApi* | [**GetNodesOfInstrumentation**](docs/InstrumentationApi.md#getnodesofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/nodes | Get all nodes of one Instrumentation
*InstrumentationApi* | [**GetSpecificationHistoryOfInstrumentation**](docs/InstrumentationApi.md#getspecificationhistoryofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/specifications/{key}/history | Get the history of one specification attribute of an instrumentation.
*InstrumentationApi* | [**GetSpecificationKeysOfInstrumentations**](docs/InstrumentationApi.md#getspecificationkeysofinstrumentations) | **GET** /instrumentation/specification_keys | Get existing instrumentation specification keys
*InstrumentationApi* | [**GetSpecificationsOfInstrumentation**](docs/InstrumentationApi.md#getspecificationsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/specifications | Get specifications of an instrumentation
*InstrumentationApi* | [**GetSystemsOfInstrumentation**](docs/InstrumentationApi.md#getsystemsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/systems | Get all systems of one instrumentation
*InstrumentationApi* | [**RemoveAssetsFromInstrumentation**](docs/InstrumentationApi.md#removeassetsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/assets | Remove assets from an instrumentation
*InstrumentationApi* | [**RemoveBillOfMaterialsFromInstrumentation**](docs/InstrumentationApi.md#removebillofmaterialsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/bill_of_materials | Remove bill of materials from an instrumentation
*InstrumentationApi* | [**RemoveDocumentsFromInstrumentation**](docs/InstrumentationApi.md#removedocumentsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/documents | Remove documents from an instrumentation
*InstrumentationApi* | [**RemoveEventFromInstrumentation**](docs/InstrumentationApi.md#removeeventfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/events | Remove events from an instrumentation
*InstrumentationApi* | [**RemoveNodesFromInstrumentation**](docs/InstrumentationApi.md#removenodesfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/nodes | Remove nodes from an instrumentation
*InstrumentationApi* | [**RemoveSpecificationsFromInstrumentation**](docs/InstrumentationApi.md#removespecificationsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/specifications | Delete specifications of an instrumentation
*InstrumentationApi* | [**RenameSpecificationsOfInstrumentation**](docs/InstrumentationApi.md#renamespecificationsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/specifications/rename | Rename a specification key
*InstrumentationApi* | [**ReplaceAssetsOfInstrumentation**](docs/InstrumentationApi.md#replaceassetsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/assets | Replace the assets of an instrumentation
*InstrumentationApi* | [**ReplaceBillOfMaterialsOfInstrumentation**](docs/InstrumentationApi.md#replacebillofmaterialsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/bill_of_materials | Replace the bill of materials of an instrumentation
*InstrumentationApi* | [**ReplaceDocumentsOfInstrumentation**](docs/InstrumentationApi.md#replacedocumentsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/documents | Replace the documents of an instrumentation
*InstrumentationApi* | [**ReplaceNodesOfInstrumentation**](docs/InstrumentationApi.md#replacenodesofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/nodes | Replace the nodes of an instrumentation
*InstrumentationApi* | [**UpdateInstrumentation**](docs/InstrumentationApi.md#updateinstrumentation) | **PATCH** /instrumentations/{id} | Update an instrumentation
*InstrumentationApi* | [**UpdateInstrumentationPicture**](docs/InstrumentationApi.md#updateinstrumentationpicture) | **PATCH** /instrumentations/{instrumentation_id}/pictures/{id} | Update an instrumentation picture
*InstrumentationApi* | [**UpdateInstrumentationPictureLink**](docs/InstrumentationApi.md#updateinstrumentationpicturelink) | **PATCH** /instrumentations/{instrumentation_id}/pictures/links/{id} | Update an instrumentation picture link
*InstrumentationApi* | [**UpdateInstrumentationThreshold**](docs/InstrumentationApi.md#updateinstrumentationthreshold) | **PATCH** /instrumentations/{instrumentation_id}/thresholds/{id} | Update an instrumentation threshold
*InstrumentationApi* | [**UpdateSpecificationsOfInstrumentation**](docs/InstrumentationApi.md#updatespecificationsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/specifications | Update specifications of an instrumentation
*InstrumentationApi* | [**UploadInstrumentationPicture**](docs/InstrumentationApi.md#uploadinstrumentationpicture) | **POST** /instrumentations/{id}/pictures | Upload an instrumentation picture
*InstrumentationStatusApi* | [**CreateInstrumentationStatus**](docs/InstrumentationStatusApi.md#createinstrumentationstatus) | **POST** /instrumentation/statuses | Create a new instrumentation status
*InstrumentationStatusApi* | [**DeleteInstrumentationStatus**](docs/InstrumentationStatusApi.md#deleteinstrumentationstatus) | **DELETE** /instrumentation/statuses/{id} | Delete an instrumentation status
*InstrumentationStatusApi* | [**GetInstrumentationIdStatus**](docs/InstrumentationStatusApi.md#getinstrumentationidstatus) | **GET** /instrumentations/{instrumentation_id}/status | Get the status of the specific instrumentation
*InstrumentationStatusApi* | [**GetInstrumentationStatusById**](docs/InstrumentationStatusApi.md#getinstrumentationstatusbyid) | **GET** /instrumentation/statuses/{id} | Get a single instrumentation status
*InstrumentationStatusApi* | [**GetInstrumentationStatuses**](docs/InstrumentationStatusApi.md#getinstrumentationstatuses) | **GET** /instrumentation/statuses | Get a range of instrumentation statuses
*InstrumentationStatusApi* | [**GetInstrumentationStatusesOptions**](docs/InstrumentationStatusApi.md#getinstrumentationstatusesoptions) | **GET** /instrumentations/{instrumentation_id}/status-options | Get all possible statuses of the specified instrumentation
*InstrumentationStatusApi* | [**UpdateInstrumentationStatus**](docs/InstrumentationStatusApi.md#updateinstrumentationstatus) | **PATCH** /instrumentation/statuses/{id} | Update an instrumentation status
*InstrumentationTypeApi* | [**CreateInstrumentationType**](docs/InstrumentationTypeApi.md#createinstrumentationtype) | **POST** /instrumentation/types | Create a new instrumentation type
*InstrumentationTypeApi* | [**DeleteInstrumentationType**](docs/InstrumentationTypeApi.md#deleteinstrumentationtype) | **DELETE** /instrumentation/types/{id} | Delete an instrumentation type
*InstrumentationTypeApi* | [**GetInstrumentationIdType**](docs/InstrumentationTypeApi.md#getinstrumentationidtype) | **GET** /instrumentations/{instrumentation_id}/type | Get the type of the specific instrumentation
*InstrumentationTypeApi* | [**GetInstrumentationTypeById**](docs/InstrumentationTypeApi.md#getinstrumentationtypebyid) | **GET** /instrumentation/types/{id} | Get a single instrumentation type
*InstrumentationTypeApi* | [**GetInstrumentationTypes**](docs/InstrumentationTypeApi.md#getinstrumentationtypes) | **GET** /instrumentation/types | Get a range of instrumentation types
*InstrumentationTypeApi* | [**GetInstrumentationTypesOptions**](docs/InstrumentationTypeApi.md#getinstrumentationtypesoptions) | **GET** /instrumentations/{instrumentation_id}/type-options | Get all possible types of the specified instrumentation
*InstrumentationTypeApi* | [**UpdateInstrumentationType**](docs/InstrumentationTypeApi.md#updateinstrumentationtype) | **PATCH** /instrumentation/types/{id} | Update an instrumentation type
*LookupApi* | [**EhExtendedOrderCodeLookup**](docs/LookupApi.md#ehextendedordercodelookup) | **GET** /endress/extended_order_code_lookup | lookup for the extended order code for Endress+Hauser products
*LookupApi* | [**EhProductLookup**](docs/LookupApi.md#ehproductlookup) | **GET** /endress/product_lookup | lookup for Endress+Hauser products with asset specific search criterias
*LookupApi* | [**EhSuccessorLookup**](docs/LookupApi.md#ehsuccessorlookup) | **GET** /endress/successor_lookup | lookup for Endress+Hauser successor products
*NodeApi* | [**AddAssetsToNode**](docs/NodeApi.md#addassetstonode) | **POST** /nodes/{node_id}/assets | Add assets to a node
*NodeApi* | [**AddDocumentsToNode**](docs/NodeApi.md#adddocumentstonode) | **POST** /nodes/{node_id}/documents | Add documents to a node
*NodeApi* | [**AddInstrumentationsToNode**](docs/NodeApi.md#addinstrumentationstonode) | **POST** /nodes/{node_id}/instrumentations | Add instrumentations to a node
*NodeApi* | [**AddNodePictureLink**](docs/NodeApi.md#addnodepicturelink) | **POST** /nodes/{id}/pictures/links | Add a link as node picture
*NodeApi* | [**AddRecipesToNode**](docs/NodeApi.md#addrecipestonode) | **POST** /nodes/{node_id}/recipes | Add recipes to a node
*NodeApi* | [**AddSystemsToNode**](docs/NodeApi.md#addsystemstonode) | **POST** /nodes/{node_id}/systems | Add systems to a node
*NodeApi* | [**CreateNodes**](docs/NodeApi.md#createnodes) | **POST** /nodes | Create a new node
*NodeApi* | [**DeleteNode**](docs/NodeApi.md#deletenode) | **DELETE** /nodes/{id} | Delete a node
*NodeApi* | [**DeleteNodePicture**](docs/NodeApi.md#deletenodepicture) | **DELETE** /nodes/{node_id}/pictures/{id} | Delete an node picture
*NodeApi* | [**DownloadNodePicture**](docs/NodeApi.md#downloadnodepicture) | **GET** /nodes/{node_id}/pictures/{id}/download | Download an node picture
*NodeApi* | [**GetAssetsOfNode**](docs/NodeApi.md#getassetsofnode) | **GET** /nodes/{node_id}/assets | Get all assets of one node
*NodeApi* | [**GetDocumentsOfNode**](docs/NodeApi.md#getdocumentsofnode) | **GET** /nodes/{node_id}/documents | Get all documents of a node
*NodeApi* | [**GetInstrumentationsOfNode**](docs/NodeApi.md#getinstrumentationsofnode) | **GET** /nodes/{node_id}/instrumentations | Get all instrumentations of one node
*NodeApi* | [**GetNodeIdType**](docs/NodeApi.md#getnodeidtype) | **GET** /nodes/{node_id}/type | Get the type of the specific node
*NodeApi* | [**GetNodePicture**](docs/NodeApi.md#getnodepicture) | **GET** /nodes/{node_id}/pictures/{id} | Get an node picture
*NodeApi* | [**GetNodePictures**](docs/NodeApi.md#getnodepictures) | **GET** /nodes/{id}/pictures | Get node pictures
*NodeApi* | [**GetNodeTypesOptions**](docs/NodeApi.md#getnodetypesoptions) | **GET** /nodes/{node_id}/type-options | Get all possible types of the specified node
*NodeApi* | [**GetNodes**](docs/NodeApi.md#getnodes) | **GET** /nodes | Get a range of nodes
*NodeApi* | [**GetNodesById**](docs/NodeApi.md#getnodesbyid) | **GET** /nodes/{id} | Get a single node
*NodeApi* | [**GetRecipesOfNode**](docs/NodeApi.md#getrecipesofnode) | **GET** /nodes/{node_id}/recipes | Get all recipes of one node
*NodeApi* | [**GetSpecificationKeysOfNodes**](docs/NodeApi.md#getspecificationkeysofnodes) | **GET** /node/specification_keys | Get existing asset specification keys
*NodeApi* | [**GetSpecificationsOfNode**](docs/NodeApi.md#getspecificationsofnode) | **GET** /nodes/{node_id}/specifications | Get specifications of a node
*NodeApi* | [**GetSystemsOfNode**](docs/NodeApi.md#getsystemsofnode) | **GET** /nodes/{node_id}/systems | Get all systems of one node
*NodeApi* | [**RemoveAssetsFromNode**](docs/NodeApi.md#removeassetsfromnode) | **DELETE** /nodes/{node_id}/assets | Remove assets from a node
*NodeApi* | [**RemoveDocumentsFromNode**](docs/NodeApi.md#removedocumentsfromnode) | **DELETE** /nodes/{node_id}/documents | Remove documents from a node
*NodeApi* | [**RemoveInstrumentationsFromNode**](docs/NodeApi.md#removeinstrumentationsfromnode) | **DELETE** /nodes/{node_id}/instrumentations | Remove instrumentations from a node
*NodeApi* | [**RemoveRecipesFromNode**](docs/NodeApi.md#removerecipesfromnode) | **DELETE** /nodes/{node_id}/recipes | Remove recipes from a node
*NodeApi* | [**RemoveSpecificationsFromNode**](docs/NodeApi.md#removespecificationsfromnode) | **DELETE** /nodes/{node_id}/specifications | Delete specifications of a node
*NodeApi* | [**RemoveSystemsFromNode**](docs/NodeApi.md#removesystemsfromnode) | **DELETE** /nodes/{node_id}/systems | Remove systems from a node
*NodeApi* | [**RenameSpecificationsOfNode**](docs/NodeApi.md#renamespecificationsofnode) | **PATCH** /nodes/{node_id}/specifications/rename | Rename a specification key
*NodeApi* | [**ReplaceAssetsOfNode**](docs/NodeApi.md#replaceassetsofnode) | **PATCH** /nodes/{node_id}/assets | Replace the assets of a node
*NodeApi* | [**ReplaceDocumentsOfNode**](docs/NodeApi.md#replacedocumentsofnode) | **PATCH** /nodes/{node_id}/documents | Replace the documents of a node
*NodeApi* | [**ReplaceInstrumentationsOfNode**](docs/NodeApi.md#replaceinstrumentationsofnode) | **PATCH** /nodes/{node_id}/instrumentations | Replace the instrumentations of a node
*NodeApi* | [**ReplaceRecipesOfNode**](docs/NodeApi.md#replacerecipesofnode) | **PATCH** /nodes/{node_id}/recipes | Replace the recipes of a node
*NodeApi* | [**ReplaceSystemsOfNode**](docs/NodeApi.md#replacesystemsofnode) | **PATCH** /nodes/{node_id}/systems | Replace the systems of a node
*NodeApi* | [**UpdateNode**](docs/NodeApi.md#updatenode) | **PATCH** /nodes/{id} | Update a node
*NodeApi* | [**UpdateNodePicture**](docs/NodeApi.md#updatenodepicture) | **PATCH** /nodes/{node_id}/pictures/{id} | Update an node picture
*NodeApi* | [**UpdateNodePictureLink**](docs/NodeApi.md#updatenodepicturelink) | **PATCH** /nodes/{node_id}/pictures/links/{id} | Update a node picture link
*NodeApi* | [**UpdateSpecificationsOfNode**](docs/NodeApi.md#updatespecificationsofnode) | **PATCH** /nodes/{node_id}/specifications | Update specifications of a node
*NodeApi* | [**UploadNodePicture**](docs/NodeApi.md#uploadnodepicture) | **POST** /nodes/{id}/pictures | Upload an node picture
*NodeTypeApi* | [**CreateNodeType**](docs/NodeTypeApi.md#createnodetype) | **POST** /node/types | Create a new node type
*NodeTypeApi* | [**DeleteNodeType**](docs/NodeTypeApi.md#deletenodetype) | **DELETE** /node/types/{id} | Delete a node type
*NodeTypeApi* | [**GetNodeIdType**](docs/NodeTypeApi.md#getnodeidtype) | **GET** /nodes/{node_id}/type | Get the type of the specific node
*NodeTypeApi* | [**GetNodeTypeById**](docs/NodeTypeApi.md#getnodetypebyid) | **GET** /node/types/{id} | Get a single node type
*NodeTypeApi* | [**GetNodeTypes**](docs/NodeTypeApi.md#getnodetypes) | **GET** /node/types | Get a range of instrumentation types
*NodeTypeApi* | [**GetNodeTypesOptions**](docs/NodeTypeApi.md#getnodetypesoptions) | **GET** /nodes/{node_id}/type-options | Get all possible types of the specified node
*NodeTypeApi* | [**UpdateNodeType**](docs/NodeTypeApi.md#updatenodetype) | **PATCH** /node/types/{id} | Update a node type
*NotificationApi* | [**AddClientApplicationsToNotification**](docs/NotificationApi.md#addclientapplicationstonotification) | **POST** /notifications/{notification_id}/client_applications | add client_applications to a notification
*NotificationApi* | [**CreateNotification**](docs/NotificationApi.md#createnotification) | **POST** /notifications | Create a new notification
*NotificationApi* | [**DeleteNotification**](docs/NotificationApi.md#deletenotification) | **DELETE** /notifications/{id} | Delete a notification
*NotificationApi* | [**GetClientApplicationsOfNotification**](docs/NotificationApi.md#getclientapplicationsofnotification) | **GET** /notifications/{notification_id}/client_applications | Get all client_applications assigned to a notification
*NotificationApi* | [**GetNotificationById**](docs/NotificationApi.md#getnotificationbyid) | **GET** /notifications/{id} | Get a single notification
*NotificationApi* | [**GetNotifications**](docs/NotificationApi.md#getnotifications) | **GET** /notifications | Get a range of notifications
*NotificationApi* | [**RemoteClientApplicationsFromNotification**](docs/NotificationApi.md#remoteclientapplicationsfromnotification) | **DELETE** /notifications/{notification_id}/client_applications | Remove client_application form a notification
*NotificationApi* | [**ReplaceClientApplicationsOfNotification**](docs/NotificationApi.md#replaceclientapplicationsofnotification) | **PATCH** /notifications/{notification_id}/client_applications | Replace the client_applications of a notification
*NotificationApi* | [**UpdateNotification**](docs/NotificationApi.md#updatenotification) | **PATCH** /notifications/{id} | Update a notification
*PermissionApi* | [**CreatePermissionInheritance**](docs/PermissionApi.md#createpermissioninheritance) | **POST** /permission_inheritances | Create a new permission inheritance
*PermissionApi* | [**CreatePermissions**](docs/PermissionApi.md#createpermissions) | **POST** /permissions | Create a new permission
*PermissionApi* | [**DeletePermission**](docs/PermissionApi.md#deletepermission) | **DELETE** /permissions/{id} | Delete a permission
*PermissionApi* | [**DeletePermissionInheritance**](docs/PermissionApi.md#deletepermissioninheritance) | **DELETE** /permission_inheritances/{id} | Delete a permission inheritance
*PermissionApi* | [**GetPermissionById**](docs/PermissionApi.md#getpermissionbyid) | **GET** /permissions/{id} | Get a single permission
*PermissionApi* | [**GetPermissionInheritanceById**](docs/PermissionApi.md#getpermissioninheritancebyid) | **GET** /permission_inheritances/{id} | Get a single permission inheritance
*PermissionApi* | [**GetPermissionInheritances**](docs/PermissionApi.md#getpermissioninheritances) | **GET** /permission_inheritances | Get a range of permission inheritances
*PermissionApi* | [**GetPermissions**](docs/PermissionApi.md#getpermissions) | **GET** /permissions | Get a range of permissions
*PermissionRequestApi* | [**CreatePermissionRequest**](docs/PermissionRequestApi.md#createpermissionrequest) | **POST** /permission_requests | Create a new permission request
*PermissionRequestApi* | [**DeletePermissionRequest**](docs/PermissionRequestApi.md#deletepermissionrequest) | **DELETE** /permission_requests/{id} | Delete a permission request
*PermissionRequestApi* | [**GetPermissionRequestById**](docs/PermissionRequestApi.md#getpermissionrequestbyid) | **GET** /permission_requests/{id} | Get a single permissionRequest
*PermissionRequestApi* | [**UpdatePermissionRequest**](docs/PermissionRequestApi.md#updatepermissionrequest) | **PATCH** /permission_requests/{id} | Update a permission request
*ProductApi* | [**AddCategoriesToProduct**](docs/ProductApi.md#addcategoriestoproduct) | **POST** /products/{product_id}/categories | Add categories to a product
*ProductApi* | [**AddDocumentsToProduct**](docs/ProductApi.md#adddocumentstoproduct) | **POST** /products/{product_id}/documents | Add documents to a product
*ProductApi* | [**AddEdgeDeviceFeaturesToProduct**](docs/ProductApi.md#addedgedevicefeaturestoproduct) | **POST** /products/{product_id}/edge_device_features | Add edge device features to a product
*ProductApi* | [**AddProductPictureLink**](docs/ProductApi.md#addproductpicturelink) | **POST** /products/{id}/pictures/links | Add a link as product picture
*ProductApi* | [**AddPurchaseOrdersToProduct**](docs/ProductApi.md#addpurchaseorderstoproduct) | **POST** /products/{product_id}/purchase_orders | Add purchase orders to a product
*ProductApi* | [**AddQuotationsToProduct**](docs/ProductApi.md#addquotationstoproduct) | **POST** /products/{product_id}/quotations | Add quotations to a product
*ProductApi* | [**AddSoftwaresToProduct**](docs/ProductApi.md#addsoftwarestoproduct) | **POST** /products/{product_id}/softwares | Add software to a product
*ProductApi* | [**AddSparePartsToProduct**](docs/ProductApi.md#addsparepartstoproduct) | **POST** /products/{product_id}/spare_parts | Add spare parts to a product
*ProductApi* | [**CreateProduct**](docs/ProductApi.md#createproduct) | **POST** /products | Create a new product
*ProductApi* | [**CreateProductFeature**](docs/ProductApi.md#createproductfeature) | **POST** /product_features | Create a new product feature
*ProductApi* | [**CreateProductOption**](docs/ProductApi.md#createproductoption) | **POST** /product_options | Create a new product option
*ProductApi* | [**CreateProductVariant**](docs/ProductApi.md#createproductvariant) | **POST** /product_variants | Create a new product variant
*ProductApi* | [**DeleteCategoriesFromProduct**](docs/ProductApi.md#deletecategoriesfromproduct) | **DELETE** /products/{product_id}/categories | Remove categories from a product
*ProductApi* | [**DeleteProduct**](docs/ProductApi.md#deleteproduct) | **DELETE** /products/{id} | Delete a product
*ProductApi* | [**DeleteProductFeature**](docs/ProductApi.md#deleteproductfeature) | **DELETE** /product_features/{id} | Delete a product feature
*ProductApi* | [**DeleteProductOption**](docs/ProductApi.md#deleteproductoption) | **DELETE** /product_options/{id} | Delete a product option
*ProductApi* | [**DeleteProductPicture**](docs/ProductApi.md#deleteproductpicture) | **DELETE** /products/{product_id}/pictures/{id} | Delete a product picture
*ProductApi* | [**DeleteProductVariant**](docs/ProductApi.md#deleteproductvariant) | **DELETE** /product_variants/{id} | Delete a product variant
*ProductApi* | [**DownloadProductPicture**](docs/ProductApi.md#downloadproductpicture) | **GET** /products/{product_id}/pictures/{id}/download | Download a product picture
*ProductApi* | [**GetAssetProductOptions**](docs/ProductApi.md#getassetproductoptions) | **GET** /assets/{asset_id}/product-options | Get all possible products of the specified assets
*ProductApi* | [**GetCategoriesOfProduct**](docs/ProductApi.md#getcategoriesofproduct) | **GET** /products/{product_id}/categories | Get all categories of a product
*ProductApi* | [**GetCategoriesOptionsOfProduct**](docs/ProductApi.md#getcategoriesoptionsofproduct) | **GET** /products/{product_id}/categories-options | Get all categories of one product
*ProductApi* | [**GetDocumentsOfProduct**](docs/ProductApi.md#getdocumentsofproduct) | **GET** /products/{product_id}/documents | Get all documents of a product
*ProductApi* | [**GetDocumentsOfProductVariant**](docs/ProductApi.md#getdocumentsofproductvariant) | **GET** /product_variants/{product_variant_id}/documents | Get all documents of a product variant
*ProductApi* | [**GetEdgeDeviceFeaturesOfProduct**](docs/ProductApi.md#getedgedevicefeaturesofproduct) | **GET** /products/{product_id}/edge_device_features | Get all edge device features of a product
*ProductApi* | [**GetProductById**](docs/ProductApi.md#getproductbyid) | **GET** /products/{id} | Get a single product
*ProductApi* | [**GetProductFeatureById**](docs/ProductApi.md#getproductfeaturebyid) | **GET** /product_features/{id} | Get a single product feature
*ProductApi* | [**GetProductFeatures**](docs/ProductApi.md#getproductfeatures) | **GET** /product_features | Get a range of product features
*ProductApi* | [**GetProductIdStatus**](docs/ProductApi.md#getproductidstatus) | **GET** /products/{product_id}/status | Get the status of a specific product
*ProductApi* | [**GetProductOptionById**](docs/ProductApi.md#getproductoptionbyid) | **GET** /product_options/{id} | Get a single product option
*ProductApi* | [**GetProductOptions**](docs/ProductApi.md#getproductoptions) | **GET** /product_options | Get a range of product options
*ProductApi* | [**GetProductPicture**](docs/ProductApi.md#getproductpicture) | **GET** /products/{product_id}/pictures/{id} | Get a product picture
*ProductApi* | [**GetProductPictures**](docs/ProductApi.md#getproductpictures) | **GET** /products/{id}/pictures | Get product pictures
*ProductApi* | [**GetProductStatusesOptions**](docs/ProductApi.md#getproductstatusesoptions) | **GET** /products/{product_id}/status-options | Get all possible statuses for the specified product
*ProductApi* | [**GetProductVariantById**](docs/ProductApi.md#getproductvariantbyid) | **GET** /product_variants/{id} | Get a single product variant
*ProductApi* | [**GetProductVariantConfigurations**](docs/ProductApi.md#getproductvariantconfigurations) | **GET** /product_variants/{id}/configurations | get configuration of product variant
*ProductApi* | [**GetProductVariants**](docs/ProductApi.md#getproductvariants) | **GET** /product_variants | Get a range of product variants
*ProductApi* | [**GetProducts**](docs/ProductApi.md#getproducts) | **GET** /products | Get a range of products
*ProductApi* | [**GetProductsOfCompany**](docs/ProductApi.md#getproductsofcompany) | **GET** /companies/{company_id}/products | Get all products of a company
*ProductApi* | [**GetPurchaseOrdersOfProduct**](docs/ProductApi.md#getpurchaseordersofproduct) | **GET** /products/{product_id}/purchase_orders | Get all purchase orders of one product
*ProductApi* | [**GetQuotationsOfProduct**](docs/ProductApi.md#getquotationsofproduct) | **GET** /products/{product_id}/quotations | Get all quotations of one product
*ProductApi* | [**GetSoftwaresOfProduct**](docs/ProductApi.md#getsoftwaresofproduct) | **GET** /products/{product_id}/softwares | Get a range of software of one product
*ProductApi* | [**GetSparePartsOfProduct**](docs/ProductApi.md#getsparepartsofproduct) | **GET** /products/{product_id}/spare_parts | Get all spare parts of a product
*ProductApi* | [**GetSpecificationsOfProduct**](docs/ProductApi.md#getspecificationsofproduct) | **GET** /products/{product_id}/specifications | Get specifications of a product
*ProductApi* | [**RemoveDocumentsFromProduct**](docs/ProductApi.md#removedocumentsfromproduct) | **DELETE** /products/{product_id}/documents | Remove documents from a product
*ProductApi* | [**RemoveEdgeDeviceFeaturesFromProduct**](docs/ProductApi.md#removeedgedevicefeaturesfromproduct) | **DELETE** /products/{product_id}/edge_device_features | Remove edge device features from a product
*ProductApi* | [**RemovePurchaseOrdersFromProduct**](docs/ProductApi.md#removepurchaseordersfromproduct) | **DELETE** /products/{product_id}/purchase_orders | Remove purchase orders from a product
*ProductApi* | [**RemoveQuotationsFromProduct**](docs/ProductApi.md#removequotationsfromproduct) | **DELETE** /products/{product_id}/quotations | Remove quotations from a product
*ProductApi* | [**RemoveSoftwaresOfProduct**](docs/ProductApi.md#removesoftwaresofproduct) | **DELETE** /products/{product_id}/softwares | Remove software from a product
*ProductApi* | [**RemoveSparePartsFromProduct**](docs/ProductApi.md#removesparepartsfromproduct) | **DELETE** /products/{product_id}/spare_parts | Remove spare parts from a product
*ProductApi* | [**RemoveSpecificationsFromProduct**](docs/ProductApi.md#removespecificationsfromproduct) | **DELETE** /products/{product_id}/specifications | Delete specifications of a product
*ProductApi* | [**RenameSpecificationsOfProduct**](docs/ProductApi.md#renamespecificationsofproduct) | **PATCH** /products/{product_id}/specifications/rename | rename a key in the specification.
*ProductApi* | [**ReplaceCategoriesOfProduct**](docs/ProductApi.md#replacecategoriesofproduct) | **PATCH** /products/{product_id}/categories | Replace all categories of a product
*ProductApi* | [**ReplaceDocumentsOfProduct**](docs/ProductApi.md#replacedocumentsofproduct) | **PATCH** /products/{product_id}/documents | Replace the documents of a product
*ProductApi* | [**ReplaceEdgeDeviceFeaturesOfProduct**](docs/ProductApi.md#replaceedgedevicefeaturesofproduct) | **PATCH** /products/{product_id}/edge_device_features | Replace the edge device features of a product
*ProductApi* | [**ReplacePurchaseOrdersOfProduct**](docs/ProductApi.md#replacepurchaseordersofproduct) | **PATCH** /products/{product_id}/purchase_orders | Replace the purchase orders of a product
*ProductApi* | [**ReplaceQuotationsOfProduct**](docs/ProductApi.md#replacequotationsofproduct) | **PATCH** /products/{product_id}/quotations | Replace the quotations of a product
*ProductApi* | [**ReplaceSoftwaresOfProduct**](docs/ProductApi.md#replacesoftwaresofproduct) | **PATCH** /products/{product_id}/softwares | Replace the software of a product
*ProductApi* | [**ReplaceSparePartsOfProduct**](docs/ProductApi.md#replacesparepartsofproduct) | **PATCH** /products/{product_id}/spare_parts | Replace the spare parts of a product
*ProductApi* | [**SetProductVariantConfiguration**](docs/ProductApi.md#setproductvariantconfiguration) | **PATCH** /product_variants/{id}/configurations | update configuration of a product variant
*ProductApi* | [**UpdateProduct**](docs/ProductApi.md#updateproduct) | **PATCH** /products/{id} | Update a product
*ProductApi* | [**UpdateProductFeature**](docs/ProductApi.md#updateproductfeature) | **PATCH** /product_features/{id} | Update a product feature
*ProductApi* | [**UpdateProductOption**](docs/ProductApi.md#updateproductoption) | **PATCH** /product_options/{id} | Update a product option
*ProductApi* | [**UpdateProductPicture**](docs/ProductApi.md#updateproductpicture) | **PATCH** /products/{product_id}/pictures/{id} | Update a product picture
*ProductApi* | [**UpdateProductPictureLink**](docs/ProductApi.md#updateproductpicturelink) | **PATCH** /products/{product_id}/pictures/links/{id} | Update a product picture link
*ProductApi* | [**UpdateProductVariant**](docs/ProductApi.md#updateproductvariant) | **PATCH** /product_variants/{id} | Update a product variant
*ProductApi* | [**UpdateSpecificationsOfProduct**](docs/ProductApi.md#updatespecificationsofproduct) | **PATCH** /products/{product_id}/specifications | Update specifications of a product
*ProductApi* | [**UploadProductPicture**](docs/ProductApi.md#uploadproductpicture) | **POST** /products/{id}/pictures | Upload a product picture
*ProductCategoryApi* | [**AddCategoriesToProduct**](docs/ProductCategoryApi.md#addcategoriestoproduct) | **POST** /products/{product_id}/categories | Add categories to a product
*ProductCategoryApi* | [**AddProductsToProductCategory**](docs/ProductCategoryApi.md#addproductstoproductcategory) | **POST** /product/categories/{category_id}/products | Add products to a category
*ProductCategoryApi* | [**CreateProductCategory**](docs/ProductCategoryApi.md#createproductcategory) | **POST** /product/categories | Create a new product category
*ProductCategoryApi* | [**CreateProductsOfProductCategory**](docs/ProductCategoryApi.md#createproductsofproductcategory) | **GET** /product/categories/{category_id}/products | Get all products of a product category
*ProductCategoryApi* | [**DeleteCategoriesFromProduct**](docs/ProductCategoryApi.md#deletecategoriesfromproduct) | **DELETE** /products/{product_id}/categories | Remove categories from a product
*ProductCategoryApi* | [**DeleteProductCategory**](docs/ProductCategoryApi.md#deleteproductcategory) | **DELETE** /product/categories/{id} | Delete a product category
*ProductCategoryApi* | [**GetCategoriesOfProduct**](docs/ProductCategoryApi.md#getcategoriesofproduct) | **GET** /products/{product_id}/categories | Get all categories of a product
*ProductCategoryApi* | [**GetCategoriesOptionsOfProduct**](docs/ProductCategoryApi.md#getcategoriesoptionsofproduct) | **GET** /products/{product_id}/categories-options | Get all categories of one product
*ProductCategoryApi* | [**GetProductCategories**](docs/ProductCategoryApi.md#getproductcategories) | **GET** /product/categories | Get a range of product categories
*ProductCategoryApi* | [**GetProductCategoryById**](docs/ProductCategoryApi.md#getproductcategorybyid) | **GET** /product/categories/{id} | Get a single product category
*ProductCategoryApi* | [**RemoveProductsFromProductCategory**](docs/ProductCategoryApi.md#removeproductsfromproductcategory) | **DELETE** /product/categories/{category_id}/products | Remove products from a category
*ProductCategoryApi* | [**ReplaceCategoriesOfProduct**](docs/ProductCategoryApi.md#replacecategoriesofproduct) | **PATCH** /products/{product_id}/categories | Replace all categories of a product
*ProductCategoryApi* | [**ReplaceProductsOfProductCategory**](docs/ProductCategoryApi.md#replaceproductsofproductcategory) | **PATCH** /product/categories/{category_id}/products | Replace products of a category
*ProductCategoryApi* | [**UpdateProductCategory**](docs/ProductCategoryApi.md#updateproductcategory) | **PATCH** /product/categories/{id} | Update a product category
*ProductHealthConditionApi* | [**AddHealthConditionsToProduct**](docs/ProductHealthConditionApi.md#addhealthconditionstoproduct) | **POST** /products/{product_id}/health_conditions | Add health conditions to an product
*ProductHealthConditionApi* | [**GetProductHealthConditions**](docs/ProductHealthConditionApi.md#getproducthealthconditions) | **GET** /products/{product_id}/health_conditions | Get all health conditions assigned to an product
*ProductHealthConditionApi* | [**ReaplaceHealthConditionsOfProduct**](docs/ProductHealthConditionApi.md#reaplacehealthconditionsofproduct) | **PATCH** /products/{product_id}/health_conditions | Replace health conditions of an product
*ProductHealthConditionApi* | [**RemoveHealthConditionsOfProduct**](docs/ProductHealthConditionApi.md#removehealthconditionsofproduct) | **DELETE** /products/{product_id}/health_conditions | Remove health conditions of an product
*ProductIdentifierApi* | [**AddProductsToProductIdentifier**](docs/ProductIdentifierApi.md#addproductstoproductidentifier) | **POST** /product/identifiers/{product_identifier_id}/products | Add products to a product identifier
*ProductIdentifierApi* | [**CreateProductIdentifier**](docs/ProductIdentifierApi.md#createproductidentifier) | **POST** /product/identifiers | Create a new product identifier
*ProductIdentifierApi* | [**CreateProductIdentifierForProduct**](docs/ProductIdentifierApi.md#createproductidentifierforproduct) | **POST** /products/{product_id}/identifiers | Create a new product identifier for a product
*ProductIdentifierApi* | [**DeleteProductIdentifier**](docs/ProductIdentifierApi.md#deleteproductidentifier) | **DELETE** /product/identifiers/{id} | Delete a product identifier
*ProductIdentifierApi* | [**GetProductIdentifierById**](docs/ProductIdentifierApi.md#getproductidentifierbyid) | **GET** /product/identifiers/{id} | Get a single product identifier
*ProductIdentifierApi* | [**GetProductIdentifiers**](docs/ProductIdentifierApi.md#getproductidentifiers) | **GET** /product/identifiers | Get a range of product identifiers
*ProductIdentifierApi* | [**GetProductIdentifiersOfProduct**](docs/ProductIdentifierApi.md#getproductidentifiersofproduct) | **GET** /products/{product_id}/identifiers | Get all product identifiers of one product
*ProductIdentifierApi* | [**GetProductsOfProductIdentifier**](docs/ProductIdentifierApi.md#getproductsofproductidentifier) | **GET** /product/identifiers/{product_identifier_id}/products | Get all products of one product identifier
*ProductIdentifierApi* | [**RemoveProductIdentifierFromProduct**](docs/ProductIdentifierApi.md#removeproductidentifierfromproduct) | **DELETE** /products/{product_id}/identifiers | Remove product identifiers from a product
*ProductIdentifierApi* | [**RemoveProductsFromProductIdentifier**](docs/ProductIdentifierApi.md#removeproductsfromproductidentifier) | **DELETE** /product/identifiers/{product_identifier_id}/products | Remove products from a product identifier
*ProductIdentifierApi* | [**UpdateProductIdentifier**](docs/ProductIdentifierApi.md#updateproductidentifier) | **PATCH** /product/identifiers/{id} | Update a product identifier
*ProductStatusApi* | [**DeleteProductStatus**](docs/ProductStatusApi.md#deleteproductstatus) | **DELETE** /product/statuses/{id} | Delete a product status
*ProductStatusApi* | [**GetProductIdStatus**](docs/ProductStatusApi.md#getproductidstatus) | **GET** /products/{product_id}/status | Get the status of a specific product
*ProductStatusApi* | [**GetProductStatusById**](docs/ProductStatusApi.md#getproductstatusbyid) | **GET** /product/statuses/{id} | Get a single product status
*ProductStatusApi* | [**GetProductStatuses**](docs/ProductStatusApi.md#getproductstatuses) | **GET** /product/statuses | Get a range of product statuses
*ProductStatusApi* | [**GetProductStatusesOptions**](docs/ProductStatusApi.md#getproductstatusesoptions) | **GET** /products/{product_id}/status-options | Get all possible statuses for the specified product
*ProductStatusApi* | [**UpdateProductStatus**](docs/ProductStatusApi.md#updateproductstatus) | **PATCH** /product/statuses/{id} | Update a product status
*PurchaseOrderApi* | [**AddDeliviersToPurchaseOrder**](docs/PurchaseOrderApi.md#adddelivierstopurchaseorder) | **POST** /purchase_orders/{purchase_order_id}/deliveries | Add deliveries to a purchase order
*PurchaseOrderApi* | [**AddDocumentsToPurchaseOrder**](docs/PurchaseOrderApi.md#adddocumentstopurchaseorder) | **POST** /purchase_orders/{purchase_order_id}/documents | Add documents to a purchase order
*PurchaseOrderApi* | [**AddProductsToPurchaseOrder**](docs/PurchaseOrderApi.md#addproductstopurchaseorder) | **POST** /purchase_orders/{purchase_order_id}/products | Add products to a purchase order
*PurchaseOrderApi* | [**CreatePurchaseOrder**](docs/PurchaseOrderApi.md#createpurchaseorder) | **POST** /purchase_orders | Create a new purchase order
*PurchaseOrderApi* | [**DeletePurchaseOrder**](docs/PurchaseOrderApi.md#deletepurchaseorder) | **DELETE** /purchase_orders/{id} | Delete a purchase order
*PurchaseOrderApi* | [**GetDeliviersOfPurchaseOrder**](docs/PurchaseOrderApi.md#getdeliviersofpurchaseorder) | **GET** /purchase_orders/{purchase_order_id}/deliveries | Get all deliveries of one purchase order
*PurchaseOrderApi* | [**GetDocumentsOfPurchaseOrder**](docs/PurchaseOrderApi.md#getdocumentsofpurchaseorder) | **GET** /purchase_orders/{purchase_order_id}/documents | Get all documents of one purchase order
*PurchaseOrderApi* | [**GetProductsOfPurchaseOrder**](docs/PurchaseOrderApi.md#getproductsofpurchaseorder) | **GET** /purchase_orders/{purchase_order_id}/products | Get all products of one purchase
*PurchaseOrderApi* | [**GetPurchaseOrderById**](docs/PurchaseOrderApi.md#getpurchaseorderbyid) | **GET** /purchase_orders/{id} | Get a single purchase order
*PurchaseOrderApi* | [**GetPurchaseOrderIdStatus**](docs/PurchaseOrderApi.md#getpurchaseorderidstatus) | **GET** /purchase_orders/{purchase_order_id}/status | Get the status of the specific purchase order
*PurchaseOrderApi* | [**GetPurchaseOrders**](docs/PurchaseOrderApi.md#getpurchaseorders) | **GET** /purchase_orders | Get a range of purchase orders
*PurchaseOrderApi* | [**RemoveDeliviersFromPurchaseOrder**](docs/PurchaseOrderApi.md#removedeliviersfrompurchaseorder) | **DELETE** /purchase_orders/{purchase_order_id}/deliveries | Remove deliveries from a purchase order
*PurchaseOrderApi* | [**RemoveDocumentsFromPurchaseOrder**](docs/PurchaseOrderApi.md#removedocumentsfrompurchaseorder) | **DELETE** /purchase_orders/{purchase_order_id}/documents | Remove documents from a purchase order
*PurchaseOrderApi* | [**RemoveProductsFromPurchaseOrder**](docs/PurchaseOrderApi.md#removeproductsfrompurchaseorder) | **DELETE** /purchase_orders/{purchase_order_id}/products | Remove products from a purchase order
*PurchaseOrderApi* | [**ReplaceDeliviersOfPurchaseOrder**](docs/PurchaseOrderApi.md#replacedeliviersofpurchaseorder) | **PATCH** /purchase_orders/{purchase_order_id}/deliveries | Replace the deliveries of a purchase order
*PurchaseOrderApi* | [**ReplaceDocumentsOfPurchaseOrder**](docs/PurchaseOrderApi.md#replacedocumentsofpurchaseorder) | **PATCH** /purchase_orders/{purchase_order_id}/documents | Replace the documents of a purchase order
*PurchaseOrderApi* | [**ReplaceProductsOfPurchaseOrder**](docs/PurchaseOrderApi.md#replaceproductsofpurchaseorder) | **PATCH** /purchase_orders/{purchase_order_id}/products | Replace the products of a purchase order
*PurchaseOrderApi* | [**UpdateProductQuantitiesOfPurchaseOrder**](docs/PurchaseOrderApi.md#updateproductquantitiesofpurchaseorder) | **PATCH** /purchase_orders/{purchase_order_id}/products/quantity | Change the product quantity in a purchase order
*PurchaseOrderApi* | [**UpdatePurchaseOrder**](docs/PurchaseOrderApi.md#updatepurchaseorder) | **PATCH** /purchase_orders/{id} | Update a purchase order
*PurchaseOrderStatusApi* | [**CreatePurchaseOrderStatus**](docs/PurchaseOrderStatusApi.md#createpurchaseorderstatus) | **POST** /purchase_order/statuses | Create a new purchase order status
*PurchaseOrderStatusApi* | [**DeletePurchaseOrderStatus**](docs/PurchaseOrderStatusApi.md#deletepurchaseorderstatus) | **DELETE** /purchase_order/statuses/{id} | Delete an purchase order status
*PurchaseOrderStatusApi* | [**GetPurchaseOrderIdStatus**](docs/PurchaseOrderStatusApi.md#getpurchaseorderidstatus) | **GET** /purchase_orders/{purchase_order_id}/status | Get the status of the specific purchase order
*PurchaseOrderStatusApi* | [**GetPurchaseOrderStatusById**](docs/PurchaseOrderStatusApi.md#getpurchaseorderstatusbyid) | **GET** /purchase_order/statuses/{id} | Get a single purchase order status
*PurchaseOrderStatusApi* | [**GetPurchaseOrderStatuses**](docs/PurchaseOrderStatusApi.md#getpurchaseorderstatuses) | **GET** /purchase_order/statuses | Get a range of purchase order statuses
*PurchaseOrderStatusApi* | [**UpdatePurchaseOrderStatus**](docs/PurchaseOrderStatusApi.md#updatepurchaseorderstatus) | **PATCH** /purchase_order/statuses/{id} | Update an purchase order status
*QuotationApi* | [**AddDocumentsToQuotation**](docs/QuotationApi.md#adddocumentstoquotation) | **POST** /quotations/{quotation_id}/documents | Add documents to a quotation
*QuotationApi* | [**AddProductsToQuotation**](docs/QuotationApi.md#addproductstoquotation) | **POST** /quotations/{quotation_id}/products | Add products to a quotation
*QuotationApi* | [**AddPurchaseOrdersToQuotation**](docs/QuotationApi.md#addpurchaseorderstoquotation) | **POST** /quotations/{quotation_id}/purchase_orders | Add purchase orders to a quotation
*QuotationApi* | [**CreateQuotation**](docs/QuotationApi.md#createquotation) | **POST** /quotations | Create a new quotation
*QuotationApi* | [**DeleteQuotation**](docs/QuotationApi.md#deletequotation) | **DELETE** /quotations/{id} | Delete a quotation
*QuotationApi* | [**GetDocumentsOfQuotation**](docs/QuotationApi.md#getdocumentsofquotation) | **GET** /quotations/{quotation_id}/documents | Get all documents of one quotation
*QuotationApi* | [**GetProductsOfQuotation**](docs/QuotationApi.md#getproductsofquotation) | **GET** /quotations/{quotation_id}/products | Get all products of one quotation
*QuotationApi* | [**GetPurchaseOrdersOfQuotation**](docs/QuotationApi.md#getpurchaseordersofquotation) | **GET** /quotations/{quotation_id}/purchase_orders | Get all purchase orders of one quotation
*QuotationApi* | [**GetQuotationById**](docs/QuotationApi.md#getquotationbyid) | **GET** /quotations/{id} | Get a single quotation
*QuotationApi* | [**GetQuotationIdStatus**](docs/QuotationApi.md#getquotationidstatus) | **GET** /quotations/{quotation_id}/status | Get the status of the specific quotation
*QuotationApi* | [**GetQuotations**](docs/QuotationApi.md#getquotations) | **GET** /quotations | Get a range of quotations
*QuotationApi* | [**RemoveDocumentsFromQuotation**](docs/QuotationApi.md#removedocumentsfromquotation) | **DELETE** /quotations/{quotation_id}/documents | Remove documents from a quotation
*QuotationApi* | [**RemoveProductsFromQuotation**](docs/QuotationApi.md#removeproductsfromquotation) | **DELETE** /quotations/{quotation_id}/products | Remove products from a quotation
*QuotationApi* | [**RemovePurchaseOrdersFromQuotation**](docs/QuotationApi.md#removepurchaseordersfromquotation) | **DELETE** /quotations/{quotation_id}/purchase_orders | Remove purchase orders from a quotation
*QuotationApi* | [**ReplaceDocumentsOfQuotation**](docs/QuotationApi.md#replacedocumentsofquotation) | **PATCH** /quotations/{quotation_id}/documents | Replace the documents of a quotation
*QuotationApi* | [**ReplaceProductsOfQuotation**](docs/QuotationApi.md#replaceproductsofquotation) | **PATCH** /quotations/{quotation_id}/products | Replace the products of a quotation
*QuotationApi* | [**ReplacePurchaseOrdersOfQuotation**](docs/QuotationApi.md#replacepurchaseordersofquotation) | **PATCH** /quotations/{quotation_id}/purchase_orders | Replace the purchase orders of a quotation
*QuotationApi* | [**UpdateProductQuantitiesOfQuotation**](docs/QuotationApi.md#updateproductquantitiesofquotation) | **PATCH** /quotations/{quotation_id}/products/quantity | Change the product quantity in a quotation
*QuotationApi* | [**UpdateQuotation**](docs/QuotationApi.md#updatequotation) | **PATCH** /quotations/{id} | Update a quotation
*QuotationStatusApi* | [**CreateQuotationStatus**](docs/QuotationStatusApi.md#createquotationstatus) | **POST** /quotation/statuses | Create a new quotation status
*QuotationStatusApi* | [**DeleteQuotationStatus**](docs/QuotationStatusApi.md#deletequotationstatus) | **DELETE** /quotation/statuses/{id} | Delete an quotation status
*QuotationStatusApi* | [**GetQuotationIdStatus**](docs/QuotationStatusApi.md#getquotationidstatus) | **GET** /quotations/{quotation_id}/status | Get the status of the specific quotation
*QuotationStatusApi* | [**GetQuotationStatusById**](docs/QuotationStatusApi.md#getquotationstatusbyid) | **GET** /quotation/statuses/{id} | Get a single quotation status
*QuotationStatusApi* | [**GetQuotationStatuses**](docs/QuotationStatusApi.md#getquotationstatuses) | **GET** /quotation/statuses | Get a range of quotation statuses
*QuotationStatusApi* | [**UpdateQuotationStatus**](docs/QuotationStatusApi.md#updatequotationstatus) | **PATCH** /quotation/statuses/{id} | Update an quotation status
*RequestForQuotationApi* | [**AddBillOfMaterialsToRequestForQuotation**](docs/RequestForQuotationApi.md#addbillofmaterialstorequestforquotation) | **POST** /request_for_quotations/{request_for_quotation_id}/bill_of_materials | Add bill of materials to a request for quotation
*RequestForQuotationApi* | [**AddDocumentsToRequestForQuotation**](docs/RequestForQuotationApi.md#adddocumentstorequestforquotation) | **POST** /request_for_quotations/{request_for_quotation_id}/documents | Add documents to a request for quotation
*RequestForQuotationApi* | [**AddQuotationsToRequestForQuotation**](docs/RequestForQuotationApi.md#addquotationstorequestforquotation) | **POST** /request_for_quotations/{request_for_quotation_id}/quotations | Add quotations to a request for quotation
*RequestForQuotationApi* | [**CreateRequestForQuotation**](docs/RequestForQuotationApi.md#createrequestforquotation) | **POST** /request_for_quotations | Create a new request for quotation
*RequestForQuotationApi* | [**DeleteBillOfMaterialsFromRequestForQuotation**](docs/RequestForQuotationApi.md#deletebillofmaterialsfromrequestforquotation) | **DELETE** /request_for_quotations/{request_for_quotation_id}/bill_of_materials | Remove bill of materials from a request for quotation
*RequestForQuotationApi* | [**DeleteDocumentsOfRequestForQuotation**](docs/RequestForQuotationApi.md#deletedocumentsofrequestforquotation) | **DELETE** /request_for_quotations/{request_for_quotation_id}/documents | Remove documents from a request for quotation
*RequestForQuotationApi* | [**DeleteQuotationsFromRequestForQuotation**](docs/RequestForQuotationApi.md#deletequotationsfromrequestforquotation) | **DELETE** /request_for_quotations/{request_for_quotation_id}/quotations | Remove quotations from a request for quotation
*RequestForQuotationApi* | [**DeleteRequestForQuotation**](docs/RequestForQuotationApi.md#deleterequestforquotation) | **DELETE** /request_for_quotations/{id} | Delete a request for quotation
*RequestForQuotationApi* | [**GetBillOfMaterialsOfRequestForQuotation**](docs/RequestForQuotationApi.md#getbillofmaterialsofrequestforquotation) | **GET** /request_for_quotations/{request_for_quotation_id}/bill_of_materials | Get all bill of materials of one request for quotation
*RequestForQuotationApi* | [**GetDocumentsOfRequestForQuotation**](docs/RequestForQuotationApi.md#getdocumentsofrequestforquotation) | **GET** /request_for_quotations/{request_for_quotation_id}/documents | Get all documents of one request for quotation
*RequestForQuotationApi* | [**GetQuotationsOfRequestForQuotation**](docs/RequestForQuotationApi.md#getquotationsofrequestforquotation) | **GET** /request_for_quotations/{request_for_quotation_id}/quotations | Get all quotations of one request for quotation
*RequestForQuotationApi* | [**GetRequestForQuotationById**](docs/RequestForQuotationApi.md#getrequestforquotationbyid) | **GET** /request_for_quotations/{id} | Get a single request for quotation
*RequestForQuotationApi* | [**GetRequestForQuotationIdStatus**](docs/RequestForQuotationApi.md#getrequestforquotationidstatus) | **GET** /request_for_quotations/{request_for_quotation_id}/status | Get the status of the specific request for quotation
*RequestForQuotationApi* | [**GetRequestForQuotations**](docs/RequestForQuotationApi.md#getrequestforquotations) | **GET** /request_for_quotations | Get a range of request for quotations
*RequestForQuotationApi* | [**ReplaceBillOfMaterialsOfRequestForQuotation**](docs/RequestForQuotationApi.md#replacebillofmaterialsofrequestforquotation) | **PATCH** /request_for_quotations/{request_for_quotation_id}/bill_of_materials | Replace the bill of materials of a request for quotation
*RequestForQuotationApi* | [**ReplaceDocumentsOfRequestForQuotation**](docs/RequestForQuotationApi.md#replacedocumentsofrequestforquotation) | **PATCH** /request_for_quotations/{request_for_quotation_id}/documents | Replace the documents of a request for quotation
*RequestForQuotationApi* | [**ReplaceQuotationsOfRequestForQuotation**](docs/RequestForQuotationApi.md#replacequotationsofrequestforquotation) | **PATCH** /request_for_quotations/{request_for_quotation_id}/quotations | Replace the quotations of a request for quotation
*RequestForQuotationApi* | [**UpdateRequestForQuotation**](docs/RequestForQuotationApi.md#updaterequestforquotation) | **PATCH** /request_for_quotations/{id} | Update a request for quotation
*RequestForQuotationStatusApi* | [**CreateRequestForQuotationStatus**](docs/RequestForQuotationStatusApi.md#createrequestforquotationstatus) | **POST** /request_for_quotation/statuses | Create a new request for quotation status
*RequestForQuotationStatusApi* | [**DeleteRequestForQuotationStatus**](docs/RequestForQuotationStatusApi.md#deleterequestforquotationstatus) | **DELETE** /request_for_quotation/statuses/{id} | Delete an request for quotation status
*RequestForQuotationStatusApi* | [**GetRequestForQuotationIdStatus**](docs/RequestForQuotationStatusApi.md#getrequestforquotationidstatus) | **GET** /request_for_quotations/{request_for_quotation_id}/status | Get the status of the specific request for quotation
*RequestForQuotationStatusApi* | [**GetRequestForQuotationStatusById**](docs/RequestForQuotationStatusApi.md#getrequestforquotationstatusbyid) | **GET** /request_for_quotation/statuses/{id} | Get a single request for quotation status
*RequestForQuotationStatusApi* | [**GetRequestForQuotationStatuses**](docs/RequestForQuotationStatusApi.md#getrequestforquotationstatuses) | **GET** /request_for_quotation/statuses | Get a range of request for quotation statuses
*RequestForQuotationStatusApi* | [**UpdateRequestForQuotationStatus**](docs/RequestForQuotationStatusApi.md#updaterequestforquotationstatus) | **PATCH** /request_for_quotation/statuses/{id} | Update an request for quotation status
*SearchApi* | [**Search**](docs/SearchApi.md#search) | **GET** /search | search assets, batches, instrumentations, nodes, recipes, systems .
*SoftwareApi* | [**CreateSoftware**](docs/SoftwareApi.md#createsoftware) | **POST** /softwares | Create a new software
*SoftwareApi* | [**DeleteSoftware**](docs/SoftwareApi.md#deletesoftware) | **DELETE** /softwares/{id} | Delete a software
*SoftwareApi* | [**GetSoftwareAttachmentsOfSoftware**](docs/SoftwareApi.md#getsoftwareattachmentsofsoftware) | **GET** /softwares/{software_id}/attachments | Get all software attachments of one software
*SoftwareApi* | [**GetSoftwareById**](docs/SoftwareApi.md#getsoftwarebyid) | **GET** /softwares/{id} | Get a single software
*SoftwareApi* | [**GetSoftwares**](docs/SoftwareApi.md#getsoftwares) | **GET** /softwares | Get a range of softwares
*SoftwareApi* | [**UpdateSoftware**](docs/SoftwareApi.md#updatesoftware) | **PATCH** /softwares/{id} | Update a software
*SoftwareAttachmentApi* | [**CreateLinkSoftwareAttachment**](docs/SoftwareAttachmentApi.md#createlinksoftwareattachment) | **POST** /software/attachments/links | Create a new link as software attachment
*SoftwareAttachmentApi* | [**DeleteSoftwareAttachment**](docs/SoftwareAttachmentApi.md#deletesoftwareattachment) | **DELETE** /software/attachments/{id} | Delete a software attachment and the file
*SoftwareAttachmentApi* | [**DownloadSoftwareAttachment**](docs/SoftwareAttachmentApi.md#downloadsoftwareattachment) | **GET** /software/attachments/{id}/download | Download the software attachments file
*SoftwareAttachmentApi* | [**GetSoftwareAttachmentById**](docs/SoftwareAttachmentApi.md#getsoftwareattachmentbyid) | **GET** /software/attachments/{id} | Get a single software attachment
*SoftwareAttachmentApi* | [**GetSoftwareAttachments**](docs/SoftwareAttachmentApi.md#getsoftwareattachments) | **GET** /software/attachments | Get a range of software attachments
*SoftwareAttachmentApi* | [**UpdateLinkSoftwareAttachment**](docs/SoftwareAttachmentApi.md#updatelinksoftwareattachment) | **PATCH** /software/attachments/links/{id} | Update a software attachment with a link
*SoftwareAttachmentApi* | [**UpdateSoftwareAttachment**](docs/SoftwareAttachmentApi.md#updatesoftwareattachment) | **PATCH** /software/attachments/{id} | Update an software attachment and especially its file
*SoftwareAttachmentApi* | [**UploadSoftwareAttachment**](docs/SoftwareAttachmentApi.md#uploadsoftwareattachment) | **POST** /software/attachments | Create and upload a new software attachment
*SparePartApi* | [**AddDocumentsToSparePart**](docs/SparePartApi.md#adddocumentstosparepart) | **POST** /spare_parts/{spare_part_id}/documents | Add document to a spare part
*SparePartApi* | [**CreateSparePart**](docs/SparePartApi.md#createsparepart) | **POST** /spare_parts | Create a new spare part
*SparePartApi* | [**DeleteSparePart**](docs/SparePartApi.md#deletesparepart) | **DELETE** /spare_parts/{id} | Delete a spare part
*SparePartApi* | [**GetDocumentsOfSparePart**](docs/SparePartApi.md#getdocumentsofsparepart) | **GET** /spare_parts/{spare_part_id}/documents | Get all documents of a spare part
*SparePartApi* | [**GetSparePartById**](docs/SparePartApi.md#getsparepartbyid) | **GET** /spare_parts/{id} | Get a single spare part
*SparePartApi* | [**GetSparePartStatusesOptions**](docs/SparePartApi.md#getsparepartstatusesoptions) | **GET** /spare_parts/{spare_part_id}/status-options | Get all possible statuses for the specified spare part
*SparePartApi* | [**GetSparePartTypesOptions**](docs/SparePartApi.md#getspareparttypesoptions) | **GET** /spare_parts/{spare_part_id}/type-options | Get all possible types for the specified spare part
*SparePartApi* | [**GetSpareParts**](docs/SparePartApi.md#getspareparts) | **GET** /spare_parts | Get a range of spare parts
*SparePartApi* | [**RemoveDocumentsFromSparePart**](docs/SparePartApi.md#removedocumentsfromsparepart) | **DELETE** /spare_parts/{spare_part_id}/documents | Remove documents from a spare part
*SparePartApi* | [**ReplaceDocumentsOfSparePart**](docs/SparePartApi.md#replacedocumentsofsparepart) | **PATCH** /spare_parts/{spare_part_id}/documents | Replace the documents of a spare part
*SparePartApi* | [**UpdateSparePart**](docs/SparePartApi.md#updatesparepart) | **PATCH** /spare_parts/{id} | Update a spare part
*SparePartStatusApi* | [**GetSparePartStatusById**](docs/SparePartStatusApi.md#getsparepartstatusbyid) | **GET** /spare_part/statuses/{id} | Get a single spare part status
*SparePartStatusApi* | [**GetSparePartStatuses**](docs/SparePartStatusApi.md#getsparepartstatuses) | **GET** /spare_part/statuses | Get a range of spare part statuses
*SparePartStatusApi* | [**GetSparePartStatusesOptions**](docs/SparePartStatusApi.md#getsparepartstatusesoptions) | **GET** /spare_parts/{spare_part_id}/status-options | Get all possible statuses for the specified spare part
*SparePartTypeApi* | [**CreateSparePartType**](docs/SparePartTypeApi.md#createspareparttype) | **POST** /spare_part/types | Create a new spare part type
*SparePartTypeApi* | [**DeleteSparePartType**](docs/SparePartTypeApi.md#deletespareparttype) | **DELETE** /spare_part/types/{id} | Delete a spare part type
*SparePartTypeApi* | [**GetSparePartTypeById**](docs/SparePartTypeApi.md#getspareparttypebyid) | **GET** /spare_part/types/{id} | Get a single spare part type
*SparePartTypeApi* | [**GetSparePartTypes**](docs/SparePartTypeApi.md#getspareparttypes) | **GET** /spare_part/types | Get a range of spare part types
*SparePartTypeApi* | [**GetSparePartTypesOptions**](docs/SparePartTypeApi.md#getspareparttypesoptions) | **GET** /spare_parts/{spare_part_id}/type-options | Get all possible types for the specified spare part
*SparePartTypeApi* | [**UpdateSparePartType**](docs/SparePartTypeApi.md#updatespareparttype) | **PATCH** /spare_part/types/{id} | Update a spare part type
*SpecificationApi* | [**DeleteSpecificationsOfAsset**](docs/SpecificationApi.md#deletespecificationsofasset) | **DELETE** /assets/{asset_id}/specifications | Delete specifications of an asset
*SpecificationApi* | [**GetSpecificationHistoryOfAsset**](docs/SpecificationApi.md#getspecificationhistoryofasset) | **GET** /assets/{asset_id}/specifications/{key}/history | Get the history of one specification attribute of an asset.
*SpecificationApi* | [**GetSpecificationHistoryOfBatch**](docs/SpecificationApi.md#getspecificationhistoryofbatch) | **GET** /batches/{batch_id}/specifications/{key}/history | Get the history of one specification attribute of a batch.
*SpecificationApi* | [**GetSpecificationHistoryOfInstrumentation**](docs/SpecificationApi.md#getspecificationhistoryofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/specifications/{key}/history | Get the history of one specification attribute of an instrumentation.
*SpecificationApi* | [**GetSpecificationHistoryOfRecipe**](docs/SpecificationApi.md#getspecificationhistoryofrecipe) | **GET** /recipes/{recipe_id}/specifications/{key}/history | Get the history of one specification attribute of an recipe.
*SpecificationApi* | [**GetSpecificationHistoryOfSystem**](docs/SpecificationApi.md#getspecificationhistoryofsystem) | **GET** /systems/{system_id}/specifications/{key}/history | Get the history of one specification attribute of a system.
*SpecificationApi* | [**GetSpecificationKeysOfAssets**](docs/SpecificationApi.md#getspecificationkeysofassets) | **GET** /asset/specification_keys | Get existing asset specification keys
*SpecificationApi* | [**GetSpecificationKeysOfInstrumentations**](docs/SpecificationApi.md#getspecificationkeysofinstrumentations) | **GET** /instrumentation/specification_keys | Get existing instrumentation specification keys
*SpecificationApi* | [**GetSpecificationKeysOfNodes**](docs/SpecificationApi.md#getspecificationkeysofnodes) | **GET** /node/specification_keys | Get existing asset specification keys
*SpecificationApi* | [**GetSpecificationsOfAPISubscription**](docs/SpecificationApi.md#getspecificationsofapisubscription) | **GET** /api_subscriptions/{id}/specifications | Get specifications of an api subscription
*SpecificationApi* | [**GetSpecificationsOfAsset**](docs/SpecificationApi.md#getspecificationsofasset) | **GET** /assets/{asset_id}/specifications | Get specifications of an asset
*SpecificationApi* | [**GetSpecificationsOfBatch**](docs/SpecificationApi.md#getspecificationsofbatch) | **GET** /batches/{batch_id}/specifications | Get specifications of a batch
*SpecificationApi* | [**GetSpecificationsOfEvent**](docs/SpecificationApi.md#getspecificationsofevent) | **GET** /events/{event_id}/specifications | Get specifications of an event
*SpecificationApi* | [**GetSpecificationsOfInstrumentation**](docs/SpecificationApi.md#getspecificationsofinstrumentation) | **GET** /instrumentations/{instrumentation_id}/specifications | Get specifications of an instrumentation
*SpecificationApi* | [**GetSpecificationsOfNode**](docs/SpecificationApi.md#getspecificationsofnode) | **GET** /nodes/{node_id}/specifications | Get specifications of a node
*SpecificationApi* | [**GetSpecificationsOfProduct**](docs/SpecificationApi.md#getspecificationsofproduct) | **GET** /products/{product_id}/specifications | Get specifications of a product
*SpecificationApi* | [**GetSpecificationsOfRecipe**](docs/SpecificationApi.md#getspecificationsofrecipe) | **GET** /recipes/{recipe_id}/specifications | Get specifications of an recipe
*SpecificationApi* | [**GetSpecificationsOfSubscription**](docs/SpecificationApi.md#getspecificationsofsubscription) | **GET** /subscriptions/{subscription_id}/specifications | Get specifications of a subscription
*SpecificationApi* | [**GetSpecificationsOfSystem**](docs/SpecificationApi.md#getspecificationsofsystem) | **GET** /systems/{system_id}/specifications | Get specifications of a system
*SpecificationApi* | [**GetSpecificationsOfUser**](docs/SpecificationApi.md#getspecificationsofuser) | **GET** /users/{user_id}/specifications | Get specifications of a user
*SpecificationApi* | [**RemoveSpecificationsFromAPISubscriptions**](docs/SpecificationApi.md#removespecificationsfromapisubscriptions) | **DELETE** /api_subscriptions/{id}/specifications | Delete specifications of an api subscription
*SpecificationApi* | [**RemoveSpecificationsFromBatch**](docs/SpecificationApi.md#removespecificationsfrombatch) | **DELETE** /batches/{batch_id}/specifications | Delete specifications of a batch
*SpecificationApi* | [**RemoveSpecificationsFromEvent**](docs/SpecificationApi.md#removespecificationsfromevent) | **DELETE** /events/{event_id}/specifications | Delete specifications of an event
*SpecificationApi* | [**RemoveSpecificationsFromInstrumentation**](docs/SpecificationApi.md#removespecificationsfrominstrumentation) | **DELETE** /instrumentations/{instrumentation_id}/specifications | Delete specifications of an instrumentation
*SpecificationApi* | [**RemoveSpecificationsFromNode**](docs/SpecificationApi.md#removespecificationsfromnode) | **DELETE** /nodes/{node_id}/specifications | Delete specifications of a node
*SpecificationApi* | [**RemoveSpecificationsFromProduct**](docs/SpecificationApi.md#removespecificationsfromproduct) | **DELETE** /products/{product_id}/specifications | Delete specifications of a product
*SpecificationApi* | [**RemoveSpecificationsFromRecipe**](docs/SpecificationApi.md#removespecificationsfromrecipe) | **DELETE** /recipes/{recipe_id}/specifications | Delete specifications of an recipe
*SpecificationApi* | [**RemoveSpecificationsFromSubscriptions**](docs/SpecificationApi.md#removespecificationsfromsubscriptions) | **DELETE** /subscriptions/{subscription_id}/specifications | Delete specifications of a subscription
*SpecificationApi* | [**RemoveSpecificationsFromSystem**](docs/SpecificationApi.md#removespecificationsfromsystem) | **DELETE** /systems/{system_id}/specifications | Delete specifications of a system
*SpecificationApi* | [**RemoveSpecificationsFromUsers**](docs/SpecificationApi.md#removespecificationsfromusers) | **DELETE** /users/{user_id}/specifications | Delete specifications of a user
*SpecificationApi* | [**RenameSpecificationsOfAPISubscriptions**](docs/SpecificationApi.md#renamespecificationsofapisubscriptions) | **PATCH** /api_subscriptions/{id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**RenameSpecificationsOfAsset**](docs/SpecificationApi.md#renamespecificationsofasset) | **PATCH** /assets/{asset_id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**RenameSpecificationsOfBatch**](docs/SpecificationApi.md#renamespecificationsofbatch) | **PATCH** /batches/{batch_id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**RenameSpecificationsOfEvent**](docs/SpecificationApi.md#renamespecificationsofevent) | **PATCH** /events/{event_id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**RenameSpecificationsOfInstrumentation**](docs/SpecificationApi.md#renamespecificationsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**RenameSpecificationsOfNode**](docs/SpecificationApi.md#renamespecificationsofnode) | **PATCH** /nodes/{node_id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**RenameSpecificationsOfProduct**](docs/SpecificationApi.md#renamespecificationsofproduct) | **PATCH** /products/{product_id}/specifications/rename | rename a key in the specification.
*SpecificationApi* | [**RenameSpecificationsOfRecipe**](docs/SpecificationApi.md#renamespecificationsofrecipe) | **PATCH** /recipes/{recipe_id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**RenameSpecificationsOfSubscriptions**](docs/SpecificationApi.md#renamespecificationsofsubscriptions) | **PATCH** /subscriptions/{subscription_id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**RenameSpecificationsOfSystem**](docs/SpecificationApi.md#renamespecificationsofsystem) | **PATCH** /systems/{system_id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**RenameSpecificationsOfUsers**](docs/SpecificationApi.md#renamespecificationsofusers) | **PATCH** /users/{user_id}/specifications/rename | Rename a specification key
*SpecificationApi* | [**UpdateSpecificationsOfAPISubscriptions**](docs/SpecificationApi.md#updatespecificationsofapisubscriptions) | **PATCH** /api_subscriptions/{id}/specifications | Update specifications of an api subscription
*SpecificationApi* | [**UpdateSpecificationsOfAsset**](docs/SpecificationApi.md#updatespecificationsofasset) | **PATCH** /assets/{asset_id}/specifications | Update specifications of an asset
*SpecificationApi* | [**UpdateSpecificationsOfBatch**](docs/SpecificationApi.md#updatespecificationsofbatch) | **PATCH** /batches/{batch_id}/specifications | Update specifications of a batch
*SpecificationApi* | [**UpdateSpecificationsOfEvent**](docs/SpecificationApi.md#updatespecificationsofevent) | **PATCH** /events/{event_id}/specifications | Update specifications of an event
*SpecificationApi* | [**UpdateSpecificationsOfInstrumentation**](docs/SpecificationApi.md#updatespecificationsofinstrumentation) | **PATCH** /instrumentations/{instrumentation_id}/specifications | Update specifications of an instrumentation
*SpecificationApi* | [**UpdateSpecificationsOfNode**](docs/SpecificationApi.md#updatespecificationsofnode) | **PATCH** /nodes/{node_id}/specifications | Update specifications of a node
*SpecificationApi* | [**UpdateSpecificationsOfProduct**](docs/SpecificationApi.md#updatespecificationsofproduct) | **PATCH** /products/{product_id}/specifications | Update specifications of a product
*SpecificationApi* | [**UpdateSpecificationsOfRecipe**](docs/SpecificationApi.md#updatespecificationsofrecipe) | **PATCH** /recipes/{recipe_id}/specifications | Update specifications of an recipe
*SpecificationApi* | [**UpdateSpecificationsOfSubscriptions**](docs/SpecificationApi.md#updatespecificationsofsubscriptions) | **PATCH** /subscriptions/{subscription_id}/specifications | Update specifications of a subscription
*SpecificationApi* | [**UpdateSpecificationsOfSystem**](docs/SpecificationApi.md#updatespecificationsofsystem) | **PATCH** /systems/{system_id}/specifications | Update specifications of a system
*SpecificationApi* | [**UpdateSpecificationsOfUsers**](docs/SpecificationApi.md#updatespecificationsofusers) | **PATCH** /users/{user_id}/specifications | Update specifications of a user
*SubscriptionApi* | [**AddAssetsToSubscription**](docs/SubscriptionApi.md#addassetstosubscription) | **POST** /subscriptions/{subscription_id}/assets | Add assets to a subscription
*SubscriptionApi* | [**AddSeatUsersToSubscription**](docs/SubscriptionApi.md#addseatuserstosubscription) | **POST** /subscriptions/{subscription_id}/seats | Add users (existing users) or emails (new users) to a seat in subscription
*SubscriptionApi* | [**AssignAssetSetToSubscription**](docs/SubscriptionApi.md#assignassetsettosubscription) | **POST** /subscriptions/{subscription_id}/asset_assignment | Assign assets to a subscription based on a filter
*SubscriptionApi* | [**CreateSubscription**](docs/SubscriptionApi.md#createsubscription) | **POST** /subscriptions | Create a new subscription
*SubscriptionApi* | [**DeleteSubscription**](docs/SubscriptionApi.md#deletesubscription) | **DELETE** /subscriptions/{id} | Delete a subscription
*SubscriptionApi* | [**DeleteSubscriptionSeat**](docs/SubscriptionApi.md#deletesubscriptionseat) | **DELETE** /subscription/seats/{id} | Delete a subscription seat
*SubscriptionApi* | [**GetAssetsOfSubscription**](docs/SubscriptionApi.md#getassetsofsubscription) | **GET** /subscriptions/{subscription_id}/assets | Get all assets of one subscription
*SubscriptionApi* | [**GetSeatUsersOfSubscription**](docs/SubscriptionApi.md#getseatusersofsubscription) | **GET** /subscriptions/{subscription_id}/seats | Get all users or invited emails having a seat in subscription
*SubscriptionApi* | [**GetSpecificationsOfSubscription**](docs/SubscriptionApi.md#getspecificationsofsubscription) | **GET** /subscriptions/{subscription_id}/specifications | Get specifications of a subscription
*SubscriptionApi* | [**GetSubscriptionById**](docs/SubscriptionApi.md#getsubscriptionbyid) | **GET** /subscriptions/{id} | Get a single subscription
*SubscriptionApi* | [**GetSubscriptionSeats**](docs/SubscriptionApi.md#getsubscriptionseats) | **GET** /subscription/seats | Get a range of subscription seats
*SubscriptionApi* | [**GetSubscriptions**](docs/SubscriptionApi.md#getsubscriptions) | **GET** /subscriptions | Get a range of subscriptions
*SubscriptionApi* | [**RemoveAssetsFromSubscription**](docs/SubscriptionApi.md#removeassetsfromsubscription) | **DELETE** /subscriptions/{subscription_id}/assets | Remove assets from a subscription
*SubscriptionApi* | [**RemoveSeatUsersFromSubscription**](docs/SubscriptionApi.md#removeseatusersfromsubscription) | **DELETE** /subscriptions/{subscription_id}/seats | Remove users (existing users) or emails (new users) from a seat in subscription
*SubscriptionApi* | [**RemoveSpecificationsFromSubscriptions**](docs/SubscriptionApi.md#removespecificationsfromsubscriptions) | **DELETE** /subscriptions/{subscription_id}/specifications | Delete specifications of a subscription
*SubscriptionApi* | [**RenameSpecificationsOfSubscriptions**](docs/SubscriptionApi.md#renamespecificationsofsubscriptions) | **PATCH** /subscriptions/{subscription_id}/specifications/rename | Rename a specification key
*SubscriptionApi* | [**ReplaceAssetsOfSubscription**](docs/SubscriptionApi.md#replaceassetsofsubscription) | **PATCH** /subscriptions/{subscription_id}/assets | Replace the assets of a subscription
*SubscriptionApi* | [**UnassignAssetSetToSubscription**](docs/SubscriptionApi.md#unassignassetsettosubscription) | **DELETE** /subscriptions/{subscription_id}/asset_assignment | Unassign assets to a subscription based on a filter
*SubscriptionApi* | [**UpdateSpecificationsOfSubscriptions**](docs/SubscriptionApi.md#updatespecificationsofsubscriptions) | **PATCH** /subscriptions/{subscription_id}/specifications | Update specifications of a subscription
*SubscriptionApi* | [**UpdateSubscription**](docs/SubscriptionApi.md#updatesubscription) | **PATCH** /subscriptions/{id} | Update a subscription
*SubscriptionApi* | [**UpdateSubscriptionSeat**](docs/SubscriptionApi.md#updatesubscriptionseat) | **PATCH** /subscription/seats/{id} | Update a subscription seat
*TenantApi* | [**AddTenantAdmins**](docs/TenantApi.md#addtenantadmins) | **POST** /tenants/{tenant_id}/admins | Add admins to a tenant
*TenantApi* | [**AddTenantUsers**](docs/TenantApi.md#addtenantusers) | **POST** /tenants/{tenant_id}/users | Add users to a tenant
*TenantApi* | [**CreateTenants**](docs/TenantApi.md#createtenants) | **POST** /tenants | Create a new tenant
*TenantApi* | [**DeleteTenant**](docs/TenantApi.md#deletetenant) | **DELETE** /tenants/{id} | Delete a tenant
*TenantApi* | [**GetAssetTenantOptions**](docs/TenantApi.md#getassettenantoptions) | **GET** /assets/{asset_id}/tenant-options | Get all possible tenants of the specified assets
*TenantApi* | [**GetTenantAdmins**](docs/TenantApi.md#gettenantadmins) | **GET** /tenants/{tenant_id}/admins | Get all admins of a tenant
*TenantApi* | [**GetTenantUsers**](docs/TenantApi.md#gettenantusers) | **GET** /tenants/{tenant_id}/users | Get all users of a tenant
*TenantApi* | [**GetTenants**](docs/TenantApi.md#gettenants) | **GET** /tenants | Get a range of tenants
*TenantApi* | [**GetTenantsById**](docs/TenantApi.md#gettenantsbyid) | **GET** /tenants/{id} | Get a single tenant
*TenantApi* | [**RemoveTenantAdmins**](docs/TenantApi.md#removetenantadmins) | **DELETE** /tenants/{tenant_id}/admins | Remove admins from a tenant
*TenantApi* | [**RemoveTenantUsers**](docs/TenantApi.md#removetenantusers) | **DELETE** /tenants/{tenant_id}/users | Remove users from a tenant
*TenantApi* | [**ReplaceTenantAdmins**](docs/TenantApi.md#replacetenantadmins) | **PATCH** /tenants/{tenant_id}/admins | Replace the admins of a tenant
*TenantApi* | [**ReplaceTenantUsers**](docs/TenantApi.md#replacetenantusers) | **PATCH** /tenants/{tenant_id}/users | Replace the users of a tenant
*TenantApi* | [**UpdateTenant**](docs/TenantApi.md#updatetenant) | **PATCH** /tenants/{id} | Update a tenant
*ThresholdApi* | [**CreateInstrumentationThreshold**](docs/ThresholdApi.md#createinstrumentationthreshold) | **POST** /instrumentations/{instrumentation_id}/thresholds | Create an instrumentation threshold
*ThresholdApi* | [**CreateRecipeThreshold**](docs/ThresholdApi.md#createrecipethreshold) | **POST** /recipes/{recipe_id}/thresholds | Create an recipe threshold
*ThresholdApi* | [**CreateSystemThreshold**](docs/ThresholdApi.md#createsystemthreshold) | **POST** /systems/{system_id}/thresholds | Create an system threshold
*ThresholdApi* | [**DeleteInstrumentationThreshold**](docs/ThresholdApi.md#deleteinstrumentationthreshold) | **DELETE** /instrumentations/{instrumentation_id}/thresholds/{id} | Delete an instrumentation threshold.
*ThresholdApi* | [**DeleteRecipeThreshold**](docs/ThresholdApi.md#deleterecipethreshold) | **DELETE** /recipes/{recipe_id}/thresholds/{id} | Delete an recipe threshold.
*ThresholdApi* | [**DeleteSystemThreshold**](docs/ThresholdApi.md#deletesystemthreshold) | **DELETE** /systems/{system_id}/thresholds/{id} | Delete an system threshold.
*ThresholdApi* | [**GetInstrumentationThreshold**](docs/ThresholdApi.md#getinstrumentationthreshold) | **GET** /instrumentations/{instrumentation_id}/thresholds/{id} | Get an instrumentation threshold
*ThresholdApi* | [**GetInstrumentationThresholds**](docs/ThresholdApi.md#getinstrumentationthresholds) | **GET** /instrumentations/{instrumentation_id}/thresholds | Get instrumentation thresholds
*ThresholdApi* | [**GetRecipeThreshold**](docs/ThresholdApi.md#getrecipethreshold) | **GET** /recipes/{recipe_id}/thresholds/{id} | Get an recipe threshold
*ThresholdApi* | [**GetRecipeThresholds**](docs/ThresholdApi.md#getrecipethresholds) | **GET** /recipes/{recipe_id}/thresholds | Get recipe thresholds
*ThresholdApi* | [**GetSystemThreshold**](docs/ThresholdApi.md#getsystemthreshold) | **GET** /systems/{system_id}/thresholds/{id} | Get an system threshold
*ThresholdApi* | [**GetSystemThresholds**](docs/ThresholdApi.md#getsystemthresholds) | **GET** /systems/{system_id}/thresholds | Get system thresholds
*ThresholdApi* | [**UpdateInstrumentationThreshold**](docs/ThresholdApi.md#updateinstrumentationthreshold) | **PATCH** /instrumentations/{instrumentation_id}/thresholds/{id} | Update an instrumentation threshold
*ThresholdApi* | [**UpdateRecipeThreshold**](docs/ThresholdApi.md#updaterecipethreshold) | **PATCH** /recipes/{recipe_id}/thresholds/{id} | Update an recipe threshold
*ThresholdApi* | [**UpdateSystemThreshold**](docs/ThresholdApi.md#updatesystemthreshold) | **PATCH** /systems/{system_id}/thresholds/{id} | Update an system threshold
*UnitApi* | [**GetUnitById**](docs/UnitApi.md#getunitbyid) | **GET** /units/{id} | Get a single Unit
*UnitApi* | [**GetUnits**](docs/UnitApi.md#getunits) | **GET** /units | Get a range of units.
*UserApi* | [**AddUserGroupsToUser**](docs/UserApi.md#addusergroupstouser) | **POST** /users/{user_id}/usergroups | Add user groups to a user
*UserApi* | [**AddUserRolesToUser**](docs/UserApi.md#adduserrolestouser) | **POST** /users/{user_id}/userroles | Add user roles to a user
*UserApi* | [**CreateCurrentUserDataExport**](docs/UserApi.md#createcurrentuserdataexport) | **POST** /users/current/data_exports | create users data export for current user
*UserApi* | [**CreateTechnicalUser**](docs/UserApi.md#createtechnicaluser) | **POST** /technical_users | Create a new technical user
*UserApi* | [**DeleteCurrentUserDatasExport**](docs/UserApi.md#deletecurrentuserdatasexport) | **DELETE** /users/current/data_exports/{id} | delete users data export for current user
*UserApi* | [**DeleteCurrentUserDemoData**](docs/UserApi.md#deletecurrentuserdemodata) | **DELETE** /users/current/demo_data | Deactivate demo data for user
*UserApi* | [**DeleteCurrentUserNotifications**](docs/UserApi.md#deletecurrentusernotifications) | **DELETE** /users/current/notifications/{id} | Delete the given notification for the current user
*UserApi* | [**DeleteTechnicalUser**](docs/UserApi.md#deletetechnicaluser) | **DELETE** /technical_users/{id} | Delete a technical user
*UserApi* | [**DeleteUser**](docs/UserApi.md#deleteuser) | **DELETE** /users/{id} | Delete a user
*UserApi* | [**GetCurrentUser**](docs/UserApi.md#getcurrentuser) | **GET** /users/current | Get current user
*UserApi* | [**GetCurrentUserAccessRights**](docs/UserApi.md#getcurrentuseraccessrights) | **GET** /users/current/access_rights | Get current users access rights for a permitable
*UserApi* | [**GetCurrentUserDataExportbyId**](docs/UserApi.md#getcurrentuserdataexportbyid) | **GET** /users/current/data_exports/{id} | Get a single user data export
*UserApi* | [**GetCurrentUserDataExports**](docs/UserApi.md#getcurrentuserdataexports) | **GET** /users/current/data_exports | Get current users data exports
*UserApi* | [**GetCurrentUserDataExportsFile**](docs/UserApi.md#getcurrentuserdataexportsfile) | **GET** /users/current/data_exports/{id}/download | Get current users data export zip file
*UserApi* | [**GetCurrentUserDemoData**](docs/UserApi.md#getcurrentuserdemodata) | **GET** /users/current/demo_data | Get information if demo data is available for user
*UserApi* | [**GetCurrentUserNotifications**](docs/UserApi.md#getcurrentusernotifications) | **GET** /users/current/notifications | Get relevant notifications for the current authenticated user
*UserApi* | [**GetSignInsOfAllUser**](docs/UserApi.md#getsigninsofalluser) | **GET** /sign_ins | Get sign_ins of all users
*UserApi* | [**GetSignInsOfUser**](docs/UserApi.md#getsigninsofuser) | **GET** /users/{user_id}/sign_ins | Get sign_ins of a user
*UserApi* | [**GetSpecificationsOfUser**](docs/UserApi.md#getspecificationsofuser) | **GET** /users/{user_id}/specifications | Get specifications of a user
*UserApi* | [**GetTechnicalUsers**](docs/UserApi.md#gettechnicalusers) | **GET** /technical_users | Get a range of technical users
*UserApi* | [**GetUsageOfUser**](docs/UserApi.md#getusageofuser) | **GET** /users/{user_id}/usage | Get the use of storage and the number of assets registred of a user
*UserApi* | [**GetUserById**](docs/UserApi.md#getuserbyid) | **GET** /users/{id} | Get a single user
*UserApi* | [**GetUserGroupsOfUser**](docs/UserApi.md#getusergroupsofuser) | **GET** /users/{user_id}/usergroups | Get the user groups of one user
*UserApi* | [**GetUserRolesOfUser**](docs/UserApi.md#getuserrolesofuser) | **GET** /users/{user_id}/userroles | Get all user roles of one user
*UserApi* | [**GetUsers**](docs/UserApi.md#getusers) | **GET** /users | Get a range of users
*UserApi* | [**LookupUser**](docs/UserApi.md#lookupuser) | **GET** /users/lookup | Lookup user by email
*UserApi* | [**RemoveSpecificationsFromUsers**](docs/UserApi.md#removespecificationsfromusers) | **DELETE** /users/{user_id}/specifications | Delete specifications of a user
*UserApi* | [**RemoveUserGroupFromUser**](docs/UserApi.md#removeusergroupfromuser) | **DELETE** /users/{user_id}/usergroups | Remove user groups from a user
*UserApi* | [**RemoveUserRolesFromUser**](docs/UserApi.md#removeuserrolesfromuser) | **DELETE** /users/{user_id}/userroles | Remove user roles from a user
*UserApi* | [**RenameSpecificationsOfUsers**](docs/UserApi.md#renamespecificationsofusers) | **PATCH** /users/{user_id}/specifications/rename | Rename a specification key
*UserApi* | [**ReplaceUserGroupsOfUser**](docs/UserApi.md#replaceusergroupsofuser) | **PATCH** /users/{user_id}/usergroups | Replace the user groups of a user
*UserApi* | [**ReplaceUserRolesOfUser**](docs/UserApi.md#replaceuserrolesofuser) | **PATCH** /users/{user_id}/userroles | Replace the user roles of a user
*UserApi* | [**ResetPasswordTechnicalUser**](docs/UserApi.md#resetpasswordtechnicaluser) | **POST** /technical_users/{id}/password_reset | create a new password for a technical user
*UserApi* | [**SetCurrentUserDemoData**](docs/UserApi.md#setcurrentuserdemodata) | **POST** /users/current/demo_data | Activate demo data for user
*UserApi* | [**UpdateSpecificationsOfUsers**](docs/UserApi.md#updatespecificationsofusers) | **PATCH** /users/{user_id}/specifications | Update specifications of a user
*UserApi* | [**UpdateUser**](docs/UserApi.md#updateuser) | **PATCH** /users/{id} | Update a user
*UserGroupApi* | [**AddUsersToUserGroup**](docs/UserGroupApi.md#adduserstousergroup) | **POST** /usergroups/{usergroup_id}/users | Add users to a user group
*UserGroupApi* | [**CreateUserGroup**](docs/UserGroupApi.md#createusergroup) | **POST** /usergroups | Create a new user group
*UserGroupApi* | [**DeleteUserGroup**](docs/UserGroupApi.md#deleteusergroup) | **DELETE** /usergroups/{id} | Delete a user group
*UserGroupApi* | [**GetUserGroupById**](docs/UserGroupApi.md#getusergroupbyid) | **GET** /usergroups/{id} | Get a single user group
*UserGroupApi* | [**GetUserGroups**](docs/UserGroupApi.md#getusergroups) | **GET** /usergroups | Get a range of user groups
*UserGroupApi* | [**GetUsersOfUserGroup**](docs/UserGroupApi.md#getusersofusergroup) | **GET** /usergroups/{usergroup_id}/users | Get the users of a user group
*UserGroupApi* | [**RemoveUsersFromUserGroup**](docs/UserGroupApi.md#removeusersfromusergroup) | **DELETE** /usergroups/{usergroup_id}/users | Remove users from a user group
*UserGroupApi* | [**ReplaceUsersOfUserGroup**](docs/UserGroupApi.md#replaceusersofusergroup) | **PATCH** /usergroups/{usergroup_id}/users | Replace the users of a user group
*UserGroupApi* | [**UpdateUserGroup**](docs/UserGroupApi.md#updateusergroup) | **PATCH** /usergroups/{id} | Update a user group
*UserRoleApi* | [**AddUsersToUserRole**](docs/UserRoleApi.md#adduserstouserrole) | **POST** /userroles/{userrole_id}/users | Add users to a user role
*UserRoleApi* | [**CreateUserRole**](docs/UserRoleApi.md#createuserrole) | **POST** /userroles | Create a new user role
*UserRoleApi* | [**DeleteUserRole**](docs/UserRoleApi.md#deleteuserrole) | **DELETE** /userroles/{id} | Delete a user role
*UserRoleApi* | [**DeleteUsersFromUserRole**](docs/UserRoleApi.md#deleteusersfromuserrole) | **DELETE** /userroles/{userrole_id}/users | Remove users from a user role
*UserRoleApi* | [**GetUserRoleById**](docs/UserRoleApi.md#getuserrolebyid) | **GET** /userroles/{id} | Get a single user role
*UserRoleApi* | [**GetUserRoles**](docs/UserRoleApi.md#getuserroles) | **GET** /userroles | Get a range of user roles
*UserRoleApi* | [**GetUsersOfUserRole**](docs/UserRoleApi.md#getusersofuserrole) | **GET** /userroles/{userrole_id}/users | Get all users of one user role. To work with roles, admin role is required.
*UserRoleApi* | [**ReplaceUsersOfUserRole**](docs/UserRoleApi.md#replaceusersofuserrole) | **PATCH** /userroles/{userrole_id}/users | Replace the users of a user role
*UserRoleApi* | [**UpdateUserRole**](docs/UserRoleApi.md#updateuserrole) | **PATCH** /userroles/{id} | Update a user role
*ValuesApi* | [**CreateAssetValues**](docs/ValuesApi.md#createassetvalues) | **POST** /assets/{asset_id}/values | Create asset values
*ValuesApi* | [**GetAssetValues**](docs/ValuesApi.md#getassetvalues) | **GET** /assets/{asset_id}/values | Get latest values for the asset.
*ValuesApi* | [**GetAssetValuesForKey**](docs/ValuesApi.md#getassetvaluesforkey) | **GET** /assets/{asset_id}/values/{key} | Get asset values for a specific key.
*ValuesApi* | [**GetBatchValues**](docs/ValuesApi.md#getbatchvalues) | **GET** /batches/{batch_id}/values | Get latest values for the batch.
*ValuesApi* | [**GetBatchValuesForKey**](docs/ValuesApi.md#getbatchvaluesforkey) | **GET** /batches/{batch_id}/values/{key} | Get batch values for a specific key.
*ValuesApi* | [**GetInstrumentationValues**](docs/ValuesApi.md#getinstrumentationvalues) | **GET** /instrumentations/{instrumentation_id}/values | Get latest values for the instrumentation.
*ValuesApi* | [**GetInstrumentationValuesForKey**](docs/ValuesApi.md#getinstrumentationvaluesforkey) | **GET** /instrumentations/{instrumentation_id}/values/{key} | Get instrumentation values for a specific key.
*ValuesApi* | [**GetSystemValues**](docs/ValuesApi.md#getsystemvalues) | **GET** /systems/{system_id}/values | Get latest values for the system.
*ValuesApi* | [**GetSystemValuesForKey**](docs/ValuesApi.md#getsystemvaluesforkey) | **GET** /systems/{system_id}/values/{key} | Get system values for a specific key.

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.APIKeyBase](docs/APIKeyBase.md)
 - [Model.APIKeyRequest](docs/APIKeyRequest.md)
 - [Model.APIKeyResponse](docs/APIKeyResponse.md)
 - [Model.APIKeysResponse](docs/APIKeysResponse.md)
 - [Model.APISubscriptionBase](docs/APISubscriptionBase.md)
 - [Model.APISubscriptionRequest](docs/APISubscriptionRequest.md)
 - [Model.APISubscriptionResponse](docs/APISubscriptionResponse.md)
 - [Model.APISubscriptionsResponse](docs/APISubscriptionsResponse.md)
 - [Model.AccessRightsResponse](docs/AccessRightsResponse.md)
 - [Model.AddOnBase](docs/AddOnBase.md)
 - [Model.AddOnIDs](docs/AddOnIDs.md)
 - [Model.AddOnResponse](docs/AddOnResponse.md)
 - [Model.AddOnsResponse](docs/AddOnsResponse.md)
 - [Model.AddressBase](docs/AddressBase.md)
 - [Model.AdminIDs](docs/AdminIDs.md)
 - [Model.AssetBase](docs/AssetBase.md)
 - [Model.AssetHealthConditionNested](docs/AssetHealthConditionNested.md)
 - [Model.AssetHealthConditionResponse](docs/AssetHealthConditionResponse.md)
 - [Model.AssetHealthConditionTimemachine](docs/AssetHealthConditionTimemachine.md)
 - [Model.AssetHealthConditionsCalculateRequest](docs/AssetHealthConditionsCalculateRequest.md)
 - [Model.AssetHealthConditionsRequest](docs/AssetHealthConditionsRequest.md)
 - [Model.AssetHealthConditionsRequestHealthConditions](docs/AssetHealthConditionsRequestHealthConditions.md)
 - [Model.AssetHealthConditionsResponse](docs/AssetHealthConditionsResponse.md)
 - [Model.AssetHealthConditionsTimemachineResponse](docs/AssetHealthConditionsTimemachineResponse.md)
 - [Model.AssetHistory](docs/AssetHistory.md)
 - [Model.AssetHistoryBase](docs/AssetHistoryBase.md)
 - [Model.AssetHistoryResponse](docs/AssetHistoryResponse.md)
 - [Model.AssetIDs](docs/AssetIDs.md)
 - [Model.AssetInstrumentationHistory](docs/AssetInstrumentationHistory.md)
 - [Model.AssetInstrumentationsHistoryResponse](docs/AssetInstrumentationsHistoryResponse.md)
 - [Model.AssetKeyValueObjectsData](docs/AssetKeyValueObjectsData.md)
 - [Model.AssetKeyValueObjectsResponse](docs/AssetKeyValueObjectsResponse.md)
 - [Model.AssetKeyValuesData](docs/AssetKeyValuesData.md)
 - [Model.AssetKeyValuesResponse](docs/AssetKeyValuesResponse.md)
 - [Model.AssetRequest](docs/AssetRequest.md)
 - [Model.AssetResponse](docs/AssetResponse.md)
 - [Model.AssetStatusBase](docs/AssetStatusBase.md)
 - [Model.AssetStatusRequest](docs/AssetStatusRequest.md)
 - [Model.AssetStatusResponse](docs/AssetStatusResponse.md)
 - [Model.AssetStatuses](docs/AssetStatuses.md)
 - [Model.AssetValue](docs/AssetValue.md)
 - [Model.AssetValueObjectRequest](docs/AssetValueObjectRequest.md)
 - [Model.AssetValueObjectRequestData](docs/AssetValueObjectRequestData.md)
 - [Model.AssetValueObjectsPagination](docs/AssetValueObjectsPagination.md)
 - [Model.AssetValueObjectsRequest](docs/AssetValueObjectsRequest.md)
 - [Model.AssetValueRequest](docs/AssetValueRequest.md)
 - [Model.AssetValueRequestData](docs/AssetValueRequestData.md)
 - [Model.AssetValuesPagination](docs/AssetValuesPagination.md)
 - [Model.AssetValuesRequest](docs/AssetValuesRequest.md)
 - [Model.AssetValuesResponse](docs/AssetValuesResponse.md)
 - [Model.AssetsResponse](docs/AssetsResponse.md)
 - [Model.Assignable](docs/Assignable.md)
 - [Model.AttachmentLinkRequest](docs/AttachmentLinkRequest.md)
 - [Model.AttachmentResponse](docs/AttachmentResponse.md)
 - [Model.AttachmentsBody](docs/AttachmentsBody.md)
 - [Model.AttachmentsIdBody](docs/AttachmentsIdBody.md)
 - [Model.AttachmentsIdBody1](docs/AttachmentsIdBody1.md)
 - [Model.AttachmentsResponse](docs/AttachmentsResponse.md)
 - [Model.BillOfMaterialBase](docs/BillOfMaterialBase.md)
 - [Model.BillOfMaterialIDs](docs/BillOfMaterialIDs.md)
 - [Model.BillOfMaterialRequest](docs/BillOfMaterialRequest.md)
 - [Model.BillOfMaterialResponse](docs/BillOfMaterialResponse.md)
 - [Model.BillOfMaterialsResponse](docs/BillOfMaterialsResponse.md)
 - [Model.BillingAddressRequest](docs/BillingAddressRequest.md)
 - [Model.BillingAddressResponse](docs/BillingAddressResponse.md)
 - [Model.BillingContactRequest](docs/BillingContactRequest.md)
 - [Model.BillingContactResponse](docs/BillingContactResponse.md)
 - [Model.CategoryIDs](docs/CategoryIDs.md)
 - [Model.Causes](docs/Causes.md)
 - [Model.ClientApplicationBase](docs/ClientApplicationBase.md)
 - [Model.ClientApplicationIDs](docs/ClientApplicationIDs.md)
 - [Model.ClientApplicationPublicResponse](docs/ClientApplicationPublicResponse.md)
 - [Model.ClientApplicationRequest](docs/ClientApplicationRequest.md)
 - [Model.ClientApplicationResponse](docs/ClientApplicationResponse.md)
 - [Model.ClientApplicationsResponse](docs/ClientApplicationsResponse.md)
 - [Model.Companies](docs/Companies.md)
 - [Model.Companies1](docs/Companies1.md)
 - [Model.CompanyAddressRequest](docs/CompanyAddressRequest.md)
 - [Model.CompanyAddressResponse](docs/CompanyAddressResponse.md)
 - [Model.CompanyBase](docs/CompanyBase.md)
 - [Model.CompanyNested](docs/CompanyNested.md)
 - [Model.CompanyRequest](docs/CompanyRequest.md)
 - [Model.CompanyResponse](docs/CompanyResponse.md)
 - [Model.ContainerExportRequest](docs/ContainerExportRequest.md)
 - [Model.CurrentUserDemoDataResponse](docs/CurrentUserDemoDataResponse.md)
 - [Model.CurrentUserResponse](docs/CurrentUserResponse.md)
 - [Model.CurrentUserResponseLinks](docs/CurrentUserResponseLinks.md)
 - [Model.CustomerBase](docs/CustomerBase.md)
 - [Model.CustomerRequest](docs/CustomerRequest.md)
 - [Model.CustomerResponse](docs/CustomerResponse.md)
 - [Model.CustomersResponse](docs/CustomersResponse.md)
 - [Model.DataExportRequest](docs/DataExportRequest.md)
 - [Model.DataExportResponse](docs/DataExportResponse.md)
 - [Model.DataExportsResponse](docs/DataExportsResponse.md)
 - [Model.DeliveriesResponse](docs/DeliveriesResponse.md)
 - [Model.DeliveryBase](docs/DeliveryBase.md)
 - [Model.DeliveryIDs](docs/DeliveryIDs.md)
 - [Model.DeliveryProducts](docs/DeliveryProducts.md)
 - [Model.DeliveryProductsAssets](docs/DeliveryProductsAssets.md)
 - [Model.DeliveryRequest](docs/DeliveryRequest.md)
 - [Model.DeliveryResponse](docs/DeliveryResponse.md)
 - [Model.DeliveryStatusBase](docs/DeliveryStatusBase.md)
 - [Model.DeliveryStatusRequest](docs/DeliveryStatusRequest.md)
 - [Model.DeliveryStatusResponse](docs/DeliveryStatusResponse.md)
 - [Model.DeliveryStatuses](docs/DeliveryStatuses.md)
 - [Model.DocumentBase](docs/DocumentBase.md)
 - [Model.DocumentCategoriesResponse](docs/DocumentCategoriesResponse.md)
 - [Model.DocumentCategoryBase](docs/DocumentCategoryBase.md)
 - [Model.DocumentCategoryRequest](docs/DocumentCategoryRequest.md)
 - [Model.DocumentCategoryResponse](docs/DocumentCategoryResponse.md)
 - [Model.DocumentCategoryResponseLinks](docs/DocumentCategoryResponseLinks.md)
 - [Model.DocumentClassificationBase](docs/DocumentClassificationBase.md)
 - [Model.DocumentClassificationRequest](docs/DocumentClassificationRequest.md)
 - [Model.DocumentClassificationResponse](docs/DocumentClassificationResponse.md)
 - [Model.DocumentClassifications](docs/DocumentClassifications.md)
 - [Model.DocumentIDs](docs/DocumentIDs.md)
 - [Model.DocumentRequest](docs/DocumentRequest.md)
 - [Model.DocumentResponse](docs/DocumentResponse.md)
 - [Model.DocumentStatusBase](docs/DocumentStatusBase.md)
 - [Model.DocumentStatusRequest](docs/DocumentStatusRequest.md)
 - [Model.DocumentStatusResponse](docs/DocumentStatusResponse.md)
 - [Model.DocumentStatuses](docs/DocumentStatuses.md)
 - [Model.DocumentsResponse](docs/DocumentsResponse.md)
 - [Model.EdgeDeviceApplicationBase](docs/EdgeDeviceApplicationBase.md)
 - [Model.EdgeDeviceApplicationResponse](docs/EdgeDeviceApplicationResponse.md)
 - [Model.EdgeDeviceApplicationsResponse](docs/EdgeDeviceApplicationsResponse.md)
 - [Model.EdgeDeviceBase](docs/EdgeDeviceBase.md)
 - [Model.EdgeDeviceFeatureBase](docs/EdgeDeviceFeatureBase.md)
 - [Model.EdgeDeviceFeatureIDs](docs/EdgeDeviceFeatureIDs.md)
 - [Model.EdgeDeviceFeatureResponse](docs/EdgeDeviceFeatureResponse.md)
 - [Model.EdgeDeviceFeaturesResponse](docs/EdgeDeviceFeaturesResponse.md)
 - [Model.EdgeDeviceResponse](docs/EdgeDeviceResponse.md)
 - [Model.EdgeDeviceResponseApiSubscription](docs/EdgeDeviceResponseApiSubscription.md)
 - [Model.EdgeDevicesIds](docs/EdgeDevicesIds.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.EventBase](docs/EventBase.md)
 - [Model.EventRequest](docs/EventRequest.md)
 - [Model.EventRequestNoAssets](docs/EventRequestNoAssets.md)
 - [Model.EventRequestNoInstrumentations](docs/EventRequestNoInstrumentations.md)
 - [Model.EventResponse](docs/EventResponse.md)
 - [Model.EventStatusBase](docs/EventStatusBase.md)
 - [Model.EventStatusRequest](docs/EventStatusRequest.md)
 - [Model.EventStatusResponse](docs/EventStatusResponse.md)
 - [Model.EventStatuses](docs/EventStatuses.md)
 - [Model.EventTypeBase](docs/EventTypeBase.md)
 - [Model.EventTypeRequest](docs/EventTypeRequest.md)
 - [Model.EventTypeResponse](docs/EventTypeResponse.md)
 - [Model.EventTypes](docs/EventTypes.md)
 - [Model.Events](docs/Events.md)
 - [Model.Events1](docs/Events1.md)
 - [Model.EventsResponse](docs/EventsResponse.md)
 - [Model.ExtendedOrderCode](docs/ExtendedOrderCode.md)
 - [Model.Features](docs/Features.md)
 - [Model.Features1](docs/Features1.md)
 - [Model.HealthConditionBase](docs/HealthConditionBase.md)
 - [Model.HealthConditionCauseBase](docs/HealthConditionCauseBase.md)
 - [Model.HealthConditionCauseIDs](docs/HealthConditionCauseIDs.md)
 - [Model.HealthConditionCauseRequest](docs/HealthConditionCauseRequest.md)
 - [Model.HealthConditionCauseResponse](docs/HealthConditionCauseResponse.md)
 - [Model.HealthConditionExtended](docs/HealthConditionExtended.md)
 - [Model.HealthConditionExtendedRules](docs/HealthConditionExtendedRules.md)
 - [Model.HealthConditionRemedyBase](docs/HealthConditionRemedyBase.md)
 - [Model.HealthConditionRemedyRequest](docs/HealthConditionRemedyRequest.md)
 - [Model.HealthConditionRemedyResponse](docs/HealthConditionRemedyResponse.md)
 - [Model.HealthConditionRequest](docs/HealthConditionRequest.md)
 - [Model.HealthConditionResponse](docs/HealthConditionResponse.md)
 - [Model.HealthConditionsRequest](docs/HealthConditionsRequest.md)
 - [Model.HealthConditionsRequestHealthConditions](docs/HealthConditionsRequestHealthConditions.md)
 - [Model.HealthConditionsResponse](docs/HealthConditionsResponse.md)
 - [Model.IdPicturesBody](docs/IdPicturesBody.md)
 - [Model.IdPicturesBody1](docs/IdPicturesBody1.md)
 - [Model.IdPicturesBody2](docs/IdPicturesBody2.md)
 - [Model.IdPicturesBody3](docs/IdPicturesBody3.md)
 - [Model.InstrumentationAssetHistory](docs/InstrumentationAssetHistory.md)
 - [Model.InstrumentationAssetsHistoryResponse](docs/InstrumentationAssetsHistoryResponse.md)
 - [Model.InstrumentationBase](docs/InstrumentationBase.md)
 - [Model.InstrumentationIDs](docs/InstrumentationIDs.md)
 - [Model.InstrumentationRequest](docs/InstrumentationRequest.md)
 - [Model.InstrumentationResponse](docs/InstrumentationResponse.md)
 - [Model.InstrumentationStatusBase](docs/InstrumentationStatusBase.md)
 - [Model.InstrumentationStatusRequest](docs/InstrumentationStatusRequest.md)
 - [Model.InstrumentationStatusResponse](docs/InstrumentationStatusResponse.md)
 - [Model.InstrumentationStatuses](docs/InstrumentationStatuses.md)
 - [Model.InstrumentationStatuses1](docs/InstrumentationStatuses1.md)
 - [Model.InstrumentationTypeBase](docs/InstrumentationTypeBase.md)
 - [Model.InstrumentationTypeRequest](docs/InstrumentationTypeRequest.md)
 - [Model.InstrumentationTypeResponse](docs/InstrumentationTypeResponse.md)
 - [Model.InstrumentationTypes](docs/InstrumentationTypes.md)
 - [Model.InstrumentationsResponse](docs/InstrumentationsResponse.md)
 - [Model.Link](docs/Link.md)
 - [Model.Links](docs/Links.md)
 - [Model.Links1](docs/Links1.md)
 - [Model.Links10](docs/Links10.md)
 - [Model.Links11](docs/Links11.md)
 - [Model.Links12](docs/Links12.md)
 - [Model.Links13](docs/Links13.md)
 - [Model.Links14](docs/Links14.md)
 - [Model.Links15](docs/Links15.md)
 - [Model.Links16](docs/Links16.md)
 - [Model.Links17](docs/Links17.md)
 - [Model.Links18](docs/Links18.md)
 - [Model.Links19](docs/Links19.md)
 - [Model.Links2](docs/Links2.md)
 - [Model.Links20](docs/Links20.md)
 - [Model.Links21](docs/Links21.md)
 - [Model.Links3](docs/Links3.md)
 - [Model.Links4](docs/Links4.md)
 - [Model.Links5](docs/Links5.md)
 - [Model.Links6](docs/Links6.md)
 - [Model.Links7](docs/Links7.md)
 - [Model.Links8](docs/Links8.md)
 - [Model.Links9](docs/Links9.md)
 - [Model.NestedID](docs/NestedID.md)
 - [Model.NestedIDCode](docs/NestedIDCode.md)
 - [Model.NestedIDEmail](docs/NestedIDEmail.md)
 - [Model.NestedIDHref](docs/NestedIDHref.md)
 - [Model.NestedIDHrefName](docs/NestedIDHrefName.md)
 - [Model.NestedIDHrefSerialnumber](docs/NestedIDHrefSerialnumber.md)
 - [Model.NestedIDHrefTag](docs/NestedIDHrefTag.md)
 - [Model.NestedIDUserNameHref](docs/NestedIDUserNameHref.md)
 - [Model.NodeBase](docs/NodeBase.md)
 - [Model.NodeIDs](docs/NodeIDs.md)
 - [Model.NodeRequest](docs/NodeRequest.md)
 - [Model.NodeResponse](docs/NodeResponse.md)
 - [Model.NodeTypeBase](docs/NodeTypeBase.md)
 - [Model.NodeTypeRequest](docs/NodeTypeRequest.md)
 - [Model.NodeTypeResponse](docs/NodeTypeResponse.md)
 - [Model.NodeTypes](docs/NodeTypes.md)
 - [Model.NodesResponse](docs/NodesResponse.md)
 - [Model.NotificationBase](docs/NotificationBase.md)
 - [Model.NotificationRequest](docs/NotificationRequest.md)
 - [Model.NotificationResponse](docs/NotificationResponse.md)
 - [Model.Notifications](docs/Notifications.md)
 - [Model.Ooptions](docs/Ooptions.md)
 - [Model.Options](docs/Options.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.PermissionBase](docs/PermissionBase.md)
 - [Model.PermissionInheritable](docs/PermissionInheritable.md)
 - [Model.PermissionInheritanceBase](docs/PermissionInheritanceBase.md)
 - [Model.PermissionInheritanceRequest](docs/PermissionInheritanceRequest.md)
 - [Model.PermissionInheritanceResponse](docs/PermissionInheritanceResponse.md)
 - [Model.PermissionInheritances](docs/PermissionInheritances.md)
 - [Model.PermissionRequest](docs/PermissionRequest.md)
 - [Model.PermissionRequestCreateRequest](docs/PermissionRequestCreateRequest.md)
 - [Model.PermissionRequestCreateRequestAsset](docs/PermissionRequestCreateRequestAsset.md)
 - [Model.PermissionRequestCreateRequestAssetManufacturer](docs/PermissionRequestCreateRequestAssetManufacturer.md)
 - [Model.PermissionRequestResponse](docs/PermissionRequestResponse.md)
 - [Model.PermissionRequestUpdateRequest](docs/PermissionRequestUpdateRequest.md)
 - [Model.PermissionResponse](docs/PermissionResponse.md)
 - [Model.Permissions](docs/Permissions.md)
 - [Model.Permitable](docs/Permitable.md)
 - [Model.Permitable1](docs/Permitable1.md)
 - [Model.PictureLinkRequest](docs/PictureLinkRequest.md)
 - [Model.PictureResponse](docs/PictureResponse.md)
 - [Model.PicturesIdBody](docs/PicturesIdBody.md)
 - [Model.PicturesIdBody1](docs/PicturesIdBody1.md)
 - [Model.PicturesIdBody2](docs/PicturesIdBody2.md)
 - [Model.PicturesIdBody3](docs/PicturesIdBody3.md)
 - [Model.PicturesResponse](docs/PicturesResponse.md)
 - [Model.ProductBase](docs/ProductBase.md)
 - [Model.ProductCategoriesResponse](docs/ProductCategoriesResponse.md)
 - [Model.ProductCategoryBase](docs/ProductCategoryBase.md)
 - [Model.ProductCategoryRequest](docs/ProductCategoryRequest.md)
 - [Model.ProductCategoryResponse](docs/ProductCategoryResponse.md)
 - [Model.ProductCategoryResponseLinks](docs/ProductCategoryResponseLinks.md)
 - [Model.ProductFeatureBase](docs/ProductFeatureBase.md)
 - [Model.ProductFeatureRequest](docs/ProductFeatureRequest.md)
 - [Model.ProductFeatureResponse](docs/ProductFeatureResponse.md)
 - [Model.ProductFeaturesResponse](docs/ProductFeaturesResponse.md)
 - [Model.ProductIDs](docs/ProductIDs.md)
 - [Model.ProductIdentifierBase](docs/ProductIdentifierBase.md)
 - [Model.ProductIdentifierRequest](docs/ProductIdentifierRequest.md)
 - [Model.ProductIdentifierRequestNoProducts](docs/ProductIdentifierRequestNoProducts.md)
 - [Model.ProductIdentifierResponse](docs/ProductIdentifierResponse.md)
 - [Model.ProductIdentifiers](docs/ProductIdentifiers.md)
 - [Model.ProductIdentifiersResponse](docs/ProductIdentifiersResponse.md)
 - [Model.ProductLineItem](docs/ProductLineItem.md)
 - [Model.ProductNested](docs/ProductNested.md)
 - [Model.ProductOptionBase](docs/ProductOptionBase.md)
 - [Model.ProductOptionRequest](docs/ProductOptionRequest.md)
 - [Model.ProductOptionResponse](docs/ProductOptionResponse.md)
 - [Model.ProductOptionsResponse](docs/ProductOptionsResponse.md)
 - [Model.ProductQuantity](docs/ProductQuantity.md)
 - [Model.ProductRequest](docs/ProductRequest.md)
 - [Model.ProductResponse](docs/ProductResponse.md)
 - [Model.ProductResponseLinks](docs/ProductResponseLinks.md)
 - [Model.ProductStatusBase](docs/ProductStatusBase.md)
 - [Model.ProductStatusRequest](docs/ProductStatusRequest.md)
 - [Model.ProductStatusResponse](docs/ProductStatusResponse.md)
 - [Model.ProductStatuses](docs/ProductStatuses.md)
 - [Model.ProductVariantBase](docs/ProductVariantBase.md)
 - [Model.ProductVariantConfigurationRequest](docs/ProductVariantConfigurationRequest.md)
 - [Model.ProductVariantConfigurationResponse](docs/ProductVariantConfigurationResponse.md)
 - [Model.ProductVariantRequest](docs/ProductVariantRequest.md)
 - [Model.ProductVariantResponse](docs/ProductVariantResponse.md)
 - [Model.ProductVariantResponseLinks](docs/ProductVariantResponseLinks.md)
 - [Model.ProductVariantsResponse](docs/ProductVariantsResponse.md)
 - [Model.Products](docs/Products.md)
 - [Model.ProductsResponse](docs/ProductsResponse.md)
 - [Model.PurchaseOrderBase](docs/PurchaseOrderBase.md)
 - [Model.PurchaseOrderIDs](docs/PurchaseOrderIDs.md)
 - [Model.PurchaseOrderRequest](docs/PurchaseOrderRequest.md)
 - [Model.PurchaseOrderResponse](docs/PurchaseOrderResponse.md)
 - [Model.PurchaseOrderStatusBase](docs/PurchaseOrderStatusBase.md)
 - [Model.PurchaseOrderStatusRequest](docs/PurchaseOrderStatusRequest.md)
 - [Model.PurchaseOrderStatusResponse](docs/PurchaseOrderStatusResponse.md)
 - [Model.PurchaseOrderStatuses](docs/PurchaseOrderStatuses.md)
 - [Model.PurchaseOrdersResponse](docs/PurchaseOrdersResponse.md)
 - [Model.Quantity](docs/Quantity.md)
 - [Model.QuotationBase](docs/QuotationBase.md)
 - [Model.QuotationIDs](docs/QuotationIDs.md)
 - [Model.QuotationRequest](docs/QuotationRequest.md)
 - [Model.QuotationResponse](docs/QuotationResponse.md)
 - [Model.QuotationStatusBase](docs/QuotationStatusBase.md)
 - [Model.QuotationStatusRequest](docs/QuotationStatusRequest.md)
 - [Model.QuotationStatusResponse](docs/QuotationStatusResponse.md)
 - [Model.QuotationStatuses](docs/QuotationStatuses.md)
 - [Model.QuotationsResponse](docs/QuotationsResponse.md)
 - [Model.RecipeBase](docs/RecipeBase.md)
 - [Model.RecipeIDs](docs/RecipeIDs.md)
 - [Model.RecipeResponse](docs/RecipeResponse.md)
 - [Model.RecipesResponse](docs/RecipesResponse.md)
 - [Model.Remedies](docs/Remedies.md)
 - [Model.RequestForQuotationBase](docs/RequestForQuotationBase.md)
 - [Model.RequestForQuotationIDs](docs/RequestForQuotationIDs.md)
 - [Model.RequestForQuotationRequest](docs/RequestForQuotationRequest.md)
 - [Model.RequestForQuotationResponse](docs/RequestForQuotationResponse.md)
 - [Model.RequestForQuotationStatusBase](docs/RequestForQuotationStatusBase.md)
 - [Model.RequestForQuotationStatusRequest](docs/RequestForQuotationStatusRequest.md)
 - [Model.RequestForQuotationStatusResponse](docs/RequestForQuotationStatusResponse.md)
 - [Model.RequestForQuotationStatuses](docs/RequestForQuotationStatuses.md)
 - [Model.RequestForQuotationsResponse](docs/RequestForQuotationsResponse.md)
 - [Model.RequestUser](docs/RequestUser.md)
 - [Model.ResponseUser](docs/ResponseUser.md)
 - [Model.SearchItemResponse](docs/SearchItemResponse.md)
 - [Model.SearchItemsResponse](docs/SearchItemsResponse.md)
 - [Model.ShippingAddressRequest](docs/ShippingAddressRequest.md)
 - [Model.ShippingAddressResponse](docs/ShippingAddressResponse.md)
 - [Model.SignInResponse](docs/SignInResponse.md)
 - [Model.SignInsResponse](docs/SignInsResponse.md)
 - [Model.SoftwareAttachmentLinkRequestPatch](docs/SoftwareAttachmentLinkRequestPatch.md)
 - [Model.SoftwareAttachmentLinkRequestPost](docs/SoftwareAttachmentLinkRequestPost.md)
 - [Model.SoftwareAttachmentResponse](docs/SoftwareAttachmentResponse.md)
 - [Model.SoftwareAttachmentsBody](docs/SoftwareAttachmentsBody.md)
 - [Model.SoftwareAttachmentsResponse](docs/SoftwareAttachmentsResponse.md)
 - [Model.SoftwareIDs](docs/SoftwareIDs.md)
 - [Model.SoftwareRequestPatch](docs/SoftwareRequestPatch.md)
 - [Model.SoftwareRequestPost](docs/SoftwareRequestPost.md)
 - [Model.SoftwareResponse](docs/SoftwareResponse.md)
 - [Model.SoftwareResponseSoftwareType](docs/SoftwareResponseSoftwareType.md)
 - [Model.SoftwaresResponse](docs/SoftwaresResponse.md)
 - [Model.SparePartBase](docs/SparePartBase.md)
 - [Model.SparePartIDs](docs/SparePartIDs.md)
 - [Model.SparePartRequest](docs/SparePartRequest.md)
 - [Model.SparePartResponse](docs/SparePartResponse.md)
 - [Model.SparePartResponseLinks](docs/SparePartResponseLinks.md)
 - [Model.SparePartStatusResponse](docs/SparePartStatusResponse.md)
 - [Model.SparePartStatuses](docs/SparePartStatuses.md)
 - [Model.SparePartTypeBase](docs/SparePartTypeBase.md)
 - [Model.SparePartTypeRequest](docs/SparePartTypeRequest.md)
 - [Model.SparePartTypeResponse](docs/SparePartTypeResponse.md)
 - [Model.SparePartTypes](docs/SparePartTypes.md)
 - [Model.SparePartsResponse](docs/SparePartsResponse.md)
 - [Model.SpecificationBase](docs/SpecificationBase.md)
 - [Model.SpecificationHistoryResponse](docs/SpecificationHistoryResponse.md)
 - [Model.SpecificationKeys](docs/SpecificationKeys.md)
 - [Model.SpecificationRequest](docs/SpecificationRequest.md)
 - [Model.SpecificationResponse](docs/SpecificationResponse.md)
 - [Model.SpecificationUIVisibleRequest](docs/SpecificationUIVisibleRequest.md)
 - [Model.SpecificationUIVisibleResponse](docs/SpecificationUIVisibleResponse.md)
 - [Model.SpecificationsDelete](docs/SpecificationsDelete.md)
 - [Model.SpecificationsRename](docs/SpecificationsRename.md)
 - [Model.SpecificationsRequest](docs/SpecificationsRequest.md)
 - [Model.SpecificationsResponse](docs/SpecificationsResponse.md)
 - [Model.SpecificationsUIVisibleRequest](docs/SpecificationsUIVisibleRequest.md)
 - [Model.SpecificationsUIVisibleResponse](docs/SpecificationsUIVisibleResponse.md)
 - [Model.SubscriptionAssetAssignmentRequest](docs/SubscriptionAssetAssignmentRequest.md)
 - [Model.SubscriptionBase](docs/SubscriptionBase.md)
 - [Model.SubscriptionRequest](docs/SubscriptionRequest.md)
 - [Model.SubscriptionResponse](docs/SubscriptionResponse.md)
 - [Model.SubscriptionSeatBase](docs/SubscriptionSeatBase.md)
 - [Model.SubscriptionSeatPatch](docs/SubscriptionSeatPatch.md)
 - [Model.SubscriptionSeatResponse](docs/SubscriptionSeatResponse.md)
 - [Model.SubscriptionSeatsResponse](docs/SubscriptionSeatsResponse.md)
 - [Model.SubscriptionsResponse](docs/SubscriptionsResponse.md)
 - [Model.SuccessorResponse](docs/SuccessorResponse.md)
 - [Model.SuccessorsResponse](docs/SuccessorsResponse.md)
 - [Model.SystemBase](docs/SystemBase.md)
 - [Model.SystemIDs](docs/SystemIDs.md)
 - [Model.SystemResponse](docs/SystemResponse.md)
 - [Model.SystemsResponse](docs/SystemsResponse.md)
 - [Model.TechnicalUserBase](docs/TechnicalUserBase.md)
 - [Model.TechnicalUserCreateResponse](docs/TechnicalUserCreateResponse.md)
 - [Model.TechnicalUserCreateResponseLinks](docs/TechnicalUserCreateResponseLinks.md)
 - [Model.TechnicalUserPasswordResponse](docs/TechnicalUserPasswordResponse.md)
 - [Model.TechnicalUserRequest](docs/TechnicalUserRequest.md)
 - [Model.TechnicalUserResponse](docs/TechnicalUserResponse.md)
 - [Model.TechnicalUsersResponse](docs/TechnicalUsersResponse.md)
 - [Model.TenantBase](docs/TenantBase.md)
 - [Model.TenantRequest](docs/TenantRequest.md)
 - [Model.TenantResponse](docs/TenantResponse.md)
 - [Model.Tenants](docs/Tenants.md)
 - [Model.TenantsResponse](docs/TenantsResponse.md)
 - [Model.ThresholdBase](docs/ThresholdBase.md)
 - [Model.ThresholdRequest](docs/ThresholdRequest.md)
 - [Model.ThresholdResponse](docs/ThresholdResponse.md)
 - [Model.ThresholdsResponse](docs/ThresholdsResponse.md)
 - [Model.UnitBase](docs/UnitBase.md)
 - [Model.UnitResponse](docs/UnitResponse.md)
 - [Model.UnitsResponse](docs/UnitsResponse.md)
 - [Model.UsageResponse](docs/UsageResponse.md)
 - [Model.UserAddressRequest](docs/UserAddressRequest.md)
 - [Model.UserAddressResponse](docs/UserAddressResponse.md)
 - [Model.UserBase](docs/UserBase.md)
 - [Model.UserChangeRequest](docs/UserChangeRequest.md)
 - [Model.UserGroupBase](docs/UserGroupBase.md)
 - [Model.UserGroupIDs](docs/UserGroupIDs.md)
 - [Model.UserGroupRequest](docs/UserGroupRequest.md)
 - [Model.UserGroupResponse](docs/UserGroupResponse.md)
 - [Model.UserGroupResponseLinks](docs/UserGroupResponseLinks.md)
 - [Model.UserGroupWithUsers](docs/UserGroupWithUsers.md)
 - [Model.UserGroupsWithUsers](docs/UserGroupsWithUsers.md)
 - [Model.UserIDorEmails](docs/UserIDorEmails.md)
 - [Model.UserIDs](docs/UserIDs.md)
 - [Model.UserPublicResponse](docs/UserPublicResponse.md)
 - [Model.UserResponse](docs/UserResponse.md)
 - [Model.UserResponseLinks](docs/UserResponseLinks.md)
 - [Model.UserRoleBase](docs/UserRoleBase.md)
 - [Model.UserRoleIDs](docs/UserRoleIDs.md)
 - [Model.UserRoleRequest](docs/UserRoleRequest.md)
 - [Model.UserRoleResponse](docs/UserRoleResponse.md)
 - [Model.UserRolesResponse](docs/UserRolesResponse.md)
 - [Model.UsersPublicResponse](docs/UsersPublicResponse.md)
 - [Model.UsersResponse](docs/UsersResponse.md)
 - [Model.WebhookBase](docs/WebhookBase.md)
 - [Model.WebhookBaseProperties](docs/WebhookBaseProperties.md)
 - [Model.WebhookCreateResponse](docs/WebhookCreateResponse.md)
 - [Model.WebhookEventIDs](docs/WebhookEventIDs.md)
 - [Model.WebhookEventResponse](docs/WebhookEventResponse.md)
 - [Model.WebhookEventResponses](docs/WebhookEventResponses.md)
 - [Model.WebhookRequest](docs/WebhookRequest.md)
 - [Model.WebhookResponse](docs/WebhookResponse.md)
 - [Model.WebhookResponses](docs/WebhookResponses.md)
 - [Model.WebhookSecretResponse](docs/WebhookSecretResponse.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="API-Key"></a>
### API-Key

- **Type**: API key
- **API key parameter name**: API-Key
- **Location**: HTTP header

<a name="Authentication"></a>
### Authentication

- **Type**: HTTP basic authentication

