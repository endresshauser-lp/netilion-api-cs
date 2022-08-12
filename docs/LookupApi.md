# Netilion.Api.Api.LookupApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EhExtendedOrderCodeLookup**](LookupApi.md#ehextendedordercodelookup) | **GET** /endress/extended_order_code_lookup | lookup for the extended order code for Endress+Hauser products
[**EhProductLookup**](LookupApi.md#ehproductlookup) | **GET** /endress/product_lookup | lookup for Endress+Hauser products with asset specific search criterias
[**EhSuccessorLookup**](LookupApi.md#ehsuccessorlookup) | **GET** /endress/successor_lookup | lookup for Endress+Hauser successor products

<a name="ehextendedordercodelookup"></a>
# **EhExtendedOrderCodeLookup**
> ExtendedOrderCode EhExtendedOrderCodeLookup (string orderCode)

lookup for the extended order code for Endress+Hauser products

Returns an extended order code for Endress+Hauser products when the given order code is existing

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class EhExtendedOrderCodeLookupExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");
            // Configure HTTP basic authorization: Authentication
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LookupApi();
            var orderCode = orderCode_example;  // string | any Endress+Hauser order code

            try
            {
                // lookup for the extended order code for Endress+Hauser products
                ExtendedOrderCode result = apiInstance.EhExtendedOrderCodeLookup(orderCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookupApi.EhExtendedOrderCodeLookup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderCode** | **string**| any Endress+Hauser order code | 

### Return type

[**ExtendedOrderCode**](ExtendedOrderCode.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ehproductlookup"></a>
# **EhProductLookup**
> ProductResponse EhProductLookup (string serialNumber)

lookup for Endress+Hauser products with asset specific search criterias

Returns an Endress+Hauser product, matching the serial number. The serial number is at least 4 characters long and may include letters, numbers, dashes (-), underscores (_) and backslashes (\\\\).

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class EhProductLookupExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");
            // Configure HTTP basic authorization: Authentication
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LookupApi();
            var serialNumber = serialNumber_example;  // string | Any Endress+Hauser serial number

            try
            {
                // lookup for Endress+Hauser products with asset specific search criterias
                ProductResponse result = apiInstance.EhProductLookup(serialNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookupApi.EhProductLookup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serialNumber** | **string**| Any Endress+Hauser serial number | 

### Return type

[**ProductResponse**](ProductResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ehsuccessorlookup"></a>
# **EhSuccessorLookup**
> SuccessorsResponse EhSuccessorLookup (string include = null, string serialNumber = null, string orderCode = null, string productCode = null)

lookup for Endress+Hauser successor products

Returns successor information, if a serial_number or order code was provided, the order code transformer is used, for product_code the successor comes from the Product Status List r Possible include values: ```product, product.pictures,product.status, product.parent``` The serial number is at least 4 characters long and may include letters, numbers, dashes (-), underscores (_) and backslashes (\\\\).

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class EhSuccessorLookupExample
    {
        public void main()
        {
            // Configure API key authorization: API-Key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");
            // Configure HTTP basic authorization: Authentication
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LookupApi();
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var serialNumber = serialNumber_example;  // string | Any Endress+Hauser serial number (optional) 
            var orderCode = orderCode_example;  // string | an Endress+Hauser order code (optional) 
            var productCode = productCode_example;  // string | an Endress+Hauser product_code (optional) 

            try
            {
                // lookup for Endress+Hauser successor products
                SuccessorsResponse result = apiInstance.EhSuccessorLookup(include, serialNumber, orderCode, productCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookupApi.EhSuccessorLookup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **serialNumber** | **string**| Any Endress+Hauser serial number | [optional] 
 **orderCode** | **string**| an Endress+Hauser order code | [optional] 
 **productCode** | **string**| an Endress+Hauser product_code | [optional] 

### Return type

[**SuccessorsResponse**](SuccessorsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
