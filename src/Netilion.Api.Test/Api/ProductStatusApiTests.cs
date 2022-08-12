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
    ///  Class for testing ProductStatusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductStatusApiTests
    {
        private ProductStatusApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductStatusApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductStatusApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductStatusApi
            //Assert.IsInstanceOfType(typeof(ProductStatusApi), instance, "instance is a ProductStatusApi");
        }

        /// <summary>
        /// Test DeleteProductStatus
        /// </summary>
        [Test]
        public void DeleteProductStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteProductStatus(id);
            
        }
        /// <summary>
        /// Test GetProductIdStatus
        /// </summary>
        [Test]
        public void GetProductIdStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? productId = null;
            //string acceptLanguage = null;
            //var response = instance.GetProductIdStatus(productId, acceptLanguage);
            //Assert.IsInstanceOf<ProductStatusResponse> (response, "response is ProductStatusResponse");
        }
        /// <summary>
        /// Test GetProductStatusById
        /// </summary>
        [Test]
        public void GetProductStatusByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string acceptLanguage = null;
            //var response = instance.GetProductStatusById(id, acceptLanguage);
            //Assert.IsInstanceOf<ProductStatusResponse> (response, "response is ProductStatusResponse");
        }
        /// <summary>
        /// Test GetProductStatuses
        /// </summary>
        [Test]
        public void GetProductStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string tenantId = null;
            //string code = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetProductStatuses(page, perPage, name, tenantId, code, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<ProductStatuses> (response, "response is ProductStatuses");
        }
        /// <summary>
        /// Test GetProductStatusesOptions
        /// </summary>
        [Test]
        public void GetProductStatusesOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? productId = null;
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string tenantId = null;
            //string code = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetProductStatusesOptions(productId, page, perPage, name, tenantId, code, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<ProductStatuses> (response, "response is ProductStatuses");
        }
        /// <summary>
        /// Test UpdateProductStatus
        /// </summary>
        [Test]
        public void UpdateProductStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductStatusRequest body = null;
            //long? id = null;
            //string contentLanguage = null;
            //instance.UpdateProductStatus(body, id, contentLanguage);
            
        }
    }

}