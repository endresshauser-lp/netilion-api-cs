# Netilion.Api.Model.AssetKeyValuesResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | key of the asset values | 
**Unit** | [**NestedID**](NestedID.md) |  | [optional] 
**Group** | **string** | group of the asset value. No wildcard-filter supported. | [optional] 
**Latest** | **string** | the last written asset value | [optional] 
**Max** | **string** | the maximum value for the requested time slot | [optional] 
**Min** | **string** | the minimum value for the requested time slot | [optional] 
**Mean** | **string** | the mean (average) value for the requested time slot | [optional] 
**Data** | [**List&lt;AssetKeyValuesData&gt;**](AssetKeyValuesData.md) |  | [optional] 
**Pagination** | [**AssetValuesPagination**](AssetValuesPagination.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

