# Netilion.Api.Model.AssetRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SerialNumber** | **string** | at least 4 characters long and unique within the manufacturers scope. Whitespaces are trimmed | 
**Description** | **string** | description text of the asset | [optional] 
**ProductionDate** | **string** | Date of production of the asset | [optional] 
**LastSeenAt** | **string** | last time this asset has been visited/seen/scanned by a person or edge device | [optional] 
**Status** | [**NestedID**](NestedID.md) |  | [optional] 
**Product** | [**NestedID**](NestedID.md) |  | [optional] 
**Parent** | [**NestedID**](NestedID.md) |  | [optional] 
**Tenant** | [**NestedID**](NestedID.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

