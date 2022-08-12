# Netilion.Api.Model.EdgeDeviceResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SerialNumber** | **string** | serial number of the edge device | 
**Name** | **string** | name of the edge device | [optional] 
**Description** | **string** | description of the edge device | [optional] 
**LogLevel** | **string** | log level the edge device should use (allowed values: trace, debug, info, warning, error, critical, off) | [optional] 
**ApplyTimestamp** | **string** | timestamp when the current settings have been applied at in the edge device. Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
**Id** | **long?** | Id of object | [optional] 
**Type** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Status** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**SoftwareVersion** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**TechnicalUser** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**OrderUser** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**ApiSubscription** | [**EdgeDeviceResponseApiSubscription**](EdgeDeviceResponseApiSubscription.md) |  | [optional] 
**ApiKey** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Tenant** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**Usergroup** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**AddOn** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**LastSeenAt** | **string** | timestamp when the edge_device iself has polled the hub the last time. Date format is YYYY-MM-DDThh:mm:ss | [optional] 
**Links** | [**Links9**](Links9.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

