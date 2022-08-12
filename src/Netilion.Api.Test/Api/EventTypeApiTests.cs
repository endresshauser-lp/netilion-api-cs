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
    ///  Class for testing EventTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EventTypeApiTests
    {
        private EventTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EventTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EventTypeApi
            //Assert.IsInstanceOfType(typeof(EventTypeApi), instance, "instance is a EventTypeApi");
        }

        /// <summary>
        /// Test CreateEventType
        /// </summary>
        [Test]
        public void CreateEventTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EventTypeRequest body = null;
            //var response = instance.CreateEventType(body);
            //Assert.IsInstanceOf<EventTypeResponse> (response, "response is EventTypeResponse");
        }
        /// <summary>
        /// Test DeleteEventType
        /// </summary>
        [Test]
        public void DeleteEventTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteEventType(id);
            
        }
        /// <summary>
        /// Test GetEventIdType
        /// </summary>
        [Test]
        public void GetEventIdTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? eventId = null;
            //string acceptLanguage = null;
            //var response = instance.GetEventIdType(eventId, acceptLanguage);
            //Assert.IsInstanceOf<EventTypeResponse> (response, "response is EventTypeResponse");
        }
        /// <summary>
        /// Test GetEventTypeById
        /// </summary>
        [Test]
        public void GetEventTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string acceptLanguage = null;
            //var response = instance.GetEventTypeById(id, acceptLanguage);
            //Assert.IsInstanceOf<EventTypeResponse> (response, "response is EventTypeResponse");
        }
        /// <summary>
        /// Test GetEventTypeesOptions
        /// </summary>
        [Test]
        public void GetEventTypeesOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? eventId = null;
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string code = null;
            //string tenantId = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetEventTypeesOptions(eventId, page, perPage, name, code, tenantId, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<EventTypes> (response, "response is EventTypes");
        }
        /// <summary>
        /// Test GetEventTypes
        /// </summary>
        [Test]
        public void GetEventTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string code = null;
            //string name = null;
            //string tenantId = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetEventTypes(page, perPage, code, name, tenantId, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<EventTypes> (response, "response is EventTypes");
        }
        /// <summary>
        /// Test UpdateEventType
        /// </summary>
        [Test]
        public void UpdateEventTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EventTypeRequest body = null;
            //long? id = null;
            //string contentLanguage = null;
            //instance.UpdateEventType(body, id, contentLanguage);
            
        }
    }

}