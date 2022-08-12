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
    ///  Class for testing DeliveryBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DeliveryBaseTests
    {
        // TODO uncomment below to declare an instance variable for DeliveryBase
        //private DeliveryBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DeliveryBase
            //instance = new DeliveryBase();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DeliveryBase
        /// </summary>
        [Test]
        public void DeliveryBaseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DeliveryBase
            //Assert.IsInstanceOfType<DeliveryBase> (instance, "variable 'instance' is a DeliveryBase");
        }

        /// <summary>
        /// Test deserialize a DeliveryResponse from type DeliveryBase
        /// </summary>
        [Test]
        public void DeliveryResponseDeserializeFromDeliveryBaseTest()
        {
            // TODO uncomment below to test deserialize a DeliveryResponse from type DeliveryBase
            //Assert.IsInstanceOf<DeliveryBase>(JsonConvert.DeserializeObject<DeliveryBase>(new DeliveryResponse().ToJson()));
        }
        /// <summary>
        /// Test deserialize a DeliveryRequest from type DeliveryBase
        /// </summary>
        [Test]
        public void DeliveryRequestDeserializeFromDeliveryBaseTest()
        {
            // TODO uncomment below to test deserialize a DeliveryRequest from type DeliveryBase
            //Assert.IsInstanceOf<DeliveryBase>(JsonConvert.DeserializeObject<DeliveryBase>(new DeliveryRequest().ToJson()));
        }

        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'CustomerNumber'
        /// </summary>
        [Test]
        public void CustomerNumberTest()
        {
            // TODO unit test for the property 'CustomerNumber'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'DateOfShipment'
        /// </summary>
        [Test]
        public void DateOfShipmentTest()
        {
            // TODO unit test for the property 'DateOfShipment'
        }

    }

}