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
    ///  Class for testing APIKeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class APIKeyApiTests
    {
        private APIKeyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new APIKeyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of APIKeyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' APIKeyApi
            //Assert.IsInstanceOfType(typeof(APIKeyApi), instance, "instance is a APIKeyApi");
        }

        /// <summary>
        /// Test CreateAPIKey
        /// </summary>
        [Test]
        public void CreateAPIKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //APIKeyRequest body = null;
            //var response = instance.CreateAPIKey(body);
            //Assert.IsInstanceOf<APIKeyResponse> (response, "response is APIKeyResponse");
        }
        /// <summary>
        /// Test DeleteAPIKey
        /// </summary>
        [Test]
        public void DeleteAPIKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteAPIKey(id);
            
        }
        /// <summary>
        /// Test GetAPIKeyById
        /// </summary>
        [Test]
        public void GetAPIKeyByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetAPIKeyById(id);
            //Assert.IsInstanceOf<APIKeyResponse> (response, "response is APIKeyResponse");
        }
        /// <summary>
        /// Test GetAPIKeys
        /// </summary>
        [Test]
        public void GetAPIKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string apiKey = null;
            //DateTime? validFrom = null;
            //DateTime? validFromFrom = null;
            //DateTime? validFromTo = null;
            //DateTime? validUntil = null;
            //DateTime? validUntilFrom = null;
            //DateTime? validUntilTo = null;
            //string orderBy = null;
            //var response = instance.GetAPIKeys(page, perPage, apiKey, validFrom, validFromFrom, validFromTo, validUntil, validUntilFrom, validUntilTo, orderBy);
            //Assert.IsInstanceOf<APIKeysResponse> (response, "response is APIKeysResponse");
        }
        /// <summary>
        /// Test UpdateAPIKey
        /// </summary>
        [Test]
        public void UpdateAPIKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //APIKeyRequest body = null;
            //long? id = null;
            //instance.UpdateAPIKey(body, id);
            
        }
    }

}
