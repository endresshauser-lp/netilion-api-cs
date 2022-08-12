# Netilion.Api.Model.DataExportResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **int?** |  | 
**Type** | **string** | can be complete, measurements, batch_values, instrumentation_values, asset_vdi_2770_documentation_container or system_vdi_2770_documentation_container | 
**StartDate** | **string** |  | [optional] 
**EndDate** | **string** |  | [optional] 
**CreatedAt** | **string** |  | 
**FinishedAt** | **string** |  | [optional] 
**Language** | **string** | language in which the export should be made (currently only applicable to vdi 2770 containers) | [optional] 
**ExportFileName** | **string** |  | [optional] 
**ExportContentType** | **string** |  | [optional] 
**ExportFileSize** | **string** |  | [optional] 
**ExportUpdatedAt** | **string** |  | [optional] 
**ExportFingerprint** | **string** |  | [optional] 
**User** | [**NestedIDHref**](NestedIDHref.md) |  | 
**Asset** | [**NestedIDHrefSerialnumber**](NestedIDHrefSerialnumber.md) |  | [optional] 
**Instrumentation** | [**NestedIDHrefTag**](NestedIDHrefTag.md) |  | [optional] 
**System** | [**NestedIDHrefName**](NestedIDHrefName.md) |  | [optional] 
**Batch** | [**NestedIDHrefName**](NestedIDHrefName.md) |  | [optional] 
**DownloadHref** | **string** | download link | [optional] 
**AvailableUntil** | **string** | date until the download is available, after that the download will automatically removed | [optional] 
**Keys** | **List&lt;string&gt;** | value keys to export (in case of type instrumentation_values) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

