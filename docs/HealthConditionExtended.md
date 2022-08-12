# Netilion.Api.Model.HealthConditionExtended
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiagnosisCode** | **string** | Diagnosis code of the health condition. Whitespaces are trimmed | 
**Protocol** | **string** | Possible values are: &#x27;PROFIBUS&#x27;, &#x27;HART&#x27; and &#x27;MODBUS&#x27;. | [optional] 
**ProtocolVersion** | **string** | version number of the protocol | [optional] 
**DeviceIdent** | **string** | protocol specific device_ident | [optional] 
**ProductIdentifier** | **string** | protocol specific product_identifier | [optional] 
**Hidden** | **bool?** | should be hidden in frontend | [optional] [default to false]
**Rules** | [**List&lt;HealthConditionExtendedRules&gt;**](HealthConditionExtendedRules.md) | Health condition rules. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

