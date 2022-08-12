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
    ///  Class for testing CompanyBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CompanyBaseTests
    {
        // TODO uncomment below to declare an instance variable for CompanyBase
        //private CompanyBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CompanyBase
            //instance = new CompanyBase();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompanyBase
        /// </summary>
        [Test]
        public void CompanyBaseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CompanyBase
            //Assert.IsInstanceOfType<CompanyBase> (instance, "variable 'instance' is a CompanyBase");
        }

        /// <summary>
        /// Test deserialize a CompanyResponse from type CompanyBase
        /// </summary>
        [Test]
        public void CompanyResponseDeserializeFromCompanyBaseTest()
        {
            // TODO uncomment below to test deserialize a CompanyResponse from type CompanyBase
            //Assert.IsInstanceOf<CompanyBase>(JsonConvert.DeserializeObject<CompanyBase>(new CompanyResponse().ToJson()));
        }
        /// <summary>
        /// Test deserialize a CompanyRequest from type CompanyBase
        /// </summary>
        [Test]
        public void CompanyRequestDeserializeFromCompanyBaseTest()
        {
            // TODO uncomment below to test deserialize a CompanyRequest from type CompanyBase
            //Assert.IsInstanceOf<CompanyBase>(JsonConvert.DeserializeObject<CompanyBase>(new CompanyRequest().ToJson()));
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
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Parent'
        /// </summary>
        [Test]
        public void ParentTest()
        {
            // TODO unit test for the property 'Parent'
        }

    }

}