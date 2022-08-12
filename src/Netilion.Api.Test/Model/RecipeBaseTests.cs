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
    ///  Class for testing RecipeBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RecipeBaseTests
    {
        // TODO uncomment below to declare an instance variable for RecipeBase
        //private RecipeBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RecipeBase
            //instance = new RecipeBase();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecipeBase
        /// </summary>
        [Test]
        public void RecipeBaseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RecipeBase
            //Assert.IsInstanceOfType<RecipeBase> (instance, "variable 'instance' is a RecipeBase");
        }

        /// <summary>
        /// Test deserialize a RecipeResponse from type RecipeBase
        /// </summary>
        [Test]
        public void RecipeResponseDeserializeFromRecipeBaseTest()
        {
            // TODO uncomment below to test deserialize a RecipeResponse from type RecipeBase
            //Assert.IsInstanceOf<RecipeBase>(JsonConvert.DeserializeObject<RecipeBase>(new RecipeResponse().ToJson()));
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
