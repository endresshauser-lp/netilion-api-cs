/* 
 * Netilion API Documentation
 *
 * Welcome to the Netilion API Documentation, which provides interactive access and documentation to our REST API. Please visit our developer portal for further instructions and information: https://developer.netilion.endress.com/ 
 *
 * OpenAPI spec version: 01.00.00
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Netilion.Api.Api;
using Netilion.Api.Model;
using Netilion.Api.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Netilion.Api.Test
{
    /// <summary>
    ///  Class for testing WebhookBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class WebhookBaseTests
    {
        // TODO uncomment below to declare an instance variable for WebhookBase
        //private WebhookBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of WebhookBase
            //instance = new WebhookBase();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WebhookBase
        /// </summary>
        [Test]
        public void WebhookBaseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" WebhookBase
            //Assert.IsInstanceOfType<WebhookBase> (instance, "variable 'instance' is a WebhookBase");
        }

        /// <summary>
        /// Test deserialize a WebhookRequest from type WebhookBase
        /// </summary>
        [Test]
        public void WebhookRequestDeserializeFromWebhookBaseTest()
        {
            // TODO uncomment below to test deserialize a WebhookRequest from type WebhookBase
            //Assert.IsInstanceOf<WebhookBase>(JsonConvert.DeserializeObject<WebhookBase>(new WebhookRequest().ToJson()));
        }

        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Test]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'EventTypes'
        /// </summary>
        [Test]
        public void EventTypesTest()
        {
            // TODO unit test for the property 'EventTypes'
        }
        /// <summary>
        /// Test the property 'Properties'
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            // TODO unit test for the property 'Properties'
        }
        /// <summary>
        /// Test the property 'Disabled'
        /// </summary>
        [Test]
        public void DisabledTest()
        {
            // TODO unit test for the property 'Disabled'
        }

    }

}