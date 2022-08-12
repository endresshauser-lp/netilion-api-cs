# Netilion.Api.Model.AssetResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SerialNumber** | **string** | at least 4 characters long and unique within the manufacturers scope. Whitespaces are trimmed | 
**Description** | **string** | description text of the asset | [optional] 
**ProductionDate** | **string** | Date of production of the asset | [optional] 
**LastSeenAt** | **string** | last time this asset has been visited/seen/scanned by a person or edge device | [optional] 
**Id** | **long?** | Id of object | [optional] 
**OwnershipClaimed** | **bool?** | flag if asset ownership was claimed by a user | [optional] [default to false]
**CreatedAt** | **string** | Timestamp at which the asset was created | [optional] 
**UpdatedAt** | **string** | Timestamp at which the asset was last changed | [optional] 
**Product** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**ProductVariant** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Parent** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Status** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Tenant** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Links** | [**Links2**](Links2.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

