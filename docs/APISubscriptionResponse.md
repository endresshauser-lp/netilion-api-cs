# Netilion.Api.Model.APISubscriptionResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Name of the api subscription | [optional] 
**Description** | **string** | Description of the api subscription | [optional] 
**ExternalReference** | **string** | can be used to store id of external api subscription managment system | [optional] 
**Status** | **string** | status of the api subscription, can be  open, payment_required, confirmed, cancelled, scheduled_update and non_renewing | [optional] 
**NotificationStatus** | **string** | status of the mail notification for the api subscription, can be no_notification, first_notification, second_notification or alert_notification | [optional] 
**SubscriptionType** | **string** | type of the api subscription, can be &#x27;s&#x27; or &#x27;m&#x27; | [optional] 
**CustomerPurchaseOrder** | **string** | reference for customer system | [optional] 
**StartDate** | **string** | start date of the api subscription | [optional] 
**EndDate** | **string** | end date of the api subscription | [optional] 
**BilledUntil** | **string** | end date of the api subscription | [optional] 
**ExternalUserReference** | **string** | can be used to store user id of external api subscription managment system | [optional] 
**ExternalPlanVariantReference** | **string** | can be used to store paln variant of external api subscription managment system | [optional] 
**ApiCallQuota** | **int?** | number of bought api calls | [optional] 
**StorageQuota** | **int?** | number of bought storage (in bytes) | [optional] 
**NumberAssignedAssets** | **int?** | number of assigned assets | [optional] 
**ConnectedAssetsUsed** | **int?** | number of connected assets used | [optional] 
**UploadDownloadQuota** | **int?** | traffic for up- and download of data (in bytes) | [optional] 
**ConnectedAssetQuota** | **int?** | number of bought connected asset addons | [optional] 
**ApiCallsUsed** | **int?** | number of api calls used | [optional] 
**StorageUsed** | **int?** | number of storage used (in bytes) | [optional] 
**UploadDownloadUsed** | **int?** | data up- and download used (in bytes) | [optional] 
**Id** | **long?** | Id of object | [optional] 
**CreatedAt** | **string** | Timestamp at which the api subscription was created | [optional] 
**UpdatedAt** | **string** | Timestamp at which the api subscription was last changed | [optional] 
**User** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**ClientApplication** | [**NestedIDHrefName**](NestedIDHrefName.md) |  | [optional] 
**BillingAddress** | [**BillingAddressResponse**](BillingAddressResponse.md) |  | [optional] 
**ShippingAddress** | [**ShippingAddressResponse**](ShippingAddressResponse.md) |  | [optional] 
**Links** | [**Links**](Links.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

