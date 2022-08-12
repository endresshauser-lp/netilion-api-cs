# Netilion.Api.Model.DataExportRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container | 
**StartDate** | **string** | start of export date range | [optional] 
**EndDate** | **string** | end of export date range, if not provided, current date will be used | [optional] 
**Language** | **string** | language in which the export should be made (currently only applicable to vdi 2770 containers) | [optional] 
**Asset** | [**NestedID**](NestedID.md) |  | [optional] 
**Instrumentation** | [**NestedID**](NestedID.md) |  | [optional] 
**System** | [**NestedID**](NestedID.md) |  | [optional] 
**Batch** | [**NestedID**](NestedID.md) |  | [optional] 
**Keys** | **List&lt;string&gt;** | value keys to export (in case of type instrumentation_values) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

