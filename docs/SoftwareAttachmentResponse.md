# Netilion.Api.Model.SoftwareAttachmentResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Id of object | 
**Type** | **string** | type of software attachment, can be &#x27;file&#x27; or &#x27;link&#x27; | 
**FileName** | **string** | the original filename of the software attachment | [optional] 
**Fingerprint** | **string** | SHA256 checksum of the file | [optional] 
**ContentDate** | **string** | last edit date of the file | [optional] 
**Remarks** | **string** | remarks of the software attachment | [optional] 
**Software** | [**NestedIDHref**](NestedIDHref.md) |  | 
**DownloadHref** | **string** | the download link to the file of the software attachment | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

