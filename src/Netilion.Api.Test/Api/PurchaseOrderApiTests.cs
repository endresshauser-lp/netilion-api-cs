/* 
 * Netilion API Documentation
 *
 * Welcome to the Netilion API Documentation, which provides interactive access and documentation to our REST API. Please visit our developer portal for further instructions and information: https://developer.netilion.endress.com/ 
 *
 * OpenAPI spec version: 01.00.00
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Netilion.Api.Client;
using Netilion.Api.Api;
using Netilion.Api.Model;

namespace Netilion.Api.Test
{
    /// <summary>
    ///  Class for testing PurchaseOrderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PurchaseOrderApiTests
    {
        private PurchaseOrderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PurchaseOrderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PurchaseOrderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PurchaseOrderApi
            //Assert.IsInstanceOfType(typeof(PurchaseOrderApi), instance, "instance is a PurchaseOrderApi");
        }

        /// <summary>
        /// Test AddDeliviersToPurchaseOrder
        /// </summary>
        [Test]
        public void AddDeliviersToPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeliveryIDs body = null;
            //long? purchaseOrderId = null;
            //instance.AddDeliviersToPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test AddDocumentsToPurchaseOrder
        /// </summary>
        [Test]
        public void AddDocumentsToPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIDs body = null;
            //long? purchaseOrderId = null;
            //instance.AddDocumentsToPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test AddProductsToPurchaseOrder
        /// </summary>
        [Test]
        public void AddProductsToPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductIDs body = null;
            //long? purchaseOrderId = null;
            //instance.AddProductsToPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test CreatePurchaseOrder
        /// </summary>
        [Test]
        public void CreatePurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PurchaseOrderRequest body = null;
            //var response = instance.CreatePurchaseOrder(body);
            //Assert.IsInstanceOf<PurchaseOrderResponse> (response, "response is PurchaseOrderResponse");
        }
        /// <summary>
        /// Test DeletePurchaseOrder
        /// </summary>
        [Test]
        public void DeletePurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeletePurchaseOrder(id);
            
        }
        /// <summary>
        /// Test GetDeliviersOfPurchaseOrder
        /// </summary>
        [Test]
        public void GetDeliviersOfPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? purchaseOrderId = null;
            //int? page = null;
            //int? perPage = null;
            //string number = null;
            //string name = null;
            //DateTime? dateOfShipment = null;
            //DateTime? dateOfShipmentFrom = null;
            //DateTime? dateOfShipmentTo = null;
            //string statusId = null;
            //string senderId = null;
            //string receiverId = null;
            //string customerNumber = null;
            //string orderBy = null;
            //var response = instance.GetDeliviersOfPurchaseOrder(purchaseOrderId, page, perPage, number, name, dateOfShipment, dateOfShipmentFrom, dateOfShipmentTo, statusId, senderId, receiverId, customerNumber, orderBy);
            //Assert.IsInstanceOf<DeliveriesResponse> (response, "response is DeliveriesResponse");
        }
        /// <summary>
        /// Test GetDocumentsOfPurchaseOrder
        /// </summary>
        [Test]
        public void GetDocumentsOfPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? purchaseOrderId = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string name = null;
            //string documentVersion = null;
            //string number = null;
            //string statusId = null;
            //string classificationId = null;
            //string tenantId = null;
            //string categoryId = null;
            //DateTime? validFrom = null;
            //DateTime? validUntil = null;
            //DateTime? validAt = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetDocumentsOfPurchaseOrder(purchaseOrderId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<DocumentsResponse> (response, "response is DocumentsResponse");
        }
        /// <summary>
        /// Test GetProductsOfPurchaseOrder
        /// </summary>
        [Test]
        public void GetProductsOfPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? purchaseOrderId = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string productCode = null;
            //string name = null;
            //string manufacturerId = null;
            //string statusId = null;
            //string parentId = null;
            //string tenantId = null;
            //string categoryId = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetProductsOfPurchaseOrder(purchaseOrderId, page, perPage, include, productCode, name, manufacturerId, statusId, parentId, tenantId, categoryId, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<ProductsResponse> (response, "response is ProductsResponse");
        }
        /// <summary>
        /// Test GetPurchaseOrderById
        /// </summary>
        [Test]
        public void GetPurchaseOrderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetPurchaseOrderById(id);
            //Assert.IsInstanceOf<PurchaseOrderResponse> (response, "response is PurchaseOrderResponse");
        }
        /// <summary>
        /// Test GetPurchaseOrderIdStatus
        /// </summary>
        [Test]
        public void GetPurchaseOrderIdStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? purchaseOrderId = null;
            //string include = null;
            //string acceptLanguage = null;
            //var response = instance.GetPurchaseOrderIdStatus(purchaseOrderId, include, acceptLanguage);
            //Assert.IsInstanceOf<PurchaseOrderStatusResponse> (response, "response is PurchaseOrderStatusResponse");
        }
        /// <summary>
        /// Test GetPurchaseOrders
        /// </summary>
        [Test]
        public void GetPurchaseOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string number = null;
            //string customerPurchaseOrderNumber = null;
            //string statusId = null;
            //string date = null;
            //string dateFrom = null;
            //string dateTo = null;
            //string senderId = null;
            //string receiverId = null;
            //string quotationId = null;
            //string customerNumber = null;
            //string orderBy = null;
            //var response = instance.GetPurchaseOrders(page, perPage, name, number, customerPurchaseOrderNumber, statusId, date, dateFrom, dateTo, senderId, receiverId, quotationId, customerNumber, orderBy);
            //Assert.IsInstanceOf<PurchaseOrdersResponse> (response, "response is PurchaseOrdersResponse");
        }
        /// <summary>
        /// Test RemoveDeliviersFromPurchaseOrder
        /// </summary>
        [Test]
        public void RemoveDeliviersFromPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeliveryIDs body = null;
            //long? purchaseOrderId = null;
            //instance.RemoveDeliviersFromPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test RemoveDocumentsFromPurchaseOrder
        /// </summary>
        [Test]
        public void RemoveDocumentsFromPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIDs body = null;
            //long? purchaseOrderId = null;
            //instance.RemoveDocumentsFromPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test RemoveProductsFromPurchaseOrder
        /// </summary>
        [Test]
        public void RemoveProductsFromPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductIDs body = null;
            //long? purchaseOrderId = null;
            //instance.RemoveProductsFromPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test ReplaceDeliviersOfPurchaseOrder
        /// </summary>
        [Test]
        public void ReplaceDeliviersOfPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeliveryIDs body = null;
            //long? purchaseOrderId = null;
            //instance.ReplaceDeliviersOfPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test ReplaceDocumentsOfPurchaseOrder
        /// </summary>
        [Test]
        public void ReplaceDocumentsOfPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIDs body = null;
            //long? purchaseOrderId = null;
            //instance.ReplaceDocumentsOfPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test ReplaceProductsOfPurchaseOrder
        /// </summary>
        [Test]
        public void ReplaceProductsOfPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductIDs body = null;
            //long? purchaseOrderId = null;
            //instance.ReplaceProductsOfPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test UpdateProductQuantitiesOfPurchaseOrder
        /// </summary>
        [Test]
        public void UpdateProductQuantitiesOfPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductQuantity body = null;
            //long? purchaseOrderId = null;
            //instance.UpdateProductQuantitiesOfPurchaseOrder(body, purchaseOrderId);
            
        }
        /// <summary>
        /// Test UpdatePurchaseOrder
        /// </summary>
        [Test]
        public void UpdatePurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PurchaseOrderRequest body = null;
            //long? id = null;
            //instance.UpdatePurchaseOrder(body, id);
            
        }
    }

}