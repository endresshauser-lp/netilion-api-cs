# Netilion.Api.Model.AttachmentResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Id of object | 
**Type** | **string** | type of attachment, can be &#x27;file&#x27; or &#x27;link&#x27; | 
**FileName** | **string** | the original filename of the attachment | [optional] 
**Fingerprint** | **string** | SHA256 checksum of the file | [optional] 
**ContentAuthor** | **string** | the file authors name | [optional] 
**ContentVersion** | **string** | the version of the attachment | [optional] 
**ContentDate** | **string** | date of the content | [optional] 
**ContentType** | **string** | content type of the file | [optional] 
**Remarks** | **string** | remarks of the attachment | [optional] 
**Document** | [**NestedIDHref**](NestedIDHref.md) |  | 
**Languages** | **List&lt;string&gt;** | the languages of the files content | [optional] 
**DownloadHref** | **string** | the download link to the file of the attachment | 
**CreatedAt** | **string** | Timestamp at which the attachment was created | [optional] 
**UpdatedAt** | **string** | Timestamp at which the attachment was last changed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

