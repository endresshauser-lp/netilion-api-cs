# Netilion.Api.Model.SubscriptionResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Name of the subscription | [optional] 
**Description** | **string** | Description of the subscription | [optional] 
**ExternalReference** | **string** | can be used to store id of external subscription managment system | [optional] 
**Status** | **string** | status of the subscription, can be  open, payment_required, confirmed, cancelled, scheduled_update and non_renewing | [optional] 
**NotificationStatus** | **string** | status of the mail notification for the subscription, can be no_notification, first_notification, second_notification or alert_notification | [optional] 
**CustomerPurchaseOrder** | **string** | reference for customer system | [optional] 
**StartDate** | **string** | start date of the subscription | [optional] 
**EndDate** | **string** | end date of the subscription | [optional] 
**BilledUntil** | **string** | end date of the subscription | [optional] 
**TrialEndDate** | **string** | end date of the subscription&#x27;s trial period | [optional] 
**CancelledAt** | **string** | date when subscription was cancelled | [optional] 
**ExternalUserReference** | **string** | can be used to store user id of external subscription managment system | [optional] 
**ExternalPlanVariantReference** | **string** | can be used to store paln variant of external subscription managment system | [optional] 
**NumberAssignedAssets** | **int?** | number of assigned assets | [optional] 
**AssetQuota** | **int?** | number of bought assets | [optional] 
**StorageQuota** | **int?** | number of bought storage (in bytes) | [optional] 
**SeatQuota** | **int?** | number of bought seats | [optional] 
**ForceMfa** | **bool?** | will force MFA for the users using this subscription including owner and seat users | [optional] 
**ResellerLabel** | **string** | Custom label given to the subscription by the reseller user | [optional] 
**Id** | **long?** | Id of object | [optional] 
**CreatedAt** | **string** | Timestamp at which the subscription was created | [optional] 
**UpdatedAt** | **string** | Timestamp at which the subscription was last changed | [optional] 
**User** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**ClientApplication** | [**NestedIDHrefName**](NestedIDHrefName.md) |  | [optional] 
**BillingAddress** | [**BillingAddressResponse**](BillingAddressResponse.md) |  | [optional] 
**ShippingAddress** | [**ShippingAddressResponse**](ShippingAddressResponse.md) |  | [optional] 
**Successor** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Predecessor** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Customer** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Usable** | **bool?** | indecates whether the subscription can be used as a user subscription (user is owner or a seat user) in our service applications e.g. Analytics. This information will only be part of the response if scope with value &#x27;USER&#x27; is used. | [optional] 
**Links** | [**Links21**](Links21.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

