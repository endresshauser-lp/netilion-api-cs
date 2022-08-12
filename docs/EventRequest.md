# Netilion.Api.Model.EventRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the event | 
**Description** | **string** | description text of the event | [optional] 
**Responsible** | **string** | responsible of the event | [optional] 
**StartDatetime** | **string** | start date/time of the event: format example: 2016-01-01T18:30:00 | [optional] 
**EndDatetime** | **string** | end date/time of the event: format example: 2016-01-01T18:30:00 | [optional] 
**Status** | [**NestedID**](NestedID.md) |  | [optional] 
**Type** | [**NestedID**](NestedID.md) |  | [optional] 
**Tenant** | [**NestedID**](NestedID.md) |  | [optional] 
**Assets** | [**List&lt;NestedID&gt;**](NestedID.md) |  | [optional] 
**Instrumentations** | [**List&lt;NestedID&gt;**](NestedID.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

