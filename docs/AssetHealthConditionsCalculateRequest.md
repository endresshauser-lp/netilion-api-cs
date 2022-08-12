# Netilion.Api.Model.AssetHealthConditionsCalculateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Protocol** | **string** | possible values: HART, PROFIBUS, ETHERNETIP, MODBUS, OTHERS | 
**ProtocolVersion** | **string** | definition of the protocol version. For example 5, 6 or 7 for HART | [optional] 
**DiagnosisMessage** | **string** | diagnosis message to use for the calculation | 
**DeviceIdent** | **string** | the protocol dependent device identifier, mandatory for HART and PROFIBUS protocol | [optional] 
**ProductIdentifier** | **string** | the protocol dependent product identifier, mandatory for HART and PROFIBUS protocol | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

