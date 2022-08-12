# Netilion.Api.Model.APIKeyResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValidFrom** | **string** | Date must be in format &#x27;2016-01-01&#x27;, cannot be set by non-admin users | [optional] 
**ValidUntil** | **string** | Date must be in format &#x27;2016-01-01&#x27;, cannot be set by non-admin users | [optional] 
**Disabled** | **bool?** | disabled api keys cannot be used for requests | [optional] [default to false]
**AuthenticationType** | **string** | possible values are: any, oauth, basic_auth. Oauth is assigned per default | [optional] 
**Description** | **string** | Description of the APIKey | [optional] 
**Id** | **long?** | Id of object | [optional] 
**ApiKey** | **string** | the api_key value | [optional] 
**ApiSecret** | **string** | API Key api_secret (only for oauth authentication) | [optional] 
**ClientApplication** | [**NestedIDHref**](NestedIDHref.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

