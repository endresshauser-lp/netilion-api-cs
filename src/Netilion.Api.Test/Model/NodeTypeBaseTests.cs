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
    ///  Class for testing NodeTypeBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class NodeTypeBaseTests
    {
        // TODO uncomment below to declare an instance variable for NodeTypeBase
        //private NodeTypeBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NodeTypeBase
            //instance = new NodeTypeBase();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NodeTypeBase
        /// </summary>
        [Test]
        public void NodeTypeBaseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NodeTypeBase
            //Assert.IsInstanceOfType<NodeTypeBase> (instance, "variable 'instance' is a NodeTypeBase");
        }

        /// <summary>
        /// Test deserialize a NodeTypeResponse from type NodeTypeBase
        /// </summary>
        [Test]
        public void NodeTypeResponseDeserializeFromNodeTypeBaseTest()
        {
            // TODO uncomment below to test deserialize a NodeTypeResponse from type NodeTypeBase
            //Assert.IsInstanceOf<NodeTypeBase>(JsonConvert.DeserializeObject<NodeTypeBase>(new NodeTypeResponse().ToJson()));
        }
        /// <summary>
        /// Test deserialize a NodeTypeRequest from type NodeTypeBase
        /// </summary>
        [Test]
        public void NodeTypeRequestDeserializeFromNodeTypeBaseTest()
        {
            // TODO uncomment below to test deserialize a NodeTypeRequest from type NodeTypeBase
            //Assert.IsInstanceOf<NodeTypeBase>(JsonConvert.DeserializeObject<NodeTypeBase>(new NodeTypeRequest().ToJson()));
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

    }

}
