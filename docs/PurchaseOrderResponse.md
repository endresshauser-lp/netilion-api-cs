# Netilion.Api.Model.PurchaseOrderResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** |  | 
**CustomerNumber** | **string** | customer number the purchase order was sold to | [optional] 
**CustomerPurchaseOrderNumber** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Date** | **string** | Date must be in format &#x27;2016-01-01&#x27; | [optional] 
**Description** | **string** |  | [optional] 
**Id** | **long?** | Id of object | [optional] 
**Status** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Sender** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Receiver** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Quotation** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**LineItems** | [**List&lt;ProductLineItem&gt;**](ProductLineItem.md) |  | [optional] 
**Links** | [**Links16**](Links16.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

