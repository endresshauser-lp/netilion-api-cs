# Netilion.Api.Model.WebhookEventResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Id of webhook event | 
**Status** | **string** | status of the event, possible values are pending, delivered, cancelled and failed | [optional] 
**Payload** | **Object** | payload of the webhook event | [optional] 
**LastSendAt** | **string** | datewhen webhook event was last send | [optional] 
**Retries** | **int?** | number of retries to send the event | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

