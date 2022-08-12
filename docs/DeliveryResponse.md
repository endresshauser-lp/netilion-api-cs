# Netilion.Api.Model.DeliveryResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | Number of the delivery | 
**Name** | **string** | Name of the delivery | [optional] 
**CustomerNumber** | **string** | Customer number, the delivery was shipped to | [optional] 
**Description** | **string** | description text of the delivery | [optional] 
**DateOfShipment** | **string** | date of the delivery: format example: 2016-01-01T18:30:00 | [optional] 
**Id** | **long?** | Id of object | [optional] 
**Sender** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Receiver** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Status** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Products** | [**List&lt;DeliveryProducts&gt;**](DeliveryProducts.md) |  | [optional] 
**Links** | [**Links5**](Links5.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

