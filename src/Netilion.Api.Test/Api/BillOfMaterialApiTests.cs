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
    ///  Class for testing BillOfMaterialApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BillOfMaterialApiTests
    {
        private BillOfMaterialApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BillOfMaterialApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillOfMaterialApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BillOfMaterialApi
            //Assert.IsInstanceOfType(typeof(BillOfMaterialApi), instance, "instance is a BillOfMaterialApi");
        }

        /// <summary>
        /// Test AddDocumentsToBillOfMaterial
        /// </summary>
        [Test]
        public void AddDocumentsToBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIDs body = null;
            //long? billOfMaterialId = null;
            //instance.AddDocumentsToBillOfMaterial(body, billOfMaterialId);
            
        }
        /// <summary>
        /// Test AddInstrumentationsToBillOfMaterial
        /// </summary>
        [Test]
        public void AddInstrumentationsToBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InstrumentationIDs body = null;
            //long? billOfMaterialId = null;
            //instance.AddInstrumentationsToBillOfMaterial(body, billOfMaterialId);
            
        }
        /// <summary>
        /// Test AddRequestForQuotationsToBillOfMaterial
        /// </summary>
        [Test]
        public void AddRequestForQuotationsToBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestForQuotationIDs body = null;
            //long? billOfMaterialId = null;
            //instance.AddRequestForQuotationsToBillOfMaterial(body, billOfMaterialId);
            
        }
        /// <summary>
        /// Test CreateBillOfMaterial
        /// </summary>
        [Test]
        public void CreateBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillOfMaterialRequest body = null;
            //var response = instance.CreateBillOfMaterial(body);
            //Assert.IsInstanceOf<BillOfMaterialResponse> (response, "response is BillOfMaterialResponse");
        }
        /// <summary>
        /// Test DeleteBillOfMaterial
        /// </summary>
        [Test]
        public void DeleteBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteBillOfMaterial(id);
            
        }
        /// <summary>
        /// Test GetBillOfMaterialById
        /// </summary>
        [Test]
        public void GetBillOfMaterialByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetBillOfMaterialById(id);
            //Assert.IsInstanceOf<BillOfMaterialResponse> (response, "response is BillOfMaterialResponse");
        }
        /// <summary>
        /// Test GetBillOfMaterials
        /// </summary>
        [Test]
        public void GetBillOfMaterialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string author = null;
            //string date = null;
            //string dateFrom = null;
            //string dateTo = null;
            //string orderBy = null;
            //var response = instance.GetBillOfMaterials(page, perPage, name, author, date, dateFrom, dateTo, orderBy);
            //Assert.IsInstanceOf<BillOfMaterialsResponse> (response, "response is BillOfMaterialsResponse");
        }
        /// <summary>
        /// Test GetDocumentsOfBillOfMaterial
        /// </summary>
        [Test]
        public void GetDocumentsOfBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? billOfMaterialId = null;
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
            //var response = instance.GetDocumentsOfBillOfMaterial(billOfMaterialId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<DocumentsResponse> (response, "response is DocumentsResponse");
        }
        /// <summary>
        /// Test GetInstrumentationsOfBillOfMaterial
        /// </summary>
        [Test]
        public void GetInstrumentationsOfBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? billOfMaterialId = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string tag = null;
            //string statusId = null;
            //string typeId = null;
            //string parentId = null;
            //string tenantId = null;
            //string specificationsKey = null;
            //string specificationsValue = null;
            //string criticality = null;
            //string accessibility = null;
            //string assetStatusId = null;
            //string permission = null;
            //string orderBy = null;
            //var response = instance.GetInstrumentationsOfBillOfMaterial(billOfMaterialId, page, perPage, include, tag, statusId, typeId, parentId, tenantId, specificationsKey, specificationsValue, criticality, accessibility, assetStatusId, permission, orderBy);
            //Assert.IsInstanceOf<InstrumentationsResponse> (response, "response is InstrumentationsResponse");
        }
        /// <summary>
        /// Test GetRequestForQuotationsOfBillOfMaterial
        /// </summary>
        [Test]
        public void GetRequestForQuotationsOfBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? billOfMaterialId = null;
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string number = null;
            //string statusId = null;
            //string date = null;
            //string dateFrom = null;
            //string dateTo = null;
            //string senderId = null;
            //string receiverId = null;
            //string author = null;
            //string orderBy = null;
            //var response = instance.GetRequestForQuotationsOfBillOfMaterial(billOfMaterialId, page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, author, orderBy);
            //Assert.IsInstanceOf<RequestForQuotationsResponse> (response, "response is RequestForQuotationsResponse");
        }
        /// <summary>
        /// Test RemoveDocumentsFromBillOfMaterial
        /// </summary>
        [Test]
        public void RemoveDocumentsFromBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIDs body = null;
            //long? billOfMaterialId = null;
            //instance.RemoveDocumentsFromBillOfMaterial(body, billOfMaterialId);
            
        }
        /// <summary>
        /// Test RemoveInstrumentationsFromBillOfMaterial
        /// </summary>
        [Test]
        public void RemoveInstrumentationsFromBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InstrumentationIDs body = null;
            //long? billOfMaterialId = null;
            //instance.RemoveInstrumentationsFromBillOfMaterial(body, billOfMaterialId);
            
        }
        /// <summary>
        /// Test RemoveRequestForQuotationsOfBillOfMaterial
        /// </summary>
        [Test]
        public void RemoveRequestForQuotationsOfBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestForQuotationIDs body = null;
            //long? billOfMaterialId = null;
            //instance.RemoveRequestForQuotationsOfBillOfMaterial(body, billOfMaterialId);
            
        }
        /// <summary>
        /// Test ReplaceDocumentsOfBillOfMaterial
        /// </summary>
        [Test]
        public void ReplaceDocumentsOfBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIDs body = null;
            //long? billOfMaterialId = null;
            //instance.ReplaceDocumentsOfBillOfMaterial(body, billOfMaterialId);
            
        }
        /// <summary>
        /// Test ReplaceInstrumentationsOfBillOfMaterial
        /// </summary>
        [Test]
        public void ReplaceInstrumentationsOfBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InstrumentationIDs body = null;
            //long? billOfMaterialId = null;
            //instance.ReplaceInstrumentationsOfBillOfMaterial(body, billOfMaterialId);
            
        }
        /// <summary>
        /// Test ReplaceRequestForQuotationsOfBillOfMaterial
        /// </summary>
        [Test]
        public void ReplaceRequestForQuotationsOfBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestForQuotationIDs body = null;
            //long? billOfMaterialId = null;
            //instance.ReplaceRequestForQuotationsOfBillOfMaterial(body, billOfMaterialId);
            
        }
        /// <summary>
        /// Test UpdateBillOfMaterial
        /// </summary>
        [Test]
        public void UpdateBillOfMaterialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillOfMaterialRequest body = null;
            //long? id = null;
            //instance.UpdateBillOfMaterial(body, id);
            
        }
    }

}
