# Netilion.Api.Model.InstrumentationResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tag** | **string** | Instrumentation tag. The value must be unique if under a parent instrumentation | [optional] 
**Description** | **string** | description text of the Instrumentation | [optional] 
**Criticality** | **string** | possible values are: undefined, low, medium and high. Undefined is assigned per default | [optional] 
**Accessibility** | **string** | possible values are: undefined, easy, moderate and difficult. Undefined is assigned per default | [optional] 
**Id** | **long?** | Id of object | [optional] 
**Status** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Type** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Parent** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Tenant** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Links** | [**Links12**](Links12.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

