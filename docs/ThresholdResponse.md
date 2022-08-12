# Netilion.Api.Model.ThresholdResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Id of object | 
**Name** | **string** | name of the threshold. The name of the threshold. | 
**Description** | **string** | description of the threshold. The description of the threshold. | [optional] 
**Key** | **string** | key of the threshold. This key is related to the keys set in asset values. | 
**UnitId** | **long?** | Id of the unit used for the threshold value property. | [optional] 
**Value** | **float?** | the threshold value | 
**Tolerance** | **float?** | the threshold tolerance, should be a positive value | 
**ThresholdType** | **string** | the threshold type, tree values can be given for now, &#x27;low&#x27; if the it is a lower threshold, &#x27;high&#x27; if it is an upper threshold and &#x27;deviation&#x27; if it is as deviation from reference values | 
**Notification** | **bool?** | Whether the threshold should send notifications when exceeded | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

