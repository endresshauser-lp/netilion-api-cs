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
    ///  Class for testing DocumentBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DocumentBaseTests
    {
        // TODO uncomment below to declare an instance variable for DocumentBase
        //private DocumentBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DocumentBase
            //instance = new DocumentBase();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentBase
        /// </summary>
        [Test]
        public void DocumentBaseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DocumentBase
            //Assert.IsInstanceOfType<DocumentBase> (instance, "variable 'instance' is a DocumentBase");
        }

        /// <summary>
        /// Test deserialize a DocumentResponse from type DocumentBase
        /// </summary>
        [Test]
        public void DocumentResponseDeserializeFromDocumentBaseTest()
        {
            // TODO uncomment below to test deserialize a DocumentResponse from type DocumentBase
            //Assert.IsInstanceOf<DocumentBase>(JsonConvert.DeserializeObject<DocumentBase>(new DocumentResponse().ToJson()));
        }
        /// <summary>
        /// Test deserialize a DocumentRequest from type DocumentBase
        /// </summary>
        [Test]
        public void DocumentRequestDeserializeFromDocumentBaseTest()
        {
            // TODO uncomment below to test deserialize a DocumentRequest from type DocumentBase
            //Assert.IsInstanceOf<DocumentBase>(JsonConvert.DeserializeObject<DocumentBase>(new DocumentRequest().ToJson()));
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
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'DocumentVersion'
        /// </summary>
        [Test]
        public void DocumentVersionTest()
        {
            // TODO unit test for the property 'DocumentVersion'
        }
        /// <summary>
        /// Test the property 'ValidFrom'
        /// </summary>
        [Test]
        public void ValidFromTest()
        {
            // TODO unit test for the property 'ValidFrom'
        }
        /// <summary>
        /// Test the property 'ValidUntil'
        /// </summary>
        [Test]
        public void ValidUntilTest()
        {
            // TODO unit test for the property 'ValidUntil'
        }

    }

}
