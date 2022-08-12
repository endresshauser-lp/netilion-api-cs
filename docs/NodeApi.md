# Netilion.Api.Api.NodeApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAssetsToNode**](NodeApi.md#addassetstonode) | **POST** /nodes/{node_id}/assets | Add assets to a node
[**AddDocumentsToNode**](NodeApi.md#adddocumentstonode) | **POST** /nodes/{node_id}/documents | Add documents to a node
[**AddInstrumentationsToNode**](NodeApi.md#addinstrumentationstonode) | **POST** /nodes/{node_id}/instrumentations | Add instrumentations to a node
[**AddNodePictureLink**](NodeApi.md#addnodepicturelink) | **POST** /nodes/{id}/pictures/links | Add a link as node picture
[**AddRecipesToNode**](NodeApi.md#addrecipestonode) | **POST** /nodes/{node_id}/recipes | Add recipes to a node
[**AddSystemsToNode**](NodeApi.md#addsystemstonode) | **POST** /nodes/{node_id}/systems | Add systems to a node
[**CreateNodes**](NodeApi.md#createnodes) | **POST** /nodes | Create a new node
[**DeleteNode**](NodeApi.md#deletenode) | **DELETE** /nodes/{id} | Delete a node
[**DeleteNodePicture**](NodeApi.md#deletenodepicture) | **DELETE** /nodes/{node_id}/pictures/{id} | Delete an node picture
[**DownloadNodePicture**](NodeApi.md#downloadnodepicture) | **GET** /nodes/{node_id}/pictures/{id}/download | Download an node picture
[**GetAssetsOfNode**](NodeApi.md#getassetsofnode) | **GET** /nodes/{node_id}/assets | Get all assets of one node
[**GetDocumentsOfNode**](NodeApi.md#getdocumentsofnode) | **GET** /nodes/{node_id}/documents | Get all documents of a node
[**GetInstrumentationsOfNode**](NodeApi.md#getinstrumentationsofnode) | **GET** /nodes/{node_id}/instrumentations | Get all instrumentations of one node
[**GetNodeIdType**](NodeApi.md#getnodeidtype) | **GET** /nodes/{node_id}/type | Get the type of the specific node
[**GetNodePicture**](NodeApi.md#getnodepicture) | **GET** /nodes/{node_id}/pictures/{id} | Get an node picture
[**GetNodePictures**](NodeApi.md#getnodepictures) | **GET** /nodes/{id}/pictures | Get node pictures
[**GetNodeTypesOptions**](NodeApi.md#getnodetypesoptions) | **GET** /nodes/{node_id}/type-options | Get all possible types of the specified node
[**GetNodes**](NodeApi.md#getnodes) | **GET** /nodes | Get a range of nodes
[**GetNodesById**](NodeApi.md#getnodesbyid) | **GET** /nodes/{id} | Get a single node
[**GetRecipesOfNode**](NodeApi.md#getrecipesofnode) | **GET** /nodes/{node_id}/recipes | Get all recipes of one node
[**GetSpecificationKeysOfNodes**](NodeApi.md#getspecificationkeysofnodes) | **GET** /node/specification_keys | Get existing asset specification keys
[**GetSpecificationsOfNode**](NodeApi.md#getspecificationsofnode) | **GET** /nodes/{node_id}/specifications | Get specifications of a node
[**GetSystemsOfNode**](NodeApi.md#getsystemsofnode) | **GET** /nodes/{node_id}/systems | Get all systems of one node
[**RemoveAssetsFromNode**](NodeApi.md#removeassetsfromnode) | **DELETE** /nodes/{node_id}/assets | Remove assets from a node
[**RemoveDocumentsFromNode**](NodeApi.md#removedocumentsfromnode) | **DELETE** /nodes/{node_id}/documents | Remove documents from a node
[**RemoveInstrumentationsFromNode**](NodeApi.md#removeinstrumentationsfromnode) | **DELETE** /nodes/{node_id}/instrumentations | Remove instrumentations from a node
[**RemoveRecipesFromNode**](NodeApi.md#removerecipesfromnode) | **DELETE** /nodes/{node_id}/recipes | Remove recipes from a node
[**RemoveSpecificationsFromNode**](NodeApi.md#removespecificationsfromnode) | **DELETE** /nodes/{node_id}/specifications | Delete specifications of a node
[**RemoveSystemsFromNode**](NodeApi.md#removesystemsfromnode) | **DELETE** /nodes/{node_id}/systems | Remove systems from a node
[**RenameSpecificationsOfNode**](NodeApi.md#renamespecificationsofnode) | **PATCH** /nodes/{node_id}/specifications/rename | Rename a specification key
[**ReplaceAssetsOfNode**](NodeApi.md#replaceassetsofnode) | **PATCH** /nodes/{node_id}/assets | Replace the assets of a node
[**ReplaceDocumentsOfNode**](NodeApi.md#replacedocumentsofnode) | **PATCH** /nodes/{node_id}/documents | Replace the documents of a node
[**ReplaceInstrumentationsOfNode**](NodeApi.md#replaceinstrumentationsofnode) | **PATCH** /nodes/{node_id}/instrumentations | Replace the instrumentations of a node
[**ReplaceRecipesOfNode**](NodeApi.md#replacerecipesofnode) | **PATCH** /nodes/{node_id}/recipes | Replace the recipes of a node
[**ReplaceSystemsOfNode**](NodeApi.md#replacesystemsofnode) | **PATCH** /nodes/{node_id}/systems | Replace the systems of a node
[**UpdateNode**](NodeApi.md#updatenode) | **PATCH** /nodes/{id} | Update a node
[**UpdateNodePicture**](NodeApi.md#updatenodepicture) | **PATCH** /nodes/{node_id}/pictures/{id} | Update an node picture
[**UpdateNodePictureLink**](NodeApi.md#updatenodepicturelink) | **PATCH** /nodes/{node_id}/pictures/links/{id} | Update a node picture link
[**UpdateSpecificationsOfNode**](NodeApi.md#updatespecificationsofnode) | **PATCH** /nodes/{node_id}/specifications | Update specifications of a node
[**UploadNodePicture**](NodeApi.md#uploadnodepicture) | **POST** /nodes/{id}/pictures | Upload an node picture

<a name="addassetstonode"></a>
# **AddAssetsToNode**
> void AddAssetsToNode (AssetIDs body, long? nodeId)

Add assets to a node

Add one or more assets to a node. This action requires `can_permit` permission on the node and on the asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddAssetsToNodeExample
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

            var apiInstance = new NodeApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be added.
            var nodeId = 789;  // long? | Id of the node to which the assets will be added

            try
            {
                // Add assets to a node
                apiInstance.AddAssetsToNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.AddAssetsToNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be added. | 
 **nodeId** | **long?**| Id of the node to which the assets will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adddocumentstonode"></a>
# **AddDocumentsToNode**
> void AddDocumentsToNode (DocumentIDs body, long? nodeId)

Add documents to a node

Add one or more documents to a node. This action requires `can_update` permission on the node and `can_read` permission on the document.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddDocumentsToNodeExample
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

            var apiInstance = new NodeApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be added.
            var nodeId = 789;  // long? | Id of the node to which the documents will be added

            try
            {
                // Add documents to a node
                apiInstance.AddDocumentsToNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.AddDocumentsToNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be added. | 
 **nodeId** | **long?**| Id of the node to which the documents will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addinstrumentationstonode"></a>
# **AddInstrumentationsToNode**
> void AddInstrumentationsToNode (InstrumentationIDs body, long? nodeId)

Add instrumentations to a node

Add one or more instrumentations to a node. This action requires `can_permit` permission on the node and on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddInstrumentationsToNodeExample
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

            var apiInstance = new NodeApi();
            var body = new InstrumentationIDs(); // InstrumentationIDs | Resources that shall be added.
            var nodeId = 789;  // long? | Id of the node to which the instrumentations will be added

            try
            {
                // Add instrumentations to a node
                apiInstance.AddInstrumentationsToNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.AddInstrumentationsToNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationIDs**](InstrumentationIDs.md)| Resources that shall be added. | 
 **nodeId** | **long?**| Id of the node to which the instrumentations will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addnodepicturelink"></a>
# **AddNodePictureLink**
> PictureResponse AddNodePictureLink (PictureLinkRequest body, long? id)

Add a link as node picture

Add an external resource as node picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddNodePictureLinkExample
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

            var apiInstance = new NodeApi();
            var body = new PictureLinkRequest(); // PictureLinkRequest | Picture link object to be created
            var id = 789;  // long? | Id of the node

            try
            {
                // Add a link as node picture
                PictureResponse result = apiInstance.AddNodePictureLink(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.AddNodePictureLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PictureLinkRequest**](PictureLinkRequest.md)| Picture link object to be created | 
 **id** | **long?**| Id of the node | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addrecipestonode"></a>
# **AddRecipesToNode**
> void AddRecipesToNode (RecipeIDs body, long? nodeId)

Add recipes to a node

Add one or more recipes to a node. This action requires `can_permit` permission on the node and on the recipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddRecipesToNodeExample
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

            var apiInstance = new NodeApi();
            var body = new RecipeIDs(); // RecipeIDs | Resources that shall be added.
            var nodeId = 789;  // long? | Id of the node to which the recipes will be added

            try
            {
                // Add recipes to a node
                apiInstance.AddRecipesToNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.AddRecipesToNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecipeIDs**](RecipeIDs.md)| Resources that shall be added. | 
 **nodeId** | **long?**| Id of the node to which the recipes will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addsystemstonode"></a>
# **AddSystemsToNode**
> void AddSystemsToNode (SystemIDs body, long? nodeId)

Add systems to a node

Add one or more systems to a node. This action requires `can_permit` permission on the node and on the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class AddSystemsToNodeExample
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

            var apiInstance = new NodeApi();
            var body = new SystemIDs(); // SystemIDs | Resources that shall be added.
            var nodeId = 789;  // long? | Id of the node to which the systems will be added

            try
            {
                // Add systems to a node
                apiInstance.AddSystemsToNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.AddSystemsToNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SystemIDs**](SystemIDs.md)| Resources that shall be added. | 
 **nodeId** | **long?**| Id of the node to which the systems will be added | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createnodes"></a>
# **CreateNodes**
> NodeResponse CreateNodes (NodeRequest body)

Create a new node

Create a new node. The name of the given node needs to be unique within its parent. The node will not be created when this constraint is violated. To assign a parent node the user needs `can_permit` permission on the parent.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class CreateNodesExample
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

            var apiInstance = new NodeApi();
            var body = new NodeRequest(); // NodeRequest | Object body that will be created. Name, node status and node type are required

            try
            {
                // Create a new node
                NodeResponse result = apiInstance.CreateNodes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.CreateNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeRequest**](NodeRequest.md)| Object body that will be created. Name, node status and node type are required | 

### Return type

[**NodeResponse**](NodeResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletenode"></a>
# **DeleteNode**
> void DeleteNode (long? id)

Delete a node

Delete a specific resource in your accessible scope, identified by the id in the URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteNodeExample
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

            var apiInstance = new NodeApi();
            var id = 789;  // long? | Id of the node to delete

            try
            {
                // Delete a node
                apiInstance.DeleteNode(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.DeleteNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the node to delete | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletenodepicture"></a>
# **DeleteNodePicture**
> void DeleteNodePicture (long? nodeId, long? id)

Delete an node picture

Delete an node picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DeleteNodePictureExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | Id of the node
            var id = 789;  // long? | Id of the node picture

            try
            {
                // Delete an node picture
                apiInstance.DeleteNodePicture(nodeId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.DeleteNodePicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| Id of the node | 
 **id** | **long?**| Id of the node picture | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloadnodepicture"></a>
# **DownloadNodePicture**
> void DownloadNodePicture (long? nodeId, long? id)

Download an node picture

Download an node picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class DownloadNodePictureExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | Id of the node
            var id = 789;  // long? | Id of the node picture

            try
            {
                // Download an node picture
                apiInstance.DownloadNodePicture(nodeId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.DownloadNodePicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| Id of the node | 
 **id** | **long?**| Id of the node picture | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetsofnode"></a>
# **GetAssetsOfNode**
> AssetsResponse GetAssetsOfNode (long? nodeId, int? page = null, int? perPage = null, string include = null, string serialNumber = null, string productId = null, string productCategoryId = null, string parentId = null, string manufacturerId = null, string statusId = null, string statusCode = null, DateTime? productionDate = null, DateTime? productionDateFrom = null, DateTime? productionDateTo = null, string specificationsKey = null, string specificationsValue = null, DateTime? createdAt = null, string createdAtFrom = null, string createdAtTo = null, DateTime? updatedAt = null, string updatedAtFrom = null, string updatedAtTo = null, bool? ownershipClaimed = null, string permission = null, string orderBy = null)

Get all assets of one node

Returns a list of all assets that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```status, tenant, parent, pictures, product, product.manufacturer, product.pictures, product.status, product.categories, product.categories.parent, specifications, specifications[key1,key2], product.tenant,                             product.manufacturer.tenant, status.tenant, instrumentations ```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetAssetsOfNodeExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var serialNumber = serialNumber_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productId = productId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var productCategoryId = productCategoryId_example;  // string | One or multiple ids (comma list). By adding `+` after the id, the filter considers the given category and all its children (e.g. 3+). (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var manufacturerId = manufacturerId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var statusCode = statusCode_example;  // string | Filter accepts `*` as wildcard (optional) 
            var productionDate = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateFrom = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var productionDateTo = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var createdAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var createdAtTo = createdAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAt = 2013-10-20;  // DateTime? | Expected date format is YYYY-MM-DD (optional) 
            var updatedAtFrom = updatedAtFrom_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var updatedAtTo = updatedAtTo_example;  // string | Expected date format is YYYY-MM-DDThh:mm:ss (optional) 
            var ownershipClaimed = true;  // bool? | Filter accepts true or false (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `serial_number`, `created_at` or `updated_at`, `last_seen_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all assets of one node
                AssetsResponse result = apiInstance.GetAssetsOfNode(nodeId, page, perPage, include, serialNumber, productId, productCategoryId, parentId, manufacturerId, statusId, statusCode, productionDate, productionDateFrom, productionDateTo, specificationsKey, specificationsValue, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, ownershipClaimed, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetAssetsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **serialNumber** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **productCategoryId** | **string**| One or multiple ids (comma list). By adding &#x60;+&#x60; after the id, the filter considers the given category and all its children (e.g. 3+). | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **manufacturerId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **statusCode** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **productionDate** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateFrom** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **productionDateTo** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **createdAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **createdAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **createdAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAt** | **DateTime?**| Expected date format is YYYY-MM-DD | [optional] 
 **updatedAtFrom** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **updatedAtTo** | **string**| Expected date format is YYYY-MM-DDThh:mm:ss | [optional] 
 **ownershipClaimed** | **bool?**| Filter accepts true or false | [optional] 
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;serial_number&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, &#x60;last_seen_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**AssetsResponse**](AssetsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdocumentsofnode"></a>
# **GetDocumentsOfNode**
> DocumentsResponse GetDocumentsOfNode (long? nodeId, int? page = null, int? perPage = null, string include = null, string name = null, string documentVersion = null, string number = null, string statusId = null, string classificationId = null, string tenantId = null, string categoryId = null, DateTime? validFrom = null, DateTime? validUntil = null, DateTime? validAt = null, string acceptLanguage = null)

Get all documents of a node

Returns a list of documents. If the query has no matches, the response is an empty list. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```status, tenant, classification, categories, categories.parent, categories.standards, attachments```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetDocumentsOfNodeExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | The resource defined in the URL
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
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all documents of a node
                DocumentsResponse result = apiInstance.GetDocumentsOfNode(nodeId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetDocumentsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| The resource defined in the URL | 
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
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**DocumentsResponse**](DocumentsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinstrumentationsofnode"></a>
# **GetInstrumentationsOfNode**
> InstrumentationsResponse GetInstrumentationsOfNode (long? nodeId, int? page = null, int? perPage = null, string include = null, string tag = null, string statusId = null, string typeId = null, string parentId = null, string tenantId = null, string specificationsKey = null, string specificationsValue = null, string criticality = null, string accessibility = null, string assetStatusId = null, string permission = null, string orderBy = null)

Get all instrumentations of one node

Returns a list of all instrumentations that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```specifications, specifications[key1,key2], pictures, tenant, parent, status, worst_asset_status, type```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetInstrumentationsOfNodeExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var tag = tag_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var criticality = criticality_example;  // string | Filter accepts undefined, low, medium or high (optional) 
            var accessibility = accessibility_example;  // string | Filter accepts undefined, easy, moderate or difficult (optional) 
            var assetStatusId = assetStatusId_example;  // string | One or multiple ids (comma list). Expected id format is integer. This retrieves all Instrumentations where at least one of its assets has one of the given statuses. (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `tag`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all instrumentations of one node
                InstrumentationsResponse result = apiInstance.GetInstrumentationsOfNode(nodeId, page, perPage, include, tag, statusId, typeId, parentId, tenantId, specificationsKey, specificationsValue, criticality, accessibility, assetStatusId, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetInstrumentationsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **tag** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **criticality** | **string**| Filter accepts undefined, low, medium or high | [optional] 
 **accessibility** | **string**| Filter accepts undefined, easy, moderate or difficult | [optional] 
 **assetStatusId** | **string**| One or multiple ids (comma list). Expected id format is integer. This retrieves all Instrumentations where at least one of its assets has one of the given statuses. | [optional] 
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;tag&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**InstrumentationsResponse**](InstrumentationsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnodeidtype"></a>
# **GetNodeIdType**
> NodeTypeResponse GetNodeIdType (long? nodeId, string include = null, string acceptLanguage = null)

Get the type of the specific node

Returns the type of the node. Needed if only permission on node but not on tenant. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language. Possible include values: ```tenant```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetNodeIdTypeExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | Id of the node
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get the type of the specific node
                NodeTypeResponse result = apiInstance.GetNodeIdType(nodeId, include, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetNodeIdType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| Id of the node | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**NodeTypeResponse**](NodeTypeResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnodepicture"></a>
# **GetNodePicture**
> PictureResponse GetNodePicture (long? nodeId, long? id)

Get an node picture

Get a single picture of an node.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetNodePictureExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | Id of the node
            var id = 789;  // long? | Id of the node picture

            try
            {
                // Get an node picture
                PictureResponse result = apiInstance.GetNodePicture(nodeId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetNodePicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| Id of the node | 
 **id** | **long?**| Id of the node picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnodepictures"></a>
# **GetNodePictures**
> PicturesResponse GetNodePictures (long? id, int? width = null, int? widthFrom = null, int? widthTo = null, int? height = null, int? heightFrom = null, int? heightTo = null)

Get node pictures

Get all pictures of an node.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetNodePicturesExample
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

            var apiInstance = new NodeApi();
            var id = 789;  // long? | Id of the node
            var width = 56;  // int? | filter by width (optional) 
            var widthFrom = 56;  // int? | filter by width_from (optional) 
            var widthTo = 56;  // int? | filter by width_to (optional) 
            var height = 56;  // int? | filter by height (optional) 
            var heightFrom = 56;  // int? | filter by height_from (optional) 
            var heightTo = 56;  // int? | filter by height_to (optional) 

            try
            {
                // Get node pictures
                PicturesResponse result = apiInstance.GetNodePictures(id, width, widthFrom, widthTo, height, heightFrom, heightTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetNodePictures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the node | 
 **width** | **int?**| filter by width | [optional] 
 **widthFrom** | **int?**| filter by width_from | [optional] 
 **widthTo** | **int?**| filter by width_to | [optional] 
 **height** | **int?**| filter by height | [optional] 
 **heightFrom** | **int?**| filter by height_from | [optional] 
 **heightTo** | **int?**| filter by height_to | [optional] 

### Return type

[**PicturesResponse**](PicturesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnodetypesoptions"></a>
# **GetNodeTypesOptions**
> NodeTypes GetNodeTypesOptions (long? nodeId, int? page = null, int? perPage = null, string tenantId = null, string name = null, string code = null, string acceptLanguage = null)

Get all possible types of the specified node

Returns a list of all possible node types for the specified node. Parameters supporting translation: ```name, description```. To get a translation set Accept-Language.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetNodeTypesOptionsExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | Id of the node
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var code = code_example;  // string | Filter accepts `*` as wildcard (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The client's accepted languages. One or several (e.g. fr,de,en) (optional) 

            try
            {
                // Get all possible types of the specified node
                NodeTypes result = apiInstance.GetNodeTypesOptions(nodeId, page, perPage, tenantId, name, code, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetNodeTypesOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| Id of the node | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **code** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **acceptLanguage** | **string**| The client&#x27;s accepted languages. One or several (e.g. fr,de,en) | [optional] 

### Return type

[**NodeTypes**](NodeTypes.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnodes"></a>
# **GetNodes**
> NodesResponse GetNodes (int? page = null, int? perPage = null, string include = null, string name = null, string typeId = null, string parentId = null, string tenantId = null, string permission = null, string orderBy = null)

Get a range of nodes

Returns a list of nodes in your accessible scope. If the query has no matches, the response is an empty list.  Possible include values: ```parent, tenant, type, type.parent, specifications, specifications[key1,key2], pictures, instrumentations, instrumentations.specifications, instrumentations.specifications[key1,key2], instrumentations.values, instrumentations.values.unit, instrumentations.values_in_preferred_units, instrumentations.values_in_preferred_units.unit, worst_asset_status``` Hidden nodes are not returned by default, if the hidden nodes should be included, add \"```hidden```\" to the include parameter 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetNodesExample
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

            var apiInstance = new NodeApi();
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var parentId = parentId_example;  // string | One or multiple ids (comma list). \"null\" to retrieve all objects without parent, \"!null\" for all objects with parent. (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`, add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get a range of nodes
                NodesResponse result = apiInstance.GetNodes(page, perPage, include, name, typeId, parentId, tenantId, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetNodes: " + e.Message );
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
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **parentId** | **string**| One or multiple ids (comma list). \&quot;null\&quot; to retrieve all objects without parent, \&quot;!null\&quot; for all objects with parent. | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;, add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**NodesResponse**](NodesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnodesbyid"></a>
# **GetNodesById**
> NodeResponse GetNodesById (long? id, string include = null)

Get a single node

Get a specific node in your accessible scope, identified by the id in the URL.  Possible include values: ```parent, tenant, type, specifications, specifications[key1,key2], pictures, instrumentations, instrumentations.specifications, instrumentations.specifications[key1,key2], instrumentations.values, instrumentations.values.unit, instrumentations.values_in_preferred_units, instrumentations.values_in_preferred_units.unit, worst_asset_status``` 

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetNodesByIdExample
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

            var apiInstance = new NodeApi();
            var id = 789;  // long? | Id of the node to fetch
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 

            try
            {
                // Get a single node
                NodeResponse result = apiInstance.GetNodesById(id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetNodesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the node to fetch | 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 

### Return type

[**NodeResponse**](NodeResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrecipesofnode"></a>
# **GetRecipesOfNode**
> RecipesResponse GetRecipesOfNode (long? nodeId, int? page = null, int? perPage = null, string include = null, string name = null, string statusId = null, string typeId = null, string tenantId = null, string specificationsKey = null, string specificationsValue = null, string orderBy = null)

Get all recipes of one node

Returns a list of all recipes that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```Possible include values: pictures, specifications, specifications[key1,key2], tenant, status, type, type.tenant, type.parent ```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetRecipesOfNodeExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all recipes of one node
                RecipesResponse result = apiInstance.GetRecipesOfNode(nodeId, page, perPage, include, name, statusId, typeId, tenantId, specificationsKey, specificationsValue, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetRecipesOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**RecipesResponse**](RecipesResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationkeysofnodes"></a>
# **GetSpecificationKeysOfNodes**
> SpecificationKeys GetSpecificationKeysOfNodes (string key = null, bool? uiVisible = null)

Get existing asset specification keys

Returns the existing specification keys in all readable nodes.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationKeysOfNodesExample
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

            var apiInstance = new NodeApi();
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get existing asset specification keys
                SpecificationKeys result = apiInstance.GetSpecificationKeysOfNodes(key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetSpecificationKeysOfNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationKeys**](SpecificationKeys.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getspecificationsofnode"></a>
# **GetSpecificationsOfNode**
> SpecificationsUIVisibleResponse GetSpecificationsOfNode (long? nodeId, string key = null, bool? uiVisible = null)

Get specifications of a node

Returns the specification of an object in your accessible scope. If no specifications are defined, this is just an empty object. Specification must have the form below.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSpecificationsOfNodeExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | Id of the specified node
            var key = key_example;  // string | Filter accepts '*' as wildcard (optional) 
            var uiVisible = true;  // bool? |  (optional) 

            try
            {
                // Get specifications of a node
                SpecificationsUIVisibleResponse result = apiInstance.GetSpecificationsOfNode(nodeId, key, uiVisible);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetSpecificationsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| Id of the specified node | 
 **key** | **string**| Filter accepts &#x27;*&#x27; as wildcard | [optional] 
 **uiVisible** | **bool?**|  | [optional] 

### Return type

[**SpecificationsUIVisibleResponse**](SpecificationsUIVisibleResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsystemsofnode"></a>
# **GetSystemsOfNode**
> SystemsResponse GetSystemsOfNode (long? nodeId, int? page = null, int? perPage = null, string include = null, string name = null, string statusId = null, string typeId = null, string tenantId = null, string specificationsKey = null, string specificationsValue = null, string permission = null, string orderBy = null)

Get all systems of one node

Returns a list of all systems that are available in your scope. You can apply query parameters in the request to get a filtered list. If the query has no matches, the response will show an empty array.  Possible include values: ```pictures, specifications, specifications[key1,key2], tenant, parent, status, type, type.tenant, type.parent, worst_asset_status ```

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class GetSystemsOfNodeExample
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

            var apiInstance = new NodeApi();
            var nodeId = 789;  // long? | The resource defined in the URL
            var page = 56;  // int? | Page number to load (optional) 
            var perPage = 56;  // int? | Number of items to load per page (optional) 
            var include = include_example;  // string | Comma separated list of objects to include in response (optional) 
            var name = name_example;  // string | Filter accepts `*` as wildcard (optional) 
            var statusId = statusId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var typeId = typeId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var tenantId = tenantId_example;  // string | One or multiple ids (comma list). Expected id format is integer (optional) 
            var specificationsKey = specificationsKey_example;  // string | Filter accepts `*` as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter (optional) 
            var specificationsValue = specificationsValue_example;  // string | Filter accepts `*` as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors (optional) 
            var permission = permission_example;  // string | Filter by permission of current user. Accepts `can_permit`, `can_delete`, `can_update`, `can_read` (default) (optional) 
            var orderBy = orderBy_example;  // string | Order result by attribute value, accepts `id`, `name`, `created_at` or `updated_at`. Add `-` as a prefix for descending order. Default value is `id` (optional) 

            try
            {
                // Get all systems of one node
                SystemsResponse result = apiInstance.GetSystemsOfNode(nodeId, page, perPage, include, name, statusId, typeId, tenantId, specificationsKey, specificationsValue, permission, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetSystemsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **long?**| The resource defined in the URL | 
 **page** | **int?**| Page number to load | [optional] 
 **perPage** | **int?**| Number of items to load per page | [optional] 
 **include** | **string**| Comma separated list of objects to include in response | [optional] 
 **name** | **string**| Filter accepts &#x60;*&#x60; as wildcard | [optional] 
 **statusId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **typeId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **tenantId** | **string**| One or multiple ids (comma list). Expected id format is integer | [optional] 
 **specificationsKey** | **string**| Filter accepts &#x60;*&#x60; as wildcard (if used as single specifications filter), supports comma list of keys in connection with specifications_value filter | [optional] 
 **specificationsValue** | **string**| Filter accepts &#x60;*&#x60; as wildcard, supports comma list of values in connection with specifications_key filter. Does not work for vectors | [optional] 
 **permission** | **string**| Filter by permission of current user. Accepts &#x60;can_permit&#x60;, &#x60;can_delete&#x60;, &#x60;can_update&#x60;, &#x60;can_read&#x60; (default) | [optional] 
 **orderBy** | **string**| Order result by attribute value, accepts &#x60;id&#x60;, &#x60;name&#x60;, &#x60;created_at&#x60; or &#x60;updated_at&#x60;. Add &#x60;-&#x60; as a prefix for descending order. Default value is &#x60;id&#x60; | [optional] 

### Return type

[**SystemsResponse**](SystemsResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeassetsfromnode"></a>
# **RemoveAssetsFromNode**
> void RemoveAssetsFromNode (AssetIDs body, long? nodeId)

Remove assets from a node

Remove one or more assets from a node in your accessible scope. This action requires `can_permit` permission on the node and on the asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveAssetsFromNodeExample
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

            var apiInstance = new NodeApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be removed.
            var nodeId = 789;  // long? | Id of the node from which the assets will be removed

            try
            {
                // Remove assets from a node
                apiInstance.RemoveAssetsFromNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.RemoveAssetsFromNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be removed. | 
 **nodeId** | **long?**| Id of the node from which the assets will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removedocumentsfromnode"></a>
# **RemoveDocumentsFromNode**
> void RemoveDocumentsFromNode (DocumentIDs body, long? nodeId)

Remove documents from a node

Remove one or more documents from a node. This action requires `can_update` permission on the node and `can_read` permission on the document.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveDocumentsFromNodeExample
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

            var apiInstance = new NodeApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be removed.
            var nodeId = 789;  // long? | Id of the node from which the documents will be removed

            try
            {
                // Remove documents from a node
                apiInstance.RemoveDocumentsFromNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.RemoveDocumentsFromNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be removed. | 
 **nodeId** | **long?**| Id of the node from which the documents will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeinstrumentationsfromnode"></a>
# **RemoveInstrumentationsFromNode**
> void RemoveInstrumentationsFromNode (InstrumentationIDs body, long? nodeId)

Remove instrumentations from a node

Remove one or more instrumentations from a node in your accessible scope. This action requires `can_permit` permission on the node and on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveInstrumentationsFromNodeExample
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

            var apiInstance = new NodeApi();
            var body = new InstrumentationIDs(); // InstrumentationIDs | Resources that shall be removed.
            var nodeId = 789;  // long? | Id of the node from which the instrumentations will be removed

            try
            {
                // Remove instrumentations from a node
                apiInstance.RemoveInstrumentationsFromNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.RemoveInstrumentationsFromNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationIDs**](InstrumentationIDs.md)| Resources that shall be removed. | 
 **nodeId** | **long?**| Id of the node from which the instrumentations will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removerecipesfromnode"></a>
# **RemoveRecipesFromNode**
> void RemoveRecipesFromNode (RecipeIDs body, long? nodeId)

Remove recipes from a node

Remove one or more recipes from a node in your accessible scope. This action requires `can_permit` permission on the node and on the recipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveRecipesFromNodeExample
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

            var apiInstance = new NodeApi();
            var body = new RecipeIDs(); // RecipeIDs | Resources that shall be removed.
            var nodeId = 789;  // long? | Id of the node from which the recipes will be removed

            try
            {
                // Remove recipes from a node
                apiInstance.RemoveRecipesFromNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.RemoveRecipesFromNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecipeIDs**](RecipeIDs.md)| Resources that shall be removed. | 
 **nodeId** | **long?**| Id of the node from which the recipes will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removespecificationsfromnode"></a>
# **RemoveSpecificationsFromNode**
> void RemoveSpecificationsFromNode (List<string> body, long? nodeId)

Delete specifications of a node

The specification keys in the body will be removed of the object in your accessible scope. If a key does not exist it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSpecificationsFromNodeExample
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

            var apiInstance = new NodeApi();
            var body = new List<string>(); // List<string> | Array of keys to delete from specifications
            var nodeId = 789;  // long? | Id of the specified node

            try
            {
                // Delete specifications of a node
                apiInstance.RemoveSpecificationsFromNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.RemoveSpecificationsFromNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| Array of keys to delete from specifications | 
 **nodeId** | **long?**| Id of the specified node | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removesystemsfromnode"></a>
# **RemoveSystemsFromNode**
> void RemoveSystemsFromNode (SystemIDs body, long? nodeId)

Remove systems from a node

Remove one or more systems from a node in your accessible scope. This action requires `can_permit` permission on the node and on the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RemoveSystemsFromNodeExample
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

            var apiInstance = new NodeApi();
            var body = new SystemIDs(); // SystemIDs | Resources that shall be removed.
            var nodeId = 789;  // long? | Id of the node from which the systems will be removed

            try
            {
                // Remove systems from a node
                apiInstance.RemoveSystemsFromNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.RemoveSystemsFromNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SystemIDs**](SystemIDs.md)| Resources that shall be removed. | 
 **nodeId** | **long?**| Id of the node from which the systems will be removed | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="renamespecificationsofnode"></a>
# **RenameSpecificationsOfNode**
> void RenameSpecificationsOfNode (SpecificationsRename body, long? nodeId)

Rename a specification key

Rename one specification key of a node in your accessible scope. The key name allows [a-z A-Z 0-9 . - _ ] all uppercase letters will be converted to lower-case.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class RenameSpecificationsOfNodeExample
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

            var apiInstance = new NodeApi();
            var body = new SpecificationsRename(); // SpecificationsRename | The specifications object to patch.
            var nodeId = 789;  // long? | Id of the specified node

            try
            {
                // Rename a specification key
                apiInstance.RenameSpecificationsOfNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.RenameSpecificationsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpecificationsRename**](SpecificationsRename.md)| The specifications object to patch. | 
 **nodeId** | **long?**| Id of the specified node | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceassetsofnode"></a>
# **ReplaceAssetsOfNode**
> void ReplaceAssetsOfNode (AssetIDs body, long? nodeId)

Replace the assets of a node

Replaces all assets belonging to a node in your accessible scope. You can send a list of resources that will replace all previous values. This action requires `can_permit` permission on the node and on the asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceAssetsOfNodeExample
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

            var apiInstance = new NodeApi();
            var body = new AssetIDs(); // AssetIDs | Resources that shall be replaced
            var nodeId = 789;  // long? | Id of the node of which the assets will be replaced

            try
            {
                // Replace the assets of a node
                apiInstance.ReplaceAssetsOfNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.ReplaceAssetsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetIDs**](AssetIDs.md)| Resources that shall be replaced | 
 **nodeId** | **long?**| Id of the node of which the assets will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacedocumentsofnode"></a>
# **ReplaceDocumentsOfNode**
> void ReplaceDocumentsOfNode (DocumentIDs body, long? nodeId)

Replace the documents of a node

Replaces all documents belonging to a node. You can send a list of resources that will replace all previous values. This action requires `can_update` permission on the node and `can_read` permission on the document.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceDocumentsOfNodeExample
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

            var apiInstance = new NodeApi();
            var body = new DocumentIDs(); // DocumentIDs | Resources that shall be replaced
            var nodeId = 789;  // long? | Id of the node of which the documents will be replaced

            try
            {
                // Replace the documents of a node
                apiInstance.ReplaceDocumentsOfNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.ReplaceDocumentsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentIDs**](DocumentIDs.md)| Resources that shall be replaced | 
 **nodeId** | **long?**| Id of the node of which the documents will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replaceinstrumentationsofnode"></a>
# **ReplaceInstrumentationsOfNode**
> void ReplaceInstrumentationsOfNode (InstrumentationIDs body, long? nodeId)

Replace the instrumentations of a node

Replaces all instrumentations belonging to a node in your accessible scope. You can send a list of resources that will replace all previous values. This action requires `can_permit` permission on the node and on the instrumentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceInstrumentationsOfNodeExample
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

            var apiInstance = new NodeApi();
            var body = new InstrumentationIDs(); // InstrumentationIDs | Resources that shall be replaced
            var nodeId = 789;  // long? | Id of the node of which the instrumentations will be replaced

            try
            {
                // Replace the instrumentations of a node
                apiInstance.ReplaceInstrumentationsOfNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.ReplaceInstrumentationsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstrumentationIDs**](InstrumentationIDs.md)| Resources that shall be replaced | 
 **nodeId** | **long?**| Id of the node of which the instrumentations will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacerecipesofnode"></a>
# **ReplaceRecipesOfNode**
> void ReplaceRecipesOfNode (RecipeIDs body, long? nodeId)

Replace the recipes of a node

Replaces all recipes belonging to a node in your accessible scope. You can send a list of resources that will replace all previous values. This action requires `can_permit` permission on the node and on the recipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceRecipesOfNodeExample
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

            var apiInstance = new NodeApi();
            var body = new RecipeIDs(); // RecipeIDs | Resources that shall be replaced
            var nodeId = 789;  // long? | Id of the node of which the recipes will be replaced

            try
            {
                // Replace the recipes of a node
                apiInstance.ReplaceRecipesOfNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.ReplaceRecipesOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecipeIDs**](RecipeIDs.md)| Resources that shall be replaced | 
 **nodeId** | **long?**| Id of the node of which the recipes will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="replacesystemsofnode"></a>
# **ReplaceSystemsOfNode**
> void ReplaceSystemsOfNode (SystemIDs body, long? nodeId)

Replace the systems of a node

Replaces all systems belonging to a node in your accessible scope. You can send a list of resources that will replace all previous values. This action requires `can_permit` permission on the node and on the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class ReplaceSystemsOfNodeExample
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

            var apiInstance = new NodeApi();
            var body = new SystemIDs(); // SystemIDs | Resources that shall be replaced
            var nodeId = 789;  // long? | Id of the node of which the systems will be replaced

            try
            {
                // Replace the systems of a node
                apiInstance.ReplaceSystemsOfNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.ReplaceSystemsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SystemIDs**](SystemIDs.md)| Resources that shall be replaced | 
 **nodeId** | **long?**| Id of the node of which the systems will be replaced | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatenode"></a>
# **UpdateNode**
> void UpdateNode (NodeRequest body, long? id)

Update a node

Update accessible parameters of the requested resource in your accessible scope. To assign a parent node the user needs `can_permit` permission on the parent and on the current node.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateNodeExample
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

            var apiInstance = new NodeApi();
            var body = new NodeRequest(); // NodeRequest | Parameters that shall be updated.
            var id = 789;  // long? | Id of the node to update

            try
            {
                // Update a node
                apiInstance.UpdateNode(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.UpdateNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NodeRequest**](NodeRequest.md)| Parameters that shall be updated. | 
 **id** | **long?**| Id of the node to update | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatenodepicture"></a>
# **UpdateNodePicture**
> PictureResponse UpdateNodePicture (byte[] image, long? nodeId, long? id)

Update an node picture

Upload a new node picture. Check the file-storage quota. Allowed content-types are - image/gif - image/jpg - image/jpeg - image/png

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateNodePictureExample
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

            var apiInstance = new NodeApi();
            var image = image_example;  // byte[] | 
            var nodeId = 789;  // long? | Id of the node
            var id = 789;  // long? | Id of the node picture

            try
            {
                // Update an node picture
                PictureResponse result = apiInstance.UpdateNodePicture(image, nodeId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.UpdateNodePicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **nodeId** | **long?**| Id of the node | 
 **id** | **long?**| Id of the node picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatenodepicturelink"></a>
# **UpdateNodePictureLink**
> PictureResponse UpdateNodePictureLink (PictureLinkRequest body, long? nodeId, long? id)

Update a node picture link

Update a node picture link.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateNodePictureLinkExample
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

            var apiInstance = new NodeApi();
            var body = new PictureLinkRequest(); // PictureLinkRequest | Picture link object to be updated
            var nodeId = 789;  // long? | Id of the node
            var id = 789;  // long? | Id of the node picture

            try
            {
                // Update a node picture link
                PictureResponse result = apiInstance.UpdateNodePictureLink(body, nodeId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.UpdateNodePictureLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PictureLinkRequest**](PictureLinkRequest.md)| Picture link object to be updated | 
 **nodeId** | **long?**| Id of the node | 
 **id** | **long?**| Id of the node picture | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatespecificationsofnode"></a>
# **UpdateSpecificationsOfNode**
> void UpdateSpecificationsOfNode (Dictionary<string, SpecificationUIVisibleRequest> body, long? nodeId)

Update specifications of a node

Update the specification object of a node in your accessible scope. To add specifications, just add the key and set the value object with value, unit and source_timestamp. To mark an existing specification to be unknown, the value could be set to null. To delete keys, use the delete method. Multiple specification objects can be sent in the same request. Keys inside a specification are unique and can only be added once. Keys can only consist of [a-z A-Z 0-9 . - _ ]. All uppercase A-Z are converted to lower-case a-z. For a key that is send multiple times in the request body, only the last key-value is saved.

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UpdateSpecificationsOfNodeExample
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

            var apiInstance = new NodeApi();
            var body = new Dictionary<string, SpecificationUIVisibleRequest>(); // Dictionary<string, SpecificationUIVisibleRequest> | The specifications objects to patch.
            var nodeId = 789;  // long? | Id of the specified node

            try
            {
                // Update specifications of a node
                apiInstance.UpdateSpecificationsOfNode(body, nodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.UpdateSpecificationsOfNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, SpecificationUIVisibleRequest&gt;**](Dictionary&lt;string, SpecificationUIVisibleRequest&gt;.md)| The specifications objects to patch. | 
 **nodeId** | **long?**| Id of the specified node | 

### Return type

void (empty response body)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadnodepicture"></a>
# **UploadNodePicture**
> PictureResponse UploadNodePicture (byte[] image, long? id)

Upload an node picture

Upload a new node picture. Checks the file-storage quota. Allowed content-types are - image/gif - image/jpg - image/jpeg - image/png

### Example
```csharp
using System;
using System.Diagnostics;
using Netilion.Api.Api;
using Netilion.Api.Client;
using Netilion.Api.Model;

namespace Example
{
    public class UploadNodePictureExample
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

            var apiInstance = new NodeApi();
            var image = image_example;  // byte[] | 
            var id = 789;  // long? | Id of the node

            try
            {
                // Upload an node picture
                PictureResponse result = apiInstance.UploadNodePicture(image, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.UploadNodePicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **byte[]****byte[]**|  | 
 **id** | **long?**| Id of the node | 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

[API-Key](../README.md#API-Key), [Authentication](../README.md#Authentication)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
