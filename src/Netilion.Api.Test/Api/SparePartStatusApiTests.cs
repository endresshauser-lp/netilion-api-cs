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
    ///  Class for testing SparePartStatusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SparePartStatusApiTests
    {
        private SparePartStatusApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SparePartStatusApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SparePartStatusApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SparePartStatusApi
            //Assert.IsInstanceOfType(typeof(SparePartStatusApi), instance, "instance is a SparePartStatusApi");
        }

        /// <summary>
        /// Test GetSparePartStatusById
        /// </summary>
        [Test]
        public void GetSparePartStatusByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string acceptLanguage = null;
            //var response = instance.GetSparePartStatusById(id, acceptLanguage);
            //Assert.IsInstanceOf<SparePartStatusResponse> (response, "response is SparePartStatusResponse");
        }
        /// <summary>
        /// Test GetSparePartStatuses
        /// </summary>
        [Test]
        public void GetSparePartStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string tenantId = null;
            //string code = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetSparePartStatuses(page, perPage, name, tenantId, code, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<SparePartStatuses> (response, "response is SparePartStatuses");
        }
        /// <summary>
        /// Test GetSparePartStatusesOptions
        /// </summary>
        [Test]
        public void GetSparePartStatusesOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? sparePartId = null;
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string tenantId = null;
            //string code = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetSparePartStatusesOptions(sparePartId, page, perPage, name, tenantId, code, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<SparePartStatuses> (response, "response is SparePartStatuses");
        }
    }

}
