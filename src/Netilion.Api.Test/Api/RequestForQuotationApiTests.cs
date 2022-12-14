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
    ///  Class for testing RequestForQuotationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RequestForQuotationApiTests
    {
        private RequestForQuotationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RequestForQuotationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RequestForQuotationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RequestForQuotationApi
            //Assert.IsInstanceOfType(typeof(RequestForQuotationApi), instance, "instance is a RequestForQuotationApi");
        }

        /// <summary>
        /// Test AddBillOfMaterialsToRequestForQuotation
        /// </summary>
        [Test]
        public void AddBillOfMaterialsToRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillOfMaterialIDs body = null;
            //long? requestForQuotationId = null;
            //instance.AddBillOfMaterialsToRequestForQuotation(body, requestForQuotationId);
            
        }
        /// <summary>
        /// Test AddDocumentsToRequestForQuotation
        /// </summary>
        [Test]
        public void AddDocumentsToRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIDs body = null;
            //long? requestForQuotationId = null;
            //instance.AddDocumentsToRequestForQuotation(body, requestForQuotationId);
            
        }
        /// <summary>
        /// Test AddQuotationsToRequestForQuotation
        /// </summary>
        [Test]
        public void AddQuotationsToRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuotationIDs body = null;
            //long? requestForQuotationId = null;
            //instance.AddQuotationsToRequestForQuotation(body, requestForQuotationId);
            
        }
        /// <summary>
        /// Test CreateRequestForQuotation
        /// </summary>
        [Test]
        public void CreateRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestForQuotationRequest body = null;
            //var response = instance.CreateRequestForQuotation(body);
            //Assert.IsInstanceOf<RequestForQuotationResponse> (response, "response is RequestForQuotationResponse");
        }
        /// <summary>
        /// Test DeleteBillOfMaterialsFromRequestForQuotation
        /// </summary>
        [Test]
        public void DeleteBillOfMaterialsFromRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillOfMaterialIDs body = null;
            //long? requestForQuotationId = null;
            //instance.DeleteBillOfMaterialsFromRequestForQuotation(body, requestForQuotationId);
            
        }
        /// <summary>
        /// Test DeleteDocumentsOfRequestForQuotation
        /// </summary>
        [Test]
        public void DeleteDocumentsOfRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIDs body = null;
            //long? requestForQuotationId = null;
            //instance.DeleteDocumentsOfRequestForQuotation(body, requestForQuotationId);
            
        }
        /// <summary>
        /// Test DeleteQuotationsFromRequestForQuotation
        /// </summary>
        [Test]
        public void DeleteQuotationsFromRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuotationIDs body = null;
            //long? requestForQuotationId = null;
            //instance.DeleteQuotationsFromRequestForQuotation(body, requestForQuotationId);
            
        }
        /// <summary>
        /// Test DeleteRequestForQuotation
        /// </summary>
        [Test]
        public void DeleteRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteRequestForQuotation(id);
            
        }
        /// <summary>
        /// Test GetBillOfMaterialsOfRequestForQuotation
        /// </summary>
        [Test]
        public void GetBillOfMaterialsOfRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? requestForQuotationId = null;
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string author = null;
            //string date = null;
            //string dateFrom = null;
            //string dateTo = null;
            //string orderBy = null;
            //var response = instance.GetBillOfMaterialsOfRequestForQuotation(requestForQuotationId, page, perPage, name, author, date, dateFrom, dateTo, orderBy);
            //Assert.IsInstanceOf<BillOfMaterialsResponse> (response, "response is BillOfMaterialsResponse");
        }
        /// <summary>
        /// Test GetDocumentsOfRequestForQuotation
        /// </summary>
        [Test]
        public void GetDocumentsOfRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? requestForQuotationId = null;
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
            //var response = instance.GetDocumentsOfRequestForQuotation(requestForQuotationId, page, perPage, include, name, documentVersion, number, statusId, classificationId, tenantId, categoryId, validFrom, validUntil, validAt, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<DocumentsResponse> (response, "response is DocumentsResponse");
        }
        /// <summary>
        /// Test GetQuotationsOfRequestForQuotation
        /// </summary>
        [Test]
        public void GetQuotationsOfRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? requestForQuotationId = null;
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
            //string orderBy = null;
            //var response = instance.GetQuotationsOfRequestForQuotation(requestForQuotationId, page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, orderBy);
            //Assert.IsInstanceOf<QuotationsResponse> (response, "response is QuotationsResponse");
        }
        /// <summary>
        /// Test GetRequestForQuotationById
        /// </summary>
        [Test]
        public void GetRequestForQuotationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetRequestForQuotationById(id);
            //Assert.IsInstanceOf<RequestForQuotationResponse> (response, "response is RequestForQuotationResponse");
        }
        /// <summary>
        /// Test GetRequestForQuotationIdStatus
        /// </summary>
        [Test]
        public void GetRequestForQuotationIdStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? requestForQuotationId = null;
            //string include = null;
            //string acceptLanguage = null;
            //var response = instance.GetRequestForQuotationIdStatus(requestForQuotationId, include, acceptLanguage);
            //Assert.IsInstanceOf<RequestForQuotationStatusResponse> (response, "response is RequestForQuotationStatusResponse");
        }
        /// <summary>
        /// Test GetRequestForQuotations
        /// </summary>
        [Test]
        public void GetRequestForQuotationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
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
            //var response = instance.GetRequestForQuotations(page, perPage, name, number, statusId, date, dateFrom, dateTo, senderId, receiverId, author, orderBy);
            //Assert.IsInstanceOf<RequestForQuotationsResponse> (response, "response is RequestForQuotationsResponse");
        }
        /// <summary>
        /// Test ReplaceBillOfMaterialsOfRequestForQuotation
        /// </summary>
        [Test]
        public void ReplaceBillOfMaterialsOfRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillOfMaterialIDs body = null;
            //long? requestForQuotationId = null;
            //instance.ReplaceBillOfMaterialsOfRequestForQuotation(body, requestForQuotationId);
            
        }
        /// <summary>
        /// Test ReplaceDocumentsOfRequestForQuotation
        /// </summary>
        [Test]
        public void ReplaceDocumentsOfRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIDs body = null;
            //long? requestForQuotationId = null;
            //instance.ReplaceDocumentsOfRequestForQuotation(body, requestForQuotationId);
            
        }
        /// <summary>
        /// Test ReplaceQuotationsOfRequestForQuotation
        /// </summary>
        [Test]
        public void ReplaceQuotationsOfRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuotationIDs body = null;
            //long? requestForQuotationId = null;
            //instance.ReplaceQuotationsOfRequestForQuotation(body, requestForQuotationId);
            
        }
        /// <summary>
        /// Test UpdateRequestForQuotation
        /// </summary>
        [Test]
        public void UpdateRequestForQuotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestForQuotationRequest body = null;
            //long? id = null;
            //instance.UpdateRequestForQuotation(body, id);
            
        }
    }

}
