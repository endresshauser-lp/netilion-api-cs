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
    ///  Class for testing HealthConditionRemedyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class HealthConditionRemedyApiTests
    {
        private HealthConditionRemedyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HealthConditionRemedyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HealthConditionRemedyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HealthConditionRemedyApi
            //Assert.IsInstanceOfType(typeof(HealthConditionRemedyApi), instance, "instance is a HealthConditionRemedyApi");
        }

        /// <summary>
        /// Test CreateHealthConditionRemedy
        /// </summary>
        [Test]
        public void CreateHealthConditionRemedyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //HealthConditionRemedyRequest body = null;
            //long? healthConditionId = null;
            //long? causeId = null;
            //var response = instance.CreateHealthConditionRemedy(body, healthConditionId, causeId);
            //Assert.IsInstanceOf<HealthConditionRemedyResponse> (response, "response is HealthConditionRemedyResponse");
        }
        /// <summary>
        /// Test DeleteHealthConditionRemedy
        /// </summary>
        [Test]
        public void DeleteHealthConditionRemedyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? healthConditionId = null;
            //long? causeId = null;
            //long? id = null;
            //instance.DeleteHealthConditionRemedy(healthConditionId, causeId, id);
            
        }
        /// <summary>
        /// Test GetHealthConditionRemedies
        /// </summary>
        [Test]
        public void GetHealthConditionRemediesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? healthConditionId = null;
            //long? causeId = null;
            //int? page = null;
            //int? perPage = null;
            //string code = null;
            //string description = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetHealthConditionRemedies(healthConditionId, causeId, page, perPage, code, description, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<Remedies> (response, "response is Remedies");
        }
        /// <summary>
        /// Test GetHealthConditionRemedyById
        /// </summary>
        [Test]
        public void GetHealthConditionRemedyByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? healthConditionId = null;
            //long? causeId = null;
            //long? id = null;
            //string acceptLanguage = null;
            //var response = instance.GetHealthConditionRemedyById(healthConditionId, causeId, id, acceptLanguage);
            //Assert.IsInstanceOf<HealthConditionRemedyResponse> (response, "response is HealthConditionRemedyResponse");
        }
        /// <summary>
        /// Test UpdateHealthConditionRemedy
        /// </summary>
        [Test]
        public void UpdateHealthConditionRemedyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //HealthConditionRemedyRequest body = null;
            //long? healthConditionId = null;
            //long? causeId = null;
            //long? id = null;
            //string contentLanguage = null;
            //instance.UpdateHealthConditionRemedy(body, healthConditionId, causeId, id, contentLanguage);
            
        }
    }

}
