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
    ///  Class for testing UnitApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UnitApiTests
    {
        private UnitApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UnitApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UnitApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UnitApi
            //Assert.IsInstanceOfType(typeof(UnitApi), instance, "instance is a UnitApi");
        }

        /// <summary>
        /// Test GetUnitById
        /// </summary>
        [Test]
        public void GetUnitByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string include = null;
            //var response = instance.GetUnitById(id, include);
            //Assert.IsInstanceOf<UnitResponse> (response, "response is UnitResponse");
        }
        /// <summary>
        /// Test GetUnits
        /// </summary>
        [Test]
        public void GetUnitsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string code = null;
            //string symbol = null;
            //string name = null;
            //string baseUnitId = null;
            //string orderBy = null;
            //string acceptLanguage = null;
            //var response = instance.GetUnits(page, perPage, include, code, symbol, name, baseUnitId, orderBy, acceptLanguage);
            //Assert.IsInstanceOf<UnitsResponse> (response, "response is UnitsResponse");
        }
    }

}
