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
    ///  Class for testing SoftwareApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SoftwareApiTests
    {
        private SoftwareApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SoftwareApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SoftwareApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SoftwareApi
            //Assert.IsInstanceOfType(typeof(SoftwareApi), instance, "instance is a SoftwareApi");
        }

        /// <summary>
        /// Test CreateSoftware
        /// </summary>
        [Test]
        public void CreateSoftwareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SoftwareRequestPost body = null;
            //var response = instance.CreateSoftware(body);
            //Assert.IsInstanceOf<SoftwareResponse> (response, "response is SoftwareResponse");
        }
        /// <summary>
        /// Test DeleteSoftware
        /// </summary>
        [Test]
        public void DeleteSoftwareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteSoftware(id);
            
        }
        /// <summary>
        /// Test GetSoftwareAttachmentsOfSoftware
        /// </summary>
        [Test]
        public void GetSoftwareAttachmentsOfSoftwareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? softwareId = null;
            //int? page = null;
            //int? perPage = null;
            //string remarks = null;
            //string fileName = null;
            //string orderBy = null;
            //var response = instance.GetSoftwareAttachmentsOfSoftware(softwareId, page, perPage, remarks, fileName, orderBy);
            //Assert.IsInstanceOf<SoftwareAttachmentsResponse> (response, "response is SoftwareAttachmentsResponse");
        }
        /// <summary>
        /// Test GetSoftwareById
        /// </summary>
        [Test]
        public void GetSoftwareByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string include = null;
            //string acceptLanguage = null;
            //var response = instance.GetSoftwareById(id, include, acceptLanguage);
            //Assert.IsInstanceOf<SoftwareResponse> (response, "response is SoftwareResponse");
        }
        /// <summary>
        /// Test GetSoftwares
        /// </summary>
        [Test]
        public void GetSoftwaresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string softwareTypeId = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetSoftwares(page, perPage, include, softwareTypeId, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<SoftwaresResponse> (response, "response is SoftwaresResponse");
        }
        /// <summary>
        /// Test UpdateSoftware
        /// </summary>
        [Test]
        public void UpdateSoftwareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SoftwareRequestPatch body = null;
            //long? id = null;
            //string contentLanguage = null;
            //instance.UpdateSoftware(body, id, contentLanguage);
            
        }
    }

}
