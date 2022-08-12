# Netilion.Api.Model.ProductResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** | Product code must be unique within the manufacturers scope. Whitespaces are trimmed. | [optional] 
**Name** | **string** | Supports translations. Whitespaces are trimmed. | [optional] 
**Description** | **string** | Supports translations. | [optional] 
**Id** | **long?** | Id of object | [optional] 
**Status** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Manufacturer** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Parent** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Tenant** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Links** | [**ProductResponseLinks**](ProductResponseLinks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

