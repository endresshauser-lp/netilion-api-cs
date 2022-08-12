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
    ///  Class for testing InstrumentationTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InstrumentationTypeApiTests
    {
        private InstrumentationTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InstrumentationTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InstrumentationTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InstrumentationTypeApi
            //Assert.IsInstanceOfType(typeof(InstrumentationTypeApi), instance, "instance is a InstrumentationTypeApi");
        }

        /// <summary>
        /// Test CreateInstrumentationType
        /// </summary>
        [Test]
        public void CreateInstrumentationTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InstrumentationTypeRequest body = null;
            //var response = instance.CreateInstrumentationType(body);
            //Assert.IsInstanceOf<InstrumentationTypeResponse> (response, "response is InstrumentationTypeResponse");
        }
        /// <summary>
        /// Test DeleteInstrumentationType
        /// </summary>
        [Test]
        public void DeleteInstrumentationTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteInstrumentationType(id);
            
        }
        /// <summary>
        /// Test GetInstrumentationIdType
        /// </summary>
        [Test]
        public void GetInstrumentationIdTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? instrumentationId = null;
            //string acceptLanguage = null;
            //var response = instance.GetInstrumentationIdType(instrumentationId, acceptLanguage);
            //Assert.IsInstanceOf<InstrumentationTypeResponse> (response, "response is InstrumentationTypeResponse");
        }
        /// <summary>
        /// Test GetInstrumentationTypeById
        /// </summary>
        [Test]
        public void GetInstrumentationTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string include = null;
            //string acceptLanguage = null;
            //var response = instance.GetInstrumentationTypeById(id, include, acceptLanguage);
            //Assert.IsInstanceOf<InstrumentationTypeResponse> (response, "response is InstrumentationTypeResponse");
        }
        /// <summary>
        /// Test GetInstrumentationTypes
        /// </summary>
        [Test]
        public void GetInstrumentationTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string name = null;
            //string code = null;
            //string tenantId = null;
            //string parentId = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetInstrumentationTypes(page, perPage, include, name, code, tenantId, parentId, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<InstrumentationTypes> (response, "response is InstrumentationTypes");
        }
        /// <summary>
        /// Test GetInstrumentationTypesOptions
        /// </summary>
        [Test]
        public void GetInstrumentationTypesOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? instrumentationId = null;
            //int? page = null;
            //int? perPage = null;
            //string tenantId = null;
            //string name = null;
            //string code = null;
            //string acceptLanguage = null;
            //var response = instance.GetInstrumentationTypesOptions(instrumentationId, page, perPage, tenantId, name, code, acceptLanguage);
            //Assert.IsInstanceOf<InstrumentationTypes> (response, "response is InstrumentationTypes");
        }
        /// <summary>
        /// Test UpdateInstrumentationType
        /// </summary>
        [Test]
        public void UpdateInstrumentationTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InstrumentationTypeRequest body = null;
            //long? id = null;
            //string contentLanguage = null;
            //instance.UpdateInstrumentationType(body, id, contentLanguage);
            
        }
    }

}