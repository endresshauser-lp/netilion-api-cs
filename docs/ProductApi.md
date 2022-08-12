# Netilion.Api.Api.ProductApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCategoriesToProduct**](ProductApi.md#addcategoriestoproduct) | **POST** /products/{product_id}/categories | Add categories to a product
[**AddDocumentsToProduct**](ProductApi.md#adddocumentstoproduct) | **POST** /products/{product_id}/documents | Add documents to a product
[**AddEdgeDeviceFeaturesToProduct**](ProductApi.md#addedgedevicefeaturestoproduct) | **POST** /products/{product_id}/edge_device_features | Add edge device features to a product
[**AddProductPictureLink**](ProductApi.md#addproductpicturelink) | **POST** /products/{id}/pictures/links | Add a link as product picture
[**AddPurchaseOrdersToProduct**](ProductApi.md#addpurchaseorderstoproduct) | **POST** /products/{product_id}/purchase_orders | Add purchase orders to a product
[**AddQuotationsToProduct**](ProductApi.md#addquotationstoproduct) | **POST** /products/{product_id}/quotations | Add quotations to a product
[**AddSoftwaresToProduct**](ProductApi.md#addsoftwarestoproduct) | **POST** /products/{product_id}/softwares | Add software to a product
[**AddSparePartsToProduct**](ProductApi.md#addsparepartstoproduct) | **POST** /products/{product_id}/spare_parts | Add spare parts to a product
[**CreateProduct**](ProductApi.md#createproduct) | **POST** /products | Create a new product
[**CreateProductFeature**](ProductApi.md#createproductfeature) | **POST** /product_features | Create a new product feature
[**CreateProductOption**](ProductApi.md#createproductoption) | **POST** /product_options | Create a new product option
[**CreateProductVariant**](ProductApi.md#createproductvariant) | **POST** /product_variants | Create a new product variant
[**DeleteCategoriesFromProduct**](ProductApi.md#deletecategoriesfromproduct) | **DELETE** /products/{product_id}/categories | Remove categories from a product
[**DeleteProduct**](ProductApi.md#deleteproduct) | **DELETE** /products/{id} | Delete a product
[**DeleteProductFeature**](ProductApi.md#deleteproductfeature) | **DELETE** /product_features/{id} | Delete a product feature
[**DeleteProductOption**](ProductApi.md#deleteproductoption) | **DELETE** /product_options/{id} | Delete a product option
[**DeleteProductPicture**](ProductApi.md#deleteproductpicture) | **DELETE** /products/{product_id}/pictures/{id} | Delete a product picture
[**DeleteProductVariant**](ProductApi.md#deleteproductvariant) | **DELETE** /product_variants/{id} | Delete a product variant
[**DownloadProductPicture**](ProductApi.md#downloadproductpicture) | **GET** /products/{product_id}/pictures/{id}/download | Download a product picture
[**GetAssetProductOptions**](ProductApi.md#getassetproductoptions) | **GET** /assets/{asset_id}/product-options | Get all possible products of the specified assets
[**GetCategoriesOfProduct**](ProductApi.md#getcategoriesofproduct) | **GET** /products/{product_id}/categories | Get all categories of a product
[**GetCategoriesOptionsOfProduct**](ProductApi.md#getcategoriesoptionsofproduct) | **GET** /products/{product_id}/categories-options | Get all categories of one product
[**GetDocumentsOfProduct**](ProductApi.md#getdocumentsofproduct) | **GET** /products/{product_id}/documents | Get all documents of a product
[**GetDocumentsOfProductVariant**](ProductApi.md#getdocumentsofproductvariant) | **GET** /product_variants/{product_variant_id}/documents | Get all documents of a product variant
[**GetEdgeDeviceFeaturesOfProduct**](ProductApi.md#getedgedevicefeaturesofproduct) | **GET** /products/{product_id}/edge_device_features | Get all edge device features of a product
[**GetProductById**](ProductApi.md#getproductbyid) | **GET** /products/{id} | Get a single product
[**GetProductFeatureById**](ProductApi.md#getproductfeaturebyid) | **GET** /product_features/{id} | Get a single product feature
[**GetProductFeatures**](ProductApi.md#getproductfeatures) | **GET** /product_features | Get a range of product features
[**GetProductIdStatus**](ProductApi.md#getproductidstatus) | **GET** /products/{product_id}/status | Get the status of a specific product
[**GetProductOptionById**](ProductApi.md#getproductoptionbyid) | **GET** /product_options/{id} | Get a single product option
[**GetProductOptions**](ProductApi.md#getproductoptions) | **GET** /product_options | Get a range of product options
[**GetProductPicture**](ProductApi.md#getproductpicture) | **GET** /products/{product_id}/pictures/{id} | Get a product picture
[**GetProductPictures**](ProductApi.md#getproductpictures) | **GET** /products/{id}/pictures | Get product pictures
[**GetProductStatusesOptions**](ProductApi.md#getproductstatusesoptions) | **GET** /products/{product_id}/status-options | Get all possible statuses for the specified product
[**GetProductVariantById**](ProductApi.md#getproductvariantbyid) | **GET** /product_variants/{id} | Get a single product variant
[**GetProductVariantConfigurations**](ProductApi.md#getproductvariantconfigurations) | **GET** /product_variants/{id}/configurations | get configuration of product variant
[**GetProductVariants**](ProductApi.md#getproductvariants) | **GET** /product_variants | Get a range of product variants
[**GetProducts**](ProductApi.md#getproducts) | **GET** /products | Get a range of products
[**GetProductsOfCompany**](ProductApi.md#getproductsofcompany) | **GET** /companies/{company_id}/products | Get all products of a company
[**GetPurchaseOrdersOfProduct**](ProductApi.md#getpurchaseordersofproduct) | **GET** /products/{product_id}/purchase_orders | Get all purchase orders of one product
[**GetQuotationsOfProduct**](ProductApi.md#getquotationsofproduct) | **GET** /products/{product_id}/quotations | Get all quotations of one product
[**GetSoftwaresOfProduct**](ProductApi.md#getsoftwaresofproduct) | **GET** /products/{product_id}/softwares | Get a range of software of one product
[**GetSparePartsOfProduct**](ProductApi.md#getsparepartsofproduct) | **GET** /products/{product_id}/spare_parts | Get all spare parts of a product
[**GetSpecificationsOfProduct**](ProductApi.md#getspecificationsofproduct) | **GET** /products/{product_id}/specifications | Get specifications of a product
[**RemoveDocumentsFromProduct**](ProductApi.md#removedocumentsfromproduct) | **DELETE** /products/{product_id}/documents | Remove documents from a product
[**RemoveEdgeDeviceFeaturesFromProduct**](ProductApi.md#removeedgedevicefeaturesfromproduct) | **DELETE** /products/{product_id}/edge_device_features | Remove edge device features from a product
[**RemovePurchaseOrdersFromProduct**](ProductApi.md#removepurchaseordersfromproduct) | **DELETE** /products/{product_id}/purchase_orders | Remove purchase orders from a product
[**RemoveQuotationsFromProduct**](ProductApi.md#removequotationsfromproduct) | **DELETE** /products/{product_id}/quotations | Remove quotations from a product
[**RemoveSoftwaresOfProduct**](ProductApi.md#removesoftwaresofproduct) | **DELETE** /products/{product_id}/softwares | Remove software from a product
[**RemoveSparePartsFromProduct**](ProductApi.md#removesparepartsfromproduct) | **DELETE** /products/{product_id}/spare_parts | Remove spare parts from a product
[**RemoveSpecificationsFromProduct**](ProductApi.md#removespecificationsfromproduct) | **DELETE** /products/{product_id}/specifications | Delete specifications of a product
[**RenameSpecificationsOfProduct**](ProductApi.md#renamespecificationsofproduct) | **PATCH** /products/{product_id}/specifications/rename | rename a key in the specification.
[**ReplaceCategoriesOfProduct**](ProductApi.md#replacecategoriesofproduct) | **PATCH** /products/{product_id}/categories | Replace all categories of a product
[**ReplaceDocumentsOfProduct**](ProductApi.md#replacedocumentsofproduct) | **PATCH** /products/{product_id}/documents | Replace the documents of a product
[**ReplaceEdgeDeviceFeaturesOfProduct**](ProductApi.md#replaceedgedevicefeaturesofproduct) | **PATCH** /products/{product_id}/edge_device_features | Replace the edge device features of a product
[**ReplacePurchaseOrdersOfProduct**](ProductApi.md#replacepurchaseordersofproduct) | **PATCH** /products/{product_id}/purchase_orders | Replace the purchase orders of a product
[**ReplaceQuotationsOfProduct**](ProductApi.md#replacequotationsofproduct) | **PATCH** /products/{product_id}/quotations | Replace the quotations of a product
[**ReplaceSoftwaresOfProduct**](ProductApi.md#replacesoftwaresofproduct) | **PATCH** /products/{product_id}/softwares | Replace the software of a product
[**ReplaceSparePartsOfProduct**](ProductApi.md#replacesparepartsofproduct) | **PATCH** /products/{product_id}/spare_parts | Replace the spare parts of a product
[**SetProductVariantConfiguration**](ProductApi.md#setproductvariantconfiguration) | **PATCH** /product_variants/{id}/configurations | update configuration of a product variant
[**UpdateProduct**](ProductApi.md#updateproduct) | **PATCH** /products/{id} | Update a product
[**UpdateProductFeature**](ProductApi.md#updateproductfeature) | **PATCH** /product_features/{id} | Update a product feature
[**UpdateProductOption**](ProductApi.md#updateproductoption) | **PATCH** /product_options/{id} | Update a product option
[**UpdateProductPicture**](ProductApi.md#updateproductpicture) | **PATCH** /products/{product_id}/pictures/{id} | Update a product picture
[**UpdateProductPictureLink**](ProductApi.md#updateproductpicturelink) | **PATCH** /products/{product_id}/pictures/links/{id} | Update a product picture link
[**UpdateProductVariant**](ProductApi.md#updateproductvariant) | **PATCH** /product_variants/{id} | Update a product variant
[**UpdateSpecificationsOfProduct**](ProductApi.md#updatespecificationsofproduct) | **PATCH** /products/{product_id}/specifications | Update specifications of a product
[**UploadProductPicture**](ProductApi.md#uploadproductpicture) | **POST** /products/{id}/pictures | Upload a product picture

<a name="addcategoriestoproduct"></a>
# **AddCategoriesToProduct**
> void AddCategoriesToProduct (CategoryIDs body, long? productId)

Add categories to a product

Add one or more categories to a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddCategoriesToProductExample
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

            var apiInstance = new ProductApi();
            var body = new CategoryIDs(); // CategoryIDs | Resources that shall be added
            var productId = 789;  // long? | Id of the product

            try
            {
                // Add categories to a product
                apiInstance.AddCategoriesToProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.AddCategoriesToProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoryIDs**](CategoryIDs.md)| Resources that shall be added | 
 **productId** | **long?**| Id of the product | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adddocumentstoproduct"></a>
# **AddDocumentsToProduct**
> void AddDocumentsToProduct (DocumentIDs body, long? productId)

Add documents to a product

Add one or more documents to a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDocumentsToProductExample
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

            var apiInstance = new ProductApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be added.
            var productId = 789;  // long? | Id of the product to which the documents will be added

            try
            {
                // Add documents to a product
                apiInstance.AddDocumentsToProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.AddDocumentsToProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be added. | 
 **productId** | **long?**| Id of the product to which the documents will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addedgedevicefeaturestoproduct"></a>
# **AddEdgeDeviceFeaturesToProduct**
> void AddEdgeDeviceFeaturesToProduct (EdgeDeviceFeatureIDs body, long? productId)

Add edge device features to a product

Add one or more edge device features to a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddEdgeDeviceFeaturesToProductExample
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

            var apiInstance = new ProductApi();
            var body = new EdgeDeviceFeatureIDs(); // EdgeDeviceFeatureIDs | Resources that shall be added.
            var productId = 789;  // long? | Id of the product to which the edge device features will be added

            try
            {
                // Add edge device features to a product
                apiInstance.AddEdgeDeviceFeaturesToProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.AddEdgeDeviceFeaturesToProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EdgeDeviceFeatureIDs**](EdgeDeviceFeatureIDs.md)| Resources that shall be added. | 
 **productId** | **long?**| Id of the product to which the edge device features will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addproductpicturelink"></a>
# **AddProductPictureLink**
> PictureResponse AddProductPictureLink (PictureLinkRequest body, long? id)

Add a link as product picture

Add an external resource as product picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddProductPictureLinkExample
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

            var apiInstance = new ProductApi();
            var body = new PictureLinkRequest(); // PictureLinkRequest | Picture link object to be created
            var id = 789;  // long? | Id of the product

            try
            {
                // Add a link as product picture
                PictureResponse result = apiInstance.AddProductPictureLink(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.AddProductPictureLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PictureLinkRequest**](PictureLinkRequest.md)| Picture link object to be created | 
 **id** | **long?**| Id of the product | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addpurchaseorderstoproduct"></a>
# **AddPurchaseOrdersToProduct**
> void AddPurchaseOrdersToProduct (PurchaseOrderIDs body, long? productId)

Add purchase orders to a product

Add one or more purchase orders to a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddPurchaseOrdersToProductExample
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

            var apiInstance = new ProductApi();
            var body = new PurchaseOrderIDs(); // PurchaseOrderIDs | Resources that shall be added.
            var productId = 789;  // long? | Id of the product to which the purchase orders will be added

            try
            {
                // Add purchase orders to a product
                apiInstance.AddPurchaseOrdersToProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.AddPurchaseOrdersToProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderIDs**](PurchaseOrderIDs.md)| Resources that shall be added. | 
 **productId** | **long?**| Id of the product to which the purchase orders will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addquotationstoproduct"></a>
# **AddQuotationsToProduct**
> void AddQuotationsToProduct (QuotationIDs body, long? productId)

Add quotations to a product

Add one or more quotations to a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddQuotationsToProductExample
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

            var apiInstance = new ProductApi();
            var body = new QuotationIDs(); // QuotationIDs | Resources that shall be added.
            var productId = 789;  // long? | Id of the product to which the quotations will be added

            try
            {
                // Add quotations to a product
                apiInstance.AddQuotationsToProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.AddQuotationsToProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuotationIDs**](QuotationIDs.md)| Resources that shall be added. | 
 **productId** | **long?**| Id of the product to which the quotations will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addsoftwarestoproduct"></a>
# **AddSoftwaresToProduct**
> void AddSoftwaresToProduct (SoftwareIDs body, long? productId)

Add software to a product

Add one or more software to a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddSoftwaresToProductExample
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

            var apiInstance = new ProductApi();
            var body = new SoftwareIDs(); // SoftwareIDs | Resources that shall be added.
            var productId = 789;  // long? | Id of the product to which the software will be added

            try
            {
                // Add software to a product
                apiInstance.AddSoftwaresToProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.AddSoftwaresToProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareIDs**](SoftwareIDs.md)| Resources that shall be added. | 
 **productId** | **long?**| Id of the product to which the software will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addsparepartstoproduct"></a>
# **AddSparePartsToProduct**
> void AddSparePartsToProduct (SparePartIDs body, long? productId)

Add spare parts to a product

Add one or more spare parts to a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddSparePartsToProductExample
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

            var apiInstance = new ProductApi();
            var body = new SparePartIDs(); // SparePartIDs | Resources that shall be added.
            var productId = 789;  // long? | Id of the product to which the spare part will be added

            try
            {
                // Add spare parts to a product
                apiInstance.AddSparePartsToProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.AddSparePartsToProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SparePartIDs**](SparePartIDs.md)| Resources that shall be added. | 
 **productId** | **long?**| Id of the product to which the spare part will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createproduct"></a>
# **CreateProduct**
> ProductResponse CreateProduct (ProductRequest body)

Create a new product

Products need a unique product_code and a manufacturer (company). Parameters supporting translation: ```name, description```. POST sets values in default language: en.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateProductExample
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

            var apiInstance = new ProductApi();
            var body = new ProductRequest(); // ProductRequest | Product object that needs to be created.

            try
            {
                // Create a new product
                ProductResponse result = apiInstance.CreateProduct(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.CreateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductRequest**](ProductRequest.md)| Product object that needs to be created. | 

### Return type

[**ProductResponse**](ProductResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createproductfeature"></a>
# **CreateProductFeature**
> ProductFeatureResponse CreateProductFeature (ProductFeatureRequest body)

Create a new product feature

Products must have a product (user needs product edit rights) and a unique feature_key (per product)

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateProductFeatureExample
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

            var apiInstance = new ProductApi();
            var body = new ProductFeatureRequest(); // ProductFeatureRequest | Product Feature object that needs to be created.

            try
            {
                // Create a new product feature
                ProductFeatureResponse result = apiInstance.CreateProductFeature(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.CreateProductFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductFeatureRequest**](ProductFeatureRequest.md)| Product Feature object that needs to be created. | 

### Return type

[**ProductFeatureResponse**](ProductFeatureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createproductoption"></a>
# **CreateProductOption**
> ProductOptionResponse CreateProductOption (ProductOptionRequest body)

Create a new product option

Products must have a product feature (user needs product feature - product edit rights) and a unique option_key (per product feature)

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateProductOptionExample
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

            var apiInstance = new ProductApi();
            var body = new ProductOptionRequest(); // ProductOptionRequest | Product option object that needs to be created.

            try
            {
                // Create a new product option
                ProductOptionResponse result = apiInstance.CreateProductOption(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.CreateProductOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductOptionRequest**](ProductOptionRequest.md)| Product option object that needs to be created. | 

### Return type

[**ProductOptionResponse**](ProductOptionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createproductvariant"></a>
# **CreateProductVariant**
> ProductVariantResponse CreateProductVariant (ProductVariantRequest body)

Create a new product variant

Product Variants must have a product (user needs product edit rights) and a unique variant_code (per product)

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateProductVariantExample
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

            var apiInstance = new ProductApi();
            var body = new ProductVariantRequest(); // ProductVariantRequest | Product variant object that needs to be created.

            try
            {
                // Create a new product variant
                ProductVariantResponse result = apiInstance.CreateProductVariant(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.CreateProductVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductVariantRequest**](ProductVariantRequest.md)| Product variant object that needs to be created. | 

### Return type

[**ProductVariantResponse**](ProductVariantResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecategoriesfromproduct"></a>
# **DeleteCategoriesFromProduct**
> void DeleteCategoriesFromProduct (CategoryIDs body, long? productId)

Remove categories from a product

Remove one or more categories from a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteCategoriesFromProductExample
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

            var apiInstance = new ProductApi();
            var body = new CategoryIDs(); // CategoryIDs | Resources that shall be removed.
            var productId = 789;  // long? | Id of the product from which the category will be removed

            try
            {
                // Remove categories from a product
                apiInstance.DeleteCategoriesFromProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.DeleteCategoriesFromProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoryIDs**](CategoryIDs.md)| Resources that shall be removed. | 
 **productId** | **long?**| Id of the product from which the category will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproduct"></a>
# **DeleteProduct**
> void DeleteProduct (long? id)

Delete a product

Delete a specific resource identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteProductExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product to delete

            try
            {
                // Delete a product
                apiInstance.DeleteProduct(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.DeleteProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproductfeature"></a>
# **DeleteProductFeature**
> void DeleteProductFeature (long? id)

Delete a product feature

Delete a specific resource identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteProductFeatureExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product feature to delete

            try
            {
                // Delete a product feature
                apiInstance.DeleteProductFeature(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.DeleteProductFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product feature to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproductoption"></a>
# **DeleteProductOption**
> void DeleteProductOption (long? id)

Delete a product option

Delete a specific resource identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteProductOptionExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product option to delete

            try
            {
                // Delete a product option
                apiInstance.DeleteProductOption(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.DeleteProductOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product option to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproductpicture"></a>
# **DeleteProductPicture**
> void DeleteProductPicture (long? productId, long? id)

Delete a product picture

Delete a product picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteProductPictureExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | Id of the product
            var id = 789;  // long? | Id of the product picture

            try
            {
                // Delete a product picture
                apiInstance.DeleteProductPicture(productId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.DeleteProductPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| Id of the product | 
 **id** | **long?**| Id of the product picture | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproductvariant"></a>
# **DeleteProductVariant**
> void DeleteProductVariant (long? id)

Delete a product variant

Delete a specific resource identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteProductVariantExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product variant to delete

            try
            {
                // Delete a product variant
                apiInstance.DeleteProductVariant(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.DeleteProductVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product variant to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloadproductpicture"></a>
# **DownloadProductPicture**
> void DownloadProductPicture (long? productId, long? id)

Download a product picture

Download a product picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DownloadProductPictureExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | Id of the product
            var id = 789;  // long? | Id of the product picture

            try
            {
                // Download a product picture
                apiInstance.DownloadProductPicture(productId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.DownloadProductPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| Id of the product | 
 **id** | **long?**| Id of the product picture | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetproductoptions"></a>
# **GetAssetProductOptions**
> Products GetAssetProductOptions (long? assetId, int? page = null, int? perPage = null, string include = null, string productCode = null, string name = null, string manufacturerId = null, string statusId = null, string categoryId = null, string parentId = null, string tenantId = null, string orderBy = null)

Get all possible products of the specified assets

Returns a list of all possible products for the specified asset. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, parent, manufacturer, pictures, categories, categories.parent```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetProductOptionsExample
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

            var apiInstance = new ProductApi();
            var assetId = 789;  // long? | Id of the specified asset
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var productCode = productCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all possible products of the specified assets
                Products result = apiInstance.GetAssetProductOptions(assetId, page, perPage, include, productCode, name, manufacturerId, statusId, categoryId, parentId, tenantId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetAssetProductOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **long?**| Id of the specified asset | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **productCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**Products**](Products.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcategoriesofproduct"></a>
# **GetCategoriesOfProduct**
> ProductCategoriesResponse GetCategoriesOfProduct (long? productId, int? page = null, int? perPage = null, string include = null, string name = null, string code = null, string parentId = null, string tenantId = null, string orderBy = null, string acceptLanguage = null)

Get all categories of a product

Get all categories for the specific product identified by the id in the URL. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```tenant, parent```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCategoriesOfProductExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all categories of a product
                ProductCategoriesResponse result = apiInstance.GetCategoriesOfProduct(productId, page, perPage, include, name, code, parentId, tenantId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetCategoriesOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**ProductCategoriesResponse**](ProductCategoriesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcategoriesoptionsofproduct"></a>
# **GetCategoriesOptionsOfProduct**
> ProductCategoriesResponse GetCategoriesOptionsOfProduct (long? productId, int? page = null, int? perPage = null, string include = null, string name = null, string code = null, string parentId = null, string tenantId = null, string orderBy = null, string acceptLanguage = null)

Get all categories of one product

Returns a list of all possible categories for the specific product available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```tenant, parent``` \"

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetCategoriesOptionsOfProductExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all categories of one product
                ProductCategoriesResponse result = apiInstance.GetCategoriesOptionsOfProduct(productId, page, perPage, include, name, code, parentId, tenantId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetCategoriesOptionsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**ProductCategoriesResponse**](ProductCategoriesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdocumentsofproduct"></a>
# **GetDocumentsOfProduct**
> DocumentsResponse GetDocumentsOfProduct (long? productId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string orderBy = null, string acceptLanguage = null)

Get all documents of a product

Returns a list of documents assigned to the specified product. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, classification, categories, categories.parent, categories.standards, attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfProductExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var documentVersion = documentVersion_example;  // string | Filter accepts `*` as wildcard (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var classificationId = classificationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var validFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntil = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD or YYYY-MM or YYYY (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all documents of a product
                DocumentsResponse result = apiInstance.GetDocumentsOfProduct(productId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetDocumentsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **documentVersion** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **classificationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **validFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntil** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validAt** | **DateTime?**| Expected date format is YYYY-MM-DD or YYYY-MM or YYYY | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**DocumentsResponse**](DocumentsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdocumentsofproductvariant"></a>
# **GetDocumentsOfProductVariant**
> DocumentsResponse GetDocumentsOfProductVariant (long? productVariantId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string orderBy = null, string acceptLanguage = null)

Get all documents of a product variant

Returns a list of documents assigned to the specified product variant. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, classification, categories, categories.parent, categories.standards, attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfProductVariantExample
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

            var apiInstance = new ProductApi();
            var productVariantId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var documentVersion = documentVersion_example;  // string | Filter accepts `*` as wildcard (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var classificationId = classificationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var validFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validUntil = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var validAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD or YYYY-MM or YYYY (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all documents of a product variant
                DocumentsResponse result = apiInstance.GetDocumentsOfProductVariant(productVariantId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetDocumentsOfProductVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productVariantId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **documentVersion** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **classificationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **validFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validUntil** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **validAt** | **DateTime?**| Expected date format is YYYY-MM-DD or YYYY-MM or YYYY | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**DocumentsResponse**](DocumentsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getedgedevicefeaturesofproduct"></a>
# **GetEdgeDeviceFeaturesOfProduct**
> EdgeDeviceFeaturesResponse GetEdgeDeviceFeaturesOfProduct (long? productId, int? page = null, int? perPage = null, string name = null, string code = null, string orderBy = null, string acceptLanguage = null)

Get all edge device features of a product

Returns a list of edge device features assigned to the specified product. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetEdgeDeviceFeaturesOfProductExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all edge device features of a product
                EdgeDeviceFeaturesResponse result = apiInstance.GetEdgeDeviceFeaturesOfProduct(productId, page, perPage, name, code, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetEdgeDeviceFeaturesOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**EdgeDeviceFeaturesResponse**](EdgeDeviceFeaturesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductbyid"></a>
# **GetProductById**
> ProductResponse GetProductById (long? id, string include = null, string acceptLanguage = null)

Get a single product

Get a specific product identified by the id in the URL. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, parent, manufacturer, pictures, specifications, specifications[key1,key2], categories, categories.parent```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductByIdExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a single product
                ProductResponse result = apiInstance.GetProductById(id, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**ProductResponse**](ProductResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductfeaturebyid"></a>
# **GetProductFeatureById**
> ProductFeatureResponse GetProductFeatureById (long? id)

Get a single product feature

Get a specific product feature identified by the id in the URL. 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductFeatureByIdExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product feature to fetch

            try
            {
                // Get a single product feature
                ProductFeatureResponse result = apiInstance.GetProductFeatureById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductFeatureById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product feature to fetch | 

### Return type

[**ProductFeatureResponse**](ProductFeatureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductfeatures"></a>
# **GetProductFeatures**
> ProductFeaturesResponse GetProductFeatures (int? page = null, int? perPage = null, string productId = null, string featureKey = null, string orderBy = null)

Get a range of product features

 Returns a list of all product features that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array. 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductFeaturesExample
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

            var apiInstance = new ProductApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var productId = productId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var featureKey = featureKey_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of product features
                ProductFeaturesResponse result = apiInstance.GetProductFeatures(page, perPage, productId, featureKey, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductFeatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **productId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **featureKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ProductFeaturesResponse**](ProductFeaturesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductidstatus"></a>
# **GetProductIdStatus**
> ProductStatusResponse GetProductIdStatus (long? productId, string acceptLanguage = null)

Get the status of a specific product

Returns the status of the product. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductIdStatusExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | Id of the specified product
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the status of a specific product
                ProductStatusResponse result = apiInstance.GetProductIdStatus(productId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductIdStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| Id of the specified product | 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**ProductStatusResponse**](ProductStatusResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductoptionbyid"></a>
# **GetProductOptionById**
> ProductOptionResponse GetProductOptionById (long? id)

Get a single product option

Get a specific product option identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductOptionByIdExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product option to fetch

            try
            {
                // Get a single product option
                ProductOptionResponse result = apiInstance.GetProductOptionById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductOptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product option to fetch | 

### Return type

[**ProductOptionResponse**](ProductOptionResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductoptions"></a>
# **GetProductOptions**
> ProductOptionsResponse GetProductOptions (int? page = null, int? perPage = null, string productFeatureId = null, string optionKey = null, string orderBy = null)

Get a range of product options

Returns a list of all product options that are available in your scope. You can apply the query parameters listed below to get a filtered list.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductOptionsExample
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

            var apiInstance = new ProductApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var productFeatureId = productFeatureId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var optionKey = optionKey_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of product options
                ProductOptionsResponse result = apiInstance.GetProductOptions(page, perPage, productFeatureId, optionKey, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **productFeatureId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **optionKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ProductOptionsResponse**](ProductOptionsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductpicture"></a>
# **GetProductPicture**
> PictureResponse GetProductPicture (long? productId, long? id)

Get a product picture

Get a single picture of a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductPictureExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | Id of the product
            var id = 789;  // long? | Id of the product picture

            try
            {
                // Get a product picture
                PictureResponse result = apiInstance.GetProductPicture(productId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| Id of the product | 
 **id** | **long?**| Id of the product picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductpictures"></a>
# **GetProductPictures**
> PicturesResponse GetProductPictures (long? id, int? width = null, int? widthFrom = null, int? widthTo = null, int? height = null, int? heightFrom = null, int? heightTo = null, string orderBy = null)

Get product pictures

Get all product pictures of a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductPicturesExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product
            var width = 56;  // int? | filter by width (optional) 
            var widthFrom = 56;  // int? | filter by width_from (optional) 
            var widthTo = 56;  // int? | filter by width_to (optional) 
            var height = 56;  // int? | filter by height (optional) 
            var heightFrom = 56;  // int? | filter by height_from (optional) 
            var heightTo = 56;  // int? | filter by height_to (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get product pictures
                PicturesResponse result = apiInstance.GetProductPictures(id, width, widthFrom, widthTo, height, heightFrom, heightTo, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductPictures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product | 
 **width** | **int?**| filter by width | [optional] 
 **widthFrom** | **int?**| filter by width_from | [optional] 
 **widthTo** | **int?**| filter by width_to | [optional] 
 **height** | **int?**| filter by height | [optional] 
 **heightFrom** | **int?**| filter by height_from | [optional] 
 **heightTo** | **int?**| filter by height_to | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**PicturesResponse**](PicturesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductstatusesoptions"></a>
# **GetProductStatusesOptions**
> ProductStatuses GetProductStatusesOptions (long? productId, int? page = null, int? perPage = null, string name = null, string tenantId = null, string code = null, string orderBy = null, string acceptLanguage = null)

Get all possible statuses for the specified product

Returns a list of all possible product statuses for the specified product. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductStatusesOptionsExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | Id of the specified product
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all possible statuses for the specified product
                ProductStatuses result = apiInstance.GetProductStatusesOptions(productId, page, perPage, name, tenantId, code, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductStatusesOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| Id of the specified product | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**ProductStatuses**](ProductStatuses.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductvariantbyid"></a>
# **GetProductVariantById**
> ProductVariantResponse GetProductVariantById (long? id)

Get a single product variant

Get a specific product variant identified by the id in the URL. 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductVariantByIdExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product variant to fetch

            try
            {
                // Get a single product variant
                ProductVariantResponse result = apiInstance.GetProductVariantById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductVariantById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product variant to fetch | 

### Return type

[**ProductVariantResponse**](ProductVariantResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductvariantconfigurations"></a>
# **GetProductVariantConfigurations**
> ProductVariantConfigurationResponse GetProductVariantConfigurations (long? id, string orderBy = null)

get configuration of product variant

get configuration of a product variant

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductVariantConfigurationsExample
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

            var apiInstance = new ProductApi();
            var id = 789;  // long? | Id of the product variant
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // get configuration of product variant
                ProductVariantConfigurationResponse result = apiInstance.GetProductVariantConfigurations(id, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductVariantConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the product variant | 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ProductVariantConfigurationResponse**](ProductVariantConfigurationResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductvariants"></a>
# **GetProductVariants**
> ProductVariantsResponse GetProductVariants (int? page = null, int? perPage = null, string productId = null, string variantCode = null, string orderBy = null)

Get a range of product variants

 Returns a list of all product variants that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array. 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductVariantsExample
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

            var apiInstance = new ProductApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var productId = productId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var variantCode = variantCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of product variants
                ProductVariantsResponse result = apiInstance.GetProductVariants(page, perPage, productId, variantCode, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductVariants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **productId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **variantCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ProductVariantsResponse**](ProductVariantsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproducts"></a>
# **GetProducts**
> ProductsResponse GetProducts (int? page = null, int? perPage = null, string include = null, string productCode = null, string name = null, string manufacturerId = null, string statusId = null, string categoryId = null, string parentId = null, string tenantId = null, string specificationsKey = null, string specificationsValue = null, string orderBy = null, string acceptLanguage = null)

Get a range of products

Returns a list of all products that are available in your scope. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, parent, manufacturer, pictures, specifications, specifications[key1,key2], categories, categories.parent``` \"

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductsExample
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

            var apiInstance = new ProductApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var productCode = productCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of products
                ProductsResponse result = apiInstance.GetProducts(page, perPage, include, productCode, name, manufacturerId, statusId, categoryId, parentId, tenantId, specificationsKey, specificationsValue, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **productCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**ProductsResponse**](ProductsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductsofcompany"></a>
# **GetProductsOfCompany**
> ProductsResponse GetProductsOfCompany (long? companyId, int? page = null, int? perPage = null, string include = null, string productCode = null, string name = null, string statusId = null, string categoryId = null, string parentId = null, string tenantId = null, string orderBy = null)

Get all products of a company

Receive a list of products of a specific company, identified by the id in the URL. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, parent, manufacturer, pictures, categories, categories.parent```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetProductsOfCompanyExample
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

            var apiInstance = new ProductApi();
            var companyId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var productCode = productCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var categoryId = categoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all products of a company
                ProductsResponse result = apiInstance.GetProductsOfCompany(companyId, page, perPage, include, productCode, name, statusId, categoryId, parentId, tenantId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetProductsOfCompany: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **productCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **categoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**ProductsResponse**](ProductsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpurchaseordersofproduct"></a>
# **GetPurchaseOrdersOfProduct**
> PurchaseOrdersResponse GetPurchaseOrdersOfProduct (long? productId, int? page = null, int? perPage = null, string name = null, string number = null, string statusId = null, string date = null, string dateFrom = null, string dateTo = null, string senderId = null, string receiverId = null, string quotationId = null, string customerNumber = null, string orderBy = null)

Get all purchase orders of one product

Returns a list of all purchase orders that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetPurchaseOrdersOfProductExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var date = date_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateFrom = dateFrom_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateTo = dateTo_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var senderId = senderId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var receiverId = receiverId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var quotationId = quotationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var customerNumber = customerNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all purchase orders of one product
                PurchaseOrdersResponse result = apiInstance.GetPurchaseOrdersOfProduct(productId, page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, quotationId, customerNumber, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetPurchaseOrdersOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **date** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateFrom** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateTo** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **senderId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **receiverId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **quotationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **customerNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**PurchaseOrdersResponse**](PurchaseOrdersResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getquotationsofproduct"></a>
# **GetQuotationsOfProduct**
> QuotationsResponse GetQuotationsOfProduct (long? productId, int? page = null, int? perPage = null, string name = null, string number = null, string statusId = null, string date = null, string dateFrom = null, string dateTo = null, string senderId = null, string receiverId = null, string requestForQuotationId = null, string orderBy = null)

Get all quotations of one product

Returns a list of all quotations that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetQuotationsOfProductExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var number = number_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var date = date_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateFrom = dateFrom_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var dateTo = dateTo_example;  // string | Expected date format is YYYY-MM-DD (optional) 
            var senderId = senderId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var receiverId = receiverId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var requestForQuotationId = requestForQuotationId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all quotations of one product
                QuotationsResponse result = apiInstance.GetQuotationsOfProduct(productId, page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, requestForQuotationId, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetQuotationsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **number** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **date** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateFrom** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **dateTo** | **string**| Expected date format is YYYY-MM-DD | [optional] 
 **senderId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **receiverId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **requestForQuotationId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**QuotationsResponse**](QuotationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsoftwaresofproduct"></a>
# **GetSoftwaresOfProduct**
> SoftwaresResponse GetSoftwaresOfProduct (long? productId, int? page = null, int? perPage = null, string include = null, string orderBy = null, string acceptLanguage = null)

Get a range of software of one product

Returns a list of software. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```software_attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSoftwaresOfProductExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `version_number`, `name`, `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get a range of software of one product
                SoftwaresResponse result = apiInstance.GetSoftwaresOfProduct(productId, page, perPage, include, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetSoftwaresOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;version_number&#x60;, &#x60;name&#x60;, &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**SoftwaresResponse**](SoftwaresResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsparepartsofproduct"></a>
# **GetSparePartsOfProduct**
> SparePartsResponse GetSparePartsOfProduct (long? productId, int? page = null, int? perPage = null, string include = null, string name = null, string orderCode = null, string statusId = null, string typeId = null, string tenantId = null, string orderBy = null, string acceptLanguage = null)

Get all spare parts of a product

Returns a list of spare pasrts assigned to the specified product. You can apply the query parameters listed below to get a filtered list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSparePartsOfProductExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var orderCode = orderCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all spare parts of a product
                SparePartsResponse result = apiInstance.GetSparePartsOfProduct(productId, page, perPage, include, name, orderCode, statusId, typeId, tenantId, orderBy, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetSparePartsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **orderCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**SparePartsResponse**](SparePartsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofproduct"></a>
# **GetSpecificationsOfProduct**
> SpecificationsResponse GetSpecificationsOfProduct (long? productId, string key = null)

Get specifications of a product

Returns the specification of an object. If no specifications are defined, this is just an empty object.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfProductExample
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

            var apiInstance = new ProductApi();
            var productId = 789;  // long? | Id of the specified product
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 

            try
            {
                // Get specifications of a product
                SpecificationsResponse result = apiInstance.GetSpecificationsOfProduct(productId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.GetSpecificationsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| Id of the specified product | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 

### Return type

[**SpecificationsResponse**](SpecificationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removedocumentsfromproduct"></a>
# **RemoveDocumentsFromProduct**
> void RemoveDocumentsFromProduct (DocumentIDs body, long? productId)

Remove documents from a product

Remove one or more documents from a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDocumentsFromProductExample
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

            var apiInstance = new ProductApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be removed.
            var productId = 789;  // long? | Id of the product from which the documents will be removed

            try
            {
                // Remove documents from a product
                apiInstance.RemoveDocumentsFromProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.RemoveDocumentsFromProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be removed. | 
 **productId** | **long?**| Id of the product from which the documents will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeedgedevicefeaturesfromproduct"></a>
# **RemoveEdgeDeviceFeaturesFromProduct**
> void RemoveEdgeDeviceFeaturesFromProduct (EdgeDeviceFeatureIDs body, long? productId)

Remove edge device features from a product

Remove one or more edge device features from a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveEdgeDeviceFeaturesFromProductExample
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

            var apiInstance = new ProductApi();
            var body = new EdgeDeviceFeatureIDs(); // EdgeDeviceFeatureIDs | Resources that shall be removed.
            var productId = 789;  // long? | Id of the product from which the edge device features will be removed

            try
            {
                // Remove edge device features from a product
                apiInstance.RemoveEdgeDeviceFeaturesFromProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.RemoveEdgeDeviceFeaturesFromProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EdgeDeviceFeatureIDs**](EdgeDeviceFeatureIDs.md)| Resources that shall be removed. | 
 **productId** | **long?**| Id of the product from which the edge device features will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removepurchaseordersfromproduct"></a>
# **RemovePurchaseOrdersFromProduct**
> void RemovePurchaseOrdersFromProduct (PurchaseOrderIDs body, long? productId)

Remove purchase orders from a product

Remove one or more purchase orders from a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemovePurchaseOrdersFromProductExample
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

            var apiInstance = new ProductApi();
            var body = new PurchaseOrderIDs(); // PurchaseOrderIDs | Resources that shall be removed.
            var productId = 789;  // long? | Id of the product from which the purchase orders will be removed

            try
            {
                // Remove purchase orders from a product
                apiInstance.RemovePurchaseOrdersFromProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.RemovePurchaseOrdersFromProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderIDs**](PurchaseOrderIDs.md)| Resources that shall be removed. | 
 **productId** | **long?**| Id of the product from which the purchase orders will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removequotationsfromproduct"></a>
# **RemoveQuotationsFromProduct**
> void RemoveQuotationsFromProduct (QuotationIDs body, long? productId)

Remove quotations from a product

Remove one or more quotations from a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveQuotationsFromProductExample
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

            var apiInstance = new ProductApi();
            var body = new QuotationIDs(); // QuotationIDs | Resources that shall be removed.
            var productId = 789;  // long? | Id of the product from which the quotations will be removed

            try
            {
                // Remove quotations from a product
                apiInstance.RemoveQuotationsFromProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.RemoveQuotationsFromProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuotationIDs**](QuotationIDs.md)| Resources that shall be removed. | 
 **productId** | **long?**| Id of the product from which the quotations will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removesoftwaresofproduct"></a>
# **RemoveSoftwaresOfProduct**
> void RemoveSoftwaresOfProduct (SoftwareIDs body, long? productId)

Remove software from a product

Remove one or more software from a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSoftwaresOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new SoftwareIDs(); // SoftwareIDs | Resources that shall be removed.
            var productId = 789;  // long? | Id of the product from which the software will be removed

            try
            {
                // Remove software from a product
                apiInstance.RemoveSoftwaresOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.RemoveSoftwaresOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareIDs**](SoftwareIDs.md)| Resources that shall be removed. | 
 **productId** | **long?**| Id of the product from which the software will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removesparepartsfromproduct"></a>
# **RemoveSparePartsFromProduct**
> void RemoveSparePartsFromProduct (SparePartIDs body, long? productId)

Remove spare parts from a product

Remove one or more documents from a product.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSparePartsFromProductExample
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

            var apiInstance = new ProductApi();
            var body = new SparePartIDs(); // SparePartIDs | Resources that shall be removed.
            var productId = 789;  // long? | Id of the product from which the spare parts will be removed

            try
            {
                // Remove spare parts from a product
                apiInstance.RemoveSparePartsFromProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.RemoveSparePartsFromProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SparePartIDs**](SparePartIDs.md)| Resources that shall be removed. | 
 **productId** | **long?**| Id of the product from which the spare parts will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromproduct"></a>
# **RemoveSpecificationsFromProduct**
> void RemoveSpecificationsFromProduct (List<string> body, long? productId)

Delete specifications of a product

The specification keys in the body will be removed. Multiple specification keys can be sent in the same request. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromProductExample
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

            var apiInstance = new ProductApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var productId = 789;  // long? | Id of the specified product

            try
            {
                // Delete specifications of a product
                apiInstance.RemoveSpecificationsFromProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.RemoveSpecificationsFromProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **productId** | **long?**| Id of the specified product | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofproduct"></a>
# **RenameSpecificationsOfProduct**
> void RenameSpecificationsOfProduct (SpecificationsRename body, long? productId)

rename a key in the specification.

Rename a key of the specification object of a product. Instead of delete and recreate again, this is to preserve the key´s value history. Also the new keys can only consist of a-z A-Z 0-9 . - _ all uppercase A-Z are converted to lower-case a-z. Only one key can be changed per request

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var productId = 789;  // long? | Id of the specified product

            try
            {
                // rename a key in the specification.
                apiInstance.RenameSpecificationsOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.RenameSpecificationsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **productId** | **long?**| Id of the specified product | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacecategoriesofproduct"></a>
# **ReplaceCategoriesOfProduct**
> void ReplaceCategoriesOfProduct (CategoryIDs body, long? productId)

Replace all categories of a product

Replaces all categories belonging to a product. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceCategoriesOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new CategoryIDs(); // CategoryIDs | Resources that shall be added
            var productId = 789;  // long? | Id of the product

            try
            {
                // Replace all categories of a product
                apiInstance.ReplaceCategoriesOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ReplaceCategoriesOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoryIDs**](CategoryIDs.md)| Resources that shall be added | 
 **productId** | **long?**| Id of the product | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedocumentsofproduct"></a>
# **ReplaceDocumentsOfProduct**
> void ReplaceDocumentsOfProduct (DocumentIDs body, long? productId)

Replace the documents of a product

Replaces all documents belonging to a product. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDocumentsOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be replaced
            var productId = 789;  // long? | Id of the product of which the documents will be replaced

            try
            {
                // Replace the documents of a product
                apiInstance.ReplaceDocumentsOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ReplaceDocumentsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be replaced | 
 **productId** | **long?**| Id of the product of which the documents will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceedgedevicefeaturesofproduct"></a>
# **ReplaceEdgeDeviceFeaturesOfProduct**
> void ReplaceEdgeDeviceFeaturesOfProduct (EdgeDeviceFeatureIDs body, long? productId)

Replace the edge device features of a product

Replaces all edge device features belonging to a product. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceEdgeDeviceFeaturesOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new EdgeDeviceFeatureIDs(); // EdgeDeviceFeatureIDs | Resources that shall be replaced
            var productId = 789;  // long? | Id of the product of which the edge device features will be replaced

            try
            {
                // Replace the edge device features of a product
                apiInstance.ReplaceEdgeDeviceFeaturesOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ReplaceEdgeDeviceFeaturesOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EdgeDeviceFeatureIDs**](EdgeDeviceFeatureIDs.md)| Resources that shall be replaced | 
 **productId** | **long?**| Id of the product of which the edge device features will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacepurchaseordersofproduct"></a>
# **ReplacePurchaseOrdersOfProduct**
> void ReplacePurchaseOrdersOfProduct (PurchaseOrderIDs body, long? productId)

Replace the purchase orders of a product

Replaces all purchase orders belonging to a product. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplacePurchaseOrdersOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new PurchaseOrderIDs(); // PurchaseOrderIDs | Resources that shall be replaced
            var productId = 789;  // long? | Id of the product of which the purchase orders will be replaced

            try
            {
                // Replace the purchase orders of a product
                apiInstance.ReplacePurchaseOrdersOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ReplacePurchaseOrdersOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PurchaseOrderIDs**](PurchaseOrderIDs.md)| Resources that shall be replaced | 
 **productId** | **long?**| Id of the product of which the purchase orders will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacequotationsofproduct"></a>
# **ReplaceQuotationsOfProduct**
> void ReplaceQuotationsOfProduct (QuotationIDs body, long? productId)

Replace the quotations of a product

Replaces all quotations belonging to a product. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceQuotationsOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new QuotationIDs(); // QuotationIDs | Resources that shall be replaced
            var productId = 789;  // long? | Id of the product of which the quotations will be replaced

            try
            {
                // Replace the quotations of a product
                apiInstance.ReplaceQuotationsOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ReplaceQuotationsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**QuotationIDs**](QuotationIDs.md)| Resources that shall be replaced | 
 **productId** | **long?**| Id of the product of which the quotations will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacesoftwaresofproduct"></a>
# **ReplaceSoftwaresOfProduct**
> void ReplaceSoftwaresOfProduct (SoftwareIDs body, long? productId)

Replace the software of a product

Replaces all software belonging to a product. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceSoftwaresOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new SoftwareIDs(); // SoftwareIDs | Resources that shall be replaced
            var productId = 789;  // long? | Id of the product of which the software will be replaced

            try
            {
                // Replace the software of a product
                apiInstance.ReplaceSoftwaresOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ReplaceSoftwaresOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SoftwareIDs**](SoftwareIDs.md)| Resources that shall be replaced | 
 **productId** | **long?**| Id of the product of which the software will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacesparepartsofproduct"></a>
# **ReplaceSparePartsOfProduct**
> void ReplaceSparePartsOfProduct (SparePartIDs body, long? productId)

Replace the spare parts of a product

Replaces all spare parts belonging to a product. You can send a list of resources that will replace all previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceSparePartsOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new SparePartIDs(); // SparePartIDs | Resources that shall be replaced
            var productId = 789;  // long? | Id of the product of which the spare parts will be replaced

            try
            {
                // Replace the spare parts of a product
                apiInstance.ReplaceSparePartsOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ReplaceSparePartsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SparePartIDs**](SparePartIDs.md)| Resources that shall be replaced | 
 **productId** | **long?**| Id of the product of which the spare parts will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setproductvariantconfiguration"></a>
# **SetProductVariantConfiguration**
> void SetProductVariantConfiguration (ProductVariantConfigurationRequest body, long? id)

update configuration of a product variant

set / update configuration of a product variant. The configuration is defined by the product features and product options. An empty array can be sent to remove the configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class SetProductVariantConfigurationExample
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

            var apiInstance = new ProductApi();
            var body = new ProductVariantConfigurationRequest(); // ProductVariantConfigurationRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the product variant to update

            try
            {
                // update configuration of a product variant
                apiInstance.SetProductVariantConfiguration(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.SetProductVariantConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductVariantConfigurationRequest**](ProductVariantConfigurationRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the product variant to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproduct"></a>
# **UpdateProduct**
> void UpdateProduct (ProductRequest body, long? id)

Update a product

Update accessible parameters of the requested resource. Parameters supporting translation: ```name, description```. To add a translation set Content-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateProductExample
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

            var apiInstance = new ProductApi();
            var body = new ProductRequest(); // ProductRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the product to update

            try
            {
                // Update a product
                apiInstance.UpdateProduct(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductRequest**](ProductRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the product to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductfeature"></a>
# **UpdateProductFeature**
> void UpdateProductFeature (ProductFeatureRequest body, long? id, string contentLanguage = null)

Update a product feature

Update accessible parameters of the requested resource.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateProductFeatureExample
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

            var apiInstance = new ProductApi();
            var body = new ProductFeatureRequest(); // ProductFeatureRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the product feature to update
            var contentLanguage = contentLanguage_example;  // string | language of the content (optional) 

            try
            {
                // Update a product feature
                apiInstance.UpdateProductFeature(body, id, contentLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateProductFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductFeatureRequest**](ProductFeatureRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the product feature to update | 
 **contentLanguage** | **string**| language of the content | [optional] 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductoption"></a>
# **UpdateProductOption**
> void UpdateProductOption (ProductOptionRequest body, long? id)

Update a product option

Update accessible parameters of the requested resource.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateProductOptionExample
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

            var apiInstance = new ProductApi();
            var body = new ProductOptionRequest(); // ProductOptionRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the product option to update

            try
            {
                // Update a product option
                apiInstance.UpdateProductOption(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateProductOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductOptionRequest**](ProductOptionRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the product option to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductpicture"></a>
# **UpdateProductPicture**
> PictureResponse UpdateProductPicture (byte[] image, long? productId, long? id)

Update a product picture

Upload a new product picture. Checks the file-storage quota. Allowed content-types are - image/gif - image/jpg - image/jpeg - image/png

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateProductPictureExample
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

            var apiInstance = new ProductApi();
            var image = image_example;  // byte[] | 
            var productId = 789;  // long? | Id of the product
            var id = 789;  // long? | Id of the product picture

            try
            {
                // Update a product picture
                PictureResponse result = apiInstance.UpdateProductPicture(image, productId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateProductPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **productId** | **long?**| Id of the product | 
 **id** | **long?**| Id of the product picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductpicturelink"></a>
# **UpdateProductPictureLink**
> PictureResponse UpdateProductPictureLink (PictureLinkRequest body, long? productId, long? id)

Update a product picture link

Update a product picture link.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateProductPictureLinkExample
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

            var apiInstance = new ProductApi();
            var body = new PictureLinkRequest(); // PictureLinkRequest | Picture link object to be updated
            var productId = 789;  // long? | Id of the product
            var id = 789;  // long? | Id of the product picture

            try
            {
                // Update a product picture link
                PictureResponse result = apiInstance.UpdateProductPictureLink(body, productId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateProductPictureLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PictureLinkRequest**](PictureLinkRequest.md)| Picture link object to be updated | 
 **productId** | **long?**| Id of the product | 
 **id** | **long?**| Id of the product picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductvariant"></a>
# **UpdateProductVariant**
> void UpdateProductVariant (ProductVariantRequest body, long? id)

Update a product variant

Update accessible parameters of the requested resource.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateProductVariantExample
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

            var apiInstance = new ProductApi();
            var body = new ProductVariantRequest(); // ProductVariantRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the product variant to update

            try
            {
                // Update a product variant
                apiInstance.UpdateProductVariant(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateProductVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductVariantRequest**](ProductVariantRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the product variant to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofproduct"></a>
# **UpdateSpecificationsOfProduct**
> void UpdateSpecificationsOfProduct (Dictionary<string, SpecificationRequest> body, long? productId)

Update specifications of a product

Update the specification object of a product. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. If a key occurs more than once in the request body, the last key-value will be saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfProductExample
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

            var apiInstance = new ProductApi();
            var body = new Dictionary<string, SpecificationRequest>(); // Dictionary<string, SpecificationRequest> | The specifications objects to patch.
            var productId = 789;  // long? | Id of the specified product

            try
            {
                // Update specifications of a product
                apiInstance.UpdateSpecificationsOfProduct(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.UpdateSpecificationsOfProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationRequest&gt;**](Dictionary&lt;string, SpecificationRequest&gt;.md)| The specifications objects to patch. | 
 **productId** | **long?**| Id of the specified product | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadproductpicture"></a>
# **UploadProductPicture**
> PictureResponse UploadProductPicture (byte[] image, long? id)

Upload a product picture

Upload a new product picture. Checks the file-storage quota. Allowed content-types are - image/gif - image/jpg - image/jpeg - image/png

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UploadProductPictureExample
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

            var apiInstance = new ProductApi();
            var image = image_example;  // byte[] | 
            var id = 789;  // long? | Id of the product

            try
            {
                // Upload a product picture
                PictureResponse result = apiInstance.UploadProductPicture(image, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.UploadProductPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **id** | **long?**| Id of the product | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
