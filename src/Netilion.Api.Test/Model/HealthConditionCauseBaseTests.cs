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
    ///  Class for testing HealthConditionCauseBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HealthConditionCauseBaseTests
    {
        // TODO uncomment below to declare an instance variable for HealthConditionCauseBase
        //private HealthConditionCauseBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HealthConditionCauseBase
            //instance = new HealthConditionCauseBase();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HealthConditionCauseBase
        /// </summary>
        [Test]
        public void HealthConditionCauseBaseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HealthConditionCauseBase
            //Assert.IsInstanceOfType<HealthConditionCauseBase> (instance, "variable 'instance' is a HealthConditionCauseBase");
        }

        /// <summary>
        /// Test deserialize a HealthConditionCauseRequest from type HealthConditionCauseBase
        /// </summary>
        [Test]
        public void HealthConditionCauseRequestDeserializeFromHealthConditionCauseBaseTest()
        {
            // TODO uncomment below to test deserialize a HealthConditionCauseRequest from type HealthConditionCauseBase
            //Assert.IsInstanceOf<HealthConditionCauseBase>(JsonConvert.DeserializeObject<HealthConditionCauseBase>(new HealthConditionCauseRequest().ToJson()));
        }
        /// <summary>
        /// Test deserialize a HealthConditionCauseResponse from type HealthConditionCauseBase
        /// </summary>
        [Test]
        public void HealthConditionCauseResponseDeserializeFromHealthConditionCauseBaseTest()
        {
            // TODO uncomment below to test deserialize a HealthConditionCauseResponse from type HealthConditionCauseBase
            //Assert.IsInstanceOf<HealthConditionCauseBase>(JsonConvert.DeserializeObject<HealthConditionCauseBase>(new HealthConditionCauseResponse().ToJson()));
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }

    }

}
