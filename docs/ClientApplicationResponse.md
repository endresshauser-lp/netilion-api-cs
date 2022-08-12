# Netilion.Api.Model.ClientApplicationResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the client application | 
**Description** | **string** | Description of the client application | [optional] 
**RedirectUris** | **List&lt;string&gt;** | Redirect URIs array | [optional] 
**IsInsider** | **bool?** | Endress+Hauser Application | [optional] 
**CanSendMails** | **bool?** | Is client application allowed to send mails? | [optional] 
**Id** | **long?** | Id of object | [optional] 
**AllowEdgeDeviceApplication** | **bool?** | Is the client application allowed to get assigned to an edge device application? | [optional] 
**ContactPerson** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**TechnicalUser** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 
**BillingContact** | [**BillingContactResponse**](BillingContactResponse.md) |  | [optional] 
**Links** | [**Links4**](Links4.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

